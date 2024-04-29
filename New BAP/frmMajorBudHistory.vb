Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmMajorBudHistory
    Private Sub FrmMajorBudHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGridMBudget()
    End Sub
    Private Sub FrmMajorBudHistory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SelectMajorBudget()
    End Sub
    Public Sub SelectMajorBudget()
        Dim dtMBudRec As DataTable = Zaji.dbSelect("SP_SelectAllMajorBudgetHistory")
        rgvMBudget.DataSource = dtMBudRec
    End Sub

    Public Sub ReadyGridMBudget()
        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldMID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvMBudget.Columns.Add(fldID)

        Dim fldMjorRefNo As New GridViewTextBoxColumn("Major Ref. No")
        With fldMjorRefNo
            .FieldName = "fldMajorRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        rgvMBudget.Columns.Add(fldMjorRefNo)

        Dim fldDesc As New GridViewTextBoxColumn("Description")
        With fldDesc
            .FieldName = "fldDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvMBudget.Columns.Add(fldDesc)

        Dim fldJpyAmount As New GridViewTextBoxColumn("Old JPY Amount")
        With fldJpyAmount
            .FieldName = "fldJpyAmount"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(fldJpyAmount)
        rgvMBudget.Columns("fldJpyAmount").FormatString = "{0:N2}"

        Dim newJpyAmount As New GridViewTextBoxColumn("New JPY Amount")
        With newJpyAmount
            .FieldName = "fldNewJpyAmount"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(newJpyAmount)
        rgvMBudget.Columns("fldNewJpyAmount").FormatString = "{0:N2}"

        Dim fldDeptColumn As New GridViewTextBoxColumn("Department")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(fldDeptColumn)

        Dim fldYear As New GridViewTextBoxColumn("Year")
        With fldYear
            .FieldName = "GetYear"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        rgvMBudget.Columns.Add(fldYear)

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        With fldDateAdded
            .FieldName = "fldDateAdded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvMBudget.Columns.Add(fldDateAdded)
        rgvMBudget.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks")
        With fldRemarks
            .FieldName = "fldRemarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvMBudget.Columns.Add(fldRemarks)

        Dim fldProject As New GridViewTextBoxColumn("PROJECT")
        With fldProject
            .FieldName = "fldProject"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(fldProject)

        With rgvMBudget
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub


End Class
