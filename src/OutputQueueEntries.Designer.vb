<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OutputQueueEntries
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputQueueEntries))
        Me.TxtBoxOutQLib = New System.Windows.Forms.TextBox()
        Me.LblOutQlIb = New System.Windows.Forms.Label()
        Me.DtaGrdOutQ = New MetroFramework.Controls.MetroGrid()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.TxtBoxOutQName = New System.Windows.Forms.TextBox()
        Me.LblOutQ = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.ToolStripMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripRecordsSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxUsr = New System.Windows.Forms.TextBox()
        Me.LblUsr = New System.Windows.Forms.Label()
        Me.TxtBoxSplF = New System.Windows.Forms.TextBox()
        Me.LblSplF = New System.Windows.Forms.Label()
        Me.CmbBoxMax = New System.Windows.Forms.ComboBox()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.CntMnuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DeleteSpooledFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HoldSpooledFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseSpooledFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ChangeOutputQueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayActiveJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DtaGrdOutQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.CntMnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBoxOutQLib
        '
        Me.TxtBoxOutQLib.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxOutQLib.Location = New System.Drawing.Point(1058, 40)
        Me.TxtBoxOutQLib.MaxLength = 10
        Me.TxtBoxOutQLib.Name = "TxtBoxOutQLib"
        Me.TxtBoxOutQLib.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxOutQLib.TabIndex = 2
        '
        'LblOutQlIb
        '
        Me.LblOutQlIb.AutoSize = True
        Me.LblOutQlIb.Location = New System.Drawing.Point(1017, 43)
        Me.LblOutQlIb.Name = "LblOutQlIb"
        Me.LblOutQlIb.Size = New System.Drawing.Size(38, 13)
        Me.LblOutQlIb.TabIndex = 90
        Me.LblOutQlIb.Text = "Library"
        '
        'DtaGrdOutQ
        '
        Me.DtaGrdOutQ.AllowUserToAddRows = False
        Me.DtaGrdOutQ.AllowUserToDeleteRows = False
        Me.DtaGrdOutQ.AllowUserToOrderColumns = True
        Me.DtaGrdOutQ.AllowUserToResizeColumns = False
        Me.DtaGrdOutQ.AllowUserToResizeRows = False
        Me.DtaGrdOutQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DtaGrdOutQ.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtaGrdOutQ.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtaGrdOutQ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DtaGrdOutQ.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DtaGrdOutQ.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtaGrdOutQ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DtaGrdOutQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtaGrdOutQ.DefaultCellStyle = DataGridViewCellStyle5
        Me.DtaGrdOutQ.EnableHeadersVisualStyles = False
        Me.DtaGrdOutQ.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DtaGrdOutQ.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtaGrdOutQ.Location = New System.Drawing.Point(4, 70)
        Me.DtaGrdOutQ.Name = "DtaGrdOutQ"
        Me.DtaGrdOutQ.ReadOnly = True
        Me.DtaGrdOutQ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(165, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtaGrdOutQ.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DtaGrdOutQ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtaGrdOutQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdOutQ.ShowCellErrors = False
        Me.DtaGrdOutQ.ShowCellToolTips = False
        Me.DtaGrdOutQ.ShowEditingIcon = False
        Me.DtaGrdOutQ.ShowRowErrors = False
        Me.DtaGrdOutQ.Size = New System.Drawing.Size(1439, 758)
        Me.DtaGrdOutQ.Style = MetroFramework.MetroColorStyle.Brown
        Me.DtaGrdOutQ.TabIndex = 8
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(17, 80)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 86
        Me.LblWait.Text = "LblStatus"
        '
        'TxtBoxOutQName
        '
        Me.TxtBoxOutQName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxOutQName.Location = New System.Drawing.Point(1058, 14)
        Me.TxtBoxOutQName.MaxLength = 10
        Me.TxtBoxOutQName.Name = "TxtBoxOutQName"
        Me.TxtBoxOutQName.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxOutQName.TabIndex = 1
        '
        'LblOutQ
        '
        Me.LblOutQ.AutoSize = True
        Me.LblOutQ.Location = New System.Drawing.Point(1017, 17)
        Me.LblOutQ.Name = "LblOutQ"
        Me.LblOutQ.Size = New System.Drawing.Size(35, 13)
        Me.LblOutQ.TabIndex = 88
        Me.LblOutQ.Text = "Name"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(137, 22)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(69, 34)
        Me.BtnClose.TabIndex = 7
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(9, 57)
        Me.PrgBar.MarqueeAnimationSpeed = 70
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(203, 10)
        Me.PrgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PrgBar.TabIndex = 87
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Results:"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(392, 32)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 83
        Me.LblResults.Text = "LblResults"
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(269, 32)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 82
        Me.LblSuccess.Text = "LblSuccess"
        '
        'ToolStripMessage
        '
        Me.ToolStripMessage.Name = "ToolStripMessage"
        Me.ToolStripMessage.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripMessage.Text = "ToolStripMessage"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripRecordsSelected, Me.ToolStripMessage})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 831)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1445, 22)
        Me.StatusStrip.TabIndex = 89
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripRecordsSelected
        '
        Me.ToolStripRecordsSelected.Name = "ToolStripRecordsSelected"
        Me.ToolStripRecordsSelected.Size = New System.Drawing.Size(139, 17)
        Me.ToolStripRecordsSelected.Text = "ToolStripRecordsSelected"
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(12, 22)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(120, 34)
        Me.BtnGet.TabIndex = 6
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Success:"
        '
        'TxtBoxUsr
        '
        Me.TxtBoxUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxUsr.Location = New System.Drawing.Point(1212, 15)
        Me.TxtBoxUsr.MaxLength = 10
        Me.TxtBoxUsr.Name = "TxtBoxUsr"
        Me.TxtBoxUsr.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxUsr.TabIndex = 3
        '
        'LblUsr
        '
        Me.LblUsr.AutoSize = True
        Me.LblUsr.Location = New System.Drawing.Point(1177, 17)
        Me.LblUsr.Name = "LblUsr"
        Me.LblUsr.Size = New System.Drawing.Size(29, 13)
        Me.LblUsr.TabIndex = 92
        Me.LblUsr.Text = "User"
        '
        'TxtBoxSplF
        '
        Me.TxtBoxSplF.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxSplF.Location = New System.Drawing.Point(1212, 41)
        Me.TxtBoxSplF.MaxLength = 10
        Me.TxtBoxSplF.Name = "TxtBoxSplF"
        Me.TxtBoxSplF.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxSplF.TabIndex = 4
        '
        'LblSplF
        '
        Me.LblSplF.AutoSize = True
        Me.LblSplF.Location = New System.Drawing.Point(1159, 43)
        Me.LblSplF.Name = "LblSplF"
        Me.LblSplF.Size = New System.Drawing.Size(47, 13)
        Me.LblSplF.TabIndex = 94
        Me.LblSplF.Text = "Spoolfile"
        '
        'CmbBoxMax
        '
        Me.CmbBoxMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMax.FormattingEnabled = True
        Me.CmbBoxMax.Items.AddRange(New Object() {"10", "20", "50", "100", "200", "500", "1000", "99999"})
        Me.CmbBoxMax.Location = New System.Drawing.Point(1369, 16)
        Me.CmbBoxMax.Name = "CmbBoxMax"
        Me.CmbBoxMax.Size = New System.Drawing.Size(64, 21)
        Me.CmbBoxMax.TabIndex = 5
        Me.CmbBoxMax.TabStop = False
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblMax.Location = New System.Drawing.Point(1316, 18)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(47, 13)
        Me.LblMax.TabIndex = 96
        Me.LblMax.Text = "Records"
        '
        'CntMnuStrip
        '
        Me.CntMnuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CntMnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteSpooledFileToolStripMenuItem, Me.ToolStripSeparator1, Me.HoldSpooledFileToolStripMenuItem, Me.ReleaseSpooledFileToolStripMenuItem, Me.ToolStripSeparator2, Me.ChangeOutputQueueToolStripMenuItem, Me.ToolStripSeparator3, Me.DisplayActiveJobsToolStripMenuItem})
        Me.CntMnuStrip.Name = "CntMnuStrip"
        Me.CntMnuStrip.Size = New System.Drawing.Size(208, 194)
        '
        'DeleteSpooledFileToolStripMenuItem
        '
        Me.DeleteSpooledFileToolStripMenuItem.Image = CType(resources.GetObject("DeleteSpooledFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeleteSpooledFileToolStripMenuItem.Name = "DeleteSpooledFileToolStripMenuItem"
        Me.DeleteSpooledFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete
        Me.DeleteSpooledFileToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.DeleteSpooledFileToolStripMenuItem.Text = "Delete spooled file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(204, 6)
        '
        'HoldSpooledFileToolStripMenuItem
        '
        Me.HoldSpooledFileToolStripMenuItem.Image = CType(resources.GetObject("HoldSpooledFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HoldSpooledFileToolStripMenuItem.Name = "HoldSpooledFileToolStripMenuItem"
        Me.HoldSpooledFileToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.HoldSpooledFileToolStripMenuItem.Text = "Hold spooled file"
        '
        'ReleaseSpooledFileToolStripMenuItem
        '
        Me.ReleaseSpooledFileToolStripMenuItem.Image = CType(resources.GetObject("ReleaseSpooledFileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleaseSpooledFileToolStripMenuItem.Name = "ReleaseSpooledFileToolStripMenuItem"
        Me.ReleaseSpooledFileToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.ReleaseSpooledFileToolStripMenuItem.Text = "Release spooled file"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'ChangeOutputQueueToolStripMenuItem
        '
        Me.ChangeOutputQueueToolStripMenuItem.Image = CType(resources.GetObject("ChangeOutputQueueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeOutputQueueToolStripMenuItem.Name = "ChangeOutputQueueToolStripMenuItem"
        Me.ChangeOutputQueueToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.ChangeOutputQueueToolStripMenuItem.Text = "Change output queue"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'DisplayActiveJobsToolStripMenuItem
        '
        Me.DisplayActiveJobsToolStripMenuItem.Image = CType(resources.GetObject("DisplayActiveJobsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisplayActiveJobsToolStripMenuItem.Name = "DisplayActiveJobsToolStripMenuItem"
        Me.DisplayActiveJobsToolStripMenuItem.Size = New System.Drawing.Size(207, 30)
        Me.DisplayActiveJobsToolStripMenuItem.Text = "Display active jobs"
        '
        'OutputQueueEntries
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1445, 853)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.CmbBoxMax)
        Me.Controls.Add(Me.LblMax)
        Me.Controls.Add(Me.TxtBoxSplF)
        Me.Controls.Add(Me.LblSplF)
        Me.Controls.Add(Me.TxtBoxUsr)
        Me.Controls.Add(Me.LblUsr)
        Me.Controls.Add(Me.TxtBoxOutQLib)
        Me.Controls.Add(Me.LblOutQlIb)
        Me.Controls.Add(Me.TxtBoxOutQName)
        Me.Controls.Add(Me.LblOutQ)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PrgBar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DtaGrdOutQ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "OutputQueueEntries"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Output queue entries"
        CType(Me.DtaGrdOutQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.CntMnuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBoxOutQLib As TextBox
    Friend WithEvents LblOutQlIb As Label
    Friend WithEvents DtaGrdOutQ As MetroFramework.Controls.MetroGrid
    Friend WithEvents LblWait As Label
    Friend WithEvents TxtBoxOutQName As TextBox
    Friend WithEvents LblOutQ As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PrgBar As ProgressBar
    Friend WithEvents Label2 As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents LblSuccess As Label
    Friend WithEvents ToolStripMessage As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripRecordsSelected As ToolStripStatusLabel
    Friend WithEvents BtnGet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxUsr As TextBox
    Friend WithEvents LblUsr As Label
    Friend WithEvents TxtBoxSplF As TextBox
    Friend WithEvents LblSplF As Label
    Friend WithEvents CmbBoxMax As ComboBox
    Friend WithEvents LblMax As Label
    Friend WithEvents CntMnuStrip As ContextMenuStrip
    Friend WithEvents DeleteSpooledFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HoldSpooledFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseSpooledFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeOutputQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DisplayActiveJobsToolStripMenuItem As ToolStripMenuItem
End Class
