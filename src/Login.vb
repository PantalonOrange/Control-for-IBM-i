'Login.vb
'This form handles the credentials and exit point to the webservice
'Copyright (C)2021 by Christian Brunner


Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Initial load
        HostTextBox.Text = "https://10.1.1.1:20210/system"
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Check data, login in -> save credentials to structure and load main-form
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
            MessageBox.Show("No webservice-address inserted!", "No webservice", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Success = False
        End If
        If Success Then
            Main.Credentials.User = UsernameTextBox.Text
            Main.Credentials.Password = PasswordTextBox.Text
            Main.Host = HostTextBox.Text
            Main.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
