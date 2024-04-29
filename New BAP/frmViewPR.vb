Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Public Class FrmViewPR
    Private Sub FrmViewPR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
    End Sub
    Private Sub FrmViewPR_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
    Private Sub ReadyGrid()

        Dim fldOIDColumn As New GridViewDecimalColumn("ID")
        With fldOIDColumn
            .FieldName = "fldOrderID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldOIDColumn)

        Dim fldTransCodeColumn As New GridViewDecimalColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldTransCodeColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("MAJOR BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldPRNumColumn As New GridViewTextBoxColumn("PR NUMBER")
        With fldPRNumColumn
            .FieldName = "fldPRNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = Left
        End With
        rgvList.Columns.Add(fldPRNumColumn)

        Dim fldMOrderedColumn As New GridViewDateTimeColumn("MONTH ORDERED")
        With fldMOrderedColumn
            .FieldName = "fldMonthOrder"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMOrderedColumn)
        rgvList.Columns("fldMonthOrder").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDescriptionColumn As New GridViewTextBoxColumn("DESCRITION")
        With fldDescriptionColumn
            .FieldName = "fldOrderDesc"
            .Width = 300
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDescriptionColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClassification"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldOrderDepartment"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUnitPrice As New GridViewDecimalColumn("UNIT PRICE")
        With fldUnitPrice
            .FieldName = "fldUnitPrice"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldUnitPrice)
        rgvList.Columns("fldUnitPrice").FormatString = "{0:N6}"

        Dim fldTotalCost As New GridViewDecimalColumn("TOTAL COST")
        With fldTotalCost
            .FieldName = "fldTotalCost"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTotalCost)
        rgvList.Columns("fldTotalCost").FormatString = "{0:N6}"

        Dim fldRQTYColumn As New GridViewTextBoxColumn("REMAINING QUANTITY")
        With fldRQTYColumn
            .FieldName = "RQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldRQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldOrderStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE", "REMOVED"}
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldStatusColumn)

        Dim myStatColumn As New GridViewComboBoxColumn("myStat")
        With myStatColumn
            .FieldName = "myStat"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE", "REMOVED"}
            .IsVisible = False
        End With
        rgvList.Columns.Add(myStatColumn)

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldOrderRemarks"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRemarksColumn)

        Dim fldEOAColumn As New GridViewDecimalColumn("ESTIMATED PR AMOUNT")
        With fldEOAColumn
            .FieldName = "fldEOA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldEOAColumn)
        rgvList.Columns("fldEOA").FormatString = "{0:N6}"

        Dim fldECColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldECColumn
            .FieldName = "fldEC"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldECColumn)

        Dim fldEJPYColumn As New GridViewDecimalColumn("ESTIMATED PR AMOUNT (JPY)")
        With fldEJPYColumn
            .FieldName = "fldEJPY"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldEJPYColumn)
        rgvList.Columns("fldEJPY").FormatString = "{0:N6}"

        Dim fldTOPRAColumn As New GridViewDecimalColumn("OPEN PR AMOUNT")
        With fldTOPRAColumn
            .FieldName = "fldTOPRA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTOPRAColumn)
        rgvList.Columns("fldTOPRA").FormatString = "{0:N6}"

        Dim fldTDOPRAColumn As New GridViewDecimalColumn("OPEN DEPT. PR AMOUNT")
        With fldTDOPRAColumn
            .FieldName = "fldTDOPRA"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTDOPRAColumn)
        rgvList.Columns("fldTDOPRA").FormatString = "{0:N6}"

        Dim fldSignatureColumn As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .Width = 180
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSignatureColumn)

        Dim fldDeleteColumn As New GridViewCommandColumn("    ")
        With fldDeleteColumn
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .UseDefaultText = True
            .DefaultText = "REMOVE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

        Dim fldMoldDie As New GridViewTextBoxColumn("Mold Die Name")
        With fldMoldDie
            .FieldName = "fldMoldDie"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter

        End With
        rgvList.Columns.Add(fldMoldDie)

        With rgvList
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            .ShowGroupPanel = True
            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub
    Private Sub ReadyPRGrid()

        Dim fldUC4SColumn As New GridViewTextBoxColumn("UC4S")
        With fldUC4SColumn
            .FieldName = "fldUC4S"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldUC4SColumn)

        Dim fldMOIIDColumn As New GridViewTextBoxColumn("MOIID")
        With fldMOIIDColumn
            .FieldName = "fldMOIID"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldMOIIDColumn)

        Dim fldTransCodeColumn As New GridViewTextBoxColumn("TransCode")
        With fldTransCodeColumn
            .FieldName = "fldTransCode"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvListItem.Columns.Add(fldTransCodeColumn)

        Dim fldBudRefNumColumn As New GridViewTextBoxColumn("BUDGET REF. NO.")
        With fldBudRefNumColumn
            .FieldName = "fldBudRefNum"
            .Width = 160
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvListItem.Columns.Add(fldBudRefNumColumn)

        Dim fldICodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldICodeColumn
            .FieldName = "fldICode"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldICodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldDescColumn)

        Dim fldQTYColumn As New GridViewTextBoxColumn("PR QTY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldQTYColumn)

        Dim fldQTYEBColumn As New GridViewTextBoxColumn("REMAINING QTY")
        With fldQTYEBColumn
            .FieldName = "fldQTYEB"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldQTYEBColumn)

        Dim fldQTYSOUTColumn As New GridViewTextBoxColumn("PO QTY")
        With fldQTYSOUTColumn
            .FieldName = "fldQTYSOUT"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldQTYSOUTColumn)

        Dim fldUnitColumn As New GridViewTextBoxColumn("UNIT")
        With fldUnitColumn
            .FieldName = "fldUnit"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldUnitColumn)

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "fldStat"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = Right
        End With
        rgvListItem.Columns.Add(fldStatColumn)

        Dim fldRSColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRSColumn
            .FieldName = "fldRS"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvListItem.Columns.Add(fldRSColumn)

        With rgvListItem
            .EnableAlternatingRowColor = True
            .ShowGroupPanel = True
            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

End Class
