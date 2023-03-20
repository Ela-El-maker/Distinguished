Imports System.Data.SqlClient
Public Class ViewOrders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\CafeSYS.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub DisplayBill()
        Con.open()
        Dim query = "select * from OrderTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        ordersDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub ViewOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayBill()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()

    End Sub
End Class