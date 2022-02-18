<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfiles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserProfiles))
        Me.LblWait = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PrgBar = New System.Windows.Forms.ProgressBar()
        Me.BtnGet = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResults = New System.Windows.Forms.Label()
        Me.LblSuccess = New System.Windows.Forms.Label()
        Me.DtaGrdUsrPrf = New System.Windows.Forms.DataGridView()
        Me.LblUsrPrf = New System.Windows.Forms.Label()
        Me.LblUsrCls = New System.Windows.Forms.Label()
        Me.TxtBoxUsrPrf = New System.Windows.Forms.TextBox()
        Me.CmbBoxUsrCls = New System.Windows.Forms.ComboBox()
        Me.CmbBoxEnabled = New System.Windows.Forms.ComboBox()
        Me.LblEnabled = New System.Windows.Forms.Label()
        Me.CmbBoxActive = New System.Windows.Forms.ComboBox()
        Me.LblActive = New System.Windows.Forms.Label()
        Me.CntMnuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeUserprofileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ActiveJobsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LblDescription = New System.Windows.Forms.Label()
        Me.TxtBoxDescription = New System.Windows.Forms.TextBox()
        Me.CmbBoxPwdExp = New System.Windows.Forms.ComboBox()
        Me.LblPwdExp = New System.Windows.Forms.Label()
        Me.TxtBoxGrpPrf = New System.Windows.Forms.TextBox()
        Me.LblGrpPrf = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripRecordsSelected = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripMessage = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.DtaGrdUsrPrf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CntMnuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblWait
        '
        Me.LblWait.AutoSize = True
        Me.LblWait.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWait.Location = New System.Drawing.Point(17, 91)
        Me.LblWait.Name = "LblWait"
        Me.LblWait.Size = New System.Drawing.Size(183, 42)
        Me.LblWait.TabIndex = 37
        Me.LblWait.Text = "LblStatus"
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Location = New System.Drawing.Point(137, 17)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(69, 34)
        Me.BtnClose.TabIndex = 9
        Me.BtnClose.Text = "&Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PrgBar
        '
        Me.PrgBar.Location = New System.Drawing.Point(9, 52)
        Me.PrgBar.MarqueeAnimationSpeed = 70
        Me.PrgBar.Name = "PrgBar"
        Me.PrgBar.Size = New System.Drawing.Size(203, 23)
        Me.PrgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.PrgBar.TabIndex = 38
        '
        'BtnGet
        '
        Me.BtnGet.Location = New System.Drawing.Point(12, 17)
        Me.BtnGet.Name = "BtnGet"
        Me.BtnGet.Size = New System.Drawing.Size(120, 34)
        Me.BtnGet.TabIndex = 8
        Me.BtnGet.Text = "&Get"
        Me.BtnGet.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(341, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Results:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Success:"
        '
        'LblResults
        '
        Me.LblResults.AutoSize = True
        Me.LblResults.Location = New System.Drawing.Point(392, 27)
        Me.LblResults.Name = "LblResults"
        Me.LblResults.Size = New System.Drawing.Size(56, 13)
        Me.LblResults.TabIndex = 34
        Me.LblResults.Text = "LblResults"
        '
        'LblSuccess
        '
        Me.LblSuccess.AutoSize = True
        Me.LblSuccess.Location = New System.Drawing.Point(269, 27)
        Me.LblSuccess.Name = "LblSuccess"
        Me.LblSuccess.Size = New System.Drawing.Size(62, 13)
        Me.LblSuccess.TabIndex = 33
        Me.LblSuccess.Text = "LblSuccess"
        '
        'DtaGrdUsrPrf
        '
        Me.DtaGrdUsrPrf.AllowUserToAddRows = False
        Me.DtaGrdUsrPrf.AllowUserToDeleteRows = False
        Me.DtaGrdUsrPrf.AllowUserToResizeColumns = False
        Me.DtaGrdUsrPrf.AllowUserToResizeRows = False
        Me.DtaGrdUsrPrf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DtaGrdUsrPrf.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DtaGrdUsrPrf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DtaGrdUsrPrf.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DtaGrdUsrPrf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtaGrdUsrPrf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DtaGrdUsrPrf.Location = New System.Drawing.Point(6, 81)
        Me.DtaGrdUsrPrf.MultiSelect = False
        Me.DtaGrdUsrPrf.Name = "DtaGrdUsrPrf"
        Me.DtaGrdUsrPrf.ReadOnly = True
        Me.DtaGrdUsrPrf.RowHeadersWidth = 62
        Me.DtaGrdUsrPrf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DtaGrdUsrPrf.ShowEditingIcon = False
        Me.DtaGrdUsrPrf.Size = New System.Drawing.Size(1347, 526)
        Me.DtaGrdUsrPrf.TabIndex = 10
        '
        'LblUsrPrf
        '
        Me.LblUsrPrf.AutoSize = True
        Me.LblUsrPrf.Location = New System.Drawing.Point(862, 9)
        Me.LblUsrPrf.Name = "LblUsrPrf"
        Me.LblUsrPrf.Size = New System.Drawing.Size(29, 13)
        Me.LblUsrPrf.TabIndex = 39
        Me.LblUsrPrf.Text = "User"
        '
        'LblUsrCls
        '
        Me.LblUsrCls.AutoSize = True
        Me.LblUsrCls.Location = New System.Drawing.Point(838, 33)
        Me.LblUsrCls.Name = "LblUsrCls"
        Me.LblUsrCls.Size = New System.Drawing.Size(53, 13)
        Me.LblUsrCls.TabIndex = 40
        Me.LblUsrCls.Text = "Userclass"
        '
        'TxtBoxUsrPrf
        '
        Me.TxtBoxUsrPrf.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxUsrPrf.Location = New System.Drawing.Point(897, 6)
        Me.TxtBoxUsrPrf.MaxLength = 10
        Me.TxtBoxUsrPrf.Name = "TxtBoxUsrPrf"
        Me.TxtBoxUsrPrf.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxUsrPrf.TabIndex = 1
        '
        'CmbBoxUsrCls
        '
        Me.CmbBoxUsrCls.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxUsrCls.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxUsrCls.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxUsrCls.FormattingEnabled = True
        Me.CmbBoxUsrCls.Location = New System.Drawing.Point(897, 30)
        Me.CmbBoxUsrCls.MaxLength = 10
        Me.CmbBoxUsrCls.Name = "CmbBoxUsrCls"
        Me.CmbBoxUsrCls.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxUsrCls.TabIndex = 3
        '
        'CmbBoxEnabled
        '
        Me.CmbBoxEnabled.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxEnabled.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxEnabled.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxEnabled.FormattingEnabled = True
        Me.CmbBoxEnabled.Location = New System.Drawing.Point(1057, 6)
        Me.CmbBoxEnabled.MaxLength = 10
        Me.CmbBoxEnabled.Name = "CmbBoxEnabled"
        Me.CmbBoxEnabled.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxEnabled.TabIndex = 2
        '
        'LblEnabled
        '
        Me.LblEnabled.AutoSize = True
        Me.LblEnabled.Location = New System.Drawing.Point(1005, 9)
        Me.LblEnabled.Name = "LblEnabled"
        Me.LblEnabled.Size = New System.Drawing.Size(46, 13)
        Me.LblEnabled.TabIndex = 42
        Me.LblEnabled.Text = "Enabled"
        '
        'CmbBoxActive
        '
        Me.CmbBoxActive.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxActive.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxActive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxActive.FormattingEnabled = True
        Me.CmbBoxActive.Location = New System.Drawing.Point(1057, 30)
        Me.CmbBoxActive.MaxLength = 10
        Me.CmbBoxActive.Name = "CmbBoxActive"
        Me.CmbBoxActive.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxActive.TabIndex = 4
        '
        'LblActive
        '
        Me.LblActive.AutoSize = True
        Me.LblActive.Location = New System.Drawing.Point(1014, 33)
        Me.LblActive.Name = "LblActive"
        Me.LblActive.Size = New System.Drawing.Size(37, 13)
        Me.LblActive.TabIndex = 44
        Me.LblActive.Text = "Active"
        '
        'CntMnuStrip
        '
        Me.CntMnuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.CntMnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetailsToolStripMenuItem, Me.ChangeUserprofileToolStripMenuItem, Me.ToolStripSeparator1, Me.ActiveJobsToolStripMenuItem})
        Me.CntMnuStrip.Name = "CntMnuStrip"
        Me.CntMnuStrip.Size = New System.Drawing.Size(183, 100)
        '
        'DetailsToolStripMenuItem
        '
        Me.DetailsToolStripMenuItem.Image = CType(resources.GetObject("DetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DetailsToolStripMenuItem.Name = "DetailsToolStripMenuItem"
        Me.DetailsToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.DetailsToolStripMenuItem.Text = "Display details"
        '
        'ChangeUserprofileToolStripMenuItem
        '
        Me.ChangeUserprofileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSettingsToolStripMenuItem, Me.ChangePasswordToolStripMenuItem, Me.DisableUserToolStripMenuItem})
        Me.ChangeUserprofileToolStripMenuItem.Image = CType(resources.GetObject("ChangeUserprofileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeUserprofileToolStripMenuItem.Name = "ChangeUserprofileToolStripMenuItem"
        Me.ChangeUserprofileToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.ChangeUserprofileToolStripMenuItem.Text = "Change userprofile"
        '
        'ChangeSettingsToolStripMenuItem
        '
        Me.ChangeSettingsToolStripMenuItem.Image = CType(resources.GetObject("ChangeSettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeSettingsToolStripMenuItem.Name = "ChangeSettingsToolStripMenuItem"
        Me.ChangeSettingsToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ChangeSettingsToolStripMenuItem.Text = "Change Settings"
        '
        'ChangePasswordToolStripMenuItem
        '
        Me.ChangePasswordToolStripMenuItem.Image = CType(resources.GetObject("ChangePasswordToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangePasswordToolStripMenuItem.Name = "ChangePasswordToolStripMenuItem"
        Me.ChangePasswordToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.ChangePasswordToolStripMenuItem.Text = "Change password"
        '
        'DisableUserToolStripMenuItem
        '
        Me.DisableUserToolStripMenuItem.Image = CType(resources.GetObject("DisableUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DisableUserToolStripMenuItem.Name = "DisableUserToolStripMenuItem"
        Me.DisableUserToolStripMenuItem.Size = New System.Drawing.Size(188, 30)
        Me.DisableUserToolStripMenuItem.Text = "Disable user"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(179, 6)
        '
        'ActiveJobsToolStripMenuItem
        '
        Me.ActiveJobsToolStripMenuItem.Image = CType(resources.GetObject("ActiveJobsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ActiveJobsToolStripMenuItem.Name = "ActiveJobsToolStripMenuItem"
        Me.ActiveJobsToolStripMenuItem.Size = New System.Drawing.Size(182, 30)
        Me.ActiveJobsToolStripMenuItem.Text = "Display active jobs"
        '
        'LblDescription
        '
        Me.LblDescription.AutoSize = True
        Me.LblDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblDescription.Location = New System.Drawing.Point(831, 58)
        Me.LblDescription.Name = "LblDescription"
        Me.LblDescription.Size = New System.Drawing.Size(60, 13)
        Me.LblDescription.TabIndex = 45
        Me.LblDescription.Text = "Description"
        '
        'TxtBoxDescription
        '
        Me.TxtBoxDescription.Location = New System.Drawing.Point(897, 55)
        Me.TxtBoxDescription.MaxLength = 50
        Me.TxtBoxDescription.Name = "TxtBoxDescription"
        Me.TxtBoxDescription.Size = New System.Drawing.Size(456, 20)
        Me.TxtBoxDescription.TabIndex = 7
        '
        'CmbBoxPwdExp
        '
        Me.CmbBoxPwdExp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CmbBoxPwdExp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CmbBoxPwdExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbBoxPwdExp.FormattingEnabled = True
        Me.CmbBoxPwdExp.Location = New System.Drawing.Point(1258, 5)
        Me.CmbBoxPwdExp.MaxLength = 10
        Me.CmbBoxPwdExp.Name = "CmbBoxPwdExp"
        Me.CmbBoxPwdExp.Size = New System.Drawing.Size(95, 21)
        Me.CmbBoxPwdExp.TabIndex = 5
        '
        'LblPwdExp
        '
        Me.LblPwdExp.AutoSize = True
        Me.LblPwdExp.Location = New System.Drawing.Point(1162, 9)
        Me.LblPwdExp.Name = "LblPwdExp"
        Me.LblPwdExp.Size = New System.Drawing.Size(90, 13)
        Me.LblPwdExp.TabIndex = 47
        Me.LblPwdExp.Text = "Password expired"
        '
        'TxtBoxGrpPrf
        '
        Me.TxtBoxGrpPrf.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtBoxGrpPrf.Location = New System.Drawing.Point(1258, 30)
        Me.TxtBoxGrpPrf.MaxLength = 10
        Me.TxtBoxGrpPrf.Name = "TxtBoxGrpPrf"
        Me.TxtBoxGrpPrf.Size = New System.Drawing.Size(95, 20)
        Me.TxtBoxGrpPrf.TabIndex = 6
        '
        'LblGrpPrf
        '
        Me.LblGrpPrf.AutoSize = True
        Me.LblGrpPrf.Location = New System.Drawing.Point(1185, 33)
        Me.LblGrpPrf.Name = "LblGrpPrf"
        Me.LblGrpPrf.Size = New System.Drawing.Size(67, 13)
        Me.LblGrpPrf.TabIndex = 49
        Me.LblGrpPrf.Text = "Group profile"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripRecordsSelected, Me.ToolStripMessage})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 612)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1360, 22)
        Me.StatusStrip.TabIndex = 50
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripRecordsSelected
        '
        Me.ToolStripRecordsSelected.Name = "ToolStripRecordsSelected"
        Me.ToolStripRecordsSelected.Size = New System.Drawing.Size(139, 17)
        Me.ToolStripRecordsSelected.Text = "ToolStripRecordsSelected"
        '
        'ToolStripMessage
        '
        Me.ToolStripMessage.Name = "ToolStripMessage"
        Me.ToolStripMessage.Size = New System.Drawing.Size(99, 17)
        Me.ToolStripMessage.Text = "ToolStripMessage"
        '
        'UserProfiles
        '
        Me.AcceptButton = Me.BtnGet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(1360, 634)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.TxtBoxGrpPrf)
        Me.Controls.Add(Me.LblGrpPrf)
        Me.Controls.Add(Me.CmbBoxPwdExp)
        Me.Controls.Add(Me.LblPwdExp)
        Me.Controls.Add(Me.TxtBoxDescription)
        Me.Controls.Add(Me.LblDescription)
        Me.Controls.Add(Me.LblWait)
        Me.Controls.Add(Me.CmbBoxActive)
        Me.Controls.Add(Me.LblActive)
        Me.Controls.Add(Me.CmbBoxEnabled)
        Me.Controls.Add(Me.LblEnabled)
        Me.Controls.Add(Me.CmbBoxUsrCls)
        Me.Controls.Add(Me.TxtBoxUsrPrf)
        Me.Controls.Add(Me.LblUsrCls)
        Me.Controls.Add(Me.LblUsrPrf)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.PrgBar)
        Me.Controls.Add(Me.BtnGet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblResults)
        Me.Controls.Add(Me.LblSuccess)
        Me.Controls.Add(Me.DtaGrdUsrPrf)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UserProfiles"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Userprofile - Informations"
        CType(Me.DtaGrdUsrPrf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CntMnuStrip.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblWait As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PrgBar As ProgressBar
    Friend WithEvents BtnGet As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResults As Label
    Friend WithEvents LblSuccess As Label
    Friend WithEvents DtaGrdUsrPrf As DataGridView
    Friend WithEvents LblUsrPrf As Label
    Friend WithEvents LblUsrCls As Label
    Friend WithEvents TxtBoxUsrPrf As TextBox
    Friend WithEvents CmbBoxUsrCls As ComboBox
    Friend WithEvents CmbBoxEnabled As ComboBox
    Friend WithEvents LblEnabled As Label
    Friend WithEvents CmbBoxActive As ComboBox
    Friend WithEvents LblActive As Label
    Friend WithEvents CntMnuStrip As ContextMenuStrip
    Friend WithEvents DetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActiveJobsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblDescription As Label
    Friend WithEvents TxtBoxDescription As TextBox
    Friend WithEvents ChangeUserprofileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CmbBoxPwdExp As ComboBox
    Friend WithEvents LblPwdExp As Label
    Friend WithEvents TxtBoxGrpPrf As TextBox
    Friend WithEvents LblGrpPrf As Label
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripRecordsSelected As ToolStripStatusLabel
    Friend WithEvents ToolStripMessage As ToolStripStatusLabel
    Friend WithEvents DisableUserToolStripMenuItem As ToolStripMenuItem
End Class
