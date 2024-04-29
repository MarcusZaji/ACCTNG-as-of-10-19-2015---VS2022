Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Imports System.Data.SqlClient
Imports Telerik.WinControls.Export
Imports System.ComponentModel

Public Class FrmMajorBudget
    Private dtSubBud As DataTable
    Private dtSBudRec As DataTable
    Dim MRefNo As String
    Dim UsrLvl = globalVariables.LoginUserLvl
    Private Sub FrmMajorBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RHandler()

        ReadyGridMBudget()
        ReadyGridSBudget()
        dtpDate.CustomFormat = "yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
        dtpDate.Value = Today
        Security()
    End Sub
    Public Sub RHandler()
        RemoveHandler rgvMBudget.SelectionChanged, AddressOf rgvMBudget_SelectionChanged
        RemoveHandler rgvMBudget.Click, AddressOf rgvMBudget_Click
    End Sub
    Public Sub AHandler()
        AddHandler rgvMBudget.SelectionChanged, AddressOf rgvMBudget_SelectionChanged
        AddHandler rgvMBudget.Click, AddressOf rgvMBudget_Click
        GetSubBudgetValue()
    End Sub

    Private Sub FrmMajorBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Shown()
    End Sub
    Public Sub Shown()
        SelectSubBudget()
        SelectMajorBudget()
        AHandler()
    End Sub
    Public Sub Security()
        If UsrLvl = "ADMINISTRATOR" Or UsrLvl = "MANAGER" Or UsrLvl = "SUPERADMIN" Then
            cbbAdd.Enabled = True
            cbbEdit.Enabled = True
            txtAddSubBudget.Enabled = True
            cbbDelete.Enabled = True
            cbImportData.Enabled = True
        End If
    End Sub

    Public Sub SelectMajorBudget()
        Dim dtMBudRec As DataTable
        If UsrLvl = "ADMINISTRATOR" Or UsrLvl = "SUPERADMIN" Or UsrLvl = "MANAGER" Then
            Zaji.addParameter("_Year", dtpDate.Value.Year)
            dtMBudRec = Zaji.dbSelect("SP_SelectAllMjrbyYear")
        Else
            Zaji.addParameter("Dept", globalVariables.LoginDept)
            Zaji.addParameter("_Year", dtpDate.Value.Year)
            dtMBudRec = Zaji.dbSelect("SP_SelectAllMjrByDept")
        End If


        Dim BudQuery = (From x In dtMBudRec.AsEnumerable()
                        Let _BudTotal = GetTotalBudget(Convert.ToString(x("fldMajorRefNo")))
                        Select New With
                         {
                            .fldMID = x("fldMID"),
                            .fldMajorRefNo = x("fldMajorRefNo"),
                            .fldDesc = x("fldDesc"),
                            .fldJpyAmount = String.Format("{0:N2}", x("fldJpyAmount")),
                            .fldDept = x("fldDept"),
                            .fldYear = x("fldYear"),
                            .fldDateAdded = x("fldDateAdded"),
                            .fldSubRefNo = x("fldSubRefNo"),
                            .fldSubRefDesc = x("fldSubRefDesc"),
                            .GetYear = x("GetYear"),
                            .BudTotal = String.Format("{0:N2}", _BudTotal),
                            .fldProject = x("fldProject")
                         }).ToList

        rgvMBudget.DataSource = Zaji.convertToDatatable(BudQuery)
    End Sub

    Public Sub SelectSubBudget()
        If UsrLvl = "ADMINISTRATOR" Or UsrLvl = "SUPERADMIN" Or UsrLvl = "MANAGER" Then
            dtSBudRec = Zaji.dbSelect("SP_SelectAllSubBud")
            dtSubBud = dtSBudRec
        Else
            Zaji.addParameter("Dept", globalVariables.LoginDept)
            dtSBudRec = Zaji.dbSelect("SP_SelectAllSubBudBydDept")
            dtSubBud = dtSBudRec
        End If

    End Sub
    Function GetTotalBudget(ByVal MajorBdget As String)
        Dim TotalBud = dtSBudRec.AsEnumerable() _
        .Where(Function(x) CStr(x("MarjoRefNo")) = MajorBdget) _
        .Sum(Function(x) CType(x("fldYen"), Decimal))
        Return Convert.ToDecimal(TotalBud)
    End Function
    Public Sub GetSubBudgetValue()
        Try
            MRefNo = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()

            Dim Query = (From Sbud In dtSubBud.AsEnumerable()
                         Where Sbud.Field(Of String)("fldMajorReFNo") = MRefNo
                         Select New With
                                {
                               Key .fldBudgetID = Sbud("fldBudgetID"),
                               Key .fldBudRefNum = Sbud("fldBudRefNum"),
                               Key .fldDept = Sbud("fldDept"),
                               Key .fldDesc = Sbud("fldDesc"),
                               Key .fldClass = Sbud("fldClass"),
                               Key .fldProcess = Sbud("fldProcess"),
                               Key .fldCurrency = Sbud("fldCurrency"),
                               Key .fldYen = String.Format("{0:N2}", Sbud("fldYen")),
                               Key .fldAmount = String.Format("{0:N2}", Sbud("fldAmount")),
                               Key .fldQTY = Sbud("fldQTY"),
                               Key .fldUOM = Sbud("fldUOM"),
                               Key .fldPHPAmount = String.Format("{0:N2}", Sbud("fldPHPAmount")),
                               Key .fldUSDAmount = String.Format("{0:N2}", Sbud("fldUSDAmount")),
                               Key .fldSOU = String.Format("{0:MMM dd, yyyy}", Sbud("fldSOU")),
                               Key .fldMBudgeted = String.Format("{0:MMM dd, yyyy}", Sbud("fldMBudgeted")),
                               Key .fldStat = Sbud("fldStat"),
                               Key .fldRemarks = Sbud("fldRemarks"),
                               Key .fldMonth = Sbud("fldMonth"),
                               Key .fldNB = Sbud("fldNB"),
                               Key .fldUID = Sbud("fldUID"),
                               Key .fldMajorRefNo = Sbud("fldMajorRefNo")
                                }).ToList
            rgvSBudget.DataSource = Zaji.convertToDatatable(Query)
        Catch ex As Exception

        End Try
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

        Dim JpyAmount As New GridViewTextBoxColumn("JPY Amount Original")
        With JpyAmount
            .FieldName = "fldJpyAmount"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(JpyAmount)
        rgvMBudget.Columns("fldJpyAmount").FormatString = "{0:N2}"

        Dim fldJpyAmount As New GridViewTextBoxColumn("Current JPY Amount")
        With fldJpyAmount
            .FieldName = "BudTotal"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvMBudget.Columns.Add(fldJpyAmount)
        rgvMBudget.Columns("BudTotal").FormatString = "{0:N2}"

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

        Dim fldOrdItem As New GridViewCommandColumn("Order Item")
        With fldOrdItem
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .UseDefaultText = True
            .DefaultText = "Order Item"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

        Dim fldDelivered As New GridViewCommandColumn("Delivered Item")
        With fldDelivered
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 80
            .UseDefaultText = True
            .DefaultText = "Delivered Item"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With

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

        AddHandler rgvMBudget.CommandCellClick, AddressOf OrdItemList
        rgvMBudget.Columns.Add(fldOrdItem)
        rgvMBudget.Columns.Add(fldDelivered)
    End Sub
    Private Sub OrdItemList()
        If rgvMBudget.CurrentColumn.HeaderText = "Order Item" Then

            globalVariables.BudRefNo = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()
            frmBOI.txtBRNum.Text = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()
            frmBOI.txtDept.Text = rgvMBudget.CurrentRow.Cells("fldDept").Value.ToString()

            Try
                frmBOI.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try
        ElseIf rgvMBudget.CurrentColumn.HeaderText = "Delivered Item" Then

            globalVariables.BudRefNo = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()
            frmBAI.txtBRNum.Text = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()
            frmBAI.txtDept.Text = rgvMBudget.CurrentRow.Cells("fldDept").Value.ToString()

            Try
                frmBAI.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try
        End If
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

        Dim fldUpdate As New GridViewCommandColumn("UPDATE")
        With fldUpdate
            .FieldName = "UPDATE"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "UPDATE"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvSBudget.Columns.Add(fldUpdate)


        AddHandler rgvSBudget.CommandCellClick, AddressOf UpdateMe

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
    Private Sub UpdateMe()
        If rgvSBudget.CurrentColumn.HeaderText = "UPDATE" Then
            Try
                FrmUpdateSubBudget.txtID.Text = rgvSBudget.CurrentRow.Cells("fldBudgetID").Value.ToString
                FrmUpdateSubBudget.txtBRNum.Text = rgvSBudget.CurrentRow.Cells("fldBudRefNum").Value.ToString
                FrmUpdateSubBudget.ddlMBudget.Text = rgvSBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString
                FrmUpdateSubBudget.ddlDept.Text = rgvSBudget.CurrentRow.Cells("fldDept").Value.ToString
                globalVariables._Class = rgvSBudget.CurrentRow.Cells("fldClass").Value.ToString
                FrmUpdateSubBudget.txtDesc.Text = rgvSBudget.CurrentRow.Cells("fldDesc").Value.ToString
                globalVariables.Process = rgvSBudget.CurrentRow.Cells("fldProcess").Value.ToString
                FrmUpdateSubBudget.ddlCurrency.Text = rgvSBudget.CurrentRow.Cells("fldCurrency").Value.ToString
                FrmUpdateSubBudget.mebQTY.Value = rgvSBudget.CurrentRow.Cells("fldQTY").Value.ToString
                FrmUpdateSubBudget.ddlUOM.Text = rgvSBudget.CurrentRow.Cells("fldUOM").Value.ToString
                FrmUpdateSubBudget.dtpSOU.Value = rgvSBudget.CurrentRow.Cells("fldSOU").Value.ToString
                FrmUpdateSubBudget.dtpMBudgeted.Value = rgvSBudget.CurrentRow.Cells("fldMBudgeted").Value.ToString
                FrmUpdateSubBudget.ddlStat.Text = rgvSBudget.CurrentRow.Cells("fldStat").Value.ToString
                FrmUpdateSubBudget.mebAmount.Value = rgvSBudget.CurrentRow.Cells("fldAmount").Value.ToString
                FrmUpdateSubBudget.mebJPY.Value = rgvSBudget.CurrentRow.Cells("fldYen").Value.ToString
                FrmUpdateSubBudget.dtpDate.Value = rgvSBudget.CurrentRow.Cells("fldMBudgeted").Value.ToString
                FrmUpdateSubBudget.txtOrgAmountFix.Value = rgvSBudget.CurrentRow.Cells("fldAmount").Value.ToString
                FrmUpdateSubBudget.txtMajorAmount.Value = rgvMBudget.CurrentRow.Cells("BudTotal").Value.ToString
                FrmUpdateSubBudget.txtMID.Text = rgvMBudget.CurrentRow.Cells("fldMID").Value.ToString
                FrmUpdateSubBudget.txtJPYOrg.Value = rgvSBudget.CurrentRow.Cells("fldYen").Value.ToString
                Try
                    FrmUpdateSubBudget.Show()
                Catch ex As Exception
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                End Try
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub rgvMBudget_Click(sender As Object, e As EventArgs) Handles rgvMBudget.Click
        GetSubBudgetValue()
    End Sub

    Private Sub rgvMBudget_SelectionChanged(sender As Object, e As EventArgs) Handles rgvMBudget.SelectionChanged
        Try
            GetSubBudgetValue()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cbbRefresh_Click(sender As Object, e As EventArgs) Handles cbbRefresh.Click
        SelectMajorBudget()
        SelectSubBudget()
    End Sub

    Private Sub cbImportData_Click(sender As Object, e As EventArgs) Handles cbImportData.Click
        If Zaji.IsFormOpen(FrmImportMasterBudget) Then
            FrmImportMasterBudget.Focus()
        Else
            FrmImportMasterBudget.Show()
        End If
    End Sub

    Private Sub cbbAdd_Click(sender As Object, e As EventArgs) Handles cbbAdd.Click
        If Zaji.IsFormOpen(FrmAddMBudget) Then
            FrmAddMBudget.Focus()
        Else
            FrmAddMBudget.Show()
        End If
    End Sub

    Private Sub cbbEdit_Click(sender As Object, e As EventArgs) Handles cbbEdit.Click
        If Zaji.IsFormOpen(FrmAddMBudget) Then
            FrmAddMBudget.Focus()
        Else
            globalVariables.BudRefNo = rgvMBudget.CurrentRow.Cells("fldMajorRefNo").Value.ToString()
            globalVariables.Desc = rgvMBudget.CurrentRow.Cells("fldDesc").Value.ToString()
            globalVariables.Dpt = rgvMBudget.CurrentRow.Cells("fldDept").Value.ToString()
            globalVariables.Year = rgvMBudget.CurrentRow.Cells("GetYear").Value.ToString()
            globalVariables.JPY = Convert.ToDecimal(rgvMBudget.CurrentRow.Cells("fldJpyAmount").Value.ToString())
            FrmAddMBudget.txtID.Text = rgvMBudget.CurrentRow.Cells("fldMID").Value.ToString()
            FrmAddMBudget.Show()
        End If
    End Sub

    Private Sub cbExport_Click(sender As Object, e As EventArgs) Handles cbExport.Click
        If rgvMBudget.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.rgvMBudget)
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

    Private Sub txtAddSubBudget_Click(sender As Object, e As EventArgs) Handles txtAddSubBudget.Click
        If Zaji.IsFormOpen(FrmAddSubBudget) Then
            FrmAddSubBudget.Focus()
        Else
            FrmAddSubBudget.Show()
        End If
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        RHandler()
        Shown()
    End Sub

    Private Sub cbHistory_Click(sender As Object, e As EventArgs) Handles cbHistory.Click
        If Zaji.IsFormOpen(FrmBudgetHistory) Then
            FrmBudgetHistory.Focus()
        Else
            FrmBudgetHistory.Show()
        End If
    End Sub

    Private Sub cbMajorBudgetHistory_Click(sender As Object, e As EventArgs) Handles cbMajorBudgetHistory.Click
        If Zaji.IsFormOpen(FrmMajorBudHistory) Then
            FrmMajorBudHistory.Focus()
        Else
            FrmMajorBudHistory.Show()
        End If
    End Sub

    Private Sub btnExportSub_Click(sender As Object, e As EventArgs) Handles btnExportSub.Click
        If rgvSBudget.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.rgvSBudget)
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


End Class