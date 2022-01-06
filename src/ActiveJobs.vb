'ActiveJobs.vb
'This form shows active job informations with different options to select
'Copyright (C)2021 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class ActiveJobs

    Private ResponseStream As New ResponseFromServer_T
    Private ActiveJobWebservice As String = Main.Host.Trim() + "/activejobs"

    Private Sub ActiveJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        FillCmbBoxes()
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If CmbBoxJobSts.Text = "" And TxtBoxUsr.Text = "" And CmbBoxSbs.Text = "" And TxtBoxFunction.Text = "" Then
            MessageBox.Show("Please take at least one selection", "No selection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'Start communication, etrieve json stream and fill datagridview
            BtnGet.Enabled = False
            BtnClose.Enabled = False
            DtaGrdActJob.Enabled = False
            DisplayInformation("Please wait, collecting data...")
            StartProcessGETActiveJobs(ActiveJobWebservice, TxtBoxUsr.Text, CmbBoxJobSts.Text, CmbBoxSbs.Text, TxtBoxFunction.Text)
            RemoveInformation()
            BtnGet.Enabled = True
            BtnClose.Enabled = True
            DtaGrdActJob.Enabled = True
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Async Sub StartProcessGETActiveJobs(ByVal pURL As String, ByVal pSelUsr As String, ByVal pSelJobSts As String, ByVal pSelSubSys As String, ByVal pSelFct As String)
        Dim GetActiveJobs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pSelUsr <> "" Then
            URL = URL.Trim() + "&usr=" + pSelUsr.Trim()
        End If
        If pSelJobSts <> "" Then
            URL = URL.Trim() + "&jobsts=" + pSelJobSts.Trim()
        End If
        If pSelSubSys <> "" Then
            URL = URL.Trim() + "&sbs=" + pSelSubSys.Trim()
        End If
        If pSelFct <> "" Then
            URL = URL.Trim() + "&fct=" + pSelFct.Trim()
        End If

        Try
            GetActiveJobs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetActiveJobs._returnJSONStream
            Await Task.Run(Function() GetActiveJobs._returnJSONStream())
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                    DtaGrdActJob.Select()
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    LblSuccess.Text = "false"
                    LblResults.Text = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(LblResults.Text, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DtaGrdActJob.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseJsonStream(ByVal pJSON As String)
        'Parse incomming json stream and fill in the data to datagridview
        Dim ActiveJobInfo As New ActiveJobInfo_T
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DtaGrdActJob
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
            .Columns.Add("SubSystem", "SubSystem")
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
                        With DtaGrdActJob
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
                            .Rows(Index).Cells(12).Value = ActiveJobInfo.SubSystem
                            .Rows(Index).Cells(13).Value = ActiveJobInfo.JobActiveTime
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DtaGrdActJob.Refresh()
    End Sub

    Private Async Sub EndJobImmed(ByVal pJobName As String)
        'Process end job requests
        Dim PostEndJob As New DoRestStuffPost
        Dim endJob As New EndJob_T
        Dim URL As String = ActiveJobWebservice.Trim()
        Dim Success As String
        endJob.endJobList(0).jobName = pJobName
        Dim JsonStream As String = JObject.FromObject(endJob).ToString
        PostEndJob.PostJSONData(URL, JsonStream, Main.Credentials.User, Main.Credentials.Password)
        ResponseStream = PostEndJob._returnJSONStream()
        Await Task.Run(Function() PostEndJob._returnJSONStream)

        If ResponseStream.Code = HttpStatusCode.OK Then
            Dim Ser As JObject = JObject.Parse(ResponseStream.Response)
            Dim Data As List(Of JToken) = Ser.Children().ToList()
            For Each Item As JProperty In Data
                Item.CreateReader()
                Select Case Item.Name
                    Case "endJobResults"
                        For Each Entry As JObject In Item.Values()
                            Try
                                Success = Entry("success").ToString.ToLower()
                                If Success = "false" Then
                                    MessageBox.Show(Entry("errorMessage").ToString(), "WS-Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    MessageBox.Show("job ended successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Async Sub ReplyMessage(ByVal pMessageKey As String, ByVal pReplyMessage As String)
        'Process reply messages
        Dim PostReplyMessage As New DoRestStuffPost
        Dim replyMessage As New ReplyMessage_T
        Dim URL As String = ActiveJobWebservice.Trim()
        Dim Success As String
        replyMessage.replyList(0).replyMessage = pReplyMessage
        replyMessage.replyList(0).messageKey = pMessageKey
        Dim JsonStream As String = JObject.FromObject(replyMessage).ToString
        PostReplyMessage.PostJSONData(URL, JsonStream, Main.Credentials.User, Main.Credentials.Password)
        ResponseStream = PostReplyMessage._returnJSONStream()
        Await Task.Run(Function() PostReplyMessage._returnJSONStream)

        If ResponseStream.Code = HttpStatusCode.OK Then
            Dim Ser As JObject = JObject.Parse(ResponseStream.Response)
            Dim Data As List(Of JToken) = Ser.Children().ToList()
            For Each Item As JProperty In Data
                Item.CreateReader()
                Select Case Item.Name
                    Case "replyResults"
                        For Each Entry As JObject In Item.Values()
                            Try
                                Success = Entry("success").ToString.ToLower()
                                If Success = "false" Then
                                    MessageBox.Show(Entry("errorMessage").ToString(), "WS-Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                                Else
                                    MessageBox.Show("Reply message was successfull", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

    Private Async Sub ExecuteCommandOnHost(ByVal pCommand As String)
        'Process execute command on host system
        Dim PostReplyMessage As New DoRestStuffPost
        Dim executeCommand As New ExecuteCommand_T
        Dim URL As String = ActiveJobWebservice.Trim()
        Dim Success As String
        executeCommand.executeCommandList(0).command = pCommand
        Dim JsonStream As String = JObject.FromObject(executeCommand).ToString
        PostReplyMessage.PostJSONData(URL, JsonStream, Main.Credentials.User, Main.Credentials.Password)
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

    Private Sub FillCmbBoxes()
        CmbBoxJobSts.Items.Add("MSGW")
        CmbBoxJobSts.Items.Add("LCKW")
        CmbBoxJobSts.Items.Add("DSPW")
        CmbBoxJobSts.Items.Add("TIMW")
        CmbBoxSbs.Items.Add("QINTER")
        CmbBoxSbs.Items.Add("QBATCH")
        CmbBoxSbs.Items.Add("QSPL")
        CmbBoxSbs.Items.Add("QUSRWRK")
    End Sub

    Private Sub DtaGrdActJob_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DtaGrdActJob.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            'Every second row
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.LightGray
        Else
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.White
        End If

        Select Case e.ColumnIndex
            Case 10 'temporary Storage used
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            Case 11 'ip address
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        End Select
    End Sub

    Private Sub DtaGrdActJob_MouseClick(sender As Object, e As MouseEventArgs) Handles DtaGrdActJob.MouseClick
        'Shows the drop down menue on the datagridview via mouseclick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            CntMnu.Show(Me, e.Location)
        End If
    End Sub

    Private Sub CntMnuEndJob_Click(sender As Object, e As EventArgs) Handles CntMnuEndJob.Click
        'Process end job requests
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Result = MessageBox.Show("Please confirm the endjob", "End job immed?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                DisplayInformation("Please wait, process input...")
                EndJobImmed(DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value)
                RemoveInformation()
            End If
        Next
    End Sub

    Private Sub CntMnuMsgw_Click(sender As Object, e As EventArgs) Handles CntMnuMsgw.Click
        'Process reply messages
        Dim Result As String
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Result = InputBox("Please insert your reply message", "Reply-Message")
            If Result <> "" And DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value <> "" Then
                DisplayInformation("Please wait, process input...")
                ReplyMessage(DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value, Result)
                RemoveInformation()
            ElseIf Result <> "" And DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value = "" Then
                MessageBox.Show("No message key available", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
    End Sub

    Private Sub CntMnuExcCmd_Click(sender As Object, e As EventArgs) Handles CntMnuExcCmd.Click
        'Execute given command on host system
        Dim Result As String
        Result = InputBox("Please insert your command to be executed on host-system")
        If Result <> "" Then
            DisplayInformation("Please wait, process input...")
            ExecuteCommandOnHost(Result)
            RemoveInformation()
        End If
    End Sub

    Private Sub CntMnuDspJobLog_Click(sender As Object, e As EventArgs) Handles CntMnuDspJobLog.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Dim JoblogForm As New JobLog
            JoblogForm.MdiParent = Main
            JoblogForm.Show()
            JoblogForm.TxtBoxJob.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value
            JoblogForm.TxtBoxJob.Enabled = False
            JoblogForm.CmbBoxMax.Text = "50"
            JoblogForm.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub CntMnuDspUsrPrf_Click(sender As Object, e As EventArgs) Handles CntMnuDspUsrPrf.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Dim UsrPrfForm As New UsrPrf
            UsrPrfForm.MdiParent = Main
            UsrPrfForm.Show()
            UsrPrfForm.TxtBoxUsrPrf.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(6).Value
            UsrPrfForm.TxtBoxUsrPrf.Enabled = False
            UsrPrfForm.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub CntMnuFltUsrJob_Click(sender As Object, e As EventArgs) Handles CntMnuFltUsrJob.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(6).Value
            CmbBoxSbs.Text = ""
            TxtBoxFunction.Text = ""
            Me.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub CntMnuFltFct_Click(sender As Object, e As EventArgs) Handles CntMnuFltFct.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = ""
            CmbBoxSbs.Text = ""
            TxtBoxFunction.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(9).Value
            Me.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub CntMnuFltSbs_Click(sender As Object, e As EventArgs) Handles CntMnuFltSbs.Click
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = ""
            CmbBoxSbs.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(12).Value
            TxtBoxFunction.Text = ""
            Me.BtnGet.PerformClick()
        Next
    End Sub
End Class
