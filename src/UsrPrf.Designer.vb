<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsrPrf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsrPrf))
        Me.LblUsrPrf = New System.Windows.Forms.Label()
        Me.TxtBoxUsrPrf = New System.Windows.Forms.TextBox()
        Me.TxtBoxUsrTxt = New System.Windows.Forms.TextBox()
        Me.LblUsrTxt = New System.Windows.Forms.Label()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.TxtBoxEnabled = New System.Windows.Forms.TextBox()
        Me.LblEnabled = New System.Windows.Forms.Label()
        Me.TxtBoxPrvSignon = New System.Windows.Forms.TextBox()
        Me.LblPrvSignon = New System.Windows.Forms.Label()
        Me.TxtBoxPwdChgDate = New System.Windows.Forms.TextBox()
        Me.LblPwdChgDate = New System.Windows.Forms.Label()
        Me.TxtBoxUsrCls = New System.Windows.Forms.TextBox()
        Me.LblUsrCls = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnActJob = New System.Windows.Forms.Button()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.TxtBoxPrvUsed = New System.Windows.Forms.TextBox()
        Me.LblPrvUsed = New System.Windows.Forms.Label()
        Me.GrpBoxUsr = New System.Windows.Forms.GroupBox()
        Me.TxtBoxJobsRun = New System.Windows.Forms.TextBox()
        Me.LblJobsRun = New System.Windows.Forms.Label()
        Me.TxtBoxStgUsed = New System.Windows.Forms.TextBox()
        Me.LblStgUsed = New System.Windows.Forms.Label()
        Me.TxtBoxLimitDevSess = New System.Windows.Forms.TextBox()
        Me.LblLimDevSess = New System.Windows.Forms.Label()
        Me.TxtBoxLmtCap = New System.Windows.Forms.TextBox()
        Me.LblLimCap = New System.Windows.Forms.Label()
        Me.TxtBoxCurLib = New System.Windows.Forms.TextBox()
        Me.LblCurLib = New System.Windows.Forms.Label()
        Me.TxtBoxOwner = New System.Windows.Forms.TextBox()
        Me.LblOwner = New System.Windows.Forms.Label()
        Me.TxtBoxGrpPrf = New System.Windows.Forms.TextBox()
        Me.LblGrpPrf = New System.Windows.Forms.Label()
        Me.GrpBoxUsr.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblUsrPrf
        '
        Me.LblUsrPrf.AutoSize = True
        Me.LblUsrPrf.Location = New System.Drawing.Point(8, 9)
        Me.LblUsrPrf.Name = "LblUsrPrf"
        Me.LblUsrPrf.Size = New System.Drawing.Size(60, 13)
        Me.LblUsrPrf.TabIndex = 0
        Me.LblUsrPrf.Text = "Userprofile:"
        '
        'TxtBoxUsrPrf
        '
        Me.TxtBoxUsrPrf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxUsrPrf.Location = New System.Drawing.Point(119, 6)
        Me.TxtBoxUsrPrf.MaxLength = 10
        Me.TxtBoxUsrPrf.Name = "TxtBoxUsrPrf"
        Me.TxtBoxUsrPrf.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUsrPrf.TabIndex = 1
        '
        'TxtBoxUsrTxt
        '
        Me.TxtBoxUsrTxt.Location = New System.Drawing.Point(115, 14)
        Me.TxtBoxUsrTxt.MaxLength = 128
        Me.TxtBoxUsrTxt.Name = "TxtBoxUsrTxt"
        Me.TxtBoxUsrTxt.ReadOnly = True
        Me.TxtBoxUsrTxt.Size = New System.Drawing.Size(585, 20)
        Me.TxtBoxUsrTxt.TabIndex = 2
        '
        'LblUsrTxt
        '
        Me.LblUsrTxt.AutoSize = True
        Me.LblUsrTxt.Location = New System.Drawing.Point(4, 17)
        Me.LblUsrTxt.Name = "LblUsrTxt"
        Me.LblUsrTxt.Size = New System.Drawing.Size(63, 13)
        Me.LblUsrTxt.TabIndex = 2
        Me.LblUsrTxt.Text = "Description:"
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(229, 6)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 8
        Me.LblWait.Text = "LblStatus"
        '
        'TxtBoxEnabled
        '
        Me.TxtBoxEnabled.Location = New System.Drawing.Point(115, 40)
        Me.TxtBoxEnabled.MaxLength = 10
        Me.TxtBoxEnabled.Name = "TxtBoxEnabled"
        Me.TxtBoxEnabled.ReadOnly = True
        Me.TxtBoxEnabled.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxEnabled.TabIndex = 3
        '
        'LblEnabled
        '
        Me.LblEnabled.AutoSize = True
        Me.LblEnabled.Location = New System.Drawing.Point(4, 43)
        Me.LblEnabled.Name = "LblEnabled"
        Me.LblEnabled.Size = New System.Drawing.Size(49, 13)
        Me.LblEnabled.TabIndex = 9
        Me.LblEnabled.Text = "Enabled:"
        '
        'TxtBoxPrvSignon
        '
        Me.TxtBoxPrvSignon.Location = New System.Drawing.Point(115, 66)
        Me.TxtBoxPrvSignon.MaxLength = 32
        Me.TxtBoxPrvSignon.Name = "TxtBoxPrvSignon"
        Me.TxtBoxPrvSignon.ReadOnly = True
        Me.TxtBoxPrvSignon.Size = New System.Drawing.Size(231, 20)
        Me.TxtBoxPrvSignon.TabIndex = 4
        '
        'LblPrvSignon
        '
        Me.LblPrvSignon.AutoSize = True
        Me.LblPrvSignon.Location = New System.Drawing.Point(4, 69)
        Me.LblPrvSignon.Name = "LblPrvSignon"
        Me.LblPrvSignon.Size = New System.Drawing.Size(66, 13)
        Me.LblPrvSignon.TabIndex = 11
        Me.LblPrvSignon.Text = "Last Signon:"
        '
        'TxtBoxPwdChgDate
        '
        Me.TxtBoxPwdChgDate.Location = New System.Drawing.Point(115, 121)
        Me.TxtBoxPwdChgDate.MaxLength = 32
        Me.TxtBoxPwdChgDate.Name = "TxtBoxPwdChgDate"
        Me.TxtBoxPwdChgDate.ReadOnly = True
        Me.TxtBoxPwdChgDate.Size = New System.Drawing.Size(231, 20)
        Me.TxtBoxPwdChgDate.TabIndex = 6
        '
        'LblPwdChgDate
        '
        Me.LblPwdChgDate.AutoSize = True
        Me.LblPwdChgDate.Location = New System.Drawing.Point(4, 124)
        Me.LblPwdChgDate.Name = "LblPwdChgDate"
        Me.LblPwdChgDate.Size = New System.Drawing.Size(101, 13)
        Me.LblPwdChgDate.TabIndex = 13
        Me.LblPwdChgDate.Text = "Password changed:"
        '
        'TxtBoxUsrCls
        '
        Me.TxtBoxUsrCls.Location = New System.Drawing.Point(115, 148)
        Me.TxtBoxUsrCls.MaxLength = 10
        Me.TxtBoxUsrCls.Name = "TxtBoxUsrCls"
        Me.TxtBoxUsrCls.ReadOnly = True
        Me.TxtBoxUsrCls.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUsrCls.TabIndex = 7
        '
        'LblUsrCls
        '
        Me.LblUsrCls.AutoSize = True
        Me.LblUsrCls.Location = New System.Drawing.Point(4, 151)
        Me.LblUsrCls.Name = "LblUsrCls"
        Me.LblUsrCls.Size = New System.Drawing.Size(56, 13)
        Me.LblUsrCls.TabIndex = 15
        Me.LblUsrCls.Text = "Userclass:"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(632, 252)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 16
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnActJob
        '
        Me.BtnActJob.Location = New System.Drawing.Point(551, 252)
        Me.BtnActJob.Name = "BtnActJob"
        Me.BtnActJob.Size = New System.Drawing.Size(75, 23)
        Me.BtnActJob.TabIndex = 17
        Me.BtnActJob.Text = "&Active jobs"
        Me.BtnActJob.UseVisualStyleBackColor = True
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(470, 252)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(75, 23)
        Me.BtnGet.TabIndex = 15
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'TxtBoxPrvUsed
        '
        Me.TxtBoxPrvUsed.Location = New System.Drawing.Point(115, 93)
        Me.TxtBoxPrvUsed.MaxLength = 32
        Me.TxtBoxPrvUsed.Name = "TxtBoxPrvUsed"
        Me.TxtBoxPrvUsed.ReadOnly = True
        Me.TxtBoxPrvUsed.Size = New System.Drawing.Size(231, 20)
        Me.TxtBoxPrvUsed.TabIndex = 5
        '
        'LblPrvUsed
        '
        Me.LblPrvUsed.AutoSize = True
        Me.LblPrvUsed.Location = New System.Drawing.Point(4, 96)
        Me.LblPrvUsed.Name = "LblPrvUsed"
        Me.LblPrvUsed.Size = New System.Drawing.Size(58, 13)
        Me.LblPrvUsed.TabIndex = 17
        Me.LblPrvUsed.Text = "Last Used:"
        '
        'GrpBoxUsr
        '
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxJobsRun)
        Me.GrpBoxUsr.Controls.Add(Me.LblJobsRun)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxStgUsed)
        Me.GrpBoxUsr.Controls.Add(Me.LblStgUsed)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxLimitDevSess)
        Me.GrpBoxUsr.Controls.Add(Me.LblLimDevSess)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxLmtCap)
        Me.GrpBoxUsr.Controls.Add(Me.LblLimCap)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxCurLib)
        Me.GrpBoxUsr.Controls.Add(Me.LblCurLib)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxOwner)
        Me.GrpBoxUsr.Controls.Add(Me.LblOwner)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxGrpPrf)
        Me.GrpBoxUsr.Controls.Add(Me.LblGrpPrf)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxPrvUsed)
        Me.GrpBoxUsr.Controls.Add(Me.LblPrvUsed)
        Me.GrpBoxUsr.Controls.Add(Me.BtnGet)
        Me.GrpBoxUsr.Controls.Add(Me.BtnActJob)
        Me.GrpBoxUsr.Controls.Add(Me.BtnClose)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxUsrCls)
        Me.GrpBoxUsr.Controls.Add(Me.LblUsrCls)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxPwdChgDate)
        Me.GrpBoxUsr.Controls.Add(Me.LblPwdChgDate)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxPrvSignon)
        Me.GrpBoxUsr.Controls.Add(Me.LblPrvSignon)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxEnabled)
        Me.GrpBoxUsr.Controls.Add(Me.LblEnabled)
        Me.GrpBoxUsr.Controls.Add(Me.TxtBoxUsrTxt)
        Me.GrpBoxUsr.Controls.Add(Me.LblUsrTxt)
        Me.GrpBoxUsr.Location = New System.Drawing.Point(4, 32)
        Me.GrpBoxUsr.Name = "GrpBoxUsr"
        Me.GrpBoxUsr.Size = New System.Drawing.Size(713, 281)
        Me.GrpBoxUsr.TabIndex = 18
        Me.GrpBoxUsr.TabStop = False
        '
        'TxtBoxJobsRun
        '
        Me.TxtBoxJobsRun.Location = New System.Drawing.Point(600, 120)
        Me.TxtBoxJobsRun.MaxLength = 10
        Me.TxtBoxJobsRun.Name = "TxtBoxJobsRun"
        Me.TxtBoxJobsRun.ReadOnly = True
        Me.TxtBoxJobsRun.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxJobsRun.TabIndex = 14
        Me.TxtBoxJobsRun.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblJobsRun
        '
        Me.LblJobsRun.AutoSize = True
        Me.LblJobsRun.Location = New System.Drawing.Point(489, 123)
        Me.LblJobsRun.Name = "LblJobsRun"
        Me.LblJobsRun.Size = New System.Drawing.Size(67, 13)
        Me.LblJobsRun.TabIndex = 31
        Me.LblJobsRun.Text = "Jobs running"
        '
        'TxtBoxStgUsed
        '
        Me.TxtBoxStgUsed.Location = New System.Drawing.Point(600, 92)
        Me.TxtBoxStgUsed.MaxLength = 10
        Me.TxtBoxStgUsed.Name = "TxtBoxStgUsed"
        Me.TxtBoxStgUsed.ReadOnly = True
        Me.TxtBoxStgUsed.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxStgUsed.TabIndex = 13
        Me.TxtBoxStgUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LblStgUsed
        '
        Me.LblStgUsed.AutoSize = True
        Me.LblStgUsed.Location = New System.Drawing.Point(489, 95)
        Me.LblStgUsed.Name = "LblStgUsed"
        Me.LblStgUsed.Size = New System.Drawing.Size(70, 13)
        Me.LblStgUsed.TabIndex = 29
        Me.LblStgUsed.Text = "Storage used"
        '
        'TxtBoxLimitDevSess
        '
        Me.TxtBoxLimitDevSess.Location = New System.Drawing.Point(600, 66)
        Me.TxtBoxLimitDevSess.MaxLength = 10
        Me.TxtBoxLimitDevSess.Name = "TxtBoxLimitDevSess"
        Me.TxtBoxLimitDevSess.ReadOnly = True
        Me.TxtBoxLimitDevSess.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxLimitDevSess.TabIndex = 12
        '
        'LblLimDevSess
        '
        Me.LblLimDevSess.AutoSize = True
        Me.LblLimDevSess.Location = New System.Drawing.Point(489, 68)
        Me.LblLimDevSess.Name = "LblLimDevSess"
        Me.LblLimDevSess.Size = New System.Drawing.Size(106, 13)
        Me.LblLimDevSess.TabIndex = 27
        Me.LblLimDevSess.Text = "Limit device sessions"
        '
        'TxtBoxLmtCap
        '
        Me.TxtBoxLmtCap.Location = New System.Drawing.Point(115, 252)
        Me.TxtBoxLmtCap.MaxLength = 10
        Me.TxtBoxLmtCap.Name = "TxtBoxLmtCap"
        Me.TxtBoxLmtCap.ReadOnly = True
        Me.TxtBoxLmtCap.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxLmtCap.TabIndex = 11
        '
        'LblLimCap
        '
        Me.LblLimCap.AutoSize = True
        Me.LblLimCap.Location = New System.Drawing.Point(4, 255)
        Me.LblLimCap.Name = "LblLimCap"
        Me.LblLimCap.Size = New System.Drawing.Size(83, 13)
        Me.LblLimCap.TabIndex = 25
        Me.LblLimCap.Text = "Limit capabilities"
        '
        'TxtBoxCurLib
        '
        Me.TxtBoxCurLib.Location = New System.Drawing.Point(115, 226)
        Me.TxtBoxCurLib.MaxLength = 10
        Me.TxtBoxCurLib.Name = "TxtBoxCurLib"
        Me.TxtBoxCurLib.ReadOnly = True
        Me.TxtBoxCurLib.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxCurLib.TabIndex = 10
        '
        'LblCurLib
        '
        Me.LblCurLib.AutoSize = True
        Me.LblCurLib.Location = New System.Drawing.Point(4, 229)
        Me.LblCurLib.Name = "LblCurLib"
        Me.LblCurLib.Size = New System.Drawing.Size(71, 13)
        Me.LblCurLib.TabIndex = 23
        Me.LblCurLib.Text = "Current library"
        '
        'TxtBoxOwner
        '
        Me.TxtBoxOwner.Location = New System.Drawing.Point(115, 200)
        Me.TxtBoxOwner.MaxLength = 10
        Me.TxtBoxOwner.Name = "TxtBoxOwner"
        Me.TxtBoxOwner.ReadOnly = True
        Me.TxtBoxOwner.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxOwner.TabIndex = 9
        '
        'LblOwner
        '
        Me.LblOwner.AutoSize = True
        Me.LblOwner.Location = New System.Drawing.Point(4, 203)
        Me.LblOwner.Name = "LblOwner"
        Me.LblOwner.Size = New System.Drawing.Size(38, 13)
        Me.LblOwner.TabIndex = 21
        Me.LblOwner.Text = "Owner"
        '
        'TxtBoxGrpPrf
        '
        Me.TxtBoxGrpPrf.Location = New System.Drawing.Point(115, 174)
        Me.TxtBoxGrpPrf.MaxLength = 10
        Me.TxtBoxGrpPrf.Name = "TxtBoxGrpPrf"
        Me.TxtBoxGrpPrf.ReadOnly = True
        Me.TxtBoxGrpPrf.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxGrpPrf.TabIndex = 8
        '
        'LblGrpPrf
        '
        Me.LblGrpPrf.AutoSize = True
        Me.LblGrpPrf.Location = New System.Drawing.Point(4, 177)
        Me.LblGrpPrf.Name = "LblGrpPrf"
        Me.LblGrpPrf.Size = New System.Drawing.Size(96, 13)
        Me.LblGrpPrf.TabIndex = 19
        Me.LblGrpPrf.Text = "Group profile name"
        '
        'UsrPrf
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(720, 315)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.TxtBoxUsrPrf)
        Me.Controls.Add(Me.LblUsrPrf)
        Me.Controls.Add(Me.GrpBoxUsr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UsrPrf"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Userprofile detail informations"
        Me.GrpBoxUsr.ResumeLayout(False)
        Me.GrpBoxUsr.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsrPrf As Label
    Friend WithEvents TxtBoxUsrPrf As TextBox
    Friend WithEvents TxtBoxUsrTxt As TextBox
    Friend WithEvents LblUsrTxt As Label
    Friend WithEvents LblWait As Label
    Friend WithEvents TxtBoxEnabled As TextBox
    Friend WithEvents LblEnabled As Label
    Friend WithEvents TxtBoxPrvSignon As TextBox
    Friend WithEvents LblPrvSignon As Label
    Friend WithEvents TxtBoxPwdChgDate As TextBox
    Friend WithEvents LblPwdChgDate As Label
    Friend WithEvents TxtBoxUsrCls As TextBox
    Friend WithEvents LblUsrCls As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnActJob As Button
    Friend WithEvents BtnGet As Button
    Friend WithEvents TxtBoxPrvUsed As TextBox
    Friend WithEvents LblPrvUsed As Label
    Friend WithEvents GrpBoxUsr As GroupBox
    Friend WithEvents TxtBoxStgUsed As TextBox
    Friend WithEvents LblStgUsed As Label
    Friend WithEvents TxtBoxLimitDevSess As TextBox
    Friend WithEvents LblLimDevSess As Label
    Friend WithEvents TxtBoxLmtCap As TextBox
    Friend WithEvents LblLimCap As Label
    Friend WithEvents TxtBoxCurLib As TextBox
    Friend WithEvents LblCurLib As Label
    Friend WithEvents TxtBoxOwner As TextBox
    Friend WithEvents LblOwner As Label
    Friend WithEvents TxtBoxGrpPrf As TextBox
    Friend WithEvents LblGrpPrf As Label
    Friend WithEvents TxtBoxJobsRun As TextBox
    Friend WithEvents LblJobsRun As Label
End Class
