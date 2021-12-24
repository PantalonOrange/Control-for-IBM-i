Public Class Login

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Success As Boolean = True
        If UsernameTextBox.Text = "" Then
            UsernameTextBox.Select()
            MessageBox.Show("No user inserted!", "No user", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Success = False
        End If
        If Success And PasswordTextBox.Text = "" Then
            PasswordTextBox.Select()
            MessageBox.Show("No password inserted!", "No password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Success = False
        End If
        If Success And HostTextBox.Text = "" Then
            HostTextBox.Select()
            MessageBox.Show("No host-address inserted!", "No host", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Success = False
        End If
        If Success Then
            ActiveJobs.Credentials.User = UsernameTextBox.Text
            ActiveJobs.Credentials.Password = PasswordTextBox.Text
            ActiveJobs.Host = HostTextBox.Text
            ActiveJobs.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        HostTextBox.Text = "https://10.1.1.1:20210/system/activejobs"
    End Sub
End Class
