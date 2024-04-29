Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports Telerik.Reporting.Processing
Imports System.IO

Public Class FrmUpPO

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub rgvList_FilterChanged(sender As Object, e As Telerik.WinControls.UI.GridViewCollectionChangedEventArgs) Handles rgvList.FilterChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub btnViewData_Click(sender As Object, e As EventArgs) Handles btnViewData.Click
        Dim GoodToGo As Boolean = True

        Try

            Dim filename As String = rbeGetData.Value.ToString

            Dim cn As System.Data.OleDb.OleDbConnection
            Dim cmd As System.Data.OleDb.OleDbDataAdapter
            Dim dt As New DataTable
            'cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" & "data source=" & filename & ";Extended Properties=Excel 8.0;")
            cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filename & ";Extended Properties=Excel 12.0;")
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
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show(ex.Message)
        End Try

        imBusy = False

        If GoodToGo = True Then
            btnUpload.Enabled = True
        Else
            btnUpload.Enabled = False
        End If

    End Sub

    Public Sub Busy()
        Timer1.Start()
        For Each frm As Form In My.Application.OpenForms

            'If Not frm.Name = "frmSaveReport" Then
            frm.Cursor = Cursors.WaitCursor
            '            End If
        Next
        imBusy = True
        Application.AddMessageFilter(Me)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If imBusy = False Then
            Timer1.Stop()
            For Each frm As Form In My.Application.OpenForms
                frm.Cursor = Cursors.Arrow
            Next
            Application.RemoveMessageFilter(Me)
        End If
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
        frmUploadPicker.rbUpItem.IsChecked = False
        frmUploadPicker.rbUpBudget.IsChecked = False
        frmUploadPicker.rbUpBC.IsChecked = False
        frmUploadPicker.rbUpPO.IsChecked = False

    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim LoadCount As Integer

        If rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item to Add/Update! Please Add Items", "Order Added", MessageBoxButtons.OK)

        Else

            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to Upload this item(s)?",
                      "Upload PO", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Try
                    LoadCount = rgvList.Rows.Count

                    With pbOlrayt
                        .Minimum = 1
                        .Maximum = LoadCount
                        .Value = 1
                        .Step = 1
                        .Visible = True
                    End With

                    conn.Open()
                    myCmd.Connection = conn

                    Dim BRN, Dept, fldPONo, Currency, Supplier, Classification, POOnly, SubRefNo As String
                    Dim OAmount, JPYAmount, JPYBAP, Forex As Decimal
                    Dim DDate, UDate As Date

                    For x As Integer = 0 To rgvList.Rows.Count - 1
                        BRN = rgvList.Rows(x).Cells(0).Value
                        Dept = rgvList.Rows(x).Cells(1).Value
                        fldPONo = rgvList.Rows(x).Cells(2).Value
                        OAmount = rgvList.Rows(x).Cells(3).Value
                        Currency = rgvList.Rows(x).Cells(4).Value
                        JPYAmount = rgvList.Rows(x).Cells(5).Value
                        Classification = rgvList.Rows(x).Cells(6).Value
                        Supplier = rgvList.Rows(x).Cells(7).Value
                        DDate = rgvList.Rows(x).Cells(8).Value
                        JPYBAP = rgvList.Rows(x).Cells(9).Value
                        Forex = rgvList.Rows(x).Cells(10).Value
                        POOnly = rgvList.Rows(x).Cells(11).Value
                        SubRefNo = rgvList.Rows(x).Cells(12).Value
                        'UDate = Convert.ToDateTime(Format("{0:yyyy-MM-dd}", Today))

                        myCmd.CommandText = "INSERT INTO tblUPO " _
                            & "(fldBudRefNum, fldDept, fldOAmount, fldJPY, fldCurrency, " _
                            & "fldPONo, fldDDate, fldSupplier, fldClass, fldJPYBAP, fldForex, fldPOOnly, fldSubRefNo) " _
                            & "VALUES " _
                            & "(@fldBudRefNum, @fldDept, @fldOAmount, @fldJPY, @fldCurrency, " _
                            & "@fldPONo, @fldDDate, @fldSupplier, @fldClass, @fldJPYBAP, @fldForex, @fldPOOnly, @SubRefNo)"

                        With myCmd.Parameters
                            .AddWithValue("@fldBudRefNum", BRN)
                            .AddWithValue("@fldDept", Dept)
                            .AddWithValue("@fldOAmount", OAmount)
                            .AddWithValue("@fldJPY", JPYAmount)
                            .AddWithValue("@fldCurrency", Currency)
                            .AddWithValue("@fldPONo", fldPONo)
                            '.AddWithValue("@fldUDate", UDate)
                            .AddWithValue("@fldDDate", DDate)
                            .AddWithValue("@fldSupplier", Supplier)
                            .AddWithValue("@fldClass", Classification)
                            .AddWithValue("@fldJPYBAP", JPYBAP)
                            .AddWithValue("@fldForex", Forex)
                            .AddWithValue("@fldPOOnly", POOnly)
                            .AddWithValue("@SubRefNo", SubRefNo)
                        End With

                        myCmd.ExecuteNonQuery()
                        myCmd.Parameters.Clear()

                        pbOlrayt.PerformStep()
                    Next

                    conn.Close()
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Uploading Complete", "Upload Success", MessageBoxButtons.OK)
                    rgvList.Columns.Clear()
                    btnUpload.Enabled = False

                    pbOlrayt.Visible = False
                Catch ex As Exception

                End Try

            End If

        End If

    End Sub

    Private Sub FrmUpPO_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
