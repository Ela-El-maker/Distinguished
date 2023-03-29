Public Class AdminLogin
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj As New StaffLogin()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Obj As New Login()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Obj As New AdminLogin()
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtAdmin.Text
        Dim password As String = txtPassword.Text
        If username = "admin" And password = "password" Then
            Dim mainForm As New AdmStaffs()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Username or Password!!!")
        End If
    End Sub
End Class