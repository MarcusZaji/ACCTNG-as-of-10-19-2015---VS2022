Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class rptRemBudLessPR
    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        'Me.ReportParameters("Dept").Value = frmGenReport.ddlDept.Text
        'Me.ReportParameters("Class").Value = frmGenReport.ddlClass.Text
        'Me.ReportParameters("D1").Value = frmGenReport.dtpFrom.Value
        'Me.ReportParameters("D2").Value = frmGenReport.dtpTo.Value

        'Dim UPOFPO As DataTable = Chinita.fetchDBTable("CALL SP_FPOUPO('" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpFrom.Value)) & "', " _
        '                                                  & "'" & Convert.ToString(String.Format("{0:yyyy-MM-dd}", frmGenReport.dtpTo.Value)) & "', " _
        '                                                  & "'" & frmGenReport.ddlDept.Text & "','" & frmGenReport.ddlClass.Text & "') ")
        'Table1.DataSource = UPOFPO

        Me.ReportParameters("BudRefNum").Value = globalVariables.PassBudRefNo

    End Sub
End Class