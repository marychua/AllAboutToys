Public Class HomePage

    Private Sub HomePage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadata.Show()

        loadata.putitemonpanel()
        cart_lbl.Text = Convert.ToString(ItemDetails.count) + "  items"
        HideCart()
        ClearName()
        OpenHome()
        loadata.Close()
    End Sub

    Private Sub home_btn_Click(sender As Object, e As EventArgs) Handles home_btn.Click
        OpenHome()
    End Sub

    Private Sub aboutus_btn_Click(sender As Object, e As EventArgs) Handles aboutus_btn.Click
        OpenAboutUs()
    End Sub

    Private Sub cart_btn_Click(sender As Object, e As EventArgs) Handles cart_btn.Click
        OpenCart()

        If ItemDetails.count <= 0 Then
            Cart.noitems_panel.BringToFront()
        Else
            Cart.noitems_panel.SendToBack()
            Cart.Panel1.BringToFront()

        End If
    End Sub

    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        OpenRegister()
    End Sub
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        OpenCustLogin()
    End Sub

    Private Sub staff_btn_Click(sender As Object, e As EventArgs) Handles staff_btn.Click
        StaffLogin.username.Text = ""
        StaffLogin.password.Text = ""
        StaffLogin.show_password.Checked = False

        'Dim result = MsgBox("Are you a AAT Staff?", 4, "Staff Only")
        'If result = DialogResult.Yes Then
        OpenStaffLogin()
        'Else
        '    MsgBox("Sorry, this function is allowed for AAT staff only.")
        'End If
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result = MsgBox("Are you want to logout?", 4, "Logout")
        If result = DialogResult.Yes Then
            ClearName()
            login_btn.Show()
            register_btn.Show()
            staff_btn.Show()
            logout_btn.Hide()
            custID.Hide()
            custName.Hide()
                                 
            OpenCustLogin()
            HideSearch()
            HideCart()
            MsgBox("Successfully logged out")
        End If
    End Sub
    Private Sub List1_Scroll()
        Dim i As Integer
        For i = 0 To Cart.ListBox1.Items.Count - 1
            Cart.ListBox1.SetSelected(i, True)
        Next
    End Sub

    Private Sub OpenHome()

        ItemDetails.TopLevel = False
        ItemDetails.TopMost = True
        content.Controls.Add(ItemDetails)
        content.Controls.Remove(AboutUs)
        content.Controls.Remove(Cart)
        content.Controls.Remove(Register)
        content.Controls.Remove(CustLogin)
        content.Controls.Remove(StaffLogin)
        ItemDetails.Show()

        ShowSearch()
    End Sub

    Private Sub OpenAboutUs()

        AboutUs.TopLevel = False
        AboutUs.TopMost = True
        content.Controls.Remove(ItemDetails)
        content.Controls.Add(AboutUs)
        content.Controls.Remove(Cart)
        content.Controls.Remove(Register)
        content.Controls.Remove(CustLogin)
        content.Controls.Remove(StaffLogin)
        AboutUs.Show()

        HideSearch()
    End Sub

    Private Sub OpenCart()
        List1_Scroll()
        Cart.temp.Text = Cart.ListBox1.SelectedIndex

        Cart.TopLevel = False
        Cart.TopMost = True
        content.Controls.Remove(ItemDetails)
        content.Controls.Remove(AboutUs)
        content.Controls.Add(Cart)
        content.Controls.Remove(Register)
        content.Controls.Remove(CustLogin)
        content.Controls.Remove(StaffLogin)
        Cart.Show()

        HideSearch()
    End Sub

    Private Sub OpenRegister()
        Register.TopLevel = False
        Register.TopMost = True
        content.Controls.Remove(ItemDetails)
        content.Controls.Remove(AboutUs)
        content.Controls.Remove(Cart)
        content.Controls.Add(Register)
        content.Controls.Remove(CustLogin)
        content.Controls.Remove(StaffLogin)
        Register.Show()

        HideSearch()
    End Sub

    Private Sub OpenCustLogin()
        CustLogin.TopLevel = False
        CustLogin.TopMost = True
        content.Controls.Remove(ItemDetails)
        content.Controls.Remove(AboutUs)
        content.Controls.Remove(Cart)
        content.Controls.Remove(Register)
        content.Controls.Add(CustLogin)
        content.Controls.Remove(StaffLogin)
        CustLogin.Show()

        HideSearch()
    End Sub

    Private Sub OpenStaffLogin()
        StaffLogin.TopLevel = False
        StaffLogin.TopMost = True
        content.Controls.Remove(ItemDetails)
        content.Controls.Remove(AboutUs)
        content.Controls.Remove(Cart)
        content.Controls.Remove(Register)
        content.Controls.Remove(CustLogin)
        content.Controls.Add(StaffLogin)
        StaffLogin.Show()

        HideSearch()
    End Sub

    Private Sub HideSearch()
        search_txtbox.Hide()
        search_btn.Hide()
        filter.Hide()
    End Sub
    Private Sub ShowSearch()
        search_txtbox.Show()
        search_btn.Show()
        filter.Show()
    End Sub


    Private Sub filter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles filter.KeyPress
        e.Handled = True 'Disable editing
    End Sub

    Private Sub HideCart()
        cart_btn.Hide()
        cart_lbl.Hide()
    End Sub

    Private Sub ClearName()
        CustLogin.username.Text = ""
        CustLogin.password.Text = ""
        custName.Text = ""
        custID.Text = ""
    End Sub

    Private Sub exit_btn_Click(sender As Object, e As EventArgs) Handles exit_btn.Click
        Application.Exit()
    End Sub

    Private Sub search_btn_Click(sender As Object, e As EventArgs) Handles search_btn.Click
        If search_txtbox.Text.Length > 0 Then
            Dim compareTo As String = String.Concat("", search_txtbox.Text.ToLowerInvariant, "")
            For Each c As Control In ItemDetails.FlowLayoutPanel1.Controls
                c.Visible = (c.Text.ToLowerInvariant Like compareTo)
            Next
        Else
            For Each c As Control In ItemDetails.Controls
                c.Visible = True
            Next
        End If

    End Sub
End Class