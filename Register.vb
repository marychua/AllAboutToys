Imports System.Data
Imports System.Data.SqlClient
Imports System.Net.Mail
Public Class Register
    Private Sub register_btn_Click(sender As Object, e As EventArgs) Handles register_btn.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim rd As SqlDataReader

        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\Desktop\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"
        cmd.Connection = con
        con.Open()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM Customer WHERE Customer_Username='" & uname.Text & "' "

        rd = cmd.ExecuteReader
        If rd.HasRows Then
            MsgBox("Username already exist")
            con.Close()
        Else
            con.Close()
            con.Open()
            cmd = New SqlCommand("INSERT INTO Customer(Customer_ID, Customer_FirstName, Customer_LastName, Customer_Username, Customer_Gender, Customer_Contact, Customer_Email, Customer_Password) values ('" & CID.Text & "','" & fname.Text & "', '" & lname.Text & "', '" & uname.Text & "', '" & gender.Text & "', '" & contactno.Text & "', '" & email.Text & "', '" & pw.Text & "')", con)

            If (fname.Text = "" And lname.Text = "" And uname.Text = "" And email.Text = "" And pw.Text = "") Then
                MsgBox("Please enter details")
            Else
                cmd.ExecuteNonQuery()
                MsgBox("Registered successfully")
                GenerateEmail()
                Clear()

            End If
        End If
    End Sub

    Private Sub GenerateEmail()
        Dim EmailMessage As New MailMessage
        Try
            EmailMessage.From = New MailAddress("catslovemath.awd@gmail.com")
            EmailMessage.To.Add(email.Text)
            EmailMessage.Subject = "Receipt"
            EmailMessage.Body = "Here is your receipt" + fname.Text + " !" + Environment.NewLine + Environment.NewLine + " © 2019 CatsLoveMath All rights reserved " + Environment.NewLine
            Dim SMTP As New SmtpClient("smtp.gmail.com")
            SMTP.Port = 587
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential("catslovemath.awd@gmail.com", "catslovemaths123")
            SMTP.Send(EmailMessage)
            MsgBox("Email sent!")
        Catch es As Exception

        End Try
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CID.Text = "CID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
    End Sub

    Private Sub show_pw_CheckedChanged(sender As Object, e As EventArgs) Handles show_pw.CheckedChanged
        If show_pw.Checked Then
            pw.UseSystemPasswordChar = False
        Else
            pw.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub show_pw2_CheckedChanged(sender As Object, e As EventArgs) Handles show_pw2.CheckedChanged
        If show_pw2.Checked Then
            pw2.UseSystemPasswordChar = False
        Else
            pw2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Clear()
        fname.Clear()
        lname.Clear()
        uname.Clear()
        email.Clear()
        pw.Clear()
    End Sub
End Class