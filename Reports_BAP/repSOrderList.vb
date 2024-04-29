Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repSOrderList
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Me.ReportParameters("Dept").Value = frmGenReport.ddlDept.Text
        Me.ReportParameters("PO").Value = frmGenReport.ddlPO.Text
        Me.ReportParameters("d1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("d2").Value = frmGenReport.dtpTo.Value
    End Sub



    'Private Sub SubReport1_ItemDataBound(sender As Object, e As EventArgs) Handles SubReport1.ItemDataBound
    '    Dim subReport As Telerik.Reporting.Processing.Report = DirectCast(sender, Telerik.Reporting.Processing.Report)
    '    SubReport1.Visible = subReport.ChildElements.Find("detail", True).Length > 0
    'End Sub
End Class