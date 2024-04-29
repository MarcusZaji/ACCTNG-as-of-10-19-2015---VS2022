Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports Telerik.Reporting.Processing
Imports System.IO
Imports Telerik.WinControls.UI.Export

Public Class FrmUpBud

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub rgvList_FilterChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles rgvList.FilterChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
        frmUploadPicker.rbUpItem.IsChecked = False
        frmUploadPicker.rbUpBudget.IsChecked = False
        frmUploadPicker.rbUpBC.IsChecked = False
        frmUploadPicker.rbUpPO.IsChecked = False
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        Dim GoodToGo As Boolean = True

        'Try

        Dim filename As String = rbeGetData.Value.ToString

        Dim cn As System.Data.OleDb.OleDbConnection
        Dim cmd As System.Data.OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source=" & filename & ";Extended Properties=Excel 8.0;")
        'cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filename & ";Extended Properties=Excel 12.0;")


        ' Select the data from Sheet1 of the workbook.
        cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [SHEET1$]", cn)
        cn.Open()
        cmd.Fill(dt)
        cn.Close()
        rgvList.Columns.Clear()
        'ReadyGrid()
        rgvList.DataSource = dt

        ' Catch ex As Exception
        'imBusy = False
        'GoodToGo = False
        ' RadMessageBox.Show(ex.Message)
        ' End Try

        ' imBusy = False

        If GoodToGo = True Then
            btnUpload.Enabled = True
        Else
            btnUpload.Enabled = False
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim LoadCount As Integer

        If rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item to Add/Update! Please Add Items", "Order Added", MessageBoxButtons.OK)

        Else

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to Upload this item(s)?",
                      "Upload Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Try
                    conn.Open()
                    myCmd.Connection = conn

                    LoadCount = rgvList.Rows.Count

                    With pbOlrayt
                        .Minimum = 1
                        .Maximum = LoadCount
                        .Value = 1
                        .Step = 1
                        .Visible = True
                    End With

                    Dim BudRefNum As String
                    Dim Dept As String
                    Dim Classification As String
                    Dim Desc As String
                    Dim Process As String
                    Dim QTY As Decimal
                    Dim UOM As String
                    Dim SOU As Date
                    Dim Currency As String
                    Dim Amount As Decimal
                    Dim YEN As Decimal
                    Dim MBudgeted As Date
                    Dim Stat As String

                    imBusy = True

                    '----- ADD TO tblBudget -----'

                    For x As Integer = 0 To rgvList.Rows.Count - 1
                        BudRefNum = rgvList.Rows(x).Cells(0).Value.ToString
                        Dept = rgvList.Rows(x).Cells(1).Value.ToString
                        Desc = rgvList.Rows(x).Cells(2).Value.ToString
                        Classification = rgvList.Rows(x).Cells(3).Value.ToString
                        Process = rgvList.Rows(x).Cells(4).Value.ToString
                        Currency = rgvList.Rows(x).Cells(5).Value.ToString
                        YEN = rgvList.Rows(x).Cells(6).Value
                        Amount = rgvList.Rows(x).Cells(7).Value
                        QTY = rgvList.Rows(x).Cells(8).Value
                        UOM = rgvList.Rows(x).Cells(9).Value.ToString
                        SOU = rgvList.Rows(x).Cells(10).Value
                        MBudgeted = rgvList.Rows(x).Cells(11).Value
                        Stat = rgvList.Rows(x).Cells(12).Value.ToString

                        myCmd.CommandText = "INSERT INTO tblBudget " _
                            & "(fldBudRefNum,fldDept,fldDesc,fldClass,fldProcess," _
                            & "fldCurrency,fldYen,fldAmount," _
                            & "fldQTY,fldUOM,fldSOU,fldMBudgeted,fldStat) " _
                            & "VALUES " _
                            & "(@fldBudRefNum,@fldDept,@fldDesc,@fldClass,@fldProcess," _
                            & "@fldCurrency,@fldYen,@fldAmount," _
                            & "@fldQTY,@fldUOM,@fldSOU,@fldMBudgeted,@fldStat) "

                        With myCmd
                            .Parameters.AddWithValue("@fldBudRefNum", BudRefNum)
                            .Parameters.AddWithValue("@fldDept", Dept)
                            .Parameters.AddWithValue("@fldDesc", Desc)
                            .Parameters.AddWithValue("@fldClass", Classification)
                            .Parameters.AddWithValue("@fldProcess", Process)
                            .Parameters.AddWithValue("@fldCurrency", Currency)
                            .Parameters.AddWithValue("@fldYen", YEN)
                            .Parameters.AddWithValue("@fldAmount", Amount)
                            .Parameters.AddWithValue("@fldQTY", QTY)
                            .Parameters.AddWithValue("@fldUOM", UOM)
                            .Parameters.AddWithValue("@fldSOU", SOU)
                            .Parameters.AddWithValue("@fldMBudgeted", MBudgeted)
                            .Parameters.AddWithValue("@fldStat", Stat)
                        End With

                        myCmd.ExecuteNonQuery()
                        myCmd.Parameters.Clear()

                        pbOlrayt.PerformStep()
                    Next

                Catch ex As Exception

                End Try

                Try
                    conn2.Open()
                    myCmd2.Connection = conn

                    LoadCount = rgvList.Rows.Count

                    With pbOlrayt
                        .Minimum = 1
                        .Maximum = LoadCount
                        .Value = 1
                        .Step = 1
                        .Visible = True
                    End With

                    Dim revBudRefNum As String
                    'Dim Dept As String
                    Dim revDesc As String
                    'Dim Classification As String
                    'Dim Process As String
                    Dim revCurrency As String
                    Dim revYEN As Decimal
                    Dim revAmount As Decimal
                    Dim revQTY As Integer
                    Dim revUOM As String
                    Dim revSOU As Date
                    'Dim MBudgeted As Date
                    Dim revStat As String

                    '----- ADD TO tblRevision -----'

                    For x As Integer = 0 To rgvList.Rows.Count - 1
                        revBudRefNum = rgvList.Rows(x).Cells(0).Value.ToString
                        'Dept = rgvList.Rows(x).Cells(1).Value
                        revDesc = rgvList.Rows(x).Cells(2).Value.ToString
                        'Classification = rgvList.Rows(3).Cells(0).Value
                        'Process = rgvList.Rows(x).Cells(4).Value
                        revCurrency = rgvList.Rows(x).Cells(5).Value.ToString
                        revYEN = rgvList.Rows(x).Cells(6).Value
                        revAmount = rgvList.Rows(x).Cells(7).Value
                        revQTY = rgvList.Rows(x).Cells(8).Value
                        revUOM = rgvList.Rows(x).Cells(9).Value.ToString
                        revSOU = rgvList.Rows(x).Cells(10).Value
                        'MBudgeted = rgvList.Rows(x).Cells(11).Value
                        revStat = rgvList.Rows(x).Cells(12).Value.ToString


                        myCmd2.CommandText = "INSERT INTO tblRevision (fldBudRefNum,fldStat,fldRevAmount,fldDesc,fldYen,fldCurrency,fldQTY,fldUOM,fldSOU) " _
                               & "VALUES " _
                               & "(@fldBudRefNum,@fldStat,@fldRevAmount,@fldDesc,@fldYen,@fldCurrency,@fldQTY,@fldUOM,@fldSOU)"

                        With myCmd2
                            .Parameters.AddWithValue("@fldBudRefNum", revBudRefNum)
                            .Parameters.AddWithValue("@fldDesc", revDesc)
                            .Parameters.AddWithValue("@fldCurrency", revCurrency)
                            .Parameters.AddWithValue("@fldYen", revYEN)
                            .Parameters.AddWithValue("@fldRevAmount", revAmount)
                            .Parameters.AddWithValue("@fldQTY", revQTY)
                            .Parameters.AddWithValue("@fldUOM", revUOM)
                            .Parameters.AddWithValue("@fldSOU", revSOU)
                            .Parameters.AddWithValue("@fldStat", revStat)
                        End With

                        myCmd2.ExecuteNonQuery()
                        myCmd2.Parameters.Clear()

                        pbOlrayt.PerformStep()
                    Next

                    conn.Close()
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Uploading Complete", "Upload Success", MessageBoxButtons.OK)
                    rgvList.Columns.Clear()
                    btnUpload.Enabled = False
                    rbeGetData.Text = ""
                    rbeGetData.Focus()

                    pbOlrayt.Visible = False
                Catch ex As Exception

                End Try

                imBusy = False

            End If

        End If

    End Sub

    Private Sub FrmUpBud_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub rbeGetData_ValueChanged(sender As Object, e As EventArgs) Handles rbeGetData.ValueChanged

    End Sub

    Private Sub btnPaste_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub FrmUpBud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
