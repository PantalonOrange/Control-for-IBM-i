'Settings.vb
'This form handles the credentials and exit point to the webservice
'Copyright (C)2022 by Christian Brunner


Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxUsr.Text = Main.Credentials.User
        TxtBoxPwd.Text = Main.Credentials.Password
        TxtBoxHost.Text = Main.Host
        ChkBoxMsgw.Checked = Main.MsgwCheck
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        If TxtBoxUsr.Text = "" Then
            MessageBox.Show("Missing user", "Missing user", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxUsr.Select()
        ElseIf TxtBoxPwd.Text = "" Then
            MessageBox.Show("Missing password", "Missing password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxPwd.Select()
        ElseIf TxtBoxHost.Text = "" Then
            MessageBox.Show("Missing host-url", "Missing host", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtBoxHost.Select()
        Else
            Main.Credentials.User = TxtBoxUsr.Text
            Main.Credentials.Password = TxtBoxPwd.Text
            Main.Host = TxtBoxHost.Text
            Main.MsgwCheck = ChkBoxMsgw.Checked
            If Main.MsgwCheck And Not Main.MsgwSearchTimer.Enabled Then
                Main.MsgwSearchTimer.Start()
            ElseIf Not Main.MsgwCheck And Main.MsgwSearchTimer.Enabled Then
                Main.MsgwSearchTimer.Stop()
            End If
            Me.Close()
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

End Class