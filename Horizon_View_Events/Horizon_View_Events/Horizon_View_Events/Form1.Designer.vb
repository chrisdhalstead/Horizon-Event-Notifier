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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.txtRefresh = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btn_Start = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkSendMail = New System.Windows.Forms.CheckBox()
        Me.txtSendFrom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtalertrecipients = New System.Windows.Forms.TextBox()
        Me.btnEmailTest = New System.Windows.Forms.Button()
        Me.txtsmtpport = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsmtpserver = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSaveSMTP = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkInfo = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ChkError = New System.Windows.Forms.CheckBox()
        Me.ChkWarning = New System.Windows.Forms.CheckBox()
        Me.chkAuditFail = New System.Windows.Forms.CheckBox()
        Me.btn_Events = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkTestDB = New System.Windows.Forms.CheckBox()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.cmdAddSQL = New System.Windows.Forms.Button()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdb = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSQLpw = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSQLUsername = New System.Windows.Forms.TextBox()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.txtSQLServer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdRemoveSQL = New System.Windows.Forms.Button()
        Me.lstSQLDbs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearALLSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnTestSQL = New System.Windows.Forms.Button()
        Me.btnSaveSQL = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblMailError = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lstEvents = New System.Windows.Forms.ListView()
        Me.Time = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Server = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Event_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Severity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.EventText = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lstEventsSelected = New System.Windows.Forms.ListBox()
        Me.lstallevents = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtpoll = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnPolling = New System.Windows.Forms.Button()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdProtect = New System.Windows.Forms.Button()
        Me.cmdUnprotect = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1005, 24)
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
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1005, 22)
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
        Me.btn_Start.Location = New System.Drawing.Point(8, 477)
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
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Transparent
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(982, 421)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Settings"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkSendMail)
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
        Me.GroupBox3.Location = New System.Drawing.Point(6, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(970, 144)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SMTP Server Settings"
        '
        'chkSendMail
        '
        Me.chkSendMail.AutoSize = True
        Me.chkSendMail.Checked = True
        Me.chkSendMail.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkSendMail.Location = New System.Drawing.Point(7, 121)
        Me.chkSendMail.Name = "chkSendMail"
        Me.chkSendMail.Size = New System.Drawing.Size(150, 17)
        Me.chkSendMail.TabIndex = 12
        Me.chkSendMail.Text = "Send Alerts via Email?"
        Me.chkSendMail.UseVisualStyleBackColor = True
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
        Me.Label6.Location = New System.Drawing.Point(239, 114)
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
        Me.btnEmailTest.Location = New System.Drawing.Point(835, 20)
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
        Me.btnSaveSMTP.Location = New System.Drawing.Point(835, 100)
        Me.btnSaveSMTP.Name = "btnSaveSMTP"
        Me.btnSaveSMTP.Size = New System.Drawing.Size(129, 23)
        Me.btnSaveSMTP.TabIndex = 5
        Me.btnSaveSMTP.Text = "Save Changes"
        Me.btnSaveSMTP.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkInfo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtTime)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.ChkError)
        Me.GroupBox2.Controls.Add(Me.ChkWarning)
        Me.GroupBox2.Controls.Add(Me.chkAuditFail)
        Me.GroupBox2.Controls.Add(Me.btn_Events)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(970, 103)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Horizon View Events"
        '
        'chkInfo
        '
        Me.chkInfo.AutoSize = True
        Me.chkInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkInfo.Location = New System.Drawing.Point(13, 83)
        Me.chkInfo.Name = "chkInfo"
        Me.chkInfo.Size = New System.Drawing.Size(193, 17)
        Me.chkInfo.TabIndex = 9
        Me.chkInfo.Text = "Alert on Informational Events"
        Me.chkInfo.UseVisualStyleBackColor = True
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
        Me.txtTime.Text = "10"
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
        Me.ChkError.Location = New System.Drawing.Point(13, 62)
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
        Me.ChkWarning.Location = New System.Drawing.Point(13, 41)
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
        Me.btn_Events.Location = New System.Drawing.Point(835, 60)
        Me.btn_Events.Name = "btn_Events"
        Me.btn_Events.Size = New System.Drawing.Size(129, 23)
        Me.btn_Events.TabIndex = 7
        Me.btn_Events.Text = "Save Changes"
        Me.btn_Events.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkTestDB)
        Me.GroupBox1.Controls.Add(Me.lblInfo)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.lblName)
        Me.GroupBox1.Controls.Add(Me.cmdAddSQL)
        Me.GroupBox1.Controls.Add(Me.txtPrefix)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtdb)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtSQLpw)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSQLUsername)
        Me.GroupBox1.Controls.Add(Me.lblUserName)
        Me.GroupBox1.Controls.Add(Me.txtSQLServer)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmdRemoveSQL)
        Me.GroupBox1.Controls.Add(Me.lstSQLDbs)
        Me.GroupBox1.Controls.Add(Me.btnTestSQL)
        Me.GroupBox1.Controls.Add(Me.btnSaveSQL)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(970, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SQL Server Settings"
        '
        'chkTestDB
        '
        Me.chkTestDB.AutoSize = True
        Me.chkTestDB.Checked = True
        Me.chkTestDB.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkTestDB.Location = New System.Drawing.Point(631, 104)
        Me.chkTestDB.Name = "chkTestDB"
        Me.chkTestDB.Size = New System.Drawing.Size(200, 17)
        Me.chkTestDB.TabIndex = 33
        Me.chkTestDB.Text = "Test DB connection on update?"
        Me.chkTestDB.UseVisualStyleBackColor = True
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.BackColor = System.Drawing.SystemColors.Info
        Me.lblInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(364, 126)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(436, 13)
        Me.lblInfo.TabIndex = 28
        Me.lblInfo.Text = "Select a SQL Server to populate settings or add a new SQL Server to Monitor"
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(413, 17)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(206, 21)
        Me.txtName.TabIndex = 27
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(363, 21)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(42, 13)
        Me.lblName.TabIndex = 26
        Me.lblName.Text = "Name:"
        '
        'cmdAddSQL
        '
        Me.cmdAddSQL.Location = New System.Drawing.Point(834, 82)
        Me.cmdAddSQL.Name = "cmdAddSQL"
        Me.cmdAddSQL.Size = New System.Drawing.Size(129, 23)
        Me.cmdAddSQL.TabIndex = 25
        Me.cmdAddSQL.TabStop = False
        Me.cmdAddSQL.Text = "Add SQL Server"
        Me.cmdAddSQL.UseVisualStyleBackColor = True
        '
        'txtPrefix
        '
        Me.txtPrefix.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrefix.Location = New System.Drawing.Point(413, 100)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(70, 21)
        Me.txtPrefix.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Table Prefix:"
        '
        'txtdb
        '
        Me.txtdb.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdb.Location = New System.Drawing.Point(694, 47)
        Me.txtdb.Name = "txtdb"
        Me.txtdb.Size = New System.Drawing.Size(134, 21)
        Me.txtdb.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(625, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Database:"
        '
        'txtSQLpw
        '
        Me.txtSQLpw.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLpw.Location = New System.Drawing.Point(695, 73)
        Me.txtSQLpw.Name = "txtSQLpw"
        Me.txtSQLpw.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSQLpw.Size = New System.Drawing.Size(134, 21)
        Me.txtSQLpw.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(626, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password:"
        '
        'txtSQLUsername
        '
        Me.txtSQLUsername.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLUsername.Location = New System.Drawing.Point(413, 73)
        Me.txtSQLUsername.Name = "txtSQLUsername"
        Me.txtSQLUsername.Size = New System.Drawing.Size(112, 21)
        Me.txtSQLUsername.TabIndex = 30
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(338, 76)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(68, 13)
        Me.lblUserName.TabIndex = 15
        Me.lblUserName.Text = "Username:"
        '
        'txtSQLServer
        '
        Me.txtSQLServer.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSQLServer.Location = New System.Drawing.Point(413, 46)
        Me.txtSQLServer.Name = "txtSQLServer"
        Me.txtSQLServer.Size = New System.Drawing.Size(204, 21)
        Me.txtSQLServer.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(340, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "DB Server:"
        '
        'cmdRemoveSQL
        '
        Me.cmdRemoveSQL.Enabled = False
        Me.cmdRemoveSQL.Location = New System.Drawing.Point(834, 111)
        Me.cmdRemoveSQL.Name = "cmdRemoveSQL"
        Me.cmdRemoveSQL.Size = New System.Drawing.Size(129, 23)
        Me.cmdRemoveSQL.TabIndex = 13
        Me.cmdRemoveSQL.TabStop = False
        Me.cmdRemoveSQL.Text = "Remove SQL Server"
        Me.cmdRemoveSQL.UseVisualStyleBackColor = True
        '
        'lstSQLDbs
        '
        Me.lstSQLDbs.CheckBoxes = True
        Me.lstSQLDbs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lstSQLDbs.ContextMenuStrip = Me.ContextMenuStrip2
        Me.lstSQLDbs.GridLines = True
        Me.lstSQLDbs.HideSelection = False
        Me.lstSQLDbs.Location = New System.Drawing.Point(9, 18)
        Me.lstSQLDbs.MultiSelect = False
        Me.lstSQLDbs.Name = "lstSQLDbs"
        Me.lstSQLDbs.Size = New System.Drawing.Size(312, 125)
        Me.lstSQLDbs.TabIndex = 11
        Me.lstSQLDbs.UseCompatibleStateImageBehavior = False
        Me.lstSQLDbs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Monitored View Event DBs"
        Me.ColumnHeader1.Width = 280
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ClearALLSettingsToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(170, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(169, 22)
        Me.ToolStripMenuItem1.Text = "Clear all SQL DBs"
        '
        'ClearALLSettingsToolStripMenuItem
        '
        Me.ClearALLSettingsToolStripMenuItem.Name = "ClearALLSettingsToolStripMenuItem"
        Me.ClearALLSettingsToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.ClearALLSettingsToolStripMenuItem.Text = "Clear ALL Settings"
        '
        'btnTestSQL
        '
        Me.btnTestSQL.Enabled = False
        Me.btnTestSQL.Location = New System.Drawing.Point(834, 20)
        Me.btnTestSQL.Name = "btnTestSQL"
        Me.btnTestSQL.Size = New System.Drawing.Size(129, 23)
        Me.btnTestSQL.TabIndex = 6
        Me.btnTestSQL.TabStop = False
        Me.btnTestSQL.Text = "Test Connection"
        Me.btnTestSQL.UseVisualStyleBackColor = True
        '
        'btnSaveSQL
        '
        Me.btnSaveSQL.Enabled = False
        Me.btnSaveSQL.Location = New System.Drawing.Point(835, 50)
        Me.btnSaveSQL.Name = "btnSaveSQL"
        Me.btnSaveSQL.Size = New System.Drawing.Size(129, 23)
        Me.btnSaveSQL.TabIndex = 5
        Me.btnSaveSQL.Text = "Save Changes"
        Me.btnSaveSQL.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "mail_send.png")
        Me.ImageList1.Images.SetKeyName(1, "mail_delete(1).png")
        Me.ImageList1.Images.SetKeyName(2, "notification_done.png")
        Me.ImageList1.Images.SetKeyName(3, "notification_error.png")
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.lblMailError)
        Me.TabPage1.Controls.Add(Me.btnClear)
        Me.TabPage1.Controls.Add(Me.lstEvents)
        Me.TabPage1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(982, 421)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Horizon Events"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblMailError
        '
        Me.lblMailError.AutoSize = True
        Me.lblMailError.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblMailError.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMailError.ForeColor = System.Drawing.Color.Yellow
        Me.lblMailError.Location = New System.Drawing.Point(58, 158)
        Me.lblMailError.Name = "lblMailError"
        Me.lblMailError.Size = New System.Drawing.Size(811, 33)
        Me.lblMailError.TabIndex = 12
        Me.lblMailError.Text = "Error Sending Email - Please Check and test SMTP Settings"
        Me.lblMailError.Visible = False
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(6, 384)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(64, 26)
        Me.btnClear.TabIndex = 5
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lstEvents
        '
        Me.lstEvents.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lstEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Time, Me.Server, Me.Event_ID, Me.Severity, Me.EventText})
        Me.lstEvents.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstEvents.GridLines = True
        Me.lstEvents.HideSelection = False
        Me.lstEvents.HotTracking = True
        Me.lstEvents.HoverSelection = True
        Me.lstEvents.Location = New System.Drawing.Point(6, 12)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(968, 363)
        Me.lstEvents.SmallImageList = Me.ImageList1
        Me.lstEvents.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.lstEvents.TabIndex = 1
        Me.lstEvents.UseCompatibleStateImageBehavior = False
        Me.lstEvents.View = System.Windows.Forms.View.Details
        '
        'Time
        '
        Me.Time.Text = "Date / Time"
        Me.Time.Width = 120
        '
        'Server
        '
        Me.Server.Text = "Server"
        Me.Server.Width = 110
        '
        'Event_ID
        '
        Me.Event_ID.Text = "Event ID"
        Me.Event_ID.Width = 150
        '
        'Severity
        '
        Me.Severity.Text = "Severity"
        Me.Severity.Width = 75
        '
        'EventText
        '
        Me.EventText.Text = "Event Text"
        Me.EventText.Width = 500
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(990, 447)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Button2)
        Me.TabPage3.Controls.Add(Me.lstEventsSelected)
        Me.TabPage3.Controls.Add(Me.lstallevents)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(982, 421)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Event Filtering"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Red
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(243, 196)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(501, 42)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Hidden - for Future Release"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(454, 28)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(69, 24)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "--->"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstEventsSelected
        '
        Me.lstEventsSelected.FormattingEnabled = True
        Me.lstEventsSelected.Location = New System.Drawing.Point(559, 17)
        Me.lstEventsSelected.Name = "lstEventsSelected"
        Me.lstEventsSelected.Size = New System.Drawing.Size(406, 134)
        Me.lstEventsSelected.TabIndex = 1
        '
        'lstallevents
        '
        Me.lstallevents.FormattingEnabled = True
        Me.lstallevents.Location = New System.Drawing.Point(14, 17)
        Me.lstallevents.Name = "lstallevents"
        Me.lstallevents.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstallevents.Size = New System.Drawing.Size(403, 134)
        Me.lstallevents.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(225, 485)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Seconds"
        '
        'txtpoll
        '
        Me.txtpoll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpoll.Location = New System.Drawing.Point(192, 480)
        Me.txtpoll.Name = "txtpoll"
        Me.txtpoll.Size = New System.Drawing.Size(29, 21)
        Me.txtpoll.TabIndex = 9
        Me.txtpoll.Text = "60"
        Me.txtpoll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(124, 484)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Poll Every:"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 30000
        '
        'btnPolling
        '
        Me.btnPolling.Location = New System.Drawing.Point(282, 480)
        Me.btnPolling.Name = "btnPolling"
        Me.btnPolling.Size = New System.Drawing.Size(111, 23)
        Me.btnPolling.TabIndex = 12
        Me.btnPolling.Text = "Save Change"
        Me.btnPolling.UseVisualStyleBackColor = True
        Me.btnPolling.Visible = False
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefresh.Location = New System.Drawing.Point(896, 479)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(101, 27)
        Me.cmdRefresh.TabIndex = 14
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'cmdProtect
        '
        Me.cmdProtect.Location = New System.Drawing.Point(449, 479)
        Me.cmdProtect.Name = "cmdProtect"
        Me.cmdProtect.Size = New System.Drawing.Size(96, 27)
        Me.cmdProtect.TabIndex = 15
        Me.cmdProtect.Text = "Protect"
        Me.cmdProtect.UseVisualStyleBackColor = True
        Me.cmdProtect.Visible = False
        '
        'cmdUnprotect
        '
        Me.cmdUnprotect.Location = New System.Drawing.Point(561, 479)
        Me.cmdUnprotect.Name = "cmdUnprotect"
        Me.cmdUnprotect.Size = New System.Drawing.Size(96, 27)
        Me.cmdUnprotect.TabIndex = 16
        Me.cmdUnprotect.Text = "Unprotect"
        Me.cmdUnprotect.UseVisualStyleBackColor = True
        Me.cmdUnprotect.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 538)
        Me.Controls.Add(Me.cmdUnprotect)
        Me.Controls.Add(Me.cmdProtect)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.btnPolling)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtpoll)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_Start)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Horizon Event Notifier"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents sslabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btn_Start As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents txtRefresh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSendFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtalertrecipients As System.Windows.Forms.TextBox
    Friend WithEvents btnEmailTest As System.Windows.Forms.Button
    Friend WithEvents txtsmtpport As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtsmtpserver As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSaveSMTP As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTime As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ChkError As System.Windows.Forms.CheckBox
    Friend WithEvents ChkWarning As System.Windows.Forms.CheckBox
    Friend WithEvents chkAuditFail As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Events As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTestSQL As System.Windows.Forms.Button
    Friend WithEvents btnSaveSQL As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lstEvents As System.Windows.Forms.ListView
    Friend WithEvents Time As System.Windows.Forms.ColumnHeader
    Friend WithEvents Server As System.Windows.Forms.ColumnHeader
    Friend WithEvents Event_ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Severity As System.Windows.Forms.ColumnHeader
    Friend WithEvents EventText As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lstSQLDbs As System.Windows.Forms.ListView
    Friend WithEvents cmdRemoveSQL As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtdb As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSQLpw As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSQLUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUserName As System.Windows.Forms.Label
    Friend WithEvents txtSQLServer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAddSQL As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtpoll As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblMailError As System.Windows.Forms.Label
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents btnPolling As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents chkInfo As System.Windows.Forms.CheckBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents lstallevents As System.Windows.Forms.ListBox
    Friend WithEvents lstEventsSelected As System.Windows.Forms.ListBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkSendMail As System.Windows.Forms.CheckBox
    Friend WithEvents cmdProtect As System.Windows.Forms.Button
    Friend WithEvents cmdUnprotect As System.Windows.Forms.Button
    Friend WithEvents chkTestDB As System.Windows.Forms.CheckBox
    Friend WithEvents ClearALLSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
