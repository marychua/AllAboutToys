Public Class NewItem
    Dim total(999) As Double
    Public subtotal As Double = 0
    Dim myindex As Integer
    Private Sub quantity_count_ValueChanged(sender As Object, e As EventArgs) Handles quantity_count.Click
        Integer.TryParse(id.Text, myindex)
        myindex -= 1
        Dim dp As Double
        Double.TryParse(dprice.Text, dp)
        dprice.Text = dp * quantity_count.Value

        Cart.ListBox1.SelectedIndex = myindex
        Cart.ListBox1.Items.RemoveAt(myindex)
        Cart.ListBox1.Items.Insert(myindex, dprice.Text)
        List1_Scroll()

    End Sub

    Private Sub List1_Scroll()
        Dim i As Integer
        For i = 0 To Cart.ListBox1.Items.Count - 1
            Cart.ListBox1.SetSelected(i, True)
        Next
    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click

        Integer.TryParse(id.Text, myindex)


        ItemDetails.itemindex = -1
        ItemDetails.count -= 1

        HomePage.cart_lbl.Text = Convert.ToString(ItemDetails.count) + "  items"
        Cart.ListBox1.Items.RemoveAt(Cart.ListBox1.SelectedIndex)
        Cart.FlowLayoutPanel1.Controls.Remove(myitem)

        List1_Scroll()


        StaffNewStock.add_btn.Enabled = True
        StaffNewStock.add_btn.Text = "Add to Cart"


        If ItemDetails.count = 0 Then
            Cart.noitems_panel.BringToFront()
        Else
            Cart.Panel1.BringToFront()
        End If

    End Sub

End Class