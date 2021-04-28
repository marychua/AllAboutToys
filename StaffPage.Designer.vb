<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffPage
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.profile_panel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.staffID = New System.Windows.Forms.Label()
        Me.staffName = New System.Windows.Forms.Label()
        Me.staffProfile = New System.Windows.Forms.Label()
        Me.logout_btn = New System.Windows.Forms.Label()
        Me.custReport = New System.Windows.Forms.Label()
        Me.salesReport = New System.Windows.Forms.Label()
        Me.queries_btn = New System.Windows.Forms.Label()
        Me.custDetail_btn = New System.Windows.Forms.Label()
        Me.stockDetail_btn = New System.Windows.Forms.Label()
        Me.staff_content = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.profile_panel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.profile_panel)
        Me.Panel1.Controls.Add(Me.staffProfile)
        Me.Panel1.Controls.Add(Me.logout_btn)
        Me.Panel1.Controls.Add(Me.custReport)
        Me.Panel1.Controls.Add(Me.salesReport)
        Me.Panel1.Controls.Add(Me.queries_btn)
        Me.Panel1.Controls.Add(Me.custDetail_btn)
        Me.Panel1.Controls.Add(Me.stockDetail_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1032, 49)
        Me.Panel1.TabIndex = 45
        '
        'profile_panel
        '
        Me.profile_panel.BackColor = System.Drawing.Color.White
        Me.profile_panel.Controls.Add(Me.Panel2)
        Me.profile_panel.Controls.Add(Me.staffName)
        Me.profile_panel.Location = New System.Drawing.Point(720, 7)
        Me.profile_panel.Name = "profile_panel"
        Me.profile_panel.Size = New System.Drawing.Size(200, 32)
        Me.profile_panel.TabIndex = 44
        Me.profile_panel.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.staffID)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(91, 32)
        Me.Panel2.TabIndex = 46
        '
        'staffID
        '
        Me.staffID.AutoSize = True
        Me.staffID.BackColor = System.Drawing.Color.Transparent
        Me.staffID.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffID.ForeColor = System.Drawing.Color.Black
        Me.staffID.Location = New System.Drawing.Point(14, 7)
        Me.staffID.Name = "staffID"
        Me.staffID.Size = New System.Drawing.Size(45, 17)
        Me.staffID.TabIndex = 44
        Me.staffID.Text = "staffID"
        '
        'staffName
        '
        Me.staffName.AutoSize = True
        Me.staffName.BackColor = System.Drawing.Color.Transparent
        Me.staffName.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffName.ForeColor = System.Drawing.Color.Black
        Me.staffName.Location = New System.Drawing.Point(108, 7)
        Me.staffName.Name = "staffName"
        Me.staffName.Size = New System.Drawing.Size(68, 17)
        Me.staffName.TabIndex = 45
        Me.staffName.Text = "staffName"
        '
        'staffProfile
        '
        Me.staffProfile.AutoSize = True
        Me.staffProfile.BackColor = System.Drawing.Color.Transparent
        Me.staffProfile.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.staffProfile.ForeColor = System.Drawing.Color.White
        Me.staffProfile.Location = New System.Drawing.Point(658, 18)
        Me.staffProfile.Name = "staffProfile"
        Me.staffProfile.Size = New System.Drawing.Size(45, 17)
        Me.staffProfile.TabIndex = 6
        Me.staffProfile.Text = "Profile"
        '
        'logout_btn
        '
        Me.logout_btn.AutoSize = True
        Me.logout_btn.BackColor = System.Drawing.Color.Transparent
        Me.logout_btn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.Location = New System.Drawing.Point(953, 18)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(49, 17)
        Me.logout_btn.TabIndex = 5
        Me.logout_btn.Text = "Logout"
        '
        'custReport
        '
        Me.custReport.AutoSize = True
        Me.custReport.BackColor = System.Drawing.Color.Transparent
        Me.custReport.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custReport.ForeColor = System.Drawing.Color.White
        Me.custReport.Location = New System.Drawing.Point(525, 18)
        Me.custReport.Name = "custReport"
        Me.custReport.Size = New System.Drawing.Size(108, 17)
        Me.custReport.TabIndex = 4
        Me.custReport.Text = "Customer Report"
        '
        'salesReport
        '
        Me.salesReport.AutoSize = True
        Me.salesReport.BackColor = System.Drawing.Color.Transparent
        Me.salesReport.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salesReport.ForeColor = System.Drawing.Color.White
        Me.salesReport.Location = New System.Drawing.Point(415, 18)
        Me.salesReport.Name = "salesReport"
        Me.salesReport.Size = New System.Drawing.Size(83, 17)
        Me.salesReport.TabIndex = 3
        Me.salesReport.Text = "Stock Report"
        '
        'queries_btn
        '
        Me.queries_btn.AutoSize = True
        Me.queries_btn.BackColor = System.Drawing.Color.Transparent
        Me.queries_btn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.queries_btn.ForeColor = System.Drawing.Color.White
        Me.queries_btn.Location = New System.Drawing.Point(266, 18)
        Me.queries_btn.Name = "queries_btn"
        Me.queries_btn.Size = New System.Drawing.Size(122, 17)
        Me.queries_btn.TabIndex = 2
        Me.queries_btn.Text = "Customer's Queries"
        '
        'custDetail_btn
        '
        Me.custDetail_btn.AutoSize = True
        Me.custDetail_btn.BackColor = System.Drawing.Color.Transparent
        Me.custDetail_btn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.custDetail_btn.ForeColor = System.Drawing.Color.White
        Me.custDetail_btn.Location = New System.Drawing.Point(128, 18)
        Me.custDetail_btn.Name = "custDetail_btn"
        Me.custDetail_btn.Size = New System.Drawing.Size(107, 17)
        Me.custDetail_btn.TabIndex = 1
        Me.custDetail_btn.Text = "Customer Details"
        '
        'stockDetail_btn
        '
        Me.stockDetail_btn.AutoSize = True
        Me.stockDetail_btn.BackColor = System.Drawing.Color.Transparent
        Me.stockDetail_btn.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stockDetail_btn.ForeColor = System.Drawing.Color.White
        Me.stockDetail_btn.Location = New System.Drawing.Point(25, 18)
        Me.stockDetail_btn.Name = "stockDetail_btn"
        Me.stockDetail_btn.Size = New System.Drawing.Size(76, 17)
        Me.stockDetail_btn.TabIndex = 0
        Me.stockDetail_btn.Text = "Stock Detail"
        '
        'staff_content
        '
        Me.staff_content.Location = New System.Drawing.Point(0, 45)
        Me.staff_content.Name = "staff_content"
        Me.staff_content.Size = New System.Drawing.Size(1032, 517)
        Me.staff_content.TabIndex = 46
        '
        'StaffPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 562)
        Me.Controls.Add(Me.staff_content)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StaffPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StaffPage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.profile_panel.ResumeLayout(False)
        Me.profile_panel.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents profile_panel As Panel
    Friend WithEvents staffName As Label
    Friend WithEvents staffID As Label
    Friend WithEvents staffProfile As Label
    Friend WithEvents logout_btn As Label
    Friend WithEvents custReport As Label
    Friend WithEvents salesReport As Label
    Friend WithEvents queries_btn As Label
    Friend WithEvents custDetail_btn As Label
    Friend WithEvents stockDetail_btn As Label
    Friend WithEvents staff_content As Panel
    Friend WithEvents Panel2 As Panel
End Class
