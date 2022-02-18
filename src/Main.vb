'Main.vb
'Mainform as mdi-parent
'Copyright (C)2021,2022 by Christian Brunner


Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq


Public Class Main

    Public Credentials As New Credentials_T
    Public Host As String
    Public MsgwCheck As Boolean

    Private MessageWait4Timer As MessageWait4Timer_T

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Main load
        StrpLabelHost.Text = Me.Host
        StrpLabelUser.Text = Me.Credentials.User
        ToolStripStsLblMsgwSearch.Visible = False
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        'Change credentials or api-url
        Dim SettingsForm As New Settings
        SettingsForm.MdiParent = Me
        SettingsForm.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Close app
        Login.Close()
        Me.Close()
    End Sub

    Private Sub MainClose(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub

    Private Sub ActiveJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveJobsToolStripMenuItem.Click, TlStrpActJob.Click
        'Show active jobs
        Dim ActiveJobForm As New ActiveJobs
        ActiveJobForm.MdiParent = Me
        ActiveJobForm.Show()
    End Sub

    Private Sub JobLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JobLogsToolStripMenuItem.Click, TlStrpJobLog.Click
        'Show job logs
        Dim JoblogForm As New JobLog
        JoblogForm.MdiParent = Me
        JoblogForm.Show()
    End Sub

    Private Sub UsrInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsrInfoToolStripMenuItem.Click, TlStrpUsrPrf.Click
        'Show user informations
        Dim UsrInfoForm As New UserProfiles
        UsrInfoForm.MdiParent = Me
        UsrInfoForm.Show()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        'Show informations about app
        MessageBox.Show("Control for IBM i® - Version: " + Login.Version + vbCrLf + "Erstellt von Christian Brunner" + vbCrLf + "Copyright (c)2021,2022 Pantalon Orange OSS" + vbCrLf +
                        "https://github.com/PantalonOrange/Control-for-IBM-i" + vbCrLf +
                        "Icons created by flaticon.com", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub MsgwSearchTimer_Tick(sender As Object, e As EventArgs) Handles MsgwSearchTimer.Tick
        'Start backgroundworker for msgw checks
        Try
            BackgroundMsgwSearch.RunWorkerAsync()
        Catch x As Exception
            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BackgroundMsgwSearch_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundMsgwSearch.DoWork
        'Check host over api for msgw
        If MsgwCheck Then
            MsgwSearchTimer.Stop()
        End If
        ToolStripStsLblMsgwSearch.Visible = True
        StartProcessGETActiveJobs()
        ToolStripStsLblMsgwSearch.Visible = False
        If MsgwCheck Then
            MsgwSearchTimer.Start()
        End If
    End Sub

    Private Sub BackgroundMsgwSearch_Completed(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundMsgwSearch.RunWorkerCompleted
        'Completed, show messagebox when msgw was found. Optionally open active jobs with filter jobsts msgw and jobnameshort
        Dim Result As DialogResult
        If MessageWait4Timer.JobMessage <> "" And MessageWait4Timer.MessageKey <> "" Then
            Result = MessageBox.Show("MSGW found at job " + MessageWait4Timer.JobName.Trim() + vbCrLf +
                                     "Message: " + MessageWait4Timer.JobMessage.Trim() + vbCrLf +
                                     "Start active jobs to check this information?", "MSGW found",
                                     MessageBoxButtons.YesNo, MessageBoxIcon.Information)
            If Result = System.Windows.Forms.DialogResult.Yes Then
                Dim ActiveJobsMsgw As New ActiveJobs
                ActiveJobsMsgw.MdiParent = Me
                ActiveJobsMsgw.CmbBoxJobSts.Text = "MSGW"
                ActiveJobsMsgw.TxtBoxJobNameShort.Text = MessageWait4Timer.JobNameShort.Trim()
                ActiveJobsMsgw.Show()
                ActiveJobsMsgw.BtnGet.PerformClick()
            End If
        End If
    End Sub

    Private Sub StartProcessGETActiveJobs()
        'Call activejobs api to search for msgw
        Dim GetActiveJobs As New DoRestStuffGet
        Dim ResponseStream As New ResponseFromServer_T
        Dim URL As String = Host.Trim() + "/activejobs?jobsts=MSGW"

        Try
            GetActiveJobs.GetJSONData(URL, Credentials.User, Credentials.Password)
            ResponseStream = GetActiveJobs._returnJSONStream
            If Not String.IsNullOrEmpty(ResponseStream.Response) Then
                If ResponseStream.Code = HttpStatusCode.OK Then
                    ParseJsonStream(ResponseStream.Response)
                End If
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

        For Each Item As JProperty In Data
            Item.CreateReader()
            Select Case Item.Name
                Case "activeJobInfo"
                    For Each Entry As JObject In Item.Values()
                        MessageWait4Timer.JobName = Entry("jobName").ToString()
                        MessageWait4Timer.JobNameShort = Entry("jobNameShort").ToString()
                        Try
                            MessageWait4Timer.JobMessage = Entry("jobMessage").ToString()
                        Catch x As Exception
                            MessageWait4Timer.JobMessage = ""
                        End Try
                        Try
                            MessageWait4Timer.MessageKey = Entry("messageKey").ToString
                        Catch x As Exception
                            MessageWait4Timer.MessageKey = ""
                        End Try
                        If MessageWait4Timer.JobMessage <> "" And MessageWait4Timer.MessageKey <> "" Then
                            Exit For
                        End If
                    Next
            End Select
        Next
    End Sub

End Class