'ActiveJobs.vb
'This form shows active job informations with different options to select
'Copyright (C)2021,2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class ActiveJobs

    Private ResponseStream As New ResponseFromServer_T
    Private ActiveJobWebservice As String = Main.Host.Trim() + "/activejobs"

    Private Sub ActiveJobs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial load
        Me.KeyPreview = True
        LblSuccess.Text = "-"
        LblResults.Text = "-"
        LblWait.Visible = False
        ToolStripRecordsSelected.Text = ""
        ToolStripRecordsSelected.Visible = False
        ToolStripMessage.Visible = False
        PrgBar.Visible = False
        FillCmbBoxes()
    End Sub

    Private Sub ActiveJobs_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Handle key prints f5 or f12
        Select Case e.KeyCode
            Case Keys.F5
                Me.BtnGet.PerformClick()
            Case Keys.F12
                Me.BtnClose.PerformClick()
        End Select

    End Sub

    Private Sub ActiveJobs_RowsSelected(sender As Object, e As EventArgs) Handles DtaGrdActJob.SelectionChanged
        Dim RecordsSelected As Integer = DtaGrdActJob.SelectedRows.Count
        If RecordsSelected > 0 Then
            ToolStripRecordsSelected.Visible = True
            ToolStripRecordsSelected.Text = "Selected rows: " + RecordsSelected.ToString()
        Else
            ToolStripRecordsSelected.Visible = False
        End If
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If CmbBoxJobSts.Text = "" And TxtBoxUsr.Text = "" And CmbBoxSbs.Text = "" And TxtBoxFunction.Text = "" And
            TxtBoxJobNameShort.Text = "" And CmbBoxJobTyp.Text = "" And TxtBoxIPAdr.Text = "" Then
            MessageBox.Show("Please take at least one selection", "No selection found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            CmbBoxSbs.Select()
        Else
            BtnGet.Enabled = False
            BtnClose.Enabled = False
            DtaGrdActJob.Enabled = False
            'Start communication, retrieve json stream and fill datagridview
            ActiveJobWebservice = Main.Host.Trim() + "/activejobs"
            DisplayInformation("Please wait, collecting data...")
            StartProcessGETActiveJobs(ActiveJobWebservice, CmbBoxJobTyp.Text, TxtBoxJobNameShort.Text, TxtBoxUsr.Text, CmbBoxJobSts.Text,
                                      CmbBoxSbs.Text, TxtBoxFunction.Text, TxtBoxIPAdr.Text)
            RemoveInformation()
            BtnGet.Enabled = True
            BtnClose.Enabled = True
            DtaGrdActJob.Enabled = True
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
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

        'Change colors on base of the job-status
        If DtaGrdActJob.Rows(e.RowIndex).Cells(3).Value = "MSGW" Then
            e.CellStyle.ForeColor = Color.DarkRed
        ElseIf DtaGrdActJob.Rows(e.RowIndex).Cells(3).Value = "LCKW" Then
            e.CellStyle.ForeColor = Color.MediumVioletRed
        ElseIf DtaGrdActJob.Rows(e.RowIndex).Cells(3).Value = "DSC" Then
            e.CellStyle.ForeColor = Color.BlueViolet
        ElseIf DtaGrdActJob.Rows(e.RowIndex).Cells(3).Value = "RUN" Then
            e.CellStyle.ForeColor = Color.DarkGreen
        End If

        'Change cell formats
        Select Case e.ColumnIndex
            Case 0 'Position
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 2 'job type
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 3 'job status
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 6 'authorization name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 8 'function type
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 9 'function
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 10 'temporary Storage used
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 11 'ip address
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 12 'subsystem
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
            Result = MessageBox.Show("Please confirm the endjob-request for: " + vbCrLf +
                                     DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim(), "End job immed?",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                DisplayInformation("Please wait, process endjob on host...")
                EndJobImmed(DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value)
                RemoveInformation()
            End If
        Next
    End Sub

    Private Sub CntMnuMsgw_Click(sender As Object, e As EventArgs) Handles CntMnuMsgw.Click
        'Process reply messages
        Dim Result As String
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Result = InputBox("Please insert your reply for job " +
                              DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim() +
                              "." + vbCrLf + "Message: " +
                              DtaGrdActJob.Rows(SelectedRow.Index).Cells(4).Value.ToString().Trim(), "Send reply to messagewait")
            If Result <> "" And DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value <> "-" Then
                DisplayInformation("Please wait, process reply-request...")
                ReplyMessage(DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value, Result, DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value)
                RemoveInformation()
            ElseIf Result <> "" And DtaGrdActJob.Rows(SelectedRow.Index).Cells(5).Value = "-" Then
                MessageBox.Show("No message key available. Cancel reply request", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Next
    End Sub

    Private Sub CntMnuExcCmd_Click(sender As Object, e As EventArgs) Handles CntMnuExcCmd.Click
        'Execute given command on host system
        Dim Result As String
        Result = InputBox("Please insert your command to be executed on host-system", "Execute command")
        If Result <> "" Then
            DisplayInformation("Please wait, try to process command-request on host...")
            ExecuteCommandOnHost(Result)
            RemoveInformation()
        End If
    End Sub

    Private Sub CntMnuDspJobLog_Click(sender As Object, e As EventArgs) Handles CntMnuDspJobLog.Click, DtaGrdActJob.MouseDoubleClick
        'Display joblog for selected job
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Dim JoblogForm As New JobLog
            JoblogForm.MdiParent = Main
            JoblogForm.Show()
            JoblogForm.TxtBoxJob.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value
            JoblogForm.TxtBoxJob.ReadOnly = True
            JoblogForm.CmbBoxMax.Text = "50"
            JoblogForm.BtnGet.PerformClick()
        Next
    End Sub

    Private Sub CntMnuDspUsrPrf_Click(sender As Object, e As EventArgs) Handles CntMnuDspUsrPrf.Click
        'Display userinformations for selected user
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            Dim UsrPrfForm As New UsrPrf
            UsrPrfForm.MdiParent = Main
            UsrPrfForm.Show()
            UsrPrfForm.TxtBoxUsrPrf.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(6).Value
            UsrPrfForm.TxtBoxUsrPrf.ReadOnly = True
            UsrPrfForm.Mode = 0
            UsrPrfForm.BtnGet.PerformClick()
            Exit For
        Next
    End Sub

    Private Sub CntMnuFltUsrJob_Click(sender As Object, e As EventArgs) Handles CntMnuFltUsrJob.Click
        'Set filter to selected user
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(6).Value
            CmbBoxSbs.Text = ""
            TxtBoxFunction.Text = ""
            CmbBoxJobTyp.Text = ""
            TxtBoxJobNameShort.Text = ""
            TxtBoxIPAdr.Text = ""
            ToolStripMessage.Visible = True
            ToolStripMessage.Text = "Set filter to selected 'user': " + TxtBoxUsr.Text.Trim()
            Me.BtnGet.PerformClick()
            Exit For
        Next
    End Sub

    Private Sub CntMnuFltFct_Click(sender As Object, e As EventArgs) Handles CntMnuFltFct.Click
        'Set filter to selected function
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = ""
            CmbBoxSbs.Text = ""
            TxtBoxFunction.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(9).Value
            CmbBoxJobTyp.Text = ""
            TxtBoxJobNameShort.Text = ""
            TxtBoxIPAdr.Text = ""
            ToolStripMessage.Visible = True
            ToolStripMessage.Text = "Set filter to selected 'function': " + TxtBoxFunction.Text.Trim()
            Me.BtnGet.PerformClick()
            Exit For
        Next
    End Sub

    Private Sub CntMnuFltSbs_Click(sender As Object, e As EventArgs) Handles CntMnuFltSbs.Click
        'Set filter to selected subsystem
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = ""
            CmbBoxSbs.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(12).Value
            TxtBoxFunction.Text = ""
            CmbBoxJobTyp.Text = ""
            TxtBoxJobNameShort.Text = ""
            TxtBoxIPAdr.Text = ""
            ToolStripMessage.Visible = True
            ToolStripMessage.Text = "Set filter to selected 'subsystem': " + CmbBoxSbs.Text.Trim()
            Me.BtnGet.PerformClick()
            Exit For
        Next
    End Sub

    Private Sub CntMnuFltJobTyp_Click(sender As Object, e As EventArgs) Handles CntMnuFltJobTyp.Click
        'Set filter to selected job type
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            CmbBoxJobSts.Text = ""
            TxtBoxUsr.Text = ""
            CmbBoxSbs.Text = ""
            TxtBoxFunction.Text = ""
            CmbBoxJobTyp.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(2).Value
            TxtBoxJobNameShort.Text = ""
            TxtBoxIPAdr.Text = ""
            ToolStripMessage.Visible = True
            ToolStripMessage.Text = "Set filter to selected 'job type': " + CmbBoxJobTyp.Text.Trim()
            Me.BtnGet.PerformClick()
            Exit For
        Next
    End Sub

    Private Sub CntMnuFltIPAdr_Click(sender As Object, e As EventArgs) Handles CntMnuFltIPAdr.Click
        'Set filter to selected entry ip-address
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            If DtaGrdActJob.Rows(SelectedRow.Index).Cells(11).Value = "-" Then
                MessageBox.Show("No ip address selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                CmbBoxJobSts.Text = ""
                TxtBoxUsr.Text = ""
                CmbBoxSbs.Text = ""
                TxtBoxFunction.Text = ""
                CmbBoxJobTyp.Text = ""
                TxtBoxJobNameShort.Text = ""
                TxtBoxIPAdr.Text = DtaGrdActJob.Rows(SelectedRow.Index).Cells(11).Value
                ToolStripMessage.Visible = True
                ToolStripMessage.Text = "Set filter to selected 'client-ip-address': " + TxtBoxIPAdr.Text.Trim()
                Me.BtnGet.PerformClick()
            End If
            Exit For
        Next
    End Sub

    Private Sub CntMnuStrPrt_Click(sender As Object, e As EventArgs) Handles CntMnuStrPrt.Click
        'Start printer
        Dim Result As String = InputBox("Please insert the printer to start", "Start printer")
        If Result <> "" Then
            Result = "STRPRTWTR DEV(" + Result.ToUpper().Trim() + ")"
            DisplayInformation("Please wait, process input...")
            ExecuteCommandOnHost(Result)
            RemoveInformation()
        End If
    End Sub

    Private Sub CntMnuEndPrt_Click(sender As Object, e As EventArgs) Handles CntMnuEndPrt.Click
        'End printer
        Dim Result As String = InputBox("Please insert the printer to end", "End printer")
        If Result <> "" Then
            Result = "ENDWTR WTR(" + Result.ToUpper().Trim() + ") OPTION(*IMMED)"
            DisplayInformation("Please wait, process input...")
            ExecuteCommandOnHost(Result)
            RemoveInformation()
        End If
    End Sub

    Private Sub CntMnuSndBrkMsg_Click(sender As Object, e As EventArgs) Handles CntMnuSndBrkMsg.Click
        'Send break message to selected job(s)
        Dim Result As String = InputBox("Please inser the message to send as break message", "Send break message")
        Dim MessageRequest As String
        If Result <> "" Then
            For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
                DisplayInformation("Please wait, try to send message to job...")
                MessageRequest = "SNDBRKMSG MSG('" + Result.Trim() + "') TOMSGQ(" + DtaGrdActJob.Rows(SelectedRow.Index).Cells(14).Value.ToString.Trim() + ")"
                ExecuteCommandOnHost(MessageRequest)
                RemoveInformation()
            Next
        End If
    End Sub

    Private Sub CntMnuHldJob_Click(sender As Object, e As EventArgs) Handles CntMnuHldJob.Click
        'Hold selected job(s)
        Dim Command As String
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            If DtaGrdActJob.Rows(SelectedRow.Index).Cells(2).Value = "WTR" Then
                MessageBox.Show("Not possible, job is a printer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Result = MessageBox.Show("Please confirm the hold job request for: " + DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim(), "Hold job",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then

                    DisplayInformation("Please wait, try to hold job...")
                    Command = "HLDJOB JOB(" + DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString.Trim() + ")"
                    ExecuteCommandOnHost(Command)
                    RemoveInformation()
                End If
            End If
        Next
    End Sub

    Private Sub CntMnuRlsJob_Click(sender As Object, e As EventArgs) Handles CntMnuRlsJob.Click
        'Release selected job(s)
        Dim Command As String
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            If DtaGrdActJob.Rows(SelectedRow.Index).Cells(2).Value = "WTR" Then
                MessageBox.Show("Not possible, job is a printer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Result = MessageBox.Show("Please confirm the release job request for: " + DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim(), "Release job",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    DisplayInformation("Please wait, try to release job...")
                    Command = "RLSJOB JOB(" + DtaGrdActJob.Rows(SelectedRow.Index).Cells(1).Value.ToString.Trim() + ")"
                    ExecuteCommandOnHost(Command)
                    RemoveInformation()
                End If
            End If
        Next
    End Sub

    Private Sub CntMnuHldOutQ_Click(sender As Object, e As EventArgs) Handles CntMnuHldOutQ.Click
        'Hold selected outqueue(s)
        Dim Command As String
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            If DtaGrdActJob.Rows(SelectedRow.Index).Cells(2).Value = "WTR" Then
                Result = MessageBox.Show("Please confirm the hold outqueue request for: " + DtaGrdActJob.Rows(SelectedRow.Index).Cells(14).Value.ToString().Trim(), "Hold outqueue",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then
                    DisplayInformation("Please wait, try to hold outqueue...")
                    Command = "HLDOUTQ OUTQ(QUSRSYS/" + DtaGrdActJob.Rows(SelectedRow.Index).Cells(14).Value.ToString.Trim() + ")"
                    ExecuteCommandOnHost(Command)
                    RemoveInformation()
                End If
            Else
                MessageBox.Show("Not possible, job is not a printer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Next
    End Sub

    Private Sub CntMnuRlsOutQ_Click(sender As Object, e As EventArgs) Handles CntMnuRlsOutQ.Click
        'Release selected outqueue(s)
        Dim Command As String
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdActJob.SelectedRows
            If DtaGrdActJob.Rows(SelectedRow.Index).Cells(2).Value = "WTR" Then
                Result = MessageBox.Show("Please confirm the release outqueue request for: " + DtaGrdActJob.Rows(SelectedRow.Index).Cells(14).Value.ToString().Trim(), "Hold outqueue",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Result = System.Windows.Forms.DialogResult.Yes Then

                    DisplayInformation("Please wait, try to hold outqueue...")
                    Command = "RLSOUTQ OUTQ(QUSRSYS/" + DtaGrdActJob.Rows(SelectedRow.Index).Cells(14).Value.ToString.Trim() + ")"
                    ExecuteCommandOnHost(Command)
                    RemoveInformation()
                End If
            Else
                MessageBox.Show("Not possible, job is not a printer", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Next
    End Sub

    Private Sub ToolStripMessage_Click(sender As Object, e As EventArgs) Handles ToolStripMessage.Click
        ToolStripMessage.Text = Nothing
    End Sub

    Private Sub StartProcessGETActiveJobs(ByVal pURL As String, ByVal pJobTyp As String, ByVal pJobNameShort As String,
                                      ByVal pSelUsr As String, ByVal pSelJobSts As String, ByVal pSelSubSys As String,
                                      ByVal pSelFct As String, ByVal pClientIP As String)
        Dim GetActiveJobs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pJobTyp <> "" Then
            URL = URL.Trim() + "jobtype=" + pJobTyp.Trim() + "&"
        End If
        If pJobNameShort <> "" Then
            URL = URL.Trim() + "jobshort=" + pJobNameShort.Trim() + "&"
        End If
        If pSelUsr <> "" Then
            URL = URL.Trim() + "usr=" + pSelUsr.Trim() + "&"
        End If
        If pSelJobSts <> "" Then
            URL = URL.Trim() + "jobsts=" + pSelJobSts.Trim() + "&"
        End If
        If pSelSubSys <> "" Then
            URL = URL.Trim() + "sbs=" + pSelSubSys.Trim() + "&"
        End If
        If pSelFct <> "" Then
            URL = URL.Trim() + "fct=" + pSelFct.Trim() + "&"
        End If
        If pClientIP <> "" Then
            URL = URL.Trim() + "clientip=" + pClientIP.Trim()
        End If

        Try
            GetActiveJobs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetActiveJobs._returnJSONStream
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

        DisplayInformation("Please wait, parse incoming data...")

        With DtaGrdActJob
            .Columns.Clear()
            .Columns.Add("Pos", "Pos")
            .Columns(0).Visible = False
            .Columns.Add("JobName", "Job Name")
            .Columns.Add("JobType", "Job Type")
            .Columns.Add("JobStatus", "Job Status")
            .Columns.Add("JobMessage", "Job Message")
            .Columns.Add("MessageKey", "Message Key")
            .Columns.Add("AuthorizationName", "Authorization Name")
            .Columns.Add("AuthorizationDescription", "Authorization Description")
            .Columns.Add("FunctionType", "Function Type")
            .Columns.Add("Function", "Function")
            .Columns.Add("Storage", "Storage")
            .Columns.Add("ClientIPAddress", "Client IP Address")
            .Columns.Add("SubSystem", "Sub System")
            .Columns.Add("JobActivityTime", "Job Activity Time")
            .Columns.Add("JobNameShort", "Job Name Short")
            .Columns(14).Visible = False
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
                        ActiveJobInfo.JobNameShort = Entry("jobNameShort").ToString()
                        ActiveJobInfo.JobType = Entry("jobType").ToString()
                        ActiveJobInfo.JobStatus = Entry("jobStatus").ToString
                        Try
                            ActiveJobInfo.JobMessage = Entry("jobMessage").ToString()
                        Catch x As Exception
                            ActiveJobInfo.JobMessage = "-"
                        End Try
                        Try
                            ActiveJobInfo.MessageKey = Entry("messageKey").ToString
                        Catch x As Exception
                            ActiveJobInfo.MessageKey = "-"
                        End Try
                        ActiveJobInfo.AuthorizationName = Entry("authorizationName").ToString()
                        ActiveJobInfo.AuthorizationDescription = Entry("authorizationDescription").ToString()
                        Try
                            ActiveJobInfo.FunctionType = Entry("functionType").ToString()
                            ActiveJobInfo.FunctionName = Entry("function").ToString()
                        Catch x As Exception
                            ActiveJobInfo.FunctionType = "-"
                            ActiveJobInfo.FunctionName = "-"
                        End Try
                        Try
                            ActiveJobInfo.StorageUsed = Convert.ToInt32(Entry("temporaryStorage").ToString())
                        Catch x As Exception
                            ActiveJobInfo.StorageUsed = 0
                        End Try
                        Try
                            ActiveJobInfo.ClientIPAddress = Entry("clientIPAddress").ToString
                        Catch x As Exception
                            ActiveJobInfo.ClientIPAddress = "-"
                        End Try
                        ActiveJobInfo.JobActiveTime = Entry("jobActiveTime").ToString

                        DisplayInformation("Please wait, write parsed data to display...")
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
                            .Rows(Index).Cells(14).Value = ActiveJobInfo.JobNameShort
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DtaGrdActJob.Refresh()
    End Sub

    Private Async Sub EndJobImmed(ByVal pJobName As String)
        'Process end job requests
        ActiveJobWebservice = Main.Host.Trim() + "/endjobs"
        Dim PostEndJob As New DoRestStuffPost
        Dim endJob As New EndJob_T
        Dim Success As String
        endJob.endJobList(0).jobName = pJobName
        Dim JsonStream As String = JObject.FromObject(endJob).ToString
        PostEndJob.PostJSONData(ActiveJobWebservice, JsonStream, Main.Credentials.User, Main.Credentials.Password)
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
                                    ToolStripMessage.Visible = True
                                    ToolStripMessage.Text = "Job '" + pJobName.Trim() + "' ended successfull."
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

    Private Async Sub ReplyMessage(ByVal pMessageKey As String, ByVal pReplyMessage As String, ByVal pJobName As String)
        'Process reply messages
        ActiveJobWebservice = Main.Host.Trim() + "/replys"
        Dim PostReplyMessage As New DoRestStuffPost
        Dim replyMessage As New ReplyMessage_T
        Dim Success As String
        replyMessage.replyList(0).replyMessage = pReplyMessage
        replyMessage.replyList(0).messageKey = pMessageKey
        Dim JsonStream As String = JObject.FromObject(replyMessage).ToString
        PostReplyMessage.PostJSONData(ActiveJobWebservice, JsonStream, Main.Credentials.User, Main.Credentials.Password)
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
                                    ToolStripMessage.Visible = True
                                    ToolStripMessage.Text = "Sending reply message to job '" + pJobName.Trim() + "' was successfull"
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
        ActiveJobWebservice = Main.Host.Trim() + "/executecommands"
        Dim PostReplyMessage As New DoRestStuffPost
        Dim executeCommand As New ExecuteCommand_T
        Dim Success As String
        executeCommand.executeCommandList(0).command = pCommand
        Dim JsonStream As String = JObject.FromObject(executeCommand).ToString
        PostReplyMessage.PostJSONData(ActiveJobWebservice, JsonStream, Main.Credentials.User, Main.Credentials.Password)
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
                                    ToolStripMessage.Visible = True
                                    ToolStripMessage.Text = "Command executed successfull on host-system"
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
        CmbBoxJobSts.Items.AddRange(File.ReadAllLines(Application.StartupPath + "\settings\jobsts.txt"))
        CmbBoxSbs.Items.AddRange(File.ReadAllLines(Application.StartupPath + "\settings\sbs.txt"))
        CmbBoxJobTyp.Items.AddRange(File.ReadAllLines(Application.StartupPath + "\settings\jobtyp.txt"))
    End Sub

End Class
