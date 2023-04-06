Imports System.Data.SqlClient
Public Class StudentAccountInfo
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub LoadStudentData()
        Dim query As String = "SELECT * from StudentTBL"
        Dim Conn As New SqlConnection(Connection) 'create a new sqlconnection object using the connection
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        historyDGV.DataSource = table
    End Sub
    Private Sub LoadMealData()
        Dim query As String = "SELECT * from MealTBL"
        Dim Conn As New SqlConnection(Connection)
        Dim adapter As New SqlDataAdapter(query, Conn)
        Dim table As New DataTable()
        adapter.Fill(table)
        historyDGV.DataSource = table
    End Sub
    Private Sub LoadMealSelectedData()
        Dim table As New DataTable()
        Using Conn As New SqlConnection(Connection)
            Conn.Open()
            Dim cmd As New SqlCommand("SELECT * FROM StudentSelectionTBL", Conn)
            Dim adapter As New SqlDataAdapter()
            adapter.SelectCommand = cmd
            adapter.Fill(table)

        End Using

        historyDGV.DataSource = table
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

    Private Sub StudentAccountInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadMealSelectedData()
        Dim username As String = Login.txtAdmNo.Text
        lblWelcome.Text = "Welcome, " + username + "!"

        ' Retrieve name from the database using admNo
        Dim name As String = txtName.Text
        Dim admNo As String = txtAdm.Text

        Dim Conn As New SqlConnection(Connection) ' Create a new SqlConnection object using the connection string
        Conn.Open()
        Dim query As String = "SELECT Name FROM StudentTBL WHERE AdmNo = '" & admNo & "'"

        Dim cmd As New SqlCommand(query, Conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()
        If reader.Read() Then
            'name = reader("Name").ToString()
            name = reader("Name").ToString()
            admNo = reader("AdmNo").ToString()
        End If
        reader.Close()

        ' Display name and admission number in text boxes
        'txtName.Text = name
        'txtAdm.Text = admNo

        ' Disable editing of the text boxes
        For Each ctrl As Control In Controls
            If TypeOf ctrl Is TextBox Then
                DirectCast(ctrl, TextBox).ReadOnly = True
            End If
        Next
    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click

    End Sub

    Private Sub historyDGV_SelectionChanged(sender As Object, e As EventArgs) Handles historyDGV.SelectionChanged
        If historyDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = historyDGV.SelectedRows(0)

            'Display the values in the textboxes
            txtAdm.Text = selectedRow.Cells("AdmNo").Value.ToString()
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            cbMealTime.Text = selectedRow.Cells("MealTime").Value.ToString()
            txtMeal.Text = selectedRow.Cells("Meal").Value.ToString()

            'Populate StudentSelectionTBL DGV
            Dim query As String = "SELECT * FROM StudentSelectionTBL WHERE AdmNo = '" & txtAdm.Text & "' "
            Dim conn As New SqlConnection(Connection)
            Dim adapter As New SqlDataAdapter(query, conn)
            Dim table As New DataTable()
            adapter.Fill(table)
            historyDGV.DataSource = table
        End If
    End Sub

End Class