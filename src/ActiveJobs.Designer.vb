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
        Me.CntMnuEndJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuMsgw = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuExcCmd = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CntMnuDspJobLog = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuDspUsrPrf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltUsrJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltFct = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltSbs = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuFltJobTyp = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupOperations = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuSndBrkMsg = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.CntMnuStrPrt = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuEndPrt = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CntMnuHldJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuRlsJob = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.CmbBoxJobSts = New System.Windows.Forms.ComboBox()
        Me.CmbBoxSbs = New System.Windows.Forms.ComboBox()
        Me.CmbBoxJobTyp = New System.Windows.Forms.ComboBox()
        Me.LblJobTyp = New System.Windows.Forms.Label()
        Me.TxtBoxJobNameShort = New System.Windows.Forms.TextBox()
        Me.LblJobNameShort = New System.Windows.Forms.Label()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.CntMnuHldOutQ = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuRlsOutQ = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.DtaGrdActJob.Name = "DtaGrdActJob"
        Me.DtaGrdActJob.ReadOnly = True
        Me.DtaGrdActJob.RowHeadersWidth = 62
        Me.DtaGrdActJob.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdActJob.ShowEditingIcon = False
        Me.DtaGrdActJob.Size = New System.Drawing.Size(1411, 614)
        Me.DtaGrdActJob.TabIndex = 9
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
        Me.BtnGet.TabIndex = 7
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
        Me.LblJobSts.Location = New System.Drawing.Point(947, 15)
        Me.LblJobSts.Name = "LblJobSts"
        Me.LblJobSts.Size = New System.Drawing.Size(57, 13)
        Me.LblJobSts.TabIndex = 8
        Me.LblJobSts.Text = "Job-Status"
        Me.LblJobSts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblSubSys
        '
        Me.LblSubSys.AutoSize = True
        Me.LblSubSys.Location = New System.Drawing.Point(946, 42)
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
        Me.TxtBoxUsr.TabIndex = 3
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
        Me.TxtBoxFunction.TabIndex = 6
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
        Me.CntMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuEndJob, Me.CntMnuMsgw, Me.CntMnuExcCmd, Me.ToolStripSeparator1, Me.CntMnuDspJobLog, Me.CntMnuDspUsrPrf, Me.ToolStripSeparator2, Me.GroupFilter, Me.ToolStripSeparator3, Me.GroupOperations})
        Me.CntMnu.Name = "CntMnu"
        Me.CntMnu.Size = New System.Drawing.Size(189, 254)
        '
        'CntMnuEndJob
        '
        Me.CntMnuEndJob.Image = CType(resources.GetObject("CntMnuEndJob.Image"), System.Drawing.Image)
        Me.CntMnuEndJob.Name = "CntMnuEndJob"
        Me.CntMnuEndJob.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuEndJob.Text = "&End job"
        '
        'CntMnuMsgw
        '
        Me.CntMnuMsgw.Image = CType(resources.GetObject("CntMnuMsgw.Image"), System.Drawing.Image)
        Me.CntMnuMsgw.Name = "CntMnuMsgw"
        Me.CntMnuMsgw.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuMsgw.Text = "&Send reply"
        '
        'CntMnuExcCmd
        '
        Me.CntMnuExcCmd.Image = CType(resources.GetObject("CntMnuExcCmd.Image"), System.Drawing.Image)
        Me.CntMnuExcCmd.Name = "CntMnuExcCmd"
        Me.CntMnuExcCmd.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuExcCmd.Text = "E&xecute command"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(185, 6)
        '
        'CntMnuDspJobLog
        '
        Me.CntMnuDspJobLog.Image = CType(resources.GetObject("CntMnuDspJobLog.Image"), System.Drawing.Image)
        Me.CntMnuDspJobLog.Name = "CntMnuDspJobLog"
        Me.CntMnuDspJobLog.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuDspJobLog.Text = "Display job log"
        '
        'CntMnuDspUsrPrf
        '
        Me.CntMnuDspUsrPrf.Image = CType(resources.GetObject("CntMnuDspUsrPrf.Image"), System.Drawing.Image)
        Me.CntMnuDspUsrPrf.Name = "CntMnuDspUsrPrf"
        Me.CntMnuDspUsrPrf.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuDspUsrPrf.Text = "Display userprofile"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(185, 6)
        '
        'GroupFilter
        '
        Me.GroupFilter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuFltUsrJob, Me.CntMnuFltFct, Me.CntMnuFltSbs, Me.CntMnuFltJobTyp})
        Me.GroupFilter.Name = "GroupFilter"
        Me.GroupFilter.Size = New System.Drawing.Size(188, 30)
        Me.GroupFilter.Text = "Filters"
        '
        'CntMnuFltUsrJob
        '
        Me.CntMnuFltUsrJob.Image = CType(resources.GetObject("CntMnuFltUsrJob.Image"), System.Drawing.Image)
        Me.CntMnuFltUsrJob.Name = "CntMnuFltUsrJob"
        Me.CntMnuFltUsrJob.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuFltUsrJob.Text = "Userprofile"
        '
        'CntMnuFltFct
        '
        Me.CntMnuFltFct.Image = CType(resources.GetObject("CntMnuFltFct.Image"), System.Drawing.Image)
        Me.CntMnuFltFct.Name = "CntMnuFltFct"
        Me.CntMnuFltFct.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuFltFct.Text = "Function"
        '
        'CntMnuFltSbs
        '
        Me.CntMnuFltSbs.Image = CType(resources.GetObject("CntMnuFltSbs.Image"), System.Drawing.Image)
        Me.CntMnuFltSbs.Name = "CntMnuFltSbs"
        Me.CntMnuFltSbs.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuFltSbs.Text = "Subsystem"
        '
        'CntMnuFltJobTyp
        '
        Me.CntMnuFltJobTyp.Image = CType(resources.GetObject("CntMnuFltJobTyp.Image"), System.Drawing.Image)
        Me.CntMnuFltJobTyp.Name = "CntMnuFltJobTyp"
        Me.CntMnuFltJobTyp.Size = New System.Drawing.Size(188, 30)
        Me.CntMnuFltJobTyp.Text = "Job type"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(185, 6)
        '
        'GroupOperations
        '
        Me.GroupOperations.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuSndBrkMsg, Me.ToolStripSeparator4, Me.CntMnuStrPrt, Me.CntMnuEndPrt, Me.ToolStripSeparator5, Me.CntMnuHldJob, Me.CntMnuRlsJob, Me.ToolStripSeparator6, Me.CntMnuHldOutQ, Me.CntMnuRlsOutQ})
        Me.GroupOperations.Name = "GroupOperations"
        Me.GroupOperations.Size = New System.Drawing.Size(188, 30)
        Me.GroupOperations.Text = "&Operations"
        '
        'CntMnuSndBrkMsg
        '
        Me.CntMnuSndBrkMsg.Image = CType(resources.GetObject("CntMnuSndBrkMsg.Image"), System.Drawing.Image)
        Me.CntMnuSndBrkMsg.Name = "CntMnuSndBrkMsg"
        Me.CntMnuSndBrkMsg.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuSndBrkMsg.Text = "Send &break message to job"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(220, 6)
        '
        'CntMnuStrPrt
        '
        Me.CntMnuStrPrt.Image = CType(resources.GetObject("CntMnuStrPrt.Image"), System.Drawing.Image)
        Me.CntMnuStrPrt.Name = "CntMnuStrPrt"
        Me.CntMnuStrPrt.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuStrPrt.Text = "Start &printer"
        '
        'CntMnuEndPrt
        '
        Me.CntMnuEndPrt.Image = CType(resources.GetObject("CntMnuEndPrt.Image"), System.Drawing.Image)
        Me.CntMnuEndPrt.Name = "CntMnuEndPrt"
        Me.CntMnuEndPrt.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuEndPrt.Text = "&End printer"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(220, 6)
        '
        'CntMnuHldJob
        '
        Me.CntMnuHldJob.Image = CType(resources.GetObject("CntMnuHldJob.Image"), System.Drawing.Image)
        Me.CntMnuHldJob.Name = "CntMnuHldJob"
        Me.CntMnuHldJob.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuHldJob.Text = "Hold job"
        '
        'CntMnuRlsJob
        '
        Me.CntMnuRlsJob.Image = CType(resources.GetObject("CntMnuRlsJob.Image"), System.Drawing.Image)
        Me.CntMnuRlsJob.Name = "CntMnuRlsJob"
        Me.CntMnuRlsJob.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuRlsJob.Text = "Release job"
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
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'CmbBoxJobSts
        '
        Me.CmbBoxJobSts.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxJobSts.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxJobSts.FormattingEnabled = True
        Me.CmbBoxJobSts.Location = New System.Drawing.Point(1010, 12)
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
        Me.CmbBoxSbs.Location = New System.Drawing.Point(1010, 38)
        Me.CmbBoxSbs.MaxLength = 10
        Me.CmbBoxSbs.Name = "CmbBoxSbs"
        Me.CmbBoxSbs.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxSbs.TabIndex = 4
        '
        'CmbBoxJobTyp
        '
        Me.CmbBoxJobTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxJobTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxJobTyp.FormattingEnabled = True
        Me.CmbBoxJobTyp.Location = New System.Drawing.Point(1168, 12)
        Me.CmbBoxJobTyp.MaxLength = 3
        Me.CmbBoxJobTyp.Name = "CmbBoxJobTyp"
        Me.CmbBoxJobTyp.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxJobTyp.TabIndex = 2
        '
        'LblJobTyp
        '
        Me.LblJobTyp.AutoSize = True
        Me.LblJobTyp.Location = New System.Drawing.Point(1111, 15)
        Me.LblJobTyp.Name = "LblJobTyp"
        Me.LblJobTyp.Size = New System.Drawing.Size(51, 13)
        Me.LblJobTyp.TabIndex = 18
        Me.LblJobTyp.Text = "Job-Type"
        Me.LblJobTyp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxJobNameShort
        '
        Me.TxtBoxJobNameShort.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxJobNameShort.Location = New System.Drawing.Point(1168, 38)
        Me.TxtBoxJobNameShort.MaxLength = 10
        Me.TxtBoxJobNameShort.Name = "TxtBoxJobNameShort"
        Me.TxtBoxJobNameShort.Size = New System.Drawing.Size(96, 20)
        Me.TxtBoxJobNameShort.TabIndex = 5
        '
        'LblJobNameShort
        '
        Me.LblJobNameShort.AutoSize = True
        Me.LblJobNameShort.Location = New System.Drawing.Point(1112, 41)
        Me.LblJobNameShort.Name = "LblJobNameShort"
        Me.LblJobNameShort.Size = New System.Drawing.Size(50, 13)
        Me.LblJobNameShort.TabIndex = 20
        Me.LblJobNameShort.Text = "Jobname"
        Me.LblJobNameShort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(220, 6)
        '
        'CntMnuHldOutQ
        '
        Me.CntMnuHldOutQ.Image = CType(resources.GetObject("CntMnuHldOutQ.Image"), System.Drawing.Image)
        Me.CntMnuHldOutQ.Name = "CntMnuHldOutQ"
        Me.CntMnuHldOutQ.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuHldOutQ.Text = "Hold outqueue"
        '
        'CntMnuRlsOutQ
        '
        Me.CntMnuRlsOutQ.Image = CType(resources.GetObject("CntMnuRlsOutQ.Image"), System.Drawing.Image)
        Me.CntMnuRlsOutQ.Name = "CntMnuRlsOutQ"
        Me.CntMnuRlsOutQ.Size = New System.Drawing.Size(223, 30)
        Me.CntMnuRlsOutQ.Text = "Release outqueue"
        '
        'ActiveJobs
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1431, 692)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.TxtBoxJobNameShort)
        Me.Controls.Add(Me.LblJobNameShort)
        Me.Controls.Add(Me.CmbBoxJobTyp)
        Me.Controls.Add(Me.LblJobTyp)
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
    Friend WithEvents GroupOperations As ToolStripMenuItem
    Friend WithEvents CntMnuStrPrt As ToolStripMenuItem
    Friend WithEvents CntMnuEndPrt As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents CntMnuSndBrkMsg As ToolStripMenuItem
    Friend WithEvents CmbBoxJobTyp As ComboBox
    Friend WithEvents LblJobTyp As Label
    Friend WithEvents TxtBoxJobNameShort As TextBox
    Friend WithEvents LblJobNameShort As Label
    Friend WithEvents CntMnuFltJobTyp As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents CntMnuHldJob As ToolStripMenuItem
    Friend WithEvents CntMnuRlsJob As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents CntMnuHldOutQ As ToolStripMenuItem
    Friend WithEvents CntMnuRlsOutQ As ToolStripMenuItem
End Class
