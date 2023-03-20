Public Class Login
    Private Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        If usernametxt.Text = "" Or passwordtxt.Text = "" Then
            MsgBox("Enter Username and Password")
        ElseIf usernametxt.Text = "Admin" Or passwordtxt.Text = "Password" Then
            Dim Obj = New Items
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Incorrect Username or Password")
            usernametxt.Text = ""
            passwordtxt.Text = ""
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub
End Class
