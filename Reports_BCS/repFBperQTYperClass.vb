Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports MySql.Data.MySqlClient

Partial Public Class repFBperQTYperClass

    Inherits Telerik.Reporting.Report
    Public Sub New()
        InitializeComponent()

        Me.ReportParameters("DEPT").Value = frmGenReportBC.ddlDept.Text
        Me.ReportParameters("Class").Value = frmGenReportBC.ddlClass.Text
        Me.ReportParameters("BYEAR").Value = frmGenReportBC.ddlYear.Text


        'txtDept.Value = frmGenReportBC.ddlDept.Text

        ''Dim drPHP_USD As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & frmGenReportBC.dtpFrom.Value.Year & "' AND fldCurrency = 'PHP-USD')as Amount")
        'Dim drUSD_YEN As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & frmGenReportBC.ddlYear.Text & "' AND fldCurrency = 'USD-JPY')as Amount")
        'Dim drJPY_PHP As DataRow = Chinita.fetchMySqlRow_BC("select (select fldAmount from tblConversion where year(fldDate) = '" & frmGenReportBC.ddlYear.Text & "' AND fldCurrency = 'JPY-PHP')as Amount")

        'txtPHPtoJPY.Value = drJPY_PHP.Item("Amount").ToString
        'txtUSDtoJPY.Value = drUSD_YEN.Item("Amount").ToString

    End Sub

End Class