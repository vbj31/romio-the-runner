Public Class Form4
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
        If score = 8 Then
            newlevel()
        End If
        If score = 15 Then
            meet()
        End If
        speed_text.Text = "Speed " & speed
        For Each PictureBox In Me.Controls
            If romeo.Bounds.IntersectsWith(enemy1.Bounds) Then
                '  My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                ' MessageBox.Show("1 life down 2 left", "romeo-The runne", MessageBoxButtons.OK, MessageBoxIcon.Information)






                life = life + 1
                enemy1.Left += 200
                Label1.Text = "life " & 3 - life
                gameOver()

            End If
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
                My.Computer.Audio.Play(My.Resources.change, AudioPlayMode.WaitToComplete)
                My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.BackgroundLoop)
                'My.Computer.Audio.Play("G:\WindowsApp3V\change.wav")
                life = life + 1

                Label1.Text = "life " & 3 - life
                enemy3.Left += 200
                gameOver()
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




            'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\death.wav")
            My.Computer.Audio.Play(My.Resources.death, AudioPlayMode.Background)


            replay_button.Visible = True
            end_text.Visible = True
            Timer1.Stop()
            down_mover.Stop()
            up_mover.Stop()
            enemy_1.Stop()
            enemy_2.Stop()
            enemy_3.Stop()



            up = 0
            down = 0
            score = 0
            life = 0


        End If





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

    Private Sub enemy_1_Tick(sender As Object, e As EventArgs) Handles enemy_1.Tick
        enemy1.Left += speed * 3 / 2
        If enemy1.Left >= Me.Width Then
            score += 1
            score_text.Text = "Score " & score

            enemy1.Left = -(CInt(Math.Ceiling(Rnd() * 200)) + enemy1.Width)

        End If



    End Sub

    Private Sub enemy_2_Tick(sender As Object, e As EventArgs) Handles enemy_2.Tick
        enemy2.Left += speed * 2.8
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles replay_button.Click
        score = 0
        life = 0

        Me.Controls.Clear()
        InitializeComponent()

        Form4_Load(e, e)

    End Sub
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        Timer1.Stop()
        down_mover.Stop()
        up_mover.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()


        dialog = MessageBox.Show("do you want to exit", "exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
            Timer1.Start()
            down_mover.Start()
            up_mover.Start()
            enemy_1.Start()
            enemy_2.Start()
            enemy_3.Start()

        Else
            Application.ExitThread()
        End If
    End Sub
    Private Sub newlevel()
        ' enemy1.Visible = False
        'enemy2.Visible = False
        'enemy3.Visible = False
        grandenemy.Visible = True
        enemy3.Image = Image.FromFile("F:\WindowsApp3V\WindowsApp3\assets\bullet1.png")
        enemy2.Image = Image.FromFile("F:\WindowsApp3V\WindowsApp3\assets\bullet1.png")
        enemy1.Image = Image.FromFile("F:\WindowsApp3V\WindowsApp3\assets\bullet1.png")



    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub bullet1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub meet()
        Timer1.Stop()

        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        Timer2.Start()
        princess.Visible = True
        enemy1.Visible = False
        enemy2.Visible = False
        enemy3.Visible = False
        grandenemy.Visible = False








    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        princess.Left += speed * 2
        If romeo.Bounds.IntersectsWith(princess.Bounds) Then
            Timer2.Stop()
            Button1.Visible = True
            Label2.Visible = True

        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Application.ExitThread()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles vv.Click
        Timer1.Stop()
        down_mover.Stop()
        up_mover.Stop()
        enemy_1.Stop()
        enemy_2.Stop()
        enemy_3.Stop()
        ' gift1.Stop()
        Label3.Visible() = True
        vv.Visible() = False
        My.Computer.Audio.Stop()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Timer1.Start()
        down_mover.Start()
        up_mover.Start()
        enemy_1.Start()
        enemy_2.Start()
        enemy_3.Start()
        ' gift1.Start()
        Label3.Visible() = False
        vv.Visible() = True
        'My.Computer.Audio.Play("G:\WindowsApp3V\WindowsApp3\Resources\back.wav")
        My.Computer.Audio.Play(My.Resources.gameMusic, AudioPlayMode.Background)

    End Sub

End Class



