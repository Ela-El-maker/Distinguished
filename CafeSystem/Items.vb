Imports System.Data.SqlClient
Public Class Items
    Dim Con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\CafeSYS.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If itcategoryCB.SelectedIndex = -1 Or itName.Text = "" Or itPrice.Text = "" Or itQuantity.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.Open()
            Dim query = "Insert into ItemTbl values('" & itName.Text & "','" & itcategoryCB.SelectedValue.ToString() & "','" & itPrice.Text & "','" & itQuantity.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Items Added")
            Con.close()
            Reset()
            DisplayItem()
        End If


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If category.Text = "" Then
            MsgBox("Enter The Category")
        Else
            Con.Open()
            Dim query = "Insert into CategoryTbl values('" & category.Text & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Category Added")
            Con.close()
            category.Text = ""
            FillCategory()
        End If

    End Sub
    Private Sub Reset()
        itName.Text = ""
        itcategoryCB.SelectedIndex = 0
        itQuantity.Text = 0
        itPrice.Text = ""
    End Sub
    Private Sub FillCategory()
        Con.open()
        Dim cmd = New SqlCommand("select * from CategoryTbl", Con)
        Dim adapter = New SqlDataAdapter(cmd)
        Dim Tbl = New DataTable()
        adapter.Fill(Tbl)
        itcategoryCB.DataSource = Tbl
        itcategoryCB.DisplayMember = "CatName"
        itcategoryCB.ValueMember = "CatName"
        Con.close()
    End Sub
    Private Sub resetBtn_Click(sender As Object, e As EventArgs) Handles resetBtn.Click
        Reset()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCategory()
        DisplayItem()

    End Sub
    Dim key = 0
    Private Sub itemDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemDGV.CellMouseClick
        Dim row As DataGridViewRow = itemDGV.Rows(e.RowIndex)
        itName.Text = row.Cells(1).Value.ToString
        itcategoryCB.SelectedValue = row.Cells(2).Value.ToString
        itPrice.Text = row.Cells(3).Value.ToString
        itQuantity.Text = row.Cells(4).Value.ToString
        If itName.Text = "" Then
            key = 0
        Else
            key = Convert.ToInt32(row.Cells(0).Value.ToString)

        End If
    End Sub

    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click

        If key = 0 Then
            MsgBox("Select Item to be Deleted")
        Else
            Con.Open()
            Dim query = " delete from ItemTbl where ItId = " & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Deleted")
            Con.close()
            Reset()
            DisplayItem()

        End If
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        If itcategoryCB.SelectedIndex = -1 Or itName.Text = "" Or itPrice.Text = "" Or itQuantity.Text = "" Then
            MsgBox("Missing information")
        Else
            Con.Open()
            Dim query = "update ItemTbl set ItName='" & itName.Text & "',ItCat='" & itcategoryCB.SelectedValue.ToString() & "',ItPrice='" & itPrice.Text & "',ItQty='" & itQuantity.Text & "' where ItId=" & key & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, Con)
            cmd.ExecuteNonQuery()
            MsgBox("Item Updated")
            Con.close()
            Reset()
            DisplayItem()
        End If
    End Sub
End Class