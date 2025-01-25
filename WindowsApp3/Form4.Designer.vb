<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.up_mover = New System.Windows.Forms.Timer(Me.components)
        Me.down_mover = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_2 = New System.Windows.Forms.Timer(Me.components)
        Me.enemy_3 = New System.Windows.Forms.Timer(Me.components)
        Me.score_text = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.speed_text = New System.Windows.Forms.Label()
        Me.replay_button = New System.Windows.Forms.Button()
        Me.end_text = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.princess = New System.Windows.Forms.PictureBox()
        Me.romeo = New System.Windows.Forms.PictureBox()
        Me.grandenemy = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.enemy1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.vv = New System.Windows.Forms.Label()
        CType(Me.princess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grandenemy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5
        '
        'up_mover
        '
        Me.up_mover.Interval = 5
        '
        'down_mover
        '
        Me.down_mover.Interval = 5
        '
        'enemy_1
        '
        Me.enemy_1.Enabled = True
        Me.enemy_1.Interval = 5
        '
        'enemy_2
        '
        Me.enemy_2.Enabled = True
        Me.enemy_2.Interval = 5
        '
        'enemy_3
        '
        Me.enemy_3.Enabled = True
        Me.enemy_3.Interval = 5
        '
        'score_text
        '
        Me.score_text.AutoSize = True
        Me.score_text.BackColor = System.Drawing.Color.White
        Me.score_text.Location = New System.Drawing.Point(97, 25)
        Me.score_text.Name = "score_text"
        Me.score_text.Size = New System.Drawing.Size(55, 17)
        Me.score_text.TabIndex = 6
        Me.score_text.Text = "score 0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Life 3"
        '
        'speed_text
        '
        Me.speed_text.AutoSize = True
        Me.speed_text.BackColor = System.Drawing.Color.White
        Me.speed_text.Location = New System.Drawing.Point(187, 25)
        Me.speed_text.Name = "speed_text"
        Me.speed_text.Size = New System.Drawing.Size(59, 17)
        Me.speed_text.TabIndex = 8
        Me.speed_text.Text = "speed 1"
        '
        'replay_button
        '
        Me.replay_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.replay_button.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.replay_button.Location = New System.Drawing.Point(491, 309)
        Me.replay_button.Name = "replay_button"
        Me.replay_button.Size = New System.Drawing.Size(129, 67)
        Me.replay_button.TabIndex = 9
        Me.replay_button.Text = "Replay!!"
        Me.replay_button.UseVisualStyleBackColor = True
        Me.replay_button.Visible = False
        '
        'end_text
        '
        Me.end_text.AutoSize = True
        Me.end_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.end_text.Location = New System.Drawing.Point(461, 216)
        Me.end_text.Name = "end_text"
        Me.end_text.Size = New System.Drawing.Size(186, 32)
        Me.end_text.TabIndex = 10
        Me.end_text.Text = "Game Over !"
        Me.end_text.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(277, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(619, 43)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Congrats you saved your Princess !"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(502, 325)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 32)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Exit Game"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'princess
        '
        Me.princess.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.princess.Image = CType(resources.GetObject("princess.Image"), System.Drawing.Image)
        Me.princess.Location = New System.Drawing.Point(257, 294)
        Me.princess.Name = "princess"
        Me.princess.Size = New System.Drawing.Size(89, 96)
        Me.princess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.princess.TabIndex = 12
        Me.princess.TabStop = False
        Me.princess.Visible = False
        '
        'romeo
        '
        Me.romeo.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.romeo.Image = CType(resources.GetObject("romeo.Image"), System.Drawing.Image)
        Me.romeo.Location = New System.Drawing.Point(986, 294)
        Me.romeo.Name = "romeo"
        Me.romeo.Size = New System.Drawing.Size(95, 96)
        Me.romeo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.romeo.TabIndex = 2
        Me.romeo.TabStop = False
        '
        'grandenemy
        '
        Me.grandenemy.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.grandenemy.Image = CType(resources.GetObject("grandenemy.Image"), System.Drawing.Image)
        Me.grandenemy.Location = New System.Drawing.Point(1, 181)
        Me.grandenemy.Name = "grandenemy"
        Me.grandenemy.Size = New System.Drawing.Size(183, 333)
        Me.grandenemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.grandenemy.TabIndex = 11
        Me.grandenemy.TabStop = False
        Me.grandenemy.Visible = False
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.enemy2.Image = CType(resources.GetObject("enemy2.Image"), System.Drawing.Image)
        Me.enemy2.Location = New System.Drawing.Point(62, 309)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(86, 81)
        Me.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy2.TabIndex = 5
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.enemy3.Image = CType(resources.GetObject("enemy3.Image"), System.Drawing.Image)
        Me.enemy3.Location = New System.Drawing.Point(550, 433)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(97, 81)
        Me.enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy3.TabIndex = 4
        Me.enemy3.TabStop = False
        '
        'enemy1
        '
        Me.enemy1.BackColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.enemy1.Image = CType(resources.GetObject("enemy1.Image"), System.Drawing.Image)
        Me.enemy1.Location = New System.Drawing.Point(408, 181)
        Me.enemy1.Name = "enemy1"
        Me.enemy1.Size = New System.Drawing.Size(97, 81)
        Me.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy1.TabIndex = 3
        Me.enemy1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-577, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1143, 530)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(565, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1144, 530)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(948, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Resume"
        Me.Label3.Visible = False
        '
        'vv
        '
        Me.vv.AutoSize = True
        Me.vv.BackColor = System.Drawing.Color.White
        Me.vv.Location = New System.Drawing.Point(948, 25)
        Me.vv.Name = "vv"
        Me.vv.Size = New System.Drawing.Size(48, 17)
        Me.vv.TabIndex = 8
        Me.vv.Text = "Pause"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1104, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.princess)
        Me.Controls.Add(Me.end_text)
        Me.Controls.Add(Me.vv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.speed_text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.score_text)
        Me.Controls.Add(Me.romeo)
        Me.Controls.Add(Me.grandenemy)
        Me.Controls.Add(Me.enemy2)
        Me.Controls.Add(Me.enemy3)
        Me.Controls.Add(Me.enemy1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.replay_button)
        Me.MaximumSize = New System.Drawing.Size(1122, 563)
        Me.MinimumSize = New System.Drawing.Size(1122, 563)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.princess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.romeo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grandenemy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents romeo As PictureBox
    Friend WithEvents enemy1 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents up_mover As Timer
    Friend WithEvents down_mover As Timer
    Friend WithEvents enemy_1 As Timer
    Friend WithEvents enemy_2 As Timer
    Friend WithEvents enemy_3 As Timer
    Friend WithEvents score_text As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents speed_text As Label
    Friend WithEvents replay_button As Button
    Friend WithEvents end_text As Label
    Friend WithEvents grandenemy As PictureBox
    Friend WithEvents princess As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents vv As Label
End Class
