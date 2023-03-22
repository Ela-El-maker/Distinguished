<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmStaffs
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.staffsDGV = New System.Windows.Forms.DataGridView()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.staffsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(290, 229)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(118, 36)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'staffsDGV
        '
        Me.staffsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.staffsDGV.Location = New System.Drawing.Point(472, 98)
        Me.staffsDGV.Name = "staffsDGV"
        Me.staffsDGV.Size = New System.Drawing.Size(349, 309)
        Me.staffsDGV.TabIndex = 36
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(223, 172)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(184, 30)
        Me.txtPassword.TabIndex = 29
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(223, 132)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(184, 30)
        Me.txtPosition.TabIndex = 28
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(223, 96)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(184, 30)
        Me.txtContact.TabIndex = 27
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(223, 58)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(184, 30)
        Me.txtNumber.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(223, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(184, 30)
        Me.txtName.TabIndex = 25
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(157, 229)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(118, 36)
        Me.btnUpdate.TabIndex = 30
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Panel1.Controls.Add(Me.btnDelete)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.txtContact)
        Me.Panel1.Controls.Add(Me.txtNumber)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(15, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 309)
        Me.Panel1.TabIndex = 34
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(24, 229)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(118, 36)
        Me.btnAdd.TabIndex = 24
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 177)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 25)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Phone No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Staff No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Position :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Staff Name :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.LinkLabel1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(15, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 56)
        Me.Panel2.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Location = New System.Drawing.Point(33, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 25)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Manage Staffs"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LinkLabel1.Location = New System.Drawing.Point(691, 14)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(89, 25)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Log Out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Location = New System.Drawing.Point(248, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Manage Students "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Location = New System.Drawing.Point(488, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 25)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Manage Meals"
        '
        'AdmStaffs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 418)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.staffsDGV)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "AdmStaffs"
        Me.Text = "AdmStaffs"
        CType(Me.staffsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnDelete As Button
    Friend WithEvents staffsDGV As DataGridView
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
End Class
