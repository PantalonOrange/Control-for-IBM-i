'OutputQueueEntries.vb
'This form shows output queue entries
'Copyright (c)2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json.Linq

Public Class OutputQueueEntries

    Private ResponseStream As New ResponseFromServer_T
    Private OutQWebservice As String = Main.Host.Trim() + "/outqentries"

    Private Sub OutputQueueEntries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If TxtBoxOutQName.Text = "" And TxtBoxOutQLib.Text = "" And TxtBoxUsr.Text = "" And TxtBoxSplF.Text = "" Then
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
            Case 2 'Create timestamp
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 3 'Spooled file name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 4 'User name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 5 'User data
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 6 'Status
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 7 'Size
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 8 'Total pages
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 9 'Copies
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 10 'Form type
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 11 'job name
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 12 'Device type
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Case 13 'Output priority
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 14 'File number
                e.CellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                e.CellStyle.Format = "N0"
            Case 15 'System
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

    Private Sub DeleteSpooledFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteSpooledFileToolStripMenuItem.Click
        'Delete selcted spooled files
        Dim Result As DialogResult
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            Result = MessageBox.Show("Please confirm the delete-request for spool: " + vbCrLf +
                                     DtaGrdOutQ.Rows(SelectedRow.Index).Cells(3).Value.ToString().Trim(), "Delete spooled file?",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                DisplayInformation("Please wait, process delete spooled file on host...")
                DeleteSpooledFile(DtaGrdOutQ.Rows(SelectedRow.Index).Cells(3).Value.ToString(), DtaGrdOutQ.Rows(SelectedRow.Index).Cells(11).Value.ToString(),
                                  DtaGrdOutQ.Rows(SelectedRow.Index).Cells(14).Value.ToString())
                RemoveInformation()
            End If
        Next
    End Sub

    Private Sub HoldSpooledFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HoldSpooledFileToolStripMenuItem.Click
        'Hold selcted spooled files
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            DisplayInformation("Please wait, process hold spooled file on host...")
            HoldSpooledFile(DtaGrdOutQ.Rows(SelectedRow.Index).Cells(3).Value.ToString(), DtaGrdOutQ.Rows(SelectedRow.Index).Cells(11).Value.ToString(),
                              DtaGrdOutQ.Rows(SelectedRow.Index).Cells(14).Value.ToString())
            RemoveInformation()
        Next
    End Sub

    Private Sub ReleaseSpooledFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReleaseSpooledFileToolStripMenuItem.Click
        'Release selcted spooled files
        For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
            DisplayInformation("Please wait, process hold spooled file on host...")
            ReleaseSpooledFile(DtaGrdOutQ.Rows(SelectedRow.Index).Cells(3).Value.ToString(), DtaGrdOutQ.Rows(SelectedRow.Index).Cells(11).Value.ToString(),
                              DtaGrdOutQ.Rows(SelectedRow.Index).Cells(14).Value.ToString())
            RemoveInformation()
        Next
    End Sub

    Private Sub ChangeOutputQueueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeOutputQueueToolStripMenuItem.Click
        'Change spooled file attribute OUTQ
        Dim NewOutQ As String = InputBox("Please insert the new output queue", "Change spooled file attribute")
        If NewOutQ <> "" Then
            For Each SelectedRow As DataGridViewRow In DtaGrdOutQ.SelectedRows
                DisplayInformation("Please wait, process hold spooled file on host...")
                ChangeSpooledFileOutputQueue(DtaGrdOutQ.Rows(SelectedRow.Index).Cells(3).Value.ToString(), DtaGrdOutQ.Rows(SelectedRow.Index).Cells(11).Value.ToString(),
                                             DtaGrdOutQ.Rows(SelectedRow.Index).Cells(14).Value.ToString(), NewOutQ)
                RemoveInformation()
            Next
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

    Private Sub DeleteSpooledFile(ByVal pSpooledFileName As String, ByVal pJobName As String, ByVal pFileNumber As String)
        ExecuteCommandOnHost("DLTSPLF FILE(" + pSpooledFileName.Trim() + ") JOB(" + pJobName.Trim() + ") SPLNBR(" + pFileNumber.Trim() + ")")
    End Sub

    Private Sub HoldSpooledFile(ByVal pSpooledFileName As String, ByVal pJobName As String, ByVal pFileNumber As String)
        ExecuteCommandOnHost("HLDSPLF FILE(" + pSpooledFileName.Trim() + ") JOB(" + pJobName.Trim() + ") SPLNBR(" + pFileNumber.Trim() + ")")
    End Sub

    Private Sub ReleaseSpooledFile(ByVal pSpooledFileName As String, ByVal pJobName As String, ByVal pFileNumber As String)
        ExecuteCommandOnHost("RLSSPLF FILE(" + pSpooledFileName.Trim() + ") JOB(" + pJobName.Trim() + ") SPLNBR(" + pFileNumber.Trim() + ")")
    End Sub

    Private Sub ChangeSpooledFileOutputQueue(ByVal pSpooledFileName As String, ByVal pJobName As String, ByVal pFileNumber As String, ByVal pNewOutQ As String)
        ExecuteCommandOnHost("CHGSPLFA FILE(" + pSpooledFileName.Trim() + ") JOB(" + pJobName.Trim() + ") SPLNBR(" + pFileNumber.Trim() + ") OUTQ(" + pNewOutQ.Trim() + ")")
    End Sub

    Public Sub RunGetProcess()
        'Start communication, retrieve json stream and fill datagridview
        BtnGet.Enabled = False
        BtnClose.Enabled = False
        DtaGrdOutQ.Visible = True
        DtaGrdOutQ.Enabled = False
        ToolStripMessage.Text = Nothing
        DisplayInformation("Please wait, collecting data...")
        StartProcessGETOutQInfo(OutQWebservice, TxtBoxOutQName.Text, TxtBoxOutQLib.Text, TxtBoxUsr.Text, TxtBoxSplF.Text, CmbBoxMax.Text)
        RemoveInformation()
        BtnGet.Enabled = True
        BtnClose.Enabled = True
        DtaGrdOutQ.Enabled = True
    End Sub

    Private Sub StartProcessGETOutQInfo(ByVal pURL As String, ByVal pOutQName As String, ByVal pOutQLib As String, ByVal pUser As String,
                                        ByVal pSpooledFile As String, ByVal pLimit As String)
        Dim GetOutQEntry As New DoRestStuffGet
        Dim URL As String = pURL.Trim() + "?"
        If pOutQName <> "" Then
            URL = URL.Trim() + "outq=" + pOutQName.Trim() + "&"
        End If
        If pOutQLib <> "" Then
            URL = URL.Trim() + "outqlib=" + pOutQLib.Trim() + "&"
        End If
        If pUser <> "" Then
            URL = URL.Trim() + "usr=" + pUser.Trim() + "&"
        End If
        If pSpooledFile <> "" Then
            URL = URL.Trim() + "splf=" + pSpooledFile.Trim() + "&"
        End If
        If pLimit <> "" Then
            URL = URL.Trim() + "limit=" + pLimit.Trim()
        End If

        Try
            GetOutQEntry.GetJSONData(URL, Main.Credentials.User, Main.Credentials.Password)
            ResponseStream = GetOutQEntry._returnJSONStream
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
        Dim OutputQueueEntries As New OutputQueueEntry_T
        Dim Ser As JObject = JObject.Parse(pJSON)
        Dim Data As List(Of JToken) = Ser.Children().ToList()
        Dim Index As Integer = 0

        With DtaGrdOutQ
            .Columns.Clear()
            .Columns.Add("OutQName", "Output Queue Name")
            .Columns.Add("OutQLib", "Output Queue Library")
            .Columns.Add("CrtTstp", "Create Timestamp")
            .Columns.Add("SplFN", "Spooled File Name")
            .Columns.Add("Usr", "User Name")
            .Columns.Add("UsrDta", "User Data")
            .Columns.Add("Sts", "Status")
            .Columns.Add("Size", "Size")
            .Columns.Add("TotPag", "Total Pages")
            .Columns.Add("Copies", "Copies")
            .Columns.Add("FrmTyp", "Form Type")
            .Columns.Add("JobNam", "Job Name")
            .Columns.Add("DevTyp", "Device Type")
            .Columns.Add("OutPty", "Output Priority")
            .Columns.Add("FilNbr", "File Number")
            .Columns.Add("System", "System")
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
                Case "outputQueueEntries"
                    For Each Entry As JObject In Item.Values()
                        OutputQueueEntries.OutputQueueName = Entry("outputQueueName").ToString()
                        Try
                            OutputQueueEntries.OutputQueueLibrary = Entry("outputQueueLibrary").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.OutputQueueLibrary = Nothing
                        End Try
                        Try
                            OutputQueueEntries.CreateTimestamp = Entry("createTimestamp").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.CreateTimestamp = Nothing
                        End Try
                        Try
                            OutputQueueEntries.SpooledFileName = Entry("spooledFileName").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.SpooledFileName = Nothing
                        End Try
                        Try
                            OutputQueueEntries.UserName = Entry("userName").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.UserName = Nothing
                        End Try
                        Try
                            OutputQueueEntries.UserData = Entry("userData").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.UserData = Nothing
                        End Try
                        Try
                            OutputQueueEntries.Status = Entry("status").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.Status = Nothing
                        End Try
                        Try
                            OutputQueueEntries.Size = Entry("size").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.Size = Nothing
                        End Try
                        Try
                            OutputQueueEntries.TotalPages = Entry("totalPages").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.TotalPages = Nothing
                        End Try
                        Try
                            OutputQueueEntries.Copies = Entry("copies").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.Copies = Nothing
                        End Try
                        Try
                            OutputQueueEntries.FormType = Entry("formType").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.FormType = Nothing
                        End Try
                        Try
                            OutputQueueEntries.JobName = Entry("jobName").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.JobName = Nothing
                        End Try
                        Try
                            OutputQueueEntries.DeviceType = Entry("deviceType").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.DeviceType = Nothing
                        End Try
                        Try
                            OutputQueueEntries.OutputPriority = Entry("outputPriority").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.OutputPriority = Nothing
                        End Try
                        Try
                            OutputQueueEntries.FileNumber = Entry("fileNumber").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.FileNumber = Nothing
                        End Try
                        Try
                            OutputQueueEntries.System = Entry("system").ToString()
                        Catch ex As Exception
                            OutputQueueEntries.System = Nothing
                        End Try

                        DisplayInformation("Please wait, write parsed data to display...")

                        With DtaGrdOutQ
                            .Rows.Add(OutputQueueEntries.OutputQueueName)
                            .Rows(Index).Cells(1).Value = OutputQueueEntries.OutputQueueLibrary
                            .Rows(Index).Cells(2).Value = OutputQueueEntries.CreateTimestamp
                            .Rows(Index).Cells(3).Value = OutputQueueEntries.SpooledFileName
                            .Rows(Index).Cells(4).Value = OutputQueueEntries.UserName
                            .Rows(Index).Cells(5).Value = OutputQueueEntries.UserData
                            .Rows(Index).Cells(6).Value = OutputQueueEntries.Status
                            .Rows(Index).Cells(7).Value = OutputQueueEntries.Size
                            .Rows(Index).Cells(8).Value = OutputQueueEntries.TotalPages
                            .Rows(Index).Cells(9).Value = OutputQueueEntries.Copies
                            .Rows(Index).Cells(10).Value = OutputQueueEntries.FormType
                            .Rows(Index).Cells(11).Value = OutputQueueEntries.JobName
                            .Rows(Index).Cells(12).Value = OutputQueueEntries.DeviceType
                            .Rows(Index).Cells(13).Value = OutputQueueEntries.OutputPriority
                            .Rows(Index).Cells(14).Value = OutputQueueEntries.FileNumber
                            .Rows(Index).Cells(15).Value = OutputQueueEntries.System
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