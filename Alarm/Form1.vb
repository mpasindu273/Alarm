Public Class Form1

    Dim sec As String
    Dim min As String
    Dim hour As String
    Dim duration As Integer = 10
    Dim alarmset As Integer
    Dim stopped, done As Integer
    Dim snoozed As Integer
    Dim whileplaying As Integer
    Dim sel, mel, hel As Integer


    Private Sub tim_Tick(sender As Object, e As EventArgs) Handles tim.Tick

        sec = DateTime.Now.ToString("ss")
        min = DateTime.Now.ToString("mm")
        hour = DateTime.Now.ToString("HH")

        Dim tsec As String = ts.Text
        Dim tmin As String = tm.Text
        Dim thour As String = th.Text

        ls.Text = sec
        lm.Text = min
        lh.Text = hour        

        If done <> 1 And th.Text = "00" Then
            If hel = 1 Then
                th.SelectAll()
            End If
        End If

        If done <> 1 And tm.Text = "00" Then
            If mel = 1 Then
                tm.SelectAll()
            End If
        End If

        If done <> 1 And ts.Text = "00" Then
            If sel = 1 Then
                ts.SelectAll()
            End If
        End If


        If alarmset = 1 Then

            If tsec.Equals(sec) And tmin.Equals(min) And thour.Equals(hour) Then

                If tones.song = 1 Then
                    My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.BackgroundLoop)

                ElseIf tones.song = 2 Then
                    My.Computer.Audio.Play(My.Resources.Better, AudioPlayMode.BackgroundLoop)

                ElseIf tones.song = 3 Then
                    My.Computer.Audio.Play(My.Resources.Nightwish, AudioPlayMode.BackgroundLoop)

                Else
                    My.Computer.Audio.Play(My.Resources.blues, AudioPlayMode.BackgroundLoop)
                End If

                whileplaying = 1
                buttons("Stop", "#FF69B4", "Snooze", "#da70d6")

            End If
        End If


        If stopped = 1 Then

            buttons("Clear", "#191970", "Set Alarm", "#191970")
            My.Computer.Audio.Stop()
            alarmset = 0
            duration = 10
            stopped = 0
            whileplaying = 0
            snoozed = 0
            done = 0

        Else
            If snoozed = 1 Then
                My.Computer.Audio.Stop()
                setalm.Text = CStr(duration) + " (s)"
                clr.Text = "Stop"
                duration -= 1

                If duration = 0 Then
                    setalm.Text = "Snooze"

                    If tones.song = 1 Then
                        My.Computer.Audio.Play(My.Resources.ring, AudioPlayMode.BackgroundLoop)

                    ElseIf tones.song = 2 Then
                        My.Computer.Audio.Play(My.Resources.Better, AudioPlayMode.BackgroundLoop)

                    ElseIf tones.song = 3 Then
                        My.Computer.Audio.Play(My.Resources.Nightwish, AudioPlayMode.BackgroundLoop)

                    Else
                        My.Computer.Audio.Play(My.Resources.blues, AudioPlayMode.BackgroundLoop)
                    End If

                    duration = 10
                    snoozed = 0

                End If
            End If
        End If

    End Sub


    Private Sub setalm_Click(sender As Object, e As EventArgs) Handles setalm.Click

        If whileplaying = 1 Then
            snoozed = 1
        Else
            autofil()
            buttons("Cancel", "#0000cd", "Alarm Set!", "#ba55d3")
            alarmset = 1
            done = 1
        End If

    End Sub

    Private Sub clr_Click(sender As Object, e As EventArgs) Handles clr.Click

        ts.Text = "00"
        tm.Text = "00"
        th.Text = "00"
        buttons("Clear", "#191970", "Set Alarm", "#191970")
        My.Computer.Audio.Stop()
        done = 0

        If whileplaying = 1 Then
            stopped = 1
        End If

    End Sub


    Private Sub th_TextChanged(sender As Object, e As EventArgs) Handles th.TextChanged
        hel = 1
    End Sub

    Private Sub tm_TextChanged(sender As Object, e As EventArgs) Handles tm.TextChanged
        mel = 1
    End Sub

    Private Sub ts_TextChanged(sender As Object, e As EventArgs) Handles ts.TextChanged
        sel = 1
    End Sub


    Function buttons(ct As String, cb As String, st As String, sb As String) As String

        clr.Text = ct
        clr.BackColor = ColorTranslator.FromHtml(cb)
        setalm.Text = st
        setalm.BackColor = ColorTranslator.FromHtml(sb)
        Return 0

    End Function

    Function autofil() As Integer

        If th.Text.Length = 1 Then
            th.Text = "0" + th.Text()
        End If

        If tm.Text.Length = 1 Then
            tm.Text = "0" + tm.Text()
        End If

        If ts.Text.Length = 1 Then
            ts.Text = "0" + ts.Text()
        End If

        Return 0
    End Function

    Function jumptonext() As Integer

        If th.Text.Length = 2 Then
            tm.Focus()
        End If

        If tm.Text.Length = 2 Then
            ts.Focus()
        End If

        Return 0
    End Function

    Private Sub stn_Click(sender As Object, e As EventArgs) Handles stn.Click
        Form2.Show()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
