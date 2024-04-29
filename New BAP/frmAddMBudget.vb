Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Public Class FrmAddMBudget
    Private Sub FrmAddMBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = Today()
        dtpDate.CustomFormat = "yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True

    End Sub
    Private Sub FrmAddMBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dept()
        If txtID.Text <> "" Then
            GetValue()
        End If

    End Sub
    Public Sub GetValue()
        txtBRNum.Text = globalVariables.BudRefNo
        txtDesc.Text = globalVariables.Desc
        ddlDept.Text = globalVariables.Dpt
        dtpDate.Text = globalVariables.Year
        mebJPY.Value = globalVariables.JPY
    End Sub
    Public Sub Dept()
        Dim dtBuRefNo As DataTable = Zaji.dbSelect("SP_SelectAllDepartment")
        ddlDept.DataSource = dtBuRefNo
        ddlDept.DisplayMember = "fldDeptCode"
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Zaji.addParameter("MajorRefNo", Regex.Replace(txtBRNum.Text, "\s+", " "))
        Dim RecordCheck As DataTable = Zaji.dbSelect("SP_SelectIfExistMajor")

        Dim CheckMe = RecordCheck.Rows(0).Item("CheckMe").ToString()

        'If CheckMe >= "1" Then
        '    RadMessageBox.Show("This Major Budget Already Exist", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        '    Exit Sub
        'End If

        If txtBRNum.Text = "" Then
            RadMessageBox.Show("Please insert Major Budget Ref No", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If txtDesc.Text = "" Then
            RadMessageBox.Show("Please insert Description", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If ddlDept.SelectedValue Is Nothing Then
            RadMessageBox.Show("Please select Department", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Zaji.addParameter("MajorRefNo", Regex.Replace(txtBRNum.Text, "\s+", " "))
        Zaji.addParameter("_Desc", Regex.Replace(txtDesc.Text, "\s+", " "))
        Zaji.addParameter("Dept", Regex.Replace(ddlDept.Text, "\s+", " "))
        Zaji.addParameter("_Year", dtpDate.Value)
        Zaji.addParameter("JpyAmount", mebJPY.Value)
        Zaji.addParameter("Project", ddlProject.Text)

        If Zaji.dbAED("SP_InsertMajorBudgetv2") Then
            FrmMajorBudget.Shown()
            RadMessageBox.Show("Successfully added", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub

End Class

