Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repDept
    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("Dept").Value = frmGenReport.ddlDept.Text
        Me.ReportParameters("d1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("d2").Value = frmGenReport.dtpTo.Value

    End Sub

End Class