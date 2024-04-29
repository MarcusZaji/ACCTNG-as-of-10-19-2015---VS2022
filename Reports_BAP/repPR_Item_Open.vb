Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repPR_Item_Open
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("DEPT").Value = frmGenReport.ddlDept.Text
        Me.ReportParameters("D1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("D2").Value = frmGenReport.dtpTo.Value
    End Sub
End Class