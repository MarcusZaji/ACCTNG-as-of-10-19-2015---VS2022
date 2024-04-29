Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports Telerik.Reporting.Processing
Imports System.IO

Public Class frmUpBC

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

        Try

            Dim filename As String = rbeGetData.Value.ToString

            Dim cn As System.Data.OleDb.OleDbConnection
            Dim cmd As System.Data.OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source=" & filename & ";Extended Properties=Excel 8.0;")

            ' Select the data from Sheet1 of the workbook.
            cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [SHEET1$]", cn)
            cn.Open()
            cmd.Fill(dt)
            cn.Close()
            rgvList.Columns.Clear()
            'ReadyGrid()
            rgvList.DataSource = dt

        Catch ex As Exception
            imBusy = False
            GoodToGo = False
            RadMessageBox.Show(ex.Message)
        End Try

        imBusy = False

        If GoodToGo = True Then
            btnUpload.Enabled = True
        Else
            btnUpload.Enabled = False
        End If
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim LoadCount As Integer

        If rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item to Add/Update! Please Add Items", "Order Added", MessageBoxButtons.OK)

        Else

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to Upload this item(s)?",
                      "Upload Consolidated Budget", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

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

                    Dim BCRefNo, BudRefNum, Dept, ActivityCode, Classification, ClassCode,
                        SubClass, SubClassCode, Desc, Process, UOM, Currency, Stat As String
                    Dim QTY, YEN, Amount As Decimal
                    Dim SOU, MBudgeted As Date


                    '----- ADD TO tblFinalBudget -----'

                    For x As Integer = 0 To rgvList.Rows.Count - 1
                        imBusy = True

                        BCRefNo = rgvList.Rows(x).Cells(0).Value.ToString
                        BudRefNum = rgvList.Rows(x).Cells(1).Value.ToString
                        Dept = rgvList.Rows(x).Cells(2).Value.ToString
                        ActivityCode = rgvList.Rows(x).Cells(3).Value.ToString
                        Desc = rgvList.Rows(x).Cells(4).Value.ToString
                        Classification = rgvList.Rows(x).Cells(5).Value.ToString
                        ClassCode = rgvList.Rows(x).Cells(6).Value.ToString
                        SubClass = rgvList.Rows(x).Cells(7).Value.ToString
                        SubClassCode = rgvList.Rows(x).Cells(8).Value.ToString
                        Process = rgvList.Rows(x).Cells(9).Value.ToString
                        Currency = rgvList.Rows(x).Cells(10).Value.ToString
                        YEN = rgvList.Rows(x).Cells(11).Value
                        Amount = rgvList.Rows(x).Cells(12).Value
                        QTY = rgvList.Rows(x).Cells(13).Value
                        UOM = rgvList.Rows(x).Cells(14).Value.ToString
                        SOU = rgvList.Rows(x).Cells(15).Value
                        MBudgeted = rgvList.Rows(x).Cells(16).Value
                        Stat = rgvList.Rows(x).Cells(17).Value.ToString

                        myCmd.CommandText = "INSERT INTO tblFinalBudget " _
                            & "(fldBCRefNo, fldBudRefNo, fldDept, fldActivityCode, fldDesc, fldClass, " _
                            & "fldClassCode, fldSubClass, fldSubClassCode, fldProcess," _
                            & "fldCurrency, fldYEN, fldAmount, " _
                            & "fldQTY, fldUOM, fldSOU, fldMonthBudgeted, fldStatus) " _
                            & "VALUES " _
                            & "(@fldBCRefNo, @fldBudRefNo, @fldDept, @fldActivityCode, @fldDesc, @fldClass, " _
                            & "@fldClassCode, @fldSubClass, @fldSubClassCode, @fldProcess, " _
                            & "@fldCurrency, @fldYEN, @fldAmount, " _
                            & "@fldQTY, @fldUOM, @fldSOU, @fldMonthBudgeted, @fldStatus) "

                        With myCmd
                            .Parameters.AddWithValue("@fldBCRefNo", BCRefNo)
                            .Parameters.AddWithValue("@fldBudRefNo", BudRefNum)
                            .Parameters.AddWithValue("@fldDept", Dept)
                            .Parameters.AddWithValue("@fldActivityCode", ActivityCode)
                            .Parameters.AddWithValue("@fldDesc", Desc)
                            .Parameters.AddWithValue("@fldClass", Classification)
                            .Parameters.AddWithValue("@fldClassCode", ClassCode)
                            .Parameters.AddWithValue("@fldSubClass", SubClass)
                            .Parameters.AddWithValue("@fldSubClassCode", SubClassCode)
                            .Parameters.AddWithValue("@fldProcess", Process)
                            .Parameters.AddWithValue("@fldCurrency", Currency)
                            .Parameters.AddWithValue("@fldYEN", YEN)
                            .Parameters.AddWithValue("@fldAmount", Amount)
                            .Parameters.AddWithValue("@fldQTY", QTY)
                            .Parameters.AddWithValue("@fldUOM", UOM)
                            .Parameters.AddWithValue("@fldSOU", SOU)
                            .Parameters.AddWithValue("@fldMonthBudgeted", MBudgeted)
                            .Parameters.AddWithValue("@fldStatus", Stat)
                        End With

                        myCmd.ExecuteNonQuery()
                        myCmd.Parameters.Clear()

                        pbOlrayt.PerformStep()
                    Next

                    imBusy = False

                Catch ex As Exception

                End Try

                conn.Close()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Uploading Complete", "Upload Success", MessageBoxButtons.OK)
                rgvList.Columns.Clear()
                btnUpload.Enabled = False
                rbeGetData.Text = ""
                rbeGetData.Focus()

                pbOlrayt.Visible = False

            End If

        End If

    End Sub

    Private Sub frmUpBC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
