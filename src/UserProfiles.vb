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
        PrgBar.Minimum = 0
        PrgBar.Maximum = 100
        PrgBar.Value = 0
        PrgBar.Step = 20
        PrgBar.Style = ProgressBarStyle.Marquee
        PrgBar.MarqueeAnimationSpeed = 80
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

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If TxtBoxUsrPrf.Text = "" And CmbBoxActive.Text = "ALL" And CmbBoxEnabled.Text = "ALL" And CmbBoxUsrCls.Text = "" And TxtBoxDescription.Text = "" Then
            MessageBox.Show("Please take at least one selection", "No selection found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxUsrPrf.Select()
        Else
            RunGetProcess()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Public Sub RunGetProcess()
        'Start communication, etrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        DtaGrdUsrPrf.Enabled = False
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETJoblog(UsrPrfWebservice, TxtBoxUsrPrf.Text, CmbBoxUsrCls.Text, CmbBoxEnabled.Text, CmbBoxActive.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        DtaGrdUsrPrf.Enabled = True
    End Sub

    Private Sub StartProcessGETJoblog(ByVal pURL As String, ByVal pUsrPrf As String, ByVal pUsrCls As String,
                                      ByVal pEnabled As String, ByVal pActive As String)
        Dim GetJobLogs As New DoRestStuffGet
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
        If TxtBoxDescription.Text <> "" Then
            URL = URL.Trim() + "query=" + TxtBoxDescription.Text.ToLower().Trim()
        End If

        Try
            GetJobLogs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetJobLogs._returnJSONStream
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
                            UsrPrfInfo.PasswordExpirationInterval = Nothing
                        End Try
                        Try
                            UsrPrfInfo.DatePasswordExpires = Entry("datePasswordExpires").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.DatePasswordExpires = Nothing
                        End Try
                        Try
                            UsrPrfInfo.DaysUntilPasswordExpires = Entry("daysUntilPasswordExpires").ToString()
                        Catch ex As Exception
                            UsrPrfInfo.DaysUntilPasswordExpires = Nothing
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
        CmbBoxUsrCls.Items.AddRange(File.ReadAllLines(Application.StartupPath + "\settings\usrcls.txt"))
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

    Private Sub DtaGrdJobLog_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DtaGrdUsrPrf.CellFormatting
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
            Case 1 'user profile
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 3 'enabled
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 4 'previous signon
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 5 'sign on attempt not valid
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Case 6 'password change date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 7 'password expiration interval
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Case 8 'password expiration date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 9 'days to expiration
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Case 10 'password expired
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 11 'user class
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 12 'Last used date
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 13 'Current jobs running
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End Select
    End Sub


    Private Sub DtaGrdUsrPrf_MouseClick(sender As Object, e As MouseEventArgs) Handles DtaGrdUsrPrf.MouseClick
        'Shows the drop down menue on the datagridview via mouseclick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CntMnuStrip.Show(Me, e.Location)
        End If
    End Sub

    Private Sub DtaGrdUsrPrf_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtaGrdUsrPrf.CellContentDoubleClick
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim UsrPrfInfoDetails As New UsrPrf
            UsrPrfInfoDetails.MdiParent = Main
            UsrPrfInfoDetails.TxtBoxUsrPrf.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            UsrPrfInfoDetails.TxtBoxUsrPrf.Enabled = False
            UsrPrfInfoDetails.Show()
            UsrPrfInfoDetails.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub DetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetailsToolStripMenuItem.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim UsrPrfInfoDetails As New UsrPrf
            UsrPrfInfoDetails.MdiParent = Main
            UsrPrfInfoDetails.TxtBoxUsrPrf.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            UsrPrfInfoDetails.TxtBoxUsrPrf.Enabled = False
            UsrPrfInfoDetails.Show()
            UsrPrfInfoDetails.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub ActiveJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveJobsToolStripMenuItem.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdUsrPrf.SelectedRows
            Dim ActiveJobs As New ActiveJobs
            ActiveJobs.MdiParent = Main
            ActiveJobs.TxtBoxUsr.Text = DtaGrdUsrPrf.Rows(SelectedRow.Index).Cells(1).Value
            ActiveJobs.Show()
            ActiveJobs.BtnGet.PerformClick()
        Next
    End Sub
End Class