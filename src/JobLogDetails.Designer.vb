<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JobLogDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobLogDetails))
        Me.LblJob = New System.Windows.Forms.Label()
        Me.TxtBoxJob = New System.Windows.Forms.TextBox()
        Me.GrpBoxLvl1 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxLvl1 = New System.Windows.Forms.TextBox()
        Me.GrpBoxLvl2 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxLvl2 = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblSev = New System.Windows.Forms.Label()
        Me.TxtBoxSev = New System.Windows.Forms.TextBox()
        Me.TxtBoxMsgID = New System.Windows.Forms.TextBox()
        Me.LblMessageID = New System.Windows.Forms.Label()
        Me.GrpBoxAdditionals = New System.Windows.Forms.GroupBox()
        Me.TxtBoxAdditions = New System.Windows.Forms.TextBox()
        Me.GrpBoxLvl1.SuspendLayout()
        Me.GrpBoxLvl2.SuspendLayout()
        Me.GrpBoxAdditionals.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblJob
        '
        Me.LblJob.AutoSize = True
        Me.LblJob.Location = New System.Drawing.Point(12, 15)
        Me.LblJob.Name = "LblJob"
        Me.LblJob.Size = New System.Drawing.Size(27, 13)
        Me.LblJob.TabIndex = 0
        Me.LblJob.Text = "Job:"
        '
        'TxtBoxJob
        '
        Me.TxtBoxJob.Location = New System.Drawing.Point(45, 12)
        Me.TxtBoxJob.MaxLength = 26
        Me.TxtBoxJob.Name = "TxtBoxJob"
        Me.TxtBoxJob.ReadOnly = True
        Me.TxtBoxJob.Size = New System.Drawing.Size(201, 20)
        Me.TxtBoxJob.TabIndex = 2
        Me.TxtBoxJob.TabStop = False
        Me.TxtBoxJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GrpBoxLvl1
        '
        Me.GrpBoxLvl1.Controls.Add(Me.TxtBoxLvl1)
        Me.GrpBoxLvl1.Location = New System.Drawing.Point(12, 38)
        Me.GrpBoxLvl1.Name = "GrpBoxLvl1"
        Me.GrpBoxLvl1.Size = New System.Drawing.Size(770, 88)
        Me.GrpBoxLvl1.TabIndex = 3
        Me.GrpBoxLvl1.TabStop = False
        Me.GrpBoxLvl1.Text = "Message Level 1"
        '
        'TxtBoxLvl1
        '
        Me.TxtBoxLvl1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxLvl1.Location = New System.Drawing.Point(6, 19)
        Me.TxtBoxLvl1.MaxLength = 128
        Me.TxtBoxLvl1.Multiline = True
        Me.TxtBoxLvl1.Name = "TxtBoxLvl1"
        Me.TxtBoxLvl1.ReadOnly = True
        Me.TxtBoxLvl1.Size = New System.Drawing.Size(758, 63)
        Me.TxtBoxLvl1.TabIndex = 4
        Me.TxtBoxLvl1.TabStop = False
        '
        'GrpBoxLvl2
        '
        Me.GrpBoxLvl2.Controls.Add(Me.TxtBoxLvl2)
        Me.GrpBoxLvl2.Location = New System.Drawing.Point(12, 144)
        Me.GrpBoxLvl2.Name = "GrpBoxLvl2"
        Me.GrpBoxLvl2.Size = New System.Drawing.Size(770, 243)
        Me.GrpBoxLvl2.TabIndex = 4
        Me.GrpBoxLvl2.TabStop = False
        Me.GrpBoxLvl2.Text = "Message Level 2"
        '
        'TxtBoxLvl2
        '
        Me.TxtBoxLvl2.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxLvl2.Location = New System.Drawing.Point(6, 19)
        Me.TxtBoxLvl2.MaxLength = 32768
        Me.TxtBoxLvl2.Multiline = True
        Me.TxtBoxLvl2.Name = "TxtBoxLvl2"
        Me.TxtBoxLvl2.ReadOnly = True
        Me.TxtBoxLvl2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBoxLvl2.Size = New System.Drawing.Size(758, 218)
        Me.TxtBoxLvl2.TabIndex = 5
        Me.TxtBoxLvl2.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(707, 550)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'LblSev
        '
        Me.LblSev.AutoSize = True
        Me.LblSev.Location = New System.Drawing.Point(412, 15)
        Me.LblSev.Name = "LblSev"
        Me.LblSev.Size = New System.Drawing.Size(48, 13)
        Me.LblSev.TabIndex = 6
        Me.LblSev.Text = "Severity:"
        '
        'TxtBoxSev
        '
        Me.TxtBoxSev.Location = New System.Drawing.Point(466, 12)
        Me.TxtBoxSev.MaxLength = 3
        Me.TxtBoxSev.Name = "TxtBoxSev"
        Me.TxtBoxSev.ReadOnly = True
        Me.TxtBoxSev.Size = New System.Drawing.Size(33, 20)
        Me.TxtBoxSev.TabIndex = 4
        Me.TxtBoxSev.TabStop = False
        Me.TxtBoxSev.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBoxMsgID
        '
        Me.TxtBoxMsgID.Location = New System.Drawing.Point(322, 12)
        Me.TxtBoxMsgID.MaxLength = 7
        Me.TxtBoxMsgID.Name = "TxtBoxMsgID"
        Me.TxtBoxMsgID.ReadOnly = True
        Me.TxtBoxMsgID.Size = New System.Drawing.Size(84, 20)
        Me.TxtBoxMsgID.TabIndex = 3
        Me.TxtBoxMsgID.TabStop = False
        Me.TxtBoxMsgID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMessageID
        '
        Me.LblMessageID.AutoSize = True
        Me.LblMessageID.Location = New System.Drawing.Point(252, 15)
        Me.LblMessageID.Name = "LblMessageID"
        Me.LblMessageID.Size = New System.Drawing.Size(64, 13)
        Me.LblMessageID.TabIndex = 8
        Me.LblMessageID.Text = "MessageID:"
        '
        'GrpBoxAdditionals
        '
        Me.GrpBoxAdditionals.Controls.Add(Me.TxtBoxAdditions)
        Me.GrpBoxAdditionals.Location = New System.Drawing.Point(12, 412)
        Me.GrpBoxAdditionals.Name = "GrpBoxAdditionals"
        Me.GrpBoxAdditionals.Size = New System.Drawing.Size(770, 130)
        Me.GrpBoxAdditionals.TabIndex = 9
        Me.GrpBoxAdditionals.TabStop = False
        Me.GrpBoxAdditionals.Text = "Additional informations"
        '
        'TxtBoxAdditions
        '
        Me.TxtBoxAdditions.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxAdditions.Location = New System.Drawing.Point(6, 19)
        Me.TxtBoxAdditions.Multiline = True
        Me.TxtBoxAdditions.Name = "TxtBoxAdditions"
        Me.TxtBoxAdditions.ReadOnly = True
        Me.TxtBoxAdditions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtBoxAdditions.Size = New System.Drawing.Size(758, 105)
        Me.TxtBoxAdditions.TabIndex = 6
        Me.TxtBoxAdditions.TabStop = False
        '
        'JobLogDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(788, 580)
        Me.Controls.Add(Me.GrpBoxAdditionals)
        Me.Controls.Add(Me.TxtBoxMsgID)
        Me.Controls.Add(Me.LblMessageID)
        Me.Controls.Add(Me.TxtBoxSev)
        Me.Controls.Add(Me.LblSev)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.GrpBoxLvl2)
        Me.Controls.Add(Me.GrpBoxLvl1)
        Me.Controls.Add(Me.TxtBoxJob)
        Me.Controls.Add(Me.LblJob)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "JobLogDetails"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joblog informations - message details"
        Me.GrpBoxLvl1.ResumeLayout(False)
        Me.GrpBoxLvl1.PerformLayout()
        Me.GrpBoxLvl2.ResumeLayout(False)
        Me.GrpBoxLvl2.PerformLayout()
        Me.GrpBoxAdditionals.ResumeLayout(False)
        Me.GrpBoxAdditionals.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblJob As Label
    Friend WithEvents TxtBoxJob As TextBox
    Friend WithEvents GrpBoxLvl1 As GroupBox
    Friend WithEvents TxtBoxLvl1 As TextBox
    Friend WithEvents GrpBoxLvl2 As GroupBox
    Friend WithEvents TxtBoxLvl2 As TextBox
    Friend WithEvents BtnClose As Button
    Friend WithEvents LblSev As Label
    Friend WithEvents TxtBoxSev As TextBox
    Friend WithEvents TxtBoxMsgID As TextBox
    Friend WithEvents LblMessageID As Label
    Friend WithEvents GrpBoxAdditionals As GroupBox
    Friend WithEvents TxtBoxAdditions As TextBox
End Class
