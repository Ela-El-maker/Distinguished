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
    Private Sub LoadSelectedMealData()
        Dim Conn As New SqlConnection(Connection)
        Dim query As String = "SELECT Date,AdmNo, Name, MealTime, Meal, Price, Account FROM StudentSelectionTBL"

        Dim cmd As New SqlCommand(query, Conn)
        cmd.Parameters.AddWithValue("@AdmNo", txtAdmNo.Text)
        cmd.Parameters.AddWithValue("@Date", DateTime.Now.ToShortDateString())
        Dim adapter As New SqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        mealsDGV.DataSource = table
    End Sub
    Private Sub LoadMealSelectedData()
        Using Conn As New SqlConnection(Connection)
            Conn.Open()

            ' Create a SQL command to select data from the StudentSelectionTBL table
            Dim sql As String = "SELECT Date, AdmNo, MealTime, Meal, Price FROM StudentSelectionTBL"
            Dim cmd As New SqlCommand(sql, Conn)

            ' Execute the command and get the data
            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Load the data into the historyDGV DataGridView control
            Dim dt As New DataTable()
            dt.Load(reader)
            mealsDGV.DataSource = dt

            reader.Close()
        End Using
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

        Dim studentAdm As Integer = txtAdmNo.Text
        Dim dateSelected As DateTime = DateTime.Today

        Using Conn As New SqlConnection(Connection)
            Conn.Open()
            ' Check if the meal exists in the MealTBL table
            Dim mealId As Integer = 0
            Dim sqlMealId As String = "SELECT Id FROM MealTBL WHERE Meal = @Meal AND MealTime = @MealTime AND Date = @Date"
            Dim cmdMealId As New SqlCommand(sqlMealId, Conn)
            cmdMealId.Parameters.AddWithValue("@Meal", txtMeal.Text)
            cmdMealId.Parameters.AddWithValue("@MealTime", cbMealTime.Text)
            cmdMealId.Parameters.AddWithValue("@Date", dateSelected)
            Dim readerMealId As SqlDataReader = cmdMealId.ExecuteReader()
            If readerMealId.HasRows Then
                readerMealId.Read()
                mealId = readerMealId.GetInt32(0)
                readerMealId.Close()
            Else
                readerMealId.Close()
                MessageBox.Show("Invalid meal selection.")
                Return
            End If
            ' Create a SQL command to select data from the StudentTBL table
            Dim sqlStudent As String = "SELECT Name, Account FROM StudentTBL WHERE AdmNo = @AdmNo"
            Dim cmdStudent As New SqlCommand(sqlStudent, Conn)
            cmdStudent.Parameters.AddWithValue("@AdmNo", studentAdm)

            ' Execute the command and get the data
            Dim readerStudent As SqlDataReader = cmdStudent.ExecuteReader()

            ' Check if the student exists
            If Not readerStudent.HasRows Then
                readerStudent.Close()
                MessageBox.Show("Invalid admission number.")
                Return
            End If

            ' Get the student details
            readerStudent.Read()
            Dim name As String = readerStudent("Name").ToString()
            Dim accountBalance As Decimal = Decimal.Parse(readerStudent("Account").ToString())
            readerStudent.Close()

            ' Get the meal details from the form controls
            Dim meal As String = txtMeal.Text
            Dim mealTime As String = cbMealTime.Text
            Dim price As Decimal = Decimal.Parse(txtPrice.Text)

            ' Check if the student has sufficient balance
            If accountBalance < price Then
                MessageBox.Show("Insufficient account balance.")
                Return
            End If
            ' Create a SQL command to select the account balance from the StudentTBL table
            Dim sqlAccount As String = "SELECT Account FROM StudentTBL WHERE AdmNo = @AdmNo"
            Dim cmdAccount As New SqlCommand(sqlAccount, Conn)
            cmdAccount.Parameters.AddWithValue("@AdmNo", studentAdm)

            ' Execute the command and get the account balance
            Dim accountReader As SqlDataReader = cmdAccount.ExecuteReader()
            Dim LabeLaccountBalance As Decimal = 0

            If accountReader.HasRows Then
                accountReader.Read()
                LabeLaccountBalance = Decimal.Parse(accountReader("Account").ToString())
            End If

            accountReader.Close()

            ' Display the account balance to the user
            Label7.Text = "Account Balance: " & accountBalance.ToString("c")

            ' Create a SQL command to insert the data into the StudentSelectionTBL table
            Dim sqlInsert As String = "INSERT INTO StudentSelectionTBL (Date, AdmNo, MealId, Name, Account) VALUES (@Date, @AdmNo, @MealId, @Name, @Account)"
            Dim cmdInsert As New SqlCommand(sqlInsert, Conn)
            cmdInsert.Parameters.AddWithValue("@Date", dateSelected)
            cmdInsert.Parameters.AddWithValue("@AdmNo", studentAdm)
            cmdInsert.Parameters.AddWithValue("@MealId", mealId)
            cmdInsert.Parameters.AddWithValue("@Name", name)
            cmdInsert.Parameters.AddWithValue("@Account", accountBalance - price)

            ' Execute the insert command
            cmdInsert.ExecuteNonQuery()

            ' Display a message to the user
            MessageBox.Show("Meal added to StudentSelectionTBL.")

            ' Reload the data in the historyDGV
            LoadMealSelectedData()

            ' Clear the form controls
            txtAdmNo.Clear()
            txtMeal.Clear()
            cbMealTime.SelectedIndex = -1
            txtPrice.Clear()
        End Using
    End Sub





End Class