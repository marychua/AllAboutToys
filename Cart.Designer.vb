<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart
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
        Me.Category_lbl = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.temp = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.buy_btn = New System.Windows.Forms.Button()
        Me.amount = New System.Windows.Forms.Label()
        Me.noitems_panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.history_btn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.noitems_panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Category_lbl
        '
        Me.Category_lbl.BackColor = System.Drawing.Color.Transparent
        Me.Category_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Category_lbl.ForeColor = System.Drawing.Color.Firebrick
        Me.Category_lbl.Location = New System.Drawing.Point(135, 9)
        Me.Category_lbl.Name = "Category_lbl"
        Me.Category_lbl.Size = New System.Drawing.Size(1050, 82)
        Me.Category_lbl.TabIndex = 31
        Me.Category_lbl.Text = "My Shopping Cart"
        Me.Category_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(9, 32)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(845, 373)
        Me.FlowLayoutPanel1.TabIndex = 43
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.temp)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.noitems_panel)
        Me.Panel1.Location = New System.Drawing.Point(3, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1287, 449)
        Me.Panel1.TabIndex = 44
        '
        'temp
        '
        Me.temp.AutoSize = True
        Me.temp.Location = New System.Drawing.Point(885, 426)
        Me.temp.Name = "temp"
        Me.temp.Size = New System.Drawing.Size(33, 13)
        Me.temp.TabIndex = 4
        Me.temp.Text = "Index"
        Me.temp.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.ListBox1)
        Me.Panel2.Controls.Add(Me.buy_btn)
        Me.Panel2.Controls.Add(Me.amount)
        Me.Panel2.Location = New System.Drawing.Point(852, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(412, 373)
        Me.Panel2.TabIndex = 45
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(19, 29)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(370, 251)
        Me.ListBox1.TabIndex = 0
        '
        'buy_btn
        '
        Me.buy_btn.BackColor = System.Drawing.Color.Firebrick
        Me.buy_btn.FlatAppearance.BorderSize = 0
        Me.buy_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buy_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buy_btn.ForeColor = System.Drawing.Color.White
        Me.buy_btn.Location = New System.Drawing.Point(236, 292)
        Me.buy_btn.Name = "buy_btn"
        Me.buy_btn.Size = New System.Drawing.Size(119, 42)
        Me.buy_btn.TabIndex = 3
        Me.buy_btn.Tag = ""
        Me.buy_btn.Text = "Buy Now"
        Me.buy_btn.UseVisualStyleBackColor = False
        '
        'amount
        '
        Me.amount.AutoSize = True
        Me.amount.Location = New System.Drawing.Point(70, 308)
        Me.amount.Name = "amount"
        Me.amount.Size = New System.Drawing.Size(43, 13)
        Me.amount.TabIndex = 0
        Me.amount.Text = "Amount"
        '
        'noitems_panel
        '
        Me.noitems_panel.Controls.Add(Me.Label1)
        Me.noitems_panel.Location = New System.Drawing.Point(9, 25)
        Me.noitems_panel.Name = "noitems_panel"
        Me.noitems_panel.Size = New System.Drawing.Size(1261, 398)
        Me.noitems_panel.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiBold", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Firebrick
        Me.Label1.Location = New System.Drawing.Point(105, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1050, 82)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "You have no items in your cart"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'history_btn
        '
        Me.history_btn.BackColor = System.Drawing.Color.Firebrick
        Me.history_btn.FlatAppearance.BorderSize = 0
        Me.history_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.history_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history_btn.ForeColor = System.Drawing.Color.White
        Me.history_btn.Location = New System.Drawing.Point(26, 21)
        Me.history_btn.Name = "history_btn"
        Me.history_btn.Size = New System.Drawing.Size(119, 42)
        Me.history_btn.TabIndex = 5
        Me.history_btn.Tag = "addtocart_btn"
        Me.history_btn.Text = "History"
        Me.history_btn.UseVisualStyleBackColor = False
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1302, 517)
        Me.Controls.Add(Me.history_btn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Category_lbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cart"
        Me.Text = "Cart"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.noitems_panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Category_lbl As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents amount As Label
    Friend WithEvents buy_btn As Button
    Friend WithEvents temp As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents noitems_panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents history_btn As Button
End Class
