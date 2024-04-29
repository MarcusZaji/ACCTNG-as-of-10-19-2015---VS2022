Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repRWGC2017
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("d1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("d2").Value = frmGenReport.dtpTo.Value
        Me.ReportParameters("Class").Value = frmGenReport.ddlClass.Text
        Me.ReportParameters("Choice").Value = frmGenReport.ddlBT.Text

    End Sub
End Class