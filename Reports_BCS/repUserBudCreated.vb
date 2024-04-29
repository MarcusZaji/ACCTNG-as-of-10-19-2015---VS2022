Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports MySql.Data.MySqlClient

Partial Public Class repUserBudCreated

    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("DEPT").Value = frmGenReportBC.ddlDept.Text
        Me.ReportParameters("BYEAR").Value = frmGenReportBC.ddlYear.Text

    End Sub

End Class