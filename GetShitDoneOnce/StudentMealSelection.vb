Imports System.Data.SqlClient
Public Class StudentMealSelection
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
        Dim Obj As New Login()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj As New StudentAccountInfo()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj As New StudentPayment()
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj As New StudentMealSelection()
        Obj.Show()
        Me.Hide()
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

    Private Sub StudentMealSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtMeal.Text) OrElse String.IsNullOrEmpty(cbMealTime.Text) _
        OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim conn As New SqlConnection(Connection)
        conn.Open()
        ' Define SQL queries for selecting data
        Dim mealQuery As String = "SELECT Date, MealTime, Meal, Price FROM MealTBL"
        Dim studentQuery As String = "SELECT AdmNo,Name, Account FROM StudentTBL"
        'Execute the SQL queries and fetch the data
        Dim mealsCmd As New SqlCommand(mealQuery, conn)
        Dim mealsReader As SqlDataReader = mealsCmd.ExecuteReader()
        Dim studentCmd As New SqlCommand(studentQuery, conn)
        Dim studentReader As SqlDataReader = studentCmd.ExecuteReader()
        'Insert the selected data into the studentselectionTBL
        While mealsReader.Read() And studentReader.Read()
            Dim datePicked As DateTime = mealsReader.GetDateTime(0)
            Dim mealTime As String = mealsReader.GetString(1)
            Dim meal As String = mealsReader.GetString(2)
            Dim price As Decimal = mealsReader.GetDecimal(3)
            Dim name As String = studentReader.GetString(0)
            Dim accountbalance As Decimal = studentReader.GetDecimal(1)


            Dim insertQuery As String = "INSERT INTO StudentSelectionTBL (Date ,Name, MealTime, Meal, Price, Account) VALUES (@Date, @Name,@MealTime, @Meal, @Price, @Account)"
            Dim insertCmd As New SqlCommand(insertQuery, conn)
            insertCmd.Parameters.AddWithValue("@Date", datePicked)
            insertCmd.Parameters.AddWithValue("@Name", name)
            insertCmd.Parameters.AddWithValue("@MealTime", mealTime)
            insertCmd.Parameters.AddWithValue("@Meal", meal)
            insertCmd.Parameters.AddWithValue("@Price", price)
            insertCmd.Parameters.AddWithValue("@Account", accountbalance)
            insertCmd.ExecuteNonQuery()
        End While

        ' Step 5: Close the connection and readers
        mealsReader.Close()
        studentReader.Close()
        conn.Close()
        ' Reload the data in the DataGridView control to show the new record
        LoadData()
        MessageBox.Show("Meal added successfully.")
        ' Clear the text boxes
        txtPrice.Clear()
        txtMeal.Clear()
    End Sub
End Class