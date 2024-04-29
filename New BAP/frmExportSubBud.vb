Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmExportSubBud
    Private dtSBudRec As DataTable
    Private Sub FrmExportSubBud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGridSubBud()
    End Sub
    Public Sub ReadyGridSubBud()
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
            '.IsPinned = True
            ' .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        'Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REFERENCE NO.")
        'With fldMajorRefNo
        '    .FieldName = "fldMajorRefNo"
        '    .Width = 150
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    ' .IsPinned = True
        '    .IsVisible = True
        '    '  .PinPosition = PinnedColumnPosition.Left
        'End With
        'rgvList.Columns.Add(fldMajorRefNo)


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

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
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

    Private Sub FrmExportSubBud_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchData()
        CBYear.Items.Add("2025")
    End Sub
    Public Sub FetchData()
        Zaji.addParameter("_Year", CBYear.Text)
        dtSBudRec = Zaji.dbSelect("SP_SelectSubBudByYear")
        rgvList.DataSource = dtSBudRec
    End Sub

    Private Sub cbSubmit_Click(sender As Object, e As EventArgs) Handles cbSubmit.Click
        FetchData()
    End Sub
End Class
