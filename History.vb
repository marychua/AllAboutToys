Public Class History
    Private Sub back_btn_Click(sender As Object, e As EventArgs) Handles back_btn.Click
        Me.Hide()
        Review.submit_btn.Show()
        Review.cancel_btn.Show()
        Review.review_desc.Enabled = True

        Review.star1.Enabled = True
        Review.star2.Enabled = True
        Review.star3.Enabled = True
        Review.star4.Enabled = True
        Review.star5.Enabled = True

        Review.Photo1.Enabled = True
        Review.Photo2.Enabled = True
        Review.Photo3.Enabled = True
        Review.Photo4.Enabled = True
    End Sub

    Private Sub star2_Click(sender As Object, e As EventArgs) Handles star2.Click

    End Sub
End Class