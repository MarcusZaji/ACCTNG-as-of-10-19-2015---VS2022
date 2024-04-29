Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class repBudgetGrid
    Inherits Telerik.Reporting.Report

    Public Sub New()
        InitializeComponent()

        Report.DataSource = dt

    End Sub
End Class