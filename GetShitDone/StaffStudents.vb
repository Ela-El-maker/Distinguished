Imports System.Data.SqlClient
Public Class StaffStudents
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub Label11_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub LoadData()
        Dim query As String = "SELECT * from StudentTBL"
        Dim Conn As New SqlConnection(Connection) 'create a new sqlconnection object using the connection
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        studentsDGV.DataSource = table
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New StaffLogin()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New StaffProfile()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New StaffDashboard()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj As New StaffStudents()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj As New StaffMeals()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub StaffStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtAdm.Text) OrElse String.IsNullOrEmpty(txtName.Text) _
        OrElse String.IsNullOrEmpty(txtContact.Text) OrElse String.IsNullOrEmpty(txtAccount.Text) _
        OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        'Get the values from the textboxes
        Dim studentNo As String = txtAdm.Text
        Dim studentName As String = txtName.Text
        Dim studentContact As String = txtContact.Text
        Dim studentAccount As String = txtAccount.Text
        Dim studentPassword As String = txtPassword.Text


        'Create a SQL query to insert the values into the database
        Dim query As String = "INSERT INTO StudentTBL (AdmNo,Name, Contact,Account,Password) VALUES ('" & studentNo & "', '" & studentName & "', '" & studentContact & "', '" & studentAccount & "', '" & studentPassword & "')"

        Dim Conn As New SqlConnection(Connection) ' Create a new SqlConnection object using the connection string
        Dim cmd As New SqlCommand(query, Conn)  ' Create a new SqlCommand object to execute the SQL query

        ' Open the database connection
        Conn.Open()

        ' Execute the SQL query to insert the new record
        cmd.ExecuteNonQuery()

        ' Close the database connection
        Conn.Close()

        ' Reload the data in the DataGridView control to show the new record
        LoadData()
        MessageBox.Show("Student added successfully.")
        ' Clear the text boxes
        txtAdm.Clear()
        txtName.Clear()
        txtContact.Clear()
        txtAccount.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtAdm.Text) OrElse String.IsNullOrEmpty(txtName.Text) _
        OrElse String.IsNullOrEmpty(txtContact.Text) OrElse String.IsNullOrEmpty(txtAccount.Text) _
        OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        'Get the values from the textboxes
        Dim studentNo As String = txtAdm.Text
        Dim studentName As String = txtName.Text
        Dim studentContact As String = txtContact.Text
        Dim studentAccount As String = txtAccount.Text
        Dim studentPassword As String = txtPassword.Text

        'Get the ID of the selected row
        Dim selectedID As String = studentsDGV.SelectedRows(0).Cells("Id").Value.ToString()
        'Create a SQL query to insert the values into the database
        Dim query As String = "UPDATE StudentTBL set AdmNo = '" & studentNo & "', Name = '" & studentName & "', Contact ='" & studentContact & "', Account = '" & studentAccount & "',Password= '" & studentPassword & "' WHERE Id = '" & selectedID & "'"

        Dim Conn As New SqlConnection(Connection)
        Dim cmd As New SqlCommand(query, Conn)
        ' Open the database connection
        Conn.Open()

        ' Execute the SQL query to update the record
        cmd.ExecuteNonQuery()

        ' Close the database connection
        Conn.Close()

        ' Reload the data in the DataGridView control to show the updated record set
        LoadData()
        MessageBox.Show("Student updated successfully.")
        ' Clear the text boxes
        txtAdm.Clear()
        txtName.Clear()
        txtContact.Clear()
        txtAccount.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If studentsDGV.SelectedRows.Count > 0 Then
            'Get the ID of the selected row
            Dim selectedID As String = studentsDGV.SelectedRows(0).Cells("Id").Value.ToString()

            'Create a SQL query to delete the row from the database
            Dim query As String = "DELETE FROM StudentTBL WHERE Id = '" & selectedID & "'"

            'Open a connection to the database
            Dim conn As New SqlConnection(Connection)
            conn.Open()

            'Execute the SQL query
            Dim cmd As New SqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            'Close the connection to the database
            conn.Close()

            'Refresh the DataGridView

            ' Reload the data in the DataGridView control to show the updated record set
            LoadData()
            MessageBox.Show("Student deleted successfully.")
            ' Clear the text boxes
            txtAdm.Clear()
            txtName.Clear()
            txtContact.Clear()
            txtAccount.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub studentsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles studentsDGV.SelectionChanged
        If studentsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = studentsDGV.SelectedRows(0)

            'Display the values in the textboxes
            txtAdm.Text = selectedRow.Cells("AdmNo").Value.ToString()
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            txtContact.Text = selectedRow.Cells("Contact").Value.ToString()
            txtAccount.Text = selectedRow.Cells("Account").Value.ToString()
        End If
    End Sub
End Class