Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmUploadSubBud
    Public linestat As String
    Public lineNo As Integer
    Private Sub FrmUploadSubBud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGridSubBud()
    End Sub
    Private Sub cbImport_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub cbExport2_Click(sender As Object, e As EventArgs) Handles cbExport2.Click
        If rgvList.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.rgvList)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub
    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBar1.Text = e.ProgressPercentage & "%"
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub
    Public Sub ReadyGridSubBud()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS") With {
            .FieldName = "STATUS",
            .Width = 60,
            .TextAlignment = ContentAlignment.MiddleCenter,
            .ReadOnly = True,
            .IsPinned = True,
            .PinPosition = PinnedColumnPosition.Left
        }
        rgvList.Columns.Add(fldStatColumn)

        Dim fldBIDColumn As New GridViewTextBoxColumn("ID")
        With fldBIDColumn
            .FieldName = "fldBudgetID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldBIDColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REFERENCE NO.")
        With fldMajorRefNo
            .FieldName = "fldMajorRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldMajorRefNo)


        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldAmountColumn As New GridViewDecimalColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmount").FormatString = "{0:N2}"

        Dim fldAmountJPYColumn As New GridViewDecimalColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "fldYen"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("fldYen").FormatString = "{0:N2}"

        Dim fldSOUColumn As New GridViewDateTimeColumn("START OF USE")
        With fldSOUColumn
            .FieldName = "fldSOU"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldSOUColumn)
        rgvList.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDescColumn As New GridViewTextBoxColumn("BUDGET DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 600
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldMBudgetedColumn As New GridViewDateTimeColumn("MONTH BUDGETED")
        With fldMBudgetedColumn
            .FieldName = "fldMBudgeted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMBudgetedColumn)
        rgvList.Columns("fldMBudgeted").FormatString = "{0:MMM dd, yyyy}"
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30
        For counter As Integer = 0 To rgvList.Rows.Count - 1
            Zaji.addParameter("ID", rgvList.Rows(counter).Cells("fldBudgetID").Value)
            Zaji.addParameter("BudRefNum", Regex.Replace(rgvList.Rows(counter).Cells("fldBudRefNum").Value, "\s+", " "))
            Zaji.addParameter("Currency", Regex.Replace(rgvList.Rows(counter).Cells("fldCurrency").Value, "\s+", " "))
            Zaji.addParameter("Amount", Convert.ToDecimal(rgvList.Rows(counter).Cells("fldAmount").Value))
            Zaji.addParameter("Yen", Convert.ToDecimal(rgvList.Rows(counter).Cells("fldYen").Value))
            Zaji.addParameter("SOU", Convert.ToDateTime(rgvList.Rows(counter).Cells("fldSOU").Value))
            Zaji.addParameter("_Desc", Regex.Replace(rgvList.Rows(counter).Cells("fldDesc").Value, "\s+", " "))
            Zaji.addParameter("MBudgeted", Convert.ToDateTime(rgvList.Rows(counter).Cells("fldMBudgeted").Value))
            Zaji.addParameter("UpdatedBy", globalVariables.LoginSignature)

            If Zaji.dbAED("SP_UpdateUploadSubBudget") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / rgvList.Rows.Count * 100
            lineNo = counter
            RadProgressBar1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)

        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        rgvList.CurrentRow = rgvList.Rows(lineNo)
        rgvList.CurrentRow.Cells(0).Value = linestat
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBar1.Text = "Done"
        RadProgressBar1.Value1 = 100
        RadMessageBox.Show("Successfully Uploaded", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub cbImport2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbPaste_Click(sender As Object, e As EventArgs) Handles cbPaste.Click
        rgvList.DataSource = Nothing

        Dim table As DataTable = Zaji.getClipboard

        Dim Query = (From i In table.AsEnumerable()
                     Select New With
                         {
                            .fldBudgetID = Regex.Replace(Trim(i.Item(0)), "\s+", " "),
                            .fldBudRefNum = Regex.Replace(Trim(i.Item(1)), "\s+", " "),
                            .fldCurrency = Regex.Replace(Trim(i.Item(2)), "\s+", " "),
                            .fldAmount = IIf(Not String.IsNullOrEmpty(i.Item(3)), i.Item(3), 0),
                            .fldYen = IIf(Not String.IsNullOrEmpty(i.Item(4)), i.Item(4), 0),
                            .fldSOU = i.Item(5),
                            .fldDesc = Regex.Replace(Trim(i.Item(6)), "\s+", " "),
                            .fldMBudgeted = i.Item(7)
                         }).ToList

        rgvList.DataSource = Query
    End Sub

    Private Sub cbImport_Click_1(sender As Object, e As EventArgs) Handles cbImport.Click
        bwUpload.RunWorkerAsync()
    End Sub
End Class
