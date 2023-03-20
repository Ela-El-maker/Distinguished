Public Class Login
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

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtAdmNo.Text
        Dim password As String = txtPassword.Text
        If username = "student" And password = "password" Then
            Dim mainForm As New StudentAccountInfo()
            mainForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Incorrect Adm Number or Password!!!")
        End If
    End Sub
End Class
