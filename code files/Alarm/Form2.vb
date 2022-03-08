Public Class Form2

    Private Sub qit_Click(sender As Object, e As EventArgs) Handles qit.Click
        Application.Exit()

    End Sub

    Private Sub almtone_Click(sender As Object, e As EventArgs) Handles almtone.Click
        tones.Show()
    End Sub

    Private Sub bk_Click(sender As Object, e As EventArgs) Handles bk.Click
        Me.Hide()
    End Sub
End Class