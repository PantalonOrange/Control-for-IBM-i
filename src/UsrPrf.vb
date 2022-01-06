'UsrPrf.vb
'This form shows some information about selected userprofile
'Copyright (C)2021 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq


Public Class UsrPrf

    Private ResponseStream As New ResponseFromServer_T
    Private UsrInfoWebservice As String = Main.Host.Trim() + "/userinfos"
    Private APISuccess As String
    Private APIErrorMessage As String
    Private APIResults As String

    Private Sub UsrPrf_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblWait.Visible = False
    End Sub


    Private Async Sub StartProcessGETJoblog(ByVal pURL As String, ByVal pUsrPrf As String)
        Dim GetUsrPrf As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pUsrPrf <> "" Then
            URL = URL.Trim() + "usr=" + pUsrPrf.Trim()
        End If

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
                            TxtBoxUsrTxt.Text = ""
                        End Try
                        Try
                            TxtBoxEnabled.Text = Entry("isEnabled").ToString()
                        Catch ex As Exception
                            TxtBoxEnabled.Text = ""
                        End Try
                        Try
                            TxtBoxPrvSignon.Text = Entry("previousSignon").ToString()
                        Catch ex As Exception
                            TxtBoxPrvSignon.Text = ""
                        End Try
                        Try
                            TxtBoxPrvUsed.Text = Entry("lastUsedTimestamp").ToString()
                        Catch ex As Exception
                            TxtBoxPrvUsed.Text = ""
                        End Try
                        Try
                            TxtBoxPwdChgDate.Text = Entry("passwordChangeDate").ToString()
                        Catch ex As Exception
                            TxtBoxPwdChgDate.Text = ""
                        End Try
                        Try
                            TxtBoxUsrCls.Text = Entry("userClassName").ToString()
                        Catch ex As Exception
                            TxtBoxUsrCls.Text = ""
                        End Try

                    Next
            End Select
        Next

        If APISuccess.ToLower() = "false" Then
            DisplayInformation(APIErrorMessage)
        End If

    End Sub

    Private Sub DisplayInformation(ByVal pMessage As String)
        LblWait.Text = pMessage
        LblWait.Visible = True
    End Sub

    Private Sub RemoveInformation()
        LblWait.Visible = False
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If TxtBoxUsrPrf.Text = "" Then
            MessageBox.Show("Please insert a userprofile name", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            RunGetProcess()
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
        ActiveJobInfoForm.BtnGet.PerformClick()
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

End Class
