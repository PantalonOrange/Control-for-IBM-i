<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JobLog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(JobLog))
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.LblWait = New System.Windows.Forms.Label()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.DtaGrdJobLog = New System.Windows.Forms.DataGridView()
        Me.LblJob = New System.Windows.Forms.Label()
        Me.TxtBoxJob = New System.Windows.Forms.TextBox()
        Me.LblMax = New System.Windows.Forms.Label()
        Me.CmbBoxMax = New System.Windows.Forms.ComboBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.DtaGrdJobLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(11, 51)
        Me.PrgBar.MarqueeAnimationSpeed = 70
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(203, 10)
        Me.PrgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PrgBar.TabIndex = 24
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(25, 75)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 23
        Me.LblWait.Text = "LblStatus"
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(14, 16)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(120, 34)
        Me.BtnGet.TabIndex = 3
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(343, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Results:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(214, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Success:"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(394, 26)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 19
        Me.LblResults.Text = "LblResults"
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(271, 26)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 18
        Me.LblSuccess.Text = "LblSuccess"
        '
        'DtaGrdJobLog
        '
        Me.DtaGrdJobLog.AllowUserToAddRows = False
        Me.DtaGrdJobLog.AllowUserToDeleteRows = False
        Me.DtaGrdJobLog.AllowUserToResizeColumns = False
        Me.DtaGrdJobLog.AllowUserToResizeRows = False
        Me.DtaGrdJobLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DtaGrdJobLog.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtaGrdJobLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DtaGrdJobLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtaGrdJobLog.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtaGrdJobLog.Location = New System.Drawing.Point(12, 64)
        Me.DtaGrdJobLog.MultiSelect = False
        Me.DtaGrdJobLog.Name = "DtaGrdJobLog"
        Me.DtaGrdJobLog.ReadOnly = True
        Me.DtaGrdJobLog.RowHeadersWidth = 62
        Me.DtaGrdJobLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdJobLog.ShowEditingIcon = False
        Me.DtaGrdJobLog.Size = New System.Drawing.Size(1347, 564)
        Me.DtaGrdJobLog.TabIndex = 4
        '
        'LblJob
        '
        Me.LblJob.AutoSize = True
        Me.LblJob.Location = New System.Drawing.Point(986, 26)
        Me.LblJob.Name = "LblJob"
        Me.LblJob.Size = New System.Drawing.Size(27, 13)
        Me.LblJob.TabIndex = 25
        Me.LblJob.Text = "Job:"
        '
        'TxtBoxJob
        '
        Me.TxtBoxJob.Location = New System.Drawing.Point(1019, 23)
        Me.TxtBoxJob.MaxLength = 26
        Me.TxtBoxJob.Name = "TxtBoxJob"
        Me.TxtBoxJob.Size = New System.Drawing.Size(201, 20)
        Me.TxtBoxJob.TabIndex = 1
        Me.TxtBoxJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblMax
        '
        Me.LblMax.AutoSize = True
        Me.LblMax.Location = New System.Drawing.Point(1239, 26)
        Me.LblMax.Name = "LblMax"
        Me.LblMax.Size = New System.Drawing.Size(50, 13)
        Me.LblMax.TabIndex = 27
        Me.LblMax.Text = "Records:"
        '
        'CmbBoxMax
        '
        Me.CmbBoxMax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxMax.FormattingEnabled = True
        Me.CmbBoxMax.Items.AddRange(New Object() {"10", "20", "50", "100", "200", "500", "1000"})
        Me.CmbBoxMax.Location = New System.Drawing.Point(1295, 22)
        Me.CmbBoxMax.Name = "CmbBoxMax"
        Me.CmbBoxMax.Size = New System.Drawing.Size(64, 21)
        Me.CmbBoxMax.TabIndex = 2
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(139, 16)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(69, 34)
        Me.BtnClose.TabIndex = 4
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'JobLog
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1371, 639)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.CmbBoxMax)
        Me.Controls.Add(Me.LblMax)
        Me.Controls.Add(Me.TxtBoxJob)
        Me.Controls.Add(Me.LblJob)
        Me.Controls.Add(Me.PrgBar)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.DtaGrdJobLog)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "JobLog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Joblog informations"
        CType(Me.DtaGrdJobLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PrgBar As ProgressBar
    Friend WithEvents LblWait As Label
    Friend WithEvents BtnGet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents LblSuccess As Label
    Friend WithEvents DtaGrdJobLog As DataGridView
    Friend WithEvents LblJob As Label
    Friend WithEvents TxtBoxJob As TextBox
    Friend WithEvents LblMax As Label
    Friend WithEvents CmbBoxMax As ComboBox
    Friend WithEvents BtnClose As Button
End Class
