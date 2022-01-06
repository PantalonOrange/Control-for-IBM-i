<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ActiveJobs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActiveJobs))
        Me.DtaGrdActJob = New System.Windows.Forms.DataGridView()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.LblJobSts = New System.Windows.Forms.Label()
        Me.LblSubSys = New System.Windows.Forms.Label()
        Me.TxtBoxUsr = New System.Windows.Forms.TextBox()
        Me.LblUsr = New System.Windows.Forms.Label()
        Me.TxtBoxFunction = New System.Windows.Forms.TextBox()
        Me.LblFunction = New System.Windows.Forms.Label()
        Me.CntMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntMnuMsgw = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuEndJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuExcCmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CntMnuDspJobLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuDspUsrPrf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltUsrJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltFct = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CntMnuFltSbs = New System.Windows.Forms.ToolStripMenuItem()
        Me.CmbBoxJobSts = New System.Windows.Forms.ComboBox()
        Me.CmbBoxSbs = New System.Windows.Forms.ComboBox()
        CType(Me.DtaGrdActJob, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntMnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtaGrdActJob
        '
        Me.DtaGrdActJob.AllowUserToAddRows = False
        Me.DtaGrdActJob.AllowUserToDeleteRows = False
        Me.DtaGrdActJob.AllowUserToResizeColumns = False
        Me.DtaGrdActJob.AllowUserToResizeRows = False
        Me.DtaGrdActJob.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DtaGrdActJob.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtaGrdActJob.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtaGrdActJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtaGrdActJob.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtaGrdActJob.Location = New System.Drawing.Point(9, 68)
        Me.DtaGrdActJob.MultiSelect = False
        Me.DtaGrdActJob.Name = "DtaGrdActJob"
        Me.DtaGrdActJob.ReadOnly = True
        Me.DtaGrdActJob.RowHeadersWidth = 62
        Me.DtaGrdActJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdActJob.ShowEditingIcon = False
        Me.DtaGrdActJob.Size = New System.Drawing.Size(1411, 614)
        Me.DtaGrdActJob.TabIndex = 7
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(269, 31)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 1
        Me.LblSuccess.Text = "LblSuccess"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(392, 31)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 2
        Me.LblResults.Text = "LblResults"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Success:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Results:"
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(11, 20)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(120, 34)
        Me.BtnGet.TabIndex = 5
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(22, 79)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 7
        Me.LblWait.Text = "LblStatus"
        Me.LblWait.UseWaitCursor = True
        '
        'LblJobSts
        '
        Me.LblJobSts.AutoSize = True
        Me.LblJobSts.Location = New System.Drawing.Point(1094, 14)
        Me.LblJobSts.Name = "LblJobSts"
        Me.LblJobSts.Size = New System.Drawing.Size(57, 13)
        Me.LblJobSts.TabIndex = 8
        Me.LblJobSts.Text = "Job-Status"
        Me.LblJobSts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSubSys
        '
        Me.LblSubSys.AutoSize = True
        Me.LblSubSys.Location = New System.Drawing.Point(1093, 41)
        Me.LblSubSys.Name = "LblSubSys"
        Me.LblSubSys.Size = New System.Drawing.Size(58, 13)
        Me.LblSubSys.TabIndex = 10
        Me.LblSubSys.Text = "Subsystem"
        Me.LblSubSys.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxUsr
        '
        Me.TxtBoxUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxUsr.Location = New System.Drawing.Point(1324, 11)
        Me.TxtBoxUsr.MaxLength = 10
        Me.TxtBoxUsr.Name = "TxtBoxUsr"
        Me.TxtBoxUsr.Size = New System.Drawing.Size(96, 20)
        Me.TxtBoxUsr.TabIndex = 2
        '
        'LblUsr
        '
        Me.LblUsr.AutoSize = True
        Me.LblUsr.Location = New System.Drawing.Point(1289, 14)
        Me.LblUsr.Name = "LblUsr"
        Me.LblUsr.Size = New System.Drawing.Size(29, 13)
        Me.LblUsr.TabIndex = 12
        Me.LblUsr.Text = "User"
        Me.LblUsr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxFunction
        '
        Me.TxtBoxFunction.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxFunction.Location = New System.Drawing.Point(1324, 38)
        Me.TxtBoxFunction.MaxLength = 10
        Me.TxtBoxFunction.Name = "TxtBoxFunction"
        Me.TxtBoxFunction.Size = New System.Drawing.Size(96, 20)
        Me.TxtBoxFunction.TabIndex = 4
        '
        'LblFunction
        '
        Me.LblFunction.AutoSize = True
        Me.LblFunction.Location = New System.Drawing.Point(1270, 41)
        Me.LblFunction.Name = "LblFunction"
        Me.LblFunction.Size = New System.Drawing.Size(48, 13)
        Me.LblFunction.TabIndex = 14
        Me.LblFunction.Text = "Function"
        Me.LblFunction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CntMnu
        '
        Me.CntMnu.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CntMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuMsgw, Me.CntMnuEndJob, Me.CntMnuExcCmd, Me.ToolStripSeparator1, Me.CntMnuDspJobLog, Me.CntMnuDspUsrPrf, Me.ToolStripSeparator2, Me.GroupFilter})
        Me.CntMnu.Name = "CntMnu"
        Me.CntMnu.Size = New System.Drawing.Size(174, 148)
        '
        'CntMnuMsgw
        '
        Me.CntMnuMsgw.Name = "CntMnuMsgw"
        Me.CntMnuMsgw.Size = New System.Drawing.Size(173, 22)
        Me.CntMnuMsgw.Text = "&Send reply"
        '
        'CntMnuEndJob
        '
        Me.CntMnuEndJob.Name = "CntMnuEndJob"
        Me.CntMnuEndJob.Size = New System.Drawing.Size(173, 22)
        Me.CntMnuEndJob.Text = "&End job"
        '
        'CntMnuExcCmd
        '
        Me.CntMnuExcCmd.Name = "CntMnuExcCmd"
        Me.CntMnuExcCmd.Size = New System.Drawing.Size(173, 22)
        Me.CntMnuExcCmd.Text = "E&xecute command"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'CntMnuDspJobLog
        '
        Me.CntMnuDspJobLog.Name = "CntMnuDspJobLog"
        Me.CntMnuDspJobLog.Size = New System.Drawing.Size(173, 22)
        Me.CntMnuDspJobLog.Text = "Display job log"
        '
        'CntMnuDspUsrPrf
        '
        Me.CntMnuDspUsrPrf.Name = "CntMnuDspUsrPrf"
        Me.CntMnuDspUsrPrf.Size = New System.Drawing.Size(173, 22)
        Me.CntMnuDspUsrPrf.Text = "Display userprofile"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'GroupFilter
        '
        Me.GroupFilter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuFltUsrJob, Me.CntMnuFltFct, Me.CntMnuFltSbs})
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(173, 22)
        Me.GroupFilter.Text = "Filters"
        '
        'CntMnuFltUsrJob
        '
        Me.CntMnuFltUsrJob.Name = "CntMnuFltUsrJob"
        Me.CntMnuFltUsrJob.Size = New System.Drawing.Size(180, 22)
        Me.CntMnuFltUsrJob.Text = "Userprofile"
        '
        'CntMnuFltFct
        '
        Me.CntMnuFltFct.Name = "CntMnuFltFct"
        Me.CntMnuFltFct.Size = New System.Drawing.Size(180, 22)
        Me.CntMnuFltFct.Text = "Function"
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(8, 55)
        Me.PrgBar.MarqueeAnimationSpeed = 70
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(204, 10)
        Me.PrgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PrgBar.TabIndex = 16
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(136, 20)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(69, 34)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CntMnuFltSbs
        '
        Me.CntMnuFltSbs.Name = "CntMnuFltSbs"
        Me.CntMnuFltSbs.Size = New System.Drawing.Size(180, 22)
        Me.CntMnuFltSbs.Text = "Subsystem"
        '
        'CmbBoxJobSts
        '
        Me.CmbBoxJobSts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxJobSts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxJobSts.FormattingEnabled = True
        Me.CmbBoxJobSts.Location = New System.Drawing.Point(1157, 11)
        Me.CmbBoxJobSts.MaxLength = 4
        Me.CmbBoxJobSts.Name = "CmbBoxJobSts"
        Me.CmbBoxJobSts.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxJobSts.TabIndex = 1
        '
        'CmbBoxSbs
        '
        Me.CmbBoxSbs.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxSbs.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxSbs.FormattingEnabled = True
        Me.CmbBoxSbs.Location = New System.Drawing.Point(1157, 37)
        Me.CmbBoxSbs.MaxLength = 10
        Me.CmbBoxSbs.Name = "CmbBoxSbs"
        Me.CmbBoxSbs.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxSbs.TabIndex = 3
        '
        'ActiveJobs
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1435, 696)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.CmbBoxSbs)
        Me.Controls.Add(Me.CmbBoxJobSts)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PrgBar)
        Me.Controls.Add(Me.TxtBoxFunction)
        Me.Controls.Add(Me.LblFunction)
        Me.Controls.Add(Me.TxtBoxUsr)
        Me.Controls.Add(Me.LblUsr)
        Me.Controls.Add(Me.LblSubSys)
        Me.Controls.Add(Me.LblJobSts)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.DtaGrdActJob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "ActiveJobs"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Active jobs"
        CType(Me.DtaGrdActJob, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntMnu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtaGrdActJob As DataGridView
    Friend WithEvents LblSuccess As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGet As Button
    Friend WithEvents LblWait As Label
    Friend WithEvents LblJobSts As Label
    Friend WithEvents LblSubSys As Label
    Friend WithEvents TxtBoxUsr As TextBox
    Friend WithEvents LblUsr As Label
    Friend WithEvents TxtBoxFunction As TextBox
    Friend WithEvents LblFunction As Label
    Friend WithEvents CntMnu As ContextMenuStrip
    Friend WithEvents CntMnuMsgw As ToolStripMenuItem
    Friend WithEvents CntMnuEndJob As ToolStripMenuItem
    Friend WithEvents PrgBar As ProgressBar
    Friend WithEvents CntMnuExcCmd As ToolStripMenuItem
    Friend WithEvents CntMnuDspJobLog As ToolStripMenuItem
    Friend WithEvents CntMnuDspUsrPrf As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents GroupFilter As ToolStripMenuItem
    Friend WithEvents CntMnuFltUsrJob As ToolStripMenuItem
    Friend WithEvents CntMnuFltFct As ToolStripMenuItem
    Friend WithEvents BtnClose As Button
    Friend WithEvents CntMnuFltSbs As ToolStripMenuItem
    Friend WithEvents CmbBoxJobSts As ComboBox
    Friend WithEvents CmbBoxSbs As ComboBox
End Class
