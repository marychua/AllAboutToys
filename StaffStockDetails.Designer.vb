<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StaffStockDetails
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Clr_btn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.photo = New System.Windows.Forms.TextBox()
        Me.stockCategory = New System.Windows.Forms.ComboBox()
        Me.stockinID = New System.Windows.Forms.Label()
        Me.stockDesc = New System.Windows.Forms.RichTextBox()
        Me.stockIn_date = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.update_btn = New System.Windows.Forms.Button()
        Me.staffID = New System.Windows.Forms.TextBox()
        Me.delete_btn = New System.Windows.Forms.Button()
        Me.add_btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.stockQuantity = New System.Windows.Forms.TextBox()
        Me.stockPrice = New System.Windows.Forms.TextBox()
        Me.stockName = New System.Windows.Forms.TextBox()
        Me.stockID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkRed
        Me.Panel2.Controls.Add(Me.Clr_btn)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.browse_btn)
        Me.Panel2.Controls.Add(Me.photo)
        Me.Panel2.Controls.Add(Me.stockCategory)
        Me.Panel2.Controls.Add(Me.stockinID)
        Me.Panel2.Controls.Add(Me.stockDesc)
        Me.Panel2.Controls.Add(Me.stockIn_date)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.update_btn)
        Me.Panel2.Controls.Add(Me.staffID)
        Me.Panel2.Controls.Add(Me.delete_btn)
        Me.Panel2.Controls.Add(Me.add_btn)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.stockQuantity)
        Me.Panel2.Controls.Add(Me.stockPrice)
        Me.Panel2.Controls.Add(Me.stockName)
        Me.Panel2.Controls.Add(Me.stockID)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(12, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(593, 445)
        Me.Panel2.TabIndex = 24
        '
        'Clr_btn
        '
        Me.Clr_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Clr_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clr_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clr_btn.ForeColor = System.Drawing.Color.White
        Me.Clr_btn.Location = New System.Drawing.Point(435, 384)
        Me.Clr_btn.Name = "Clr_btn"
        Me.Clr_btn.Size = New System.Drawing.Size(119, 36)
        Me.Clr_btn.TabIndex = 39
        Me.Clr_btn.Text = "Clear"
        Me.Clr_btn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Enabled = False
        Me.PictureBox1.Location = New System.Drawing.Point(398, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 197)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(395, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 16)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Stock_Picture"
        '
        'browse_btn
        '
        Me.browse_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.browse_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.browse_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.browse_btn.ForeColor = System.Drawing.Color.White
        Me.browse_btn.Location = New System.Drawing.Point(398, 318)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(89, 25)
        Me.browse_btn.TabIndex = 37
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = True
        '
        'photo
        '
        Me.photo.Enabled = False
        Me.photo.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.photo.Location = New System.Drawing.Point(398, 287)
        Me.photo.Name = "photo"
        Me.photo.Size = New System.Drawing.Size(170, 25)
        Me.photo.TabIndex = 36
        '
        'stockCategory
        '
        Me.stockCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.stockCategory.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!)
        Me.stockCategory.FormattingEnabled = True
        Me.stockCategory.Items.AddRange(New Object() {"Toys", "Clothes", "Books"})
        Me.stockCategory.Location = New System.Drawing.Point(123, 296)
        Me.stockCategory.Name = "stockCategory"
        Me.stockCategory.Size = New System.Drawing.Size(253, 25)
        Me.stockCategory.TabIndex = 35
        '
        'stockinID
        '
        Me.stockinID.AutoSize = True
        Me.stockinID.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockinID.ForeColor = System.Drawing.Color.White
        Me.stockinID.Location = New System.Drawing.Point(52, 24)
        Me.stockinID.Name = "stockinID"
        Me.stockinID.Size = New System.Drawing.Size(61, 16)
        Me.stockinID.TabIndex = 34
        Me.stockinID.Text = "StockIn_ID"
        '
        'stockDesc
        '
        Me.stockDesc.Location = New System.Drawing.Point(123, 185)
        Me.stockDesc.Name = "stockDesc"
        Me.stockDesc.Size = New System.Drawing.Size(253, 61)
        Me.stockDesc.TabIndex = 33
        Me.stockDesc.Text = ""
        '
        'stockIn_date
        '
        Me.stockIn_date.Enabled = False
        Me.stockIn_date.Location = New System.Drawing.Point(123, 82)
        Me.stockIn_date.Name = "stockIn_date"
        Me.stockIn_date.Size = New System.Drawing.Size(253, 20)
        Me.stockIn_date.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(39, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "StockIn_Date"
        '
        'update_btn
        '
        Me.update_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.update_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.update_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update_btn.ForeColor = System.Drawing.Color.White
        Me.update_btn.Location = New System.Drawing.Point(296, 384)
        Me.update_btn.Name = "update_btn"
        Me.update_btn.Size = New System.Drawing.Size(119, 36)
        Me.update_btn.TabIndex = 18
        Me.update_btn.Text = "Update"
        Me.update_btn.UseVisualStyleBackColor = True
        '
        'staffID
        '
        Me.staffID.Enabled = False
        Me.staffID.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffID.Location = New System.Drawing.Point(123, 46)
        Me.staffID.Name = "staffID"
        Me.staffID.Size = New System.Drawing.Size(253, 25)
        Me.staffID.TabIndex = 29
        '
        'delete_btn
        '
        Me.delete_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete_btn.ForeColor = System.Drawing.Color.White
        Me.delete_btn.Location = New System.Drawing.Point(163, 384)
        Me.delete_btn.Name = "delete_btn"
        Me.delete_btn.Size = New System.Drawing.Size(119, 36)
        Me.delete_btn.TabIndex = 17
        Me.delete_btn.Text = "Delete"
        Me.delete_btn.UseVisualStyleBackColor = True
        '
        'add_btn
        '
        Me.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.add_btn.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_btn.ForeColor = System.Drawing.Color.White
        Me.add_btn.Location = New System.Drawing.Point(28, 384)
        Me.add_btn.Name = "add_btn"
        Me.add_btn.Size = New System.Drawing.Size(119, 36)
        Me.add_btn.TabIndex = 16
        Me.add_btn.Text = "Add"
        Me.add_btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(65, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Staff_ID"
        '
        'stockQuantity
        '
        Me.stockQuantity.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockQuantity.Location = New System.Drawing.Point(123, 258)
        Me.stockQuantity.Name = "stockQuantity"
        Me.stockQuantity.Size = New System.Drawing.Size(253, 25)
        Me.stockQuantity.TabIndex = 11
        '
        'stockPrice
        '
        Me.stockPrice.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockPrice.Location = New System.Drawing.Point(123, 334)
        Me.stockPrice.Name = "stockPrice"
        Me.stockPrice.Size = New System.Drawing.Size(253, 25)
        Me.stockPrice.TabIndex = 9
        '
        'stockName
        '
        Me.stockName.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockName.Location = New System.Drawing.Point(123, 150)
        Me.stockName.Name = "stockName"
        Me.stockName.Size = New System.Drawing.Size(253, 25)
        Me.stockName.TabIndex = 7
        '
        'stockID
        '
        Me.stockID.Enabled = False
        Me.stockID.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockID.Location = New System.Drawing.Point(123, 113)
        Me.stockID.Name = "stockID"
        Me.stockID.Size = New System.Drawing.Size(253, 25)
        Me.stockID.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(44, 338)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Stock_Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(25, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Stock_Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(33, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Stock_Quantity"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(19, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Stock_Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(42, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Stock_Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift SemiLight SemiConde", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(61, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock_ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bahnschrift", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 23)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Stock Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(599, 39)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(395, 445)
        Me.DataGridView1.TabIndex = 22
        '
        'StaffStockDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 517)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffStockDetails"
        Me.Text = "StaffStockDetails"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents update_btn As Button
    Friend WithEvents delete_btn As Button
    Friend WithEvents add_btn As Button
    Friend WithEvents stockQuantity As TextBox
    Friend WithEvents stockPrice As TextBox
    Friend WithEvents stockName As TextBox
    Friend WithEvents stockID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents staffID As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents stockIn_date As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents stockDesc As RichTextBox
    Friend WithEvents stockinID As Label
    Friend WithEvents stockCategory As ComboBox
    Friend WithEvents photo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents browse_btn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Clr_btn As Button
End Class
