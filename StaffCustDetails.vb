Imports System.Data
Imports System.Data.SqlClient
Public Class StaffCustDetails
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim strcon As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\source\repos\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"

    Public Sub loadData()
        conn = New SqlConnection(strcon)
        conn.Open()
        Dim str As String = "Select * from Customer"
        da = New SqlDataAdapter(str, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Customer")
        DataGridView1.DataSource = ds.Tables("Customer")
        da.Dispose()
        conn.Close()

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim cmd As New SqlCommand
        Try

            conn.ConnectionString = strcon
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "delete from Stock where Customer_ID = '" & custID.Text & "'"
            cmd.ExecuteNonQuery()

            MessageBox.Show("Customer Deleted")
            loadData()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            custID.Text = row.Cells("Customer_ID").Value.ToString()
            custFName.Text = row.Cells("Customer_FirstName").Value.ToString()
            custLName.Text = row.Cells("Customer_LastName").Value.ToString()
            custGender.Text = row.Cells("Customer_Gender").Value.ToString()
            custContact.Text = row.Cells("Customer_Contact").Value.ToString()
            custEmail.Text = row.Cells("Customer_Email").Value.ToString()
            custAddress.Text = row.Cells("Customer_Address").Value.ToString()


        End If
    End Sub

    Private Sub StaffCustDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        loadData()
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim cmd As New SqlCommand
        Try
            conn.ConnectionString = strcon
            conn.Open()
            Dim str As String = "Update Customer set Customer_FirstName=@new_Fname,Customer_LastName=@new_Lname,Customer_Gender=@new_Gender,Customer_Contact=@new_Contact,Customer_Email=@new_Email,Customer_Address=@new_Address where Customer_ID=@new_CID"
            cmd = New SqlCommand(str, conn)

            cmd.Parameters.AddWithValue("@new_CID", custID.Text)
            cmd.Parameters.AddWithValue("@new_Fname", custFName.Text)
            cmd.Parameters.AddWithValue("@new_Lname", custLName.Text)
            cmd.Parameters.AddWithValue("@new_Gender", custGender.Text)
            cmd.Parameters.AddWithValue("@new_Contact", custContact.Text)
            cmd.Parameters.AddWithValue("@new_Email", custEmail.Text)
            cmd.Parameters.AddWithValue("@new_Address", custAddress.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Customer Updated")
            loadData()
            cmd.Dispose()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class