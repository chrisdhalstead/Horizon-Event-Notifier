Imports System.Management
Imports System.Data.SqlClient
Imports System.Net.Mail

Public Class Form1

    Public nitem As New ListViewItem
    Public bsilent As Boolean = False
    Public aevents As New ArrayList
    Public lvwColumnSorter As New Horizon_View_Events.ListViewColumnSorter
    Public bauditfail As Boolean
    Public bwarning As Boolean
    Public berror As Boolean
    Public smailerror As String
    Private Structure Args
        Dim sSilent As String
    End Structure
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'populate settings

        Dim acmd As Array = System.Environment.GetCommandLineArgs

        Dim item As String

        For Each item In acmd

            ' MsgBox(item)

        Next

        If UBound(acmd) = 1 Then

            If LCase(acmd(1)) = "\silent" Then

                txtSQLServer.Text = My.Settings.SQLServer
                txtSQLUsername.Text = My.Settings.SQL_Username
                txtSQLpw.Text = AES_Decrypt(My.Settings.SQL_Password, "VMware")
                txtalertrecipients.Text = My.Settings.Alert_Recipients
                txtPrefix.Text = My.Settings.TablePrefix
                txtdb.Text = My.Settings.DBName
                txtsmtpserver.Text = My.Settings.SMTPServer
                txtsmtpport.Text = My.Settings.SMTPPort
                chkAuditFail.Checked = My.Settings.AlertAF
                ChkWarning.Checked = My.Settings.AlertWarning
                ChkError.Checked = My.Settings.AlertError
                txtSendFrom.Text = My.Settings.SendFrom
                txtdb.Text = My.Settings.DBName
                txtTime.Text = My.Settings.Time
                sslabel.Text = "Running"
                NotifyIcon1.BalloonTipText = "Horizon View Events Notifier - RUNNING"
                NotifyIcon1.ShowBalloonTip(50)
                execute_events()
                btn_Start.Text = "Stop"
                Timer1.Enabled = True

                bsilent = True

            End If

        Else

            txtSQLServer.Text = My.Settings.SQLServer
            txtSQLUsername.Text = My.Settings.SQL_Username
            txtSQLpw.Text = AES_Decrypt(My.Settings.SQL_Password, "VMware")
            txtalertrecipients.Text = My.Settings.Alert_Recipients
            txtsmtpserver.Text = My.Settings.SMTPServer
            txtsmtpport.Text = My.Settings.SMTPPort
            txtPrefix.Text = My.Settings.TablePrefix
            txtdb.Text = My.Settings.DBName
            chkAuditFail.Checked = My.Settings.AlertAF
            ChkWarning.Checked = My.Settings.AlertWarning
            ChkError.Checked = My.Settings.AlertError
            txtSendFrom.Text = My.Settings.SendFrom
            txtdb.Text = My.Settings.DBName
            txtTime.Text = My.Settings.Time
            sslabel.Text = "Idle"

        End If

        If bsilent = True Then

            Me.Hide()
            Me.ShowInTaskbar = False

        End If
       

    End Sub

    Sub Send_Mail(ByVal btest)

        Dim smail As New System.Net.Mail.SmtpClient(My.Settings.Item("smtpserver"))

        Dim omessage As New MailMessage
        omessage.From = New MailAddress("chrisdhalstead@gmail.com")
        omessage.To.Add(New MailAddress("chrisdhalstead@gmail.com"))
        omessage.Subject = "TEST"
        omessage.Body = "This is a test email from the Horizon View Event Notifier Application"

        smail.Send(omessage)

    End Sub


    Sub execute_events()

        sslabel.Text = "Running"

        Dim sdb As String = My.Settings.DBName
        Dim stime As String = My.Settings.Time
        Dim spt As String = My.Settings.TablePrefix

        If My.Settings.AlertAF = True Then

            get_events("select * from " & sdb & ".dbo." & spt & "event where Severity = 'AUDIT_FAIL' and DATEDIFF(n,CAST(time as datetime),GETDATE())<=" & stime & "")

        End If

        If My.Settings.AlertError = True Then

            get_events("select * from " & sdb & ".dbo." & spt & "event where Severity = 'ERROR' and DATEDIFF(n,CAST(time as datetime),GETDATE())<=" & stime & "")

        End If

        If My.Settings.AlertWarning = True Then

            get_events("select * from " & sdb & ".dbo." & spt & "event where Severity = 'WARNING' and DATEDIFF(n,CAST(time as datetime),GETDATE())<=" & stime & "")

        End If

    End Sub



    Sub get_events(ByVal sstring As String)

        Dim ssqlserver As String = My.Settings("sqlserver")
        Dim ssqlusername As String = My.Settings("sql_username")
        Dim ssqlpw As String = AES_Decrypt(My.Settings("sql_password"), "VMware")
        Dim sdb As String = My.Settings.DBName

        Dim dataconn As New SqlConnection("Data Source=" & ssqlserver & ";uid=" & ssqlusername & ";pwd=" & ssqlpw & ";Initial Catalog=" & sdb)

        Try
            dataconn.Open()

        Catch ex As Exception

            MsgBox("Error Connecting to SQL DB - Please check connectivity", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL Connection Error")

            End


        End Try



        Dim sseverity As String
        Dim sevent As String

        Dim myCommand As New SqlCommand(sstring, dataconn)

        Dim reader As SqlDataReader = myCommand.ExecuteReader()

        Console.WriteLine(reader.Read)

        If reader.HasRows = True Then

            While reader.Read()

                Console.WriteLine(reader.Item("severity") & "|" & reader.Item("EventType") & "|" & reader.Item("Moduleandeventtext"))

                sseverity = reader.Item("severity")
                Dim sdate As DateTime = reader.Item("time")
                sevent = reader.Item("Moduleandeventtext")
                Dim sserver As String = reader.Item("node")

                If aevents.Contains(reader.Item("eventid")) Then

                    'skip - already processed


                Else
                    aevents.Add(reader.Item("eventid"))
                    nitem = lstEvents.Items.Add(sdate.ToString)

                    nitem.UseItemStyleForSubItems = False

                    nitem.SubItems.Add(sseverity)
                    nitem.SubItems.Add(sevent)

                    If send_email(sevent, sseverity, sserver, reader.Item("eventid")) = "Sent" Then


                        nitem.SubItems.Add("Sent")

                    Else

                        nitem.SubItems.Add(smailerror)

                    End If



                End If

            End While

            ' Call Close when done reading.
            reader.Close()


        Else

            Console.WriteLine("no")


        End If

        Me.lstEvents.ListViewItemSorter = lvwColumnSorter
        lvwColumnSorter.SortColumn = 0
        lvwColumnSorter.Order = SortOrder.Descending
        Me.lstEvents.Sort()

        dataconn.Close()

    End Sub

    Private Sub ReadSingleRow(ByVal record As IDataRecord)

        Console.WriteLine(String.Format("{0}, {1}", record(0), record(1)))

    End Sub


    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String

        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try

    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function



    Private Sub btnSaveSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSQL.Click

        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        End If

        My.Settings.TablePrefix = txtPrefix.Text
        My.Settings.Item("sqlserver") = txtSQLServer.Text
        My.Settings.Item("sql_username") = txtSQLUsername.Text
        My.Settings.Item("sql_password") = AES_Encrypt(txtSQLpw.Text, "VMware")
        My.Settings.DBName = txtdb.Text

        My.Settings.Save()

        MsgBox("Settings saved", MsgBoxStyle.Information, "Changes Saved")

    End Sub


    Private Sub btnTestSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestSQL.Click

        If My.Settings.SQLServer = "" Then

            MsgBox("Please update and save SQL Server Information", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Settings")

            Exit Sub

        End If

        Dim ssqlserver As String = My.Settings("sqlserver")
        Dim ssqlusername As String = My.Settings("sql_username")
        Dim ssqlpw As String = AES_Decrypt(My.Settings("sql_password"), "VMware")
        Dim sdb As String = My.Settings.DBName


        Dim dataconn As New SqlConnection("Data Source=" & ssqlserver & ";uid=" & ssqlusername & ";pwd=" & ssqlpw & ";Initial Catalog=" & sdb)

        Try

            dataconn.Open()

        Catch ex As Data.SqlClient.SqlException

            MsgBox("Cannot connect to SQL Server.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Test SQL Connection")

            Exit Sub

        End Try

        MsgBox("Successfully Connected to SQL Server", MsgBoxStyle.Information)


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAuditFail.CheckedChanged

    End Sub


    Private Sub btnSaveSMTP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSMTP.Click

        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        End If

        My.Settings.Item("smtpserver") = txtsmtpserver.Text
        My.Settings.Item("smtpport") = txtsmtpport.Text
        My.Settings.Item("alert_recipients") = txtalertrecipients.Text
        My.Settings.SendFrom = txtSendFrom.Text

        My.Settings.Save()

        MsgBox("Settings saved", MsgBoxStyle.Information, "Changes Saved")


    End Sub


    Private Sub btn_Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Start.Click

        If My.Settings.SQLServer = "" Then

            MsgBox("Please update and save SQL Server Information", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Settings")

            Exit Sub

        End If

        If btn_Start.Text = "Start" Then

            execute_events()
            btn_Start.Text = "Stop"
            Timer1.Enabled = True

            NotifyIcon1.BalloonTipText = "Horizon View Events Notifier - RUNNING"
            NotifyIcon1.ShowBalloonTip(50)

        Else

            btn_Start.Text = "Start"
            Timer1.Enabled = False
            sslabel.Text = "Idle"

            NotifyIcon1.BalloonTipText = "Horizon View Events Notifier - STOPPED"
            NotifyIcon1.ShowBalloonTip(50)

        End If


    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        execute_events()


    End Sub

 
    Private Sub btn_Events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Events.Click

        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        End If

        My.Settings.AlertAF = chkAuditFail.CheckState
        My.Settings.AlertError = ChkError.CheckState
        My.Settings.AlertWarning = ChkWarning.CheckState
        My.Settings.Time = txtTime.Text

        My.Settings.Save()

        MsgBox("Settings saved", MsgBoxStyle.Information, "Changes Saved")

    End Sub

    Private Sub btn_Reload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Reload.Click

        My.Settings.TablePrefix = txtPrefix.Text
        txtSQLServer.Text = My.Settings.SQLServer
        txtSQLUsername.Text = My.Settings.SQL_Username
        txtSQLpw.Text = AES_Decrypt(My.Settings.SQL_Password, "VMware")
        txtalertrecipients.Text = My.Settings.Alert_Recipients
        txtsmtpserver.Text = My.Settings.SMTPServer
        txtsmtpport.Text = My.Settings.SMTPPort
        chkAuditFail.Checked = My.Settings.AlertAF
        ChkWarning.Checked = My.Settings.AlertWarning
        ChkError.Checked = My.Settings.AlertError
        txtSendFrom.Text = My.Settings.SendFrom
        txtTime.Text = My.Settings.Time
        txtdb.Text = My.Settings.DBName

        MsgBox("Data Reloaded", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Data Reloaded")

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            'NotifyIcon1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.WindowState = FormWindowState.Minimized
                NotifyIcon1.Visible = True
                NotifyIcon1.BalloonTipText = "Horizon View Event Notifier - Running"
                Me.Hide()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Function send_email(ByVal serror As String, ByVal spriority As String, ByVal sserver As String, ByVal seventid As String) As String

        Dim smail As New System.Net.Mail.SmtpClient(My.Settings.SMTPServer, My.Settings.SMTPPort)

        Dim omessage As New MailMessage
        omessage.From = New MailAddress(My.Settings.SendFrom)
        omessage.To.Add(My.Settings.Alert_Recipients)
        omessage.Subject = spriority & " Alert from " & sserver
        omessage.Body = serror

        Try

            smail.Send(omessage)

        Catch ex As Exception

            smailerror = ex.Message
            Return ex.Message

            Exit Function

        End Try

        Return "Sent"
        'aevents.Remove(seventid)


    End Function



    Private Sub btnEmailTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmailTest.Click

        Dim smail As New System.Net.Mail.SmtpClient(My.Settings.SMTPServer, My.Settings.SMTPPort)

        Dim omessage As New MailMessage
        omessage.From = New MailAddress(My.Settings.SendFrom)
        omessage.To.Add(My.Settings.Alert_Recipients)
        omessage.Subject = "TEST Message"
        omessage.Body = "This is a test email from the Horizon View Event Notifier Application"

        Try

            smail.Send(omessage)

        Catch ex As Exception

            MsgBox("Error Sending: " & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error Sending")

            Exit Sub

        End Try

        MsgBox("Message Sent", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sent")

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.Yes Then

            End

        Else



        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        MsgBox("Horizon View Event Notifier" & vbCrLf & "Chris Halstead - @chrisdhalstead" & vbCrLf & "ChrisdHalstead@gmail.com" & vbCrLf & "Version: " & My.Application.Info.Version.ToString, MsgBoxStyle.Information+MsgBoxStyle.OkOnly, "About")

    End Sub

    Private Sub lstEvents_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lstEvents.ColumnClick

        ' Determine if the clicked column is already the column that is
        ' being sorted.
        If (e.Column = lvwColumnSorter.SortColumn) Then
            ' Reverse the current sort direction for this column.
            If (lvwColumnSorter.Order = SortOrder.Ascending) Then
                lvwColumnSorter.Order = SortOrder.Descending
            Else
                lvwColumnSorter.Order = SortOrder.Ascending
            End If
        Else
            ' Set the column number that is to be sorted; default to ascending.
            lvwColumnSorter.SortColumn = e.Column
            lvwColumnSorter.Order = SortOrder.Ascending
        End If

        ' Perform the sort with these new sort options.
        Me.lstEvents.Sort()



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        If MsgBox("Are you sure you want to clear all current events?", MsgBoxStyle.YesNo, "Clear Events?") = MsgBoxResult.Yes Then

            lstEvents.Items.Clear()

        Else


        End If

    End Sub

    Private Sub lstEvents_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstEvents.SelectedIndexChanged


    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub ContextMenuStrip1_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub txtRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefresh.Click

        execute_events()

    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click

        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.Yes Then

            End

        Else

        End If


    End Sub

    Private Sub ResToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResToolStripMenuItem.Click

        Try
            Me.Show()
            Me.WindowState = FormWindowState.Normal
            'NotifyIcon1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
