Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class FrmInvestment
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private Sub FrmInvestment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim MyYear As String = Date.Today.Year
        txtYear.Text = MyYear
        ReadyGrid()
        dtpDate.Value = Date.Today
        dtpDepreciation.Value = Date.Today
        dtpInstallationDate.Value = Date.Today
        dtpCompletion.Value = Date.Today

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point(0, 2)

    End Sub

    Private Sub FrmInvestment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        bwLoadData.RunWorkerAsync()
        DepartmentUserInv()
        GetControlNo()
        GetUser()
        GeTBudgetRef()
    End Sub
    Private Sub GeTBudgetRef()
        Try
            'dtLoadData2 = Chinita.fetchDBTable("select * from tblRevision WHERE fldBudRefNum like '%2020%' AND fldStat = 'OPEN' ;")
            dtLoadData2 = Chinita.fetchDBTable("select * from tblMajorBudget WHERE year(fldYear) like '%2021%';")
            ddlBRNum.DataSource = dtLoadData2
            ddlBRNum.DisplayMember = "fldMajorRefNo"
            ddlBRNum.MultiColumnComboBoxElement.DropDownWidth = 630
            ddlBRNum.MultiColumnComboBoxElement.DropDownHeight = 200
            ddlBRNum.Text = ""
            txtApprovedBud.Text = 0
            ddlBRNum.EditorControl.AllowSearchRow = False
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Empty Department", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtInvestment.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Investment Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlInvestmentType.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Investment Type", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlMachine.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Existing Machine", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtOrgAmount.Text = "0.00" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Project Estimated Cost (OA) Zero amount not valid", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtJPY.Text = "0.00" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Project Estimated Cost (JPY) Zero amount not valid", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            If Tomboy.AddInvesment(txtYear.Text, ddlDept.Text, dtpDate.Value, txtInvestment.Text, txtProjTitle.Text, txtProjDesc.Text, ddlCurrency.Text, _
                                       txtCivilWorks.Text, txtMechanicalWork.Text, txtElectricalWorks.Text, txtOthers.Text, txtOrgAmount.Value, _
                                       txtJPY.Value, txtApprovedBud.Value, dtpInstallationDate.Value, dtpCompletion.Value, txtSignature.Text, ddlBRNum.Text, _
                                       ddlInvestmentType.Text, ddlMachine.Text, dtpDepreciation.Text, ddlStat.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Investment Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                'Clear()
                bwLoadData.RunWorkerAsync()
                GetControlNo()
            End If

        End If
    End Sub
    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        imBusy = True

        Try
            dtLoadData = Chinita.fetchDBTable("call SP_SelectAllInvestment()")

            For counter As Integer = 0 To dtLoadData.Rows.Count - 1

                Dim x As Double = counter / dtLoadData.Rows.Count * 100
                bwLoadData.ReportProgress(x)
                Threading.Thread.Sleep(Delay)

            Next


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyGrid()
        '-----------------'
        '--MASTER BUDGET--'
        '-----------------'

        Dim IID As New GridViewTextBoxColumn("ID")
        With IID
            .FieldName = "fldIID"
            .ReadOnly = False
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 140
        End With
        rgvInvestment.Columns.Add(IID)

        Dim BudRefNumColumn As New GridViewTextBoxColumn("YEAR")
        With BudRefNumColumn
            .FieldName = "fldYear"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 140
        End With
        rgvInvestment.Columns.Add(BudRefNumColumn)

        Dim Dept As New GridViewTextBoxColumn("DEPARTMENT")
        With Dept
            .FieldName = "fldDept"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(Dept)

        Dim fldDate As New GridViewDateTimeColumn("DATE")
        With fldDate
            .FieldName = "fldDate"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvInvestment.Columns.Add(fldDate)
        rgvInvestment.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldInvestmentNo As New GridViewTextBoxColumn("INVESTMENT NO")
        With fldInvestmentNo
            .FieldName = "fldInvestmentNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldInvestmentNo)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("BUDGET REFERENCE NO.")
        With fldBudRefColumn
            .FieldName = "fldBudRefNum"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvInvestment.Columns.Add(fldBudRefColumn)


        Dim fldProjTitle As New GridViewTextBoxColumn("PROJECT TITLE")
        With fldProjTitle
            .FieldName = "fldProjTitle"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldProjTitle)

        Dim fldInvestmentType As New GridViewTextBoxColumn("INVESTMENT TYPE")
        With fldInvestmentType
            .FieldName = "fldInvestmentType"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldInvestmentType)

        Dim fldExistingMachine As New GridViewTextBoxColumn("EXISTING MACHINE")
        With fldExistingMachine
            .FieldName = "fldExistingMachine"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldExistingMachine)

        Dim fldDetails As New GridViewTextBoxColumn("DETAILS")
        With fldDetails
            .FieldName = "fldDetails"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldDetails)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrency
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldCurrency)

        Dim fldCivilWorks As New GridViewTextBoxColumn("CIVIL WORKS")
        With fldCivilWorks
            .FieldName = "fldCivilWorks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldCivilWorks)

        Dim fldMechanicalWork As New GridViewTextBoxColumn("MECHANICAL WORK")
        With fldMechanicalWork
            .FieldName = "fldMechanicalWork"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldMechanicalWork)

        Dim fldElecWorks As New GridViewTextBoxColumn("ELECTRICAL WORK")
        With fldElecWorks
            .FieldName = "fldElecWorks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldElecWorks)

        Dim fldOthers As New GridViewTextBoxColumn("OTHERS")
        With fldOthers
            .FieldName = "fldOthers"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldOthers)

        Dim fldProdCostOrg As New GridViewTextBoxColumn("Project Estimated Cost (Original Amount)")
        With fldProdCostOrg
            .FieldName = "fldProdCostOrg"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvInvestment.Columns.Add(fldProdCostOrg)
        rgvInvestment.Columns("fldProdCostOrg").FormatString = "{0:N2}"

        Dim fldProdCostJPY As New GridViewTextBoxColumn("Project Estimated Cost (JPY Amount )")
        With fldProdCostJPY
            .FieldName = "fldProdCostJPY"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvInvestment.Columns.Add(fldProdCostJPY)
        rgvInvestment.Columns("fldProdCostJPY").FormatString = "{0:N2}"

        Dim fldApprovedBudget As New GridViewTextBoxColumn("Approved Budget")
        With fldApprovedBudget
            .FieldName = "fldApprovedBudget"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
        End With
        rgvInvestment.Columns.Add(fldApprovedBudget)
        rgvInvestment.Columns("fldApprovedBudget").FormatString = "{0:N2}"

        Dim fldDateInstallation As New GridViewDateTimeColumn("DATE INSTALLATION")
        With fldDateInstallation
            .FieldName = "fldDateInstallation"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvInvestment.Columns.Add(fldDateInstallation)
        rgvInvestment.Columns("fldDateInstallation").FormatString = "{0:MMM dd, yyyy}"

        Dim fldDateCompletion As New GridViewDateTimeColumn("DATE COMPLETION")
        With fldDateCompletion
            .FieldName = "fldDateCompletion"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvInvestment.Columns.Add(fldDateCompletion)
        rgvInvestment.Columns("fldDateCompletion").FormatString = "{0:MMM dd, yyyy}"

        Dim fldPreparedBy As New GridViewTextBoxColumn("PREPARED BY")
        With fldPreparedBy
            .FieldName = "fldPreparedBy"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldPreparedBy)

        Dim fldDepreciation As New GridViewDateTimeColumn("DATE DEPRECIATION")
        With fldDepreciation
            .FieldName = "fldDepreciation"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvInvestment.Columns.Add(fldDepreciation)
        rgvInvestment.Columns("fldDepreciation").FormatString = "{0:MMM dd, yyyy}"

        Dim fldStat As New GridViewTextBoxColumn("STATUS")
        With fldStat
            .FieldName = "fldStat"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldStat)

        Dim CancelMe As New GridViewCommandColumn("Cancel")
        With CancelMe
            .FieldName = "Cancel"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "Cancel"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvInvestment.Columns.Add(CancelMe)

        Dim fldStatus As New GridViewTextBoxColumn("STATUS")
        With fldStatus
            .FieldName = "fldStatus"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 160
        End With
        rgvInvestment.Columns.Add(fldStatus)

        AddHandler rgvInvestment.CommandCellClick, AddressOf CancelInv
    End Sub
    Public Sub CancelInv()
        If rgvInvestment.SelectedRows.Count > 0 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to cancel this Investment?",
                                  "Remove Order", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If Tomboy.CancelInvestment(rgvInvestment.CurrentRow.Cells("fldIID").Value.ToString) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Investment has been Cancelled!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                    bwLoadData.RunWorkerAsync()
                End If

            End If
        End If

        Try
        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        pbOlrayt.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOlrayt.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        Try
            rgvInvestment.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOlrayt.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try
    End Sub
    Private Sub GetControlNo()
        Try
            'Dim MyYear As String = Date.Today.Year
            'Dim MyMonth As String = Date.Today.Month.ToString().PadLeft(2, "0")
            Dim MyYear As String = dtpDate.Value.Year
            Dim MyMonth As String = dtpDate.Value.Month.ToString().PadLeft(2, "0")
            Dim CNo As String
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
            Dim myCmd As New MySqlCommand
            Dim myData As New DataTable
            Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter

            myCmd.Connection = conn
            myCmd.CommandText = " select cast(fldNo as Char(5)) as fldNo from tblControlNo where fldCategory = 'INVESTMENT'"

            myAdapter.SelectCommand = myCmd
            myAdapter.Fill(myData)

            CNo = myData.Rows(0).Item("fldNo")
            txtInvestment.Text = String.Concat(MyYear.Substring(MyYear.Length - 2), MyMonth, "-", CNo)

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Control No Problem" & Environment.NewLine & _
                                    "Please Contact Mark @ Local 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try
    End Sub

    Private Sub txtCivilWorks_TextChanged(sender As Object, e As EventArgs) Handles txtCivilWorks.TextChanged
        SumMe()
    End Sub
    Private Sub SumMe()
        Try
            txtOrgAmount.Text = Convert.ToString(Convert.ToDecimal(txtCivilWorks.Value) + Convert.ToDecimal(txtMechanicalWork.Value) + Convert.ToDecimal(txtElectricalWorks.Value) + Convert.ToDecimal(txtOthers.Value))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtMechanicalWork_TextChanged(sender As Object, e As EventArgs) Handles txtMechanicalWork.TextChanged
        SumMe()
    End Sub

    Private Sub txtElectricalWorks_TextChanged(sender As Object, e As EventArgs) Handles txtElectricalWorks.TextChanged
        SumMe()
    End Sub

    Private Sub txtOthers_TextChanged(sender As Object, e As EventArgs) Handles txtOthers.TextChanged
        SumMe()
    End Sub

    Private Sub ddlBRNum_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlBRNum.SelectedIndexChanged
        Try
            txtApprovedBud.Text = ddlBRNum.EditorControl.CurrentRow.Cells("BUDGET AMOUNT").Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        GetControlNo()
    End Sub

    Private Sub rgvInvestment_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvInvestment.CellDoubleClick
        Try
            txtIID.Text = rgvInvestment.CurrentRow.Cells("fldIID").Value.ToString
            txtYear.Text = rgvInvestment.CurrentRow.Cells("fldYear").Value.ToString
            ddlDept.Text = rgvInvestment.CurrentRow.Cells("fldDept").Value.ToString
            dtpDate.Text = rgvInvestment.CurrentRow.Cells("fldDate").Value.ToString
            txtInvestment.Text = rgvInvestment.CurrentRow.Cells("fldInvestmentNo").Value.ToString
            txtProjTitle.Text = rgvInvestment.CurrentRow.Cells("fldProjTitle").Value.ToString
            txtProjDesc.Text = rgvInvestment.CurrentRow.Cells("fldDetails").Value.ToString
            ddlInvestmentType.Text = rgvInvestment.CurrentRow.Cells("fldInvestmentType").Value.ToString
            ddlMachine.Text = rgvInvestment.CurrentRow.Cells("fldExistingMachine").Value.ToString
            ddlCurrency.Text = rgvInvestment.CurrentRow.Cells("fldCurrency").Value.ToString
            txtCivilWorks.Text = rgvInvestment.CurrentRow.Cells("fldCivilWorks").Value.ToString
            txtMechanicalWork.Text = rgvInvestment.CurrentRow.Cells("fldMechanicalWork").Value.ToString
            txtElectricalWorks.Text = rgvInvestment.CurrentRow.Cells("fldElecWorks").Value.ToString
            txtOthers.Text = rgvInvestment.CurrentRow.Cells("fldOthers").Value.ToString
            txtOrgAmount.Text = rgvInvestment.CurrentRow.Cells("fldProdCostOrg").Value.ToString
            txtJPY.Text = rgvInvestment.CurrentRow.Cells("fldProdCostJPY").Value.ToString
            ddlBRNum.Text = rgvInvestment.CurrentRow.Cells("fldBudRefNum").Value.ToString
            txtApprovedBud.Text = rgvInvestment.CurrentRow.Cells("fldApprovedBudget").Value.ToString
            dtpInstallationDate.Text = rgvInvestment.CurrentRow.Cells("fldDateInstallation").Value.ToString
            dtpCompletion.Text = rgvInvestment.CurrentRow.Cells("fldDateCompletion").Value.ToString
            dtpDepreciation.Text = rgvInvestment.CurrentRow.Cells("fldDepreciation").Value.ToString
            ddlStat.Text = rgvInvestment.CurrentRow.Cells("fldStatus").Value.ToString
            btnUpdate.Visible = True
            btnSave.Visible = False
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Control No Problem" & Environment.NewLine & _
                                    "Please Contact Mark @ Local 606", "System Error", MessageBoxButtons.OK, RadMessageIcon.Error)
            Me.Close()
        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(ddlDept.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Empty Department", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtInvestment.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Investment Number", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlInvestmentType.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Investment Type", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(ddlMachine.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("No Existing Machine", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtOrgAmount.Text = "0.00" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Project Estimated Cost (OA) Zero amount not valid", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf txtJPY.Text = "0.00" Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Project Estimated Cost (JPY) Zero amount not valid", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            If Tomboy.UpdateInvesment(txtIID.Text, txtYear.Text, ddlDept.Text, dtpDate.Value, txtProjTitle.Text, txtProjDesc.Text, ddlCurrency.Text, _
                                       txtCivilWorks.Text, txtMechanicalWork.Text, txtElectricalWorks.Text, txtOthers.Text, txtOrgAmount.Value, _
                                       txtJPY.Value, txtApprovedBud.Value, dtpInstallationDate.Value, dtpCompletion.Value, txtSignature.Text, ddlBRNum.Text, _
                                       ddlInvestmentType.Text, ddlMachine.Text, dtpDepreciation.Text, ddlStat.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Investment successfully updated!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                'Clear()
                bwLoadData.RunWorkerAsync()
                GetControlNo()

                btnUpdate.Visible = False
                btnSave.Visible = True
                ClearMe()
            End If

        End If
    End Sub
    Public Sub ClearMe()
        ddlDept.Text = ""
        txtInvestment.Text = ""
        txtProjTitle.Text = ""
        txtProjDesc.Text = ""
        ddlInvestmentType.Text = ""
        ddlMachine.Text = ""
        ddlCurrency.Text = ""
        txtCivilWorks.Text = "0.00"
        txtMechanicalWork.Text = "0.00"
        txtElectricalWorks.Text = "0.00"
        txtOthers.Text = "0.00"
        txtOrgAmount.Text = "0.00"
        txtJPY.Text = "0.00"
        ddlBRNum.Text = ""
        txtApprovedBud.Text = "0.00"

    End Sub
End Class
