Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmRFQPur
    Private Sub FrmRFQPur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        ReadyGridItems()
        dtpDateNeeded.Value = Now()
    End Sub
    Private Sub ReadyGridItems()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "STATUS"
            fldStatColumn.Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            fldStatColumn.ReadOnly = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            rgvItems.Columns.Add(fldStatColumn)
        End With

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvItems.Columns.Add(fldID)

        Dim fldDesc As New GridViewTextBoxColumn("Descripion")
        With fldDesc
            .FieldName = "fldDesc"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItems.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewTextBoxColumn("QTY")
        With fldQTY
            .FieldName = "fldQTY"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItems.Columns.Add(fldQTY)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
            .ReadOnly = True
        End With
        rgvItems.Columns.Add(fldUOMColumn)

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks")
        With fldRemarks
            .FieldName = "fldRemarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItems.Columns.Add(fldRemarks)

        Dim fldDateNeeded As New GridViewDateTimeColumn("Date Needed")
        With fldDateNeeded
            .FieldName = "fldDateNeeded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItems.Columns.Add(fldDateNeeded)
        rgvItems.Columns("fldDateNeeded").FormatString = "{0:MMM dd, yyyy}"
    End Sub
    Private Sub ReadyGrid()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "STATUS"
            fldStatColumn.Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            fldStatColumn.ReadOnly = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            rgvSupplier.Columns.Add(fldStatColumn)
        End With

        Dim fldTypeExpense As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldTypeExpense
            .FieldName = "fldSuppName"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldTypeExpense)

        Dim fldName As New GridViewTextBoxColumn("COMPANY NAME")
        With fldName
            .FieldName = "fldName"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldName)

        Dim fldDesc As New GridViewTextBoxColumn("CONTACT NO")
        With fldDesc
            .FieldName = "fldContactNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewTextBoxColumn("ADDRESS")
        With fldQTY
            .FieldName = "fldAddress"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldQTY)

    End Sub
    Public Sub LoadDropDown()
        Dim CPerson As New GridViewTextBoxColumn("CONTACT PERSON")
        CPerson.FieldName = "ContactPerson"
        CPerson.Width = 200
        ddlContactPerson.MultiColumnComboBoxElement.Columns.Add(CPerson)

        Dim Name As New GridViewTextBoxColumn("COMPANY NAME")
        Name.FieldName = "CardName"
        Name.Width = 150
        ddlContactPerson.MultiColumnComboBoxElement.Columns.Add(Name)

        Dim Phone1 As New GridViewTextBoxColumn("CONTACT NO")
        Phone1.FieldName = "Phone1"
        Phone1.Width = 100
        ddlContactPerson.MultiColumnComboBoxElement.Columns.Add(Phone1)

        Dim Street As New GridViewTextBoxColumn("ADDRESS")
        Street.FieldName = "Street"
        Street.Width = 200
        ddlContactPerson.MultiColumnComboBoxElement.Columns.Add(Street)

        ddlContactPerson.AutoFilter = True
        ddlContactPerson.AutoCompleteMode = AutoCompleteMode.SuggestAppend

        'Comment due to SAP Problem
        GetSupplier()
        '-------------------------
        'Replace For SAP Table
        'GetSuppGridNew()
        '--------------------------

        Dim CName As New FilterDescriptor()
        CName.PropertyName = "CardName"
        CName.Operator = FilterOperator.Contains
        ddlContactPerson.EditorControl.MasterTemplate.FilterDescriptors.Add(CName)

        'ClearMe()
    End Sub
    Private Sub GetSuppGridNew()
        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectAllSuppliersSAPRename")
        ddlContactPerson.DataSource = DTSBud
        ddlContactPerson.ValueMember = "CardName"
        ddlContactPerson.DisplayMember = "CardName"
        ddlContactPerson.MultiColumnComboBoxElement.DropDownWidth = 450
    End Sub
    Public Sub LoadDropDownRFQ()
        Dim fldRFQPurNo As New GridViewTextBoxColumn("RFQ No")
        fldRFQPurNo.FieldName = "fldRFQPurNo"
        fldRFQPurNo.Width = 230
        ddlRFQNo.MultiColumnComboBoxElement.Columns.Add(fldRFQPurNo)

        Dim fldCreatedBy As New GridViewTextBoxColumn("Created By")
        fldCreatedBy.FieldName = "fldCreatedBy"
        fldCreatedBy.Width = 230
        ddlRFQNo.MultiColumnComboBoxElement.Columns.Add(fldCreatedBy)

        Dim DateCreated As New GridViewDateTimeColumn("Date Created")
        With DateCreated
            .FieldName = "fldDateCreated"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        ddlRFQNo.MultiColumnComboBoxElement.Columns.Add(DateCreated)
        ddlRFQNo.MultiColumnComboBoxElement.Columns("fldDateCreated").FormatString = "{0:MMM dd, yyyy}"

        ddlRFQNo.AutoFilter = True
        ddlRFQNo.AutoCompleteMode = AutoCompleteMode.SuggestAppend


        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQPurList")
        ddlRFQNo.DataSource = dtRFQRec

        Dim RFQNo As New FilterDescriptor()
        RFQNo.PropertyName = "fldRFQPurNo"
        RFQNo.Operator = FilterOperator.Contains
        ddlRFQNo.EditorControl.MasterTemplate.FilterDescriptors.Add(RFQNo)
        ddlRFQNo.Text = ""
    End Sub
    Private Sub ClearMe()
        ddlContactPerson.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtName.Text = ""
        txtContactPerson.Text = ""
    End Sub

    Private Sub FrmRFQPur_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        LoadDropDown()
        LoadDropDownRFQ()
        ClearMe()
    End Sub

    Private Sub ddlSupplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlContactPerson.SelectedIndexChanged, ddlRFQNo.SelectedIndexChanged
        Try
            Dim selectedRow As GridViewDataRowInfo = CType(ddlContactPerson.SelectedItem, GridViewDataRowInfo)
            txtAddress.Text = selectedRow.Cells("Street").Value.ToString()
            txtPhone.Text = selectedRow.Cells("Phone1").Value.ToString()
            txtName.Text = selectedRow.Cells("CardName").Value.ToString()
            txtContactPerson.Text = selectedRow.Cells("ContactPerson").Value.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrEmpty(ddlContactPerson.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please select supplier", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            rgvSupplier.Rows.Add("", txtContactPerson.Text, txtName.Text, txtPhone.Text, txtAddress.Text)
            ClearMe()
        End If

    End Sub

    Private Sub btnItems_Click(sender As Object, e As EventArgs) Handles btnItems.Click
        Try
            FrmRFQItems.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Zaji.addParameter("Trans", "FEAP")
        Zaji.addParameter("_Year", Today.Year)
        Zaji.addParameter("CreatedBy", globalVariables.EmpName)

        If Zaji.dbAED("SP_InsertRFQSequencev2") Then
            LoadDropDownRFQ()
            Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectLastCreatedRFQPur")

            If dtRFQRec.Rows.Count > 0 Then
                ddlRFQNo.Text = Convert.ToString(dtRFQRec.Rows(0).Item("RFQ"))
            End If
        End If
    End Sub

    Private Sub btnSaveMe_Click(sender As Object, e As EventArgs) Handles btnSaveMe.Click
        If ddlRFQNo.Text Is Nothing Then
            RadMessageBox.Show("Please Create RFQNo", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If
        If RadMessageBox.Show("Are you sure want to save the data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            If rgvItems.RowCount = 0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please select Items!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            ElseIf rgvSupplier.RowCount = 0 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please select Supplier!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Else
                DeleteRFQPurReqbyRFQNo()
                bwSaveRFQ.RunWorkerAsync()
            End If

        End If

    End Sub
    Public Sub DeleteRFQPurReqbyRFQNo()
        Zaji.addParameter("RFQPurNo", ddlRFQNo.Text)
        Zaji.dbAED("SP_DeleteRFQPurReqbyRFQNo")
    End Sub
    Private lineNo As Integer
    Private lineNo2 As Integer
    Private lineStat As String
    Private lineStat2 As String
    Private Sub bwSaveRFQ_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwSaveRFQ.DoWork
        Dim delay As Integer = 80

        For x As Integer = 0 To rgvSupplier.Rows.Count - 1

            Zaji.addParameter("RFQPurNo", ddlRFQNo.Text)
            Zaji.addParameter("SuppName", rgvSupplier.Rows(x).Cells("fldSuppName").Value)
            Zaji.addParameter("Contact", rgvSupplier.Rows(x).Cells("fldContactNo").Value)
            Zaji.addParameter("Address", rgvSupplier.Rows(x).Cells("fldAddress").Value)
            Zaji.addParameter("CompanyName", rgvSupplier.Rows(x).Cells("fldName").Value)
            Zaji.addParameter("Section", txtSection.Text)
            Zaji.addParameter("Dept", txtDept.Text)
            Zaji.addParameter("DueDate", dtpDateNeeded.Value)

            If Zaji.dbAED("SP_InsertRFQPurv3") Then
                lineStat = "OK"
            Else
                lineStat = "NG"
            End If

            Dim percent As Double = x / rgvSupplier.Rows.Count * 100

            lineNo = x
            RadProgressBar1.Text = "Saving..."
            Threading.Thread.Sleep(delay)
            bwSaveRFQ.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub

    Private Sub bwSaveRFQ_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwSaveRFQ.ProgressChanged
        rgvSupplier.CurrentRow = rgvSupplier.Rows(lineNo)
        rgvSupplier.CurrentRow.Cells(0).Value = lineStat
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwSaveRFQ_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwSaveRFQ.RunWorkerCompleted
        RadProgressBar1.Value1 = 100
        RadProgressBar1.Text = "Done"
        bwRFQItems.RunWorkerAsync()
    End Sub

    Private Sub bwRFQItems_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwRFQItems.DoWork
        Dim delay As Integer = 80

        For x As Integer = 0 To rgvItems.Rows.Count - 1
            Zaji.addParameter("_RFQPurNo", ddlRFQNo.Text)
            Zaji.addParameter("_Desc", Regex.Replace(Trim(rgvItems.Rows(x).Cells("fldDesc").Value), "\s+", " "))
            Zaji.addParameter("QTY", rgvItems.Rows(x).Cells("fldQTY").Value)
            Zaji.addParameter("UOM", rgvItems.Rows(x).Cells("fldUOM").Value)
            Zaji.addParameter("Remarks", Regex.Replace(Trim(rgvItems.Rows(x).Cells("fldRemarks").Value), "\s+", " "))
            Zaji.addParameter("RFQID", rgvItems.Rows(x).Cells("fldID").Value)
            Zaji.addParameter("DateNeeded", rgvItems.Rows(x).Cells("fldDateNeeded").Value)
            ' rgvItems.CurrentRow.Cells("fldRFQPurNo").Value.ToString()

            If Zaji.dbAED("SP_InsertRFQPurChildv2") Then
                lineStat2 = "OK"

                Zaji.addParameter("ID", rgvItems.Rows(x).Cells("fldID").Value)
                Zaji.addParameter("_Status", "RFQ Created By " + globalVariables.EmpName)
                Zaji.addParameter("RFQBy", globalVariables.EmpName)
                Zaji.dbAED("SP_UpdateRFQChildByPruchasing")
            Else
                lineStat2 = "NG"
            End If

            Dim percent As Double = x / rgvItems.Rows.Count * 100

            lineNo2 = x
            RadProgressBar1.Text = "Saving..."
            Threading.Thread.Sleep(delay)
            bwRFQItems.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub

    Private Sub bwRFQItems_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwRFQItems.ProgressChanged
        rgvItems.CurrentRow = rgvItems.Rows(lineNo2)
        rgvItems.CurrentRow.Cells(0).Value = lineStat2
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwRFQItems_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwRFQItems.RunWorkerCompleted
        RadProgressBar1.Value1 = 100
        RadProgressBar1.Text = "Done"
        RadMessageBox.Show("Successfully Saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If ddlRFQNo.Text Is Nothing Then
            RadMessageBox.Show("Please Select RFQNo", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Exit Sub
        End If

        Zaji.addParameter("RFQPurNo", ddlRFQNo.Text)
        Dim dtRFQPur As DataTable = Zaji.dbSelect("SP_SelectRFQPurbyRFQNo")

        If dtRFQPur.Rows.Count > 0 Then
            txtDept.Text = Convert.ToString(dtRFQPur.Rows(0).Item("fldDept"))
            txtSection.Text = Convert.ToString(dtRFQPur.Rows(0).Item("fldSection"))
        End If

        Zaji.addParameter("RFQPurNo", ddlRFQNo.Text)
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQPurbyRFQNo")
        rgvSupplier.DataSource = dtRFQRec

        Zaji.addParameter("RFQPurNo", ddlRFQNo.Text)
        Dim dtRFQRecChild As DataTable = Zaji.dbSelect("SP_SelectRFQPurChildbyRFQNo")
        rgvItems.DataSource = dtRFQRecChild
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            reporttype = 1
            globalVariables.RFQNo = ddlRFQNo.Text
            FrmReportServer.Show()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

End Class
