Public Class Form5
    Dim speed As Integer
    Dim road(2) As PictureBox
    Dim life As Integer = 0


    Dim score As Integer = 0
    Dim up As Integer = 0
    Dim down As Integer = 0


    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Move
        speed = 2
        'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)



        road(0) = PictureBox1

        road(1) = PictureBox2




    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For x As Integer = 0 To 1

            road(x).Left += speed
            If road(x).Left >= Me.Width Then

                road(x).Left = -road(x).Width
            End If
        Next
        If score > 10 And score < 25 Then
            speed = 2.65

        End If
        If score > 25 And score < 40 Then
            speed = 3.25
        End If
        If score > 50 Then
            speed = 4.5
        End If
        If score > 13 And score < 14 Then
            speed = 1
        End If
        If score > 29 And score < 31 Then
            speed = 1
        End If

    End Sub
End Class