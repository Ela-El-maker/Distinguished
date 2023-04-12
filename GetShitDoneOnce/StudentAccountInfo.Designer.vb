<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentAccountInfo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbMealTime = New System.Windows.Forms.ComboBox()
        Me.txtMeal = New System.Windows.Forms.TextBox()
        Me.txtAdmNo = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.historyDGV = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.historyDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.cbMealTime)
        Me.Panel1.Controls.Add(Me.txtMeal)
        Me.Panel1.Controls.Add(Me.txtAdmNo)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnGenerate)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(11, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 307)
        Me.Panel1.TabIndex = 0
        '
        'cbMealTime
        '
        Me.cbMealTime.FormattingEnabled = True
        Me.cbMealTime.Location = New System.Drawing.Point(130, 106)
        Me.cbMealTime.Name = "cbMealTime"
        Me.cbMealTime.Size = New System.Drawing.Size(237, 33)
        Me.cbMealTime.TabIndex = 3
        '
        'txtMeal
        '
        Me.txtMeal.Location = New System.Drawing.Point(130, 170)
        Me.txtMeal.Name = "txtMeal"
        Me.txtMeal.Size = New System.Drawing.Size(237, 30)
        Me.txtMeal.TabIndex = 4
        '
        'txtAdmNo
        '
        Me.txtAdmNo.Location = New System.Drawing.Point(130, 62)
        Me.txtAdmNo.Name = "txtAdmNo"
        Me.txtAdmNo.Size = New System.Drawing.Size(237, 30)
        Me.txtAdmNo.TabIndex = 1
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(130, 15)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(237, 30)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = " "
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(157, 234)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(172, 41)
        Me.btnGenerate.TabIndex = 5
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 25)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Meal :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(2, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 25)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Mealtime :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Adm No:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(201, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Profile"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(314, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Payment Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(486, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Meal Selection"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(673, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 25)
        Me.LinkLabel1.TabIndex = 5
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log Out"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel2.Controls.Add(Me.lblWelcome)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(11, 22)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 56)
        Me.Panel2.TabIndex = 34
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblWelcome.Location = New System.Drawing.Point(23, 14)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(0, 25)
        Me.lblWelcome.TabIndex = 6
        '
        'historyDGV
        '
        Me.historyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.historyDGV.Location = New System.Drawing.Point(400, 123)
        Me.historyDGV.Name = "historyDGV"
        Me.historyDGV.Size = New System.Drawing.Size(417, 279)
        Me.historyDGV.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(584, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 25)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "History"
        '
        'PrintDocument1
        '
        '
        'StudentAccountInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 414)
        Me.Controls.Add(Me.historyDGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "StudentAccountInfo"
        Me.Text = "Account Information"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.historyDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents btnGenerate As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents historyDGV As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents cbMealTime As ComboBox
    Friend WithEvents txtMeal As TextBox
    Friend WithEvents txtAdmNo As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblWelcome As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
