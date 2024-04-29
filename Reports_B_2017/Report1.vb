Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class Report1
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Me.ReportParameters("Dept").Value = frmGenReport.ddlDept.Text
        Me.ReportParameters("Class").Value = frmGenReport.ddlClass.Text
        Me.ReportParameters("D1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("D2").Value = frmGenReport.dtpTo.Value
    End Sub
End Class