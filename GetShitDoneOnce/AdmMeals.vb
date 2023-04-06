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
    ' Load data into cbStudent ComboBox


    ' Get the current balance of a student
    Private Function GetStudentBalance(studentId As Integer) As Decimal
        Dim query As String = "SELECT Account FROM StudentTBL WHERE Id = @Id"

        Dim conn As New SqlConnection(Connection)
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = studentId

        conn.Open()

        Dim result = cmd.ExecuteScalar()

        conn.Close()

        If result Is Nothing OrElse IsDBNull(result) Then
            Return 0
        Else
            Return CDec(result)
        End If
    End Function
    ' Update the balance of a student
    Private Sub UpdateStudentBalance(studentId As Integer, balance As Decimal)
        Dim query As String = "UPDATE StudentTBL SET Account = @Account WHERE Id = @Id"

        Dim conn As New SqlConnection(Connection)
        Dim cmd As New SqlCommand(query, conn)

        cmd.Parameters.Add("@Account", SqlDbType.Decimal).Value = balance
        cmd.Parameters.Add("@Id", SqlDbType.Int).Value = studentId

        conn.Open()

        cmd.ExecuteNonQuery()

        conn.Close()
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
        Dim mealDate As DateTime = dateTimePicker.Value
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

        ' Get the selected student account balance
        ' Dim selectedStudentId As Integer = Integer.Parse("@Id".SelectedValue)
        'Dim selectedStudentBalance As Decimal = GetStudentBalance(selectedStudentId)


        ' Check if the student has enough balance to purchase the meal
        ' If selectedStudentBalance < mealPrice Then
        MessageBox.Show("Selected student does not have enough balance to purchase this meal.")
        '    Return
        'End If

        ' Deduct the meal price from the student's account balance
        ' Dim updatedStudentBalance As Decimal = selectedStudentBalance - mealPrice
        'UpdateStudentBalance(selectedStudentId, updatedStudentBalance)

        'Create a SQL query to insert the values into the database
        Dim query As String = "INSERT INTO MealTBL (Date, MealTime, Meal, Price,Id) VALUES (@Date, @MealTime, @Meal, @Price,@Id)"

        Dim conn As New SqlConnection(Connection)
        Dim cmd As New SqlCommand(query, conn)

        'Add parameters with correct data types
        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = mealDate
        cmd.Parameters.Add("@MealTime", SqlDbType.NVarChar).Value = mealMealTime
        cmd.Parameters.Add("@Meal", SqlDbType.NVarChar).Value = mealMeal
        cmd.Parameters.Add("@Price", SqlDbType.Decimal).Value = mealPrice
        ' cmd.Parameters.Add("@AdmNo", SqlDbType.Int).Value = selectedStudentId

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
        cbMealTime.Items.AddRange({"Breakfast", "Lunch", "Supper"})
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