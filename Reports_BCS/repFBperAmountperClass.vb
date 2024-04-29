Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing
Imports MySql.Data.MySqlClient

Partial Public Class repFBperAmountperClass

    Inherits Telerik.Reporting.Report
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
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


        'dtLoadData = Chinita.fetchDBTable_BC("call SP_ExchangeRate('" & frmGenReportBC.ddlYear.Text & "','" & frmGenReportBC.ddlDept.Text & "')")
        'Me.Table2.DataSource = dtLoadData

        'dtLoadData2 = Chinita.fetchDBTable_BC("call SP_repFBperAmountClassv2('" & frmGenReportBC.ddlDept.Text & "','" & frmGenReportBC.ddlClass.Text & "','" & frmGenReportBC.ddlYear.Text & "')")
        'Me.Table1.DataSource = dtLoadData2

        'Dim parYear As Integer = Convert.ToInt32(frmGenReportBC.ddlYear.Text)
        'Dim parDept As String = frmGenReportBC.ddlDept.Text
        'Dim parClass As String = frmGenReportBC.ddlClass.Text

        'ConBCS.addParameter("BYEAR", parYear)
        'ConBCS.addParameter("DEPT", parDept)
        'Dim dtExRate As DataTable = ConBCS.dbSelect("SP_ExchangeRate")

        'Dim query = (From i In dtExRate.AsEnumerable()
        '             Select New With {
        '            .DEPT = i("DEPT"),
        '            .USDJPYAmount = i("USDJPYAmount"),
        '            .JPYPHPAmount = i("JPYPHPAmount")
        '}).ToList()
        'Dim dtList As DataTable = convertToDatatable(query)

        'Table2.DataSource = dtList

        'ConBCS.addParameter("DEPT", parDept)
        'ConBCS.addParameter("Class", parClass)
        'ConBCS.addParameter("BYEAR", parYear)
        'Dim dtrep As DataTable = ConBCS.dbSelect("SP_repFBperAmountClassv2")
        'Table1.DataSource = dtrep

    End Sub

    'Public Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
    '    Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
    '    Dim table As DataTable = New DataTable()

    '    For Each prop As PropertyDescriptor In properties
    '        table.Columns.Add(prop.Name)
    '    Next

    '    For Each item As T In data
    '        Dim row As DataRow = table.NewRow()

    '        For Each prop As PropertyDescriptor In properties
    '            row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
    '        Next

    '        table.Rows.Add(row)
    '    Next

    '    Return table
    'End Function

End Class