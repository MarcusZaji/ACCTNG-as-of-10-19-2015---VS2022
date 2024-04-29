Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repBudUpdated
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("Dept").Value = frmGenUpd8dBud.ddlDept.Text
        Me.ReportParameters("Class").Value = frmGenUpd8dBud.ddlClass.Text
        Me.ReportParameters("d1").Value = frmGenUpd8dBud.dtpFrom.Value
        Me.ReportParameters("d2").Value = frmGenUpd8dBud.dtpTo.Value

    End Sub
End Class