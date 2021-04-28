Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class StaffStockDetails

    Dim conn As SqlConnection
    Dim da As SqlDataAdapter
    Dim strcon As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Anonymous\source\repos\AllAboutToys\AllAboutToys\AATDB.mdf;Integrated Security=True;Connect Timeout=30"
    Private Sub StaffStockDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        stockinID.Text = "SIID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")

        stockID.Text = "SKID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
        staffID.Text = StaffPage.staffID.Text
        stockIn_date.Format = DateTimePickerFormat.Custom
        stockIn_date.CustomFormat = "dd/MM/yyyy(ddd) - HH:mm"
        conn = New SqlConnection(strcon)
        conn.Open()
        loadData()
        conn.Close()
    End Sub

    Public Sub loadData()
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

    Private Sub AddNewItem(passInID As String, passID As String, passStaffID As String, passDate As String, passName As String, passDesc As String, passQuantity As String, passCategory As String, passPrice As String, passPic As Image)

        Dim newstock2 As New StaffNewStock
        newstock2.stock_id.Text = passID
        newstock2.stock_name.Text = passName
        newstock2.stock_desc.Text = passDesc
        newstock2.stock_quantity.Text = passQuantity
        newstock2.stock_category.Text = passCategory
        newstock2.stock_price.Text = passPrice
        newstock2.stock_discount.Text = passPrice
        newstock2.stock_photo.BackgroundImage = passPic
        ItemDetails.FlowLayoutPanel1.Controls.Add(newstock2.newstock)
        MsgBox("Your item has successful added In In homepage")
    End Sub


    Private Sub add_btn_Click(sender As Object, e As EventArgs) Handles add_btn.Click
        If stockName.Text IsNot "" And stockDesc.Text IsNot "" And stockQuantity.Text IsNot "" And stockCategory.Text IsNot "" And stockPrice.Text IsNot "" And PictureBox1.Image IsNot Nothing Then

            Dim cmd As New SqlCommand
            Dim cmd2 As New SqlCommand
            Dim ms As New MemoryStream
            Dim passpic As Image = PictureBox1.Image
            Try
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)


                conn.ConnectionString = strcon
                cmd.Connection = conn
                cmd.CommandText = "Insert into Stock (Stock_ID,Stock_Name,Stock_Description,Stock_Quantity,Stock_Category,Stock_Price, Stock_Photo, Staff_ID) values (@id,@name,@description,@quantity,@category,@price,@photo,@Staff_ID)"
                cmd.Parameters.AddWithValue("@id", stockID.Text)
                cmd.Parameters.AddWithValue("@name", stockName.Text)
                cmd.Parameters.AddWithValue("@description", stockDesc.Text)
                cmd.Parameters.AddWithValue("@quantity", stockQuantity.Text)
                cmd.Parameters.AddWithValue("@category", stockCategory.Text)
                cmd.Parameters.AddWithValue("@price", stockPrice.Text)
                cmd.Parameters.Add("@photo", SqlDbType.Image).Value = ms.ToArray
                cmd.Parameters.AddWithValue("@Staff_ID", staffID.Text)
                conn.Open()
                cmd.ExecuteNonQuery()
                loadData()
                conn.Close()



                Dim passInID As String = stockinID.Text
                Dim passID As String = stockID.Text
                Dim passStaffID As String = staffID.Text
                Dim passDate As String = stockIn_date.Format

                Dim passName As String = stockName.Text
                Dim passDesc As String = stockDesc.Text
                Dim passQuantity As String = stockQuantity.Text
                Dim passCategory As String = stockCategory.Text
                Dim passPrice As String = stockPrice.Text


                AddNewItem(passInID, passID, passStaffID, passDate, passName, passDesc, passQuantity, passCategory, passPrice, passpic)

                MessageBox.Show("Added")
                ClearFields()

            Catch ex As Exception
                MessageBox.Show("Error")
            End Try
        Else
            MessageBox.Show("Please complete the details")
        End If

    End Sub

    Private Sub delete_btn_Click(sender As Object, e As EventArgs) Handles delete_btn.Click
        Dim cmd As New SqlCommand
        Try

            conn.ConnectionString = strcon
            conn.Open()
            cmd.Connection = conn
            cmd.CommandText = "delete from Stock where Stock_ID = '" & stockID.Text & "'"
            cmd.ExecuteNonQuery()

            MessageBox.Show("Deleted")
            loadData()
            conn.Close()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Dim cmd As New SqlCommand
        Try
            conn.ConnectionString = strcon
            conn.Open()
            Dim str As String = "Update Stock set Stock_Name=@new_name,Stock_Description=@new_desc,Stock_Quantity=@new_quantity,Stock_Category=@new_category,Stock_Price=@new_price where Stock_ID=@new_id"
            cmd = New SqlCommand(str, conn)

            cmd.Parameters.AddWithValue("new_id", stockID.Text)
            cmd.Parameters.AddWithValue("new_name", stockName.Text)
            cmd.Parameters.AddWithValue("new_desc", stockDesc.Text)
            cmd.Parameters.AddWithValue("new_quantity", stockQuantity.Text)
            cmd.Parameters.AddWithValue("new_category", stockCategory.Text)
            cmd.Parameters.AddWithValue("new_price", stockPrice.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Updated")
            loadData()
            cmd.Dispose()
            conn.Close()
            ClearFields()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub ClearFields()
        stockinID.Text = "SIID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
        stockID.Text = "SKID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
        staffID.Text = StaffPage.staffID.Text
        stockIn_date.Format = DateTimePickerFormat.Custom
        stockIn_date.CustomFormat = "dd/MM/yyyy(ddd) - HH:mm"

        stockName.Text = ""
        stockDesc.Text = ""
        stockQuantity.Text = ""
        stockCategory.Text = ""
        stockPrice.Text = ""
        photo.Text = ""
        PictureBox1.Image = Nothing
        stockCategory.Text = ""
    End Sub


    Private Sub browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG; *.PNG; *.GIF) |*.jpg;*png;*gif"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            photo.Text = opf.FileName
            PictureBox1.Image = Image.FromFile(opf.FileName)
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)


            stockID.Text = row.Cells("Stock_ID").Value.ToString()
            stockName.Text = row.Cells("Stock_Name").Value.ToString()
            stockDesc.Text = row.Cells("Stock_Description").Value.ToString()
            stockQuantity.Text = row.Cells("Stock_Quantity").Value.ToString()
            stockCategory.Text = row.Cells("Stock_Category").Value.ToString()
            stockPrice.Text = row.Cells("Stock_Price").Value.ToString()
            Try
                Dim bytes As [Byte]() = row.Cells("Stock_Photo").Value
                Dim ms As New MemoryStream(bytes)
                PictureBox1.Image = Image.FromStream(ms)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub Clr_btn_Click(sender As Object, e As EventArgs) Handles Clr_btn.Click
        stockinID.Text = "SIID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
        stockID.Text = "SKID" + DateTime.Now.ToString("yyyyMMddHHmmssFFF")
        staffID.Text = StaffPage.staffID.Text
        stockIn_date.Format = DateTimePickerFormat.Custom
        stockIn_date.CustomFormat = "dd/MM/yyyy(ddd) - HH:mm"

        stockName.Text = ""
        stockDesc.Text = ""
        stockQuantity.Text = ""
        stockCategory.SelectedValue = ""
        stockPrice.Text = ""
        photo.Text = ""
        PictureBox1.Image = Nothing
        stockCategory.Text = ""
    End Sub
End Class
