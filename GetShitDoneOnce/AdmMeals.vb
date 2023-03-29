Imports System.Data.SqlClient
Public Class AdmMeals
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub LoadData()
        Dim query As String = "SELECT * from MealTBL"
        Dim Conn As New SqlConnection(Connection)
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        mealsDGV.DataSource = table
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj As New AdminLogin()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New AdmStaffs()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj As New AdmStudents()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj As New AdmMeals()
        Obj.Show()
        Me.Hide()
    End Sub



    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtMeal.Text) OrElse String.IsNullOrEmpty(cbMealTime.Text) _
        OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        'Get the values from the textboxes
        Dim mealDate As String = dateTimePicker.Value
        Dim mealMeal As String = txtMeal.Text
        Dim mealPrice As Decimal = Decimal.Parse(txtPrice.Text)
        Dim mealMealTime As String = cbMealTime.Text



        'Get the ID of the selected row
        Dim selectedID As String = mealsDGV.SelectedRows(0).Cells("Id").Value.ToString()
        'Update a SQL query to insert the values into the database
        Dim query As String = "UPDATE MealTBL set  Date = '" & mealDate & "', MealTime ='" & mealMealTime & "', Meal = '" & mealMeal & "',Price= '" & mealPrice & "' WHERE Id = '" & selectedID & "'"

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
        MessageBox.Show("Meal Updated Successfully.")
        ' Clear the text boxes
        txtPrice.Clear()
        txtMeal.Clear()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtMeal.Text) OrElse String.IsNullOrEmpty(cbMealTime.Text) _
        OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        'Get the values from the textboxes
        'Get the values from the textboxes
        Dim mealDate As DateTime = dateTimePicker.Value
        Dim mealMeal As String = txtMeal.Text
        Dim mealPrice As Decimal = Decimal.Parse(txtPrice.Text)
        Dim mealMealTime As String = cbMealTime.Text

        'Create a SQL query to insert the values into the database
        Dim query As String = "INSERT INTO MealTBL (Date, MealTime, Meal, Price) VALUES (@Date, @MealTime, @Meal, @Price)"

        Dim conn As New SqlConnection(Connection)
        Dim cmd As New SqlCommand(query, conn)

        'Add parameters with correct data types
        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = mealDate
        cmd.Parameters.Add("@MealTime", SqlDbType.NVarChar).Value = mealMealTime
        cmd.Parameters.Add("@Meal", SqlDbType.NVarChar).Value = mealMeal
        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = mealPrice

        ' Open the database connection
        conn.Open()

        ' Execute the SQL query to insert the new record
        cmd.ExecuteNonQuery()

        ' Close the database connection
        Conn.Close()

        ' Reload the data in the DataGridView control to show the new record
        LoadData()
        MessageBox.Show("Meal added successfully.")
        ' Clear the text boxes
        txtPrice.Clear()
        txtMeal.Clear()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If mealsDGV.SelectedRows.Count > 0 Then
            'Get the ID of the selected row
            Dim selectedID As String = mealsDGV.SelectedRows(0).Cells("Id").Value.ToString()

            'Create a SQL query to delete the row from the database
            Dim query As String = "DELETE FROM MealTBL WHERE Id = '" & selectedID & "'"

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
            MessageBox.Show("Meal deleted successfully.")
            ' Clear the text boxes
            txtMeal.Clear()
            txtPrice.Clear()

        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub AdmMeals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub mealsDGV_SelectionChanged(sender As Object, e As EventArgs) Handles mealsDGV.SelectionChanged
        If mealsDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = mealsDGV.SelectedRows(0)

            'Display the values in the textboxes

            txtMeal.Text = selectedRow.Cells("Meal").Value.ToString()
            cbMealTime.Text = selectedRow.Cells("MealTime").Value.ToString()
            txtPrice.Text = selectedRow.Cells("Price").Value.ToString()
            dateTimePicker.Value = CDate(selectedRow.Cells("Date").Value)
        End If
    End Sub
End Class