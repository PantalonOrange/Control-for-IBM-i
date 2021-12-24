<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActiveJobs
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.LblJobSts = New System.Windows.Forms.Label()
        Me.TxtBoxJobSts = New System.Windows.Forms.TextBox()
        Me.TxtBoxSubSys = New System.Windows.Forms.TextBox()
        Me.LblSubSys = New System.Windows.Forms.Label()
        Me.TxtBoxUsr = New System.Windows.Forms.TextBox()
        Me.LblUsr = New System.Windows.Forms.Label()
        Me.TxtBoxFunction = New System.Windows.Forms.TextBox()
        Me.LblFunction = New System.Windows.Forms.Label()
        Me.CntMnu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CntMnuMsgw = New System.Windows.Forms.ToolStripMenuItem()
        Me.CntMnuEndJob = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntMnu.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DataGridView1.Location = New System.Drawing.Point(11, 70)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(1584, 749)
        Me.DataGridView1.TabIndex = 0
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(211, 31)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 1
        Me.LblSuccess.Text = "LblSuccess"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(334, 31)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 2
        Me.LblResults.Text = "LblResults"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Success:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(283, 31)
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
        Me.BtnGet.TabIndex = 6
        Me.BtnGet.Text = "&Start"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(22, 79)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(137, 42)
        Me.LblWait.TabIndex = 7
        Me.LblWait.Text = "Label3"
        '
        'LblJobSts
        '
        Me.LblJobSts.AutoSize = True
        Me.LblJobSts.Location = New System.Drawing.Point(1269, 14)
        Me.LblJobSts.Name = "LblJobSts"
        Me.LblJobSts.Size = New System.Drawing.Size(57, 13)
        Me.LblJobSts.TabIndex = 8
        Me.LblJobSts.Text = "Job-Status"
        Me.LblJobSts.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxJobSts
        '
        Me.TxtBoxJobSts.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxJobSts.Location = New System.Drawing.Point(1332, 11)
        Me.TxtBoxJobSts.MaxLength = 4
        Me.TxtBoxJobSts.Name = "TxtBoxJobSts"
        Me.TxtBoxJobSts.Size = New System.Drawing.Size(79, 20)
        Me.TxtBoxJobSts.TabIndex = 1
        '
        'TxtBoxSubSys
        '
        Me.TxtBoxSubSys.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxSubSys.Location = New System.Drawing.Point(1332, 38)
        Me.TxtBoxSubSys.MaxLength = 10
        Me.TxtBoxSubSys.Name = "TxtBoxSubSys"
        Me.TxtBoxSubSys.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxSubSys.TabIndex = 3
        '
        'LblSubSys
        '
        Me.LblSubSys.AutoSize = True
        Me.LblSubSys.Location = New System.Drawing.Point(1268, 41)
        Me.LblSubSys.Name = "LblSubSys"
        Me.LblSubSys.Size = New System.Drawing.Size(58, 13)
        Me.LblSubSys.TabIndex = 10
        Me.LblSubSys.Text = "Subsystem"
        Me.LblSubSys.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxUsr
        '
        Me.TxtBoxUsr.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxUsr.Location = New System.Drawing.Point(1499, 11)
        Me.TxtBoxUsr.MaxLength = 10
        Me.TxtBoxUsr.Name = "TxtBoxUsr"
        Me.TxtBoxUsr.Size = New System.Drawing.Size(96, 20)
        Me.TxtBoxUsr.TabIndex = 2
        '
        'LblUsr
        '
        Me.LblUsr.AutoSize = True
        Me.LblUsr.Location = New System.Drawing.Point(1464, 14)
        Me.LblUsr.Name = "LblUsr"
        Me.LblUsr.Size = New System.Drawing.Size(29, 13)
        Me.LblUsr.TabIndex = 12
        Me.LblUsr.Text = "User"
        Me.LblUsr.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtBoxFunction
        '
        Me.TxtBoxFunction.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxFunction.Location = New System.Drawing.Point(1499, 38)
        Me.TxtBoxFunction.MaxLength = 10
        Me.TxtBoxFunction.Name = "TxtBoxFunction"
        Me.TxtBoxFunction.Size = New System.Drawing.Size(96, 20)
        Me.TxtBoxFunction.TabIndex = 4
        '
        'LblFunction
        '
        Me.LblFunction.AutoSize = True
        Me.LblFunction.Location = New System.Drawing.Point(1445, 41)
        Me.LblFunction.Name = "LblFunction"
        Me.LblFunction.Size = New System.Drawing.Size(48, 13)
        Me.LblFunction.TabIndex = 14
        Me.LblFunction.Text = "Function"
        Me.LblFunction.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CntMnu
        '
        Me.CntMnu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CntMnuMsgw, Me.CntMnuEndJob})
        Me.CntMnu.Name = "CntMnu"
        Me.CntMnu.Size = New System.Drawing.Size(153, 48)
        '
        'CntMnuMsgw
        '
        Me.CntMnuMsgw.Name = "CntMnuMsgw"
        Me.CntMnuMsgw.Size = New System.Drawing.Size(152, 22)
        Me.CntMnuMsgw.Text = "&Answer MSGW"
        '
        'CntMnuEndJob
        '
        Me.CntMnuEndJob.Name = "CntMnuEndJob"
        Me.CntMnuEndJob.Size = New System.Drawing.Size(152, 22)
        Me.CntMnuEndJob.Text = "&End job"
        '
        'ActiveJobs
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1607, 831)
        Me.Controls.Add(Me.TxtBoxFunction)
        Me.Controls.Add(Me.LblFunction)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.TxtBoxUsr)
        Me.Controls.Add(Me.LblUsr)
        Me.Controls.Add(Me.TxtBoxSubSys)
        Me.Controls.Add(Me.LblSubSys)
        Me.Controls.Add(Me.TxtBoxJobSts)
        Me.Controls.Add(Me.LblJobSts)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ActiveJobs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IBM i Active jobs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntMnu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblSuccess As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGet As Button
    Friend WithEvents LblWait As Label
    Friend WithEvents LblJobSts As Label
    Friend WithEvents TxtBoxJobSts As TextBox
    Friend WithEvents TxtBoxSubSys As TextBox
    Friend WithEvents LblSubSys As Label
    Friend WithEvents TxtBoxUsr As TextBox
    Friend WithEvents LblUsr As Label
    Friend WithEvents TxtBoxFunction As TextBox
    Friend WithEvents LblFunction As Label
    Friend WithEvents CntMnu As ContextMenuStrip
    Friend WithEvents CntMnuMsgw As ToolStripMenuItem
    Friend WithEvents CntMnuEndJob As ToolStripMenuItem
End Class
