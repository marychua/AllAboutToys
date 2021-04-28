Public Class StaffSalesReport
    Private Sub StaffSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AATDBDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.AATDBDataSet.Stock)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class