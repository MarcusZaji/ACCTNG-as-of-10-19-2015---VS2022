Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptPRHeader
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Me.ReportParameters("Dept1").Value = frmGenReport.ddlDept.Text
    End Sub
End Class