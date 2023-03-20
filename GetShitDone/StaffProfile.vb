Public Class StaffProfile
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New StaffLogin()
        Obj.Show()
        Me.Hide()
    End Sub
End Class