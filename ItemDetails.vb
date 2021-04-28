Public Class ItemDetails
    Public count As Integer = 0
    Public itemindex As Integer = -1
    Public localcategory As String
    Private Sub clothes_btn_Click(sender As Object, e As EventArgs)
        category_lbl.Text = clothes_btn.Text
    End Sub

    Private Sub books_btn_Click(sender As Object, e As EventArgs)
        category_lbl.Text = books_btn.Text
    End Sub

    Public Sub TotalCartNum()
         count += 1
        HomePage.cart_lbl.Text = Convert.ToString(count) + "  Items"
    End Sub
    Public Sub AddCart(passname As String, passprice As String, passdiscount As String, passdiscount2 As String, passpic As Image)
        itemindex += 1
        TotalCartNum()
            Dim shp1 As Double = 3.8
            Dim myitem2 As New NewItem
            myitem2.quantity_count.Value += 1
            myitem2.stock_name.Text = passname
            myitem2.price.Text = passprice
            myitem2.discount.Text = passdiscount
            myitem2.dprice.Text = passdiscount2
            myitem2.pic.BackgroundImage = passpic
            myitem2.id.Text = count
        Cart.FlowLayoutPanel1.Controls.Add(myitem2.myitem)
        Cart.ListBox1.Items.Add(passdiscount)
            MsgBox("Your item has successful added in your shopping cart")


    End Sub

    'Private Sub add_btn1_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn1.Enabled = False
    '        add_btn1.Text = "Added"
    '        Dim passname As String = name1.Text
    '        Dim passprice As String = price1.Text
    '        Dim passdiscount As String = discount1.Text
    '        Dim passdiscount2 As String = discount1.Text
    '        Dim passpic As Image = pic1.BackgroundImage
    '        ''Dim passindex As Integer
    '        ''Double.TryParse(NewItem.Label1.Text, passindex)
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn2_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn2.Enabled = False
    '        add_btn2.Text = "Added"
    '        Dim passname As String = name2.Text
    '        Dim passprice As String = price2.Text
    '        Dim passdiscount As String = discount2.Text
    '        Dim passdiscount2 As String = discount2.Text
    '        Dim passpic As Image = pic2.BackgroundImage
    '        Dim passindex As Integer
    '        Double.TryParse(NewItem.id.Text, passindex)
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn3_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn3.Enabled = False
    '        add_btn3.Text = "Added"
    '        Dim passname As String = name3.Text
    '        Dim passprice As String = price3.Text
    '        Dim passdiscount As String = discount3.Text
    '        Dim passdiscount2 As String = discount3.Text
    '        Dim passpic As Image = pic3.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn4_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn4.Enabled = False
    '        add_btn4.Text = "Added"
    '        Dim passname As String = name4.Text
    '        Dim passprice As String = price4.Text
    '        Dim passdiscount As String = discount4.Text
    '        Dim passdiscount2 As String = discount4.Text
    '        Dim passpic As Image = pic4.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn5_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn5.Enabled = False
    '        add_btn4.Text = "Added"
    '        Dim passname As String = name5.Text
    '        Dim passprice As String = price5.Text
    '        Dim passdiscount As String = discount5.Text
    '        Dim passdiscount2 As String = discount5.Text
    '        Dim passpic As Image = pic5.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn6_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn6.Enabled = False
    '        add_btn6.Text = "Added"
    '        Dim passname As String = name6.Text
    '        Dim passprice As String = price6.Text
    '        Dim passdiscount As String = discount6.Text
    '        Dim passdiscount2 As String = discount6.Text
    '        Dim passpic As Image = pic6.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn7_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn7.Enabled = False
    '        add_btn7.Text = "Added"
    '        Dim passname As String = name7.Text
    '        Dim passprice As String = price7.Text
    '        Dim passdiscount As String = discount7.Text
    '        Dim passdiscount2 As String = discount7.Text
    '        Dim passpic As Image = pic7.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)
    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    'Private Sub add_btn8_Click(sender As Object, e As EventArgs)
    '    If HomePage.custID.Text IsNot "" Or HomePage.custName.Text IsNot "" Then
    '        add_btn8.Enabled = False
    '        add_btn8.Text = "Added"
    '        Dim passname As String = name8.Text
    '        Dim passprice As String = price8.Text
    '        Dim passdiscount As String = discount8.Text
    '        Dim passdiscount2 As String = discount8.Text
    '        Dim passpic As Image = pic8.BackgroundImage
    '        AddCart(passname, passprice, passdiscount, passdiscount2, passpic)

    '    Else
    '        OpenCustLogin()
    '        Return
    '    End If
    'End Sub

    Private Sub ItemDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenCustLogin()
        Dim login = MsgBox("Please login first. Would you like to login?", 4, "Login")
        If login = DialogResult.Yes Then
            CustLogin.TopLevel = False
            CustLogin.TopMost = True
            HomePage.content.Controls.Remove(Me)
            HomePage.content.Controls.Remove(AboutUs)
            HomePage.content.Controls.Remove(Cart)
            HomePage.content.Controls.Remove(Register)
            HomePage.content.Controls.Add(CustLogin)
            HomePage.content.Controls.Remove(StaffLogin)
            CustLogin.Show()

            HideSearch()
        Else
            Return
        End If

    End Sub

    Private Sub HideSearch()
        HomePage.search_txtbox.Hide()
        HomePage.search_btn.Hide()
        HomePage.filter.Hide()
    End Sub

    Private Sub toys_btn_Click(sender As Object, e As EventArgs) Handles toys_btn.Click
        category_lbl.Text = "TOYS"
        localcategory = "toys"


        'change panel color
        toys_panel.BackColor = Color.Maroon
        clothes_panel.BackColor = Color.Firebrick
        books_panel.BackColor = Color.Firebrick
        BOGOF_panel.BackColor = Color.Firebrick
        ecoupon_panel.BackColor = Color.Firebrick
        specials_panel.BackColor = Color.Firebrick

        'change button color
        toys_btn.BackColor = Color.Gainsboro
        clothes_btn.BackColor = Color.White
        books_btn.BackColor = Color.White
        BOGOF_btn.BackColor = Color.White
        ecoupon_btn.BackColor = Color.White
        specials_btn.BackColor = Color.White
    End Sub

    Private Sub clothes_btn_Click_1(sender As Object, e As EventArgs) Handles clothes_btn.Click
        category_lbl.Text = "CLOTHES"
        localcategory = "clothes"

        'change panel color
        toys_panel.BackColor = Color.Firebrick
        clothes_panel.BackColor = Color.Maroon
        books_panel.BackColor = Color.Firebrick
        BOGOF_panel.BackColor = Color.Firebrick
        ecoupon_panel.BackColor = Color.Firebrick
        specials_panel.BackColor = Color.Firebrick

        'change button color
        toys_btn.BackColor = Color.White
        clothes_btn.BackColor = Color.Gainsboro
        books_btn.BackColor = Color.White
        BOGOF_btn.BackColor = Color.White
        ecoupon_btn.BackColor = Color.White
        specials_btn.BackColor = Color.White
    End Sub

    Private Sub books_btn_Click_1(sender As Object, e As EventArgs) Handles books_btn.Click
        category_lbl.Text = "BOOKS"
        localcategory = "books"

        'change panel color
        toys_panel.BackColor = Color.Firebrick
        clothes_panel.BackColor = Color.Firebrick
        books_panel.BackColor = Color.Maroon
        BOGOF_panel.BackColor = Color.Firebrick
        ecoupon_panel.BackColor = Color.Firebrick
        specials_panel.BackColor = Color.Firebrick

        'change button color
        toys_btn.BackColor = Color.White
        clothes_btn.BackColor = Color.White
        books_btn.BackColor = Color.Gainsboro
        BOGOF_btn.BackColor = Color.White
        ecoupon_btn.BackColor = Color.White
        specials_btn.BackColor = Color.White
    End Sub

    Private Sub BOGOF_btn_Click(sender As Object, e As EventArgs) Handles BOGOF_btn.Click
        localcategory = "bogof"

        If Deals.bogof_panel.Visible = True Then
            Deals.Hide()
        ElseIf Deals.bogof_panel.Visible = False Then
            Deals.bogof_panel.Show()
            Deals.bogof_panel.BringToFront()
            Deals.ecoupon_panel.Hide()
            Deals.special_panel.Hide()
            Deals.Show()
        End If
        'change panel color
        toys_panel.BackColor = Color.Firebrick
        clothes_panel.BackColor = Color.Firebrick
        books_panel.BackColor = Color.Firebrick
        BOGOF_panel.BackColor = Color.Maroon
        ecoupon_panel.BackColor = Color.Firebrick
        specials_panel.BackColor = Color.Firebrick

        'change button color
        toys_btn.BackColor = Color.White
        clothes_btn.BackColor = Color.White
        books_btn.BackColor = Color.White
        BOGOF_btn.BackColor = Color.Gainsboro
        ecoupon_btn.BackColor = Color.White
        specials_btn.BackColor = Color.White
    End Sub

    Private Sub ecoupon_btn_Click(sender As Object, e As EventArgs) Handles ecoupon_btn.Click
        localcategory = "ecoupon"


        If Deals.ecoupon_panel.Visible = True Then
            Deals.Hide()
        ElseIf Deals.ecoupon_panel.Visible = False Then
            Deals.ecoupon_panel.Show()
            Deals.ecoupon_panel.BringToFront()
            Deals.bogof_panel.Hide()
            Deals.special_panel.Hide()
            Deals.Show()
        End If
        'change panel color
        toys_panel.BackColor = Color.Firebrick
        clothes_panel.BackColor = Color.Firebrick
        books_panel.BackColor = Color.Firebrick
        BOGOF_panel.BackColor = Color.Firebrick
        ecoupon_panel.BackColor = Color.Maroon
        specials_panel.BackColor = Color.Firebrick

        'change button color
        toys_btn.BackColor = Color.White
        clothes_btn.BackColor = Color.White
        books_btn.BackColor = Color.White
        BOGOF_btn.BackColor = Color.White
        ecoupon_btn.BackColor = Color.Gainsboro
        specials_btn.BackColor = Color.White
    End Sub

    Private Sub specials_btn_Click(sender As Object, e As EventArgs) Handles specials_btn.Click
        localcategory = "specials"
        If Deals.special_panel.Visible = True Then
            Deals.Hide()
        ElseIf Deals.special_panel.Visible = False Then
            Deals.special_panel.Show()
            Deals.special_panel.BringToFront()
            Deals.ecoupon_panel.Hide()
            Deals.bogof_panel.Hide()
            Deals.Show()
        End If

        'change panel color
        toys_panel.BackColor = Color.Firebrick
        clothes_panel.BackColor = Color.Firebrick
        books_panel.BackColor = Color.Firebrick
        BOGOF_panel.BackColor = Color.Firebrick
        ecoupon_panel.BackColor = Color.Firebrick
        specials_panel.BackColor = Color.Maroon

        'change button color
        toys_btn.BackColor = Color.White
        clothes_btn.BackColor = Color.White
        books_btn.BackColor = Color.White
        BOGOF_btn.BackColor = Color.White
        ecoupon_btn.BackColor = Color.White
        specials_btn.BackColor = Color.Gainsboro
    End Sub




End Class