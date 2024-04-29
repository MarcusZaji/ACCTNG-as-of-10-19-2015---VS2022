Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmBudgetHistory
    Private Sub FrmBudgetHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGridSBudget()
    End Sub
    Private Sub ReadyGridSBudget()
        '-----------------'
        '--MASTER BUDGET--'
        '-----------------'

        Dim fldBIDColumn As New GridViewDecimalColumn("ID")
        With fldBIDColumn
            .FieldName = "fldBudgetID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvSBudget.Columns.Add(fldBIDColumn)


        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldDeptColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldClassColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvSBudget.Columns.Add(fldBudRefColumn)

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REFERENCE NO.")
        With fldMajorRefNo
            .FieldName = "fldMajorRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .IsVisible = False
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvSBudget.Columns.Add(fldMajorRefNo)

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldStat"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE"}
        End With
        rgvSBudget.Columns.Add(fldStatusColumn)

        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
        End With
        rgvSBudget.Columns.Add(fldCurrencyColumn)

        Dim fldAmountColumn As New GridViewDecimalColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldAmountColumn)
        rgvSBudget.Columns("fldAmount").FormatString = "{0:N2}"

        Dim fldAmountJPYColumn As New GridViewDecimalColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "fldYen"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldAmountJPYColumn)
        rgvSBudget.Columns("fldYen").FormatString = "{0:N2}"

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvSBudget.Columns.Add(fldUOMColumn)

        Dim fldSOUColumn As New GridViewDateTimeColumn("START OF USE")
        With fldSOUColumn
            .FieldName = "fldSOU"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvSBudget.Columns.Add(fldSOUColumn)
        rgvSBudget.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDescColumn As New GridViewTextBoxColumn("BUDGET DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 600
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldDescColumn)

        Dim fldMBudgetedColumn As New GridViewDateTimeColumn("MONTH BUDGETED")
        With fldMBudgetedColumn
            .FieldName = "fldMBudgeted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvSBudget.Columns.Add(fldMBudgetedColumn)
        rgvSBudget.Columns("fldMBudgeted").FormatString = "{0:MMM dd, yyyy}"

        Dim fldUpdatedBy As New GridViewTextBoxColumn("UPDATED BY")
        With fldUpdatedBy
            .FieldName = "fldUpdateBy"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSBudget.Columns.Add(fldUpdatedBy)

        Dim fldDateAdded As New GridViewDateTimeColumn("DATE ADDED")
        With fldDateAdded
            .FieldName = "fldDateAdded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvSBudget.Columns.Add(fldDateAdded)
        rgvSBudget.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy}"

        With rgvSBudget
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub
    Public Sub SelectMajorBudget()
        Dim dtMBudRec As DataTable = Zaji.dbSelect("SP_SelectBudgetLogs")
        rgvSBudget.DataSource = dtMBudRec
    End Sub

    Private Sub FrmBudgetHistory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SelectMajorBudget()
    End Sub
End Class
