Imports System.Data.SqlClient
Public Class Login
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"

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
        ' Get the user input
        Dim username As String = txtAdmNo.Text
        Dim password As String = txtPassword.Text

        ' Connect to the database
        Dim conn As New SqlConnection(Connection)
        conn.Open()

        ' Check if the user exists in the database
        Dim cmd As New SqlCommand("SELECT COUNT(*) FROM StudentTBL WHERE AdmNo = @AdmNo AND Password = @Password", conn)
        cmd.Parameters.AddWithValue("@AdmNo", username)
        cmd.Parameters.AddWithValue("@Password", password)
        Dim result As Integer = cmd.ExecuteScalar()

        ' Close the database connection
        conn.Close()

        ' Authenticate the user
        If result = 1 Then
            ' The user is authenticated, show the main form
            Dim mainForm As New StudentAccountInfo()
            mainForm.Show()
            MessageBox.Show("Welcome " & username & "!")
            Me.Hide()
        Else
            ' The user is not authenticated, show an error message
            MessageBox.Show("Incorrect Adm Number or Password!!!")
        End If
    End Sub
End Class
