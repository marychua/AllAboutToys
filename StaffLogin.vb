Imports System.Data
Imports System.Data.SqlClient

Public Class StaffLogin
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\source\repos\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"

        cmd.Connection = con
        con.Open()
        cmd.CommandText = "SELECT * FROM Staff WHERE Staff_Username='" & username.Text & "' AND Staff_Password= '" & password.Text & "'"

        rd = cmd.ExecuteReader
        If rd.HasRows Then
            If rd.Read Then
                HomePage.Hide()
                StaffPage.staffID.Text = rd("Staff_ID")
                StaffPage.staffName.Text = rd("Staff_Name")
                MsgBox(rd("Staff_Name").ToString() + " logged in!")
                OpenStock()
                StaffPage.Show()
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

    Private Sub OpenStock()
        StaffStockDetails.TopLevel = False
        StaffStockDetails.TopMost = True
        StaffPage.staff_content.Controls.Add(StaffStockDetails)
        StaffPage.staff_content.Controls.Remove(StaffCustDetails)
        StaffPage.staff_content.Controls.Remove(StaffQueries)
        StaffPage.staff_content.Controls.Remove(StaffSalesReport)
        StaffPage.staff_content.Controls.Remove(StaffCustReport)
        StaffStockDetails.Show()
    End Sub
End Class