<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.MnuStrpMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OperationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActiveJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StsStrpMain = New System.Windows.Forms.StatusStrip()
        Me.StrpLabelUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StrpLabelHost = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuStrpMain.SuspendLayout()
        Me.StsStrpMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuStrpMain
        '
        Me.MnuStrpMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MnuStrpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.OperationsToolStripMenuItem})
        Me.MnuStrpMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuStrpMain.Name = "MnuStrpMain"
        Me.MnuStrpMain.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MnuStrpMain.Size = New System.Drawing.Size(1206, 24)
        Me.MnuStrpMain.TabIndex = 1
        Me.MnuStrpMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'OperationsToolStripMenuItem
        '
        Me.OperationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActiveJobsToolStripMenuItem})
        Me.OperationsToolStripMenuItem.Name = "OperationsToolStripMenuItem"
        Me.OperationsToolStripMenuItem.Size = New System.Drawing.Size(77, 22)
        Me.OperationsToolStripMenuItem.Text = "&Operations"
        '
        'ActiveJobsToolStripMenuItem
        '
        Me.ActiveJobsToolStripMenuItem.Name = "ActiveJobsToolStripMenuItem"
        Me.ActiveJobsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ActiveJobsToolStripMenuItem.Text = "&Active jobs"
        '
        'StsStrpMain
        '
        Me.StsStrpMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StsStrpMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StrpLabelUser, Me.StrpLabelHost})
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
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1206, 830)
        Me.Controls.Add(Me.StsStrpMain)
        Me.Controls.Add(Me.MnuStrpMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MnuStrpMain
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IBM i Control"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuStrpMain.ResumeLayout(False)
        Me.MnuStrpMain.PerformLayout()
        Me.StsStrpMain.ResumeLayout(False)
        Me.StsStrpMain.PerformLayout()
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
End Class
