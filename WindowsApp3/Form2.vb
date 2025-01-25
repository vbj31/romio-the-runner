Public Class Form2
    Dim speed As Integer
    Dim road(2) As PictureBox
    Dim life As Integer = 0


    Dim score As Integer = 0
    Dim up As Integer = 0
    Dim down As Integer = 0

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Move
        speed = 2
        'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)



        road(0) = PictureBox1

        road(1) = PictureBox2
        road(2) = PictureBox3



    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        For x As Integer = 0 To 2

            road(x).Left += speed
            If road(x).Left >= Me.Width Then

                road(x).Left = -road(x).Width
            End If
        Next
        If score > 10 And score < 25 Then
            speed = 2.5

        End If
        If score > 25 And score < 40 Then
            speed = 3
        End If
        If score > 50 Then
            speed = 4
        End If
        If score > 29 And score < 31 Then
            speed = 1
        End If
        If score >= 15 Then
            newlevel()
        End If

        speed_text.Text = "Speed " & speed
        For Each PictureBox In Me.Controls



            If romeo.Bounds.IntersectsWith(enemy2.Bounds) Then
                ' My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                life = life + 1
                Label1.Text = "life " & 3 - life



                enemy2.Left += 200
                ' MessageBox.Show("1 life down 1 left", "romeo-The runne", MessageBoxButtons.OK, MessageBoxIcon.Information)




                gameOver()

            End If
            If romeo.Bounds.IntersectsWith(enemy3.Bounds) Then
                ' My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                life = life + 1

                Label1.Text = "life " & 3 - life
                enemy3.Left += 200
                gameOver()

            End If

            If romeo.Bounds.IntersectsWith(enemy4.Bounds) Then
                'My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                life = life + 1

                Label1.Text = "life " & 3 - life
                enemy4.Left += 200
                gameOver()
            End If



            If romeo.Bounds.IntersectsWith(gift.Bounds) Then
                'My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                'My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                'My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)


                score += 5
                gift.Left += 200



            End If

        Next





    End Sub

    Private Sub gameOver()
        If life = 1 Then
            'romeo.Image = Image.FromFile("G:\WindowsApp3V\WindowsApp3\assets\mario2_move2.bmp")

        End If
        If life = 2 Then
            'romeo.Image = Image.FromFile("G:\WindowsApp3V\WindowsApp3\assets\mario2_move2.png")

        End If
        If life = 3 Then
            My.Computer.Audio.Stop()


            ' My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\death.wav")



            replay_button.Visible = True
            end_text.Visible = True
            Timer1.Stop()
            down_mover.Stop()
            up_mover.Stop()
            enemy_1.Stop()
            enemy_2.Stop()
            enemy_3.Stop()
            enemy_4.Stop()
            gift1.Stop()


            up = 0
            down = 0
            score = 0
            life = 0
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background)


        End If





    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs)
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        Timer1.Stop()
        down_mover.Stop()
        up_mover.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        enemy_4.Stop()
        gift1.Stop()

        dialog = MessageBox.Show("do you want to exit", "exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
            Timer1.Start()
            down_mover.Start()
            up_mover.Start()
            enemy_1.Start()
            enemy_2.Start()
            enemy_3.Start()
            enemy_4.Start()
            gift1.Start()
        Else
            Application.ExitThread()
        End If
    End Sub


    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub down_mover_Tick(sender As Object, e As EventArgs) Handles down_mover.Tick
        If up < 110 Then
            romeo.Top += 5
            up += 5
            down -= 5
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            up_mover.Start()
        End If
        If e.KeyCode = Keys.Down Then
            down_mover.Start()

        End If

    End Sub

    Private Sub romeo_Click(sender As Object, e As EventArgs) Handles romeo.Click

    End Sub

    Private Sub up_mover_Tick(sender As Object, e As EventArgs) Handles up_mover.Tick
        If down < 100 Then
            romeo.Top -= 5
            up -= 5
            down += 5
        End If

    End Sub






    Private Sub Form2_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        up_mover.Stop()
        down_mover.Stop()
    End Sub

    Private Sub enemy_2_Tick(sender As Object, e As EventArgs) Handles enemy_2.Tick
        enemy2.Left += speed * 2.5
        If enemy2.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score
            enemy2.Left = -(CInt(Math.Ceiling(Rnd() * 150)) + enemy2.Width)


        End If
    End Sub

    Private Sub enemy_4_Tick(sender As Object, e As EventArgs) Handles enemy_4.Tick
        enemy4.Left += speed * 1.5
        If enemy4.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score
            enemy4.Left = -(CInt(Math.Ceiling(Rnd() * 300)) + enemy4.Width)


        End If
    End Sub

    Private Sub enemy_3_Tick(sender As Object, e As EventArgs) Handles enemy_3.Tick
        enemy3.Left += speed * 2
        If enemy3.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score
            enemy3.Left = -(CInt(Math.Ceiling(Rnd() * 300)) + enemy3.Width)


        End If
    End Sub
    Private Sub enemy2_Click(sender As Object, e As EventArgs) Handles enemy2.Click

    End Sub

    Private Sub replay_button_Click(sender As Object, e As EventArgs) Handles replay_button.Click
        score = 0
        life = 0

        Me.Controls.Clear()
        InitializeComponent()

        Form2_Load(e, e)
    End Sub
    Private Sub newlevel()
        My.Computer.Audio.Stop()
        '  My.Computer.Audio.Play("G:\WindowsApp3V\firework.wav")

        Button1.Visible = True
        Label2.Visible = True
        Timer1.Stop()
        down_mover.Stop()
        up_mover.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        enemy_4.Stop()
        gift1.Stop()
        up = 0
        down = 0
        score = 0
        life = 0

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Visible = False
        Form4.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub gift1_Tick(sender As Object, e As EventArgs) Handles gift1.Tick
        gift.Left += speed * 2
        If gift.Left >= Me.Width Then
            '  gift.Left = -gift.Width

            gift.Left = -(CInt(Math.Ceiling(Rnd() * 300)) + gift.Width)
            gift.Top = (CInt(Math.Ceiling(Rnd() * 380) + 207))

        End If



    End Sub




    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Timer1.Start()
        down_mover.Start()
        up_mover.Start()
        enemy_4.Start()
        enemy_2.Start()
        enemy_3.Start()
        gift1.Start()
        Label3.Visible() = False
        vv.Visible() = True
        'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.Background)

    End Sub

    Private Sub vv_Click(sender As Object, e As EventArgs) Handles vv.Click
        Timer1.Stop()
        down_mover.Stop()
        up_mover.Stop()
        enemy_4.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        gift1.Stop()
        Label3.Visible() = True
        vv.Visible() = False
        My.Computer.Audio.Stop()

    End Sub

End Class
