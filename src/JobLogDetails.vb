'JobLogDetails.vb
'This form shows joblog entry details from specified job name
'Copyright (C)2022 by Christian Brunner


Public Class JobLogDetails

    Private Sub JobLogDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtBoxLvl2.Text = TxtBoxLvl2.Text.Replace("&N ", vbCrLf)
        TxtBoxLvl2.Text = TxtBoxLvl2.Text.Replace("&P ", vbCrLf)
        TxtBoxLvl2.Text = TxtBoxLvl2.Text.Replace("&B ", vbCrLf + vbTab)
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class