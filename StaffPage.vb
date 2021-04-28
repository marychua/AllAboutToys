Imports System.Data.SqlClient

Public Class StaffPage
    Private Sub staffProfile_Click(sender As Object, e As EventArgs) Handles staffProfile.Click
        If profile_panel.Visible = False Then
            profile_panel.Show()
        ElseIf profile_panel.Visible = True Then
            profile_panel.Hide()
        End If
    End Sub

    Private Sub stockDetail_btn_Click(sender As Object, e As EventArgs) Handles stockDetail_btn.Click
        OpenStock()
    End Sub

    Private Sub custDetail_btn_Click(sender As Object, e As EventArgs) Handles custDetail_btn.Click
        OpenCustDetails()
    End Sub

    Private Sub queries_btn_Click(sender As Object, e As EventArgs) Handles queries_btn.Click
        OpenQueries()
    End Sub

    Private Sub salesReport_Click(sender As Object, e As EventArgs) Handles salesReport.Click
        OpenSalesReport()
    End Sub

    Private Sub custReport_Click(sender As Object, e As EventArgs) Handles custReport.Click
        OpenCustReport()
    End Sub

    Private Sub OpenStock()
        StaffStockDetails.TopLevel = False
        StaffStockDetails.TopMost = True
        staff_content.Controls.Add(StaffStockDetails)
        staff_content.Controls.Remove(StaffCustDetails)
        staff_content.Controls.Remove(StaffQueries)
        staff_content.Controls.Remove(StaffSalesReport)
        staff_content.Controls.Remove(StaffCustReport)
        StaffStockDetails.Show()
    End Sub

    Private Sub OpenCustDetails()
        StaffCustDetails.TopLevel = False
        StaffCustDetails.TopMost = True
        staff_content.Controls.Remove(StaffStockDetails)
        staff_content.Controls.Add(StaffCustDetails)
        staff_content.Controls.Remove(StaffQueries)
        staff_content.Controls.Remove(StaffSalesReport)
        staff_content.Controls.Remove(StaffCustReport)
        StaffCustDetails.Show()
    End Sub

    Private Sub OpenQueries()
        StaffQueries.TopLevel = False
        StaffQueries.TopMost = True
        staff_content.Controls.Remove(StaffStockDetails)
        staff_content.Controls.Remove(StaffCustDetails)
        staff_content.Controls.Add(StaffQueries)
        staff_content.Controls.Remove(StaffSalesReport)
        staff_content.Controls.Remove(StaffCustReport)
        StaffQueries.Show()
    End Sub

    Private Sub OpenSalesReport()
        StaffSalesReport.TopLevel = False
        StaffSalesReport.TopMost = True
        staff_content.Controls.Remove(StaffStockDetails)
        staff_content.Controls.Remove(StaffCustDetails)
        staff_content.Controls.Remove(StaffQueries)
        staff_content.Controls.Add(StaffSalesReport)
        staff_content.Controls.Remove(StaffCustReport)
        StaffSalesReport.Show()
    End Sub

    Private Sub OpenCustReport()
        StaffCustReport.TopLevel = False
        StaffCustReport.TopMost = True
        staff_content.Controls.Remove(StaffStockDetails)
        staff_content.Controls.Remove(StaffCustDetails)
        staff_content.Controls.Remove(StaffQueries)
        staff_content.Controls.Remove(StaffSalesReport)
        staff_content.Controls.Add(StaffCustReport)
        StaffCustReport.Show()
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result = MsgBox("Are you want to logout as " + staffName.Text + " ?", 4, "Logout")
        If result = DialogResult.Yes Then
            staffName.Text = ""
            staffID.Text = ""
            'StaffStockDetails.TopLevel = False
            'StaffStockDetails.TopMost = False
            'Me.staff_content.Controls.Remove(StaffStockDetails)
            'Me.staff_content.Controls.Remove(StaffCustDetails)
            'Me.staff_content.Controls.Remove(StaffQueries)
            'Me.staff_content.Controls.Remove(StaffSalesReport)
            'Me.staff_content.Controls.Remove(StaffCustReport)
            'StaffStockDetails.Close()
            Me.Close()
            MsgBox("Successfully logged out")
            HomePage.Show()
        End If
    End Sub

End Class