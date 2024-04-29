Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repIR_Sub

    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()

        'Report.ReportParameters("par_CPONo").Value = frmPOChange.rgvPOList.CurrentRow.Cells("fldCPONo").Value

        'Report.DataSource = dt

    End Sub
End Class