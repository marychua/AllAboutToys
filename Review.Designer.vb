﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Review))
        Me.anonymous = New System.Windows.Forms.CheckBox()
        Me.review_desc = New System.Windows.Forms.RichTextBox()
        Me.review_as = New System.Windows.Forms.Label()
        Me.Stock_Detail = New System.Windows.Forms.Label()
        Me.Stock_Name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.review_id = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cancel_btn = New System.Windows.Forms.Button()
        Me.submit_btn = New System.Windows.Forms.Button()
        Me.star5 = New System.Windows.Forms.PictureBox()
        Me.star4 = New System.Windows.Forms.PictureBox()
        Me.Photo4 = New System.Windows.Forms.PictureBox()
        Me.star3 = New System.Windows.Forms.PictureBox()
        Me.Photo3 = New System.Windows.Forms.PictureBox()
        Me.star2 = New System.Windows.Forms.PictureBox()
        Me.Photo2 = New System.Windows.Forms.PictureBox()
        Me.star1 = New System.Windows.Forms.PictureBox()
        Me.Photo1 = New System.Windows.Forms.PictureBox()
        Me.Stock_Photo = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.star5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Stock_Photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'anonymous
        '
        Me.anonymous.AutoSize = True
        Me.anonymous.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!)
        Me.anonymous.Location = New System.Drawing.Point(25, 396)
        Me.anonymous.Name = "anonymous"
        Me.anonymous.Size = New System.Drawing.Size(105, 22)
        Me.anonymous.TabIndex = 6
        Me.anonymous.Text = "Anonymous"
        Me.anonymous.UseVisualStyleBackColor = True
        '
        'review_desc
        '
        Me.review_desc.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!)
        Me.review_desc.ForeColor = System.Drawing.Color.DarkGray
        Me.review_desc.Location = New System.Drawing.Point(14, 14)
        Me.review_desc.Name = "review_desc"
        Me.review_desc.Size = New System.Drawing.Size(659, 134)
        Me.review_desc.TabIndex = 14
        Me.review_desc.Text = "What do you think about the products?"
        '
        'review_as
        '
        Me.review_as.AutoSize = True
        Me.review_as.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!)
        Me.review_as.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.review_as.Location = New System.Drawing.Point(19, 421)
        Me.review_as.Name = "review_as"
        Me.review_as.Size = New System.Drawing.Size(83, 18)
        Me.review_as.TabIndex = 13
        Me.review_as.Text = "Review_As"
        '
        'Stock_Detail
        '
        Me.Stock_Detail.AutoSize = True
        Me.Stock_Detail.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!)
        Me.Stock_Detail.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Stock_Detail.Location = New System.Drawing.Point(152, 71)
        Me.Stock_Detail.Name = "Stock_Detail"
        Me.Stock_Detail.Size = New System.Drawing.Size(96, 18)
        Me.Stock_Detail.TabIndex = 2
        Me.Stock_Detail.Text = "Color: Orange"
        '
        'Stock_Name
        '
        Me.Stock_Name.AutoSize = True
        Me.Stock_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock_Name.Location = New System.Drawing.Point(149, 30)
        Me.Stock_Name.Name = "Stock_Name"
        Me.Stock_Name.Size = New System.Drawing.Size(240, 31)
        Me.Stock_Name.TabIndex = 1
        Me.Stock_Name.Text = "Toy Puppy Plushie"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.review_id)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cancel_btn)
        Me.Panel1.Controls.Add(Me.submit_btn)
        Me.Panel1.Controls.Add(Me.review_as)
        Me.Panel1.Controls.Add(Me.star5)
        Me.Panel1.Controls.Add(Me.anonymous)
        Me.Panel1.Controls.Add(Me.star4)
        Me.Panel1.Controls.Add(Me.Photo4)
        Me.Panel1.Controls.Add(Me.star3)
        Me.Panel1.Controls.Add(Me.Photo3)
        Me.Panel1.Controls.Add(Me.star2)
        Me.Panel1.Controls.Add(Me.Photo2)
        Me.Panel1.Controls.Add(Me.star1)
        Me.Panel1.Controls.Add(Me.Photo1)
        Me.Panel1.Controls.Add(Me.Stock_Detail)
        Me.Panel1.Controls.Add(Me.Stock_Name)
        Me.Panel1.Controls.Add(Me.Stock_Photo)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 450)
        Me.Panel1.TabIndex = 12
        '
        'review_id
        '
        Me.review_id.AutoSize = True
        Me.review_id.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_id.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.review_id.Location = New System.Drawing.Point(548, 9)
        Me.review_id.Name = "review_id"
        Me.review_id.Size = New System.Drawing.Size(19, 15)
        Me.review_id.TabIndex = 18
        Me.review_id.Tag = ""
        Me.review_id.Text = "ID"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Firebrick
        Me.Panel2.Controls.Add(Me.review_desc)
        Me.Panel2.Location = New System.Drawing.Point(5, 123)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(686, 164)
        Me.Panel2.TabIndex = 17
        '
        'cancel_btn
        '
        Me.cancel_btn.BackColor = System.Drawing.Color.Firebrick
        Me.cancel_btn.FlatAppearance.BorderSize = 0
        Me.cancel_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancel_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel_btn.ForeColor = System.Drawing.Color.White
        Me.cancel_btn.Location = New System.Drawing.Point(460, 396)
        Me.cancel_btn.Name = "cancel_btn"
        Me.cancel_btn.Size = New System.Drawing.Size(194, 42)
        Me.cancel_btn.TabIndex = 16
        Me.cancel_btn.Tag = ""
        Me.cancel_btn.Text = "Cancel"
        Me.cancel_btn.UseVisualStyleBackColor = False
        '
        'submit_btn
        '
        Me.submit_btn.BackColor = System.Drawing.Color.Firebrick
        Me.submit_btn.FlatAppearance.BorderSize = 0
        Me.submit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submit_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit_btn.ForeColor = System.Drawing.Color.White
        Me.submit_btn.Location = New System.Drawing.Point(460, 341)
        Me.submit_btn.Name = "submit_btn"
        Me.submit_btn.Size = New System.Drawing.Size(194, 42)
        Me.submit_btn.TabIndex = 15
        Me.submit_btn.Tag = ""
        Me.submit_btn.Text = "Submit"
        Me.submit_btn.UseVisualStyleBackColor = False
        '
        'star5
        '
        Me.star5.Image = Global.AllAboutToys.My.Resources.Resources.star_empty
        Me.star5.Location = New System.Drawing.Point(614, 77)
        Me.star5.Name = "star5"
        Me.star5.Size = New System.Drawing.Size(40, 40)
        Me.star5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star5.TabIndex = 10
        Me.star5.TabStop = False
        '
        'star4
        '
        Me.star4.Image = Global.AllAboutToys.My.Resources.Resources.star_empty
        Me.star4.Location = New System.Drawing.Point(558, 77)
        Me.star4.Name = "star4"
        Me.star4.Size = New System.Drawing.Size(40, 40)
        Me.star4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star4.TabIndex = 9
        Me.star4.TabStop = False
        '
        'Photo4
        '
        Me.Photo4.BackColor = System.Drawing.Color.White
        Me.Photo4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Photo4.Image = CType(resources.GetObject("Photo4.Image"), System.Drawing.Image)
        Me.Photo4.Location = New System.Drawing.Point(337, 293)
        Me.Photo4.Name = "Photo4"
        Me.Photo4.Size = New System.Drawing.Size(90, 90)
        Me.Photo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Photo4.TabIndex = 10
        Me.Photo4.TabStop = False
        '
        'star3
        '
        Me.star3.Image = Global.AllAboutToys.My.Resources.Resources.star_empty
        Me.star3.Location = New System.Drawing.Point(502, 77)
        Me.star3.Name = "star3"
        Me.star3.Size = New System.Drawing.Size(40, 40)
        Me.star3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star3.TabIndex = 8
        Me.star3.TabStop = False
        '
        'Photo3
        '
        Me.Photo3.BackColor = System.Drawing.Color.White
        Me.Photo3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Photo3.Image = CType(resources.GetObject("Photo3.Image"), System.Drawing.Image)
        Me.Photo3.Location = New System.Drawing.Point(234, 293)
        Me.Photo3.Name = "Photo3"
        Me.Photo3.Size = New System.Drawing.Size(90, 90)
        Me.Photo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Photo3.TabIndex = 9
        Me.Photo3.TabStop = False
        '
        'star2
        '
        Me.star2.Image = Global.AllAboutToys.My.Resources.Resources.star_empty
        Me.star2.Location = New System.Drawing.Point(447, 77)
        Me.star2.Name = "star2"
        Me.star2.Size = New System.Drawing.Size(40, 40)
        Me.star2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star2.TabIndex = 7
        Me.star2.TabStop = False
        '
        'Photo2
        '
        Me.Photo2.BackColor = System.Drawing.Color.White
        Me.Photo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Photo2.Image = CType(resources.GetObject("Photo2.Image"), System.Drawing.Image)
        Me.Photo2.Location = New System.Drawing.Point(129, 293)
        Me.Photo2.Name = "Photo2"
        Me.Photo2.Size = New System.Drawing.Size(90, 90)
        Me.Photo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Photo2.TabIndex = 8
        Me.Photo2.TabStop = False
        '
        'star1
        '
        Me.star1.Image = Global.AllAboutToys.My.Resources.Resources.star_empty
        Me.star1.Location = New System.Drawing.Point(391, 77)
        Me.star1.Name = "star1"
        Me.star1.Size = New System.Drawing.Size(40, 40)
        Me.star1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.star1.TabIndex = 6
        Me.star1.TabStop = False
        '
        'Photo1
        '
        Me.Photo1.BackColor = System.Drawing.Color.White
        Me.Photo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Photo1.Image = CType(resources.GetObject("Photo1.Image"), System.Drawing.Image)
        Me.Photo1.Location = New System.Drawing.Point(25, 293)
        Me.Photo1.Name = "Photo1"
        Me.Photo1.Size = New System.Drawing.Size(90, 90)
        Me.Photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Photo1.TabIndex = 7
        Me.Photo1.TabStop = False
        '
        'Stock_Photo
        '
        Me.Stock_Photo.Image = CType(resources.GetObject("Stock_Photo.Image"), System.Drawing.Image)
        Me.Stock_Photo.Location = New System.Drawing.Point(25, 9)
        Me.Stock_Photo.Name = "Stock_Photo"
        Me.Stock_Photo.Size = New System.Drawing.Size(104, 101)
        Me.Stock_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Stock_Photo.TabIndex = 0
        Me.Stock_Photo.TabStop = False
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 449)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Review"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Review"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.star5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.star1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Stock_Photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Photo4 As PictureBox
    Friend WithEvents Photo2 As PictureBox
    Friend WithEvents anonymous As CheckBox
    Friend WithEvents Photo3 As PictureBox
    Friend WithEvents Photo1 As PictureBox
    Friend WithEvents review_desc As RichTextBox
    Friend WithEvents review_as As Label
    Friend WithEvents star5 As PictureBox
    Friend WithEvents star4 As PictureBox
    Friend WithEvents star3 As PictureBox
    Friend WithEvents star2 As PictureBox
    Friend WithEvents star1 As PictureBox
    Friend WithEvents Stock_Detail As Label
    Friend WithEvents Stock_Name As Label
    Friend WithEvents Stock_Photo As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cancel_btn As Button
    Friend WithEvents submit_btn As Button
    Friend WithEvents review_id As Label
End Class
