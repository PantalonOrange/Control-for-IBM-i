<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MnuStrpMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JobLogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsrInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputQueuesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StsStrpMain = New System.Windows.Forms.StatusStrip()
        Me.StrpLabelUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StrpLabelHost = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStsLblMsgwSearch = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuToolStrip = New System.Windows.Forms.ToolStrip()
        Me.TlStrpActJob = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpUsrPrf = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpJobLog = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpOutQ = New System.Windows.Forms.ToolStripButton()
        Me.MsgwSearchTimer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundMsgwSearch = New System.ComponentModel.BackgroundWorker()
        Me.OutputQueueEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.TlStrpOutQEntries = New System.Windows.Forms.ToolStripButton()
        Me.MnuStrpMain.SuspendLayout()
        Me.StsStrpMain.SuspendLayout()
        Me.MnuToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuStrpMain
        '
        Me.MnuStrpMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MnuStrpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OperationsToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MnuStrpMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuStrpMain.Name = "MnuStrpMain"
        Me.MnuStrpMain.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MnuStrpMain.Size = New System.Drawing.Size(1206, 24)
        Me.MnuStrpMain.TabIndex = 1
        Me.MnuStrpMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSettingsToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.Image = CType(resources.GetObject("ChangeSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ChangeSettingsToolStripMenuItem.Text = "Change settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'OperationsToolStripMenuItem
        '
        Me.OperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveJobsToolStripMenuItem, Me.ToolStripSeparator7, Me.UsrInfoToolStripMenuItem, Me.ToolStripSeparator5, Me.OutputQueuesToolStripMenuItem, Me.OutputQueueEntriesToolStripMenuItem, Me.ToolStripSeparator6, Me.JobLogsToolStripMenuItem})
        Me.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem"
        Me.OperationsToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.OperationsToolStripMenuItem.Text = "&Operations"
        '
        'ActiveJobsToolStripMenuItem
        '
        Me.ActiveJobsToolStripMenuItem.Image = CType(resources.GetObject("ActiveJobsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActiveJobsToolStripMenuItem.Name = "ActiveJobsToolStripMenuItem"
        Me.ActiveJobsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ActiveJobsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.ActiveJobsToolStripMenuItem.Text = "&Active jobs"
        '
        'JobLogsToolStripMenuItem
        '
        Me.JobLogsToolStripMenuItem.Image = CType(resources.GetObject("JobLogsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.JobLogsToolStripMenuItem.Name = "JobLogsToolStripMenuItem"
        Me.JobLogsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.J), System.Windows.Forms.Keys)
        Me.JobLogsToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.JobLogsToolStripMenuItem.Text = "Job logs"
        '
        'UsrInfoToolStripMenuItem
        '
        Me.UsrInfoToolStripMenuItem.Image = CType(resources.GetObject("UsrInfoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsrInfoToolStripMenuItem.Name = "UsrInfoToolStripMenuItem"
        Me.UsrInfoToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UsrInfoToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.UsrInfoToolStripMenuItem.Text = "User informations"
        '
        'OutputQueuesToolStripMenuItem
        '
        Me.OutputQueuesToolStripMenuItem.Image = CType(resources.GetObject("OutputQueuesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OutputQueuesToolStripMenuItem.Name = "OutputQueuesToolStripMenuItem"
        Me.OutputQueuesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OutputQueuesToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.OutputQueuesToolStripMenuItem.Text = "Output queues"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 22)
        Me.ToolStripMenuItem1.Text = "&?"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "&Info"
        '
        'StsStrpMain
        '
        Me.StsStrpMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StsStrpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StrpLabelUser, Me.StrpLabelHost, Me.ToolStripStsLblMsgwSearch})
        Me.StsStrpMain.Location = New System.Drawing.Point(0, 806)
        Me.StsStrpMain.Name = "StsStrpMain"
        Me.StsStrpMain.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StsStrpMain.Size = New System.Drawing.Size(1206, 24)
        Me.StsStrpMain.TabIndex = 2
        Me.StsStrpMain.Text = "StatusStrip1"
        '
        'StrpLabelUser
        '
        Me.StrpLabelUser.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StrpLabelUser.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StrpLabelUser.Name = "StrpLabelUser"
        Me.StrpLabelUser.Size = New System.Drawing.Size(34, 19)
        Me.StrpLabelUser.Text = "User"
        '
        'StrpLabelHost
        '
        Me.StrpLabelHost.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.StrpLabelHost.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.StrpLabelHost.Name = "StrpLabelHost"
        Me.StrpLabelHost.Size = New System.Drawing.Size(36, 19)
        Me.StrpLabelHost.Text = "Host"
        '
        'ToolStripStsLblMsgwSearch
        '
        Me.ToolStripStsLblMsgwSearch.Name = "ToolStripStsLblMsgwSearch"
        Me.ToolStripStsLblMsgwSearch.Size = New System.Drawing.Size(256, 19)
        Me.ToolStripStsLblMsgwSearch.Text = "Searching for jobs with status MSGW on host ..."
        '
        'MnuToolStrip
        '
        Me.MnuToolStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MnuToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TlStrpActJob, Me.ToolStripSeparator2, Me.TlStrpUsrPrf, Me.ToolStripSeparator3, Me.TlStrpOutQ, Me.TlStrpOutQEntries, Me.ToolStripSeparator4, Me.TlStrpJobLog})
        Me.MnuToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.MnuToolStrip.Name = "MnuToolStrip"
        Me.MnuToolStrip.Size = New System.Drawing.Size(1206, 31)
        Me.MnuToolStrip.TabIndex = 4
        Me.MnuToolStrip.Text = "MnuToolStrip"
        '
        'TlStrpActJob
        '
        Me.TlStrpActJob.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpActJob.Image = CType(resources.GetObject("TlStrpActJob.Image"), System.Drawing.Image)
        Me.TlStrpActJob.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpActJob.Name = "TlStrpActJob"
        Me.TlStrpActJob.Size = New System.Drawing.Size(28, 28)
        Me.TlStrpActJob.Text = "Active jobs"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'TlStrpUsrPrf
        '
        Me.TlStrpUsrPrf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpUsrPrf.Image = CType(resources.GetObject("TlStrpUsrPrf.Image"), System.Drawing.Image)
        Me.TlStrpUsrPrf.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpUsrPrf.Name = "TlStrpUsrPrf"
        Me.TlStrpUsrPrf.Size = New System.Drawing.Size(28, 28)
        Me.TlStrpUsrPrf.Text = "User informations"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'TlStrpJobLog
        '
        Me.TlStrpJobLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpJobLog.Image = CType(resources.GetObject("TlStrpJobLog.Image"), System.Drawing.Image)
        Me.TlStrpJobLog.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpJobLog.Name = "TlStrpJobLog"
        Me.TlStrpJobLog.Size = New System.Drawing.Size(28, 28)
        Me.TlStrpJobLog.Text = "Job logs"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'TlStrpOutQ
        '
        Me.TlStrpOutQ.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpOutQ.Image = CType(resources.GetObject("TlStrpOutQ.Image"), System.Drawing.Image)
        Me.TlStrpOutQ.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpOutQ.Name = "TlStrpOutQ"
        Me.TlStrpOutQ.Size = New System.Drawing.Size(28, 28)
        Me.TlStrpOutQ.Text = "ToolStripButton1"
        Me.TlStrpOutQ.ToolTipText = "Output queues"
        '
        'MsgwSearchTimer
        '
        Me.MsgwSearchTimer.Enabled = True
        Me.MsgwSearchTimer.Interval = 900000
        '
        'BackgroundMsgwSearch
        '
        Me.BackgroundMsgwSearch.WorkerReportsProgress = True
        Me.BackgroundMsgwSearch.WorkerSupportsCancellation = True
        '
        'OutputQueueEntriesToolStripMenuItem
        '
        Me.OutputQueueEntriesToolStripMenuItem.Image = CType(resources.GetObject("OutputQueueEntriesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OutputQueueEntriesToolStripMenuItem.Name = "OutputQueueEntriesToolStripMenuItem"
        Me.OutputQueueEntriesToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.OutputQueueEntriesToolStripMenuItem.Size = New System.Drawing.Size(259, 30)
        Me.OutputQueueEntriesToolStripMenuItem.Text = "Output queue entries"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(256, 6)
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(256, 6)
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(256, 6)
        '
        'TlStrpOutQEntries
        '
        Me.TlStrpOutQEntries.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TlStrpOutQEntries.Image = CType(resources.GetObject("TlStrpOutQEntries.Image"), System.Drawing.Image)
        Me.TlStrpOutQEntries.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TlStrpOutQEntries.Name = "TlStrpOutQEntries"
        Me.TlStrpOutQEntries.Size = New System.Drawing.Size(28, 28)
        Me.TlStrpOutQEntries.Text = "ToolStripButton1"
        Me.TlStrpOutQEntries.ToolTipText = "Output queue entries"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 830)
        Me.Controls.Add(Me.MnuToolStrip)
        Me.Controls.Add(Me.StsStrpMain)
        Me.Controls.Add(Me.MnuStrpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MnuStrpMain
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Control for IBM i®"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuStrpMain.ResumeLayout(False)
        Me.MnuStrpMain.PerformLayout()
        Me.StsStrpMain.ResumeLayout(False)
        Me.StsStrpMain.PerformLayout()
        Me.MnuToolStrip.ResumeLayout(False)
        Me.MnuToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuStrpMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActiveJobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StsStrpMain As StatusStrip
    Friend WithEvents StrpLabelUser As ToolStripStatusLabel
    Friend WithEvents StrpLabelHost As ToolStripStatusLabel
    Friend WithEvents JobLogsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsrInfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MnuToolStrip As ToolStrip
    Friend WithEvents TlStrpActJob As ToolStripButton
    Friend WithEvents TlStrpUsrPrf As ToolStripButton
    Friend WithEvents TlStrpJobLog As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents MsgwSearchTimer As Timer
    Friend WithEvents BackgroundMsgwSearch As System.ComponentModel.BackgroundWorker
    Friend WithEvents ToolStripStsLblMsgwSearch As ToolStripStatusLabel
    Friend WithEvents OutputQueuesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TlStrpOutQ As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents OutputQueueEntriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents TlStrpOutQEntries As ToolStripButton
End Class
