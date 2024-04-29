Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptDetailedReportInv
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()
        Dim Dept As String
        Dim InvNo As String

        If FrmReportInvestment.ddlDept.Text = "ALL" Then
            Dept = "%"
        Else
            Dept = FrmReportInvestment.ddlDept.Text
        End If
        If FrmReportInvestment.ddlInvestment.Text = "ALL" Then
            InvNo = "%"
        Else
            InvNo = FrmReportInvestment.ddlInvestment.Text
        End If

        Me.ReportParameters("Dept").Value = Dept
        Me.ReportParameters("InvestmentNo").Value = InvNo
    End Sub
End Class