Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports System.Data.SqlClient
Public Class FrmUpdateSubBudget
    Private Sub FrmUpdateSubBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.CustomFormat = "yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
        dtpDate.Value = Today
        txtSignature.Text = globalVariables.LoginSignature
    End Sub

    Private Sub FrmUpdateSubBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        SelectClass()
        SelectProcess()
        ddlClass.Text = globalVariables._Class
        ddlProcess.Text = globalVariables.Process
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
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
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
            If txtOrgAmountFix.Value <> mebAmount.Value Or txtJPYOrg.Value <> mebJPY.Value Then
                Dim NewJPY = (txtMajorAmount.Value - txtOrgAmountFix.Value) + mebJPY.Value

                Zaji.addParameter("MID", txtMID.Text)
                Zaji.addParameter("NewJPYAmount", NewJPY)
                Zaji.addParameter("OldJPYAmount", txtMajorAmount.Value)
                Zaji.addParameter("Remarks", "JPY amount has been updated! Sub budget JPY update from " + Convert.ToString(txtJPYOrg.Value) + " to " + Convert.ToString(mebJPY.Value))
                Zaji.dbAED("SP_InsertMajorBudHistory")
            End If

            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("BudRefNum", txtBRNum.Text)
            Zaji.addParameter("Dept", ddlDept.Text)
            Zaji.addParameter("Class", ddlClass.Text)
            Zaji.addParameter("_Desc", txtDesc.Text)
            Zaji.addParameter("_Process", ddlProcess.Text)
            Zaji.addParameter("QTY", mebQTY.Value)
            Zaji.addParameter("UOM", ddlUOM.Text)
            Zaji.addParameter("SOU", dtpSOU.Value)
            Zaji.addParameter("Currency", ddlCurrency.Text)
            Zaji.addParameter("Amount", mebAmount.Value)
            Zaji.addParameter("Yen", mebJPY.Value)
            Zaji.addParameter("MBudgeted", dtpMBudgeted.Value)
            Zaji.addParameter("Stat", ddlStat.Text)
            Zaji.addParameter("MajorRefNo", ddlMBudget.Text)
            Zaji.addParameter("Remarks", txtRemarks.Text)
            Zaji.addParameter("UpdatedBy", txtSignature.Text)

            If Zaji.dbAED("SP_UpdateSubBudget") Then
                RadMessageBox.Show("Successfully Updated", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
            Else
                    RadMessageBox.Show("Error problem please contact MIS", "Information", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End If
    End Sub
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
                mebJPY.Value = mebAmount.Value / myData.Rows(0).Item("fldAmount")

            ElseIf (ddlCurrency.Text = "USD") Then
                mebJPY.Value = mebAmount.Value * myData.Rows(0).Item("fldAmount")
            ElseIf (ddlCurrency.Text = "JPY") Then
                mebJPY.Value = mebAmount.Value
            Else
                mebJPY.Value = 0
            End If

            conn.Close()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub mebAmount_TextChanged(sender As Object, e As EventArgs) Handles mebAmount.ValueChanged
        CurrencyRate()
    End Sub

    Private Sub ddlCurrency_SelectedIndexChanged(sender As Object, e As UI.Data.PositionChangedEventArgs) Handles ddlCurrency.SelectedIndexChanged
        CurrencyRate()
    End Sub
End Class
