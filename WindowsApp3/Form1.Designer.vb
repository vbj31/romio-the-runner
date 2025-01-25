<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.down_r = New System.Windows.Forms.Timer(Me.components)
        Me.up_r = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_3 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_1 = New System.Windows.Forms.Timer(Me.components)
        Me.End_Text = New System.Windows.Forms.Label()
        Me.score_text = New System.Windows.Forms.Label()
        Me.Replay_button = New System.Windows.Forms.Button()
        Me.speed_text = New System.Windows.Forms.Label()
        Me.Newlevel_label = New System.Windows.Forms.Label()
        Me.Nextlevel_button = New System.Windows.Forms.Button()
        Me.romeo = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox12 = New System.Windows.Forms.PictureBox()
        Me.PictureBox11 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.left_mover = New System.Windows.Forms.Timer(Me.components)
        Me.right_mover = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 10
        '
        'down_r
        '
        Me.down_r.Interval = 10
        '
        'up_r
        '
        Me.up_r.Interval = 10
        '
        'enemy_2
        '
        Me.enemy_2.Enabled = True
        Me.enemy_2.Interval = 10
        '
        'enemy_3
        '
        Me.enemy_3.Enabled = True
        Me.enemy_3.Interval = 10
        '
        'enemy_1
        '
        Me.enemy_1.Enabled = True
        Me.enemy_1.Interval = 10
        '
        'End_Text
        '
        Me.End_Text.AutoSize = True
        Me.End_Text.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.End_Text.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.End_Text.ForeColor = System.Drawing.Color.Maroon
        Me.End_Text.Location = New System.Drawing.Point(291, 54)
        Me.End_Text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.End_Text.Name = "End_Text"
        Me.End_Text.Size = New System.Drawing.Size(213, 41)
        Me.End_Text.TabIndex = 4
        Me.End_Text.Text = "Game Over!"
        Me.End_Text.Visible = False
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.score_text.Location = New System.Drawing.Point(12, 7)
        Me.score_text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(59, 17)
        Me.score_text.TabIndex = 5
        Me.score_text.Text = "Score 0"
        '
        'Replay_button
        '
        Me.Replay_button.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Replay_button.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Replay_button.ForeColor = System.Drawing.Color.Crimson
        Me.Replay_button.Location = New System.Drawing.Point(357, 166)
        Me.Replay_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Replay_button.Name = "Replay_button"
        Me.Replay_button.Size = New System.Drawing.Size(113, 82)
        Me.Replay_button.TabIndex = 6
        Me.Replay_button.Text = "Replay"
        Me.Replay_button.UseVisualStyleBackColor = False
        Me.Replay_button.Visible = False
        '
        'speed_text
        '
        Me.speed_text.AutoSize = True
        Me.speed_text.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed_text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.speed_text.Location = New System.Drawing.Point(91, 7)
        Me.speed_text.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.speed_text.Name = "speed_text"
        Me.speed_text.Size = New System.Drawing.Size(60, 17)
        Me.speed_text.TabIndex = 5
        Me.speed_text.Text = "Speed 0"
        '
        'Newlevel_label
        '
        Me.Newlevel_label.AutoSize = True
        Me.Newlevel_label.Font = New System.Drawing.Font("Modern No. 20", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Newlevel_label.ForeColor = System.Drawing.Color.DarkBlue
        Me.Newlevel_label.Location = New System.Drawing.Point(280, 106)
        Me.Newlevel_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Newlevel_label.Name = "Newlevel_label"
        Me.Newlevel_label.Size = New System.Drawing.Size(250, 50)
        Me.Newlevel_label.TabIndex = 8
        Me.Newlevel_label.Text = "             Congo " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Completed the Level 1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Newlevel_label.Visible = False
        '
        'Nextlevel_button
        '
        Me.Nextlevel_button.BackColor = System.Drawing.Color.Silver
        Me.Nextlevel_button.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextlevel_button.ForeColor = System.Drawing.Color.DarkGreen
        Me.Nextlevel_button.Location = New System.Drawing.Point(357, 192)
        Me.Nextlevel_button.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Nextlevel_button.Name = "Nextlevel_button"
        Me.Nextlevel_button.Size = New System.Drawing.Size(113, 76)
        Me.Nextlevel_button.TabIndex = 9
        Me.Nextlevel_button.Text = "Next Level"
        Me.Nextlevel_button.UseVisualStyleBackColor = False
        Me.Nextlevel_button.Visible = False
        '
        'romeo
        '
        Me.romeo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.romeo.Image = CType(resources.GetObject("romeo.Image"), System.Drawing.Image)
        Me.romeo.Location = New System.Drawing.Point(731, 188)
        Me.romeo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.romeo.Name = "romeo"
        Me.romeo.Size = New System.Drawing.Size(88, 80)
        Me.romeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.romeo.TabIndex = 1
        Me.romeo.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.Image = CType(resources.GetObject("enemy3.Image"), System.Drawing.Image)
        Me.enemy3.Location = New System.Drawing.Point(525, 305)
        Me.enemy3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(57, 42)
        Me.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy3.TabIndex = 3
        Me.enemy3.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(357, 116)
        Me.enemy2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(57, 42)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 3
        Me.enemy2.TabStop = False
        '
        'enemy1
        '
        Me.enemy1.Image = CType(resources.GetObject("enemy1.Image"), System.Drawing.Image)
        Me.enemy1.Location = New System.Drawing.Point(135, 192)
        Me.enemy1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(56, 57)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 2
        Me.enemy1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox6.Location = New System.Drawing.Point(747, 272)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox6.TabIndex = 0
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox5.Location = New System.Drawing.Point(747, 172)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox10.Location = New System.Drawing.Point(157, 272)
        Me.PictureBox10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox10.TabIndex = 0
        Me.PictureBox10.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox4.Location = New System.Drawing.Point(557, 272)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox9.Location = New System.Drawing.Point(157, 172)
        Me.PictureBox9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox9.TabIndex = 0
        Me.PictureBox9.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox3.Location = New System.Drawing.Point(557, 172)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox8.Location = New System.Drawing.Point(-43, 272)
        Me.PictureBox8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox8.TabIndex = 0
        Me.PictureBox8.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox2.Location = New System.Drawing.Point(357, 272)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox7.Location = New System.Drawing.Point(-43, 172)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox7.TabIndex = 0
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Window
        Me.PictureBox1.Location = New System.Drawing.Point(357, 172)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(133, 12)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox12
        '
        Me.PictureBox12.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox12.Image = CType(resources.GetObject("PictureBox12.Image"), System.Drawing.Image)
        Me.PictureBox12.Location = New System.Drawing.Point(411, -1)
        Me.PictureBox12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox12.Name = "PictureBox12"
        Me.PictureBox12.Size = New System.Drawing.Size(1133, 92)
        Me.PictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox12.TabIndex = 7
        Me.PictureBox12.TabStop = False
        '
        'PictureBox11
        '
        Me.PictureBox11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PictureBox11.Image = CType(resources.GetObject("PictureBox11.Image"), System.Drawing.Image)
        Me.PictureBox11.Location = New System.Drawing.Point(-572, -1)
        Me.PictureBox11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox11.Name = "PictureBox11"
        Me.PictureBox11.Size = New System.Drawing.Size(1133, 92)
        Me.PictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox11.TabIndex = 7
        Me.PictureBox11.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(175, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = " life 3"
        '
        'left_mover
        '
        Me.left_mover.Interval = 10
        '
        'right_mover
        '
        Me.right_mover.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(745, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pause  "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(744, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Resume"
        Me.Label3.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(832, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Nextlevel_button)
        Me.Controls.Add(Me.Replay_button)
        Me.Controls.Add(Me.speed_text)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.End_Text)
        Me.Controls.Add(Me.romeo)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Newlevel_label)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox12)
        Me.Controls.Add(Me.PictureBox11)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(850, 408)
        Me.MinimumSize = New System.Drawing.Size(850, 408)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents romeo As PictureBox
    Friend WithEvents down_r As Timer
    Friend WithEvents up_r As Timer
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents enemy_2 As Timer
    Friend WithEvents enemy_3 As Timer
    Friend WithEvents enemy_1 As Timer
    Friend WithEvents End_Text As Label
    Friend WithEvents score_text As Label
    Friend WithEvents Replay_button As Button
    Friend WithEvents speed_text As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents Newlevel_label As Label
    Friend WithEvents Nextlevel_button As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents left_mover As Timer
    Friend WithEvents right_mover As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
