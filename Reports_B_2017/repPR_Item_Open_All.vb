Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repPR_Item_Open_All2017
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("D1").Value = frmGenReport.dtpFrom.Value
        Me.ReportParameters("D2").Value = frmGenReport.dtpTo.Value
    End Sub
End Class