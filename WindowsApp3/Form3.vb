Public Class Form0
    Private Sub Form0_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Play_button_Click(sender As Object, e As EventArgs) Handles Play_button.Click
        Me.Visible = False
        Form1.Show()
    End Sub

    Private Sub Instructions_button_Click(sender As Object, e As EventArgs) Handles Instructions_button.Click
        Instructions_label.Visible = True
        IBack_button.Visible = True
    End Sub

    Private Sub IBack_button_Click(sender As Object, e As EventArgs) Handles IBack_button.Click
        Instructions_label.Visible = False
        About_label.Visible = False
        IBack_button.Visible = False
    End Sub

    Private Sub About_button_Click(sender As Object, e As EventArgs) Handles About_button.Click
        About_label.Visible = True
        IBack_button.Visible = True

    End Sub
End Class