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
        Me.SuspendLayout()
        '
        'LblUsrPrf
        '
        Me.LblUsrPrf.AutoSize = True
        Me.LblUsrPrf.Location = New System.Drawing.Point(12, 9)
        Me.LblUsrPrf.Name = "LblUsrPrf"
        Me.LblUsrPrf.Size = New System.Drawing.Size(60, 13)
        Me.LblUsrPrf.TabIndex = 0
        Me.LblUsrPrf.Text = "Userprofile:"
        '
        'TxtBoxUsrPrf
        '
        Me.TxtBoxUsrPrf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxUsrPrf.Location = New System.Drawing.Point(123, 6)
        Me.TxtBoxUsrPrf.MaxLength = 10
        Me.TxtBoxUsrPrf.Name = "TxtBoxUsrPrf"
        Me.TxtBoxUsrPrf.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUsrPrf.TabIndex = 1
        '
        'TxtBoxUsrTxt
        '
        Me.TxtBoxUsrTxt.Location = New System.Drawing.Point(123, 55)
        Me.TxtBoxUsrTxt.MaxLength = 128
        Me.TxtBoxUsrTxt.Name = "TxtBoxUsrTxt"
        Me.TxtBoxUsrTxt.ReadOnly = True
        Me.TxtBoxUsrTxt.Size = New System.Drawing.Size(585, 20)
        Me.TxtBoxUsrTxt.TabIndex = 2
        '
        'LblUsrTxt
        '
        Me.LblUsrTxt.AutoSize = True
        Me.LblUsrTxt.Location = New System.Drawing.Point(12, 58)
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
        Me.TxtBoxEnabled.Location = New System.Drawing.Point(123, 81)
        Me.TxtBoxEnabled.MaxLength = 10
        Me.TxtBoxEnabled.Name = "TxtBoxEnabled"
        Me.TxtBoxEnabled.ReadOnly = True
        Me.TxtBoxEnabled.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxEnabled.TabIndex = 3
        '
        'LblEnabled
        '
        Me.LblEnabled.AutoSize = True
        Me.LblEnabled.Location = New System.Drawing.Point(12, 84)
        Me.LblEnabled.Name = "LblEnabled"
        Me.LblEnabled.Size = New System.Drawing.Size(49, 13)
        Me.LblEnabled.TabIndex = 9
        Me.LblEnabled.Text = "Enabled:"
        '
        'TxtBoxPrvSignon
        '
        Me.TxtBoxPrvSignon.Location = New System.Drawing.Point(123, 107)
        Me.TxtBoxPrvSignon.MaxLength = 32
        Me.TxtBoxPrvSignon.Name = "TxtBoxPrvSignon"
        Me.TxtBoxPrvSignon.ReadOnly = True
        Me.TxtBoxPrvSignon.Size = New System.Drawing.Size(231, 20)
        Me.TxtBoxPrvSignon.TabIndex = 4
        '
        'LblPrvSignon
        '
        Me.LblPrvSignon.AutoSize = True
        Me.LblPrvSignon.Location = New System.Drawing.Point(12, 110)
        Me.LblPrvSignon.Name = "LblPrvSignon"
        Me.LblPrvSignon.Size = New System.Drawing.Size(66, 13)
        Me.LblPrvSignon.TabIndex = 11
        Me.LblPrvSignon.Text = "Last Signon:"
        '
        'TxtBoxPwdChgDate
        '
        Me.TxtBoxPwdChgDate.Location = New System.Drawing.Point(123, 133)
        Me.TxtBoxPwdChgDate.MaxLength = 32
        Me.TxtBoxPwdChgDate.Name = "TxtBoxPwdChgDate"
        Me.TxtBoxPwdChgDate.ReadOnly = True
        Me.TxtBoxPwdChgDate.Size = New System.Drawing.Size(231, 20)
        Me.TxtBoxPwdChgDate.TabIndex = 5
        '
        'LblPwdChgDate
        '
        Me.LblPwdChgDate.AutoSize = True
        Me.LblPwdChgDate.Location = New System.Drawing.Point(12, 136)
        Me.LblPwdChgDate.Name = "LblPwdChgDate"
        Me.LblPwdChgDate.Size = New System.Drawing.Size(101, 13)
        Me.LblPwdChgDate.TabIndex = 13
        Me.LblPwdChgDate.Text = "Password changed:"
        '
        'TxtBoxUsrCls
        '
        Me.TxtBoxUsrCls.Location = New System.Drawing.Point(123, 159)
        Me.TxtBoxUsrCls.MaxLength = 10
        Me.TxtBoxUsrCls.Name = "TxtBoxUsrCls"
        Me.TxtBoxUsrCls.ReadOnly = True
        Me.TxtBoxUsrCls.Size = New System.Drawing.Size(100, 20)
        Me.TxtBoxUsrCls.TabIndex = 6
        '
        'LblUsrCls
        '
        Me.LblUsrCls.AutoSize = True
        Me.LblUsrCls.Location = New System.Drawing.Point(12, 162)
        Me.LblUsrCls.Name = "LblUsrCls"
        Me.LblUsrCls.Size = New System.Drawing.Size(56, 13)
        Me.LblUsrCls.TabIndex = 15
        Me.LblUsrCls.Text = "Userclass:"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(633, 157)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnActJob
        '
        Me.BtnActJob.Location = New System.Drawing.Point(552, 157)
        Me.BtnActJob.Name = "BtnActJob"
        Me.BtnActJob.Size = New System.Drawing.Size(75, 23)
        Me.BtnActJob.TabIndex = 8
        Me.BtnActJob.Text = "&Active jobs"
        Me.BtnActJob.UseVisualStyleBackColor = True
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(471, 157)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(75, 23)
        Me.BtnGet.TabIndex = 7
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'UsrPrf
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(722, 188)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.BtnActJob)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.TxtBoxUsrCls)
        Me.Controls.Add(Me.LblUsrCls)
        Me.Controls.Add(Me.TxtBoxPwdChgDate)
        Me.Controls.Add(Me.LblPwdChgDate)
        Me.Controls.Add(Me.TxtBoxPrvSignon)
        Me.Controls.Add(Me.LblPrvSignon)
        Me.Controls.Add(Me.TxtBoxEnabled)
        Me.Controls.Add(Me.LblEnabled)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.TxtBoxUsrTxt)
        Me.Controls.Add(Me.LblUsrTxt)
        Me.Controls.Add(Me.TxtBoxUsrPrf)
        Me.Controls.Add(Me.LblUsrPrf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "UsrPrf"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "IBM i Userprofile"
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
End Class
