Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class loadata
    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim strcon As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\Desktop\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"

    Private Sub loadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn = New SqlConnection(strcon)
        conn.Open()
        Dim str As String = "select * from Stock "
        da = New SqlDataAdapter(str, conn)
        Dim ds As New DataSet
        da.Fill(ds, "Stock")
        DataGridView1.DataSource = ds.Tables("Stock")
        da.Dispose()
        conn.Close()
    End Sub
    Public Sub putitemonpanel()
        Dim row As DataGridViewRow
        Dim discount As Decimal
        Dim looprow As Integer = DataGridView1.RowCount - 1
        row = Me.DataGridView1.Rows(looprow)
        Do While looprow >= 0
            Dim newstock2 As New StaffNewStock
            newstock2.stock_id.Text = DataGridView1.Item(0, looprow).Value.ToString()
            newstock2.stock_name.Text = DataGridView1.Item(1, looprow).Value.ToString()
            newstock2.stock_desc.Text = DataGridView1.Item(2, looprow).Value.ToString()
            newstock2.stock_quantity.Text = DataGridView1.Item(3, looprow).Value.ToString()
            newstock2.stock_category.Text = DataGridView1.Item(4, looprow).Value.ToString()
            newstock2.stock_price.Text = Convert.ToDouble(DataGridView1.Item(5, looprow).Value.ToString())
            discount = DataGridView1.Item(5, looprow).Value.ToString()
            newstock2.stock_discount.Text = discount * 0.5
            Try
                Dim bytes As [Byte]() = DataGridView1.Item(6, looprow).Value
                Dim ms As New MemoryStream(bytes)
                newstock2.stock_photo.BackgroundImage = Image.FromStream(ms)
            Catch ex As Exception

            End Try
            'newstock2.stock_photo.BackgroundImage = Row.Cells("Stock_Photo").Value
            ItemDetails.FlowLayoutPanel1.Controls.Add(newstock2.newstock)

            looprow = looprow - 1
        Loop

        'If e.RowIndex >= 0 Then
        '    Dim row As DataGridViewRow
        '    row = Me.DataGridView1.Rows(e.RowIndex)


        '    stockID.Text = row.Cells("Stock_ID").Value.ToString()
        '    stockName.Text = row.Cells("Stock_Name").Value.ToString()
        '    stockDesc.Text = row.Cells("Stock_Description").Value.ToString()
        '    stockQuantity.Text = row.Cells("Stock_Quantity").Value.ToString()
        '    stockCategory.Text = row.Cells("Stock_Category").Value.ToString()
        '    stockPrice.Text = row.Cells("Stock_Price").Value.ToString()
        '    Try
        '        Dim bytes As [Byte]() = row.Cells("Stock_Photo").Value
        '        Dim ms As New MemoryStream(bytes)
        '        PictureBox1.Image = Image.FromStream(ms)
        '    Catch ex As Exception

        '    End Try

        'End If
    End Sub
End Class