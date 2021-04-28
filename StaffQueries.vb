Imports System.Data
Imports System.Data.SqlClient
Public Class StaffQueries
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim da As SqlDataAdapter
    Dim strcon As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\source\repos\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"

    Public Sub loadData()
        conn = New SqlConnection(strcon)
        conn.Open()
        Dim str As String = "select * from Review"
        da = New SqlDataAdapter(str, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Review")
        DataGridView1.DataSource = ds.Tables("Review")
        da.Dispose()
        conn.Close()
    End Sub

    Private Sub StaffQueries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        loadData()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)
            reviewID.Text = row.Cells("Review_ID").Value.ToString()
            Review.Text = row.Cells("Reviewer").Value.ToString()
            reviewDesc.Text = row.Cells("Review_Desc").Value.ToString()
            reviewRating.Text = row.Cells("Review_Rating").Value.ToString()

        End If
    End Sub
End Class