Imports System.Data.SqlClient
Public Class Orders
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\CafeSYS.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub FillCategory()
        Con.open()
        Dim cmd = New SqlCommand("select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        categoryCB.DataSource = Tbl
        categoryCB.DisplayMember = "CatName"
        categoryCB.ValueMember = "CatName"
        Con.close()
    End Sub
    Private Sub DisplayItem()
        Con.open()
        Dim query = "select * from ItemTbl"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        itemDGV.DataSource = ds.Tables(0)
        Con.close()
    End Sub
    Private Sub FilterByCategory()
        Con.Open()
        Dim query = "select * from ItemTbl where ItCat='" & categoryCB.SelectedValue.ToString() & "'"
        Dim cmd = New SqlCommand(query, Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim builder = New SqlCommandBuilder(adapter)
        builder = New SqlCommandBuilder(adapter)
        Dim ds = New DataSet()
        adapter.Fill(ds)
        itemDGV.DataSource = ds.Tables(0)
        Con.Close()
    End Sub
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayItem()
        FillCategory()
    End Sub

    Private Sub categoryCB_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles categoryCB.SelectionChangeCommitted
        FilterByCategory()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DisplayItem()
    End Sub
    Dim prodName As String
    Dim i = 0, GrdTotal = 0, price, qty
    Private Sub AddBill()
        Con.Open()
        Dim query = "Insert into OrderTbl values('" & DateTime.Today.Date & "','" & GrdTotal & "')"
        Dim cmd As SqlCommand
        cmd = New SqlCommand(query, Con)
        cmd.ExecuteNonQuery()
        MsgBox("Bill Added")
        Con.close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AddBill()
        PrintPreviewDialog1.Show()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString("Cafe Shop", New Font("Arial", 22), Brushes.BlueViolet, 335, 35)
        e.Graphics.DrawString("***Your Bill***", New Font("Arial", 14), Brushes.BlueViolet, 350, 60)
        Dim bm As New Bitmap(Me.billDGV.Width, Me.billDGV.Height)
        billDGV.DrawToBitmap(bm, New Rectangle(0, 0, Me.billDGV.Width, Me.billDGV.Height))
        e.Graphics.DrawImage(bm, 0, 90)
        e.Graphics.DrawString("Total Amount " + GrdTotal.ToString(), New Font("Arial", 15), Brushes.Crimson, 325, 580)
        e.Graphics.DrawString("=============Thanks for Buying Here=============", New Font("Arial", 16), Brushes.Crimson, 130, 600)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim Obj = New ViewOrders
        Obj.Show()
        Me.Hide()
    End Sub
    Private Sub UpdateItem()

        Try
            Dim newQty = stock - Convert.ToInt32(quantity.Text)
            Con.Open()
            Dim query = "update ItemTbl set ItQty=" & newQty & " where ItId=" & key & ""
            Dim cmd As New SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Edited")
            Con.close()
            DisplayItem()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub addBillBtn_Click(sender As Object, e As EventArgs) Handles addBillBtn.Click
        If key = 0 Then
            MsgBox("Select an Item")
        ElseIf Convert.ToInt32(quantity.Text) > stock Then
            MsgBox("No Enough Stock")
        Else
            Dim rnum As Integer = billDGV.Rows.Add()
            Dim total = Convert.ToInt32(quantity.Text) * price
            i = i + 1
            billDGV.Rows.Item(rnum).Cells("Column1").Value = i
            billDGV.Rows.Item(rnum).Cells("Column2").Value = prodName
            billDGV.Rows.Item(rnum).Cells("Column3").Value = price
            billDGV.Rows.Item(rnum).Cells("Column4").Value = quantity.Text
            billDGV.Rows.Item(rnum).Cells("Column5").Value = total
            GrdTotal = GrdTotal + total
            totalLBL.Text = "Ksh : " + Convert.ToString(GrdTotal)
            UpdateItem()
            quantity.Text = ""
            key = 0
        End If
    End Sub

    Dim key = 0, stock
    Private Sub itemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemDGV.CellMouseClick
        Dim row As DataGridViewRow = itemDGV.Rows(e.RowIndex)
        prodName = row.Cells(1).Value.ToString
        If prodName = "" Then
            key = 0
            stock = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)
            stock = Convert.ToInt32(row.Cells(4).Value.ToString)
            price = Convert.ToInt32(row.Cells(3).Value.ToString)
        End If
    End Sub
End Class