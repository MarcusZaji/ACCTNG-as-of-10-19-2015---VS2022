Public Class FrmReportInv
    Private Sub FrmReportInv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If reporttype = 1025 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.rtpInvestment, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        ElseIf reporttype = 1026 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.RptPerInvNo, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        ElseIf reporttype = 1027 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.rptDetailedReportInv, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        ElseIf reporttype = 1028 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.RptPerInvPO, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        ElseIf reporttype = 1029 Then
            Dim typeReportSource As New Telerik.Reporting.TypeReportSource()
            typeReportSource.TypeName = "ACCTNG.RptPerInvPODetails, ACCTNG, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null"
            Me.ReportViewer1.ReportSource = typeReportSource
            ReportViewer1.RefreshReport()
        End If
    End Sub
End Class
