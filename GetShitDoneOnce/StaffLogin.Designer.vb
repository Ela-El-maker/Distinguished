<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffLogin
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtSTNumber = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(349, 110)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 44)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Student"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aquamarine
        Me.Button1.Location = New System.Drawing.Point(137, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 44)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Staff"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumAquamarine
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtSTNumber)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(802, 240)
        Me.Panel1.TabIndex = 7
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(343, 135)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(145, 44)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(300, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(270, 30)
        Me.txtPassword.TabIndex = 3
        '
        'txtSTNumber
        '
        Me.txtSTNumber.Location = New System.Drawing.Point(300, 17)
        Me.txtSTNumber.Name = "txtSTNumber"
        Me.txtSTNumber.Size = New System.Drawing.Size(270, 30)
        Me.txtSTNumber.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cascadia Code SemiBold", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 30)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Dining Hall System"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Code SemiBold", 17.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(344, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(247, 30)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Daystar University"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SeaGreen
        Me.Button3.Location = New System.Drawing.Point(554, 110)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 44)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Admin"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 412)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Font = New System.Drawing.Font("Cascadia Code SemiBold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "StaffLogin"
        Me.Text = "StaffLogin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtSTNumber As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button3 As Button
End Class
