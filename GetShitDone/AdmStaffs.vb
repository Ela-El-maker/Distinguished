Imports System.Data.SqlClient
Public Class AdmStaffs
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub LoadData()
        Dim query As String = "SELECT * from StaffTBL"
        Dim Conn As New SqlConnection(Connection) 'create a new sqlconnection object using the connection
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        staffsDGV.DataSource = table
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim Obj As New AdminLogin()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj As New AdmMeals()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New AdmStaffs()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New AdminLogin()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj As New AdmStudents()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtNumber.Text) OrElse String.IsNullOrEmpty(txtName.Text) _
        OrElse String.IsNullOrEmpty(txtContact.Text) OrElse String.IsNullOrEmpty(txtPosition.Text) _
        OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        'Get the values from the textboxes
        Dim staffNo As String = txtNumber.Text
        Dim staffName As String = txtName.Text
        Dim staffContact As String = txtContact.Text
        Dim staffPosition As String = txtPosition.Text
        Dim staffPassword As String = txtPassword.Text


        'Create a SQL query to insert the values into the database
        Dim query As String = "INSERT INTO StaffTBL (Number,Name, Contact,Position,Password) VALUES ('" & staffNo & "', '" & staffName & "', '" & staffContact & "', '" & staffPosition & "', '" & staffPassword & "')"

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
        MessageBox.Show("Staff added successfully.")
        ' Clear the text boxes
        txtNumber.Clear()
        txtName.Clear()
        txtContact.Clear()
        txtPosition.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub AdmStaffs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtNumber.Text) OrElse String.IsNullOrEmpty(txtName.Text) _
        OrElse String.IsNullOrEmpty(txtContact.Text) OrElse String.IsNullOrEmpty(txtPosition.Text) _
        OrElse String.IsNullOrEmpty(txtPassword.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        'Get the values from the textboxes
        Dim staffNo As String = txtNumber.Text
        Dim staffName As String = txtName.Text
        Dim staffContact As String = txtContact.Text
        Dim staffPosition As String = txtPosition.Text
        Dim staffPassword As String = txtPassword.Text
        'Get the ID of the selected row
        Dim selectedID As String = staffsDGV.SelectedRows(0).Cells("Id").Value.ToString()
        'Create a SQL query to insert the values into the database
        Dim query As String = "UPDATE StaffTBL set Number = '" & staffNo & "', Name = '" & staffName & "', Contact ='" & staffContact & "', Position = '" & staffPosition & "',Password= '" & staffPassword & "' WHERE Id = '" & selectedID & "'"
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
        MessageBox.Show("Staff Updated successfully.")
        ' Clear the text boxes
        txtNumber.Clear()
        txtName.Clear()
        txtContact.Clear()
        txtPosition.Clear()
        txtPassword.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Check if a row is selected in the DataGridView control
        If staffsDGV.SelectedRows.Count > 0 Then
            'Get the ID of the selected row
            Dim selectedID As String = staffsDGV.SelectedRows(0).Cells("Id").Value.ToString()

            'Create a SQL query to delete the row from the database
            Dim query As String = "DELETE FROM StaffTBL WHERE Id = '" & selectedID & "'"

            'Open a connection to the database
            Dim conn As New SqlConnection(Connection)
            Dim cmd As New SqlCommand(query, conn)
            ' Open the database connection
            conn.Open()

            ' Execute the SQL query to delete the record
            cmd.ExecuteNonQuery()

            ' Close the database connection
            Conn.Close()

            ' Reload the data in the DataGridView control to show the updated record set
            LoadData()

            MessageBox.Show("Staff deleted successfully.")
            ' Clear the text boxes
            txtNumber.Clear()
            txtName.Clear()
            txtContact.Clear()
            txtPosition.Clear()
            txtPassword.Clear()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub staffsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles staffsDGV.SelectionChanged
        If staffsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = staffsDGV.SelectedRows(0)

            'Display the values in the textboxes
            txtNumber.Text = selectedRow.Cells("Number").Value.ToString()
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            txtContact.Text = selectedRow.Cells("Contact").Value.ToString()
            txtPosition.Text = selectedRow.Cells("Position").Value.ToString()
        End If
    End Sub
End Class