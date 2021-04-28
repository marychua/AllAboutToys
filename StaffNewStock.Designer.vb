<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffNewStock
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
        Me.newstock = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.stock_discount = New System.Windows.Forms.Label()
        Me.stock_photo = New System.Windows.Forms.Panel()
        Me.stock_desc = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stock_category = New System.Windows.Forms.Label()
        Me.stock_price = New System.Windows.Forms.Label()
        Me.stock_name = New System.Windows.Forms.Label()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.stock_id = New System.Windows.Forms.Label()
        Me.stock_quantity = New System.Windows.Forms.Label()
        Me.newstock.SuspendLayout()
        Me.SuspendLayout()
        '
        'newstock
        '
        Me.newstock.BackColor = System.Drawing.Color.White
        Me.newstock.Controls.Add(Me.stock_photo)
        Me.newstock.Controls.Add(Me.Label2)
        Me.newstock.Controls.Add(Me.stock_discount)
        Me.newstock.Controls.Add(Me.Label1)
        Me.newstock.Controls.Add(Me.stock_price)
        Me.newstock.Controls.Add(Me.stock_name)
        Me.newstock.Controls.Add(Me.add_btn)
        Me.newstock.Controls.Add(Me.stock_desc)
        Me.newstock.Controls.Add(Me.stock_category)
        Me.newstock.Controls.Add(Me.stock_id)
        Me.newstock.Controls.Add(Me.stock_quantity)
        Me.newstock.Location = New System.Drawing.Point(27, 15)
        Me.newstock.Margin = New System.Windows.Forms.Padding(18)
        Me.newstock.Name = "newstock"
        Me.newstock.Size = New System.Drawing.Size(220, 313)
        Me.newstock.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "RM"
        '
        'stock_discount
        '
        Me.stock_discount.AutoSize = True
        Me.stock_discount.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_discount.ForeColor = System.Drawing.Color.Red
        Me.stock_discount.Location = New System.Drawing.Point(88, 279)
        Me.stock_discount.Name = "stock_discount"
        Me.stock_discount.Size = New System.Drawing.Size(82, 23)
        Me.stock_discount.TabIndex = 7
        Me.stock_discount.Text = "Discount"
        '
        'stock_photo
        '
        Me.stock_photo.BackColor = System.Drawing.Color.Transparent
        Me.stock_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stock_photo.Location = New System.Drawing.Point(11, 17)
        Me.stock_photo.Name = "stock_photo"
        Me.stock_photo.Size = New System.Drawing.Size(194, 175)
        Me.stock_photo.TabIndex = 42
        '
        'stock_desc
        '
        Me.stock_desc.AutoSize = True
        Me.stock_desc.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_desc.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_desc.Location = New System.Drawing.Point(27, 127)
        Me.stock_desc.Name = "stock_desc"
        Me.stock_desc.Size = New System.Drawing.Size(30, 13)
        Me.stock_desc.TabIndex = 9
        Me.stock_desc.Tag = ""
        Me.stock_desc.Text = "Desc"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(58, 279)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "RM"
        '
        'stock_category
        '
        Me.stock_category.AutoSize = True
        Me.stock_category.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_category.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_category.Location = New System.Drawing.Point(27, 99)
        Me.stock_category.Name = "stock_category"
        Me.stock_category.Size = New System.Drawing.Size(49, 13)
        Me.stock_category.TabIndex = 8
        Me.stock_category.Tag = ""
        Me.stock_category.Text = "Category"
        '
        'stock_price
        '
        Me.stock_price.AutoSize = True
        Me.stock_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_price.ForeColor = System.Drawing.Color.Black
        Me.stock_price.Location = New System.Drawing.Point(31, 262)
        Me.stock_price.Name = "stock_price"
        Me.stock_price.Size = New System.Drawing.Size(36, 16)
        Me.stock_price.TabIndex = 8
        Me.stock_price.Text = "Price"
        '
        'stock_name
        '
        Me.stock_name.AutoSize = True
        Me.stock_name.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_name.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_name.Location = New System.Drawing.Point(8, 246)
        Me.stock_name.Name = "stock_name"
        Me.stock_name.Size = New System.Drawing.Size(38, 15)
        Me.stock_name.TabIndex = 6
        Me.stock_name.Tag = "stock_name"
        Me.stock_name.Text = "Name"
        '
        'add_btn
        '
        Me.add_btn.BackColor = System.Drawing.Color.Firebrick
        Me.add_btn.FlatAppearance.BorderSize = 0
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.Color.White
        Me.add_btn.Location = New System.Drawing.Point(11, 198)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(194, 42)
        Me.add_btn.TabIndex = 2
        Me.add_btn.Tag = "addtocart_btn"
        Me.add_btn.Text = "Add to Cart"
        Me.add_btn.UseVisualStyleBackColor = False
        '
        'stock_id
        '
        Me.stock_id.AutoSize = True
        Me.stock_id.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_id.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_id.Location = New System.Drawing.Point(27, 84)
        Me.stock_id.Name = "stock_id"
        Me.stock_id.Size = New System.Drawing.Size(17, 13)
        Me.stock_id.TabIndex = 7
        Me.stock_id.Tag = ""
        Me.stock_id.Text = "ID"
        '
        'stock_quantity
        '
        Me.stock_quantity.AutoSize = True
        Me.stock_quantity.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_quantity.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_quantity.Location = New System.Drawing.Point(27, 114)
        Me.stock_quantity.Name = "stock_quantity"
        Me.stock_quantity.Size = New System.Drawing.Size(47, 13)
        Me.stock_quantity.TabIndex = 41
        Me.stock_quantity.Text = "Quantity"
        '
        'StaffNewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(289, 350)
        Me.Controls.Add(Me.newstock)
        Me.Name = "StaffNewStock"
        Me.Text = "StaffNewStock"
        Me.newstock.ResumeLayout(False)
        Me.newstock.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents newstock As Panel
    Friend WithEvents stock_price As Label
    Friend WithEvents stock_discount As Label
    Friend WithEvents stock_name As Label
    Friend WithEvents add_btn As Button
    Friend WithEvents stock_id As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents stock_category As Label
    Friend WithEvents stock_desc As Label
    Friend WithEvents stock_quantity As Label
    Friend WithEvents stock_photo As Panel
    Friend WithEvents Label2 As Label
End Class
