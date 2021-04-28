<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewItem
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
        Me.myitem = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.Label()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.pic = New System.Windows.Forms.Panel()
        Me.lblAmount13 = New System.Windows.Forms.Label()
        Me.PShip25 = New System.Windows.Forms.Panel()
        Me.Label111 = New System.Windows.Forms.Label()
        Me.shp1 = New System.Windows.Forms.Label()
        Me.shipping_lbl = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.quantity_lbl = New System.Windows.Forms.Label()
        Me.quantity_count = New System.Windows.Forms.NumericUpDown()
        Me.dprice = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.discount = New System.Windows.Forms.Label()
        Me.stock_name = New System.Windows.Forms.Label()
        Me.myitem.SuspendLayout()
        Me.PShip25.SuspendLayout()
        CType(Me.quantity_count, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'myitem
        '
        Me.myitem.BackColor = System.Drawing.Color.White
        Me.myitem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myitem.Controls.Add(Me.Label2)
        Me.myitem.Controls.Add(Me.Label1)
        Me.myitem.Controls.Add(Me.id)
        Me.myitem.Controls.Add(Me.delete_btn)
        Me.myitem.Controls.Add(Me.pic)
        Me.myitem.Controls.Add(Me.lblAmount13)
        Me.myitem.Controls.Add(Me.PShip25)
        Me.myitem.Controls.Add(Me.shipping_lbl)
        Me.myitem.Controls.Add(Me.Panel26)
        Me.myitem.Controls.Add(Me.quantity_lbl)
        Me.myitem.Controls.Add(Me.quantity_count)
        Me.myitem.Controls.Add(Me.dprice)
        Me.myitem.Controls.Add(Me.price)
        Me.myitem.Controls.Add(Me.discount)
        Me.myitem.Controls.Add(Me.stock_name)
        Me.myitem.Location = New System.Drawing.Point(1, 12)
        Me.myitem.Name = "myitem"
        Me.myitem.Size = New System.Drawing.Size(803, 321)
        Me.myitem.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(313, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 23)
        Me.Label2.TabIndex = 39
        Me.Label2.Tag = ""
        Me.Label2.Text = "RM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "RM"
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(40, 23)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(18, 13)
        Me.id.TabIndex = 37
        Me.id.Text = "ID"
        '
        'delete_btn
        '
        Me.delete_btn.BackColor = System.Drawing.Color.Firebrick
        Me.delete_btn.FlatAppearance.BorderSize = 0
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(675, 3)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(100, 36)
        Me.delete_btn.TabIndex = 36
        Me.delete_btn.Tag = "addtocart_btn"
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = False
        '
        'pic
        '
        Me.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pic.Location = New System.Drawing.Point(43, 45)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(237, 234)
        Me.pic.TabIndex = 35
        '
        'lblAmount13
        '
        Me.lblAmount13.AutoSize = True
        Me.lblAmount13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount13.ForeColor = System.Drawing.Color.Red
        Me.lblAmount13.Location = New System.Drawing.Point(696, 279)
        Me.lblAmount13.Name = "lblAmount13"
        Me.lblAmount13.Size = New System.Drawing.Size(0, 23)
        Me.lblAmount13.TabIndex = 33
        '
        'PShip25
        '
        Me.PShip25.Controls.Add(Me.Label111)
        Me.PShip25.Controls.Add(Me.shp1)
        Me.PShip25.Location = New System.Drawing.Point(422, 124)
        Me.PShip25.Name = "PShip25"
        Me.PShip25.Size = New System.Drawing.Size(129, 44)
        Me.PShip25.TabIndex = 14
        '
        'Label111
        '
        Me.Label111.AutoSize = True
        Me.Label111.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label111.Location = New System.Drawing.Point(3, 17)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(104, 15)
        Me.Label111.TabIndex = 17
        Me.Label111.Text = "Economy Delivery"
        '
        'shp1
        '
        Me.shp1.AutoSize = True
        Me.shp1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shp1.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.shp1.Location = New System.Drawing.Point(3, 2)
        Me.shp1.Name = "shp1"
        Me.shp1.Size = New System.Drawing.Size(49, 15)
        Me.shp1.TabIndex = 16
        Me.shp1.Text = "RM3.80"
        '
        'shipping_lbl
        '
        Me.shipping_lbl.AutoSize = True
        Me.shipping_lbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.shipping_lbl.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.shipping_lbl.Location = New System.Drawing.Point(316, 124)
        Me.shipping_lbl.Name = "shipping_lbl"
        Me.shipping_lbl.Size = New System.Drawing.Size(100, 15)
        Me.shipping_lbl.TabIndex = 12
        Me.shipping_lbl.Text = "Shipping Method"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel26.Location = New System.Drawing.Point(317, 45)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(458, 3)
        Me.Panel26.TabIndex = 11
        '
        'quantity_lbl
        '
        Me.quantity_lbl.AutoSize = True
        Me.quantity_lbl.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity_lbl.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.quantity_lbl.Location = New System.Drawing.Point(362, 189)
        Me.quantity_lbl.Name = "quantity_lbl"
        Me.quantity_lbl.Size = New System.Drawing.Size(54, 15)
        Me.quantity_lbl.TabIndex = 10
        Me.quantity_lbl.Text = "Quantity"
        '
        'quantity_count
        '
        Me.quantity_count.Location = New System.Drawing.Point(422, 188)
        Me.quantity_count.Name = "quantity_count"
        Me.quantity_count.Size = New System.Drawing.Size(69, 20)
        Me.quantity_count.TabIndex = 9
        '
        'dprice
        '
        Me.dprice.AutoSize = True
        Me.dprice.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dprice.ForeColor = System.Drawing.Color.Black
        Me.dprice.Location = New System.Drawing.Point(378, 59)
        Me.dprice.Name = "dprice"
        Me.dprice.Size = New System.Drawing.Size(36, 16)
        Me.dprice.TabIndex = 8
        Me.dprice.Text = "Price"
        Me.dprice.Visible = False
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.ForeColor = System.Drawing.Color.Black
        Me.price.Location = New System.Drawing.Point(336, 59)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(36, 16)
        Me.price.TabIndex = 8
        Me.price.Text = "Price"
        '
        'discount
        '
        Me.discount.AutoSize = True
        Me.discount.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.discount.ForeColor = System.Drawing.Color.Red
        Me.discount.Location = New System.Drawing.Point(347, 88)
        Me.discount.Name = "discount"
        Me.discount.Size = New System.Drawing.Size(82, 23)
        Me.discount.TabIndex = 7
        Me.discount.Tag = "discount_tag"
        Me.discount.Text = "Discount"
        '
        'stock_name
        '
        Me.stock_name.AutoSize = True
        Me.stock_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_name.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_name.Location = New System.Drawing.Point(313, 23)
        Me.stock_name.Name = "stock_name"
        Me.stock_name.Size = New System.Drawing.Size(47, 19)
        Me.stock_name.TabIndex = 6
        Me.stock_name.Text = "Name"
        '
        'NewItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 342)
        Me.Controls.Add(Me.myitem)
        Me.Name = "NewItem"
        Me.Text = "NewItem"
        Me.myitem.ResumeLayout(False)
        Me.myitem.PerformLayout()
        Me.PShip25.ResumeLayout(False)
        Me.PShip25.PerformLayout()
        CType(Me.quantity_count, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myitem As Panel
    Friend WithEvents delete_btn As Button
    Friend WithEvents pic As Panel
    Friend WithEvents lblAmount13 As Label
    Friend WithEvents PShip25 As Panel
    Friend WithEvents Label111 As Label
    Friend WithEvents shp1 As Label
    Friend WithEvents shipping_lbl As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents quantity_lbl As Label
    Friend WithEvents quantity_count As NumericUpDown
    Friend WithEvents price As Label
    Friend WithEvents discount As Label
    Friend WithEvents stock_name As Label
    Friend WithEvents dprice As Label
    Friend WithEvents id As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
