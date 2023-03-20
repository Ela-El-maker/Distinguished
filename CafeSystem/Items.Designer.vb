<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.itemDGV = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.category = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.itName = New System.Windows.Forms.TextBox()
        Me.itcategoryCB = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.itQuantity = New System.Windows.Forms.TextBox()
        Me.itPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.resetBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.itemDGV)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.category)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(93, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 571)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(323, 326)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Items List"
        '
        'itemDGV
        '
        Me.itemDGV.BackgroundColor = System.Drawing.Color.MediumSeaGreen
        Me.itemDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemDGV.GridColor = System.Drawing.Color.LawnGreen
        Me.itemDGV.Location = New System.Drawing.Point(77, 373)
        Me.itemDGV.Name = "itemDGV"
        Me.itemDGV.RowTemplate.Height = 28
        Me.itemDGV.Size = New System.Drawing.Size(715, 150)
        Me.itemDGV.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(375, 51)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(169, 37)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Add Category"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'category
        '
        Me.category.Location = New System.Drawing.Point(207, 58)
        Me.category.Name = "category"
        Me.category.Size = New System.Drawing.Size(137, 30)
        Me.category.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 25)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Name "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.resetBtn)
        Me.Panel2.Controls.Add(Me.deleteBtn)
        Me.Panel2.Controls.Add(Me.editBtn)
        Me.Panel2.Controls.Add(Me.addBtn)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.itName)
        Me.Panel2.Controls.Add(Me.itcategoryCB)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.itQuantity)
        Me.Panel2.Controls.Add(Me.itPrice)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(77, 118)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(715, 171)
        Me.Panel2.TabIndex = 9
        '
        'deleteBtn
        '
        Me.deleteBtn.Location = New System.Drawing.Point(392, 120)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(122, 37)
        Me.deleteBtn.TabIndex = 13
        Me.deleteBtn.Text = "Delete"
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'editBtn
        '
        Me.editBtn.Location = New System.Drawing.Point(227, 120)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Size = New System.Drawing.Size(122, 37)
        Me.editBtn.TabIndex = 12
        Me.editBtn.Text = "Edit"
        Me.editBtn.UseVisualStyleBackColor = True
        '
        'addBtn
        '
        Me.addBtn.Location = New System.Drawing.Point(73, 120)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(122, 37)
        Me.addBtn.TabIndex = 11
        Me.addBtn.Text = "Add"
        Me.addBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Categories"
        '
        'itName
        '
        Me.itName.Location = New System.Drawing.Point(27, 73)
        Me.itName.Name = "itName"
        Me.itName.Size = New System.Drawing.Size(137, 30)
        Me.itName.TabIndex = 2
        '
        'itcategoryCB
        '
        Me.itcategoryCB.FormattingEnabled = True
        Me.itcategoryCB.Location = New System.Drawing.Point(193, 70)
        Me.itcategoryCB.Name = "itcategoryCB"
        Me.itcategoryCB.Size = New System.Drawing.Size(165, 33)
        Me.itcategoryCB.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Price"
        '
        'itQuantity
        '
        Me.itQuantity.Location = New System.Drawing.Point(566, 73)
        Me.itQuantity.Name = "itQuantity"
        Me.itQuantity.Size = New System.Drawing.Size(137, 30)
        Me.itQuantity.TabIndex = 6
        '
        'itPrice
        '
        Me.itPrice.Location = New System.Drawing.Point(414, 73)
        Me.itPrice.Name = "itPrice"
        Me.itPrice.Size = New System.Drawing.Size(119, 30)
        Me.itPrice.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(561, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 25)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(320, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manage Items"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(9, 463)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(78, 25)
        Me.LinkLabel1.TabIndex = 1
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "LogOut"
        '
        'resetBtn
        '
        Me.resetBtn.Location = New System.Drawing.Point(540, 120)
        Me.resetBtn.Name = "resetBtn"
        Me.resetBtn.Size = New System.Drawing.Size(122, 37)
        Me.resetBtn.TabIndex = 14
        Me.resetBtn.Text = "Reset"
        Me.resetBtn.UseVisualStyleBackColor = True
        '
        'Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.ClientSize = New System.Drawing.Size(936, 595)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Items"
        Me.Text = "Items"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.itemDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents itQuantity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents itPrice As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents itName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents category As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents addBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents itcategoryCB As ComboBox
    Friend WithEvents itemDGV As DataGridView
    Friend WithEvents deleteBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents resetBtn As Button
End Class
