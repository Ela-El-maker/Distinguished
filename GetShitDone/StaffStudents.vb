Public Class StaffStudents
    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New StaffLogin()
        Obj.Show()
        Me.Hide()
    End Sub
End Class