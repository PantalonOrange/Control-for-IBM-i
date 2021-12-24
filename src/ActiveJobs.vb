Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class ActiveJobs

    Public Host As String
    Public Credentials As New Credentials_T
    Private ActiveJobInfo As New ActiveJobInfo_T
    Private ResponseStream As New ResponseFromServer_T

    Private GetActiveJobs As New DoRestStuffGet

    Private Sub ActiveJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblSuccess.Text = "-"
        LblResults.Text = "-"
        LblJobSts.Text = "Job-Status:"
        LblSubSys.Text = "Subsystem:"
        LblUsr.Text = "User:"
        LblFunction.Text = "Function:"
        LblWait.Text = "Please wait, load data..."
        LblWait.Visible = False
    End Sub

    Private Sub ActiveJobs_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        Login.Close()
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        StartProcessGETActiveJobs()
    End Sub

    Private Sub StartProcessGETActiveJobs()
        BtnGet.Enabled = False
        DataGridView1.Enabled = False
        LblWait.Visible = True
        Dim URL As String = Host.Trim() + "?"
        If TxtBoxUsr.Text <> "" Then
            URL = URL.Trim() + "&usr=" + TxtBoxUsr.Text.Trim()
        End If
        If TxtBoxJobSts.Text <> "" Then
            URL = URL.Trim() + "&jobsts=" + TxtBoxJobSts.Text.Trim()
        End If
        If TxtBoxSubSys.Text <> "" Then
            URL = URL.Trim() + "&sbs=" + TxtBoxSubSys.Text.Trim()
        End If
        If TxtBoxFunction.Text <> "" Then
            URL = URL.Trim() + "&fct=" + TxtBoxFunction.Text.Trim()
        End If

        Try
            GetActiveJobs.GetJSONData(URL, Credentials.User, Credentials.Password)
            ResponseStream = GetActiveJobs._returnJSONStream
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                    DataGridView1.Select()
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    LblSuccess.Text = "false"
                    LblResults.Text = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(LblResults.Text, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DataGridView1.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        BtnGet.Enabled = True
        DataGridView1.Enabled = True
        LblWait.Visible = False
    End Sub

    Private Sub ParseJsonStream(ByVal JSON As String)
        Dim Ser As JObject = JObject.Parse(JSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DataGridView1
            .Columns.Clear()
            .Columns.Add("Position", "Position")
            .Columns.Add("JobName", "JobName")
            .Columns.Add("JobType", "JobType")
            .Columns.Add("JobStatus", "JobStatus")
            .Columns.Add("JobMessage", "JobMessage")
            .Columns.Add("MessageKey", "MessageKey")
            .Columns.Add("AuthorizationName", "AuthorizationName")
            .Columns.Add("AuthorizationDescription", "AuthorizationDescription")
            .Columns.Add("FunctionType", "FunctionType")
            .Columns.Add("Function", "Function")
            .Columns.Add("Storage", "Storage")
            .Columns.Add("ClientIPAddress", "ClientIPAddress")
            .Columns.Add("JobActivityTime", "JobActivityTime")
        End With

        For Each Item As JProperty In Data
            Item.CreateReader()
            Select Case Item.Name
                Case "success"
                    LblSuccess.Text = Item.Value
                Case "results"
                    LblResults.Text = Item.Value
                Case "errorMessage"
                    LblResults.Text = Item.Value
                Case "activeJobInfo"
                    For Each Entry As JObject In Item.Values()
                        ActiveJobInfo.OrdinalPosition = Entry("ordinalPosition").ToString()
                        ActiveJobInfo.SubSystem = Entry("subSystem").ToString()
                        ActiveJobInfo.JobName = Entry("jobName").ToString()
                        ActiveJobInfo.JobType = Entry("jobType").ToString()
                        ActiveJobInfo.JobStatus = Entry("jobStatus").ToString
                        Try
                            ActiveJobInfo.JobMessage = Entry("jobMessage").ToString()
                        Catch x As Exception
                            ActiveJobInfo.JobMessage = Nothing
                        End Try
                        Try
                            ActiveJobInfo.MessageKey = Entry("messageKey").ToString
                        Catch x As Exception
                            ActiveJobInfo.MessageKey = Nothing
                        End Try
                        ActiveJobInfo.AuthorizationName = Entry("authorizationName").ToString()
                        ActiveJobInfo.AuthorizationDescription = Entry("authorizationDescription").ToString()
                        Try
                            ActiveJobInfo.FunctionType = Entry("functionType").ToString()
                            ActiveJobInfo.FunctionName = Entry("function").ToString()
                        Catch x As Exception
                            ActiveJobInfo.FunctionType = Nothing
                            ActiveJobInfo.FunctionName = Nothing
                        End Try
                        Try
                            ActiveJobInfo.StorageUsed = Convert.ToInt32(Entry("temporaryStorage").ToString())
                        Catch x As Exception
                            ActiveJobInfo.StorageUsed = Nothing
                        End Try
                        Try
                            ActiveJobInfo.ClientIPAddress = Entry("clientIPAddress").ToString
                        Catch x As Exception
                            ActiveJobInfo.ClientIPAddress = Nothing
                        End Try
                        ActiveJobInfo.JobActiveTime = Entry("jobActiveTime").ToString
                        With DataGridView1
                            .Rows.Add(ActiveJobInfo.OrdinalPosition)
                            .Rows(Index).Cells(1).Value = ActiveJobInfo.JobName
                            .Rows(Index).Cells(2).Value = ActiveJobInfo.JobType
                            .Rows(Index).Cells(3).Value = ActiveJobInfo.JobStatus
                            .Rows(Index).Cells(4).Value = ActiveJobInfo.JobMessage
                            .Rows(Index).Cells(5).Value = ActiveJobInfo.MessageKey
                            .Rows(Index).Cells(6).Value = ActiveJobInfo.AuthorizationName
                            .Rows(Index).Cells(7).Value = ActiveJobInfo.AuthorizationDescription
                            .Rows(Index).Cells(8).Value = ActiveJobInfo.FunctionType
                            .Rows(Index).Cells(9).Value = ActiveJobInfo.FunctionName
                            .Rows(Index).Cells(10).Value = ActiveJobInfo.StorageUsed
                            .Rows(Index).Cells(11).Value = ActiveJobInfo.ClientIPAddress
                            .Rows(Index).Cells(12).Value = ActiveJobInfo.JobActiveTime
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DataGridView1.Refresh()
    End Sub

End Class

Public Class ActiveJobInfo_T
    Public OrdinalPosition As String
    Public SubSystem As String
    Public JobName As String
    Public JobType As String
    Public JobStatus As String
    Public JobMessage As String
    Public MessageKey As String
    Public AuthorizationName As String
    Public AuthorizationDescription As String
    Public FunctionType As String
    Public FunctionName As String
    Public StorageUsed As Integer
    Public ClientIPAddress As String
    Public JobActiveTime As String
End Class
