Public Class Cart
    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        temp.Text = ListBox1.SelectedIndex

        Dim total As Decimal
        Try
            If ListBox1.Items.Count > 0 Then
                For Each itemprice As Decimal In ListBox1.Items
                    total += itemprice
                Next
                amount.Text = "RM " + total.ToString
            Else
                amount.Text = "RM " + 0.ToString
            End If
        Catch ex As Exception
            MessageBox.Show("No orders")
        End Try



    End Sub

    Private Sub history_btn_Click(sender As Object, e As EventArgs) Handles history_btn.Click
        Review.submit_btn.Hide()
        Review.cancel_btn.Hide()
        Review.anonymous.Hide()

        Review.star1.Enabled = False
        Review.star2.Enabled = False
        Review.star3.Enabled = False
        Review.star4.Enabled = False
        Review.star5.Enabled = False

        Review.Photo1.Enabled = False
        Review.Photo2.Enabled = False
        Review.Photo3.Enabled = False
        Review.Photo4.Enabled = False

        Review.review_desc.Enabled = False
        History.FlowLayoutPanel1.Controls.Add(Review.Panel1)
        History.Show()

    End Sub

    Private Sub buy_btn_Click(sender As Object, e As EventArgs) Handles buy_btn.Click


        Dim total As Decimal = amount.Text
        Payment.creditcard.Checked = False
        Payment.coupon.Text = ""
        Payment.coupon_valid.Text = ""
        Payment.email.Text = ""

        Payment.totalprice.Text = total
        Payment.finalprice.Text = total
        Payment.ShowDialog()
    End Sub
End Class