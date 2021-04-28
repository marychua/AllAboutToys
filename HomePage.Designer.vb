<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HomePage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomePage))
        Me.register_btn = New System.Windows.Forms.Button()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.exit_btn = New System.Windows.Forms.Button()
        Me.custName = New System.Windows.Forms.Button()
        Me.staff_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.custID = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.search_btn = New System.Windows.Forms.Button()
        Me.cart_lbl = New System.Windows.Forms.Label()
        Me.filter = New System.Windows.Forms.ComboBox()
        Me.cart_btn = New System.Windows.Forms.Button()
        Me.search_txtbox = New System.Windows.Forms.TextBox()
        Me.home_btn = New System.Windows.Forms.Button()
        Me.aboutus_btn = New System.Windows.Forms.Button()
        Me.content = New System.Windows.Forms.Panel()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.SuspendLayout()
        '
        'register_btn
        '
        Me.register_btn.BackColor = System.Drawing.Color.Firebrick
        Me.register_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.register_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.register_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.register_btn.ForeColor = System.Drawing.Color.White
        Me.register_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.register_btn.Location = New System.Drawing.Point(107, -1)
        Me.register_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.register_btn.Name = "register_btn"
        Me.register_btn.Size = New System.Drawing.Size(108, 39)
        Me.register_btn.TabIndex = 32
        Me.register_btn.Text = "Register"
        Me.register_btn.UseVisualStyleBackColor = False
        '
        'login_btn
        '
        Me.login_btn.BackColor = System.Drawing.Color.Firebrick
        Me.login_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.login_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.login_btn.ForeColor = System.Drawing.Color.White
        Me.login_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.login_btn.Location = New System.Drawing.Point(0, -1)
        Me.login_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.Size = New System.Drawing.Size(109, 39)
        Me.login_btn.TabIndex = 32
        Me.login_btn.Text = "Login"
        Me.login_btn.UseVisualStyleBackColor = False
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Firebrick
        Me.Panel8.Controls.Add(Me.exit_btn)
        Me.Panel8.Controls.Add(Me.custName)
        Me.Panel8.Controls.Add(Me.register_btn)
        Me.Panel8.Controls.Add(Me.staff_btn)
        Me.Panel8.Controls.Add(Me.login_btn)
        Me.Panel8.Controls.Add(Me.logout_btn)
        Me.Panel8.Controls.Add(Me.custID)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1302, 38)
        Me.Panel8.TabIndex = 34
        '
        'exit_btn
        '
        Me.exit_btn.BackColor = System.Drawing.Color.Firebrick
        Me.exit_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.exit_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.exit_btn.ForeColor = System.Drawing.Color.White
        Me.exit_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.exit_btn.Location = New System.Drawing.Point(1193, 0)
        Me.exit_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.exit_btn.Name = "exit_btn"
        Me.exit_btn.Size = New System.Drawing.Size(109, 38)
        Me.exit_btn.TabIndex = 42
        Me.exit_btn.Text = "Exit"
        Me.exit_btn.UseVisualStyleBackColor = False
        '
        'custName
        '
        Me.custName.BackColor = System.Drawing.Color.Firebrick
        Me.custName.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.custName.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.custName.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.custName.ForeColor = System.Drawing.Color.White
        Me.custName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.custName.Location = New System.Drawing.Point(281, 0)
        Me.custName.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(179, 39)
        Me.custName.TabIndex = 40
        Me.custName.Text = "custName"
        Me.custName.UseVisualStyleBackColor = False
        Me.custName.Visible = False
        '
        'staff_btn
        '
        Me.staff_btn.BackColor = System.Drawing.Color.Firebrick
        Me.staff_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.staff_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.staff_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.staff_btn.ForeColor = System.Drawing.Color.White
        Me.staff_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.staff_btn.Location = New System.Drawing.Point(1085, 0)
        Me.staff_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.staff_btn.Name = "staff_btn"
        Me.staff_btn.Size = New System.Drawing.Size(109, 38)
        Me.staff_btn.TabIndex = 34
        Me.staff_btn.Text = "Staff"
        Me.staff_btn.UseVisualStyleBackColor = False
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.Color.Firebrick
        Me.logout_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logout_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.logout_btn.ForeColor = System.Drawing.Color.White
        Me.logout_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.logout_btn.Location = New System.Drawing.Point(-1, 0)
        Me.logout_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(109, 39)
        Me.logout_btn.TabIndex = 35
        Me.logout_btn.Text = "Logout"
        Me.logout_btn.UseVisualStyleBackColor = False
        Me.logout_btn.Visible = False
        '
        'custID
        '
        Me.custID.BackColor = System.Drawing.Color.Firebrick
        Me.custID.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.custID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.custID.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.custID.ForeColor = System.Drawing.Color.White
        Me.custID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.custID.Location = New System.Drawing.Point(107, 0)
        Me.custID.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.custID.Name = "custID"
        Me.custID.Size = New System.Drawing.Size(179, 39)
        Me.custID.TabIndex = 41
        Me.custID.Text = "custID"
        Me.custID.UseVisualStyleBackColor = False
        Me.custID.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 38)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1302, 107)
        Me.Panel1.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AllAboutToys.My.Resources.Resources.AAT_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(581, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 96)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Firebrick
        Me.Panel9.Controls.Add(Me.search_btn)
        Me.Panel9.Controls.Add(Me.cart_lbl)
        Me.Panel9.Controls.Add(Me.filter)
        Me.Panel9.Controls.Add(Me.cart_btn)
        Me.Panel9.Controls.Add(Me.search_txtbox)
        Me.Panel9.Controls.Add(Me.home_btn)
        Me.Panel9.Controls.Add(Me.aboutus_btn)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 145)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(1302, 48)
        Me.Panel9.TabIndex = 38
        '
        'search_btn
        '
        Me.search_btn.BackColor = System.Drawing.Color.Firebrick
        Me.search_btn.BackgroundImage = CType(resources.GetObject("search_btn.BackgroundImage"), System.Drawing.Image)
        Me.search_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.search_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.search_btn.FlatAppearance.BorderSize = 0
        Me.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.search_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.search_btn.ForeColor = System.Drawing.Color.White
        Me.search_btn.Location = New System.Drawing.Point(938, 13)
        Me.search_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.search_btn.Name = "search_btn"
        Me.search_btn.Size = New System.Drawing.Size(26, 25)
        Me.search_btn.TabIndex = 37
        Me.search_btn.UseVisualStyleBackColor = False
        '
        'cart_lbl
        '
        Me.cart_lbl.AutoSize = True
        Me.cart_lbl.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.cart_lbl.ForeColor = System.Drawing.Color.White
        Me.cart_lbl.Location = New System.Drawing.Point(1223, 17)
        Me.cart_lbl.Name = "cart_lbl"
        Me.cart_lbl.Size = New System.Drawing.Size(59, 16)
        Me.cart_lbl.TabIndex = 36
        Me.cart_lbl.Text = "No Items"
        '
        'filter
        '
        Me.filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.filter.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.filter.ForeColor = System.Drawing.Color.Black
        Me.filter.FormattingEnabled = True
        Me.filter.Items.AddRange(New Object() {"Toys", "Clothes", "Books"})
        Me.filter.Location = New System.Drawing.Point(254, 13)
        Me.filter.Name = "filter"
        Me.filter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.filter.Size = New System.Drawing.Size(121, 24)
        Me.filter.TabIndex = 35
        '
        'cart_btn
        '
        Me.cart_btn.BackColor = System.Drawing.Color.Firebrick
        Me.cart_btn.BackgroundImage = CType(resources.GetObject("cart_btn.BackgroundImage"), System.Drawing.Image)
        Me.cart_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cart_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.cart_btn.FlatAppearance.BorderSize = 0
        Me.cart_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cart_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.cart_btn.ForeColor = System.Drawing.Color.White
        Me.cart_btn.Location = New System.Drawing.Point(1175, 7)
        Me.cart_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.cart_btn.Name = "cart_btn"
        Me.cart_btn.Size = New System.Drawing.Size(40, 33)
        Me.cart_btn.TabIndex = 34
        Me.cart_btn.UseVisualStyleBackColor = False
        '
        'search_txtbox
        '
        Me.search_txtbox.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.search_txtbox.Location = New System.Drawing.Point(374, 13)
        Me.search_txtbox.Multiline = True
        Me.search_txtbox.Name = "search_txtbox"
        Me.search_txtbox.Size = New System.Drawing.Size(558, 24)
        Me.search_txtbox.TabIndex = 16
        '
        'home_btn
        '
        Me.home_btn.BackColor = System.Drawing.Color.Firebrick
        Me.home_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.home_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.home_btn.ForeColor = System.Drawing.Color.White
        Me.home_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.home_btn.Location = New System.Drawing.Point(107, 0)
        Me.home_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.home_btn.Name = "home_btn"
        Me.home_btn.Size = New System.Drawing.Size(108, 48)
        Me.home_btn.TabIndex = 32
        Me.home_btn.Text = "Home"
        Me.home_btn.UseVisualStyleBackColor = False
        '
        'aboutus_btn
        '
        Me.aboutus_btn.BackColor = System.Drawing.Color.Firebrick
        Me.aboutus_btn.FlatAppearance.BorderColor = System.Drawing.Color.Maroon
        Me.aboutus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aboutus_btn.Font = New System.Drawing.Font("Bahnschrift SemiBold", 9.75!)
        Me.aboutus_btn.ForeColor = System.Drawing.Color.White
        Me.aboutus_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.aboutus_btn.Location = New System.Drawing.Point(0, 0)
        Me.aboutus_btn.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.aboutus_btn.Name = "aboutus_btn"
        Me.aboutus_btn.Size = New System.Drawing.Size(108, 48)
        Me.aboutus_btn.TabIndex = 31
        Me.aboutus_btn.Text = "About Us"
        Me.aboutus_btn.UseVisualStyleBackColor = False
        '
        'content
        '
        Me.content.Location = New System.Drawing.Point(0, 191)
        Me.content.Name = "content"
        Me.content.Size = New System.Drawing.Size(1302, 517)
        Me.content.TabIndex = 31
        '
        'HomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1302, 707)
        Me.Controls.Add(Me.content)
        Me.Controls.Add(Me.Panel9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(1)
        Me.Name = "HomePage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HomePage"
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents register_btn As Button
    Friend WithEvents login_btn As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents staff_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents search_btn As Button
    Friend WithEvents cart_lbl As Label
    Friend WithEvents filter As ComboBox
    Friend WithEvents cart_btn As Button
    Friend WithEvents search_txtbox As TextBox
    Friend WithEvents home_btn As Button
    Friend WithEvents aboutus_btn As Button
    Friend WithEvents content As Panel
    Friend WithEvents logout_btn As Button
    Friend WithEvents custID As Button
    Friend WithEvents custName As Button
    Friend WithEvents exit_btn As Button
End Class
