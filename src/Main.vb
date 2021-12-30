'Main.vb
'Mainform as mdi-parent
'Copyright (C)2021 by Christian Brunner


Public Class Main

    Public Credentials As New Credentials_T
    Public Host As String

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StrpLabelHost.Text = Me.Host
        StrpLabelUser.Text = Me.Credentials.User
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Login.Close()
        Me.Close()
    End Sub

    Private Sub MainClose(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub

    Private Sub ActiveJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActiveJobsToolStripMenuItem.Click
        Dim ActiveJobForm As New ActiveJobs
        ActiveJobForm.MdiParent = Me
        ActiveJobForm.Show()
    End Sub
End Class