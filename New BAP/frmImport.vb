Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports Telerik.Reporting.Processing
Imports System.IO
Imports Telerik.WinControls.UI.Export
Imports System.Text.RegularExpressions

Public Class FrmImport
    Private dtSubBudget As DataTable
    Private Sub FrmImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtSubBudget = Zaji.dbSelect("SP_SelectAllBudget")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Try
        Dim filename As String = rbeGetData.Value.ToString

            Dim cn As System.Data.OleDb.OleDbConnection
            Dim cmd As System.Data.OleDb.OleDbDataAdapter
            Dim dt As New DataTable

            cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filename & ";Extended Properties=Excel 12.0;")

            cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", cn)
            cn.Open()
            cmd.Fill(dt)
            cn.Close()

            globalVariables.dtImport = dt
            If globalVariables.ImportSelect = "SUB BUDGET" Then
                ImportSubBudget()
            Else

            End If
        'Catch ex As Exception
        '    RadMessageBox.SetThemeName("TelerikvisualStudio2012Light")
        '    RadMessageBox.Show("Please rename Excel sheet to Sheet1", "INFO", MessageBoxButtons.OK, RadMessageIcon.Info)

        'End Try

    End Sub
    Public Sub ImportSubBudget()
        'Try
        FrmAddSubBudget.rgvList.DataSource = Nothing

            Dim table As DataTable = globalVariables.dtImport

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Let _CheckifExist = CheckifExist(T0.Item(1))
                                        Select New With
                                             {
                                                .fldMajorRefNo = Regex.Replace(Trim(T0.Item(0)), "\s+", " ").ToString(),
                                                .fldDept = Regex.Replace(Trim(T0.Item(2)), "\s+", " "),
                                                .fldClass = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                                                .fldBudRefNum = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                                                .fldStat = Regex.Replace(Trim(T0.Item(4)), "\s+", " "),
                                                .fldCurrency = Regex.Replace(Trim(T0.Item(5)), "\s+", " "),
                                                .fldAmount = IIf(Not String.IsNullOrEmpty(T0.Item(6)), T0.Item(6), 0),
                                                .fldYen = IIf(Not String.IsNullOrEmpty(T0.Item(7)), T0.Item(7), 0),
                                                .fldProcess = Regex.Replace(Trim(T0.Item(8)), "\s+", " "),
                                                .fldQTY = IIf(Not String.IsNullOrEmpty(T0.Item(9)), T0.Item(9), 0),
                                                .fldUOM = Regex.Replace(Trim(T0.Item(10)), "\s+", " "),
                                                .fldSOU = Convert.ToDateTime(T0.Item(11)),
                                                .fldDesc = Regex.Replace(Trim(T0.Item(12)), "\s+", " "),
                                                .fldMBudgeted = Convert.ToDateTime(T0.Item(13)),
                                                .CheckifExist = If(_CheckifExist Is Nothing, "doesn't exist", "existing")
                                             }).ToList
            FrmAddSubBudget.rgvList.DataSource = Query
        'Catch ex As Exception
        '    MessageBox.Show("Error please contact MIS")
        'End Try

    End Sub
    Function CheckifExist(ByVal SubBudget As String)
        Dim Query = (From i In dtSubBudget.AsEnumerable()
                     Where Convert.ToString(i("fldBudRefNum")) = SubBudget
                     Select Convert.ToString(i("fldBudRefNum"))).FirstOrDefault()

        Return Convert.ToString(Query)
    End Function
End Class

