Imports System.Data.SqlClient

Public Class StudentPayment
    Dim Connection As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\feloe\Documents\Dining.mdf;Integrated Security=True;Connect Timeout=30"

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

    Private Sub UpdatedBalance()
        Try
            'Open database connection
            Using conn As New SqlConnection(Connection)
                conn.Open()

                'Retrieve current balance from the database
                Dim sqlBefore As String = "SELECT Account FROM StudentTBL WHERE Contact = @Contact"
                Dim cmdBefore As New SqlCommand(sqlBefore, conn)
                cmdBefore.Parameters.AddWithValue("@Contact", txtContact.Text)
                Dim currentBalance As Double = CDbl(cmdBefore.ExecuteScalar())
                'lblCurrentBalance.Text = currentBalance.ToString("C")

                'Update balance in the database
                Dim newBalance As Double = CDbl(txtNewBalance.Text)
                Dim sqlUpdate As String = "UPDATE StudentTBL SET Account = @Account WHERE Contact = @Contact"
                Dim cmdUpdate As New SqlCommand(sqlUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@Contact", txtContact.Text)
                cmdUpdate.Parameters.AddWithValue("@Account", newBalance)
                cmdUpdate.ExecuteNonQuery()

                'Retrieve new balance from the database
                Dim sqlAfter As String = "SELECT Account FROM StudentTBL WHERE Contact = @Contact"
                Dim cmdAfter As New SqlCommand(sqlAfter, conn)
                cmdAfter.Parameters.AddWithValue("@Contact", txtContact.Text)
                Dim updatedBalance As Double = CDbl(cmdAfter.ExecuteScalar())
                lblUpdatedBalance.Text = updatedBalance.ToString("C")

                MessageBox.Show("Balance updated successfully.")

            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating balance: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateBalance1()
        Try
            'Open database connection
            Using conn As New SqlConnection(Connection)
                conn.Open()

                'Retrieve current balance from database
                Dim sql As String = "SELECT Account FROM StudentTBL WHERE Contact = @Contact"
                Dim cmd As New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                Dim currentBalance As Decimal = cmd.ExecuteScalar()

                'Update balance in the database
                sql = "UPDATE StudentTBL SET Account = @Account WHERE Contact = @Contact"
                cmd = New SqlCommand(sql, conn)
                cmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                cmd.Parameters.AddWithValue("@Account", txtNewBalance.Text)
                cmd.ExecuteNonQuery()

                'Display current and updated balances
                'lblCurrentBalance.Text = currentBalance.ToString("0.00")
                lblUpdatedBalance.Text = txtNewBalance.Text

                MessageBox.Show("Balance updated successfully.")

            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating balance: " & ex.Message)
        End Try
    End Sub
    Private Sub UpdateBalance()
        Try
            'Open database connection
            Using conn As New SqlConnection(Connection)
                conn.Open()

                'Retrieve current balance
                Dim selectSql As String = "SELECT Account FROM StudentTBL WHERE Contact = @Contact"
                Dim selectCmd As New SqlCommand(selectSql, conn)
                selectCmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                Dim currentBalance As Double = Convert.ToDouble(selectCmd.ExecuteScalar())

                'Calculate updated balance
                Dim newBalance As Double = currentBalance + Convert.ToDouble(txtNewBalance.Text)

                'Update balance in the database
                Dim updateSql As String = "UPDATE StudentTBL SET Account = @Account WHERE Contact = @Contact"
                Dim updateCmd As New SqlCommand(updateSql, conn)
                updateCmd.Parameters.AddWithValue("@Contact", txtContact.Text)
                updateCmd.Parameters.AddWithValue("@Account", newBalance)
                updateCmd.ExecuteNonQuery()

                'Update balance labels

                lblUpdatedBalance.Text = newBalance.ToString("F")

                MessageBox.Show("Balance updated successfully.")

            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating balance: " & ex.Message)
        End Try
    End Sub


    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        UpdateBalance()
    End Sub
End Class
