<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form0
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form0))
        Me.Play_button = New System.Windows.Forms.Button()
        Me.Instructions_button = New System.Windows.Forms.Button()
        Me.About_button = New System.Windows.Forms.Button()
        Me.Instructions_label = New System.Windows.Forms.Label()
        Me.IBack_button = New System.Windows.Forms.Button()
        Me.About_label = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Play_button
        '
        Me.Play_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Play_button.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Play_button.ForeColor = System.Drawing.Color.Black
        Me.Play_button.Location = New System.Drawing.Point(31, 46)
        Me.Play_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Play_button.Name = "Play_button"
        Me.Play_button.Size = New System.Drawing.Size(316, 79)
        Me.Play_button.TabIndex = 0
        Me.Play_button.Text = "Play"
        Me.Play_button.UseVisualStyleBackColor = False
        '
        'Instructions_button
        '
        Me.Instructions_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Instructions_button.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructions_button.Location = New System.Drawing.Point(31, 149)
        Me.Instructions_button.Margin = New System.Windows.Forms.Padding(4)
        Me.Instructions_button.Name = "Instructions_button"
        Me.Instructions_button.Size = New System.Drawing.Size(316, 79)
        Me.Instructions_button.TabIndex = 0
        Me.Instructions_button.Text = "Instructions"
        Me.Instructions_button.UseVisualStyleBackColor = False
        '
        'About_button
        '
        Me.About_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.About_button.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About_button.Location = New System.Drawing.Point(31, 252)
        Me.About_button.Margin = New System.Windows.Forms.Padding(4)
        Me.About_button.Name = "About_button"
        Me.About_button.Size = New System.Drawing.Size(316, 79)
        Me.About_button.TabIndex = 0
        Me.About_button.Text = "About"
        Me.About_button.UseVisualStyleBackColor = False
        '
        'Instructions_label
        '
        Me.Instructions_label.AutoSize = True
        Me.Instructions_label.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructions_label.Location = New System.Drawing.Point(400, 50)
        Me.Instructions_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Instructions_label.Name = "Instructions_label"
        Me.Instructions_label.Size = New System.Drawing.Size(357, 220)
        Me.Instructions_label.TabIndex = 1
        Me.Instructions_label.Text = resources.GetString("Instructions_label.Text")
        Me.Instructions_label.Visible = False
        '
        'IBack_button
        '
        Me.IBack_button.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.IBack_button.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IBack_button.Location = New System.Drawing.Point(543, 279)
        Me.IBack_button.Margin = New System.Windows.Forms.Padding(4)
        Me.IBack_button.Name = "IBack_button"
        Me.IBack_button.Size = New System.Drawing.Size(120, 52)
        Me.IBack_button.TabIndex = 2
        Me.IBack_button.Text = "Back"
        Me.IBack_button.UseVisualStyleBackColor = False
        Me.IBack_button.Visible = False
        '
        'About_label
        '
        Me.About_label.AutoSize = True
        Me.About_label.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.About_label.Location = New System.Drawing.Point(406, 45)
        Me.About_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.About_label.Name = "About_label"
        Me.About_label.Size = New System.Drawing.Size(351, 225)
        Me.About_label.TabIndex = 3
        Me.About_label.Text = "Copyright" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " (KKIJ private ltd.)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kendre Saurav      Katti Swapnil" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Ingale Uda" &
    "y          Jagtap Vaibhav" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.About_label.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp3.My.Resources.Resources.Romeo
        Me.PictureBox1.Location = New System.Drawing.Point(425, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(332, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Form0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 383)
        Me.Controls.Add(Me.Instructions_label)
        Me.Controls.Add(Me.About_label)
        Me.Controls.Add(Me.IBack_button)
        Me.Controls.Add(Me.About_button)
        Me.Controls.Add(Me.Instructions_button)
        Me.Controls.Add(Me.Play_button)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form0"
        Me.Text = "Form0"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Play_button As Button
    Friend WithEvents Instructions_button As Button
    Friend WithEvents About_button As Button
    Friend WithEvents Instructions_label As Label
    Friend WithEvents IBack_button As Button
    Friend WithEvents About_label As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
