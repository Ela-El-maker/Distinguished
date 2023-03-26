<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMealSelection
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
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.mealsDGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.mealsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(681, 15)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 25)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log Out"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(414, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Meal Selection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(161, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(166, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Payment Status"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Profile"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(347, 322)
        Me.Panel1.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(153, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 36)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 25)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Meal :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Account Balance :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Price :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 25)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Today :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "MealTime :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(12, 21)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(812, 56)
        Me.Panel2.TabIndex = 35
        '
        'mealsDGV
        '
        Me.mealsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.mealsDGV.Location = New System.Drawing.Point(378, 111)
        Me.mealsDGV.Name = "mealsDGV"
        Me.mealsDGV.Size = New System.Drawing.Size(446, 294)
        Me.mealsDGV.TabIndex = 36
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(519, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(177, 25)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Meals Available"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(143, 96)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 30)
        Me.TextBox3.TabIndex = 20
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(143, 139)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(184, 30)
        Me.TextBox4.TabIndex = 21
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(143, 18)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(184, 33)
        Me.ComboBox1.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(143, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 30)
        Me.DateTimePicker1.TabIndex = 23
        '
        'StudentMealSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(836, 417)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mealsDGV)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "StudentMealSelection"
        Me.Text = "StudentMealSelection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.mealsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents mealsDGV As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
End Class
