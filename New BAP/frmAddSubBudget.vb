Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmAddSubBudget
    Public linestat As String
    Public lineNo As Integer
    Private dtSubBudget As DataTable
    Private Sub FrmAddSubBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.CustomFormat = "yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
        dtpDate.Value = Today
        ReadyGrid()
        txtSignature.Text = globalVariables.LoginSignature

    End Sub

    Private Sub FrmAddSubBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SelectClass()
        SelectDepartment()
        SelectProcess()
        LoadDropDown()
        dtSubBudget = Zaji.dbSelect("SP_SelectAllBudget")
    End Sub
    Public Sub LoadDropDown()

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REF. NO.")
        fldMajorRefNo.FieldName = "fldMajorRefNo"
        fldMajorRefNo.Width = 130
        ddlMBudget.MultiColumnComboBoxElement.Columns.Add(fldMajorRefNo)

        Dim fldDept As New GridViewTextBoxColumn("Department")
        fldDept.FieldName = "fldDept"
        fldDept.Width = 100
        ddlMBudget.MultiColumnComboBoxElement.Columns.Add(fldDept)

        Zaji.addParameter("_Year", dtpDate.Value.Year)
        Dim dtCustomer As DataTable = Zaji.dbSelect("SP_SelectAllMjrbyYear")
        ddlMBudget.DataSource = dtCustomer
        ddlMBudget.ValueMember = "fldMajorRefNo"
        ddlMBudget.DisplayMember = "fldMajorRefNo"
        ddlMBudget.MultiColumnComboBoxElement.DropDownWidth = 200

        ddlMBudget.AutoFilter = True
        ddlMBudget.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        Dim RefNo As New FilterDescriptor()
        RefNo.PropertyName = "fldMajorRefNo"
        RefNo.Operator = FilterOperator.Contains
        ddlMBudget.EditorControl.MasterTemplate.FilterDescriptors.Add(RefNo)
    End Sub
    Public Sub SelectDepartment()
        Dim DTDept As DataTable = Zaji.dbSelect("SP_SelectAllDepartment")
        ddlDept.DataSource = DTDept
        ddlDept.DisplayMember = "fldDeptCode"
    End Sub
    Public Sub SelectClass()
        Dim DTClass As DataTable = Zaji.dbSelect("SP_SelectClassDesc")
        ddlClass.DataSource = DTClass
        ddlClass.DisplayMember = "fldClassDesc"
    End Sub
    Public Sub SelectProcess()
        Dim DTProcess As DataTable = Zaji.dbSelect("SP_SelectAllProcess")
        ddlProcess.DataSource = DTProcess
        ddlProcess.DisplayMember = "fldProcessCode"
    End Sub
    Private Sub ReadyGrid()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "STATUS"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldStatColumn)

        Dim CheckifExist As New GridViewTextBoxColumn("Check")
        With CheckifExist
            .FieldName = "CheckifExist"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        rgvList.Columns.Add(CheckifExist)

        Dim fldMajorRefNo As New GridViewTextBoxColumn("MAJOR REFERENCE NO.")
        With fldMajorRefNo
            .FieldName = "fldMajorRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldMajorRefNo)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldStat"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE"}
        End With
        rgvList.Columns.Add(fldStatusColumn)

        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldAmountColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmount").FormatString = "{0:N2}"

        Dim fldAmountJPYColumn As New GridViewTextBoxColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "fldYen"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("fldYen").FormatString = "{0:N2}"

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
        End With
        rgvList.Columns.Add(fldUOMColumn)

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



        '-------------------------'
        '-----GRID PROPERTIES-----'
        '-------------------------'

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = True
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        globalVariables.ImportSelect = "SUB BUDGET"
        If Zaji.IsFormOpen(FrmImport) Then
            FrmImport.Focus()
        Else
            FrmImport.Show()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Zaji.addParameter("BudRefNum", Regex.Replace(txtBRNum.Text, "\s+", " "))
        Dim RecordCheck As DataTable = Zaji.dbSelect("SP_CheckMeSubRefNo")

        Dim CheckMe = RecordCheck.Rows(0).Item("CheckMe").ToString()

        If CheckMe >= "1" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("This Sub Budget Already Exist", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            'Exit Sub
        End If

        If String.IsNullOrEmpty(txtBRNum.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Empty Budget Ref Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Department Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlClass.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Classification Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlProcess.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Process Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Budget Description", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Unit of Measurement Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf mebQTY.Value = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Quantity", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf mebAmount.Value = 0.0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else
            Dim Check As String = CheckifExist(txtBRNum.Text)
            Dim Result As String
            If String.IsNullOrEmpty(Check) Then
                Result = "doesn't exist"
            Else
                Result = "existing"
            End If

            rgvList.Rows.Add("", Result, ddlMBudget.Text, ddlDept.Text, ddlClass.Text, txtBRNum.Text,
                         ddlStat.Text, ddlCurrency.Text, mebAmount.Text, mebJPY.Text,
                         ddlProcess.Text, mebQTY.Text, ddlUOM.Text, dtpSOU.Text, txtDesc.Text,
                         dtpMBudgeted.Text)
        End If
    End Sub
    Function CheckifExist(ByVal SubBudget As String)
        Dim Query = (From i In dtSubBudget.AsEnumerable()
                     Where Convert.ToString(i("fldBudRefNum")) = SubBudget
                     Select Convert.ToString(i("fldBudRefNum"))).FirstOrDefault()

        Return Convert.ToString(Query)
    End Function
    Private Sub CurrencyRate()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        Dim CCode As String = ""

        Try
            Dim Year As String = dtpDate.Value.Year

            If (ddlCurrency.Text = "PHP") Then
                conn.Open()
                myCmd.Connection = conn
                myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE Year(fldDate) = '" & Year & "' and `fldcurrency` = 'JPY-PHP'"
                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)
            ElseIf (ddlCurrency.Text = "USD") Then
                conn.Open()
                myCmd.Connection = conn
                myCmd.CommandText = "SELECT fldAmount FROM `tblConversion` WHERE Year(fldDate) = '" & Year & "' and `fldcurrency` = 'USD-JPY'"
                myAdapter.SelectCommand = myCmd
                myAdapter.Fill(myData)
            End If

            If (ddlCurrency.Text = "PHP") Then
                mebJPY.Text = mebAmount.Text / myData.Rows(0).Item("fldAmount")

            ElseIf (ddlCurrency.Text = "USD") Then
                mebJPY.Text = mebAmount.Text * myData.Rows(0).Item("fldAmount")
            ElseIf (ddlCurrency.Text = "JPY") Then
                mebJPY.Text = mebAmount.Text
            Else
                mebJPY.Text = 0
            End If

            conn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.TextChanged
        CurrencyRate()
    End Sub


    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        bwUpload.RunWorkerAsync()
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            rgvList.DataSource = Nothing
        End If
    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & rgvList.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.rgvList.SelectedRows.Count - 1) {}
            Me.rgvList.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.rgvList.Rows.Remove(rows(i))
            Next
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
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

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30
        For counter As Integer = 0 To rgvList.Rows.Count - 1

            Zaji.addParameter("BudRefNum", Regex.Replace(rgvList.Rows(counter).Cells("fldBudRefNum").Value, "\s+", " "))
            Zaji.addParameter("Dept", Regex.Replace(rgvList.Rows(counter).Cells("fldDept").Value, "\s+", " "))
            Zaji.addParameter("Class", Regex.Replace(rgvList.Rows(counter).Cells("fldClass").Value, "\s+", " "))
            Zaji.addParameter("_Desc", Regex.Replace(rgvList.Rows(counter).Cells("fldDesc").Value, "\s+", " "))
            Zaji.addParameter("_Process", Regex.Replace(rgvList.Rows(counter).Cells("fldProcess").Value, "\s+", " "))
            Zaji.addParameter("QTY", Convert.ToDecimal(rgvList.Rows(counter).Cells("fldQTY").Value))
            Zaji.addParameter("UOM", Regex.Replace(rgvList.Rows(counter).Cells("fldUOM").Value, "\s+", " "))
            Zaji.addParameter("SOU", rgvList.Rows(counter).Cells("fldSOU").Value)
            Zaji.addParameter("Currency", Regex.Replace(rgvList.Rows(counter).Cells("fldCurrency").Value, "\s+", " "))
            Zaji.addParameter("Amount", Convert.ToDecimal(rgvList.Rows(counter).Cells("fldAmount").Value))
            Zaji.addParameter("Yen", Convert.ToDecimal(rgvList.Rows(counter).Cells("fldYen").Value))
            Zaji.addParameter("MBudgeted", rgvList.Rows(counter).Cells("fldMBudgeted").Value)
            Zaji.addParameter("Stat", Regex.Replace(rgvList.Rows(counter).Cells("fldStat").Value, "\s+", " "))
            Zaji.addParameter("MajorRefNo", Regex.Replace(rgvList.Rows(counter).Cells("fldMajorRefNo").Value, "\s+", " "))
            Zaji.addParameter("_Year", DateTime.Today)

            If Zaji.dbAED("SP_InsertSubBudgetv2") Then
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

    Private Sub ddlMBudget_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlMBudget.SelectedIndexChanged
        Dim selectedRow As GridViewDataRowInfo = CType(ddlMBudget.SelectedItem, GridViewDataRowInfo)
        ddlDept.Text = selectedRow.Cells("fldDept").Value.ToString()
    End Sub

    Private Sub rgvList_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles rgvList.RowFormatting
        If e.RowElement.RowInfo.Cells("CheckifExist").Value = "existing" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Gold
        Else
            e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub
End Class