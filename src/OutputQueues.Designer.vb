<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OutputQueues
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OutputQueues))
        Me.DtaGrdOutQ = New MetroFramework.Controls.MetroGrid()
        Me.ToolStripRecordsSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripMessage = New System.Windows.Forms.ToolStripStatusLabel()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.TxtBoxOutQName = New System.Windows.Forms.TextBox()
        Me.LblOutQ = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.TxtBoxOutQLib = New System.Windows.Forms.TextBox()
        Me.LblOutQlIb = New System.Windows.Forms.Label()
        Me.CntMnuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.HoldOutqueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReleaseOutqueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayEntriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayJoblogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearOutputQueueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DisplayActiveJobToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DtaGrdOutQ, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        Me.CntMnuStrip.SuspendLayout()
        Me.SuspendLayout()
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtaGrdOutQ.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DtaGrdOutQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DtaGrdOutQ.DefaultCellStyle = DataGridViewCellStyle8
        Me.DtaGrdOutQ.EnableHeadersVisualStyles = False
        Me.DtaGrdOutQ.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.DtaGrdOutQ.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DtaGrdOutQ.Location = New System.Drawing.Point(3, 72)
        Me.DtaGrdOutQ.Name = "DtaGrdOutQ"
        Me.DtaGrdOutQ.ReadOnly = True
        Me.DtaGrdOutQ.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(173, Byte), Integer))
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(206, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtaGrdOutQ.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.DtaGrdOutQ.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DtaGrdOutQ.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdOutQ.ShowCellErrors = False
        Me.DtaGrdOutQ.ShowCellToolTips = False
        Me.DtaGrdOutQ.ShowEditingIcon = False
        Me.DtaGrdOutQ.ShowRowErrors = False
        Me.DtaGrdOutQ.Size = New System.Drawing.Size(1350, 532)
        Me.DtaGrdOutQ.Style = MetroFramework.MetroColorStyle.Teal
        Me.DtaGrdOutQ.TabIndex = 5
        '
        'ToolStripRecordsSelected
        '
        Me.ToolStripRecordsSelected.Name = "ToolStripRecordsSelected"
        Me.ToolStripRecordsSelected.Size = New System.Drawing.Size(139, 17)
        Me.ToolStripRecordsSelected.Text = "ToolStripRecordsSelected"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripRecordsSelected, Me.ToolStripMessage})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 610)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1358, 22)
        Me.StatusStrip.TabIndex = 74
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripMessage
        '
        Me.ToolStripMessage.Name = "ToolStripMessage"
        Me.ToolStripMessage.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripMessage.Text = "ToolStripMessage"
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(17, 85)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 65
        Me.LblWait.Text = "LblStatus"
        '
        'TxtBoxOutQName
        '
        Me.TxtBoxOutQName.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxOutQName.Location = New System.Drawing.Point(1258, 13)
        Me.TxtBoxOutQName.MaxLength = 10
        Me.TxtBoxOutQName.Name = "TxtBoxOutQName"
        Me.TxtBoxOutQName.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxOutQName.TabIndex = 1
        '
        'LblOutQ
        '
        Me.LblOutQ.AutoSize = True
        Me.LblOutQ.Location = New System.Drawing.Point(1217, 16)
        Me.LblOutQ.Name = "LblOutQ"
        Me.LblOutQ.Size = New System.Drawing.Size(35, 13)
        Me.LblOutQ.TabIndex = 67
        Me.LblOutQ.Text = "Name"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(129, 21)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(69, 34)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(1, 56)
        Me.PrgBar.MarqueeAnimationSpeed = 70
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(203, 10)
        Me.PrgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PrgBar.TabIndex = 66
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(4, 21)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(120, 34)
        Me.BtnGet.TabIndex = 3
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(333, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Results:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Success:"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(384, 31)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 62
        Me.LblResults.Text = "LblResults"
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(261, 31)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 61
        Me.LblSuccess.Text = "LblSuccess"
        '
        'TxtBoxOutQLib
        '
        Me.TxtBoxOutQLib.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxOutQLib.Location = New System.Drawing.Point(1258, 39)
        Me.TxtBoxOutQLib.MaxLength = 10
        Me.TxtBoxOutQLib.Name = "TxtBoxOutQLib"
        Me.TxtBoxOutQLib.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxOutQLib.TabIndex = 2
        '
        'LblOutQlIb
        '
        Me.LblOutQlIb.AutoSize = True
        Me.LblOutQlIb.Location = New System.Drawing.Point(1217, 42)
        Me.LblOutQlIb.Name = "LblOutQlIb"
        Me.LblOutQlIb.Size = New System.Drawing.Size(38, 13)
        Me.LblOutQlIb.TabIndex = 76
        Me.LblOutQlIb.Text = "Library"
        '
        'CntMnuStrip
        '
        Me.CntMnuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CntMnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HoldOutqueueToolStripMenuItem, Me.ReleaseOutqueueToolStripMenuItem, Me.ToolStripSeparator1, Me.DisplayEntriesToolStripMenuItem, Me.ToolStripSeparator2, Me.DisplayActiveJobToolStripMenuItem, Me.DisplayJoblogToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearOutputQueueToolStripMenuItem})
        Me.CntMnuStrip.Name = "CntMnuStrip"
        Me.CntMnuStrip.Size = New System.Drawing.Size(197, 202)
        '
        'HoldOutqueueToolStripMenuItem
        '
        Me.HoldOutqueueToolStripMenuItem.Image = CType(resources.GetObject("HoldOutqueueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HoldOutqueueToolStripMenuItem.Name = "HoldOutqueueToolStripMenuItem"
        Me.HoldOutqueueToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.HoldOutqueueToolStripMenuItem.Text = "Hold output queue"
        '
        'ReleaseOutqueueToolStripMenuItem
        '
        Me.ReleaseOutqueueToolStripMenuItem.Image = CType(resources.GetObject("ReleaseOutqueueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReleaseOutqueueToolStripMenuItem.Name = "ReleaseOutqueueToolStripMenuItem"
        Me.ReleaseOutqueueToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.ReleaseOutqueueToolStripMenuItem.Text = "Release output queue"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(193, 6)
        '
        'DisplayEntriesToolStripMenuItem
        '
        Me.DisplayEntriesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayEntriesToolStripMenuItem.Image = CType(resources.GetObject("DisplayEntriesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisplayEntriesToolStripMenuItem.Name = "DisplayEntriesToolStripMenuItem"
        Me.DisplayEntriesToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.DisplayEntriesToolStripMenuItem.Text = "Display entries"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(193, 6)
        '
        'DisplayJoblogToolStripMenuItem
        '
        Me.DisplayJoblogToolStripMenuItem.Image = CType(resources.GetObject("DisplayJoblogToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisplayJoblogToolStripMenuItem.Name = "DisplayJoblogToolStripMenuItem"
        Me.DisplayJoblogToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.DisplayJoblogToolStripMenuItem.Text = "Display job log"
        '
        'ClearOutputQueueToolStripMenuItem
        '
        Me.ClearOutputQueueToolStripMenuItem.Image = CType(resources.GetObject("ClearOutputQueueToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClearOutputQueueToolStripMenuItem.Name = "ClearOutputQueueToolStripMenuItem"
        Me.ClearOutputQueueToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.ClearOutputQueueToolStripMenuItem.Text = "Clear output queue"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(193, 6)
        '
        'DisplayActiveJobToolStripMenuItem
        '
        Me.DisplayActiveJobToolStripMenuItem.Image = CType(resources.GetObject("DisplayActiveJobToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisplayActiveJobToolStripMenuItem.Name = "DisplayActiveJobToolStripMenuItem"
        Me.DisplayActiveJobToolStripMenuItem.Size = New System.Drawing.Size(196, 30)
        Me.DisplayActiveJobToolStripMenuItem.Text = "Display active jobs"
        '
        'OutputQueues
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1358, 632)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.TxtBoxOutQLib)
        Me.Controls.Add(Me.LblOutQlIb)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TxtBoxOutQName)
        Me.Controls.Add(Me.LblOutQ)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PrgBar)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.DtaGrdOutQ)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "OutputQueues"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Output queues informations"
        CType(Me.DtaGrdOutQ, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.CntMnuStrip.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtaGrdOutQ As MetroFramework.Controls.MetroGrid
    Friend WithEvents ToolStripRecordsSelected As ToolStripStatusLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripMessage As ToolStripStatusLabel
    Friend WithEvents LblWait As Label
    Friend WithEvents TxtBoxOutQName As TextBox
    Friend WithEvents LblOutQ As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PrgBar As ProgressBar
    Friend WithEvents BtnGet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents LblSuccess As Label
    Friend WithEvents TxtBoxOutQLib As TextBox
    Friend WithEvents LblOutQlIb As Label
    Friend WithEvents CntMnuStrip As ContextMenuStrip
    Friend WithEvents HoldOutqueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReleaseOutqueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DisplayEntriesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DisplayJoblogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearOutputQueueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DisplayActiveJobToolStripMenuItem As ToolStripMenuItem
End Class
