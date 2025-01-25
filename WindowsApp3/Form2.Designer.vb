<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.up_mover = New System.Windows.Forms.Timer(Me.components)
        Me.down_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_3 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_4 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.speed_text = New System.Windows.Forms.Label()
        Me.end_text = New System.Windows.Forms.Label()
        Me.replay_button = New System.Windows.Forms.Button()
        Me.score_text = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gift = New System.Windows.Forms.PictureBox()
        Me.enemy4 = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.romeo = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gift1 = New System.Windows.Forms.Timer(Me.components)
        Me.vv = New System.Windows.Forms.Label()
        Me.re = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.gift, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10
        '
        'up_mover
        '
        Me.up_mover.Interval = 10
        '
        'down_mover
        '
        Me.down_mover.Interval = 10
        '
        'enemy_1
        '
        Me.enemy_1.Enabled = True
        Me.enemy_1.Interval = 10
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
        'enemy_4
        '
        Me.enemy_4.Enabled = True
        Me.enemy_4.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Life 3"
        '
        'speed_text
        '
        Me.speed_text.AutoSize = True
        Me.speed_text.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.speed_text.Location = New System.Drawing.Point(267, 26)
        Me.speed_text.Name = "speed_text"
        Me.speed_text.Size = New System.Drawing.Size(61, 20)
        Me.speed_text.TabIndex = 6
        Me.speed_text.Text = "Speed 0"
        '
        'end_text
        '
        Me.end_text.AutoSize = True
        Me.end_text.Font = New System.Drawing.Font("Modern No. 20", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_text.Location = New System.Drawing.Point(501, 197)
        Me.end_text.Name = "end_text"
        Me.end_text.Size = New System.Drawing.Size(152, 30)
        Me.end_text.TabIndex = 7
        Me.end_text.Text = "Game Over!"
        Me.end_text.Visible = False
        '
        'replay_button
        '
        Me.replay_button.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replay_button.Location = New System.Drawing.Point(507, 270)
        Me.replay_button.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.replay_button.Name = "replay_button"
        Me.replay_button.Size = New System.Drawing.Size(133, 60)
        Me.replay_button.TabIndex = 8
        Me.replay_button.Text = "Replay"
        Me.replay_button.UseVisualStyleBackColor = True
        Me.replay_button.Visible = False
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score_text.Location = New System.Drawing.Point(53, 26)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(60, 20)
        Me.score_text.TabIndex = 10
        Me.score_text.Text = "Score 0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(294, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(545, 45)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Congrats Completed Level 2!!"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkRed
        Me.Button1.Location = New System.Drawing.Point(507, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 66)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = " Next" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Level"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'gift
        '
        Me.gift.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.gift.Image = Global.WindowsApp3.My.Resources.Resources.ezgif_com_crop__2_
        Me.gift.Location = New System.Drawing.Point(3, 207)
        Me.gift.Name = "gift"
        Me.gift.Size = New System.Drawing.Size(67, 62)
        Me.gift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gift.TabIndex = 13
        Me.gift.TabStop = False
        '
        'enemy4
        '
        Me.enemy4.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.enemy4.Image = CType(resources.GetObject("enemy4.Image"), System.Drawing.Image)
        Me.enemy4.Location = New System.Drawing.Point(133, 223)
        Me.enemy4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enemy4.Name = "enemy4"
        Me.enemy4.Size = New System.Drawing.Size(91, 70)
        Me.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy4.TabIndex = 4
        Me.enemy4.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(441, 311)
        Me.enemy2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(97, 81)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 3
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.enemy3.Image = CType(resources.GetObject("enemy3.Image"), System.Drawing.Image)
        Me.enemy3.Location = New System.Drawing.Point(246, 424)
        Me.enemy3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(93, 81)
        Me.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy3.TabIndex = 3
        Me.enemy3.TabStop = False
        '
        'romeo
        '
        Me.romeo.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.romeo.Image = Global.WindowsApp3.My.Resources.Resources.Romeo
        Me.romeo.Location = New System.Drawing.Point(979, 311)
        Me.romeo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.romeo.Name = "romeo"
        Me.romeo.Size = New System.Drawing.Size(86, 81)
        Me.romeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.romeo.TabIndex = 2
        Me.romeo.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(845, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(564, 540)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(282, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(564, 540)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-283, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(564, 540)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'gift1
        '
        Me.gift1.Enabled = True
        Me.gift1.Interval = 10
        '
        'vv
        '
        Me.vv.AutoSize = True
        Me.vv.Location = New System.Drawing.Point(1017, 29)
        Me.vv.Name = "vv"
        Me.vv.Size = New System.Drawing.Size(48, 17)
        Me.vv.TabIndex = 14
        Me.vv.Text = "Pause"
        '
        're
        '
        Me.re.AutoSize = True
        Me.re.Location = New System.Drawing.Point(1016, 26)
        Me.re.Name = "re"
        Me.re.Size = New System.Drawing.Size(60, 17)
        Me.re.TabIndex = 15
        Me.re.Text = "Resume"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1016, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Resume"
        Me.Label3.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 516)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.vv)
        Me.Controls.Add(Me.gift)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.replay_button)
        Me.Controls.Add(Me.end_text)
        Me.Controls.Add(Me.speed_text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.enemy4)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.romeo)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.re)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(1122, 563)
        Me.MinimumSize = New System.Drawing.Size(1122, 563)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.gift, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents romeo As PictureBox
    Friend WithEvents up_mover As Timer
    Friend WithEvents down_mover As Timer
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents enemy4 As PictureBox
    Friend WithEvents enemy_1 As Timer
    Friend WithEvents enemy_2 As Timer
    Friend WithEvents enemy_3 As Timer
    Friend WithEvents enemy_4 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents speed_text As Label
    Friend WithEvents end_text As Label
    Friend WithEvents replay_button As Button
    Friend WithEvents score_text As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents gift As PictureBox
    Friend WithEvents gift1 As Timer
    Friend WithEvents vv As Label
    Friend WithEvents re As Label
    Friend WithEvents Label3 As Label
End Class
