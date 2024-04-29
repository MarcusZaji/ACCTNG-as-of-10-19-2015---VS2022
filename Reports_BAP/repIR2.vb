Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repIR2
    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()

        Report.ReportParameters("par_CPONo").Value = frmPOChange.rgvPOList.CurrentRow.Cells("fldCPONo").Value

        PONo.Value = frmPOChange.rgvPOList.CurrentRow.Cells("PO").Value.ToString
        txtPRNo.Value = frmPOChange.rgvPOList.CurrentRow.Cells("PR").Value.ToString

        txtTNC.Value = frmPOChange.RTTotal.Text

        txtSupName.Value = frmPOChange.ddlSupSap.Text
        txtTINNo.Value = frmPOChange.txtTINNo.Text
        txtATTN.Value = frmPOChange.txtCntctPrsn.Text

        txtDD.Value = frmPOChange.dtpDelDate.Text

        txtPrepBy.Value = frmPOChange.lblName.Text

        txtChkBy.Value = "MARJIE E. TRINIDAD"

        If txtTNC.Value <= 30000 Then
            txtApprvBy.Value = "MARILOU P. PELAGIO"

        ElseIf txtTNC.Value > 30000 And txtTNC.Value <= 50000 Then
            txtApprvBy.Value = "HIDEKI TOIDE"

        ElseIf txtTNC.Value >= 50001 Then
            txtApprvBy.Value = "HIRONORI SUZUKI"

        End If

    End Sub

End Class