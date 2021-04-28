Public Class StaffCustReport
    Private Sub StaffCustReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'AATDBDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.AATDBDataSet.Customer)

        Me.ReportViewer1.RefreshReport
    End Sub
End Class