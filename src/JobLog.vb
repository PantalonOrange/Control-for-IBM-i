'JobLog.vb
'This form shows joblog entries from specified job name
'Copyright (c)2021, 2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class JobLog

    Private ResponseStream As New ResponseFromServer_T
    Private JoblogWebservice As String = Main.Host.Trim() + "/joblogs"

    Private Sub JobLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub JobLog_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Handle key prints f5 or f12
        Select Case e.KeyCode
            Case Keys.F5
                Me.BtnGet.PerformClick()
            Case Keys.F12
                Me.BtnClose.PerformClick()
        End Select
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

    Private Sub StartProcessGETJoblog(ByVal pURL As String, ByVal pJobNam As String)
        Dim GetJobLogs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pJobNam <> "" Then
            URL = URL.Trim() + "job=" + pJobNam.Trim() + "&"
        End If
        If CmbBoxMax.Text <> "" Then
            URL = URL.Trim() + "limit=" + CmbBoxMax.Text.Trim() + "&"
        End If

        Try
            GetJobLogs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetJobLogs._returnJSONStream
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
            .Columns.Add("Pos", "Pos")
            .Columns.Add("MessageID", "Message ID")
            .Columns.Add("Sev", "Sev")
            .Columns.Add("MessageTime", "Message Time")
            .Columns.Add("MessageText", "Message Text")
            .Columns.Add("MessageTextDetail", "Message Text Detail")
            .Columns(5).Visible = False
            .Columns.Add("FromProgram", "From Program")
            .Columns.Add("FromModule", "From Module")
            .Columns.Add("FromProcedure", "From Procedure")
            .Columns.Add("ToProgram", "To Program")
            .Columns.Add("ToModule", "To Module")
            .Columns.Add("ToProcedure", "To Procedure")
            .Columns.Add("FromUser", "From User")
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
                Case "jobLogInfo"
                    For Each Entry As JObject In Item.Values()
                        JobLogInfo.Position = Entry("position").ToString()
                        Try
                            JobLogInfo.MessageID = Entry("messageID").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageID = "-"
                        End Try
                        Try
                            JobLogInfo.Severity = Entry("severity").ToString()
                        Catch ex As Exception
                            JobLogInfo.Severity = "-"
                        End Try
                        Try
                            JobLogInfo.MessageTime = Entry("messageTimestamp").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageTime = "-"
                        End Try
                        Try
                            JobLogInfo.MessageText = Entry("messageText").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageText = "-"
                        End Try
                        Try
                            JobLogInfo.MessageTextLvl2 = Entry("messageTextSecondLevel").ToString()
                        Catch ex As Exception
                            JobLogInfo.MessageTextLvl2 = "-"
                        End Try
                        Try
                            JobLogInfo.FromProgram = Entry("fromProgram").ToString()
                        Catch ex As Exception
                            JobLogInfo.FromProgram = "-"
                        End Try
                        Try
                            JobLogInfo.FromModule = Entry("fromModule").ToString()
                        Catch ex As Exception
                            JobLogInfo.FromModule = "-"
                        End Try
                        Try
                            JobLogInfo.FromProcedure = Entry("fromProcedure").ToString()
                        Catch ex As Exception
                            JobLogInfo.FromProcedure = "-"
                        End Try
                        Try
                            JobLogInfo.ToProgram = Entry("toProgram").ToString()
                        Catch ex As Exception
                            JobLogInfo.ToProgram = "-"
                        End Try
                        Try
                            JobLogInfo.ToModule = Entry("toModule").ToString()
                        Catch ex As Exception
                            JobLogInfo.ToModule = "-"
                        End Try
                        Try
                            JobLogInfo.ToProcedure = Entry("toProcedure").ToString()
                        Catch ex As Exception
                            JobLogInfo.ToProcedure = "-"
                        End Try
                        Try
                            JobLogInfo.FromUser = Entry("fromUser").ToString()
                        Catch ex As Exception
                            JobLogInfo.FromUser = "-"
                        End Try

                        DisplayInformation("Please wait, write parsed data to display...")
                        With DtaGrdJobLog
                            .Rows.Add(JobLogInfo.Position)
                            .Rows(Index).Cells(1).Value = JobLogInfo.MessageID
                            .Rows(Index).Cells(2).Value = JobLogInfo.Severity
                            .Rows(Index).Cells(3).Value = JobLogInfo.MessageTime
                            .Rows(Index).Cells(4).Value = JobLogInfo.MessageText
                            .Rows(Index).Cells(5).Value = JobLogInfo.MessageTextLvl2
                            .Rows(Index).Cells(6).Value = JobLogInfo.FromProgram
                            .Rows(Index).Cells(7).Value = JobLogInfo.FromModule
                            .Rows(Index).Cells(8).Value = JobLogInfo.FromProcedure
                            .Rows(Index).Cells(9).Value = JobLogInfo.ToProgram
                            .Rows(Index).Cells(10).Value = JobLogInfo.ToModule
                            .Rows(Index).Cells(11).Value = JobLogInfo.ToProcedure
                            .Rows(Index).Cells(12).Value = JobLogInfo.FromUser
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
            Case 0 'position
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Case 1 'message id
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 2 'severity
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 6 'from program
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 7 'from module
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 8 'from procedure
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 9 'to program
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 10 'to module
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 11 'to procedure
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 12 'from user
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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

    Private Sub DtaGrdJobLog_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DtaGrdJobLog.CellContentDoubleClick
        For Each SelectedRow As DataGridViewRow In DtaGrdJobLog.SelectedRows
            Dim JobLogInfoDetails As New JobLogDetails
            JobLogInfoDetails.MdiParent = Main
            JobLogInfoDetails.TxtBoxJob.Text = TxtBoxJob.Text
            JobLogInfoDetails.TxtBoxMsgID.Text = DtaGrdJobLog.Rows(SelectedRow.Index).Cells(1).Value
            JobLogInfoDetails.TxtBoxSev.Text = DtaGrdJobLog.Rows(SelectedRow.Index).Cells(2).Value
            JobLogInfoDetails.TxtBoxLvl1.Text = DtaGrdJobLog.Rows(SelectedRow.Index).Cells(4).Value
            JobLogInfoDetails.TxtBoxLvl2.Text = DtaGrdJobLog.Rows(SelectedRow.Index).Cells(5).Value
            JobLogInfoDetails.TxtBoxAdditions.Text =
                "From program:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(6).Value.ToString.Trim() + vbCrLf +
                "From module:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(7).Value.ToString.Trim() + vbCrLf +
                "From procedure:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(8).Value.ToString.Trim() + vbCrLf + vbCrLf +
                "To program:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(9).Value.ToString.Trim() + vbCrLf +
                "To module:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(10).Value.ToString.Trim() + vbCrLf +
                "To procedure:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(11).Value.ToString.Trim() + vbCrLf + vbCrLf +
                "From user:" + vbTab + DtaGrdJobLog.Rows(SelectedRow.Index).Cells(12).Value.ToString.Trim()
            JobLogInfoDetails.Show()
        Next
    End Sub

End Class