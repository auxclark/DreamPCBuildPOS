Public Class Sign_Up
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        Admin_Dashboard_1stPanel.Show()
    End Sub

    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignInBtn.Click
        Sign_In.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()

    End Sub
End Class