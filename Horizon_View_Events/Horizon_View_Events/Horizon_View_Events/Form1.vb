Imports System.Management
Imports System.Data.SqlClient
Imports System.Net.Mail
Imports System.Text
Imports Horizon_View_Event_Notifier.crypto
Imports System.Configuration
Imports Horizon_View_Event_Notifier.encrypt_config
Imports System.Xml
Imports Horizon_View_Event_Notifier.ListViewColumnSorter
Imports Horizon_View_Event_Notifier.RandomKeyGenerator

Public Class Form1
    Const cAuditFail = "AUDIT_FAIL"
    Const cError = "ERROR"
    Const cWarning = "WARNING"
    Const cInfo = "INFO"
    Public nitem As New ListViewItem
    Public bsilent As Boolean = False
    Public aevents As New ArrayList
    Public lvwColumnSorter As New Horizon_View_Event_Notifier.ListViewColumnSorter
    Public bauditfail As Boolean
    Public bwarning As Boolean
    Public berror As Boolean
    Public smailerror As String
    Public hsqldbs As New Hashtable
    Public bmailerror As Boolean
    Public aeventtypes As New ArrayList
    Public aselectedeventtypes As New ArrayList
    Public bupdatingsql As Boolean = False

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

                lstSQLDbs.Items.Add(txtSQLServer.Text)
                txtalertrecipients.Text = My.Settings.Alert_Recipients
                txtsmtpserver.Text = My.Settings.SMTPServer
                txtsmtpport.Text = My.Settings.SMTPPort
                chkAuditFail.Checked = My.Settings.AlertAF
                ChkWarning.Checked = My.Settings.AlertWarning
                ChkError.Checked = My.Settings.AlertError
                chkInfo.Checked = My.Settings.AlertInfo
                txtSendFrom.Text = My.Settings.SendFrom
                txtTime.Text = My.Settings.Time
                sslabel.Text = "Running"
                NotifyIcon1.BalloonTipText = "Horizon View Event Notifier - RUNNING"
                NotifyIcon1.ShowBalloonTip(50)
                'execute_events()
                btn_Start.Text = "Stop"
                Timer1.Enabled = True

                bsilent = True

            End If

        Else

            pop_sqldbs()

            'hide TabPage3 - this is for a future release
            TabControl1.TabPages.Remove(TabPage3)
            txtalertrecipients.Text = My.Settings.Alert_Recipients
            txtsmtpserver.Text = My.Settings.SMTPServer
            txtsmtpport.Text = My.Settings.SMTPPort
            chkAuditFail.Checked = My.Settings.AlertAF
            ChkWarning.Checked = My.Settings.AlertWarning
            chkInfo.Checked = My.Settings.AlertInfo
            ChkError.Checked = My.Settings.AlertError
            txtSendFrom.Text = My.Settings.SendFrom
            txtTime.Text = My.Settings.Time
            sslabel.Text = "Idle"
            txtpoll.Text = My.Settings.Polling
            chkTestDB.Checked = My.Settings.TestDB

        End If

        If bsilent = True Then

            Me.Hide()
            Me.ShowInTaskbar = False

        End If


        set_tt()

    End Sub

    Sub set_tt()


        Me.ToolTip1.SetToolTip(txtSQLServer, "Please enter the SQL Server name. A port can be specified by using the following syntax: servername,port")


    End Sub


    Sub pop_sqldbs()


        Dim ssqlitem As String
        Dim asql As Array

        hsqldbs.Clear()
        lstSQLDbs.Items.Clear()
        Try
            For Each ssqlitem In My.Settings.SQLSettings

                asql = Split(ssqlitem, "||")

                hsqldbs.Add(asql(0), asql(1))

                lstSQLDbs.Items.Add(asql(0))

            Next

        Catch ex As Exception

            MsgBox("Error: " & ex.Message & vbCrLf & "Please clear SQL settings and try again.", MsgBoxStyle.Exclamation, "Duplicate Entry Detected")

        End Try

    End Sub

    Function build_command_string(ByVal sdb As String, ByVal stp As String) As String

        Dim sstring As String = "select * from " & sdb & ".dbo." & stp & "event where "

        If chkAuditFail.Checked = True Then

            sstring = sstring & " (Severity = @codeaf"

        End If

        If chkInfo.Checked = True Then

            If InStr(sstring, "Severity") > 0 Then

                sstring = sstring & " or Severity = @codeinfo"

            Else

                sstring = sstring & "(Severity = @codeinfo"

            End If

        End If

        If ChkError.Checked = True Then

            If InStr(sstring, "Severity") > 0 Then

                sstring = sstring & " or Severity = @codeerror"

            Else

                sstring = sstring & "(Severity = @codeerror"

            End If

        End If

        If ChkWarning.Checked = True Then

            If InStr(sstring, "Severity") > 0 Then

                sstring = sstring & " or Severity = @codewarning"

            Else

                sstring = sstring & "(Severity = @codewarning"

            End If

        End If

        sstring = sstring & ") and time >=@datequery"

        Return sstring

    End Function


    Sub get_events(ByVal sstring As String, ByVal ssqlserver As String, ByVal ssqlusername As String, ByVal ssqlpw As String, ByVal sdb As String, ByVal stp As String)

        Dim stime As String = My.Settings.Time

        sslabel.Text = "Connecting to: " & ssqlserver & " " & sdb

        ssqlpw = Decrypt_PW(ssqlpw)

        Dim dataconn As New SqlConnection("Data Source=" & ssqlserver & ";uid=" & ssqlusername & ";pwd=" & ssqlpw & ";Initial Catalog=" & sdb)

        Try
            dataconn.Open()

        Catch ex As Exception

            MsgBox("Error Connecting to SQL DB: " & ssqlserver & " - Please check connectivity" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "SQL Connection Error")
            send_email("Error Connecting to SQL Server: " & ssqlserver & vbCrLf & "Error: " & ex.Message, "Connection Error", ssqlserver, 1, "SQL Connection Error", Now)

            Exit Sub

        End Try

        If DoesTableExist(stp & "event", dataconn) = True Then

            'Table and Table Prefix are Valid

        Else

            MsgBox("The Table name and Table Prefix do not exist in the specified database - The application will now exit" & vbCrLf & "SQL Server: " & ssqlserver & vbCrLf & "DB Name: " & sdb & vbCrLf & "Table Prefix: " & stp, MsgBoxStyle.Critical, "Error")
            End

        End If

        Dim sseverity As String
        Dim sevent As String

        If CheckSQLStatement(sstring) = False Then

            MsgBox("The SQL statement appears to have been tampered with - the application will now quit", MsgBoxStyle.Critical, "SQL Injection Detected")

            End

        End If

        Dim myCommand As New SqlCommand()

        With myCommand

            .CommandText = sstring
            .Connection = dataconn
            .Parameters.Add("@codeerror", SqlDbType.NVarChar).Value = cError
            .Parameters.Add("@codeinfo", SqlDbType.NVarChar).Value = cInfo
            .Parameters.Add("@codeaf", SqlDbType.NVarChar).Value = cAuditFail
            .Parameters.Add("@codewarning", SqlDbType.NVarChar).Value = cWarning
            .Parameters.Add("@datequery", SqlDbType.DateTime).Value = date_diff(My.Settings.Time)

        End With

        Try

            Dim reader As SqlDataReader = myCommand.ExecuteReader()

            If reader.HasRows = True Then

                While reader.Read()

                    sseverity = reader.Item("severity")
                    Dim sdate As DateTime = reader.Item("time")
                    sevent = reader.Item("Moduleandeventtext")
                    Dim sserver As String = reader.Item("node")
                    Dim seventid As String = reader.Item("eventid")
                    Dim seventtype As String = reader.Item("EventType")

                    Dim spool As String

                    Try

                        spool = reader.Item("DesktopID")

                    Catch ex As Exception

                        spool = "N/A"

                    End Try

                    If aevents.Contains(reader.Item("eventid")) Then

                        'skip - already processed

                    Else

                        If aevents.Count > 100 Then

                            aevents.RemoveRange(0, 99)

                        End If

                        aevents.Add(reader.Item("eventid"))


                        If send_email(sevent, sseverity, sserver, reader.Item("eventid"), seventtype, sdate) = "Sent" Then

                            'nitem.SubItems.Add("Sent")
                            nitem = lstEvents.Items.Add(sdate.ToString, 0)

                            bmailerror = False

                        Else

                            'nitem.SubItems.Add(smailerror)
                            nitem = lstEvents.Items.Add(sdate.ToString, 1)

                            bmailerror = True

                        End If

                        nitem.SubItems.Add(sserver)

                        'nitem.SubItems.Add(spool)

                        nitem.SubItems.Add(seventtype)

                        nitem.UseItemStyleForSubItems = False

                        nitem.SubItems.Add(sseverity)

                        nitem.SubItems.Add(sevent)

                        nitem.SubItems.Add(reader.Item("eventid"))


                    End If

                End While

                ' Call Close when done reading.
                reader.Close()

            Else

                'No Data

            End If


            Me.lstEvents.ListViewItemSorter = lvwColumnSorter
            lvwColumnSorter.SortColumn = 6
            lvwColumnSorter.Order = SortOrder.Descending
            Me.lstEvents.Sort()

            dataconn.Close()


        Catch ex As Exception

            MsgBox("Error: " & ex.Message)

        End Try

        '**************************************************
        'Below is for future release with event filtering

        'lstallevents.Items.Clear()

        'Dim itemevent As String

        'For Each itemevent In aeventtypes

        'lstallevents.Items.Add(itemevent)

        'Next

        '**********************************************

        lstEvents.ListViewItemSorter = New ListViewColumnSorter
        lstEvents.Sort()
        lstEvents.ListViewItemSorter = Nothing

        sslabel.Text = "Last Queried at: " & Now


    End Sub

    Function date_diff(ByVal stime As String) As DateTime

        Dim dt As DateTime = DateTime.Now
        Return dt.AddMinutes("-" & stime)

    End Function


    Private Sub ReadSingleRow(ByVal record As IDataRecord)

        Console.WriteLine(String.Format("{0}, {1}", record(0), record(1)))

    End Sub

    Private Sub btnSaveSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveSQL.Click

        bupdatingsql = True


        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        Else

            If txtName.Text = "" Then

                MsgBox("Please add a name for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtName.Focus()

                Exit Sub

            End If

            If txtSQLServer.Text = "" Then

                MsgBox("Please add a SQL Server for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLServer.Focus()

                Exit Sub

            End If

            If txtdb.Text = "" Then

                MsgBox("Please add a Database Name for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtdb.Focus()

                Exit Sub

            End If

            If txtSQLUsername.Text = "" Then

                MsgBox("Please add a name for this SQL username for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLUsername.Focus()

                Exit Sub

            End If

            If txtSQLpw.Text = "" Then

                MsgBox("Please add a SQL user password for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLpw.Focus()

                Exit Sub

            End If

            If InStr(txtName.Text, " ") > 0 Then

                MsgBox("There is a space in the name of this settings.  Please remove the space and try again.", MsgBoxStyle.Information, "Space Detected")

                txtName.Text = ""

                txtName.Focus()

                Exit Sub

            End If

            If InStr(txtName.Text, "|") > 0 Then

                MsgBox("There is a pipe in the name of this settings.  Please remove the pipe and try again.", MsgBoxStyle.Information, "Pipe Detected")

                txtName.Text = ""

                txtName.Focus()

                Exit Sub

            End If


            Dim ssqlname As String = ""
            Dim ssqlinfo As String = ""

            For Each item In lstSQLDbs.CheckedItems

                ssqlname = item.SubItems(0).Text

            Next

            My.Settings.TestDB = chkTestDB.CheckState

            Dim snewpw As String = ""

            If Len(txtSQLpw.Text) < 20 Then

                snewpw = Encrypt_PW(txtSQLpw.Text)

                ssqlinfo = txtName.Text & "||" & txtSQLServer.Text & "|" & txtdb.Text & "|" & txtSQLUsername.Text & "|" & snewpw & "|" & txtPrefix.Text

            Else
                snewpw = txtSQLpw.Text

                ssqlinfo = txtName.Text & "||" & txtSQLServer.Text & "|" & txtdb.Text & "|" & txtSQLUsername.Text & "|" & snewpw & "|" & txtPrefix.Text

            End If

            If chkTestDB.CheckState = CheckState.Checked Then

                If check_sql(txtSQLServer.Text, txtSQLUsername.Text, snewpw, txtdb.Text, txtPrefix.Text, True) = False Then

                    MsgBox("DB Connnection Test Failed - Please check settings and try again", MsgBoxStyle.Exclamation, "DB Connection Failed")
                    txtName.Focus()
                    Exit Sub

                End If

            End If

            remove_sqlDb(ssqlname)
            My.Settings.SQLSettings.Add(ssqlinfo)

            My.Settings.Save()

            MsgBox("Settings Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Changes Saved")

            bupdatingsql = False

            pop_sqldbs()

            End If



    End Sub


    Private Sub btnTestSQL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTestSQL.Click

        check_sql(txtSQLServer.Text, txtSQLUsername.Text, txtSQLpw.Text, txtdb.Text, txtPrefix.Text, False)

    End Sub


    Function check_sql(ByVal ssqlserver As String, ByVal ssqlusername As String, ByVal ssqlpw As String, ByVal sdb As String, ByVal stp As String, ByVal silent As Boolean) As Boolean


        Dim dataconn As New SqlConnection("Data Source=" & ssqlserver & ";uid=" & ssqlusername & ";pwd=" & Decrypt_PW(ssqlpw) & ";Initial Catalog=" & sdb)

        Try

            dataconn.Open()

        Catch ex As Data.SqlClient.SqlException

            If bsilent = False Then

                MsgBox("Cannot connect to SQL Server" & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Test SQL Connection")

            End If

            dataconn.Close()

            Return False


            Exit Function

        End Try

        If bsilent = False Then

            If DoesTableExist(stp & "event", dataconn) = True Then

                MsgBox("Successfully Connected to SQL Server: " & txtName.Text, MsgBoxStyle.Information, "Success")
                dataconn.Close()

                Return True

            Else

                MsgBox("Table Prefix is not Valid - please check and try again : " & txtName.Text, MsgBoxStyle.Information, "Error")

                dataconn.Close()

                Return False

            End If




        End If


    End Function

    Sub pop_eventtypes(ByVal sdataconn As System.Data.SqlClient.SqlConnection)

        Dim myeventcommand As New SqlCommand

        With myeventcommand

            .CommandText = "select distinct EventType from view_events.dbo.event"
            .Connection = sdataconn

        End With

        Dim eventreader As SqlDataReader = myeventcommand.ExecuteReader()

        If eventreader.HasRows = True Then

            While eventreader.Read()


                If aeventtypes.Contains(eventreader.Item("EventType")) = False Then

                    aeventtypes.Add(eventreader.Item("EventType"))

                End If
            End While


        End If

        eventreader = Nothing


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

        If hsqldbs.Count = 0 Then

            MsgBox("Please update and save SQL Server Information on the settings tab", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Settings")

            txtName.Focus()

            Exit Sub

        End If

        If My.Settings.SMTPServer = "" Then

            MsgBox("Please update and save SMTP Server Information on the settings tab", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Settings")

            txtsmtpserver.Focus()

            Exit Sub

        End If

        If btn_Start.Text = "Start" Then

            Dim seventdb As String = ""

            For Each seventdb In hsqldbs.Keys

                Dim asql As Array = Split(hsqldbs(seventdb), "|")

                get_events(build_command_string(asql(1), asql(4)), asql(0), asql(2), asql(3), asql(1), asql(4))

            Next

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

        Timer1.Interval = My.Settings.Polling * 1000

        Dim seventdb As String = ""

        For Each seventdb In hsqldbs.Keys

            Dim asql As Array = Split(hsqldbs(seventdb), "|")

            get_events(build_command_string(asql(1), asql(4)), asql(0), asql(2), asql(3), asql(1), asql(4))

        Next


    End Sub


    Private Sub btn_Events_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Events.Click

        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        End If

        My.Settings.AlertAF = chkAuditFail.CheckState
        My.Settings.AlertError = ChkError.CheckState
        My.Settings.AlertWarning = ChkWarning.CheckState
        My.Settings.AlertInfo = chkInfo.CheckState

        My.Settings.Time = txtTime.Text

        My.Settings.Save()

        MsgBox("Settings saved", MsgBoxStyle.Information, "Changes Saved")

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


    Function send_email(ByVal serror As String, ByVal spriority As String, ByVal sserver As String, ByVal seventid As String, ByVal seventtype As String, ByVal sdate As DateTime) As String

        Dim smail As New System.Net.Mail.SmtpClient(My.Settings.SMTPServer, My.Settings.SMTPPort)

        Dim omessage As New MailMessage
        omessage.From = New MailAddress(My.Settings.SendFrom)
        omessage.To.Add(My.Settings.Alert_Recipients)
        omessage.Subject = spriority & " Alert from " & sserver
        omessage.Body = "Date/Time of Event: " & sdate & vbCrLf & vbCrLf & "Event Type: " & seventtype & vbCrLf & vbCrLf & "Event Text: " & serror

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

    Sub reload_settings()

        txtalertrecipients.Text = My.Settings.Alert_Recipients
        txtsmtpserver.Text = My.Settings.SMTPServer
        txtsmtpport.Text = My.Settings.SMTPPort
        chkAuditFail.Checked = My.Settings.AlertAF
        ChkWarning.Checked = My.Settings.AlertWarning
        ChkError.Checked = My.Settings.AlertError
        chkInfo.Checked = My.Settings.AlertInfo
        txtSendFrom.Text = My.Settings.SendFrom
        txtTime.Text = My.Settings.Time

    End Sub


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

            bmailerror = True

            Exit Sub

        End Try

        MsgBox("Message Sent", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Sent")

        bmailerror = False

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click

        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.Yes Then

            End

        Else



        End If

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click

        MsgBox("Horizon View Event Notifier" & vbCrLf & "VMware Labs" & vbCrLf & """https://labs.vmware.com/flings/flings/horizon-view-event-notifier""" & vbCrLf & "Chris Halstead - chalstead@vmware.com" & vbCrLf & "Version: " & My.Application.Info.Version.ToString, MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "About")

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


    Private Sub txtRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRefresh.Click

        Try
            Dim seventdb As String = ""

            For Each seventdb In hsqldbs.Keys

                Dim asql As Array = Split(hsqldbs(seventdb), "|")

                get_events(build_command_string(asql(1), asql(4)), asql(0), asql(2), asql(3), asql(1), asql(4))

            Next

        Catch ex As Exception


        End Try


    End Sub

    Private Sub txtExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExit.Click

        If MsgBox("Are you sure you want to Exit?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Exit?") = MsgBoxResult.Yes Then

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


    Private Sub Form1_FormClosing(ByVal sender As Object, _
                              ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If e.CloseReason = CloseReason.UserClosing Then
            'The user has requested the form be closed so mimimise to the system tray instead.
            e.Cancel = True
            Me.Visible = False
            Me.NotifyIcon1.Visible = True
        End If

    End Sub


    Private Sub cmdAddSQL_Click(sender As Object, e As EventArgs) Handles cmdAddSQL.Click

        bupdatingsql = True

        If Timer1.Enabled = True Then

            MsgBox("Application is running, please stop it before changing settings", MsgBoxStyle.Exclamation, "Application Running")
            Exit Sub

        Else

            If hsqldbs.ContainsKey(txtName.Text) Then

                MsgBox("There is already an entry with the name " & txtName.Text & " please choose a different name and try again.", MsgBoxStyle.Exclamation, "Duplicate Name Detected")
                txtName.Text = ""
                txtName.Focus()

                Exit Sub

            End If

            If txtName.Text = "" Then

                MsgBox("Please add a name for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtName.Focus()

                Exit Sub

            End If

            If txtSQLServer.Text = "" Then

                MsgBox("Please add a SQL Server for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLServer.Focus()

                Exit Sub

            End If

            If txtdb.Text = "" Then

                MsgBox("Please add a Database Name for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtdb.Focus()

                Exit Sub

            End If

            If txtSQLUsername.Text = "" Then

                MsgBox("Please add a name for this SQL username for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLUsername.Focus()

                Exit Sub

            End If

            If txtSQLpw.Text = "" Then

                MsgBox("Please add a SQL user password for this connection", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Missing Data")

                txtSQLpw.Focus()

                Exit Sub

            End If

            If InStr(txtName.Text, " ") > 0 Then

                MsgBox("There is a space in the name of this settings.  Please remove the space and try again.", MsgBoxStyle.Information, "Space Detected")

                txtName.Text = ""

                txtName.Focus()

                Exit Sub

            End If

            If InStr(txtName.Text, "|") > 0 Then

                MsgBox("There is a pipe in the name of this settings.  Please remove the pipe and try again.", MsgBoxStyle.Information, "Pipe Detected")

                txtName.Text = ""

                txtName.Focus()

                Exit Sub

            End If

            My.Settings.TestDB = chkTestDB.CheckState

            Dim ssqlpw As String = Encrypt_PW(txtSQLpw.Text)

            Dim ssqlinfo As String = txtName.Text & "||" & txtSQLServer.Text & "|" & txtdb.Text & "|" & txtSQLUsername.Text & "|" & ssqlpw & "|" & txtPrefix.Text

            If chkTestDB.CheckState = CheckState.Checked Then

                If check_sql(txtSQLServer.Text, txtSQLUsername.Text, ssqlpw, txtdb.Text, txtPrefix.Text, True) = False Then

                    MsgBox("SQL Connection Test Failed - Please check DB settings and try again", MsgBoxStyle.Exclamation, "Connection Failed")
                    txtName.Focus()
                    Exit Sub

                End If

            End If

            My.Settings.SQLSettings.Add(ssqlinfo)

            My.Settings.Save()

            bupdatingsql = False

            pop_sqldbs()

            MsgBox("Settings Saved", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Added DB Settings")



            End If


    End Sub

    Private Sub lstSQLDbs_ItemChecked(sender As Object, e As ItemCheckedEventArgs) Handles lstSQLDbs.ItemChecked


        For Each item In lstSQLDbs.Items
            If Not item.Index = e.Item.Index Then
                item.Checked = False
            End If

        Next

        Dim ssqlname As String = ""
        Dim ssqlsettings As String = ""

        If lstSQLDbs.CheckedItems.Count > 0 Then

            lblInfo.Visible = False
            cmdAddSQL.Enabled = False
            cmdRemoveSQL.Enabled = True
            btnTestSQL.Enabled = True
            btnSaveSQL.Enabled = True

            For Each item In lstSQLDbs.CheckedItems

                ssqlname = item.SubItems(0).Text

            Next

            ssqlsettings = hsqldbs(ssqlname)

            Dim asql As Array = Split(ssqlsettings, "|")

            txtName.Text = ssqlname
            txtSQLServer.Text = asql(0)
            txtdb.Text = asql(1)
            txtSQLUsername.Text = asql(2)
            txtSQLpw.Text = asql(3)
            txtPrefix.Text = asql(4)


        Else

            If bupdatingsql = False Then

                lblInfo.Visible = True
                cmdAddSQL.Enabled = True
                cmdRemoveSQL.Enabled = False
                btnTestSQL.Enabled = False
                btnSaveSQL.Enabled = False

                txtName.Text = ""
                txtSQLServer.Text = ""
                txtdb.Text = ""
                txtSQLUsername.Text = ""
                txtSQLpw.Text = ""
                txtPrefix.Text = ""

            End If


        End If

    End Sub


    Sub remove_sqlDb(ByVal sserver As String)

        Dim ssqlstring As String = hsqldbs(sserver)

        hsqldbs.Clear()

        My.Settings.SQLSettings.Remove(sserver & "||" & ssqlstring)

        My.Settings.Save()

        pop_sqldbs()

    End Sub

    Private Sub cmdRemoveSQL_Click(sender As Object, e As EventArgs) Handles cmdRemoveSQL.Click

        Dim ssqlname As String = ""

        For Each item In lstSQLDbs.CheckedItems

            ssqlname = item.SubItems(0).Text

        Next

        bupdatingsql = False

        remove_sqlDb(ssqlname)


    End Sub


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

       Dim TabName As String

        TabName = TabControl1.SelectedTab.Name

        If TabName.Contains("TabPage2") Then

            'don't reload settings - user is on this tab

        Else

            reload_settings()

        End If

        If bmailerror = True Then

            lblMailError.Visible = True


        Else

            lblMailError.Visible = False

        End If

    End Sub

    Private Sub txtpoll_GotFocus(sender As Object, e As EventArgs) Handles txtpoll.GotFocus

        btnPolling.Visible = True

    End Sub


    Private Sub btnPolling_Click(sender As Object, e As EventArgs) Handles btnPolling.Click


        My.Settings.Polling = txtpoll.Text

        My.Settings.Save()

        MsgBox("Polling Interval Upated", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Saved")

        btnPolling.Visible = False


    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

        If MsgBox("Are you sure you want to clear all SQL Server Settings?", MsgBoxStyle.YesNo, "Clear SQL Settings?") = MsgBoxResult.Yes Then

            My.Settings.SQLSettings.Clear()
            My.Settings.Save()

            hsqldbs.Clear()
            lstSQLDbs.Items.Clear()

            MsgBox("SQL Settings Cleared", MsgBoxStyle.Information, "SQL Settings Cleared")


        End If

    End Sub

    Private Sub cmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click

        Try
            Dim seventdb As String = ""

            For Each seventdb In hsqldbs.Keys

                Dim asql As Array = Split(hsqldbs(seventdb), "|")

                get_events(build_command_string(asql(1), asql(4)), asql(0), asql(2), asql(3), asql(1), asql(4))

            Next

        Catch ex As Exception


        End Try

    End Sub

    Function Encrypt_PW(ByVal spw As String) As String

        If checkconfigprotection() = True Then

            unprotectconfig()

        End If

        Dim sencrypted As String = ""
        Dim bchanged As Boolean = False
        Dim sek As String = read_config("Horizon_View_Event_Notifier.My.MySettings.EK")
        Dim ssalt As String = read_config("Horizon_View_Event_Notifier.My.MySettings.Salt")
        Dim siv As String = read_config("Horizon_View_Event_Notifier.My.MySettings.IV")

        If sek = "" Or Len(sek) <> 16 Then

            writeconfig("Horizon_View_Event_Notifier.My.MySettings.EK", getekey())

        End If

        If ssalt = "" Or Len(ssalt) <> 16 Then

            writeconfig("Horizon_View_Event_Notifier.My.MySettings.Salt", getekey())

        End If

        If siv = "" Or Len(siv) <> 16 Then

            writeconfig("Horizon_View_Event_Notifier.My.MySettings.IV", getekey())

        End If

        sek = read_config("Horizon_View_Event_Notifier.My.MySettings.EK")
        ssalt = read_config("Horizon_View_Event_Notifier.My.MySettings.Salt")
        siv = read_config("Horizon_View_Event_Notifier.My.MySettings.IV")

        Try

            sencrypted = crypto.Encrypt(spw, sek, siv, ssalt)

        Catch ex As Exception

            MsgBox("Error when trying to Encrypt SQL Password." & vbCrLf & "Please re-enter the SQL password and Save Setttings." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
            Return "ERROR"

        End Try

        If checkconfigprotection() = False Then

            protectconfig()

        End If

        Return sencrypted

    End Function

    Function Decrypt_PW(ByVal spw As String) As String

        If checkconfigprotection() = True Then

            unprotectconfig()

        End If

        Dim sdecrypted As String = ""
        Dim sek As String = read_config("Horizon_View_Event_Notifier.My.MySettings.EK")
        Dim ssalt As String = read_config("Horizon_View_Event_Notifier.My.MySettings.Salt")
        Dim siv As String = read_config("Horizon_View_Event_Notifier.My.MySettings.IV")

        Try

            sdecrypted = crypto.Decrypt(spw, sek, siv, ssalt)

        Catch ex As Exception

            MsgBox("Error when trying to Decrypt SQL Password." & vbCrLf & "Please re-enter the SQL password and Save Setttings." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")
            Return "ERROR"

        End Try

        If checkconfigprotection() = False Then

            protectconfig()

        End If

        Return sdecrypted


    End Function

    Function CheckSQLStatement(ByVal SelectStatement As String) As Boolean
        'check for possible SQL Injection attack on SQL command before executing
        'also allow only select statements

        Dim Bad As Boolean = False
        Dim MyList As New List(Of String) From {"'", ",", ";", "--", "/* ... */", "xp_"}

        For Each item In MyList
            If SelectStatement.ToLower.Contains(item) Then
                MsgBox(item)
                MsgBox(SelectStatement)
                Bad = True
                Exit For
            End If
        Next

        If Bad Then

            Return False

        Else

            Return True

        End If
    End Function

    Sub protectconfig()

        Try
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            Dim section As ConnectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)

            If section.SectionInformation.IsProtected Then
                'skip

            Else

                section.SectionInformation.ProtectSection("DPAPIProtection")
                config.Save()

            End If

        Catch ex As Exception

            MsgBox("Error when trying to encrypt config file." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try


    End Sub


    Sub unprotectconfig()

        Try
         
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            Dim section As ConnectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)

            If section.SectionInformation.IsProtected Then
                ' Remove encryption.
                section.SectionInformation.UnprotectSection()
                config.Save()
            End If

        Catch ex As Exception

            MsgBox("Error when trying to decrypt config file." & vbCrLf & "Error: " & ex.Message, MsgBoxStyle.Exclamation, "Error")

        End Try

    End Sub


    Function checkconfigprotection() As Boolean
        Try
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath)
            Dim section As ConnectionStringsSection = DirectCast(config.GetSection("connectionStrings"), ConnectionStringsSection)

            If section.SectionInformation.IsProtected Then

                Return True

            Else

                Return False

            End If


        Catch ex As Exception

            MsgBox("Error when trying to check config file." & vbCrLf & "Error: " & ex.Message)

        End Try

    End Function


    Function read_config(ByVal keyname As String) As String

        Try

            Dim XmlDoc As New XmlDocument()
            ' Load XML Document
            XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
            ' Navigate Each XML Element of app.Config file
            For Each xElement As XmlElement In XmlDoc.DocumentElement

                If xElement.Name = "connectionStrings" Then

                    For Each xNode As XmlNode In xElement.ChildNodes

                        If xNode.Attributes(0).Value = keyname Then

                            Return xNode.Attributes(1).Value

                        End If
                    Next
                End If
            Next

        Catch ex As Exception

            MsgBox("Error when trying to read config file." & vbCrLf & "Error: " & ex.Message)

        End Try

        Return "EMPTY"

    End Function

    Public Shared Sub writeconfig(ByVal KeyName As String, ByVal KeyValue As String)
        '  AppDomain.CurrentDomain.SetupInformation.ConfigurationFile 
        ' This will get the app.config file path from Current application Domain
        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement

            If xElement.Name = "connectionStrings" Then

                For Each xNode As XmlNode In xElement.ChildNodes

                    If xNode.Attributes(0).Value = KeyName Then

                        xNode.Attributes(1).Value = KeyValue

                    End If
                Next
            End If
        Next
        ' Save app.config file
        XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)

    End Sub


    Private Sub cmdProtect_Click(sender As Object, e As EventArgs) Handles cmdProtect.Click

        protectconfig()

    End Sub


    Private Sub cmdUnprotect_Click(sender As Object, e As EventArgs) Handles cmdUnprotect.Click

        unprotectconfig()

    End Sub

    Private Sub lstSQLDbs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSQLDbs.SelectedIndexChanged

    End Sub

    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub chkTestDB_CheckedChanged(sender As Object, e As EventArgs) Handles chkTestDB.CheckedChanged

    End Sub

    Private Sub ClearALLSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearALLSettingsToolStripMenuItem.Click

        If MsgBox("Are you sure you want to clear ALL settings in the application configuration?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Clear All Settings?") = vbYes Then

            My.Settings.Reset()
            My.Settings.Save()
            hsqldbs.Clear()
            lstSQLDbs.Items.Clear()
            reload_settings()

        End If

    End Sub

    Public Function DoesTableExist(ByVal tblName As String, dbconn As SqlConnection) As Boolean

        Try

            Dim srestrictions(3) As String
            srestrictions(0) = Nothing
            srestrictions(1) = Nothing
            srestrictions(2) = tblName
            srestrictions(3) = Nothing

            Dim dbTbl As DataTable = dbconn.GetSchema("Tables", srestrictions)

            If dbTbl.Rows.Count = 0 Then
                'Table does not exist
                DoesTableExist = False
            Else
                'Table exists
                DoesTableExist = True

            End If

        Catch ex As Exception


        End Try

    End Function



End Class
