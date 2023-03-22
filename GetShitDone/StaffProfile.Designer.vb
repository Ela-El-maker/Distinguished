<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffProfile
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(84, 172)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Staff Number :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Position :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Name :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SeaGreen
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 131)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 238)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.LinkLabel2)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Location = New System.Drawing.Point(12, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(806, 56)
        Me.Panel2.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Location = New System.Drawing.Point(132, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 25)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Dashboard"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Location = New System.Drawing.Point(3, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 25)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Profile"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(691, 14)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(89, 25)
        Me.LinkLabel2.TabIndex = 31
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Log Out"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Location = New System.Drawing.Point(285, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(188, 25)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Manage Students "
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Location = New System.Drawing.Point(488, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(144, 25)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Manage Meals"
        '
        'StaffProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 419)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "StaffProfile"
        Me.Text = "StaffProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
End Class
