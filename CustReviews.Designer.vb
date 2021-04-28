<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustReviews
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
        Me.myreview = New System.Windows.Forms.Panel()
        Me.review_ID = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.reviewer = New System.Windows.Forms.Label()
        Me.rating = New System.Windows.Forms.Label()
        Me.myreview.SuspendLayout()
        Me.SuspendLayout()
        '
        'myreview
        '
        Me.myreview.BackColor = System.Drawing.Color.White
        Me.myreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.myreview.Controls.Add(Me.review_ID)
        Me.myreview.Controls.Add(Me.Label3)
        Me.myreview.Controls.Add(Me.Label4)
        Me.myreview.Controls.Add(Me.reviewer)
        Me.myreview.Controls.Add(Me.rating)
        Me.myreview.Location = New System.Drawing.Point(12, 21)
        Me.myreview.Name = "myreview"
        Me.myreview.Size = New System.Drawing.Size(760, 143)
        Me.myreview.TabIndex = 41
        '
        'review_ID
        '
        Me.review_ID.AutoSize = True
        Me.review_ID.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_ID.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.review_ID.Location = New System.Drawing.Point(17, 110)
        Me.review_ID.Name = "review_ID"
        Me.review_ID.Size = New System.Drawing.Size(74, 19)
        Me.review_ID.TabIndex = 39
        Me.review_ID.Text = "Review ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.Label3.Location = New System.Drawing.Point(18, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(696, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 23)
        Me.Label4.TabIndex = 33
        '
        'reviewer
        '
        Me.reviewer.AutoSize = True
        Me.reviewer.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reviewer.ForeColor = System.Drawing.Color.Black
        Me.reviewer.Location = New System.Drawing.Point(14, 14)
        Me.reviewer.Name = "reviewer"
        Me.reviewer.Size = New System.Drawing.Size(86, 23)
        Me.reviewer.TabIndex = 7
        Me.reviewer.Tag = "discount_tag"
        Me.reviewer.Text = "Reviewer"
        '
        'rating
        '
        Me.rating.AutoSize = True
        Me.rating.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.rating.Location = New System.Drawing.Point(17, 47)
        Me.rating.Name = "rating"
        Me.rating.Size = New System.Drawing.Size(51, 19)
        Me.rating.TabIndex = 6
        Me.rating.Text = "Rating"
        '
        'CustReviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 184)
        Me.Controls.Add(Me.myreview)
        Me.Name = "CustReviews"
        Me.Text = "v"
        Me.myreview.ResumeLayout(False)
        Me.myreview.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents myreview As Panel
    Friend WithEvents review_ID As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents reviewer As Label
    Friend WithEvents rating As Label
End Class
