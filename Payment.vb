Imports System.Net.Mail
Public Class Payment
    Private Sub cancel_btn_Click(sender As Object, e As EventArgs) Handles cancel_btn.Click
        Dim result = MsgBox("Cancel your order?", 4, "Payment")
        If result = DialogResult.Yes Then
            Me.Close()
            ClearFields()
        Else
            Return
        End If

    End Sub

    Private Sub ClearFields()
        creditcard.Checked = False
        coupon.Text = ""
        coupon_valid.Text = ""
        totalprice.Text = ""
        finalprice.Text = ""
        email.Text = ""
    End Sub

    Private Sub checkout_btn_Click(sender As Object, e As EventArgs) Handles checkout_btn.Click
        Dim result = MsgBox("Confirm your order?", 4, "Order Confirmation")
        If result = DialogResult.Yes Then
            GenerateEmail()
            Me.Hide()
        Else
            Return
        End If
    End Sub

    Private Sub apply_btn_Click(sender As Object, e As EventArgs) Handles apply_btn.Click
        Dim total As Decimal = Cart.amount.Text
        coupon_valid.Show()
        If coupon.Text IsNot "" And coupon.Text = "TOYS10" Or coupon.Text = "TOYS15" Or coupon.Text = "TOYSNEWMEMBER" Then
            coupon_valid.ForeColor = Color.Green
            coupon_valid.Text = "Coupon " + coupon.Text + " is valid!"
            finalprice.Text = total / 2
        Else
            coupon_valid.ForeColor = Color.Red
            coupon_valid.Text = "Please enter a valid coupon"
        End If
    End Sub

    Private Sub GenerateEmail()
        Dim EmailMessage As New MailMessage
        If finalprice.Text = "" And email.Text = "" And creditcard.Checked = False Then
            MsgBox("Please complete the fields!")

        Else
            Try
                EmailMessage.From = New MailAddress("allabouttoys.ltd@gmail.com")
                EmailMessage.To.Add(email.Text)
                EmailMessage.Subject = "Receipt"
                EmailMessage.Body = "Total is " + totalprice.Text + " .Here is your receipt " + HomePage.custName.Text + " ! Have a nice day!" + Environment.NewLine + Environment.NewLine + " © 2019 AllAboutToys.LTD All Rights Reserved " + Environment.NewLine
                Dim SMTP As New SmtpClient("smtp.gmail.com")
                SMTP.Port = 587
                SMTP.EnableSsl = True
                SMTP.Credentials = New System.Net.NetworkCredential("allabouttoys.ltd@gmail.com", "allabouttoys0000")
                SMTP.Send(EmailMessage)
                MsgBox("Email sent!")
                MsgBox("Order successful!")
                ClearFields()
                Me.Hide()
            Catch ex As Exception
                MsgBox("Please complete the fields!")

            End Try

        End If
    End Sub
End Class