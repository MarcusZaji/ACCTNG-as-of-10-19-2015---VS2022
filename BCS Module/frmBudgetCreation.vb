Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmBudgetCreation

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Public LoadCount As Integer

    Private Sub frmBudgetCreation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)
        txtSignature.ReadOnly = True

        DepartmentBC()
        ClassificationBC()
        SubClassBC()
        ProcessBC()
        ddlDataUOMBC()
        ddlYearBC()

        UID = SelectedDetails

        ReadyGrid()

        'Clear(Me)

        GetUser()

        CheckU()
        CheckModuleStatus()

        ddlYear.Text = Today.Year + 1
        dtpSOU.Value = Nothing

    End Sub

    Private Sub CheckModuleStatus()
        Dim check As DataRow = Chinita.fetchMySqlRow_BC("select fldCode from tblSetting where fldSettingID = 1")

        If frmMain.lblAccesslvl.Text = "SUPERADMIN" Or frmMain.lblAccesslvl.Text = "ADMINISTRATOR" Then
            btnSaveBC.Visible = True
            btnDelete.Visible = True
            btnFinalize.Visible = True

        Else
            If check.Item("fldCode").ToString = "YES" Then
                btnSaveBC.Visible = False
                btnDelete.Visible = False
                btnFinalize.Visible = False
            Else
                btnSaveBC.Visible = True
                btnDelete.Visible = True
                btnFinalize.Visible = True
            End If

        End If
    End Sub

    Private Sub frmBudgetCreation_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If
            Me.Close()
        End If

    End Sub

    Private Sub CheckU()
        Try
            If lblUserlvl.Text = "SUPERADMIN" Then
                btnSaveBC.Visible = True
                btnConversion.Visible = True
                btnFinalize.Visible = True

            Else
                btnSaveBC.Visible = True
                btnConversion.Visible = False
                btnFinalize.Visible = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

    End Sub

    Private Sub frmBudgetCreation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadData.RunWorkerAsync()
        pbOhYeah.Visible = True
        Clear(Me)
    End Sub

    Private Sub ReadyGrid()
        '-----------------'
        '--MASTER BUDGET--'
        '-----------------'

        Dim fldBIDColumn As New GridViewDecimalColumn("ID")
        With fldBIDColumn
            .FieldName = "fldBudID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldBIDColumn)

        Dim fldBYColumn As New GridViewTextBoxColumn("YEAR")
        With fldBYColumn
            .FieldName = "Byear"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            '.DropDownStyle = RadDropDownStyle.DropDownList
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldBYColumn)


        Dim fldSubRefNo As New GridViewTextBoxColumn("MAJOR REF NO.")
        With fldSubRefNo
            .FieldName = "fldSubRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldSubRefNo)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("SUB REF NO.")
        With fldBudRefColumn
            .FieldName = "fldBCRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldIndexColumn As New GridViewTextBoxColumn("INDEX")
        With fldIndexColumn
            .FieldName = "fldIndex"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldIndexColumn)

        Dim fldCheckBoxColumn As New GridViewCheckBoxColumn(" ")
        With fldCheckBoxColumn
            .FieldName = "chk"
            .Width = 30
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .ReadOnly = False
            .EnableHeaderCheckBox = True
        End With
        rgvList.Columns.Add(fldCheckBoxColumn)

        Dim fldStatusColumn As New GridViewComboBoxColumn("STATUS")
        With fldStatusColumn
            .FieldName = "fldStatus"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"OPEN", "CLOSE"}
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldStatusColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("BUDGET DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 400
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldUAmountColumn As New GridViewTextBoxColumn("UNIT PRICE")
        With fldUAmountColumn
            .FieldName = "fldUAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldUAmountColumn)
        rgvList.Columns("fldUAmount").FormatString = "{0:N2}"

        Dim fldAmountColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmount").FormatString = "{0:N2}"

        Dim fldAmountJPYColumn As New GridViewTextBoxColumn("JPY AMOUNT")
        With fldAmountJPYColumn
            .FieldName = "JPY"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldAmountJPYColumn)
        rgvList.Columns("JPY").FormatString = "{0:N2}"

        Dim fldAmountPHPColumn As New GridViewTextBoxColumn("PHP AMOUNT")
        With fldAmountPHPColumn
            .FieldName = "PHP"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldAmountPHPColumn)
        rgvList.Columns("PHP").FormatString = "{0:N2}"

        Dim fldAmountUSDColumn As New GridViewTextBoxColumn("USD AMOUNT")
        With fldAmountUSDColumn
            .FieldName = "USD"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldAmountUSDColumn)
        rgvList.Columns("USD").FormatString = "{0:N2}"

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldActivityCodeColumn As New GridViewTextBoxColumn("ACTIVITY CODE")
        With fldActivityCodeColumn
            .FieldName = "fldActivityCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldActivityCodeColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldClassCodeColumn As New GridViewTextBoxColumn("CLASS CODE")
        With fldClassCodeColumn
            .FieldName = "fldClassCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldClassCodeColumn)

        Dim fldSubClassColumn As New GridViewTextBoxColumn("SUB CLASSIFICATION")
        With fldSubClassColumn
            .FieldName = "fldSubClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSubClassColumn)

        Dim fldSubClassCodeColumn As New GridViewTextBoxColumn("SUB CLASS CODE")
        With fldSubClassCodeColumn
            .FieldName = "fldSubClassCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSubClassCodeColumn)

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
            .ReadOnly = True
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
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldSOUColumn)
        rgvList.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"

        Dim fldMBudgetedColumn As New GridViewDateTimeColumn("MONTH BUDGETED")
        With fldMBudgetedColumn
            .FieldName = "fldMonthBudgeted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMBudgetedColumn)
        rgvList.Columns("fldMonthBudgeted").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldRemarks"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldRemarksColumn)

        ' Dim fldLoanCode As New GridViewSummaryItem("fldLoanCode", "TOTAL", GridAggregateFunction.Var)
        'Dim fldPaidInstallment As New GridViewSummaryItem("fldLoanNoOfInstallmentPaid", "{0}", GridAggregateFunction.Sum)
        Dim fldTotal As New GridViewSummaryItem("fldBudRefNum", "TOTAL", GridAggregateFunction.Var)
        Dim fldOrigAmount As New GridViewSummaryItem("fldAmount", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldYEN As New GridViewSummaryItem("JPY", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldPHP As New GridViewSummaryItem("PHP", "{0:N2}", GridAggregateFunction.Sum)
        Dim fldUSD As New GridViewSummaryItem("USD", "{0:N2}", GridAggregateFunction.Sum)

        Dim SummaryRowItem As New GridViewSummaryRowItem()
        SummaryRowItem.Add(fldTotal)
        SummaryRowItem.Add(fldOrigAmount)
        SummaryRowItem.Add(fldYEN)
        SummaryRowItem.Add(fldPHP)
        SummaryRowItem.Add(fldUSD)

        rgvList.SummaryRowsBottom.Add(SummaryRowItem)

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
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If bwLoadData.IsBusy Then
            bwLoadData.CancelAsync()
            imBusy = False
        End If

        Me.Close()
    End Sub

    Public Sub Clear(ByVal root As Control)

        For Each ctrl As Control In root.Controls
            Clear(ctrl)

            If TypeOf ctrl Is Telerik.WinControls.UI.RadTextBoxControl Then
                CType(ctrl, Telerik.WinControls.UI.RadTextBoxControl).Text = ""
            End If

            If TypeOf ctrl Is Telerik.WinControls.UI.RadMaskedEditBox Then
                CType(ctrl, Telerik.WinControls.UI.RadMaskedEditBox).Text = ""
            End If

            If TypeOf ctrl Is Telerik.WinControls.UI.RadDropDownList Then
                CType(ctrl, Telerik.WinControls.UI.RadDropDownList).Text = ""
            End If

        Next ctrl

        txtBCRefNo.Text = ""
        ddlClassCode.Text = ""
        ddlYear.Text = Today.Year + 1

        dtpSOU.Value = Nothing

    End Sub

    Private Sub btnSaveBud_Click(sender As Object, e As EventArgs) Handles btnSaveBC.Click

        If EditPicker = 0 Then

            Dim dtchkMonth As DataTable = Chinita.fetchDBTable_BC _
                                      ("select month(fldMonthBudgeted) as chkMonth from tblBudget " _
                                       & "where fldBCRefNo = '" & txtBCRefNo.Text & "' AND fldStatus != 'DELETED' ")

            For x As Integer = 0 To dtchkMonth.Rows.Count - 1
                If dtpMBudgeted.Value.Month = dtchkMonth.Rows(x).Item("chkMonth").ToString Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Budget Already set to this month.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
                    Exit Sub
                End If
            Next

            If String.IsNullOrEmpty(ddlDept.Text) Then
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

            ElseIf mebUnitPrice.Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Unit Price", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf mebAmount.Value = 0.0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Currency Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf dtpMBudgeted.Value.Year <> Today.Year + 1 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please check Month/Year Budgeted.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("Are you sure you want to add this budget?",
                          "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                    If ddlClassCode.Text = "PPE" Then

                        If String.IsNullOrEmpty(ddlSubClass.Text) Then
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("No Sub-Classification selected.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                        Else
                            If Tomboy.AddCreatedBudgetPPE(txtBCRefNo.Text,
                                                          ddlDept.Text,
                                                          txtActivityCode.Text,
                                                          ddlClass.Text,
                                                          ddlClassCode.Text,
                                                          ddlSubClass.Text,
                                                          ddlSubClassCode.Text,
                                                          txtDesc.Text,
                                                          ddlProcess.Text,
                                                          mebQTY.Value,
                                                          ddlUOM.Text,
                                                          dtpSOU.Value,
                                                          ddlCurrency.Text,
                                                          mebUnitPrice.Value,
                                                          mebAmount.Value,
                                                          dtpMBudgeted.Value,
                                                          txtRemarks.Text,
                                                          txtSignature.Text,
                                                          txtSubRefNo.Text) Then

                                bwLoadData.RunWorkerAsync()
                                RadMessageBox.SetThemeName("Windows8")
                                RadMessageBox.Show("Budget Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                                Clear(Me)

                            End If

                        End If

                    Else
                        If Tomboy.AddCreatedBudget(txtBCRefNo.Text,
                                                   ddlDept.Text,
                                                   txtActivityCode.Text,
                                                   ddlClass.Text,
                                                   ddlClassCode.Text,
                                                   txtDesc.Text,
                                                   ddlProcess.Text,
                                                   mebQTY.Value,
                                                   ddlUOM.Text,
                                                   dtpSOU.Value,
                                                   ddlCurrency.Text,
                                                   mebUnitPrice.Value,
                                                   mebAmount.Value,
                                                   dtpMBudgeted.Value,
                                                   txtRemarks.Text,
                                                   txtSignature.Text,
                                                   txtSubRefNo.Text) Then

                            bwLoadData.RunWorkerAsync()
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("Budget Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                            Clear(Me)

                        End If
                    End If
                End If
            End If

        Else
                If String.IsNullOrEmpty(txtBCRefNo.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No BC Control Number Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

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

                ElseIf mebUnitPrice.Value = 0.0 Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No Unit Price", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf mebAmount.Value = 0.0 Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No Amount", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No Currency Selected", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                'ElseIf dtpMBudgeted.Value.Year <> Today.Year + 1 Then
                '    RadMessageBox.SetThemeName("Windows8")
                '    RadMessageBox.Show("Please check Month/Year Budgeted.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
            ElseIf dtpMBudgeted.Value.Year <> Today.Year + 1 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please check Month/Year Budgeted.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                Else
                    RadMessageBox.SetThemeName("Windows8")
                If RadMessageBox.Show("Are you sure you want to update this budget?",
                              "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                    If ddlClassCode.Text = "PPE" Then

                        If String.IsNullOrEmpty(ddlSubClass.Text) Then
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("No Sub-Classification selected.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                        Else
                            If Tomboy.UpdateCreatedBudgetPPE(txtBCRefNo.Text,
                                                             ddlDept.Text,
                                                             txtActivityCode.Text,
                                                             ddlClass.Text,
                                                             ddlClassCode.Text,
                                                             ddlSubClass.Text,
                                                             ddlSubClassCode.Text,
                                                             txtDesc.Text,
                                                             ddlProcess.Text,
                                                             mebQTY.Value,
                                                             ddlUOM.Text,
                                                             dtpSOU.Value,
                                                             ddlCurrency.Text,
                                                             mebUnitPrice.Value,
                                                             mebAmount.Value,
                                                             dtpMBudgeted.Value,
                                                             txtRemarks.Text) Then

                                bwLoadData.RunWorkerAsync()
                                RadMessageBox.SetThemeName("Windows8")
                                RadMessageBox.Show("Budget Updated!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                                Clear(Me)
                            End If

                        End If

                    Else
                        If Tomboy.UpdateCreatedBudget(txtBCRefNo.Text,
                                                      ddlDept.Text,
                                                      txtActivityCode.Text,
                                                      ddlClass.Text,
                                                      ddlClassCode.Text,
                                                      txtDesc.Text,
                                                      ddlProcess.Text,
                                                      mebQTY.Value,
                                                      ddlUOM.Text,
                                                      dtpSOU.Value,
                                                      ddlCurrency.Text,
                                                      mebUnitPrice.Value,
                                                      mebAmount.Value,
                                                      dtpMBudgeted.Value,
                                                      txtRemarks.Text) Then

                            bwLoadData.RunWorkerAsync()
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("Budget Updated!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                            Clear(Me)
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Dim BYEAR As Integer = ddlYear.Text
        Dim DEPT As String = lblDept.Text

        Try
            If lblUserlvl.Text = "ADMINISTRATOR" Or lblUserlvl.Text = "SUPERADMIN" Then
                dtLoadData = Chinita.fetchDBTable_BC("call SP_GetBudgetCreatedAdmin('" & BYEAR & "')")
            Else
                dtLoadData = Chinita.fetchDBTable_BC("call SP_GetBudgetCreatedNonAdmin('" & DEPT & "','" & BYEAR & "')")
            End If

            For counter As Integer = 0 To dtLoadData.Rows.Count - 1

                Dim x As Double = counter / dtLoadData.Rows.Count * 100
                bwLoadData.ReportProgress(x)
                Threading.Thread.Sleep(Delay)

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        pbOhYeah.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOhYeah.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        Try
            rgvList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOhYeah.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try
        
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear(Me)
        chkEdit.Checked = False
        ddlCurrency.Enabled = True
        rgvList.FilterDescriptors.Clear()
        'btnFinalize.Visible = False
        'btnSaveBC.Visible = True
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Clear(Me)

        Try
            bwLoadData.RunWorkerAsync()
            rgvList.Refresh()

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Multiple Refresh", "Notification", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

    End Sub

    '----- KEYPRESS OF DROP DOWN LIST -----'

    Private Sub ddlDept_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlDept.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlClass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlClass.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlProcess_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ddlProcess.KeyPress
        keyFilter(sender, e)
    End Sub

    Private Sub ddlStat_KeyPress(sender As Object, e As KeyPressEventArgs)
        keyFilter(sender, e)
    End Sub

    '---------------------------------------'

    Private Sub CurrencyRate()
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim CCode As String = ""

        Try
            Dim Year As String = dtpMBudgeted.Value.Year

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

    Private Sub mebAmount_ValueChanged(sender As Object, e As EventArgs) Handles mebAmount.ValueChanged
        CurrencyRate()
    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Try
            System.Diagnostics.Process.Start("C:\Windows\system32\calc.exe")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnConversion_Click(sender As Object, e As EventArgs) Handles btnConversion.Click
        Try
            frmConversionBC.Show(Me)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub GetData()

        Try
            txtBCRefNo.Text = rgvList.CurrentRow.Cells("fldBCRefNo").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString
            txtActivityCode.Text = rgvList.CurrentRow.Cells("fldActivityCode").Value.ToString
            ddlClass.Text = rgvList.CurrentRow.Cells("fldClass").Value.ToString
            ddlClassCode.Text = rgvList.CurrentRow.Cells("fldClassCode").Value.ToString
            ddlSubClass.Text = rgvList.CurrentRow.Cells("fldSubClass").Value.ToString
            ddlSubClassCode.Text = rgvList.CurrentRow.Cells("fldSubClassCode").Value.ToString
            txtDesc.Text = rgvList.CurrentRow.Cells("fldDesc").Value.ToString
            ddlProcess.Text = rgvList.CurrentRow.Cells("fldProcess").Value.ToString
            ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
            txtRemarks.Text = rgvList.CurrentRow.Cells("fldRemarks").Value.ToString

            mebQTY.Value = rgvList.CurrentRow.Cells("fldQTY").Value.ToString
            mebUnitPrice.Value = rgvList.CurrentRow.Cells("fldUAmount").Value.ToString
            mebAmount.Text = rgvList.CurrentRow.Cells("fldAmount").Value.ToString
            ddlUOM.Text = rgvList.CurrentRow.Cells("fldUOM").Value.ToString
            dtpSOU.Value = rgvList.CurrentRow.Cells("fldSOU").Value.ToString
            dtpMBudgeted.Value = rgvList.CurrentRow.Cells("fldMonthBudgeted").Value.ToString

            txtSubRefNo.Text = rgvList.CurrentRow.Cells("fldSubRefNo").Value.ToString

            If rgvList.CurrentRow.Cells("fldStatus").Value.ToString = "FINAL" Then
                btnSaveBC.Enabled = False
                btnDelete.Enabled = False
            Else
                btnSaveBC.Enabled = True
                btnDelete.Enabled = True
            End If

            If chkEdit.Checked = True Then
                EditPicker = 1
                btnSaveBC.Text = "Update"
                btnCLS.Enabled = False
                mebUnitPrice.Enabled = True
                'ddlCurrency.Enabled = True
                'ddlClass.Enabled = True
                'mebUnitPrice.Enabled = True

            Else
                EditPicker = 0
                btnSaveBC.Text = "Save"
                btnCLS.Enabled = True

                If String.IsNullOrEmpty(txtBCRefNo.Text) Then
                    ddlCurrency.Enabled = True

                    ddlDept.Enabled = True
                    ddlClass.Enabled = True
                    txtDesc.Enabled = True
                    ddlProcess.Enabled = True
                    ddlUOM.Enabled = True
                    mebUnitPrice.Enabled = True
                Else
                    ddlCurrency.Enabled = False

                    ddlDept.Enabled = False
                    ddlClass.Enabled = False
                    txtDesc.Enabled = False
                    ddlProcess.Enabled = False
                    ddlUOM.Enabled = False
                    mebUnitPrice.Enabled = False
                End If

            End If

            CheckDate()

        Catch ex As Exception
            Clear(Me)
        End Try

    End Sub

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick
        GetData()
    End Sub

    Private Sub rgvList_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles rgvList.RowFormatting
        If e.RowElement.RowInfo.Cells("fldStatus").Value.ToString = "FINAL" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.LightPink

        Else
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Transparent

        End If
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        GetData()
    End Sub

    Private Sub chkEdit_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles chkEdit.ToggleStateChanged
        If chkEdit.Checked = True Then
            EditPicker = 1
            btnSaveBC.Text = "Update"
            btnCLS.Enabled = False

            GetData()

        Else
            EditPicker = 0
            btnSaveBC.Text = "Save"
            btnCLS.Enabled = True

            GetData()
           
        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("Are you sure you want to delete this budget?",
                  "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If Tomboy.DeleteCreatedBudget("DELETED") Then

                bwLoadData.RunWorkerAsync()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Budget Deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Clear(Me)

                pbOlrayt.Visible = False

            End If
        End If

    End Sub

    Private Sub btnFinalize_Click(sender As Object, e As EventArgs) Handles btnFinalize.Click
        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("This process is irreversable. Are you sure you want to finalize this budget?",
                  "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If Tomboy.FinalizeCreatedBudget("FINAL") Then

                bwLoadData.RunWorkerAsync()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Budget Finalized!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

                Clear(Me)

                pbOlrayt.Visible = False

            End If

        End If

    End Sub

    Private Sub btnGenBCReport_Click(sender As Object, e As EventArgs) Handles btnGenBCReport.Click
        Try
            frmGenReportBC.Show(Me)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnCLS_Click(sender As Object, e As EventArgs) Handles btnCLS.Click
        txtBCRefNo.Text = vbNullString

        If txtBCRefNo.Text = "" Then
            ddlDept.Enabled = True
            ddlClass.Enabled = True

            If ddlClassCode.Text = "PPE" Then
                ddlSubClass.Enabled = True
            Else
                ddlSubClass.Enabled = False
            End If

            txtDesc.Enabled = True
            ddlProcess.Enabled = True
            ddlUOM.Enabled = True
            ddlCurrency.Enabled = True
            mebUnitPrice.Enabled = True
        Else
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            txtDesc.Enabled = False
            ddlProcess.Enabled = False
            ddlUOM.Enabled = False
            ddlCurrency.Enabled = False
            mebUnitPrice.Enabled = True
        End If

    End Sub

    Private Sub ddlClass_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlClass.SelectedIndexChanged
        Try
            ddlClassCode.Text = ddlClass.SelectedValue

            If ddlClassCode.Text = "PPE" Then
                ddlSubClass.Enabled = True
                ddlSubClassCode.Enabled = True

            Else
                ddlSubClass.Enabled = False
                ddlSubClassCode.Enabled = False

                ddlSubClass.Text = ""
                ddlSubClassCode.Text = ""
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetTotalAmount()
        Try
            mebAmount.Value = mebQTY.Value * mebUnitPrice.Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub mebUnitPrice_ValueChanged(sender As Object, e As EventArgs) Handles mebUnitPrice.ValueChanged
        GetTotalAmount()
    End Sub

    Private Sub mebQTY_ValueChanged(sender As Object, e As EventArgs) Handles mebQTY.ValueChanged
        GetTotalAmount()
    End Sub

    Private Sub dtpMBudgeted_ValueChanged(sender As Object, e As EventArgs) Handles dtpMBudgeted.ValueChanged
        CheckDate()
        dtpSOU.Value = dtpMBudgeted.Value
    End Sub

    Private Sub btnYV_Click(sender As Object, e As EventArgs) Handles btnYV.Click
        Try
            bwLoadData.RunWorkerAsync()
            CheckDate()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtBCRefNo_TextChanged(sender As Object, e As EventArgs) Handles txtBCRefNo.TextChanged
        If txtBCRefNo.Text = "" Then
            ddlDept.Enabled = True
            ddlClass.Enabled = True
            txtDesc.Enabled = True
            ddlProcess.Enabled = True
            ddlUOM.Enabled = True
            ddlCurrency.Enabled = True
            mebUnitPrice.Enabled = True
        Else
            ddlDept.Enabled = False
            ddlClass.Enabled = False
            txtDesc.Enabled = False
            ddlProcess.Enabled = False
            ddlUOM.Enabled = False
            ddlCurrency.Enabled = False
            mebUnitPrice.Enabled = True
        End If
    End Sub

    Private Sub CheckDate()
        Try
            If lblUserlvl.Text = "SUPERADMIN" Or lblUserlvl.Text = "ADMINISTRATOR" Then
                If rgvList.CurrentRow.Cells("fldStatus").Value.ToString = "FINAL" Then

                    btnSaveBC.Enabled = True
                    btnDelete.Enabled = True
                    btnFinalize.Enabled = True

                Else

                    If dtpMBudgeted.Value.Year = Today.Year + 1 Then
                        btnSaveBC.Enabled = True
                        btnDelete.Enabled = True
                        btnFinalize.Enabled = True
                    Else
                        'btnSaveBC.Enabled = False
                        'btnDelete.Enabled = False
                        'btnFinalize.Enabled = False

                    End If

                End If

            Else

                If rgvList.CurrentRow.Cells("fldStatus").Value.ToString = "FINAL" Then

                    btnSaveBC.Enabled = False
                    btnDelete.Enabled = False
                    btnFinalize.Enabled = False

                Else

                    If dtpMBudgeted.Value.Year = Today.Year + 1 Then
                        btnSaveBC.Enabled = True
                        btnDelete.Enabled = True
                        btnFinalize.Enabled = True
                    Else
                        'btnSaveBC.Enabled = False
                        'btnDelete.Enabled = False
                        'btnFinalize.Enabled = False

                    End If

                End If
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ddlDept_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlDept.SelectedIndexChanged
        Try
            Dim drActivityCode As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblDepartment WHERE fldDeptCode = '" & ddlDept.Text & "'")
            txtActivityCode.Text = drActivityCode.Item("fldActivityCode").ToString

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ddlSubClass_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlSubClass.SelectedIndexChanged
        Try
            ddlSubClassCode.Text = ddlSubClass.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnMatrix_Click(sender As Object, e As EventArgs) Handles btnMatrix.Click
        Try
            frmMatrixExpense.Show(Me)
        Catch ex As Exception

        End Try
    End Sub
End Class