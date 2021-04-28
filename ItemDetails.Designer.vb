<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ItemDetails
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.category_lbl = New System.Windows.Forms.Label()
        Me.Button_Panel = New System.Windows.Forms.Panel()
        Me.specials_panel = New System.Windows.Forms.Panel()
        Me.books_panel = New System.Windows.Forms.Panel()
        Me.BOGOF_panel = New System.Windows.Forms.Panel()
        Me.clothes_panel = New System.Windows.Forms.Panel()
        Me.ecoupon_panel = New System.Windows.Forms.Panel()
        Me.toys_panel = New System.Windows.Forms.Panel()
        Me.toys_btn = New System.Windows.Forms.Button()
        Me.clothes_btn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.books_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.specials_btn = New System.Windows.Forms.Button()
        Me.ecoupon_btn = New System.Windows.Forms.Button()
        Me.BOGOF_btn = New System.Windows.Forms.Button()
        Me.Button_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(252, 85)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1050, 433)
        Me.FlowLayoutPanel1.TabIndex = 15
        Me.FlowLayoutPanel1.Tag = "stock_name"
        '
        'category_lbl
        '
        Me.category_lbl.BackColor = System.Drawing.Color.Transparent
        Me.category_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 26.0!)
        Me.category_lbl.ForeColor = System.Drawing.Color.Firebrick
        Me.category_lbl.Location = New System.Drawing.Point(252, 0)
        Me.category_lbl.Name = "category_lbl"
        Me.category_lbl.Size = New System.Drawing.Size(1050, 82)
        Me.category_lbl.TabIndex = 26
        Me.category_lbl.Text = "HOME"
        Me.category_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button_Panel
        '
        Me.Button_Panel.BackColor = System.Drawing.Color.White
        Me.Button_Panel.Controls.Add(Me.specials_panel)
        Me.Button_Panel.Controls.Add(Me.books_panel)
        Me.Button_Panel.Controls.Add(Me.BOGOF_panel)
        Me.Button_Panel.Controls.Add(Me.clothes_panel)
        Me.Button_Panel.Controls.Add(Me.ecoupon_panel)
        Me.Button_Panel.Controls.Add(Me.toys_panel)
        Me.Button_Panel.Controls.Add(Me.toys_btn)
        Me.Button_Panel.Controls.Add(Me.clothes_btn)
        Me.Button_Panel.Controls.Add(Me.Label8)
        Me.Button_Panel.Controls.Add(Me.books_btn)
        Me.Button_Panel.Controls.Add(Me.Label9)
        Me.Button_Panel.Controls.Add(Me.specials_btn)
        Me.Button_Panel.Controls.Add(Me.ecoupon_btn)
        Me.Button_Panel.Controls.Add(Me.BOGOF_btn)
        Me.Button_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Button_Panel.Name = "Button_Panel"
        Me.Button_Panel.Size = New System.Drawing.Size(249, 518)
        Me.Button_Panel.TabIndex = 27
        '
        'specials_panel
        '
        Me.specials_panel.BackColor = System.Drawing.Color.Firebrick
        Me.specials_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.specials_panel.Location = New System.Drawing.Point(237, 280)
        Me.specials_panel.Name = "specials_panel"
        Me.specials_panel.Size = New System.Drawing.Size(12, 32)
        Me.specials_panel.TabIndex = 30
        '
        'books_panel
        '
        Me.books_panel.BackColor = System.Drawing.Color.Firebrick
        Me.books_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.books_panel.Location = New System.Drawing.Point(237, 121)
        Me.books_panel.Name = "books_panel"
        Me.books_panel.Size = New System.Drawing.Size(12, 32)
        Me.books_panel.TabIndex = 27
        '
        'BOGOF_panel
        '
        Me.BOGOF_panel.BackColor = System.Drawing.Color.Firebrick
        Me.BOGOF_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BOGOF_panel.Location = New System.Drawing.Point(237, 245)
        Me.BOGOF_panel.Name = "BOGOF_panel"
        Me.BOGOF_panel.Size = New System.Drawing.Size(12, 32)
        Me.BOGOF_panel.TabIndex = 29
        '
        'clothes_panel
        '
        Me.clothes_panel.BackColor = System.Drawing.Color.Firebrick
        Me.clothes_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.clothes_panel.Location = New System.Drawing.Point(237, 85)
        Me.clothes_panel.Name = "clothes_panel"
        Me.clothes_panel.Size = New System.Drawing.Size(12, 32)
        Me.clothes_panel.TabIndex = 26
        '
        'ecoupon_panel
        '
        Me.ecoupon_panel.BackColor = System.Drawing.Color.Firebrick
        Me.ecoupon_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ecoupon_panel.Location = New System.Drawing.Point(237, 210)
        Me.ecoupon_panel.Name = "ecoupon_panel"
        Me.ecoupon_panel.Size = New System.Drawing.Size(12, 32)
        Me.ecoupon_panel.TabIndex = 28
        '
        'toys_panel
        '
        Me.toys_panel.BackColor = System.Drawing.Color.Firebrick
        Me.toys_panel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.toys_panel.Location = New System.Drawing.Point(237, 50)
        Me.toys_panel.Name = "toys_panel"
        Me.toys_panel.Size = New System.Drawing.Size(12, 32)
        Me.toys_panel.TabIndex = 25
        '
        'toys_btn
        '
        Me.toys_btn.BackColor = System.Drawing.Color.White
        Me.toys_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.toys_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toys_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.toys_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.toys_btn.Location = New System.Drawing.Point(-3, 50)
        Me.toys_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.toys_btn.Name = "toys_btn"
        Me.toys_btn.Size = New System.Drawing.Size(252, 36)
        Me.toys_btn.TabIndex = 16
        Me.toys_btn.Text = "Toys"
        Me.toys_btn.UseVisualStyleBackColor = False
        '
        'clothes_btn
        '
        Me.clothes_btn.BackColor = System.Drawing.Color.White
        Me.clothes_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.clothes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.clothes_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.clothes_btn.Location = New System.Drawing.Point(-3, 85)
        Me.clothes_btn.Name = "clothes_btn"
        Me.clothes_btn.Size = New System.Drawing.Size(251, 36)
        Me.clothes_btn.TabIndex = 17
        Me.clothes_btn.Text = "Clothes"
        Me.clothes_btn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Firebrick
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(249, 36)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "CATEGORY"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'books_btn
        '
        Me.books_btn.BackColor = System.Drawing.Color.White
        Me.books_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.books_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.books_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.books_btn.Location = New System.Drawing.Point(-3, 120)
        Me.books_btn.Name = "books_btn"
        Me.books_btn.Size = New System.Drawing.Size(251, 36)
        Me.books_btn.TabIndex = 18
        Me.books_btn.Text = "Books"
        Me.books_btn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Firebrick
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(-1, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(249, 36)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "DEALS"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'specials_btn
        '
        Me.specials_btn.BackColor = System.Drawing.Color.White
        Me.specials_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.specials_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.specials_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.specials_btn.Location = New System.Drawing.Point(-3, 280)
        Me.specials_btn.Name = "specials_btn"
        Me.specials_btn.Size = New System.Drawing.Size(251, 36)
        Me.specials_btn.TabIndex = 24
        Me.specials_btn.Text = "Weekend Specials"
        Me.specials_btn.UseVisualStyleBackColor = False
        '
        'ecoupon_btn
        '
        Me.ecoupon_btn.BackColor = System.Drawing.Color.White
        Me.ecoupon_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.ecoupon_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ecoupon_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.ecoupon_btn.Location = New System.Drawing.Point(-3, 211)
        Me.ecoupon_btn.Name = "ecoupon_btn"
        Me.ecoupon_btn.Size = New System.Drawing.Size(251, 36)
        Me.ecoupon_btn.TabIndex = 22
        Me.ecoupon_btn.Text = "e-Coupons"
        Me.ecoupon_btn.UseVisualStyleBackColor = False
        '
        'BOGOF_btn
        '
        Me.BOGOF_btn.BackColor = System.Drawing.Color.White
        Me.BOGOF_btn.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray
        Me.BOGOF_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BOGOF_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 12.0!)
        Me.BOGOF_btn.Location = New System.Drawing.Point(-3, 246)
        Me.BOGOF_btn.Name = "BOGOF_btn"
        Me.BOGOF_btn.Size = New System.Drawing.Size(251, 36)
        Me.BOGOF_btn.TabIndex = 23
        Me.BOGOF_btn.Text = "Buy 1 Free 1 (BOGOF)"
        Me.BOGOF_btn.UseVisualStyleBackColor = False
        '
        'ItemDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1302, 517)
        Me.Controls.Add(Me.Button_Panel)
        Me.Controls.Add(Me.category_lbl)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemDetails"
        Me.Text = "ItemDetails"
        Me.Button_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents category_lbl As Label
    Friend WithEvents Button_Panel As Panel
    Friend WithEvents specials_panel As Panel
    Friend WithEvents books_panel As Panel
    Friend WithEvents BOGOF_panel As Panel
    Friend WithEvents clothes_panel As Panel
    Friend WithEvents ecoupon_panel As Panel
    Friend WithEvents toys_panel As Panel
    Friend WithEvents toys_btn As Button
    Friend WithEvents clothes_btn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents books_btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents specials_btn As Button
    Friend WithEvents ecoupon_btn As Button
    Friend WithEvents BOGOF_btn As Button
End Class
