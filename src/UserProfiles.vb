'UserProfiles.vb
'This form shows user profiles
'Copyright (c)2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq


Public Class UserProfiles

    Private ResponseStream As New ResponseFromServer_T
    Private UsrPrfWebservice As String = Main.Host.Trim() + "/userinfos"

    Private Sub UserProfiles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial load
        Me.KeyPreview = True
        LblSuccess.Text = "-"
        LblResults.Text = "-"
        LblWait.Visible = False
        ToolStripRecordsSelected.Text = ""
        ToolStripRecordsSelected.Visible = False
        ToolStripMessage.Visible = False
        DtaGrdUsrPrf.Visible = False
        PrgBar.Visible = False
        FillCmbBoxes()
    End Sub

    Private Sub UserProfiles_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Handle key prints f5 or f12
        Select Case e.KeyCode
            Case Keys.F5
                Me.BtnGet.PerformClick()
            Case Keys.F12
                Me.BtnClose.PerformClick()
        End Select
    End Sub

    Private Sub UserProfiles_RowsSelected(sender As Object, e As EventArgs) Handles DtaGrdUsrPrf.SelectionChanged
        Dim RecordsSelected As Integer = DtaGrdUsrPrf.SelectedRows.Count
        If RecordsSelected > 0 Then
            ToolStripRecordsSelected.Visible = True
            ToolStripRecordsSelected.Text = "Selected rows: " + RecordsSelected.ToString()
        Else
            ToolStripRecordsSelected.Visible = False
        End If
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If TxtBoxUsrPrf.Text = "" And CmbBoxActive.Text = "ALL" And CmbBoxEnabled.Text = "ALL" And CmbBoxUsrCls.Text = "" And TxtBoxDescription.Text = "" And
            CmbBoxPwdExp.Text = "" And TxtBoxGrpPrf.Text = "" Then
            MessageBox.Show("Please take at least one selection", "No selection found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxUsrPrf.Select()
        Else
            RunGetProcess()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FillCmbBoxes()
        CmbBoxEnabled.Items.Add("ALL")
        CmbBoxEnabled.Items.Add("TRUE")
        CmbBoxEnabled.Items.Add("FALSE")
        If CmbBoxEnabled.Text = "" Then
            CmbBoxEnabled.Text = "ALL"
        End If
        CmbBoxActive.Items.Add("ALL")
        CmbBoxActive.Items.Add("TRUE")
        CmbBoxActive.Items.Add("FALSE")
        If CmbBoxActive.Text = "" Then
            CmbBoxActive.Text = "ALL"
        End If
        CmbBoxPwdExp.Items.Add("ALL")
        CmbBoxPwdExp.Items.Add("TRUE")
        CmbBoxPwdExp.Items.Add("FALSE")
        If CmbBoxPwdExp.Text = "" Then
            CmbBoxPwdExp.Text = "ALL"
        End If
        CmbBoxUsrCls.Items.AddRange(File.ReadAllLines(Application.StartupPath + "\settings\usrcls.txt"))
    End Sub

    Private Sub DtaGrdUsrPrf_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DtaGrdUsrPrf.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            'Every second row
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.LightGray
        Else
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.White
        End If

        Select Case e.ColumnIndex
            Case 0 'position
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 1 'user profile
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 3 'enabled
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 4 'previous signon
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 5 'sign on attempt not valid
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 6 'password change date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 7 'password expiration interval
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 8 'password expiration date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 9 'days to expiration
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 10 'password expired
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 11 'user class
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 12 'Last used date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 13 'Current jobs running
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
        End Select
    End Sub


    Private Sub DtaGrdUsrPrf_MouseClick(sender As Object, e As MouseEventArgs) Handles DtaGrdUsrPrf.MouseClick
        'Shows the drop down menue on the datagridview via mouseclick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CntMnuStrip.Show(Me, e.Location)
        End If
    End Sub

    Private Sub DtaGrdUsrPrf_MouseDoubleClick(sender As Object, e As EventArgs) Handles DtaGrdUsrPrf.DoubleClick
        'Display detailed information about selected userprofile
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim UsrPrfInfoDetails As New UsrPrf
            UsrPrfInfoDetails.MdiParent = Main
            UsrPrfInfoDetails.TxtBoxUsrPrf.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            UsrPrfInfoDetails.TxtBoxUsrPrf.ReadOnly = True
            UsrPrfInfoDetails.Mode = 0
            UsrPrfInfoDetails.Show()
            UsrPrfInfoDetails.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        'Display detailed information about selected userprofile
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim UsrPrfInfoDetails As New UsrPrf
            UsrPrfInfoDetails.MdiParent = Main
            UsrPrfInfoDetails.TxtBoxUsrPrf.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            UsrPrfInfoDetails.TxtBoxUsrPrf.ReadOnly = True
            UsrPrfInfoDetails.Mode = 0
            UsrPrfInfoDetails.Show()
            UsrPrfInfoDetails.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        'Change selected userprofile
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim UsrPrfInfoDetails As New UsrPrf
            UsrPrfInfoDetails.MdiParent = Main
            UsrPrfInfoDetails.TxtBoxUsrPrf.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            UsrPrfInfoDetails.TxtBoxUsrPrf.ReadOnly = True
            UsrPrfInfoDetails.Mode = 1
            UsrPrfInfoDetails.Show()
        Next
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem.Click
        'Change password for selected user
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            ChangeUserPassword(DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value)
        Next
    End Sub


    Private Sub DisableUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableUserToolStripMenuItem.Click
        'Disable userprofiles
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            DisableUserProfile(DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value)
        Next
    End Sub

    Private Sub ActiveJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveJobsToolStripMenuItem.Click
        'Show active jobs for selected userprofile
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim ActiveJobs As New ActiveJobs
            ActiveJobs.MdiParent = Main
            ActiveJobs.TxtBoxUsr.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            ActiveJobs.Show()
            ActiveJobs.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub ToolStripMessage_Click(sender As Object, e As EventArgs) Handles ToolStripMessage.Click
        ToolStripMessage.Text = Nothing
    End Sub

    Private Sub DisplayInformation(ByVal pMessage As String)
        PrgBar.Visible = True
        PrgBar.Refresh()
        LblWait.Text = pMessage
        LblWait.Visible = True
    End Sub

    Private Sub RemoveInformation()
        PrgBar.Visible = False
        PrgBar.Refresh()
        LblWait.Visible = False
    End Sub

    Private Sub ChangeUserPassword(ByVal pAuthorizationName As String)
        'Change userprofile password
        Dim Result As DialogResult
        Dim Command As String
        Command = InputBox("Please insert the new password for user " + pAuthorizationName.Trim(), "Change password")
        If Command <> "" Then
            Command = "CHGUSRPRF USRPRF(" + pAuthorizationName.Trim() + ") PASSWORD(" + Command.Trim() + ")"
            Result = MessageBox.Show("Mark the password as expired?", "Expire password?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Command = Command.Trim() + " PWDEXP(*YES)"
            End If
            ExecuteCommandOnHost(Command)
        End If
    End Sub


    Private Sub DisableUserProfile(ByVal pAuthorizationName As String)
        'Disable userprofile
        ExecuteCommandOnHost("CHGUSRPRF USRPRF(" + pAuthorizationName.Trim() + ") STATUS(*DISABLED)")
    End Sub

    Public Sub RunGetProcess()
        'Start communication, retrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        DtaGrdUsrPrf.Visible = True
        DtaGrdUsrPrf.Enabled = False
        ToolStripMessage.Text = Nothing
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETUsrPrf(UsrPrfWebservice, TxtBoxUsrPrf.Text, CmbBoxUsrCls.Text, CmbBoxEnabled.Text, CmbBoxActive.Text,
                              TxtBoxDescription.Text, CmbBoxPwdExp.Text, TxtBoxGrpPrf.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        DtaGrdUsrPrf.Enabled = True
    End Sub

    Private Sub StartProcessGETUsrPrf(ByVal pURL As String, ByVal pUsrPrf As String, ByVal pUsrCls As String,
                                      ByVal pEnabled As String, ByVal pActive As String, ByVal pTextDescription As String,
                                      ByVal pExpPwd As String, ByVal pGrpPrf As String)
        Dim GetUsrPrfs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pUsrPrf <> "" Then
            URL = URL.Trim() + "usr=" + pUsrPrf.Trim() + "&"
        End If
        If pUsrCls <> "" Then
            URL = URL.Trim() + "usrcls=" + pUsrCls.Trim() + "&"
        End If
        If pEnabled = "TRUE" Then
            URL = URL.Trim() + "enabled=1&"
        ElseIf pEnabled = "FALSE" Then
            URL = URL.Trim() + "enabled=0&"
        End If
        If pActive = "TRUE" Then
            URL = URL.Trim() + "active=1&"
        ElseIf pActive = "FALSE" Then
            URL = URL.Trim() + "active=0&"
        End If
        If pTextDescription <> "" Then
            URL = URL.Trim() + "query=" + pTextDescription.ToLower().Trim() + "&"
        End If
        If pExpPwd = "TRUE" Then
            URL = URL.Trim() + "exppwd=1&"
        ElseIf pExpPwd = "FALSE" Then
            URL = URL.Trim() + "exppwd=0&"
        End If
        If pGrpPrf <> "" Then
            URL = URL.Trim() + "grpprf=" + pGrpPrf.Trim()
        End If

        Try
            GetUsrPrfs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetUsrPrfs._returnJSONStream
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                    DtaGrdUsrPrf.Select()
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    LblSuccess.Text = "false"
                    LblResults.Text = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(LblResults.Text, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DtaGrdUsrPrf.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseJsonStream(ByVal pJSON As String)
        'Parse incomming json stream and fill in the data to datagridview
        Dim UsrPrfInfo As New UserProfileInfos_T
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DtaGrdUsrPrf
            .Columns.Clear()
            .Columns.Add("Pos", "Pos")
            .Columns(0).Visible = False
            .Columns.Add("UsrPrf", "Authorization name")
            .Columns.Add("Decription", "Description")
            .Columns.Add("Enabled", "Enabled")
            .Columns.Add("PrevSignon", "Previous signon")
            .Columns.Add("SignOnAttemptsNotValid", "SignOn not valid")
            .Columns.Add("PasswordChangeDate", "Password change date")
            .Columns.Add("PasswordExpirationInterval", "Password Expiration Interval")
            .Columns.Add("DatePasswordExpires", "Date Password Expires")
            .Columns.Add("DaysUntilPasswordExpires", "Days Until Password Expires")
            .Columns.Add("SetPasswordToExpire", "Set Password To Expire")
            .Columns.Add("UserClassName", "User Class Name")
            .Columns.Add("LastUsedTimestamp", "Last Used Timestamp")
            .Columns.Add("CurrentJobsRunning", "Current Jobs Running")
        End With

        DisplayInformation("Please wait, parse incoming data...")

        For Each Item As JProperty In Data
            Item.CreateReader()
            Select Case Item.Name
                Case "success"
                    LblSuccess.Text = Item.Value
                Case "results"
                    LblResults.Text = Item.Value
                Case "errorMessage"
                    LblResults.Text = Item.Value
                Case "userInfo"
                    For Each Entry As JObject In Item.Values()
                        UsrPrfInfo.Position = Entry("position").ToString()
                        Try
                            UsrPrfInfo.UserProfile = Entry("authorizationName").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.UserProfile = "-"
                        End Try
                        Try
                            UsrPrfInfo.Description = Entry("authorizationDescription").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.Description = "-"
                        End Try
                        Try
                            UsrPrfInfo.IsEnabled = (Entry("isEnabled").ToString().ToLower() = "true")
                        Catch ex As Exception
                            UsrPrfInfo.IsEnabled = Nothing
                        End Try
                        Try
                            UsrPrfInfo.PreviousSignon = Entry("previousSignon").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.PreviousSignon = Nothing
                        End Try
                        Try
                            UsrPrfInfo.SignOnAttemptsNotValid = Entry("signOnAttemptsNotValid").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.SignOnAttemptsNotValid = "-"
                        End Try
                        Try
                            UsrPrfInfo.PasswordChangeDate = Entry("passwordChangeDate").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.PasswordChangeDate = Nothing
                        End Try
                        Try
                            UsrPrfInfo.PasswordExpirationInterval = Entry("passwordExpirationInterval").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.PasswordExpirationInterval = "-"
                        End Try
                        Try
                            UsrPrfInfo.DatePasswordExpires = Entry("datePasswordExpires").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.DatePasswordExpires = Nothing
                        End Try
                        Try
                            UsrPrfInfo.DaysUntilPasswordExpires = Entry("daysUntilPasswordExpires").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.DaysUntilPasswordExpires = "-"
                        End Try
                        Try
                            UsrPrfInfo.SetPasswordToExpire = (Entry("setPasswordToExpire").ToString().ToLower() = "true")
                        Catch ex As Exception
                            UsrPrfInfo.SetPasswordToExpire = Nothing
                        End Try
                        Try
                            UsrPrfInfo.UserClassName = Entry("userClassName").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.UserClassName = Nothing
                        End Try
                        Try
                            UsrPrfInfo.LastUsedTimestamp = Entry("lastUsedTimestamp").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.LastUsedTimestamp = Nothing
                        End Try
                        Try
                            UsrPrfInfo.CurrentJobsRunning = Entry("currentJobsRunning").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.CurrentJobsRunning = "0"
                        End Try

                        DisplayInformation("Please wait, write parsed data to display...")
                        With DtaGrdUsrPrf
                            .Rows.Add(UsrPrfInfo.Position)
                            .Rows(Index).Cells(1).Value = UsrPrfInfo.UserProfile
                            .Rows(Index).Cells(2).Value = UsrPrfInfo.Description
                            .Rows(Index).Cells(3).Value = UsrPrfInfo.IsEnabled
                            .Rows(Index).Cells(4).Value = UsrPrfInfo.PreviousSignon
                            .Rows(Index).Cells(5).Value = UsrPrfInfo.SignOnAttemptsNotValid
                            .Rows(Index).Cells(6).Value = UsrPrfInfo.PasswordChangeDate
                            .Rows(Index).Cells(7).Value = UsrPrfInfo.PasswordExpirationInterval
                            .Rows(Index).Cells(8).Value = UsrPrfInfo.DatePasswordExpires
                            .Rows(Index).Cells(9).Value = UsrPrfInfo.DaysUntilPasswordExpires
                            .Rows(Index).Cells(10).Value = UsrPrfInfo.SetPasswordToExpire
                            .Rows(Index).Cells(11).Value = UsrPrfInfo.UserClassName
                            .Rows(Index).Cells(12).Value = UsrPrfInfo.LastUsedTimestamp
                            .Rows(Index).Cells(13).Value = UsrPrfInfo.CurrentJobsRunning
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DtaGrdUsrPrf.Refresh()
    End Sub

    Private Async Sub ExecuteCommandOnHost(ByVal pCommand As String)
        'Process execute command on host system
        Dim ExecuteCommandValue = Main.Host.Trim() + "/executecommands"
        Dim PostReplyMessage As New DoRestStuffPost
        Dim executeCommand As New ExecuteCommand_T
        Dim Success As String
        executeCommand.executeCommandList(0).command = pCommand
        Dim JsonStream As String = JObject.FromObject(executeCommand).ToString
        PostReplyMessage.PostJSONData(ExecuteCommandValue, JsonStream, Main.Credentials.User, Main.Credentials.Password)
        ResponseStream = PostReplyMessage._returnJSONStream()
        Await Task.Run(Function() PostReplyMessage._returnJSONStream)

        If ResponseStream.Code = HttpStatusCode.OK Then
            Dim Ser As JObject = JObject.Parse(ResponseStream.Response)
            Dim Data As List(Of JToken) = Ser.Children().ToList()
            For Each Item As JProperty In Data
                Item.CreateReader()
                Select Case Item.Name
                    Case "executeCommandResults"
                        For Each Entry As JObject In Item.Values()
                            Try
                                Success = Entry("success").ToString.ToLower()
                                If Success = "false" Then
                                    MessageBox.Show(Entry("errorMessage").ToString(), "WS-Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    MessageBox.Show("Command successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                End If
                            Catch ex As Exception
                            End Try
                        Next
                End Select
            Next

        ElseIf ResponseStream.Code <> HttpStatusCode.OK Then
            MessageBox.Show(ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim(), "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class