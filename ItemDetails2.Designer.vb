<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ItemDetails2
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
        Me.back_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.item = New System.Windows.Forms.Panel()
        Me.stock_quantity = New System.Windows.Forms.Label()
        Me.stock_desc = New System.Windows.Forms.Label()
        Me.stock_photo = New System.Windows.Forms.Panel()
        Me.stock_id = New System.Windows.Forms.Label()
        Me.stock_name = New System.Windows.Forms.Label()
        Me.Panel26 = New System.Windows.Forms.Panel()
        Me.stock_discount = New System.Windows.Forms.Label()
        Me.stock_price = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.item.SuspendLayout()
        Me.SuspendLayout()
        '
        'back_btn
        '
        Me.back_btn.BackColor = System.Drawing.Color.White
        Me.back_btn.FlatAppearance.BorderSize = 0
        Me.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.back_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.back_btn.ForeColor = System.Drawing.Color.Black
        Me.back_btn.Location = New System.Drawing.Point(302, 586)
        Me.back_btn.Name = "back_btn"
        Me.back_btn.Size = New System.Drawing.Size(194, 42)
        Me.back_btn.TabIndex = 46
        Me.back_btn.Tag = ""
        Me.back_btn.Text = "Back"
        Me.back_btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 371)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 29)
        Me.Label1.TabIndex = 43
        Me.Label1.Tag = ""
        Me.Label1.Text = "REVIEWS"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 403)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(767, 171)
        Me.FlowLayoutPanel1.TabIndex = 45
        '
        'item
        '
        Me.item.BackColor = System.Drawing.Color.White
        Me.item.Controls.Add(Me.stock_id)
        Me.item.Controls.Add(Me.stock_photo)
        Me.item.Controls.Add(Me.stock_quantity)
        Me.item.Controls.Add(Me.stock_desc)
        Me.item.Controls.Add(Me.stock_name)
        Me.item.Controls.Add(Me.Panel26)
        Me.item.Controls.Add(Me.stock_discount)
        Me.item.Controls.Add(Me.stock_price)
        Me.item.Location = New System.Drawing.Point(17, 62)
        Me.item.Name = "item"
        Me.item.Size = New System.Drawing.Size(767, 290)
        Me.item.TabIndex = 44
        '
        'stock_quantity
        '
        Me.stock_quantity.AutoSize = True
        Me.stock_quantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_quantity.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_quantity.Location = New System.Drawing.Point(659, 52)
        Me.stock_quantity.Name = "stock_quantity"
        Me.stock_quantity.Size = New System.Drawing.Size(65, 19)
        Me.stock_quantity.TabIndex = 40
        Me.stock_quantity.Text = "Quantity"
        '
        'stock_desc
        '
        Me.stock_desc.AutoSize = True
        Me.stock_desc.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_desc.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_desc.Location = New System.Drawing.Point(281, 115)
        Me.stock_desc.Name = "stock_desc"
        Me.stock_desc.Size = New System.Drawing.Size(70, 15)
        Me.stock_desc.TabIndex = 38
        Me.stock_desc.Text = "Description"
        '
        'stock_photo
        '
        Me.stock_photo.BackColor = System.Drawing.Color.Transparent
        Me.stock_photo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.stock_photo.Location = New System.Drawing.Point(24, 24)
        Me.stock_photo.Name = "stock_photo"
        Me.stock_photo.Size = New System.Drawing.Size(237, 234)
        Me.stock_photo.TabIndex = 35
        '
        'stock_id
        '
        Me.stock_id.AutoSize = True
        Me.stock_id.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_id.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_id.Location = New System.Drawing.Point(43, 127)
        Me.stock_id.Name = "stock_id"
        Me.stock_id.Size = New System.Drawing.Size(23, 19)
        Me.stock_id.TabIndex = 39
        Me.stock_id.Text = "ID"
        '
        'stock_name
        '
        Me.stock_name.AutoSize = True
        Me.stock_name.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_name.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.stock_name.Location = New System.Drawing.Point(278, 24)
        Me.stock_name.Name = "stock_name"
        Me.stock_name.Size = New System.Drawing.Size(47, 19)
        Me.stock_name.TabIndex = 6
        Me.stock_name.Text = "Name"
        '
        'Panel26
        '
        Me.Panel26.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel26.Location = New System.Drawing.Point(282, 46)
        Me.Panel26.Name = "Panel26"
        Me.Panel26.Size = New System.Drawing.Size(458, 3)
        Me.Panel26.TabIndex = 11
        '
        'stock_discount
        '
        Me.stock_discount.AutoSize = True
        Me.stock_discount.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_discount.ForeColor = System.Drawing.Color.Red
        Me.stock_discount.Location = New System.Drawing.Point(280, 77)
        Me.stock_discount.Name = "stock_discount"
        Me.stock_discount.Size = New System.Drawing.Size(82, 23)
        Me.stock_discount.TabIndex = 7
        Me.stock_discount.Tag = "discount_tag"
        Me.stock_discount.Text = "Discount"
        '
        'stock_price
        '
        Me.stock_price.AutoSize = True
        Me.stock_price.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stock_price.ForeColor = System.Drawing.Color.Black
        Me.stock_price.Location = New System.Drawing.Point(281, 52)
        Me.stock_price.Name = "stock_price"
        Me.stock_price.Size = New System.Drawing.Size(36, 16)
        Me.stock_price.TabIndex = 8
        Me.stock_price.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 29)
        Me.Label2.TabIndex = 47
        Me.Label2.Tag = ""
        Me.Label2.Text = "ITEM DETAILS"
        '
        'ItemDetails2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Firebrick
        Me.ClientSize = New System.Drawing.Size(799, 645)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.back_btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.item)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ItemDetails2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ItemDetails2"
        Me.item.ResumeLayout(False)
        Me.item.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents back_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents item As Panel
    Friend WithEvents stock_desc As Label
    Friend WithEvents stock_photo As Panel
    Friend WithEvents stock_id As Label
    Friend WithEvents stock_name As Label
    Friend WithEvents Panel26 As Panel
    Friend WithEvents stock_discount As Label
    Friend WithEvents stock_price As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents stock_quantity As Label
End Class
