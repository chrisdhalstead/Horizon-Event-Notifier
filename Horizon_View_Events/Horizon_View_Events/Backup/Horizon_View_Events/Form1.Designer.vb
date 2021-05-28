<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtRefresh = New System.Windows.Forms.ToolStripMenuItem
        Me.ResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtExit = New System.Windows.Forms.ToolStripMenuItem
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnClear = New System.Windows.Forms.Button
        Me.lstEvents = New System.Windows.Forms.ListView
        Me.Time = New System.Windows.Forms.ColumnHeader
        Me.Severity = New System.Windows.Forms.ColumnHeader
        Me.EventText = New System.Windows.Forms.ColumnHeader
        Me.Mail_Status = New System.Windows.Forms.ColumnHeader
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btn_Reload = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtSendFrom = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtalertrecipients = New System.Windows.Forms.TextBox
        Me.btnEmailTest = New System.Windows.Forms.Button
        Me.txtsmtpport = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtsmtpserver = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnSaveSMTP = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTime = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ChkError = New System.Windows.Forms.CheckBox
        Me.ChkWarning = New System.Windows.Forms.CheckBox
        Me.chkAuditFail = New System.Windows.Forms.CheckBox
        Me.btn_Events = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtdb = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.btnTestSQL = New System.Windows.Forms.Button
        Me.txtSQLpw = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSQLUsername = New System.Windows.Forms.TextBox
        Me.lblUserName = New System.Windows.Forms.Label
        Me.btnSaveSQL = New System.Windows.Forms.Button
        Me.txtSQLServer = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.sslabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.btn_Start = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPrefix = New System.Windows.Forms.TextBox
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Horizon View Event Notifier"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Horizon View Event Notifier"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtRefresh, Me.ResToolStripMenuItem, Me.txtExit})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(142, 70)
        '
        'txtRefresh
        '
        Me.txtRefresh.Name = "txtRefresh"
        Me.txtRefresh.Size = New System.Drawing.Size(141, 22)
        Me.txtRefresh.Text = "Refresh Now"
        '
        'ResToolStripMenuItem
        '
        Me.ResToolStripMenuItem.Name = "ResToolStripMenuItem"
        Me.ResToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.ResToolStripMenuItem.Text = "Show Status"
        '
        'txtExit
        '
        Me.txtExit.Name = "txtExit"
        Me.txtExit.Size = New System.Drawing.Size(141, 22)
        Me.txtExit.Text = "Exit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 395)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.lstEvents)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(702, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Horizon View Events"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(6, 342)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 26)
        Me.btnClear.TabIndex = 5
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstEvents
        '
        Me.lstEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time, Me.Severity, Me.EventText, Me.Mail_Status})
        Me.lstEvents.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEvents.GridLines = True
        Me.lstEvents.Location = New System.Drawing.Point(6, 9)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(690, 333)
        Me.lstEvents.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lstEvents.TabIndex = 1
        Me.lstEvents.UseCompatibleStateImageBehavior = False
        Me.lstEvents.View = System.Windows.Forms.View.Details
        '
        'Time
        '
        Me.Time.Text = "Date / Time"
        Me.Time.Width = 120
        '
        'Severity
        '
        Me.Severity.Text = "Severity"
        Me.Severity.Width = 75
        '
        'EventText
        '
        Me.EventText.Text = "Event Text"
        Me.EventText.Width = 385
        '
        'Mail_Status
        '
        Me.Mail_Status.Text = "Alert Status"
        Me.Mail_Status.Width = 105
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.btn_Reload)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(702, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_Reload
        '
        Me.btn_Reload.Location = New System.Drawing.Point(6, 342)
        Me.btn_Reload.Name = "btn_Reload"
        Me.btn_Reload.Size = New System.Drawing.Size(129, 23)
        Me.btn_Reload.TabIndex = 5
        Me.btn_Reload.TabStop = False
        Me.btn_Reload.Text = "Reload Settings"
        Me.btn_Reload.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSendFrom)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtalertrecipients)
        Me.GroupBox3.Controls.Add(Me.btnEmailTest)
        Me.GroupBox3.Controls.Add(Me.txtsmtpport)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtsmtpserver)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.btnSaveSMTP)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(6, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(690, 135)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SMTP Server Settings"
        '
        'txtSendFrom
        '
        Me.txtSendFrom.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSendFrom.Location = New System.Drawing.Point(112, 45)
        Me.txtSendFrom.Name = "txtSendFrom"
        Me.txtSendFrom.Size = New System.Drawing.Size(209, 21)
        Me.txtSendFrom.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Send From:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Separate addresses with a Comma"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Alert Recipients:"
        '
        'txtalertrecipients
        '
        Me.txtalertrecipients.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalertrecipients.Location = New System.Drawing.Point(112, 71)
        Me.txtalertrecipients.Multiline = True
        Me.txtalertrecipients.Name = "txtalertrecipients"
        Me.txtalertrecipients.Size = New System.Drawing.Size(427, 40)
        Me.txtalertrecipients.TabIndex = 4
        '
        'btnEmailTest
        '
        Me.btnEmailTest.Location = New System.Drawing.Point(545, 20)
        Me.btnEmailTest.Name = "btnEmailTest"
        Me.btnEmailTest.Size = New System.Drawing.Size(129, 23)
        Me.btnEmailTest.TabIndex = 7
        Me.btnEmailTest.TabStop = False
        Me.btnEmailTest.Text = "Send Test Email"
        Me.btnEmailTest.UseVisualStyleBackColor = True
        '
        'txtsmtpport
        '
        Me.txtsmtpport.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsmtpport.Location = New System.Drawing.Point(377, 20)
        Me.txtsmtpport.Name = "txtsmtpport"
        Me.txtsmtpport.Size = New System.Drawing.Size(36, 21)
        Me.txtsmtpport.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(340, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Port:"
        '
        'txtsmtpserver
        '
        Me.txtsmtpserver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsmtpserver.Location = New System.Drawing.Point(112, 20)
        Me.txtsmtpserver.Name = "txtsmtpserver"
        Me.txtsmtpserver.Size = New System.Drawing.Size(209, 21)
        Me.txtsmtpserver.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "SMTP Server:"
        '
        'btnSaveSMTP
        '
        Me.btnSaveSMTP.Location = New System.Drawing.Point(545, 86)
        Me.btnSaveSMTP.Name = "btnSaveSMTP"
        Me.btnSaveSMTP.Size = New System.Drawing.Size(129, 23)
        Me.btnSaveSMTP.TabIndex = 5
        Me.btnSaveSMTP.Text = "Save Changes"
        Me.btnSaveSMTP.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ChkError)
        Me.GroupBox2.Controls.Add(Me.ChkWarning)
        Me.GroupBox2.Controls.Add(Me.chkAuditFail)
        Me.GroupBox2.Controls.Add(Me.btn_Events)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(690, 89)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horizon View Events"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(307, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Minutes of Events"
        '
        'txtTime
        '
        Me.txtTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTime.Location = New System.Drawing.Point(274, 16)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(29, 21)
        Me.txtTime.TabIndex = 6
        Me.txtTime.Text = "60"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(197, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Query Last:"
        '
        'ChkError
        '
        Me.ChkError.AutoSize = True
        Me.ChkError.Checked = True
        Me.ChkError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkError.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkError.Location = New System.Drawing.Point(13, 66)
        Me.ChkError.Name = "ChkError"
        Me.ChkError.Size = New System.Drawing.Size(143, 17)
        Me.ChkError.TabIndex = 5
        Me.ChkError.Text = "Alert on Error Events"
        Me.ChkError.UseVisualStyleBackColor = True
        '
        'ChkWarning
        '
        Me.ChkWarning.AutoSize = True
        Me.ChkWarning.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkWarning.Location = New System.Drawing.Point(13, 43)
        Me.ChkWarning.Name = "ChkWarning"
        Me.ChkWarning.Size = New System.Drawing.Size(162, 17)
        Me.ChkWarning.TabIndex = 4
        Me.ChkWarning.Text = "Alert on Warning Events"
        Me.ChkWarning.UseVisualStyleBackColor = True
        '
        'chkAuditFail
        '
        Me.chkAuditFail.AutoSize = True
        Me.chkAuditFail.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAuditFail.Location = New System.Drawing.Point(13, 20)
        Me.chkAuditFail.Name = "chkAuditFail"
        Me.chkAuditFail.Size = New System.Drawing.Size(167, 17)
        Me.chkAuditFail.TabIndex = 3
        Me.chkAuditFail.Text = "Alert on Audit Fail Events"
        Me.chkAuditFail.UseVisualStyleBackColor = True
        '
        'btn_Events
        '
        Me.btn_Events.Location = New System.Drawing.Point(545, 52)
        Me.btn_Events.Name = "btn_Events"
        Me.btn_Events.Size = New System.Drawing.Size(129, 23)
        Me.btn_Events.TabIndex = 7
        Me.btn_Events.Text = "Save Changes"
        Me.btn_Events.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPrefix)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdb)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.btnTestSQL)
        Me.GroupBox1.Controls.Add(Me.txtSQLpw)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSQLUsername)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.btnSaveSQL)
        Me.GroupBox1.Controls.Add(Me.txtSQLServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(690, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SQL Server Settings"
        '
        'txtdb
        '
        Me.txtdb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdb.Location = New System.Drawing.Point(367, 22)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(134, 21)
        Me.txtdb.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(298, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Database:"
        '
        'btnTestSQL
        '
        Me.btnTestSQL.Location = New System.Drawing.Point(545, 24)
        Me.btnTestSQL.Name = "btnTestSQL"
        Me.btnTestSQL.Size = New System.Drawing.Size(129, 23)
        Me.btnTestSQL.TabIndex = 6
        Me.btnTestSQL.TabStop = False
        Me.btnTestSQL.Text = "Test Connection"
        Me.btnTestSQL.UseVisualStyleBackColor = True
        '
        'txtSQLpw
        '
        Me.txtSQLpw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLpw.Location = New System.Drawing.Point(368, 48)
        Me.txtSQLpw.Name = "txtSQLpw"
        Me.txtSQLpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQLpw.Size = New System.Drawing.Size(134, 21)
        Me.txtSQLpw.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(299, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password:"
        '
        'txtSQLUsername
        '
        Me.txtSQLUsername.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLUsername.Location = New System.Drawing.Point(86, 48)
        Me.txtSQLUsername.Name = "txtSQLUsername"
        Me.txtSQLUsername.Size = New System.Drawing.Size(112, 21)
        Me.txtSQLUsername.TabIndex = 3
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(11, 51)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(68, 13)
        Me.lblUserName.TabIndex = 1
        Me.lblUserName.Text = "Username:"
        '
        'btnSaveSQL
        '
        Me.btnSaveSQL.Location = New System.Drawing.Point(545, 62)
        Me.btnSaveSQL.Name = "btnSaveSQL"
        Me.btnSaveSQL.Size = New System.Drawing.Size(129, 23)
        Me.btnSaveSQL.TabIndex = 5
        Me.btnSaveSQL.Text = "Save Changes"
        Me.btnSaveSQL.UseVisualStyleBackColor = True
        '
        'txtSQLServer
        '
        Me.txtSQLServer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLServer.Location = New System.Drawing.Point(86, 21)
        Me.txtSQLServer.Name = "txtSQLServer"
        Me.txtSQLServer.Size = New System.Drawing.Size(204, 21)
        Me.txtSQLServer.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SQL Server:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(725, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 462)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(725, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslabel
        '
        Me.sslabel.Name = "sslabel"
        Me.sslabel.Size = New System.Drawing.Size(0, 17)
        '
        'btn_Start
        '
        Me.btn_Start.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Start.Location = New System.Drawing.Point(10, 426)
        Me.btn_Start.Name = "btn_Start"
        Me.btn_Start.Size = New System.Drawing.Size(101, 27)
        Me.btn_Start.TabIndex = 4
        Me.btn_Start.Text = "Start"
        Me.btn_Start.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 60000
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "Table Prefix:"
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(86, 75)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(70, 21)
        Me.txtPrefix.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 484)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horizon View Event Notifier"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents lstEvents As System.Windows.Forms.ListView
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Severity As System.Windows.Forms.ColumnHeader
    Friend WithEvents EventText As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSQLServer As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveSQL As System.Windows.Forms.Button
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtSQLpw As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSQLUsername As System.Windows.Forms.TextBox
    Friend WithEvents btnTestSQL As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Events As System.Windows.Forms.Button
    Friend WithEvents chkAuditFail As System.Windows.Forms.CheckBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSaveSMTP As System.Windows.Forms.Button
    Friend WithEvents ChkError As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWarning As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtalertrecipients As System.Windows.Forms.TextBox
    Friend WithEvents btnEmailTest As System.Windows.Forms.Button
    Friend WithEvents txtsmtpport As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsmtpserver As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btn_Reload As System.Windows.Forms.Button
    Friend WithEvents txtSendFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Mail_Status As System.Windows.Forms.ColumnHeader
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtdb As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label

End Class
