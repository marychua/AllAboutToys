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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.show_password = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.password_lbl = New System.Windows.Forms.Label()
        Me.username = New System.Windows.Forms.TextBox()
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 26.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Firebrick
        Me.Label2.Location = New System.Drawing.Point(533, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 42)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "STAFF  LOGIN"
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Firebrick
        Me.login_btn.FlatAppearance.BorderSize = 0
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.Location = New System.Drawing.Point(571, 331)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(194, 42)
        Me.login_btn.TabIndex = 49
        Me.login_btn.Tag = ""
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(571, 377)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 47
        '
        'show_password
        '
        Me.show_password.AutoSize = True
        Me.show_password.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.show_password.Location = New System.Drawing.Point(510, 267)
        Me.show_password.Margin = New System.Windows.Forms.Padding(1)
        Me.show_password.Name = "show_password"
        Me.show_password.Size = New System.Drawing.Size(170, 28)
        Me.show_password.TabIndex = 46
        Me.show_password.Text = "Show Password"
        Me.show_password.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(662, 193)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 45
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.password.Location = New System.Drawing.Point(510, 228)
        Me.password.Margin = New System.Windows.Forms.Padding(1)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(380, 32)
        Me.password.TabIndex = 44
        Me.password.UseSystemPasswordChar = True
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.password_lbl.Location = New System.Drawing.Point(393, 236)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(99, 24)
        Me.password_lbl.TabIndex = 43
        Me.password_lbl.Text = "Password"
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.username.Location = New System.Drawing.Point(510, 172)
        Me.username.Margin = New System.Windows.Forms.Padding(1)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(380, 32)
        Me.username.TabIndex = 42
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.username_lbl.Location = New System.Drawing.Point(389, 175)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(103, 24)
        Me.username_lbl.TabIndex = 41
        Me.username_lbl.Text = "Username"
        '
        'StaffLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1302, 517)
        Me.Controls.Add(Me.login_btn)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.show_password)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.password_lbl)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Me.username_lbl)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffLogin"
        Me.Text = "StaffLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents login_btn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents show_password As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents password_lbl As Label
    Friend WithEvents username As TextBox
    Friend WithEvents username_lbl As Label
End Class
