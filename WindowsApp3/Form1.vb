Public Class Form1
    Dim speed As Integer
    Dim road(11) As PictureBox
    Dim life As Integer = 0

    Dim score As Integer = 0
    Dim up As Integer = 0
    Dim down As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.Move
        speed = 2


        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
        road(8) = PictureBox9
        road(9) = PictureBox10
        road(10) = PictureBox11
        road(11) = PictureBox12
        ' My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)




    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        For x As Integer = 0 To 11

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
        If score = 15 Then
            Newlevel()
        End If

        speed_text.Text = "Speed " & speed
        For Each PictureBox In Me.Controls
            If romeo.Bounds.IntersectsWith(enemy1.Bounds) Then
                ' My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)

                ' MessageBox.Show("1 life down 2 left", "romeo-The runne", MessageBoxButtons.OK, MessageBoxIcon.Information)






                life = life + 1
                enemy1.Left += 200
                Label1.Text = " life " & 3 - life
                gameOver()

            End If
            If romeo.Bounds.IntersectsWith(enemy2.Bounds) Then
                '  My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)

                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                life = life + 1
                Label1.Text = " life " & 3 - life



                enemy2.Left += 200
                '   MessageBox.Show("1 life down 1 left", "romeo-The runne", MessageBoxButtons.OK, MessageBoxIcon.Information)




                gameOver()

            End If
            If romeo.Bounds.IntersectsWith(enemy3.Bounds) Then
                '  My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)

                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                life = life + 1

                Label1.Text = " life " & 3 - life
                enemy3.Left += 200
                gameOver()

            End If

        Next


    End Sub
    Private Sub gameOver()
        If life = 1 Then
            'romeo.Image = Image.FromFile("G:\WindowsApp3V\WindowsApp3\assets\mario2_move2.bmp")
            '//  romeo.Image = My.Resources.mario2_move21
            '// romeo.Image = My.Resources.Romeo

        End If
        If life = 2 Then
            romeo.Image = My.Resources.Romeo

        End If
        If life = 3 Then
            My.Computer.Audio.Stop()


            'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\death.wav")
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background)



            Replay_button.Visible = True
            End_Text.Visible = True
            Timer.Stop()
            down_r.Stop()
            up_r.Stop()
            enemy_1.Stop()
            enemy_2.Stop()
            enemy_3.Stop()
            up = 0
            down = 0
            score = 0
            life = 0


        End If




    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub down_r_Tick(sender As Object, e As EventArgs) Handles down_r.Tick
        If up < 80 Then
            romeo.Top += 5
            up += 5
            down -= 5
        End If


    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Up Then
            up_r.Start()
        End If
        If e.KeyCode = Keys.Down Then
            down_r.Start()

        End If

    End Sub

    Private Sub romeo_Click(sender As Object, e As EventArgs) Handles romeo.Click

    End Sub

    Private Sub up_r_Tick(sender As Object, e As EventArgs) Handles up_r.Tick
        If down < 100 Then
            romeo.Top -= 5
            up -= 5
            down += 5
        End If

    End Sub


    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        up_r.Stop()
        down_r.Stop()
    End Sub

    Private Sub enemy_1_Tick(sender As Object, e As EventArgs) Handles enemy_1.Tick
        enemy1.Left += speed * 3 / 2
        If enemy1.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score

            enemy1.Left = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy1.Width)

        End If
    End Sub

    Private Sub enemy_2_Tick(sender As Object, e As EventArgs) Handles enemy_2.Tick
        enemy2.Left += speed * 2.5
        If enemy2.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score
            enemy2.Left = -(CInt(Math.Ceiling(Rnd() * 150)) + enemy2.Width)


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





    Private Sub Replay_button_Click(sender As Object, e As EventArgs) Handles Replay_button.Click

        score = 0
        life = 0

        Me.Controls.Clear()
        InitializeComponent()

        Form1_Load(e, e)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub Newlevel()

        My.Computer.Audio.Stop()
        'My.Computer.Audio.Play("G:\WindowsApp3V\firework.wav")
        My.Computer.Audio.Play(My.Resources.firework, AudioPlayMode.Background)


        Nextlevel_button.Visible = True
        Newlevel_label.Visible = True
        Timer.Stop()
        down_r.Stop()
        up_r.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        up = 0
        down = 0
        score = 0

    End Sub

    Private Sub Nextlevel_button_Click(sender As Object, e As EventArgs) Handles Nextlevel_button.Click
        Me.Visible = False
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        My.Computer.Audio.Stop()





        Timer.Stop()
        down_r.Stop()
        up_r.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()


        dialog = MessageBox.Show("do you want to exit", "exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
            If life = 3 Then
                Timer.Stop()
                down_r.Stop()
                up_r.Stop()
                enemy_1.Stop()
                enemy_2.Stop()
                enemy_3.Stop()

            End If


            If life < 3 Then
                '  My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.Background)
                Timer.Start()
                down_r.Start()
                up_r.Start()
                enemy_1.Start()
                enemy_2.Start()
                enemy_3.Start()

                gameOver()
            End If


        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub p_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Timer.Stop()
        down_r.Stop()
        up_r.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        Label3.Visible() = True
        Label2.Visible() = False
        My.Computer.Audio.Stop()



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Timer.Start()
        down_r.Start()
        up_r.Start()
        enemy_1.Start()
        enemy_2.Start()
        enemy_3.Start()
        Label3.Visible() = False
        Label2.Visible() = True
        'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.Background)

    End Sub
End Class












