'UsrPrf.vb
'This form shows some information about selected userprofile
'Copyright (c)2021,2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq


Public Class UsrPrf

    Public Mode As Integer '0=View, 1=Change

    Private ResponseStream As New ResponseFromServer_T
    Private UsrInfoWebservice As String = Main.Host.Trim() + "/userinfos"
    Private APISuccess As String
    Private APIErrorMessage As String
    Private APIResults As String

    Private Sub UsrPrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWait.Visible = False
        TxtBoxUsrPrf.ReadOnly = True
        TxtBoxPrvSignon.ReadOnly = True
        TxtBoxPrvUsed.ReadOnly = True
        TxtBoxPwdChgDate.ReadOnly = True
        TxtBoxStgUsed.ReadOnly = True

        If Mode = 1 Then
            RunGetProcess()
            TxtBoxUsrTxt.ReadOnly = False
            CmbBoxEnabled.Enabled = True
            CmbBoxUsrCls.Enabled = True
            TxtBoxGrpPrf.ReadOnly = False
            CmbBoxOwner.Enabled = True
            TxtBoxCurLib.ReadOnly = False
            CmbBoxLmtCap.Enabled = True
            CmbBoxLimitDevSess.Enabled = True
            BtnGet.Text = "Post"
        Else
            TxtBoxUsrTxt.ReadOnly = True
            CmbBoxEnabled.Enabled = False
            CmbBoxUsrCls.Enabled = False
            TxtBoxGrpPrf.ReadOnly = True
            CmbBoxOwner.Enabled = False
            TxtBoxCurLib.ReadOnly = True
            CmbBoxLmtCap.Enabled = False
            CmbBoxLimitDevSess.Enabled = False
            BtnGet.Text = "Get"
        End If
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If Mode = 0 Then
            'Get data from userprofile
            If TxtBoxUsrPrf.Text = "" Then
                MessageBox.Show("Please insert a userprofile name", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                RunGetProcess()
            End If
        ElseIf Mode = 1 Then
            'Change userprofile with the new settings
            ChangeUserprofile(TxtBoxUsrPrf.Text)
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnActJob_Click(sender As Object, e As EventArgs) Handles BtnActJob.Click
        Dim ActiveJobInfoForm As New ActiveJobs
        ActiveJobInfoForm.MdiParent = Main
        ActiveJobInfoForm.TxtBoxUsr.Text = TxtBoxUsrPrf.Text
        ActiveJobInfoForm.Show()
        ActiveJobInfoForm.DtaGrdActJob.Select()
        ActiveJobInfoForm.BtnGet.PerformClick()
    End Sub

    Private Sub DisplayInformation(ByVal pMessage As String)
        LblWait.Text = pMessage
        LblWait.Visible = True
    End Sub

    Private Sub RemoveInformation()
        LblWait.Visible = False
    End Sub

    Public Sub RunGetProcess()
        'Start communication, etrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        BtnActJob.Enabled = False
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETJoblog(UsrInfoWebservice, TxtBoxUsrPrf.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        BtnActJob.Enabled = True
    End Sub

    Private Sub ChangeUserprofile(ByVal pAuthorizationName As String)
        Dim Command As String
        Dim Success As Boolean = True

        If TxtBoxUsrTxt.Text = "" Then
            TxtBoxUsrTxt.Text = "*SAME"
        End If

        If Success Then
            Command = "CHGUSRPRF USRPRF(" + pAuthorizationName.Trim() + ")"
            If CmbBoxEnabled.Text = "TRUE" Then
                Command = Command.Trim() + " STATUS(*ENABLED)"
            Else
                Command = Command.Trim() + " STATUS(*DISABLED)"
            End If
            Command = Command.Trim() + " USRCLS(" + CmbBoxUsrCls.Text.Trim() + ") LMTCPB(" + CmbBoxLmtCap.Text.Trim() +
                ") CURLIB(" + TxtBoxCurLib.Text.Trim() + ") TEXT('" + TxtBoxUsrTxt.Text.Trim() +
                "') OWNER(" + CmbBoxOwner.Text.Trim() + ") LMTDEVSSN(" + CmbBoxLimitDevSess.Text.Trim() + ")"
            ExecuteCommandOnHost(Command)
        End If
    End Sub

    Private Async Sub StartProcessGETJoblog(ByVal pURL As String, ByVal pUsrPrf As String)
        Dim GetUsrPrf As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?usr=" + pUsrPrf.Trim()

        Try
            GetUsrPrf.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetUsrPrf._returnJSONStream
            Await Task.Run(Function() GetUsrPrf._returnJSONStream())
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    APISuccess = "false"
                    APIErrorMessage = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(APIErrorMessage, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("No data found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseJsonStream(ByVal pJSON As String)
        'Parse incomming json stream and fill in the data to datagridview
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()

        For Each Item As JProperty In Data
            Item.CreateReader()
            Select Case Item.Name
                Case "success"
                    APISuccess = Item.Value
                Case "results"
                    APIResults = Item.Value
                Case "errorMessage"
                    APIErrorMessage = Item.Value
                Case "userInfo"
                    For Each Entry As JObject In Item.Values()
                        Try
                            TxtBoxUsrTxt.Text = Entry("authorizationDescription").ToString()
                        Catch ex As Exception
                            TxtBoxUsrTxt.Text = "-"
                        End Try
                        Try
                            CmbBoxEnabled.Text = Entry("isEnabled").ToString().ToUpper()
                        Catch ex As Exception
                            CmbBoxEnabled.Text = "*SAME"
                        End Try
                        Try
                            TxtBoxPrvSignon.Text = Entry("previousSignon").ToString()
                        Catch ex As Exception
                            TxtBoxPrvSignon.Text = "-"
                        End Try
                        Try
                            TxtBoxPrvUsed.Text = Entry("lastUsedTimestamp").ToString()
                        Catch ex As Exception
                            TxtBoxPrvUsed.Text = "-"
                        End Try
                        Try
                            TxtBoxPwdChgDate.Text = Entry("passwordChangeDate").ToString()
                        Catch ex As Exception
                            TxtBoxPwdChgDate.Text = "-"
                        End Try
                        Try
                            CmbBoxUsrCls.Text = Entry("userClassName").ToString().ToUpper()
                        Catch ex As Exception
                            CmbBoxUsrCls.Text = "*SAME"
                        End Try
                        Try
                            TxtBoxGrpPrf.Text = Entry("groupProfileName").ToString()
                        Catch ex As Exception
                            TxtBoxGrpPrf.Text = "-"
                        End Try
                        Try
                            CmbBoxOwner.Text = Entry("owner").ToString().ToUpper()
                        Catch ex As Exception
                            CmbBoxOwner.Text = "*SAME"
                        End Try
                        Try
                            TxtBoxCurLib.Text = Entry("currentLibraryName").ToString()
                        Catch ex As Exception
                            TxtBoxCurLib.Text = "-"
                        End Try
                        Try
                            CmbBoxLmtCap.Text = Entry("limitCapabilities").ToString().ToUpper()
                        Catch ex As Exception
                            CmbBoxLmtCap.Text = "*SAME"
                        End Try
                        Try
                            CmbBoxLimitDevSess.Text = Entry("limitDeviceSessions").ToString().ToUpper()
                        Catch ex As Exception
                            CmbBoxLimitDevSess.Text = "*SAME"
                        End Try
                        Try
                            TxtBoxStgUsed.Text = Entry("storageUsed").ToString()
                        Catch ex As Exception
                            TxtBoxStgUsed.Text = "-"
                        End Try
                        Try
                            TxtBoxJobsRun.Text = Entry("currentJobsRunning").ToString()
                        Catch ex As Exception
                            TxtBoxJobsRun.Text = "0"
                        End Try

                    Next
            End Select
        Next

        If APISuccess.ToLower() = "false" Then
            DisplayInformation(APIErrorMessage)
        End If

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
                                    Me.Close()
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
