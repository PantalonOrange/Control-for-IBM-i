'OutputQueues.vb
'This form shows output queue informations
'Copyright (c)2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq


Public Class OutputQueues

    Private ResponseStream As New ResponseFromServer_T
    Private OutQWebservice As String = Main.Host.Trim() + "/outqs"

    Private Sub OutputQueues_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial load
        Me.KeyPreview = True
        LblSuccess.Text = "-"
        LblResults.Text = "-"
        LblWait.Visible = False
        ToolStripRecordsSelected.Text = ""
        ToolStripRecordsSelected.Visible = False
        ToolStripMessage.Visible = False
        DtaGrdOutQ.Visible = False
        PrgBar.Visible = False
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

    Private Sub DtaGrdOutQ_RowsSelected(sender As Object, e As EventArgs) Handles DtaGrdOutQ.SelectionChanged
        Dim RecordsSelected As Integer = DtaGrdOutQ.SelectedRows.Count
        If RecordsSelected > 0 Then
            ToolStripRecordsSelected.Visible = True
            ToolStripRecordsSelected.Text = "Selected rows: " + RecordsSelected.ToString()
        Else
            ToolStripRecordsSelected.Visible = False
        End If
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs) Handles BtnGet.Click
        If TxtBoxOutQName.Text = "" And TxtBoxOutQLib.Text = "" Then
            MessageBox.Show("Please take at least one selection", "No selection found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxOutQName.Select()
        Else
            RunGetProcess()
        End If
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub DtaGrdOutQ_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DtaGrdOutQ.CellFormatting
        If e.RowIndex Mod 2 = 0 Then
            'Every second row
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.LightGray
        Else
            e.CellStyle.ForeColor = Color.Black
            e.CellStyle.BackColor = Color.White
        End If

        Select Case e.ColumnIndex
            Case 0 'output queue name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 1 'output queue library
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 2 'number of files
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 3 'number of writers
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 4 'writer to autostart
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 5 'printer device name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 6 'operator controlled
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 7 'Output Queue Status
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 8 'Writer Job Name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 9 'writer Job Status
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            Case 10 'text description
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        End Select
    End Sub


    Private Sub DtaGrdOutQ_MouseClick(sender As Object, e As MouseEventArgs) Handles DtaGrdOutQ.MouseClick
        'Shows the drop down menue on the datagridview via mouseclick
        If e.Button = Windows.Forms.MouseButtons.Right Or e.Button = Windows.Forms.Keys.RMenu Then
            CntMnuStrip.Show(Me, e.Location)
        End If
    End Sub

    Private Sub ToolStripMessage_Click(sender As Object, e As EventArgs) Handles ToolStripMessage.Click
        ToolStripMessage.Text = Nothing
    End Sub

    Private Sub HoldOutqueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoldOutqueueToolStripMenuItem.Click
        'Hold selected outpur queues
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            ExecuteCommandOnHost("HLDOUTQ OUTQ(" + DtaGrdOutQ.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim() + "/" +
                                    DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString().Trim() + ")")
        Next
    End Sub

    Private Sub ReleaseOutqueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseOutqueueToolStripMenuItem.Click
        'Release selected output queues
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            ExecuteCommandOnHost("RLSOUTQ OUTQ(" + DtaGrdOutQ.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim() + "/" +
                                    DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString().Trim() + ")")
        Next
    End Sub

    Private Sub ClearOutputQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearOutputQueueToolStripMenuItem.Click
        'Clear entries for selected output queues
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            Result = MessageBox.Show("Please confirm the clear-request for output queue: " + vbCrLf +
                                     DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString().Trim(), "Clear all entries for output queue?",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                DisplayInformation("Please wait, process clear output queue on host...")
                ExecuteCommandOnHost("CLROUTQ OUTQ(" + DtaGrdOutQ.Rows(SelectedRow.Index).Cells(1).Value.ToString().Trim() +
                                     "/" + DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString().Trim() + ")")
                RemoveInformation()
            End If
        Next
    End Sub

    Private Sub DisplayActiveJobToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayActiveJobToolStripMenuItem.Click
        'Display active job information for each selected output queue with running job
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            If DtaGrdOutQ.Rows(SelectedRow.Index).Cells(8).Value.ToString() <> "" Then
                Dim ActiveJobsForm As New ActiveJobs
                ActiveJobsForm.MdiParent = Main
                ActiveJobsForm.TxtBoxJobNameShort.Text = DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString()
                ActiveJobsForm.Show()
                ActiveJobsForm.DtaGrdActJob.Select()
                ActiveJobsForm.BtnGet.PerformClick()
            End If
        Next
    End Sub

    Private Sub DisplayJoblogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayJoblogToolStripMenuItem.Click
        'Display joblog for each selection
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            If DtaGrdOutQ.Rows(SelectedRow.Index).Cells(8).Value.ToString() <> "" Then
                Dim JoblogForm As New JobLog
                JoblogForm.MdiParent = Main
                JoblogForm.TxtBoxJob.Text = DtaGrdOutQ.Rows(SelectedRow.Index).Cells(8).Value.ToString()
                JoblogForm.TxtBoxJob.ReadOnly = True
                JoblogForm.Show()
                JoblogForm.DtaGrdJobLog.Select()
                JoblogForm.BtnGet.PerformClick()
            End If
        Next
    End Sub

    Private Sub DisplayEntriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayEntriesToolStripMenuItem.Click, DtaGrdOutQ.DoubleClick
        'Display output queue entries for each selection
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            Dim OutQEntryForm As New OutputQueueEntries
            OutQEntryForm.MdiParent = Main
            OutQEntryForm.TxtBoxOutQName.Text = DtaGrdOutQ.Rows(SelectedRow.Index).Cells(0).Value.ToString()
            OutQEntryForm.TxtBoxOutQLib.Text = DtaGrdOutQ.Rows(SelectedRow.Index).Cells(1).Value.ToString()
            OutQEntryForm.JobNameLongFilter = Nothing
            OutQEntryForm.Show()
            OutQEntryForm.DtaGrdOutQ.Select()
            OutQEntryForm.BtnGet.PerformClick()
        Next
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

    Public Sub RunGetProcess()
        'Start communication, retrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        DtaGrdOutQ.Visible = True
        DtaGrdOutQ.Enabled = False
        ToolStripMessage.Text = Nothing
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETOutQInfo(OutQWebservice, TxtBoxOutQName.Text, TxtBoxOutQLib.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        DtaGrdOutQ.Enabled = True
    End Sub

    Private Sub StartProcessGETOutQInfo(ByVal pURL As String, ByVal pOutQName As String, ByVal pOutQLib As String)
        Dim GetOutQs As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pOutQName <> "" Then
            URL = URL.Trim() + "outq=" + pOutQName.Trim() + "&"
        End If
        If pOutQLib <> "" Then
            URL = URL.Trim() + "outqlib=" + pOutQLib.Trim() + "&"
        End If

        Try
            GetOutQs.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetOutQs._returnJSONStream
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                    DtaGrdOutQ.Select()
                ElseIf ResponseStream.Code = HttpStatusCode.Unauthorized Then
                    LblSuccess.Text = "false"
                    LblResults.Text = ResponseStream.Response.Trim() + " (" + ResponseStream.Code.Trim() + ")"
                    MessageBox.Show(LblResults.Text, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                DtaGrdOutQ.Visible = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "WS-Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ParseJsonStream(ByVal pJSON As String)
        'Parse incomming json stream and fill in the data to datagridview
        Dim OutputQueueInformation As New OutputQueue_T
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DtaGrdOutQ
            .Columns.Clear()
            .Columns.Add("OutQName", "Name")
            .Columns.Add("OutQLib", "Library")
            .Columns.Add("NbrOfFiles", "Files")
            .Columns.Add("NbrOfWtr", "Writers")
            .Columns.Add("Wrt2Auto", "Autostart")
            .Columns.Add("PrtDevNam", "Printer device name")
            .Columns.Add("OpCtl", "Operator")
            .Columns.Add("OutQSts", "Output Queue Status")
            .Columns.Add("WtrJobName", "Writer job name")
            .Columns.Add("WtrJobStst", "Writer job status")
            .Columns.Add("Description", "Description")
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
                Case "outputQueueInfo"
                    For Each Entry As JObject In Item.Values()
                        OutputQueueInformation.OutputQueueName = Entry("outputQueueName").ToString()
                        Try
                            OutputQueueInformation.OutputQueueLibrary = Entry("outputQueueLibrary").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.OutputQueueLibrary = Nothing
                        End Try
                        Try
                            OutputQueueInformation.NumberOfFiles = Entry("numberOfFiles").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.NumberOfFiles = "0"
                        End Try
                        Try
                            OutputQueueInformation.NumberOfWriters = Entry("numberOfWriters").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.NumberOfWriters = "0"
                        End Try
                        Try
                            OutputQueueInformation.WriterToAutostart = Entry("writerToAutostart").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.WriterToAutostart = Nothing
                        End Try
                        Try
                            OutputQueueInformation.PrinterDeviceName = Entry("printerDeviceName").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.PrinterDeviceName = Nothing
                        End Try
                        Try
                            OutputQueueInformation.OperatorControlled = (Entry("operatorControlled").ToString() = "true")
                        Catch ex As Exception
                            OutputQueueInformation.OperatorControlled = Nothing
                        End Try
                        Try
                            OutputQueueInformation.OutputQueueStatus = Entry("outputQueueStatus").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.OutputQueueStatus = Nothing
                        End Try
                        Try
                            OutputQueueInformation.WriterJobName = Entry("writerJobName").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.WriterJobName = Nothing
                        End Try
                        Try
                            OutputQueueInformation.writerJobStatus = Entry("writerJobStatus").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.writerJobStatus = Nothing
                        End Try
                        Try
                            OutputQueueInformation.TextDescription = Entry("textDescription").ToString()
                        Catch ex As Exception
                            OutputQueueInformation.TextDescription = Nothing
                        End Try

                        DisplayInformation("Please wait, write parsed data to display...")

                        With DtaGrdOutQ
                            .Rows.Add(OutputQueueInformation.OutputQueueName)
                            .Rows(Index).Cells(1).Value = OutputQueueInformation.OutputQueueLibrary
                            .Rows(Index).Cells(2).Value = OutputQueueInformation.NumberOfFiles
                            .Rows(Index).Cells(3).Value = OutputQueueInformation.NumberOfWriters
                            .Rows(Index).Cells(4).Value = OutputQueueInformation.WriterToAutostart
                            .Rows(Index).Cells(5).Value = OutputQueueInformation.PrinterDeviceName
                            .Rows(Index).Cells(6).Value = OutputQueueInformation.OperatorControlled
                            .Rows(Index).Cells(7).Value = OutputQueueInformation.OutputQueueStatus
                            .Rows(Index).Cells(8).Value = OutputQueueInformation.WriterJobName
                            .Rows(Index).Cells(9).Value = OutputQueueInformation.WriterJobStatus
                            .Rows(Index).Cells(10).Value = OutputQueueInformation.TextDescription
                        End With
                        Index += 1
                    Next
            End Select
        Next
        DtaGrdOutQ.Refresh()
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