Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class RptPerInvNo
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("Dept").Value = FrmReportInvestment.ddlDept.Text
        Me.ReportParameters("InvestmentNo").Value = FrmReportInvestment.ddlInvestment.Text
    End Sub
End Class