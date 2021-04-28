Public Class Review
    Dim StarValue As Integer = 0
    Dim tempstar As Integer = 0

    Dim empty As Image = My.Resources.star_empty
    Dim filled As Image = My.Resources.star_filled

    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StarValue = 0
        review_as.Text = "Review as " + HomePage.custName.Text
    End Sub

    Private Sub star1_Click(sender As Object, e As EventArgs) Handles star1.Click
        StarValue = 1
        GiveRating()
    End Sub

    Private Sub star2_Click(sender As Object, e As EventArgs) Handles star2.Click
        StarValue = 2
        GiveRating()
    End Sub

    Private Sub star3_Click(sender As Object, e As EventArgs) Handles star3.Click
        StarValue = 3
        GiveRating()
    End Sub

    Private Sub star4_Click(sender As Object, e As EventArgs) Handles star4.Click
        StarValue = 4
        GiveRating()
    End Sub

    Private Sub star5_Click(sender As Object, e As EventArgs) Handles star5.Click
        StarValue = 5
        GiveRating()
    End Sub

    Private Sub TempRating()

        If tempstar = 0 Then
            star1.Image = empty
            star2.Image = empty
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If
        If tempstar = 1 Then
            star1.Image = filled
            star2.Image = empty
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If

        If tempstar = 2 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If

        If tempstar = 3 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = empty
            star5.Image = empty
        End If

        If tempstar = 4 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = filled
            star5.Image = empty
        End If

        If tempstar = 5 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = filled
            star5.Image = filled
        End If

    End Sub

    Private Sub GiveRating()
        If StarValue = 0 Then
            star1.Image = empty
            star2.Image = empty
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If
        If StarValue = 1 Then
            star1.Image = filled
            star2.Image = empty
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If

        If StarValue = 2 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = empty
            star4.Image = empty
            star5.Image = empty
        End If

        If StarValue = 3 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = empty
            star5.Image = empty
        End If

        If StarValue = 4 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = filled
            star5.Image = empty
        End If

        If StarValue = 5 Then
            star1.Image = filled
            star2.Image = filled
            star3.Image = filled
            star4.Image = filled
            star5.Image = filled
        End If

        MsgBox("You gave " + Convert.ToString(StarValue) + " stars")
    End Sub

    Private Sub anonymous_CheckedChanged(sender As Object, e As EventArgs) Handles anonymous.CheckedChanged
        If anonymous.Checked = True Then
            review_as.Text = "Review as Anonymous"
        Else
            review_as.Text = "Review as " + HomePage.custName.Text
        End If
    End Sub



    Private Sub review_desc_MouseEnter(sender As Object, e As EventArgs) Handles review_desc.MouseEnter
        If review_desc.Text = "What do you think about the products?" Then
            review_desc.Text = ""
            review_desc.ForeColor = Color.Black
        Else

        End If
    End Sub

    Private Sub review_desc_MouseLeave(sender As Object, e As EventArgs) Handles review_desc.MouseLeave
        If review_desc.Text = "" Then
            review_desc.Text = "What do you think about the products?"
            review_desc.ForeColor = Color.DarkGray
        Else

        End If
    End Sub

    Private Sub submit_btn_Click(sender As Object, e As EventArgs) Handles submit_btn.Click
        If review_desc.Text = "" Or review_desc.Text = "What do you think about the products?" Then
            MsgBox("Please give a review.")
        End If
        If StarValue = 0 Then
            MsgBox("Please give a rating.")
        End If
        If review_desc.Text <> "" And review_desc.Text <> "What do you think about the products?" And StarValue > 0 Then
            Clear()
            MsgBox("Review Submitted!")
        End If
    End Sub

    Private Sub Photo1_Click(sender As Object, e As EventArgs) Handles Photo1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If ofd.ShowDialog = DialogResult.OK Then
            Photo1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Photo2_Click(sender As Object, e As EventArgs) Handles Photo2.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If ofd.ShowDialog = DialogResult.OK Then
            Photo1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Photo3_Click(sender As Object, e As EventArgs) Handles Photo3.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If ofd.ShowDialog = DialogResult.OK Then
            Photo1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub Photo4_Click(sender As Object, e As EventArgs) Handles Photo4.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Choose (*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If ofd.ShowDialog = DialogResult.OK Then
            Photo1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub star1_MouseHover(sender As Object, e As EventArgs) Handles star1.MouseHover
        tempstar = 1
        TempRating()
    End Sub

    Private Sub star1_MouseLeave(sender As Object, e As EventArgs) Handles star1.MouseLeave
        MouseLeave()
    End Sub

    Private Sub star2_MouseHover(sender As Object, e As EventArgs) Handles star2.MouseHover
        tempstar = 2
        TempRating()
    End Sub

    Private Sub star2_MouseLeave(sender As Object, e As EventArgs) Handles star2.MouseLeave
        MouseLeave()
    End Sub

    Private Sub star3_MouseHover(sender As Object, e As EventArgs) Handles star3.MouseHover
        tempstar = 3
        TempRating()
    End Sub

    Private Sub star3_MouseLeave(sender As Object, e As EventArgs) Handles star3.MouseLeave
        MouseLeave()
    End Sub

    Private Sub star4_MouseHover(sender As Object, e As EventArgs) Handles star4.MouseHover
        tempstar = 4
        TempRating()
    End Sub

    Private Sub star4_MouseLeave(sender As Object, e As EventArgs) Handles star4.MouseLeave
        MouseLeave()
    End Sub

    Private Sub star5_MouseHover(sender As Object, e As EventArgs) Handles star5.MouseHover
        tempstar = 5
        TempRating()
    End Sub

    Private Sub star5_MouseLeave(sender As Object, e As EventArgs) Handles star5.MouseLeave
        MouseLeave()
    End Sub

    Private Sub MouseLeave()
        If (StarValue = 0) Then
            tempstar = 0
            TempRating()
        End If
    End Sub

    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Me.Hide()

    End Sub

    Private Sub Clear()
        review_desc.Text = "What do you think about the products?"
        review_desc.ForeColor = Color.DarkGray
        StarValue = 0
        star1.Image = empty
        star2.Image = empty
        star3.Image = empty
        star4.Image = empty
        star5.Image = empty
        anonymous.Checked = False
    End Sub

End Class