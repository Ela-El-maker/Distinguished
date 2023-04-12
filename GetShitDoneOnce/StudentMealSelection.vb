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
    ' Function to check if a given date is a weekday (Monday to Friday)
    Private Function IsWeekday(ByVal dateSelected As DateTime) As Boolean
        Dim dayOfWeek As Integer = CType(dateSelected.DayOfWeek, Integer)
        Return dayOfWeek <> 0 AndAlso dayOfWeek <> 6 ' Sunday = 0, Saturday = 6
    End Function
    ' Function to calculate the cost of a meal based on the meal type and time
    Private Function CalculateMealCost(ByVal meal As String, ByVal mealTime As String) As Decimal
        Dim cost As Decimal = 0
        If mealTime = "Breakfast" Then
            If meal = "Regular" Then
                cost = 20D
            ElseIf meal = "Vegetarian" Then
                cost = 15D
            ElseIf meal = "Omelette" Then
                cost = 25D
            End If
        ElseIf mealTime = "Lunch" Then
            If meal = "Regular" Then
                cost = 35D
            ElseIf meal = "Vegetarian" Then
                cost = 30D
            ElseIf meal = "Fish and Chips" Then
                cost = 40D
            End If
        ElseIf mealTime = "Dinner" Then
            If meal = "Regular" Then
                cost = 40D
            ElseIf meal = "Vegetarian" Then
                cost = 35D
            ElseIf meal = "Pasta" Then
                cost = 45D
            End If
        End If
        Return cost
    End Function

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        Dim studentAdm As Integer = CInt(txtAdmNo.Text)
        Dim dateSelected As DateTime = dateTimePicker.Value

        Using Conn As New SqlConnection(Connection)
            Conn.Open()
            Dim transaction As SqlTransaction = Nothing
            Dim cmdIdentity As New SqlCommand("SET IDENTITY_INSERT SelectedTBL ON", Conn, transaction)
            cmdIdentity.ExecuteNonQuery()
            Try
                transaction = Conn.BeginTransaction()

                ' Check if the meal exists in the MealTBL table
                Dim mealId As Integer = 0
                Dim sqlMealId As String = "SELECT Id FROM MealTBL WHERE Meal = @Meal AND MealTime = @MealTime AND Date = @Date"
                Dim cmdMealId As New SqlCommand(sqlMealId, Conn, transaction)
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

                ' Check if the selected meal has already been added to the SelectedTBL table for the given date and student
                Dim sqlCheckSelectedMeal As String = "SELECT Id FROM SelectedTBL WHERE AdmNo = @AdmNo AND Date = @Date"
                Dim cmdCheckSelectedMeal As New SqlCommand(sqlCheckSelectedMeal, Conn, transaction)
                cmdCheckSelectedMeal.Parameters.AddWithValue("@AdmNo", studentAdm)
                cmdCheckSelectedMeal.Parameters.AddWithValue("@Date", dateSelected)
                Dim readerCheckSelectedMeal As SqlDataReader = cmdCheckSelectedMeal.ExecuteReader()
                If readerCheckSelectedMeal.HasRows Then
                    readerCheckSelectedMeal.Close()
                    MessageBox.Show("This meal has already been selected for the given date and student.")
                    Return
                End If
                readerCheckSelectedMeal.Close()

                ' Get the student details
                Dim sqlStudent As String = "SELECT Name, Account FROM StudentTBL WHERE AdmNo = @AdmNo"
                Dim cmdStudent As New SqlCommand(sqlStudent, Conn, transaction)
                cmdStudent.Parameters.AddWithValue("@AdmNo", studentAdm)
                Dim readerStudent As SqlDataReader = cmdStudent.ExecuteReader()
                If Not readerStudent.HasRows Then
                    readerStudent.Close()
                    MessageBox.Show("Invalid admission number.")
                    Return
                End If
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

                ' Insert the selected meal into the SelectedTBL table
                Dim sqlInsertSelectedMeal As String = "INSERT INTO SelectedTBL (Id, Meal, MealTime, Price, AdmNo, Date, Name, Account) VALUES (@Id, @Meal, @MealTime, @Price, @AdmNo, @Date, @Name, @Account)"
                Dim cmdInsertSelectedMeal As New SqlCommand(sqlInsertSelectedMeal, Conn, transaction)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Id", mealId)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Meal", meal)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@MealTime", mealTime)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Price", price)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@AdmNo", studentAdm)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Date", dateSelected)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Name", name)
                cmdInsertSelectedMeal.Parameters.AddWithValue("@Account", accountBalance)
                cmdInsertSelectedMeal.ExecuteNonQuery()

                ' Deduct the meal price from the student's account balance
                Dim sqlDeductAmount As String = "UPDATE StudentTBL SET Account = Account - @Price WHERE AdmNo = @AdmNo"
                Dim cmdDeductAmount As New SqlCommand(sqlDeductAmount, Conn, transaction)
                cmdDeductAmount.Parameters.AddWithValue("@Price", price)
                cmdDeductAmount.Parameters.AddWithValue("@AdmNo", studentAdm)
                cmdDeductAmount.ExecuteNonQuery()

                Dim cmdIdentityOff As New SqlCommand("SET IDENTITY_INSERT SelectedTBL OFF", Conn, transaction)
                cmdIdentityOff.ExecuteNonQuery()

                transaction.Commit()
                MessageBox.Show("Meal selected successfully.")
            Catch ex As Exception
                If Not transaction Is Nothing Then
                    transaction.Rollback()
                End If
                MessageBox.Show("An error occurred while selecting the meal. Transaction rolled back." + ex.Message)
            End Try
        End Using
    End Sub

End Class