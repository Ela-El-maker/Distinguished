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

    Private Sub LoadStudentData()
        Dim query As String = "SELECT * from StudentTBL"
        Dim Conn As New SqlConnection(Connection) 'create a new sqlconnection object using the connection
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        mealsDGV.DataSource = table
    End Sub
    Private Sub LoadMealData()
        Dim query As String = "SELECT * from MealTBL"
        Dim Conn As New SqlConnection(Connection)
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        mealsDGV.DataSource = table
    End Sub
    Private Sub LoadMealSelectedData()
        Dim query As String = "SELECT Date,AdmNo, Name, MealTime, Meal, Price, Account FROM StudentSelectionTBL"
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
        Populate()
    End Sub
    Private Sub Populate()
        Dim conn As New SqlConnection(Connection)
        Dim dateSelected As Date = DateTime.Now.ToShortDateString()
        Dim studentAdm As String = txtAdmNo.Text
        Dim sql As String = "SELECT s.Name, s.Account, m.Meal, m.MealTime, m.Price FROM StudentTBL s, MealTBL m WHERE s.AdmNo = '" & studentAdm & "' AND m.Date='" & dateSelected & "'"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim dt As New DataTable()
        da.Fill(dt)
        mealSelectedDGV.DataSource = dt

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' Check if any textbox is empty
        If String.IsNullOrEmpty(txtMeal.Text) OrElse String.IsNullOrEmpty(cbMealTime.Text) _
        OrElse String.IsNullOrEmpty(txtPrice.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If
        Dim Conn As New SqlConnection(Connection) ' Create a new SqlConnection object using the connection string

        Dim dateSelected As String = DateTime.Now.ToShortDateString()
        Dim studentAdm As Integer = txtAdmNo.Text
        'Create a SQL statement to select data from the StudentTBL and MealTBL tables
        ' Dim sql As String = "SELECT s.Name, s.Account, m.Meal, m.MealTime, m.Price
        'From StudentTBL s, MealTBL m
        'Where s.AdmNo = @AdmNo And m.Date = @Date"
        Dim sql As String = "SELECT s.Name, s.Account, m.Meal, m.MealTime, m.Price FROM StudentTBL s, MealTBL m WHERE s.AdmNo = '" & studentAdm & "' AND m.Date='" & dateSelected & "'"

        Populate()

        'Create a command object with the SQL statement and parameters

        Dim cmd As New SqlCommand(Sql, Conn)
        cmd.Parameters.AddWithValue("@AdmNo", txtAdmNo.Text) 'replace with the actual admission number
        cmd.Parameters.AddWithValue("@Date", dateSelected) 'replace with the actual date


        Conn.Open() 'Open database connection 
        'Dim mealTime As String = cbMealTime.Text
        'Dim mealSelected As String = txtMeal.Text
        'Dim mealPrice As Double = CDbl(txtPrice.Text)
        ' Execute the command and get the data
        Dim reader As SqlDataReader = cmd.ExecuteReader()


        ' Loop through the results and insert them into the studentselectionTBL table
        While reader.Read()

            Dim mealTime As String = reader("MealTime").ToString()
            Dim meal As String = reader("Meal").ToString()
            Dim price As Decimal = Decimal.Parse(reader("Price").ToString())
            Dim name As String = reader("Name").ToString()
            Dim accountBalance As Decimal = Decimal.Parse(reader("Account").ToString())

            'Create a SQL statement to insert the data into the StudentSelectionTBL table
            ' Dim insertSql As String = "INSERT INTO StudentSelectionTBL (Date,AdmNo, Name, MealTime, Meal, Price, Account) " &
            '                  "VALUES (@Date,@AdmNo, @Name, @MealTime, @Meal, @Price, @Account)"

            'Create a command object with the insert SQL statement and parameters
            Dim insertCmd As New SqlCommand("INSERT INTO StudentSelectionTBL (Date, AdmNo, Name, MealTime, Meal, Price, Account) VALUES (@Date, @AdmNo, @Name, @MealTime, @Meal, @Price, @Account)", Conn)

            ' Set the parameter values for the insert command
            insertCmd.Parameters.AddWithValue("@Date", dateSelected)
            insertCmd.Parameters.AddWithValue("@AdmNo", studentAdm)
            insertCmd.Parameters.AddWithValue("@Name", name) ' Replace studentName with the actual student name
            insertCmd.Parameters.AddWithValue("@MealTime", mealTime)
            insertCmd.Parameters.AddWithValue("@Meal", meal)
            insertCmd.Parameters.AddWithValue("@Price", price)
            insertCmd.Parameters.AddWithValue("@Account", accountBalance) ' Replace accountBalance with the actual account balance



            ' Execute the insert command
            insertCmd.ExecuteNonQuery()
        End While

        ' Close the reader and the connection
        reader.Close()
        Conn.Close()



        MessageBox.Show("Enjoy your meal.")

        ' Reload the data in the historyDGV
        LoadMealSelectedData()
        MessageBox.Show("Meal Selected successfully.")
        ' Clear the text boxes
    End Sub

    Private Sub mealSelectedDGV_SelectionChanged(sender As Object, e As EventArgs) Handles mealSelectedDGV.SelectionChanged

    End Sub
End Class