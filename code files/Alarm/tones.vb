Public Class tones

    Public val, song As Integer
    Dim turn As Integer


    Public Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        setcolor(btn1, btn2, btn3, btn4)
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.BackgroundLoop)
        val = 1
    End Sub



    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click

        setcolor(btn2, btn1, btn3, btn4)
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Better, AudioPlayMode.BackgroundLoop)
        val = 2

    End Sub


    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click

        setcolor(btn3, btn1, btn2, btn4)
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.Nightwish, AudioPlayMode.BackgroundLoop)
        val = 3

    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click

        setcolor(btn4, btn1, btn2, btn3)
        My.Computer.Audio.Stop()
        My.Computer.Audio.Play(My.Resources.blues, AudioPlayMode.BackgroundLoop)
        val = 4
    End Sub

    Function setcolor(b1 As Button, b2 As Button, b3 As Button, b4 As Button) As Integer

        b1.BackColor = Color.White
        b1.ForeColor = Color.Black

        b2.BackColor = Color.Black
        b2.ForeColor = Color.White
        b3.BackColor = Color.Black
        b3.ForeColor = Color.White
        b4.BackColor = Color.Black
        b4.ForeColor = Color.White

        Return 0
    End Function

    Public Sub bk2_Click(sender As Object, e As EventArgs) Handles bk2.Click
        If song = 1 Then
           setcolor(btn1, btn2, btn3, btn4)

        ElseIf song = 2 Then
            setcolor(btn2, btn1, btn3, btn4)

        ElseIf song = 3 Then
            setcolor(btn3, btn1, btn2, btn4)

        Else
            setcolor(btn4, btn1, btn2, btn3)
        End If

        My.Computer.Audio.Stop()
        Me.Hide()
    End Sub



    Private Sub setmusic_Click_1(sender As Object, e As EventArgs) Handles setmusic.Click
        If val = 1 Then
            song = 1
        ElseIf val = 2 Then
            song = 2
        Else
            song = 3
        End If

        My.Computer.Audio.Stop()
        Me.Hide()

    End Sub
End Class