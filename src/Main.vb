'Main.vb
'Mainform as mdi-parent
'Copyright (C)2021,2022 by Christian Brunner


Public Class Main

    Public Credentials As New Credentials_T
    Public Host As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Main load
        StrpLabelHost.Text = Me.Host
        StrpLabelUser.Text = Me.Credentials.User
    End Sub

    Private Sub ChangeSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSettingsToolStripMenuItem.Click
        'Change credentials or api-url
        Login.Show()
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

End Class