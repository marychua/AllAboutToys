<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Payment
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
        Me.apply_btn = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.creditcard = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.coupon = New System.Windows.Forms.TextBox()
        Me.password_lbl = New System.Windows.Forms.Label()
        Me.username_lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.totalprice = New System.Windows.Forms.Label()
        Me.checkout_btn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.finalprice = New System.Windows.Forms.TextBox()
        Me.coupon_valid = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiBold", 26.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(253, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 42)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "PAYMENT"
        '
        'apply_btn
        '
        Me.apply_btn.BackColor = System.Drawing.Color.Firebrick
        Me.apply_btn.FlatAppearance.BorderSize = 0
        Me.apply_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.apply_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.apply_btn.ForeColor = System.Drawing.Color.White
        Me.apply_btn.Location = New System.Drawing.Point(443, 77)
        Me.apply_btn.Name = "apply_btn"
        Me.apply_btn.Size = New System.Drawing.Size(124, 32)
        Me.apply_btn.TabIndex = 39
        Me.apply_btn.Tag = ""
        Me.apply_btn.Text = "Apply"
        Me.apply_btn.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(248, 236)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(0, 13)
        Me.LinkLabel1.TabIndex = 37
        '
        'creditcard
        '
        Me.creditcard.AutoSize = True
        Me.creditcard.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.creditcard.Location = New System.Drawing.Point(231, 261)
        Me.creditcard.Margin = New System.Windows.Forms.Padding(1)
        Me.creditcard.Name = "creditcard"
        Me.creditcard.Size = New System.Drawing.Size(130, 28)
        Me.creditcard.TabIndex = 36
        Me.creditcard.Text = "Credit Card"
        Me.creditcard.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 31)
        Me.Label1.TabIndex = 35
        '
        'coupon
        '
        Me.coupon.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.coupon.Location = New System.Drawing.Point(231, 78)
        Me.coupon.Margin = New System.Windows.Forms.Padding(1)
        Me.coupon.Name = "coupon"
        Me.coupon.Size = New System.Drawing.Size(208, 32)
        Me.coupon.TabIndex = 34
        '
        'password_lbl
        '
        Me.password_lbl.AutoSize = True
        Me.password_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.password_lbl.Location = New System.Drawing.Point(84, 78)
        Me.password_lbl.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.password_lbl.Name = "password_lbl"
        Me.password_lbl.Size = New System.Drawing.Size(125, 24)
        Me.password_lbl.TabIndex = 33
        Me.password_lbl.Text = "Coupon Code"
        '
        'username_lbl
        '
        Me.username_lbl.AutoSize = True
        Me.username_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.username_lbl.Location = New System.Drawing.Point(105, 34)
        Me.username_lbl.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.username_lbl.Name = "username_lbl"
        Me.username_lbl.Size = New System.Drawing.Size(104, 24)
        Me.username_lbl.TabIndex = 31
        Me.username_lbl.Text = "Total Price"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cancel_btn)
        Me.Panel1.Controls.Add(Me.totalprice)
        Me.Panel1.Controls.Add(Me.checkout_btn)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.finalprice)
        Me.Panel1.Controls.Add(Me.coupon_valid)
        Me.Panel1.Controls.Add(Me.username_lbl)
        Me.Panel1.Controls.Add(Me.apply_btn)
        Me.Panel1.Controls.Add(Me.password_lbl)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.coupon)
        Me.Panel1.Controls.Add(Me.creditcard)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(33, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(633, 407)
        Me.Panel1.TabIndex = 41
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.Firebrick
        Me.cancel_btn.FlatAppearance.BorderSize = 0
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.White
        Me.cancel_btn.Location = New System.Drawing.Point(61, 331)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(187, 36)
        Me.cancel_btn.TabIndex = 49
        Me.cancel_btn.Tag = ""
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'totalprice
        '
        Me.totalprice.AutoSize = True
        Me.totalprice.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.totalprice.Location = New System.Drawing.Point(233, 34)
        Me.totalprice.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.totalprice.Name = "totalprice"
        Me.totalprice.Size = New System.Drawing.Size(50, 24)
        Me.totalprice.TabIndex = 48
        Me.totalprice.Text = "RM0"
        '
        'checkout_btn
        '
        Me.checkout_btn.BackColor = System.Drawing.Color.Firebrick
        Me.checkout_btn.FlatAppearance.BorderSize = 0
        Me.checkout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.checkout_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkout_btn.ForeColor = System.Drawing.Color.White
        Me.checkout_btn.Location = New System.Drawing.Point(387, 331)
        Me.checkout_btn.Name = "checkout_btn"
        Me.checkout_btn.Size = New System.Drawing.Size(187, 36)
        Me.checkout_btn.TabIndex = 46
        Me.checkout_btn.Tag = ""
        Me.checkout_btn.Text = "Checkout"
        Me.checkout_btn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(50, 261)
        Me.Label6.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 24)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Payment Method"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(148, 211)
        Me.Label5.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Email"
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.email.Location = New System.Drawing.Point(231, 203)
        Me.email.Margin = New System.Windows.Forms.Padding(1)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(336, 32)
        Me.email.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(105, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Final Price"
        '
        'finalprice
        '
        Me.finalprice.Font = New System.Drawing.Font("Bahnschrift SemiBold", 15.0!)
        Me.finalprice.Location = New System.Drawing.Point(231, 143)
        Me.finalprice.Margin = New System.Windows.Forms.Padding(1)
        Me.finalprice.Name = "finalprice"
        Me.finalprice.Size = New System.Drawing.Size(336, 32)
        Me.finalprice.TabIndex = 42
        '
        'coupon_valid
        '
        Me.coupon_valid.AutoSize = True
        Me.coupon_valid.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.coupon_valid.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.coupon_valid.Location = New System.Drawing.Point(234, 111)
        Me.coupon_valid.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.coupon_valid.Name = "coupon_valid"
        Me.coupon_valid.Size = New System.Drawing.Size(118, 18)
        Me.coupon_valid.TabIndex = 40
        Me.coupon_valid.Text = "Coupon Successful"
        Me.coupon_valid.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(-1, -2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 85)
        Me.Panel2.TabIndex = 42
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 530)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents apply_btn As Button
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents creditcard As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents coupon As TextBox
    Friend WithEvents password_lbl As Label
    Friend WithEvents username_lbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents email As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents finalprice As TextBox
    Friend WithEvents coupon_valid As Label
    Friend WithEvents totalprice As Label
    Friend WithEvents checkout_btn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cancel_btn As Button
End Class
