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
            Dim cmd As New SqlCommand("SELECT * FROM SelectedTBL", Conn)
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
        'Populate the historyDGV with the selected meals data for the currently selected student
        ' Call OutputInDGV with the initial values
        OutputInDGV(txtAdmNo.Text)
        Dim username As String = Login.txtAdmNo.Text
        lblWelcome.Text = "Welcome, " + username + "!"

        ' Retrieve name from the database using admNo
        Dim name As String = txtName.Text
        Dim admNo As String = txtAdmNo.Text

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
    Private Sub historyDGV_SelectionChanged(sender As Object, e As EventArgs) Handles historyDGV.SelectionChanged
        If historyDGV.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = historyDGV.SelectedRows(0)

            'Display the values in the textboxes
            txtAdmNo.Text = selectedRow.Cells("AdmNo").Value.ToString()
            txtName.Text = selectedRow.Cells("Name").Value.ToString()
            cbMealTime.Text = selectedRow.Cells("MealTime").Value.ToString()
            txtMeal.Text = selectedRow.Cells("Meal").Value.ToString()

            'Populate historyDGV with selected student's meal history
            OutputInDGV(txtAdmNo.Text)
        End If
    End Sub

    Private Sub OutputInDGV(admNo As String)
        Using conn As New SqlConnection(Connection)
            conn.Open()

            Dim sql As String = "SELECT Name, AdmNo, MealTime, Meal FROM SelectedTBL WHERE AdmNo = @AdmNo"
            Dim cmd As New SqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@AdmNo", admNo)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtName.Text = reader("Name").ToString()
                txtAdmNo.Text = reader("AdmNo").ToString()
                cbMealTime.Text = reader("MealTime").ToString()
                txtMeal.Text = reader("Meal").ToString()
            Else
                MessageBox.Show("Done!!!")
            End If

            reader.Close()
        End Using
    End Sub




    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        ' Create a new PrintDocument object
        Dim pd As New Printing.PrintDocument()

        ' Set the document name (optional)
        pd.DocumentName = "Student Info"

        ' Add an event handler for the PrintPage event
        AddHandler pd.PrintPage, AddressOf PrintPageHandler

        ' Print the document
        pd.Print()
    End Sub
    Private Sub PrintPageHandler(sender As Object, e As Printing.PrintPageEventArgs)
        ' Set the font and color for the text
        Dim font As New Font("Arial", 16)
        Dim brush As New SolidBrush(Color.Black)

        ' Get the values from the textboxes
        Dim name As String = txtName.Text
        Dim admNo As String = txtAdmNo.Text
        Dim mealTime As String = cbMealTime.Text
        Dim meal As String = txtMeal.Text

        ' Create the text to be printed
        Dim text As String = "Name: " + name + vbCrLf + "Adm No: " + admNo + vbCrLf + "Meal Time: " + mealTime + vbCrLf + "Meal: " + meal

        ' Calculate the size of the text
        Dim textSize As SizeF = e.Graphics.MeasureString(text, font)

        ' Calculate the position for the text
        Dim x As Single = e.MarginBounds.Left
        Dim y As Single = e.MarginBounds.Top

        ' Print the text
        e.Graphics.DrawString(text, font, brush, x, y)

        ' Clean up
        font.Dispose()
        brush.Dispose()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    End Sub
End Class