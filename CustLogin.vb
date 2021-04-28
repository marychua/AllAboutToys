Imports System.Data.SqlClient

Public Class CustLogin
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim cmd1 As New SqlCommand
        Dim rd As SqlDataReader
        Dim rd1 As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\source\repos\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"
        cmd.Connection = con
        cmd1.Connection = con
        con.Open()
        cmd.CommandText = "Select * FROM Customer WHERE Customer_Username='" & username.Text & "' AND Customer_Password = '" & password.Text & "'"
        cmd1.CommandText = "SELECT * FROM Customer WHERE Customer_Username ='" & username.Text & "'"

        rd = cmd.ExecuteReader
        If rd.HasRows Then

            OpenHome()
            DisplayDetails()
            con.Close()
            con.Open()
            'Display ID and FirstName

            rd1 = cmd1.ExecuteReader
            If rd1.Read Then
                HomePage.custID.Text = rd1("Customer_ID").ToString()
                HomePage.custName.Text = rd1("Customer_FirstName").ToString()
            Else
                HomePage.custID.Text = "Unknown ID"
                HomePage.custName.Text = "Unknown Name"
            End If
        Else
            MsgBox("Login Failed")
        End If
    End Sub

    Private Sub show_password_CheckedChanged(sender As Object, e As EventArgs) Handles show_password.CheckedChanged
        If show_password.Checked Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub reg_link_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles reg_link.LinkClicked
        OpenRegister()
    End Sub


    Private Sub OpenRegister()
        Register.TopLevel = False
        Register.TopMost = True
        HomePage.content.Controls.Remove(ItemDetails)
        HomePage.content.Controls.Remove(AboutUs)
        HomePage.content.Controls.Remove(Cart)
        HomePage.content.Controls.Add(Register)
        HomePage.content.Controls.Remove(Me)
        HomePage.content.Controls.Remove(StaffLogin)
        Register.Show()

        HomePage.search_txtbox.Hide()
        HomePage.search_btn.Hide()
        HomePage.filter.Hide()
    End Sub

    Private Sub OpenHome()
        ItemDetails.TopLevel = False
        ItemDetails.TopMost = True
        HomePage.content.Controls.Add(ItemDetails)
        HomePage.content.Controls.Remove(AboutUs)
        HomePage.content.Controls.Remove(Cart)
        HomePage.content.Controls.Remove(Register)
        HomePage.content.Controls.Remove(Me)
        HomePage.content.Controls.Remove(StaffLogin)
        ItemDetails.Show()

        HomePage.search_txtbox.Show()
        HomePage.search_btn.Show()
        HomePage.filter.Show()
    End Sub

    Private Sub DisplayDetails()
        HomePage.login_btn.Hide()
        HomePage.register_btn.Hide()
        HomePage.staff_btn.Hide()
        HomePage.logout_btn.Show()
        HomePage.cart_btn.Show()
        HomePage.cart_lbl.Show()

        HomePage.custID.Show()
        HomePage.custName.Show()
    End Sub
End Class
