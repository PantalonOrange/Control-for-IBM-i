<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.LblUsr = New System.Windows.Forms.Label()
        Me.LblPwd = New System.Windows.Forms.Label()
        Me.LblHost = New System.Windows.Forms.Label()
        Me.LblMsgwChk = New System.Windows.Forms.Label()
        Me.TxtBoxUsr = New System.Windows.Forms.TextBox()
        Me.TxtBoxPwd = New System.Windows.Forms.TextBox()
        Me.TxtBoxHost = New System.Windows.Forms.TextBox()
        Me.ChkBoxMsgw = New System.Windows.Forms.CheckBox()
        Me.BtnOK = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.GrpBoxBtn = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'LblUsr
        '
        Me.LblUsr.AutoSize = True
        Me.LblUsr.Location = New System.Drawing.Point(12, 18)
        Me.LblUsr.Name = "LblUsr"
        Me.LblUsr.Size = New System.Drawing.Size(29, 13)
        Me.LblUsr.TabIndex = 0
        Me.LblUsr.Text = "User"
        '
        'LblPwd
        '
        Me.LblPwd.AutoSize = True
        Me.LblPwd.Location = New System.Drawing.Point(12, 44)
        Me.LblPwd.Name = "LblPwd"
        Me.LblPwd.Size = New System.Drawing.Size(53, 13)
        Me.LblPwd.TabIndex = 1
        Me.LblPwd.Text = "Password"
        '
        'LblHost
        '
        Me.LblHost.AutoSize = True
        Me.LblHost.Location = New System.Drawing.Point(12, 70)
        Me.LblHost.Name = "LblHost"
        Me.LblHost.Size = New System.Drawing.Size(29, 13)
        Me.LblHost.TabIndex = 2
        Me.LblHost.Text = "Host"
        '
        'LblMsgwChk
        '
        Me.LblMsgwChk.AutoSize = True
        Me.LblMsgwChk.Location = New System.Drawing.Point(12, 94)
        Me.LblMsgwChk.Name = "LblMsgwChk"
        Me.LblMsgwChk.Size = New System.Drawing.Size(76, 13)
        Me.LblMsgwChk.TabIndex = 3
        Me.LblMsgwChk.Text = "Check MSGW"
        '
        'TxtBoxUsr
        '
        Me.TxtBoxUsr.Location = New System.Drawing.Point(118, 15)
        Me.TxtBoxUsr.MaxLength = 10
        Me.TxtBoxUsr.Name = "TxtBoxUsr"
        Me.TxtBoxUsr.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUsr.TabIndex = 1
        '
        'TxtBoxPwd
        '
        Me.TxtBoxPwd.Location = New System.Drawing.Point(118, 41)
        Me.TxtBoxPwd.MaxLength = 128
        Me.TxtBoxPwd.Name = "TxtBoxPwd"
        Me.TxtBoxPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBoxPwd.Size = New System.Drawing.Size(311, 20)
        Me.TxtBoxPwd.TabIndex = 2
        '
        'TxtBoxHost
        '
        Me.TxtBoxHost.Location = New System.Drawing.Point(118, 67)
        Me.TxtBoxHost.MaxLength = 5000
        Me.TxtBoxHost.Name = "TxtBoxHost"
        Me.TxtBoxHost.Size = New System.Drawing.Size(311, 20)
        Me.TxtBoxHost.TabIndex = 3
        '
        'ChkBoxMsgw
        '
        Me.ChkBoxMsgw.AutoSize = True
        Me.ChkBoxMsgw.Location = New System.Drawing.Point(118, 93)
        Me.ChkBoxMsgw.Name = "ChkBoxMsgw"
        Me.ChkBoxMsgw.Size = New System.Drawing.Size(219, 17)
        Me.ChkBoxMsgw.TabIndex = 4
        Me.ChkBoxMsgw.Text = "Automatic background check for MSGW"
        Me.ChkBoxMsgw.UseVisualStyleBackColor = True
        '
        'BtnOK
        '
        Me.BtnOK.Location = New System.Drawing.Point(15, 129)
        Me.BtnOK.Name = "BtnOK"
        Me.BtnOK.Size = New System.Drawing.Size(75, 23)
        Me.BtnOK.TabIndex = 5
        Me.BtnOK.Text = "OK"
        Me.BtnOK.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Location = New System.Drawing.Point(96, 129)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'GrpBoxBtn
        '
        Me.GrpBoxBtn.Location = New System.Drawing.Point(7, 118)
        Me.GrpBoxBtn.Name = "GrpBoxBtn"
        Me.GrpBoxBtn.Size = New System.Drawing.Size(174, 40)
        Me.GrpBoxBtn.TabIndex = 7
        Me.GrpBoxBtn.TabStop = False
        '
        'Settings
        '
        Me.AcceptButton = Me.BtnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(446, 168)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnOK)
        Me.Controls.Add(Me.ChkBoxMsgw)
        Me.Controls.Add(Me.TxtBoxHost)
        Me.Controls.Add(Me.TxtBoxPwd)
        Me.Controls.Add(Me.TxtBoxUsr)
        Me.Controls.Add(Me.LblMsgwChk)
        Me.Controls.Add(Me.LblHost)
        Me.Controls.Add(Me.LblPwd)
        Me.Controls.Add(Me.LblUsr)
        Me.Controls.Add(Me.GrpBoxBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Settings"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsr As Label
    Friend WithEvents LblPwd As Label
    Friend WithEvents LblHost As Label
    Friend WithEvents LblMsgwChk As Label
    Friend WithEvents TxtBoxUsr As TextBox
    Friend WithEvents TxtBoxPwd As TextBox
    Friend WithEvents TxtBoxHost As TextBox
    Friend WithEvents ChkBoxMsgw As CheckBox
    Friend WithEvents BtnOK As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents GrpBoxBtn As GroupBox
End Class
