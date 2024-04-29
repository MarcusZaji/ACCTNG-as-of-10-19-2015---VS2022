Imports Telerik.WinControls.UI
Imports Telerik.WinControls
Imports MySql.Data.MySqlClient
Imports Telerik.Reporting.Processing
Imports System.IO

Public Class FrmUpItem

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

        If rgvList.RowCount = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Item to Add/Update! Please Add Items", "Order Added", MessageBoxButtons.OK)

        Else

            Try
                conn.Open()
                myCmd.Connection = conn

                Dim ItemCode, Desc, Category, Status As String

                For x As Integer = 0 To rgvList.Rows.Count - 1
                    ItemCode = rgvList.Rows(x).Cells(0).Value
                    Desc = rgvList.Rows(x).Cells(1).Value
                    Category = rgvList.Rows(x).Cells(2).Value
                    ' UOM = rgvList.Rows(x).Cells(3).Value
                    Status = rgvList.Rows(x).Cells(3).Value

                    myCmd.CommandText = "INSERT INTO tblIM(fldIMItemCode, fldIMItemDesc, fldIMCat, fldStat) " _
                                     & "values(@fldIMItemCode,@fldIMItemDesc,@fldIMCat,@fldStat)"

                    With myCmd.Parameters
                        .AddWithValue("@fldIMItemCode", ItemCode)
                        .AddWithValue("@fldIMItemDesc", Desc)
                        .AddWithValue("@fldIMCat", Category)
                        '.AddWithValue("@fldIMUOM", UOM)
                        .AddWithValue("@fldStat", Status)
                    End With

                    myCmd.ExecuteNonQuery()
                    myCmd.Parameters.Clear()

                Next

                conn.Close()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Uploading Complete", "Upload Success", MessageBoxButtons.OK)
                rgvList.Columns.Clear()
                btnUpload.Enabled = False

            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub FrmUpItem_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
