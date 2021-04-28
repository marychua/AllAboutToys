Public Class StaffNewStock
    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
            add_btn.Enabled = False
            add_btn.Text = "Added"
            Dim passname As String = stock_name.Text
            Dim passprice As String = stock_price.Text
            Dim passdiscount As String = stock_discount.Text
            Dim passdiscount2 As String = stock_discount.Text
            Dim passpic As Image = stock_photo.BackgroundImage
            AddCart(passname, passprice, passdiscount, passdiscount2, passpic)

        Else
            OpenCustLogin()
            Return
        End If
    End Sub


    Public Sub AddCart(passname As String, passprice As String, passdiscount As String, passdiscount2 As String, passpic As Image)
        ItemDetails.itemindex += 1
        TotalCartNum()
        Dim shp1 As Double = 3.8
        Dim myitem2 As New NewItem
        myitem2.quantity_count.Value += 1
        myitem2.stock_name.Text = passname
        myitem2.price.Text = passprice
        myitem2.discount.Text = passdiscount
        myitem2.dprice.Text = passdiscount2
        myitem2.pic.BackgroundImage = passpic
        myitem2.id.Text = ItemDetails.count
        Cart.FlowLayoutPanel1.Controls.Add(myitem2.myitem)
        Cart.ListBox1.Items.Add(passdiscount)
        MsgBox("Your item has successful added in your shopping cart")
    End Sub

    Public Sub TotalCartNum()
        ItemDetails.count += 1
        HomePage.cart_lbl.Text = Convert.ToString(ItemDetails.count) + "  Items"
    End Sub

    Private Sub OpenCustLogin()
        Dim login = MsgBox("Please login first. Would you like to login?", 4, "Login")
        If login = DialogResult.Yes Then
            CustLogin.TopLevel = False
            CustLogin.TopMost = True
            homePage.content.Controls.Remove(ItemDetails)
            HomePage.content.Controls.Remove(AboutUs)
            HomePage.content.Controls.Remove(Cart)
            HomePage.content.Controls.Remove(Register)
            HomePage.content.Controls.Add(CustLogin)
            HomePage.content.Controls.Remove(StaffLogin)
            CustLogin.Show()


        Else
            Return
        End If

    End Sub

    Private Sub HideSearch()
        HomePage.search_txtbox.Hide()
        HomePage.search_btn.Hide()
        HomePage.filter.Hide()
    End Sub

    Private Sub stock_photo_Click(sender As Object, e As EventArgs) Handles stock_photo.Click
        ItemDetails2.stock_quantity.Text = stock_quantity.Text + " LEFT"
        ItemDetails2.stock_name.Text = stock_name.Text
        ItemDetails2.stock_price.Text = "RM " + stock_price.Text
        ItemDetails2.stock_discount.Text = "RM " + stock_discount.Text
        ItemDetails2.stock_desc.Text = stock_desc.Text
        ItemDetails2.stock_id.Text = stock_id.Text
        ItemDetails2.stock_photo.BackgroundImage = stock_photo.BackgroundImage
        ItemDetails2.Show()

        ItemDetails2.stock_id.SendToBack()

    End Sub


End Class