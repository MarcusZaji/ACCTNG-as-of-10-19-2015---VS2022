Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmAcctngSync

    Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
    Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

    Dim OLD_DATA2 As String

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData_POR1 As DataTable

    Private dtLoadData_POR1MAX As DataTable

    Private dtLoadData_OPOR As DataTable
    Private dtLoadData_PDN1 As DataTable
    Private dtLoadData_OPDN As DataTable
    Private dtLoadData_RPD1 As DataTable
    Private dtLoadData_ORPD As DataTable
    Private dtLoadData_PCH1 As DataTable
    Private dtLoadData_OPCH As DataTable
    Private dtLoadData_RPC1 As DataTable
    Private dtLoadData_ORPC As DataTable
    Private dtLoadData_OLDDATA As DataTable
    Private dtLoadData_OLDDATA1 As DataTable
    Private dtLoadData_GetData As DataTable
    Private dtLoadData_GetDataBAP As DataTable

    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Private Sub frmAcctngSync_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'moveCtrl = New MoveControl(Me)

        POR1()
        OPOR()
        PDN1()
        OPDN()
        RPD1()
        ORPD()
        PCH1()
        OPCH()
        RPC1()
        ORPC()
        OLD_DATA()

        'bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub POR1()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPOR1.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOR1.Columns.Add(fldLineNum)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOR1.Columns.Add(fldItemCode)

        Dim fldQuantity As New GridViewDecimalColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOR1.Columns.Add(fldQuantity)
        rgvPOR1.Columns("Quantity").FormatString = "{0:N6}"

        Dim fldOpenQty As New GridViewDecimalColumn("OpenQty")
        With fldOpenQty
            .FieldName = "OpenQty"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPOR1.Columns.Add(fldOpenQty)
        rgvPOR1.Columns("OpenQty").FormatString = "{0:N6}"

        Dim fldBudRef As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPOR1.Columns.Add(fldBudRef)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPOR1.Columns.Add(fldLineStatus)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPOR1.Columns.Add(fldU_Detail_ID)

        With rgvPOR1
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub OLD_DATA()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOLDDATA.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOLDDATA.Columns.Add(fldLineNum)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOLDDATA.Columns.Add(fldItemCode)

        Dim fldQuantity As New GridViewDecimalColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOLDDATA.Columns.Add(fldQuantity)
        rgvOLDDATA.Columns("Quantity").FormatString = "{0:N6}"

        Dim fldOpenQty As New GridViewDecimalColumn("OpenQty")
        With fldOpenQty
            .FieldName = "OpenQty"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOLDDATA.Columns.Add(fldOpenQty)
        rgvOLDDATA.Columns("OpenQty").FormatString = "{0:N6}"

        Dim fldBudRef As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvOLDDATA.Columns.Add(fldBudRef)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvOLDDATA.Columns.Add(fldLineStatus)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOLDDATA.Columns.Add(fldU_Detail_ID)

        With rgvOLDDATA
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub OPOR()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPOR.Columns.Add(fldDocentry)

        Dim fldDocNum As New GridViewTextBoxColumn("DocNum")
        With fldDocNum
            .FieldName = "DocNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPOR.Columns.Add(fldDocNum)

        Dim fldDocDate As New GridViewDateTimeColumn("DocDate")
        With fldDocDate
            .FieldName = "DocDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPOR.Columns.Add(fldDocDate)

        Dim fldCardCode As New GridViewTextBoxColumn("CardCode")
        With fldCardCode
            .FieldName = "CardCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPOR.Columns.Add(fldCardCode)

        Dim fldCANCELED As New GridViewTextBoxColumn("CANCELED")
        With fldCANCELED
            .FieldName = "CANCELED"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPOR.Columns.Add(fldCANCELED)

        Dim fldU_HeaderID As New GridViewTextBoxColumn("U_HeaderID")
        With fldU_HeaderID
            .FieldName = "U_HeaderID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvOPOR.Columns.Add(fldU_HeaderID)

        Dim fldDocRate As New GridViewDecimalColumn("DocRate")
        With fldDocRate
            .FieldName = "DocRate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPOR.Columns.Add(fldDocRate)

        With rgvOPOR
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub PDN1()
        'Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        'With fldDocentry
        '    .FieldName = "ItemCode"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 100
        '    .IsVisible = True
        'End With
        'rgvPDN1.Columns.Add(fldItemCode)

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPDN1.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldLineNum)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldItemCode)

        Dim fldBaseEntry As New GridViewTextBoxColumn("BaseEntry")
        With fldBaseEntry
            .FieldName = "BaseEntry"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldBaseEntry)

        Dim fldBaseLine As New GridViewTextBoxColumn("BaseLine")
        With fldBaseLine
            .FieldName = "BaseLine"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldBaseLine)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldLineStatus)

        Dim fldQuantity As New GridViewTextBoxColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldQuantity)

        Dim fldU_BudgetRef As New GridViewTextBoxColumn("U_BudgetRef")
        With fldU_BudgetRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPDN1.Columns.Add(fldU_BudgetRef)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrency
            .FieldName = "Currency"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPDN1.Columns.Add(fldCurrency)

        Dim fldPriceColumn As New GridViewDecimalColumn("PRICE")
        With fldPriceColumn
            .FieldName = "Price"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldPriceColumn)

        Dim fldDocDate As New GridViewDateTimeColumn("DocDate")
        With fldDocDate
            .FieldName = "DocDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPDN1.Columns.Add(fldDocDate)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPDN1.Columns.Add(fldU_Detail_ID)

        With rgvPDN1
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub OPDN()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPDN.Columns.Add(fldDocentry)

        Dim fldDocNum As New GridViewTextBoxColumn("DocNum")
        With fldDocNum
            .FieldName = "DocNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPDN.Columns.Add(fldDocNum)

        Dim fldDocDueDate As New GridViewDateTimeColumn("DocDueDate")
        With fldDocDueDate
            .FieldName = "DocDueDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPDN.Columns.Add(fldDocDueDate)

        Dim fldCANCELED As New GridViewTextBoxColumn("CANCELED")
        With fldCANCELED
            .FieldName = "CANCELED"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPDN.Columns.Add(fldCANCELED)

        Dim fldU_HeaderID As New GridViewTextBoxColumn("U_HeaderID")
        With fldU_HeaderID
            .FieldName = "U_HeaderID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvOPDN.Columns.Add(fldU_HeaderID)

        Dim fldDocRate As New GridViewDecimalColumn("DocRate")
        With fldDocRate
            .FieldName = "DocRate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPDN.Columns.Add(fldDocRate)

        Dim fldDiscPrcnt As New GridViewDecimalColumn("DiscPrcnt")
        With fldDiscPrcnt
            .FieldName = "DiscPrcnt"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPDN.Columns.Add(fldDiscPrcnt)

        With rgvOPDN
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub RPD1()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvRPD1.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPD1.Columns.Add(fldLineNum)

        Dim fldBaseEntry As New GridViewTextBoxColumn("BaseEntry")
        With fldBaseEntry
            .FieldName = "BaseEntry"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPD1.Columns.Add(fldBaseEntry)

        Dim fldBaseLine As New GridViewTextBoxColumn("BaseLine")
        With fldBaseLine
            .FieldName = "BaseLine"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPD1.Columns.Add(fldBaseLine)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvRPD1.Columns.Add(fldItemCode)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvRPD1.Columns.Add(fldLineStatus)

        Dim fldQuantity As New GridViewDecimalColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPD1.Columns.Add(fldQuantity)
        rgvRPD1.Columns("Quantity").FormatString = "{0:N6}"

        Dim fldBudRef As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvRPD1.Columns.Add(fldBudRef)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvRPD1.Columns.Add(fldU_Detail_ID)

        With rgvRPD1
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub ORPD()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvORPD.Columns.Add(fldDocentry)

        Dim fldDocNum As New GridViewTextBoxColumn("DocNum")
        With fldDocNum
            .FieldName = "DocNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPD.Columns.Add(fldDocNum)

        Dim fldDocDueDate As New GridViewDateTimeColumn("DocDueDate")
        With fldDocDueDate
            .FieldName = "DocDueDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPD.Columns.Add(fldDocDueDate)

        Dim fldCANCELED As New GridViewTextBoxColumn("CANCELED")
        With fldCANCELED
            .FieldName = "CANCELED"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPD.Columns.Add(fldCANCELED)

        Dim fldU_HeaderID As New GridViewTextBoxColumn("U_HeaderID")
        With fldU_HeaderID
            .FieldName = "U_HeaderID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvORPD.Columns.Add(fldU_HeaderID)

        With rgvORPD
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub PCH1()
        'Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        'With fldDocentry
        '    .FieldName = "ItemCode"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 100
        '    .IsVisible = True
        'End With
        'rgvPDN1.Columns.Add(fldItemCode)

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPCH1.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPCH1.Columns.Add(fldLineNum)

        Dim fldBaseEntry As New GridViewTextBoxColumn("BaseEntry")
        With fldBaseEntry
            .FieldName = "BaseEntry"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPCH1.Columns.Add(fldBaseEntry)

        Dim fldBaseLine As New GridViewTextBoxColumn("BaseLine")
        With fldBaseLine
            .FieldName = "BaseLine"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPCH1.Columns.Add(fldBaseLine)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPCH1.Columns.Add(fldLineStatus)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPCH1.Columns.Add(fldItemCode)

        Dim fldQuantity As New GridViewTextBoxColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvPCH1.Columns.Add(fldQuantity)

        Dim fldU_BudgetRef As New GridViewTextBoxColumn("U_BudgetRef")
        With fldU_BudgetRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvPCH1.Columns.Add(fldU_BudgetRef)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvPCH1.Columns.Add(fldU_Detail_ID)

        With rgvPCH1
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub OPCH()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvOPCH.Columns.Add(fldDocentry)

        Dim fldDocNum As New GridViewTextBoxColumn("DocNum")
        With fldDocNum
            .FieldName = "DocNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPCH.Columns.Add(fldDocNum)

        Dim fldDocDueDate As New GridViewDateTimeColumn("DocDueDate")
        With fldDocDueDate
            .FieldName = "DocDueDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPCH.Columns.Add(fldDocDueDate)

        Dim fldCANCELED As New GridViewTextBoxColumn("CANCELED")
        With fldCANCELED
            .FieldName = "CANCELED"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvOPCH.Columns.Add(fldCANCELED)

        Dim fldU_HeaderID As New GridViewTextBoxColumn("U_HeaderID")
        With fldU_HeaderID
            .FieldName = "U_HeaderID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvOPCH.Columns.Add(fldU_HeaderID)

        With rgvOPCH
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub RPC1()
        'Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        'With fldDocentry
        '    .FieldName = "ItemCode"
        '    .ReadOnly = True
        '    .TextAlignment = ContentAlignment.MiddleCenter
        '    .Width = 100
        '    .IsVisible = True
        'End With
        'rgvPDN1.Columns.Add(fldItemCode)

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvRPC1.Columns.Add(fldDocentry)

        Dim fldLineNum As New GridViewTextBoxColumn("LineNum")
        With fldLineNum
            .FieldName = "LineNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPC1.Columns.Add(fldLineNum)

        Dim fldBaseEntry As New GridViewTextBoxColumn("BaseEntry")
        With fldBaseEntry
            .FieldName = "BaseEntry"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPC1.Columns.Add(fldBaseEntry)

        Dim fldBaseLine As New GridViewTextBoxColumn("BaseLine")
        With fldBaseLine
            .FieldName = "BaseLine"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPC1.Columns.Add(fldBaseLine)

        Dim fldLineStatus As New GridViewTextBoxColumn("LineStatus")
        With fldLineStatus
            .FieldName = "LineStatus"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvRPC1.Columns.Add(fldLineStatus)

        Dim fldItemCode As New GridViewTextBoxColumn("ItemCode")
        With fldItemCode
            .FieldName = "ItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPC1.Columns.Add(fldItemCode)

        Dim fldQuantity As New GridViewTextBoxColumn("Quantity")
        With fldQuantity
            .FieldName = "Quantity"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvRPC1.Columns.Add(fldQuantity)

        Dim fldU_BudgetRef As New GridViewTextBoxColumn("U_BudgetRef")
        With fldU_BudgetRef
            .FieldName = "U_BudgetRef"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvRPC1.Columns.Add(fldU_BudgetRef)

        Dim fldU_Detail_ID As New GridViewTextBoxColumn("U_Detail_ID")
        With fldU_Detail_ID
            .FieldName = "U_Detail_ID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvRPC1.Columns.Add(fldU_Detail_ID)

        With rgvRPC1
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub ORPC()

        Dim fldDocentry As New GridViewTextBoxColumn("DocEntry")
        With fldDocentry
            .FieldName = "DocEntry"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .IsVisible = True
        End With
        rgvORPC.Columns.Add(fldDocentry)

        Dim fldDocNum As New GridViewTextBoxColumn("DocNum")
        With fldDocNum
            .FieldName = "DocNum"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPC.Columns.Add(fldDocNum)

        Dim fldDocDueDate As New GridViewDateTimeColumn("DocDueDate")
        With fldDocDueDate
            .FieldName = "DocDueDate"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPC.Columns.Add(fldDocDueDate)

        Dim fldCANCELED As New GridViewTextBoxColumn("CANCELED")
        With fldCANCELED
            .FieldName = "CANCELED"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvORPC.Columns.Add(fldCANCELED)

        Dim fldU_HeaderID As New GridViewTextBoxColumn("U_HeaderID")
        With fldU_HeaderID
            .FieldName = "U_HeaderID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            '.PinPosition = PinnedColumnPosition.Left
        End With
        rgvORPC.Columns.Add(fldU_HeaderID)

        With rgvORPC
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        conn2.Open()

        Dim mycmdLimitUpdate2 As New MySqlCommand
        mycmdLimitUpdate2.Connection = conn2
        mycmdLimitUpdate2.CommandText = "UPDATE tblSettings SET fldLimit = 1, fldName = '' WHERE fldProID = 1"
        mycmdLimitUpdate2.ExecuteNonQuery()

        Me.Close()

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        Try
            bwLoadData.RunWorkerAsync()
            'SDF_Sap_Timer()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Multiple Refresh", "Fatal Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

    End Sub

    Private Function connection_ok() As Boolean
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        connection_ok = False
        Try
            conn.Open()
            connection_ok = True
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return connection_ok

    End Function

    '----------------
    '----- POR1 -----
    '----------------

    Private Sub btnSyncDataPOR1_Click(sender As Object, e As EventArgs) Handles btnSyncDataPOR1.Click

        Dim myCmd_POR1 As New MySqlCommand
        conn.Open()

        myCmd_POR1.Connection = conn
        Try
            For xPOR1 As Integer = 0 To rgvPOR1.ChildRows.Count - 1
                Dim DocEntry As Integer = rgvPOR1.ChildRows(xPOR1).Cells("DocEntry").Value
                Dim LineNum As Integer = rgvPOR1.ChildRows(xPOR1).Cells("LineNum").Value
                Dim ItemCode As String = rgvPOR1.ChildRows(xPOR1).Cells("ItemCode").Value.ToString
                Dim QTY As Decimal = Convert.ToDecimal(rgvPOR1.ChildRows(xPOR1).Cells("Quantity").Value)
                Dim OpenQty As Decimal = Convert.ToDecimal(rgvPOR1.ChildRows(xPOR1).Cells("OpenQty").Value)
                Dim U_BudgetRef As String = rgvPOR1.ChildRows(xPOR1).Cells("U_BudgetRef").Value.ToString
                Dim LineStatus As String = rgvPOR1.ChildRows(xPOR1).Cells("LineStatus").Value.ToString
                Dim U_Detail_ID As String = rgvPOR1.ChildRows(xPOR1).Cells("U_Detail_ID").Value.ToString

                myCmd_POR1.CommandText = "INSERT INTO POR1(DocEntry,LineNum,ItemCode,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID) " _
                    & "values('" & DocEntry & "','" & LineNum & "','" & ItemCode & "','" & QTY & "','" & OpenQty & "'," _
                    & "'" & U_BudgetRef & "','" & LineStatus & "','" & U_Detail_ID & "')"
                myCmd_POR1.ExecuteNonQuery()
                myCmd_POR1.Parameters.Clear()

            Next

            conn.Close()

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

        Catch ex As Exception
            conn.Close()
        End Try

    End Sub

    Private Sub btnGetDataPOR1_Click(sender As Object, e As EventArgs) Handles btnGetDataPOR1.Click

        Dim myCmd_POR1 As New MySqlCommand
        Dim myAdapter_POR1 As New MySqlDataAdapter
        Dim myData_POR1 As New DataTable
        Dim ID_POR1 As String

        conn.Open()
        myCmd_POR1.Connection = conn

        Dim myCmd_POR1MAX As New MySqlCommand
        Dim myAdapter_POR1MAX As New MySqlDataAdapter
        Dim myData_POR1MAX As New DataTable
        Dim IPOR1MAX As String
        myCmd_POR1MAX.Connection = conn

        myCmd_POR1MAX.CommandText = "select max(DocEntry-1) as POR1MAX from POR1"
        myAdapter_POR1MAX.SelectCommand = myCmd_POR1MAX
        myAdapter_POR1MAX.Fill(myData_POR1MAX)
        IPOR1MAX = myData_POR1MAX.Rows(0).Item("POR1MAX").ToString

        myCmd_POR1.CommandText = "select group_concat(DocEntry ,LineNum) as id from POR1 where DocEntry >= '" & IPOR1MAX & "' "
        myAdapter_POR1.SelectCommand = myCmd_POR1
        myAdapter_POR1.Fill(myData_POR1)
        ID_POR1 = myData_POR1.Rows(0).Item("id").ToString

        'dtLoadData_POR1 = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
        '                                            & " from POR1 WHERE U_BudgetRef IS NOT NULL and " _
        '                                            & " convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) not in  (" & ID_POR1 & ") AND DocEntry > '" & IPOR1MAX & "'")

        'dtLoadData_POR1 = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
        '                                            & " from POR1 WHERE U_BudgetRef IS NOT NULL and RIGHT(U_BudgetRef,4) = '2018'")
        dtLoadData_POR1 = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
                                                    & " from POR1 WHERE U_BudgetRef IS NOT NULL")

        rgvPOR1.DataSource = dtLoadData_POR1
        conn.Close()
       
    End Sub

    '----------------
    '----- OPOR -----
    '----------------

    Private Sub btnSyncDataOPOR_Click(sender As Object, e As EventArgs) Handles btnSyncDataOPOR.Click
        Dim mycmd_OPOR As New MySqlCommand

        conn.Open()
        mycmd_OPOR.Connection = conn

        For xOPOR As Integer = 0 To rgvOPOR.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvOPOR.ChildRows(xOPOR).Cells("DocEntry").Value
            Dim DocNum As Integer = rgvOPOR.ChildRows(xOPOR).Cells("DocNum").Value
            Dim DocDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvOPOR.ChildRows(xOPOR).Cells("DocDate").Value))
            Dim CardCode As String = rgvOPOR.ChildRows(xOPOR).Cells("CardCode").Value.ToString
            Dim CANCELED As String = rgvOPOR.ChildRows(xOPOR).Cells("CANCELED").Value.ToString
            Dim U_HeaderID As String = rgvOPOR.ChildRows(xOPOR).Cells("U_HeaderID").Value.ToString
            Dim DocRate As Decimal = Convert.ToDecimal(rgvOPOR.ChildRows(xOPOR).Cells("DocRate").Value)

            mycmd_OPOR.CommandText = "INSERT INTO OPOR(DocEntry,DocNum,DocDate,CardCode,CANCELED,U_HeaderID,DocRate)" _
                & "values('" & DocEntry & "','" & DocNum & "','" & DocDate & "','" & CardCode & "','" & CANCELED & "','" & U_HeaderID & "','" & DocRate & "') "
            mycmd_OPOR.ExecuteNonQuery()
            mycmd_OPOR.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

        'Dim myCmd_OLDDATA As New MySqlCommand
        'myCmd_OLDDATA.Connection = conn

        'Try
        '    For xOLDDATA As Integer = 0 To rgvOLDDATA.ChildRows.Count - 1

        '        Dim CHECK1 As DataTable = Chinita.fetchDBTable("select Count(DocEntry) as checkme FROM POR1 " _
        '                                                       & "where DocEntry = '" & rgvOLDDATA.ChildRows(xOLDDATA).Cells("DocEntry").Value & "' " _
        '                                                       & "and LineNum = '" & rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineNum").Value & "'")
        '        Dim checkitem1 As Integer = CHECK1.Rows(0).Item("checkme")

        '        If checkitem1 < 1 Then
        '            Dim DocEntry As Integer = rgvOLDDATA.ChildRows(xOLDDATA).Cells("DocEntry").Value
        '            Dim LineNum As Integer = rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineNum").Value
        '            Dim ItemCode As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("ItemCode").Value.ToString
        '            Dim QTY As Decimal = Convert.ToDecimal(rgvOLDDATA.ChildRows(xOLDDATA).Cells("Quantity").Value)
        '            Dim OpenQty As Decimal = Convert.ToDecimal(rgvOLDDATA.ChildRows(xOLDDATA).Cells("OpenQty").Value)
        '            Dim U_BudgetRef As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("U_BudgetRef").Value.ToString
        '            Dim LineStatus As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineStatus").Value.ToString
        '            Dim U_Detail_ID As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("U_Detail_ID").Value.ToString

        '            myCmd_OLDDATA.CommandText = "INSERT INTO POR1(DocEntry,LineNum,ItemCode,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID) " _
        '                & "values('" & DocEntry & "','" & LineNum & "','" & ItemCode & "','" & QTY & "','" & OpenQty & "'," _
        '                & "'" & U_BudgetRef & "','" & LineStatus & "','" & U_Detail_ID & "')"
        '            myCmd_OLDDATA.ExecuteNonQuery()
        '            myCmd_OLDDATA.Parameters.Clear()
        '        End If

        '    Next
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub btnGetDataOPOR_Click(sender As Object, e As EventArgs) Handles btnGetDataOPOR.Click
        Dim myCmd_OPOR As New MySqlCommand
        Dim myAdapter_OPOR As New MySqlDataAdapter
        Dim myData_OPOR As New DataTable
        Dim ID_OPOR As Integer

        conn.Open()
        myCmd_OPOR.Connection = conn

        'myCmd_OPOR.CommandText = "select MAX(DocEntry) AS ID from OPOR"
        'myAdapter_OPOR.SelectCommand = myCmd_OPOR
        'myAdapter_OPOR.Fill(myData_OPOR)
        'ID_OPOR = myData_OPOR.Rows(0).Item("ID")

        'dtLoadData_OPOR = Chinita.fetchDbTableSAPvsBAP("select DocRate,DocEntry,DocNum,DocDate,CardCode,CANCELED,U_HeaderID " _
        '                                               & "from OPOR where U_HeaderID is not null")

        'dtLoadData_OPOR = Chinita.fetchDbTableSAPvsBAP("select DocRate,DocEntry,DocNum,DocDate,CardCode,CANCELED,U_HeaderID " _
        '                                               & " from OPOR where LEFT(U_HeaderID,4) = 'POID' AND REPLACE(U_HeaderID,'POID','') >= '19230'")
        dtLoadData_OPOR = Chinita.fetchDbTableSAPvsBAP("select DocRate,DocEntry,DocNum,DocDate,CardCode,CANCELED,U_HeaderID " _
                                                      & " from OPOR where LEFT(U_HeaderID,4) = 'POID'")

        rgvOPOR.DataSource = dtLoadData_OPOR
        conn.Close()
    End Sub

    '----------------
    '----- PDN1 -----
    '----------------

    Private Sub btnSyncDataPDN1_Click(sender As Object, e As EventArgs) Handles btnSyncDataPDN1.Click


        '-----------------------------------------old data---------------------------------------------
        '----------------------------1-9-2017-----temporary comment for 2017 data
        '--------------------------if error remove comment
        'Dim myCmd_OLDDATA As New MySqlCommand
        'myCmd_OLDDATA.Connection = conn

        'Try
        '    For xOLDDATA As Integer = 0 To rgvOLDDATA.ChildRows.Count - 1

        '        Dim CHECK1 As DataTable = Chinita.fetchDBTable("select Count(DocEntry) as checkme FROM POR1 " _
        '                                                       & "where DocEntry = '" & rgvOLDDATA.ChildRows(xOLDDATA).Cells("DocEntry").Value & "' " _
        '                                                       & "and LineNum = '" & rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineNum").Value & "'")
        '        Dim checkitem1 As Integer = CHECK1.Rows(0).Item("checkme")

        '        If checkitem1 < 1 Then
        '            Dim DocEntry As Integer = rgvOLDDATA.ChildRows(xOLDDATA).Cells("DocEntry").Value
        '            Dim LineNum As Integer = rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineNum").Value
        '            Dim ItemCode As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("ItemCode").Value.ToString
        '            Dim QTY As Decimal = Convert.ToDecimal(rgvOLDDATA.ChildRows(xOLDDATA).Cells("Quantity").Value)
        '            Dim OpenQty As Decimal = Convert.ToDecimal(rgvOLDDATA.ChildRows(xOLDDATA).Cells("OpenQty").Value)
        '            Dim U_BudgetRef As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("U_BudgetRef").Value.ToString
        '            Dim LineStatus As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("LineStatus").Value.ToString
        '            Dim U_Detail_ID As String = rgvOLDDATA.ChildRows(xOLDDATA).Cells("U_Detail_ID").Value.ToString

        '            myCmd_OLDDATA.CommandText = "INSERT INTO POR1(DocEntry,LineNum,ItemCode,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID) " _
        '                & "values('" & DocEntry & "','" & LineNum & "','" & ItemCode & "','" & QTY & "','" & OpenQty & "'," _
        '                & "'" & U_BudgetRef & "','" & LineStatus & "','" & U_Detail_ID & "')"
        '            myCmd_OLDDATA.ExecuteNonQuery()
        '            myCmd_OLDDATA.Parameters.Clear()
        '        End If

        '    Next
        'Catch ex As Exception

        'End Try

        '----------------------------------------------------------------------------------------------
        Dim mycmd_PDN1 As New MySqlCommand

        conn.Open()
        mycmd_PDN1.Connection = conn

        For xPDN1 As Integer = 0 To rgvPDN1.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvPDN1.ChildRows(xPDN1).Cells("DocEntry").Value
            Dim ItemCode As String = rgvPDN1.ChildRows(xPDN1).Cells("ItemCode").Value.ToString
            Dim LineNum As Integer = rgvPDN1.ChildRows(xPDN1).Cells("LineNum").Value
            Dim BaseEntry As Integer = rgvPDN1.ChildRows(xPDN1).Cells("BaseEntry").Value
            Dim BaseLine As Integer = rgvPDN1.ChildRows(xPDN1).Cells("BaseLine").Value
            Dim LineStatus As String = rgvPDN1.ChildRows(xPDN1).Cells("LineStatus").Value.ToString
            Dim Quantity As Decimal = Convert.ToDecimal(rgvPDN1.ChildRows(xPDN1).Cells("Quantity").Value)
            Dim U_BudgetRef As String = rgvPDN1.ChildRows(xPDN1).Cells("U_BudgetRef").Value.ToString
            Dim Currency As String = rgvPDN1.ChildRows(xPDN1).Cells("Currency").Value.ToString
            Dim Price As Decimal = Convert.ToDecimal(rgvPDN1.ChildRows(xPDN1).Cells("Price").Value)
            Dim DocDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvPDN1.ChildRows(xPDN1).Cells("DocDate").Value))
            Dim U_Detail_ID As String = rgvPDN1.ChildRows(xPDN1).Cells("U_Detail_ID").Value.ToString

            mycmd_PDN1.CommandText = "INSERT INTO PDN1(DocEntry,ItemCode,LineNum,BaseEntry,BaseLine,LineStatus,Quantity,U_BudgetRef,Currency,Price,DocDate,U_Detail_ID)" _
                & "values('" & DocEntry & "','" & ItemCode & "','" & LineNum & "','" & BaseEntry & "','" & BaseLine & "','" & LineStatus & "','" & Quantity & "','" & U_BudgetRef & "','" & Currency & "','" & Price & "','" & DocDate & "','" & U_Detail_ID & "')"
            mycmd_PDN1.ExecuteNonQuery()
            mycmd_PDN1.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataPDN1_Click(sender As Object, e As EventArgs) Handles btnGetDataPDN1.Click
        Dim myCmd_PDN1 As New MySqlCommand
        Dim myAdapter_PDN1 As New MySqlDataAdapter
        Dim myData_PDN1 As New DataTable
        Dim ID_PDN1 As String

        conn.Open()

        myCmd_PDN1.Connection = conn

        Dim myCmd_PDN1MAX As New MySqlCommand
        Dim myAdapter_PDN1MAX As New MySqlDataAdapter
        Dim myData_PDN1MAX As New DataTable
        Dim PDN1MAX As String
        myCmd_PDN1MAX.Connection = conn

        myCmd_PDN1MAX.CommandText = "select max(DocEntry-1) as POR1MAX from PDN1 "
        myAdapter_PDN1MAX.SelectCommand = myCmd_PDN1MAX
        myAdapter_PDN1MAX.Fill(myData_PDN1MAX)
        PDN1MAX = myData_PDN1MAX.Rows(0).Item("POR1MAX").ToString

        myCmd_PDN1.CommandText = "select group_concat(DocEntry ,LineNum) AS ID from PDN1 where DocEntry >= '" & PDN1MAX & "'"
        myAdapter_PDN1.SelectCommand = myCmd_PDN1
        myAdapter_PDN1.Fill(myData_PDN1)
        ID_PDN1 = myData_PDN1.Rows(0).Item("ID").ToString


        'dtLoadData_PDN1 = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID, " _
        '                                               & "BaseEntry,BaseLine,ItemCode,DocEntry,LineNum,LineStatus,LineNum,Quantity, U_BudgetRef, Currency, Price, DocDate, U_Detail_ID " _
        '                                               & "from PDN1 where U_BudgetRef is not null and BaseLine is not null ")
        'rgvPDN1.DataSource = dtLoadData_PDN1

        'dtLoadData_OLDDATA1 = Chinita.fetchDbTableSAPvsBAP("select " _
        '                                                  & "isnull(STUFF((select ',' + convert(varchar(5),BaseEntry,10) " _
        '                                                  & "from PDN1 " _
        '                                                  & "where U_BudgetRef Is Not null And BaseLine Is Not null And " _
        '                                                  & "Convert(varchar(5), DocEntry, 10) + Convert(varchar(5), LineNum, 10) " _
        '                                                  & "not in (" & ID_PDN1 & ") " _
        '                                                  & "AND DocEntry > '" & PDN1MAX & "' " _
        '                                                  & "FOR XML PATH('') " _
        '                                                  & "), 1, 1, '' ),0) as ID")
        'OLD_DATA2 = dtLoadData_OLDDATA1.Rows(0).Item("ID")

        'dtLoadData_OLDDATA = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
        '                                            & " from POR1 WHERE U_BudgetRef IS NOT NULL and " _
        '                                            & " convert(varchar(5),DocEntry,10) in  (" & OLD_DATA2 & ")")


        dtLoadData_PDN1 = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID, " _
                                                       & "BaseEntry,BaseLine,ItemCode,DocEntry,LineNum,LineStatus,LineNum,Quantity, U_BudgetRef, Currency, Price, DocDate, U_Detail_ID " _
                                                       & "from PDN1 where U_BudgetRef is not null and BaseLine is not null and Currency != '' ")
        rgvPDN1.DataSource = dtLoadData_PDN1

        'dtLoadData_OLDDATA1 = Chinita.fetchDbTableSAPvsBAP("select " _
        '                                                  & "isnull(STUFF((select ',' + convert(varchar(5),BaseEntry,10) " _
        '                                                  & "from PDN1 " _
        '                                                  & "where U_BudgetRef Is Not null and RIGHT(U_BudgetRef,4) = '2018' and Currency != '' And BaseLine Is Not null And " _
        '                                                  & "Convert(varchar(5), DocEntry, 10) + Convert(varchar(5), LineNum, 10) " _
        '                                                  & "not in (" & ID_PDN1 & ") " _
        '                                                  & "AND DocEntry > '" & PDN1MAX & "' " _
        '                                                  & "FOR XML PATH('') " _
        '                                                  & "), 1, 1, '' ),0) as ID")
        'OLD_DATA2 = dtLoadData_OLDDATA1.Rows(0).Item("ID")

        'dtLoadData_OLDDATA = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
        '                                            & " from POR1 WHERE U_BudgetRef IS NOT NULL and RIGHT(U_BudgetRef,4) = '2018' and " _
        '                                            & " convert(varchar(5),DocEntry,10) in  (" & OLD_DATA2 & ")")

        dtLoadData_OLDDATA = Chinita.fetchDbTableSAPvsBAP("select convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) as ID,DocEntry,LineNum,ItemCode,LineStatus,Quantity,OpenQty,U_BudgetRef,LineStatus,U_Detail_ID " _
                                                    & " from POR1 WHERE U_BudgetRef IS NOT NULL " _
                                                    & " ")


        rgvOLDDATA.DataSource = dtLoadData_OLDDATA
        conn.Close()
    End Sub

    '----------------
    '----- OPDN -----
    '----------------

    Private Sub btnSyncDataOPDN_Click(sender As Object, e As EventArgs) Handles btnSyncDataOPDN.Click
        Dim mycmd_OPDN As New MySqlCommand

        conn.Open()
        mycmd_OPDN.Connection = conn

        For xOPDN As Integer = 0 To rgvOPDN.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvOPDN.ChildRows(xOPDN).Cells("DocEntry").Value
            Dim DocNum As Integer = rgvOPDN.ChildRows(xOPDN).Cells("DocNum").Value
            Dim DocDueDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvOPDN.ChildRows(xOPDN).Cells("DocDueDate").Value))
            Dim CANCELED As String = rgvOPDN.ChildRows(xOPDN).Cells("CANCELED").Value.ToString
            Dim U_HeaderID As String = rgvOPDN.ChildRows(xOPDN).Cells("U_HeaderID").Value.ToString
            Dim DocRate As Decimal = Convert.ToDecimal(rgvOPDN.ChildRows(xOPDN).Cells("DocRate").Value)
            Dim DiscPrcnt As Decimal = Convert.ToDecimal(rgvOPDN.ChildRows(xOPDN).Cells("DiscPrcnt").Value)

            mycmd_OPDN.CommandText = "INSERT INTO OPDN(DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID,DocRate,DiscPrcnt)" _
                & "values('" & DocEntry & "','" & DocNum & "','" & DocDueDate & "','" & CANCELED & "','" & U_HeaderID & "','" & DocRate & "','" & DiscPrcnt & "') "
            mycmd_OPDN.ExecuteNonQuery()
            mycmd_OPDN.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataOPDN_Click(sender As Object, e As EventArgs) Handles btnGetDataOPDN.Click
        Dim myCmd_OPDN As New MySqlCommand
        Dim myAdapter_OPDN As New MySqlDataAdapter
        Dim myData_OPDN As New DataTable
        Dim ID_OPDN As Integer

        conn.Open()
        myCmd_OPDN.Connection = conn

        myCmd_OPDN.CommandText = "select MAX(DocEntry) AS ID from OPDN"
        myAdapter_OPDN.SelectCommand = myCmd_OPDN
        myAdapter_OPDN.Fill(myData_OPDN)
        ID_OPDN = myData_OPDN.Rows(0).Item("ID")

        'dtLoadData_OPDN = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID,DocRate,DiscPrcnt " _
        '                                               & "from OPDN where U_HeaderID is not null")
        'dtLoadData_OPDN = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID,DocRate,DiscPrcnt " _
        '                                               & "from OPDN where LEFT(U_HeaderID,4) = 'POID' AND REPLACE(U_HeaderID,'POID','') >= '18353' and DiscPrcnt IS NOT NULL")
        dtLoadData_OPDN = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID,DocRate,DiscPrcnt " _
                                                      & "from OPDN where LEFT(U_HeaderID,4) = 'POID' and DiscPrcnt IS NOT NULL")
        rgvOPDN.DataSource = dtLoadData_OPDN

        conn.Close()
    End Sub

    '----------------
    '----- RPD1 -----
    '----------------

    Private Sub btnSyncDataRPD1_Click(sender As Object, e As EventArgs) Handles btnSyncDataRPD1.Click
        Dim mycmd_RPD1 As New MySqlCommand

        conn.Open()
        mycmd_RPD1.Connection = conn

        For xRPD1 As Integer = 0 To rgvRPD1.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvRPD1.ChildRows(xRPD1).Cells("DocEntry").Value
            Dim LineNum As String = rgvRPD1.ChildRows(xRPD1).Cells("LineNum").Value
            Dim BaseEntry As String = rgvRPD1.ChildRows(xRPD1).Cells("BaseEntry").Value
            Dim BaseLine As String = rgvRPD1.ChildRows(xRPD1).Cells("BaseLine").Value
            Dim ItemCode As String = rgvRPD1.ChildRows(xRPD1).Cells("ItemCode").Value.ToString
            Dim LineStatus As String = rgvRPD1.ChildRows(xRPD1).Cells("LineStatus").Value.ToString
            Dim Quantity As Decimal = Convert.ToDecimal(rgvRPD1.ChildRows(xRPD1).Cells("Quantity").Value)
            Dim U_BudgetRef As String = rgvRPD1.ChildRows(xRPD1).Cells("U_BudgetRef").Value.ToString
            Dim U_Detail_ID As String = rgvRPD1.ChildRows(xRPD1).Cells("U_Detail_ID").Value.ToString

            mycmd_RPD1.CommandText = "INSERT INTO RPD1(DocEntry,ItemCode,LineNum,BaseEntry,BaseLine,LineStatus,Quantity,U_BudgetRef,U_Detail_ID)" _
                & "values('" & DocEntry & "','" & ItemCode & "','" & LineNum & "','" & BaseEntry & "','" & BaseLine & "','" & LineStatus & "','" & Quantity & "','" & U_BudgetRef & "','" & U_Detail_ID & "') "
            mycmd_RPD1.ExecuteNonQuery()
            mycmd_RPD1.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataRPD1_Click(sender As Object, e As EventArgs) Handles btnGetDataRPD1.Click
        Dim myCmd_RPD1 As New MySqlCommand
        Dim myAdapter_RPD1 As New MySqlDataAdapter
        Dim myData_RPD1 As New DataTable
        Dim ID_RPD1 As String

        conn.Open()
        myCmd_RPD1.Connection = conn

        Dim myCmd_RPD1MAX As New MySqlCommand
        Dim myAdapter_RPD1MAX As New MySqlDataAdapter
        Dim myData_RPD1MAX As New DataTable
        Dim RPD1MAX As String
        myCmd_RPD1MAX.Connection = conn

        ''myCmd_RPD1MAX.CommandText = "select max(DocEntry-1) as POR1MAX from RPD1"
        ''myAdapter_RPD1MAX.SelectCommand = myCmd_RPD1MAX
        ''myAdapter_RPD1MAX.Fill(myData_RPD1MAX)
        ''RPD1MAX = myData_RPD1MAX.Rows(0).Item("POR1MAX").ToString

        ''myCmd_RPD1.CommandText = "select group_concat(DocEntry ,LineNum) AS ID from RPD1 where DocEntry >= '" & RPD1MAX & "'"
        ''myAdapter_RPD1.SelectCommand = myCmd_RPD1
        ''myAdapter_RPD1.Fill(myData_RPD1)
        ''ID_RPD1 = myData_RPD1.Rows(0).Item("ID").ToString

        '---------2017 comment
        'dtLoadData_RPD1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,LineStatus,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from RPD1 where U_BudgetRef is not null AND " _
        '                                               & " convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) NOT IN (" & ID_RPD1 & ") AND DocEntry > '" & RPD1MAX & "' ")

        'dtLoadData_RPD1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,LineStatus,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from RPD1 where U_BudgetRef is not null AND RIGHT(U_BudgetRef,4) = '2018' AND" _
        '                                               & " convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) NOT IN (" & ID_RPD1 & ") AND DocEntry > '" & RPD1MAX & "' ")

        dtLoadData_RPD1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
                                                       & " DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,LineStatus,Quantity,U_BudgetRef, U_Detail_ID " _
                                                       & " from RPD1 where U_BudgetRef is not null" _
                                                       & "")
        rgvRPD1.DataSource = dtLoadData_RPD1

        conn.Close()
    End Sub

    '----------------
    '----- ORPD -----
    '----------------

    Private Sub btnSyncDataORPD_Click(sender As Object, e As EventArgs) Handles btnSyncDataORPD.Click
        Dim mycmd_ORPD As New MySqlCommand

        conn.Open()
        mycmd_ORPD.Connection = conn

        For xORPD As Integer = 0 To rgvORPD.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvORPD.ChildRows(xORPD).Cells("DocEntry").Value
            Dim DocNum As Integer = rgvORPD.ChildRows(xORPD).Cells("DocNum").Value
            Dim DocDueDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvORPD.ChildRows(xORPD).Cells("DocDueDate").Value))
            Dim CANCELED As String = rgvORPD.ChildRows(xORPD).Cells("CANCELED").Value.ToString
            Dim U_HeaderID As String = rgvORPD.ChildRows(xORPD).Cells("U_HeaderID").Value.ToString

            mycmd_ORPD.CommandText = "INSERT INTO ORPD(DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID)" _
                & "values('" & DocEntry & "','" & DocNum & "','" & DocDueDate & "','" & CANCELED & "','" & U_HeaderID & "') "
            mycmd_ORPD.ExecuteNonQuery()
            mycmd_ORPD.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataORPD_Click(sender As Object, e As EventArgs) Handles btnGetDataORPD.Click
        Dim myCmd_ORPD As New MySqlCommand
        Dim myAdapter_ORPD As New MySqlDataAdapter
        Dim myData_ORPD As New DataTable
        Dim ID_ORPD As Integer

        conn.Open()
        myCmd_ORPD.Connection = conn

        'myCmd_ORPD.CommandText = "select MAX(DocEntry) AS ID from ORPD"
        'myAdapter_ORPD.SelectCommand = myCmd_ORPD
        'myAdapter_ORPD.Fill(myData_ORPD)
        'ID_ORPD = myData_ORPD.Rows(0).Item("ID")

        '2017 COMMENT
        'dtLoadData_ORPD = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                               & "from ORPD where U_HeaderID is not null and DocEntry > " & ID_ORPD & " ")
        'dtLoadData_ORPD = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                               & "from ORPD where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '19161'  and DocEntry > " & ID_ORPD & " ")

        dtLoadData_ORPD = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
                                                       & "from ORPD where U_HeaderID is not null")
        rgvORPD.DataSource = dtLoadData_ORPD
        conn.Close()
    End Sub

    '----------------
    '----- PCH1 -----
    '----------------

    Private Sub btnSyncDataPCH1_Click(sender As Object, e As EventArgs) Handles btnSyncDataPCH1.Click
        Dim mycmd_PCH1 As New MySqlCommand
        Dim BaseEntry As String = Nothing
        Dim BaseLine As String = Nothing
        conn.Open()
        mycmd_PCH1.Connection = conn

        For xPCH1 As Integer = 0 To rgvPCH1.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvPCH1.ChildRows(xPCH1).Cells("DocEntry").Value
            Dim LineNum As String = rgvPCH1.ChildRows(xPCH1).Cells("LineNum").Value
            If IsDBNull(rgvPCH1.ChildRows(xPCH1).Cells("BaseEntry").Value) = False Then
                BaseEntry = rgvPCH1.ChildRows(xPCH1).Cells("BaseEntry").Value
            End If
            If IsDBNull(rgvPCH1.ChildRows(xPCH1).Cells("BaseLine").Value) = False Then
                BaseLine = rgvPCH1.ChildRows(xPCH1).Cells("BaseLine").Value
            End If
            Dim ItemCode As String = rgvPCH1.ChildRows(xPCH1).Cells("ItemCode").Value.ToString
            Dim LineStatus As String = rgvPCH1.ChildRows(xPCH1).Cells("LineStatus").Value.ToString
            Dim Quantity As Decimal = Convert.ToDecimal(rgvPCH1.ChildRows(xPCH1).Cells("Quantity").Value)
            Dim U_BudgetRef As String = rgvPCH1.ChildRows(xPCH1).Cells("U_BudgetRef").Value.ToString
            Dim U_Detail_ID As String = rgvPCH1.ChildRows(xPCH1).Cells("U_Detail_ID").Value.ToString


            mycmd_PCH1.CommandText = "INSERT INTO PCH1(DocEntry,ItemCode,LineNum,BaseEntry,BaseLine,LineStatus,Quantity,U_BudgetRef,U_Detail_ID)" _
                & "values('" & DocEntry & "','" & ItemCode & "','" & LineNum & "','" & BaseEntry & "','" & BaseLine & "','" & LineStatus & "','" & Quantity & "','" & U_BudgetRef & "','" & U_Detail_ID & "') "
            mycmd_PCH1.ExecuteNonQuery()
            mycmd_PCH1.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataPCH1_Click(sender As Object, e As EventArgs) Handles btnGetDataPCH1.Click
        Dim myCmd_PCH1 As New MySqlCommand
        Dim myAdapter_PCH1 As New MySqlDataAdapter
        Dim myData_PCH1 As New DataTable
        Dim ID_PCH1 As String

        conn.Open()
        myCmd_PCH1.Connection = conn

        Dim myCmd_PCH1MAX As New MySqlCommand
        Dim myAdapter_PCH1MAX As New MySqlDataAdapter
        Dim myData_PCH1MAX As New DataTable
        Dim PCH1MAX As String
        myCmd_PCH1MAX.Connection = conn

        ''myCmd_PCH1MAX.CommandText = "select max(DocEntry-1) as POR1MAX from PCH1"
        ''myAdapter_PCH1MAX.SelectCommand = myCmd_PCH1MAX
        ''myAdapter_PCH1MAX.Fill(myData_PCH1MAX)
        ''PCH1MAX = myData_PCH1MAX.Rows(0).Item("POR1MAX").ToString

        ''myCmd_PCH1.CommandText = "select group_concat(DocEntry ,LineNum) AS ID from PCH1 where DocEntry >= '" & PCH1MAX & "'"
        ''myAdapter_PCH1.SelectCommand = myCmd_PCH1
        ''myAdapter_PCH1.Fill(myData_PCH1)
        ''ID_PCH1 = myData_PCH1.Rows(0).Item("ID").ToString

        '2017 COMMENT
        'dtLoadData_PCH1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " lineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from PCH1 where U_BudgetRef is not null ")

        'dtLoadData_PCH1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " lineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from PCH1 where U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018' ")
        dtLoadData_PCH1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
                                                       & " lineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
                                                       & " from PCH1 where U_BudgetRef is not null")

        rgvPCH1.DataSource = dtLoadData_PCH1
        conn.Close()
    End Sub

    '----------------
    '----- OPCH -----
    '----------------

    Private Sub btnSyncDataOPCH_Click(sender As Object, e As EventArgs) Handles btnSyncDataOPCH.Click
        Dim mycmd_OPCH As New MySqlCommand

        conn.Open()
        mycmd_OPCH.Connection = conn

        For xOPCH As Integer = 0 To rgvOPCH.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvOPCH.ChildRows(xOPCH).Cells("DocEntry").Value
            Dim DocNum As Integer = rgvOPCH.ChildRows(xOPCH).Cells("DocNum").Value
            Dim DocDueDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvOPCH.ChildRows(xOPCH).Cells("DocDueDate").Value))
            Dim CANCELED As String = rgvOPCH.ChildRows(xOPCH).Cells("CANCELED").Value.ToString
            Dim U_HeaderID As String = rgvOPCH.ChildRows(xOPCH).Cells("U_HeaderID").Value.ToString

            mycmd_OPCH.CommandText = "INSERT INTO OPCH(DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID)" _
                & "values('" & DocEntry & "','" & DocNum & "','" & DocDueDate & "','" & CANCELED & "','" & U_HeaderID & "') "
            mycmd_OPCH.ExecuteNonQuery()
            mycmd_OPCH.Parameters.Clear()

        Next
        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)


    End Sub

    Private Sub btnGetDataOPCH_Click(sender As Object, e As EventArgs) Handles btnGetDataOPCH.Click
        Dim myCmd_OPCH As New MySqlCommand
        Dim myAdapter_OPCH As New MySqlDataAdapter
        Dim myData_OPCH As New DataTable
        Dim ID_OPCH As Integer

        conn.Open()
        myCmd_OPCH.Connection = conn

        'myCmd_OPCH.CommandText = "select MAX(DocEntry) AS ID from OPCH"
        'myAdapter_OPCH.SelectCommand = myCmd_OPCH
        'myAdapter_OPCH.Fill(myData_OPCH)
        'ID_OPCH = myData_OPCH.Rows(0).Item("ID")

        'dtLoadData_OPCH = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                               & "from OPCH where U_HeaderID is not null and DocEntry > " & ID_OPCH & " ")

        'dtLoadData_OPCH = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                              & "from OPCH where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18795' and DocEntry > " & ID_OPCH & " ")
        dtLoadData_OPCH = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
                                                     & "from OPCH where U_HeaderID is not null")


        rgvOPCH.DataSource = dtLoadData_OPCH

        conn.Close()
    End Sub

    '----------------
    '----- RPC1 -----
    '----------------

    Private Sub btnSyncDataRPC1_Click(sender As Object, e As EventArgs) Handles btnSyncDataRPC1.Click
        Dim mycmd_RPC1 As New MySqlCommand

        conn.Open()
        mycmd_RPC1.Connection = conn

        For xRPC1 As Integer = 0 To rgvRPC1.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvRPC1.ChildRows(xRPC1).Cells("DocEntry").Value
            Dim LineNum As String = rgvRPC1.ChildRows(xRPC1).Cells("LineNum").Value
            Dim BaseEntry As String = rgvRPC1.ChildRows(xRPC1).Cells("BaseEntry").Value
            Dim BaseLine As String = rgvRPC1.ChildRows(xRPC1).Cells("BaseLine").Value
            Dim ItemCode As String = rgvRPC1.ChildRows(xRPC1).Cells("ItemCode").Value.ToString
            Dim LineStatus As String = rgvRPC1.ChildRows(xRPC1).Cells("LineStatus").Value.ToString
            Dim Quantity As Decimal = Convert.ToDecimal(rgvRPC1.ChildRows(xRPC1).Cells("Quantity").Value)
            Dim U_BudgetRef As String = rgvRPC1.ChildRows(xRPC1).Cells("U_BudgetRef").Value.ToString
            Dim U_Detail_ID As String = rgvRPC1.ChildRows(xRPC1).Cells("U_Detail_ID").Value.ToString

            mycmd_RPC1.CommandText = "INSERT INTO RPC1(DocEntry,ItemCode,LineNum,BaseEntry,BaseLine,LineStatus,Quantity,U_BudgetRef,U_Detail_ID)" _
                & "values('" & DocEntry & "','" & ItemCode & "','" & LineNum & "','" & BaseEntry & "','" & BaseLine & "','" & LineStatus & "','" & Quantity & "','" & U_BudgetRef & "','" & U_Detail_ID & "') "
            mycmd_RPC1.ExecuteNonQuery()
            mycmd_RPC1.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataRPC1_Click(sender As Object, e As EventArgs) Handles btnGetDataRPC1.Click
        Dim myCmd_RPC1 As New MySqlCommand
        Dim myAdapter_RPC1 As New MySqlDataAdapter
        Dim myData_RPC1 As New DataTable
        Dim ID_RPC1 As String

        conn.Open()
        myCmd_RPC1.Connection = conn

        Dim myCmd_RPC1MAX As New MySqlCommand
        Dim myAdapter_RPC1MAX As New MySqlDataAdapter
        Dim myData_RPC1MAX As New DataTable
        Dim RPC1MAX As String
        myCmd_RPC1MAX.Connection = conn

        ''myCmd_RPC1MAX.CommandText = "select max(DocEntry-1) as POR1MAX from RPC1"
        ''myAdapter_RPC1MAX.SelectCommand = myCmd_RPC1MAX
        ''myAdapter_RPC1MAX.Fill(myData_RPC1MAX)
        ''RPC1MAX = myData_RPC1MAX.Rows(0).Item("POR1MAX").ToString

        ''myCmd_RPC1.CommandText = "select group_concat(DocEntry ,LineNum) AS ID from RPC1 where DocEntry >= '" & RPC1MAX & "'"
        ''myAdapter_RPC1.SelectCommand = myCmd_RPC1
        ''myAdapter_RPC1.Fill(myData_RPC1)
        ''ID_RPC1 = myData_RPC1.Rows(0).Item("ID").ToString

        '2017 COMMENT
        'dtLoadData_RPC1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " LineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from RPC1 where U_BudgetRef is not null  AND " _
        '                                               & " convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) NOT IN (" & ID_RPC1 & ") AND DocEntry > '" & RPC1MAX & "'")


        '1-29-2018 COMMENT 
        'dtLoadData_RPC1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " LineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from RPC1 where U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018' AND " _
        '                                               & " convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) NOT IN (" & ID_RPC1 & ") AND DocEntry > '" & RPC1MAX & "'")
        'dtLoadData_RPC1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
        '                                               & " LineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
        '                                               & " from RPC1 where U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018'")
        dtLoadData_RPC1 = Chinita.fetchDbTableSAPvsBAP("SELECT convert(varchar(5),DocEntry,10) + convert(varchar(5),LineNum,10) AS ID, " _
                                                       & " LineStatus,DocEntry,LineNum,BaseEntry,BaseLine,ItemCode,Quantity,U_BudgetRef, U_Detail_ID " _
                                                       & " from RPC1 where U_BudgetRef is not null")


        rgvRPC1.DataSource = dtLoadData_RPC1

        conn.Close()
    End Sub

    '----------------
    '----- ORPC -----
    '----------------


    Private Sub btnSyncDataORPC_Click(sender As Object, e As EventArgs) Handles btnSyncDataORPC.Click
        Dim mycmd_ORPC As New MySqlCommand

        conn.Open()
        mycmd_ORPC.Connection = conn

        For xORPC As Integer = 0 To rgvORPC.ChildRows.Count - 1
            Dim DocEntry As Integer = rgvORPC.ChildRows(xORPC).Cells("DocEntry").Value
            Dim DocNum As Integer = rgvORPC.ChildRows(xORPC).Cells("DocNum").Value
            Dim DocDueDate As String = Convert.ToString(String.Format("{0:yyyy-MM-dd}", rgvORPC.ChildRows(xORPC).Cells("DocDueDate").Value))
            Dim CANCELED As String = rgvORPC.ChildRows(xORPC).Cells("CANCELED").Value.ToString
            Dim U_HeaderID As String = rgvORPC.ChildRows(xORPC).Cells("U_HeaderID").Value.ToString

            mycmd_ORPC.CommandText = "INSERT INTO ORPC(DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID)" _
                & "values('" & DocEntry & "','" & DocNum & "','" & DocDueDate & "','" & CANCELED & "','" & U_HeaderID & "') "
            mycmd_ORPC.ExecuteNonQuery()
            mycmd_ORPC.Parameters.Clear()

        Next

        conn.Close()

        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully Sync.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

    End Sub

    Private Sub btnGetDataORPC_Click(sender As Object, e As EventArgs) Handles btnGetDataORPC.Click
        Dim myCmd_ORPC As New MySqlCommand
        Dim myAdapter_ORPC As New MySqlDataAdapter
        Dim myData_ORPC As New DataTable
        Dim ID_ORPC As Integer

        conn.Open()
        myCmd_ORPC.Connection = conn

        'myCmd_ORPC.CommandText = "select MAX(DocEntry) AS ID from ORPC"
        'myAdapter_ORPC.SelectCommand = myCmd_ORPC
        'myAdapter_ORPC.Fill(myData_ORPC)
        'ID_ORPC = myData_ORPC.Rows(0).Item("ID")

        '2017 COMMENT
        'dtLoadData_ORPC = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                               & "from ORPC where U_HeaderID is not null and DocEntry > " & ID_ORPC & " ")

        'dtLoadData_ORPC = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
        '                                               & "from ORPC where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18563' and DocEntry > " & ID_ORPC & " ")
        dtLoadData_ORPC = Chinita.fetchDbTableSAPvsBAP("select DocEntry,DocNum,DocDueDate,CANCELED,U_HeaderID " _
                                                      & "from ORPC where U_HeaderID is not null")

        rgvORPC.DataSource = dtLoadData_ORPC
        conn.Close()
    End Sub

    Public Sub DeleteMe(ByVal SelectMe As String)
        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. This operation is irreversable. " & Environment.NewLine &
                              "Are you sure you want to delete?",
                  "BAP", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Dim myCmd_Delete As New MySqlCommand
            conn.Open()
            myCmd_Delete.Connection = conn

            myCmd_Delete.CommandText = "CALL SP_DeleteSync('" & SelectMe & "')"
            myCmd_Delete.ExecuteNonQuery()
            myCmd_Delete.Parameters.Clear()
            conn.Close()

            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Successfully Deleted.", "BAP", MessageBoxButtons.OK, RadMessageIcon.Info)

        End If

    End Sub

    Private Sub btnDeletePOR1_Click(sender As Object, e As EventArgs) Handles btnDeletePOR1.Click
        DeleteMe("POR1")
    End Sub

    Private Sub btnDeleteOPOR_Click(sender As Object, e As EventArgs) Handles btnDeleteOPOR.Click
        DeleteMe("OPOR")
    End Sub

    Private Sub btnDeletePDN1_Click(sender As Object, e As EventArgs) Handles btnDeletePDN1.Click
        DeleteMe("PDN1")
    End Sub

    Private Sub btnDeleteOPDN_Click(sender As Object, e As EventArgs) Handles btnDeleteOPDN.Click
        DeleteMe("OPDN")
    End Sub

    Private Sub btnDeleteRPD1_Click(sender As Object, e As EventArgs) Handles btnDeleteRPD1.Click
        DeleteMe("RPD1")
    End Sub

    Private Sub btnDeleteORPD_Click(sender As Object, e As EventArgs) Handles btnDeleteORPD.Click
        DeleteMe("ORPD")
    End Sub

    Private Sub btnDeletePCH1_Click(sender As Object, e As EventArgs) Handles btnDeletePCH1.Click
        DeleteMe("PCH1")
    End Sub

    Private Sub btnDeleteOPCH_Click(sender As Object, e As EventArgs) Handles btnDeleteOPCH.Click
        DeleteMe("OPCH")
    End Sub

    Private Sub btnDeleteRPC1_Click(sender As Object, e As EventArgs) Handles btnDeleteRPC1.Click
        DeleteMe("RPC1")
    End Sub

    Private Sub btnDeleteORPC_Click(sender As Object, e As EventArgs) Handles btnDeleteORPC.Click
        DeleteMe("ORPC")
    End Sub

    Private Sub rgvPCH1_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvPCH1.RowsChanged
        lblPCH1.Text = rgvPCH1.Rows.Count.ToString

    End Sub

    Private Sub rgvGetData_Click(sender As Object, e As EventArgs) Handles rgvGetData.Click
      

        dtLoadData_GetData = Chinita.fetchDbTableSAPvsBAP("SELECT" _
                                                          & "(select count(DocEntry) from OPCH where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18795') as OPCH," _
                                                          & "(select count(DocEntry) from OPDN where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18353') as OPDN," _
                                                          & "(select count(DocEntry) from OPOR where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '19230') as OPOR," _
                                                          & "(select count(DocEntry) from ORPC where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18563') as ORPC," _
                                                          & "(select count(DocEntry) from ORPD where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '19161') as ORPD," _
                                                          & "(select count(DocEntry) from PCH1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as PCH1," _
                                                          & "(select count(DocEntry) from PDN1 WHERE U_BudgetRef is not null and BaseLine is not null and RIGHT(U_BudgetRef,4) = '2018')as PDN1," _
                                                          & "(select count(DocEntry) from POR1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as POR1," _
                                                          & "(select count(DocEntry) from RPC1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as RPC1," _
                                                          & "(select count(DocEntry) from RPD1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as RPD1; ")
        rgvSAP.DataSource = dtLoadData_GetData

        'dtLoadData_GetData = Chinita.fetchDbTableSAPvsBAP("SELECT" _
        '                                                  & "(select count(DocEntry) from OPCH where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18795') as OPCH," _
        '                                                  & "(select count(DocEntry) from OPDN where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18353') as OPDN," _
        '                                                  & "(select count(DocEntry) from OPOR where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '19230') as OPOR," _
        '                                                  & "(select count(DocEntry) from ORPC where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '18563') as ORPC," _
        '                                                  & "(select count(DocEntry) from ORPD where U_HeaderID is not null AND REPLACE(U_HeaderID,'POID','') >= '19161') as ORPD," _
        '                                                  & "(select count(DocEntry) from PCH1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as PCH1," _
        '                                                  & "(select count(DocEntry) from PDN1 WHERE U_BudgetRef is not null and BaseLine is not null and RIGHT(U_BudgetRef,4) = '2018')as PDN1," _
        '                                                  & "(select count(DocEntry) from POR1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as POR1," _
        '                                                  & "(select count(DocEntry) from RPC1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as RPC1," _
        '                                                  & "(select count(DocEntry) from RPD1 WHERE U_BudgetRef is not null and RIGHT(U_BudgetRef,4) = '2018') as RPD1; ")
        'rgvSAP.DataSource = dtLoadData_GetData

        dtLoadData_GetDataBAP = Chinita.fetchDBTable("call  SP_CountForReports()")
        rgvBAP.DataSource = dtLoadData_GetDataBAP

        conn.Close()
    End Sub

    Private Sub rgvPDN1_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvPDN1.RowsChanged
        lblCountMe.Text = rgvPDN1.ChildRows.Count.ToString
    End Sub
End Class
