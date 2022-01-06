'JobLog.vb
'This form shows joblog entries from specified job name
'Copyright (C)2021 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class JobLog

    Private ResponseStream As New ResponseFromServer_T
    Private JoblogWebservice As String = Main.Host.Trim() + "/joblogs"

    Private Sub JobLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial load
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
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If TxtBoxJob.Text = "" Then
            MessageBox.Show("Missing job name", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            RunGetProcess()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Async Sub StartProcessGETJoblog(ByVal pURL As String, ByVal pJobNam As String)
        Dim GetJobLogs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pJobNam <> "" Then
            URL = URL.Trim() + "&job=" + pJobNam.Trim()
        End If
        If CmbBoxMax.Text <> "" Then
            URL = URL.Trim() + "&limit=" + CmbBoxMax.Text.Trim()
        End If

        Try
            GetJobLogs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetJobLogs._returnJSONStream
            Await Task.Run(Function() GetJobLogs._returnJSONStream())
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                    DtaGrdJobLog.Select()
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    LblSuccess.Text = "false"
                    LblResults.Text = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(LblResults.Text, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DtaGrdJobLog.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseJsonStream(ByVal pJSON As String)
        'Parse incomming json stream and fill in the data to datagridview
        Dim JobLogInfo As New JobLogInfo_T
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DtaGrdJobLog
            .Columns.Clear()
            .Columns.Add("Position", "Position")
            .Columns.Add("MessageID", "MessageID")
            .Columns.Add("Severity", "Severity")
            .Columns.Add("MessageTime", "MessageTime")
            .Columns.Add("MessageText", "MessageText")
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
                Case "jobLogInfo"
                    For Each Entry As JObject In Item.Values()
                        JobLogInfo.Position = Entry("position").ToString()
                        Try
                            JobLogInfo.MessageID = Entry("messageID").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageID = Nothing
                        End Try
                        Try
                            JobLogInfo.Severity = Entry("severity").ToString()
                        Catch ex As Exception
                            JobLogInfo.Severity = Nothing
                        End Try
                        Try
                            JobLogInfo.MessageTime = Entry("messageTimestamp").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageTime = Nothing
                        End Try
                        Try
                            JobLogInfo.MessageText = Entry("messageText").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageText = Nothing
                        End Try

                        With DtaGrdJobLog
                            .Rows.Add(JobLogInfo.Position)
                            .Rows(Index).Cells(1).Value = JobLogInfo.MessageID
                            .Rows(Index).Cells(2).Value = JobLogInfo.Severity
                            .Rows(Index).Cells(3).Value = JobLogInfo.MessageTime
                            .Rows(Index).Cells(4).Value = JobLogInfo.MessageText
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DtaGrdJobLog.Refresh()
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

    Private Sub DtaGrdJobLog_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DtaGrdJobLog.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            'Every second row
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.LightGray
        Else
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.White
        End If

        Select Case e.ColumnIndex
            Case 2 'severity
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        End Select
    End Sub

    Public Sub RunGetProcess()
        'Start communication, etrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        DtaGrdJobLog.Enabled = False
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETJoblog(JoblogWebservice, TxtBoxJob.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        DtaGrdJobLog.Enabled = True
    End Sub

End Class