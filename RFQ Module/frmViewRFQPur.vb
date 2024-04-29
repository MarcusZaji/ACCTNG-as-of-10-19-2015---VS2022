Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmViewRFQPur
    Private Sub FrmViewRFQPur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        ReadyGridItems()
        dtpDueDate.Value = Now
        dtpDateReceived.Value = Now
    End Sub

    Private Sub FrmViewRFQPur_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ViewRFQDesc()
    End Sub

    Public Sub ViewRFQDesc()

        Zaji.addParameter("CreatedBy", globalVariables.EmpName)
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQPurchasingbyCreatedby")
        'Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectAllRFQNoPur")
        rgvList.DataSource = dtRFQRec
    End Sub
    Public Sub ViewRFQItems()
        Try

            Zaji.addParameter("RFQPurNo", rgvList.CurrentRow.Cells("fldRFQPurNo").Value.ToString())
            Dim dtRFQRecChild As DataTable = Zaji.dbSelect("SP_SelectRFQPurChildbyRFQNo")
            rgvItems.DataSource = dtRFQRecChild
        Catch ex As Exception

        End Try

    End Sub
    Private Sub ReadyGrid()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldID"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldID)

        Dim fldRFQPurNo As New GridViewTextBoxColumn("RFQ PUR. NO")
        With fldRFQPurNo

            .FieldName = "fldRFQPurNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldRFQPurNo)

        Dim fldSuppName As New GridViewTextBoxColumn("CONTACT PERSON")
        With fldSuppName
            .FieldName = "fldSuppName"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSuppName)

        Dim fldDesc As New GridViewTextBoxColumn("CONTACT NO")
        With fldDesc
            .FieldName = "fldContact"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewTextBoxColumn("ADDRESS")
        With fldQTY
            .FieldName = "fldAddress"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldQTY)


        Dim fldDateCreated As New GridViewDateTimeColumn("Date Created")
        With fldDateCreated
            .FieldName = "fldDateCreated"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDateCreated)
        rgvList.Columns("fldDateCreated").FormatString = "{0:MMM dd, yyyy}"

        Dim fldCompanyName As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldCompanyName
            .FieldName = "fldCompanyName"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCompanyName)

        Dim fldSection As New GridViewTextBoxColumn("SECTION")
        With fldSection
            .FieldName = "fldSection"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSection)

        Dim fldDept As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDept
            .FieldName = "fldDept"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDept)

        Dim fldDueDate As New GridViewDateTimeColumn("DUE DATE")
        With fldDueDate
            .FieldName = "fldDueDate"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDueDate)
        rgvList.Columns("fldDueDate").FormatString = "{0:MMM dd, yyyy}"

        Dim NewStat As New GridViewTextBoxColumn("Status")
        With NewStat
            .FieldName = "NewStat"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(NewStat)

        Dim fldQuoteNo As New GridViewTextBoxColumn("Quotation No.")
        With fldQuoteNo
            .FieldName = "fldQuoteNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldQuoteNo)

        Dim fldCancel As New GridViewTextBoxColumn("Cancel")
        With fldCancel
            .FieldName = "fldCancel"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCancel)


        Dim fldReasonCancel As New GridViewTextBoxColumn("Reason Cancel")
        With fldReasonCancel
            .FieldName = "fldReasonCancel"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldReasonCancel)

    End Sub
    Private Sub ReadyGridItems()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvItems.Columns.Add(fldID)

        Dim fldRFQPurNo As New GridViewTextBoxColumn("RFQ PUR. NO")
        With fldRFQPurNo
            .FieldName = "fldRFQPurNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvItems.Columns.Add(fldRFQPurNo)

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

        Dim fldUOMColumn As New GridViewTextBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
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
    End Sub

    Private Sub rgvList_Click(sender As Object, e As EventArgs) Handles rgvList.Click
        ViewRFQItems()
    End Sub

    Private Sub rgvList_SelectionChanged(sender As Object, e As EventArgs) Handles rgvList.SelectionChanged
        ViewRFQItems()

    End Sub

    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick
        Try
            txtRFQNo.Text = rgvList.CurrentRow.Cells("fldRFQPurNo").Value.ToString
            txtSupName.Text = rgvList.CurrentRow.Cells("fldSuppName").Value.ToString
            txtContact.Text = rgvList.CurrentRow.Cells("fldContact").Value.ToString
            txtAddress.Text = rgvList.CurrentRow.Cells("fldAddress").Value.ToString
            dtpDCreated.Value = rgvList.CurrentRow.Cells("fldDateCreated").Value
            txtCompanyName.Text = rgvList.CurrentRow.Cells("fldCompanyName").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString
            ddlSection.Text = rgvList.CurrentRow.Cells("fldSection").Value.ToString



            If IsDBNull(rgvList.CurrentRow.Cells("fldDueDate").Value) = False Then
                dtpDueDate.Value = rgvList.CurrentRow.Cells("fldDueDate").Value
            End If

            txtQuote.Text = rgvList.CurrentRow.Cells("fldQuoteNo").Value.ToString()
            txtID.Text = rgvList.CurrentRow.Cells("fldID").Value.ToString()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Error problem encountered", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Info)
            ClearMe()
        End Try
    End Sub
    Private Sub ClearMe()
        txtRFQNo.Text = ""
        txtSupName.Text = ""
        txtContact.Text = ""
        txtAddress.Text = ""
        dtpDCreated.Value = Date.Now
        txtCompanyName.Text = ""
        ddlDept.Text = ""
        ddlSection.Text = ""
        dtpDueDate.Value = DateTime.Now

        txtQuote.Text = ""
        txtID.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If RadMessageBox.Show("Are you sure want to update this data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            If txtID.Text Is Nothing Then
                RadMessageBox.Show("No item selected", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If

            If CBNA.Checked Then
                Zaji.addParameter("ID", txtID.Text)
                Zaji.addParameter("SuppName", Regex.Replace(Trim(txtSupName.Text), "\s+", " "))
                Zaji.addParameter("Contact", Regex.Replace(Trim(txtContact.Text), "\s+", " "))
                Zaji.addParameter("Address", Regex.Replace(Trim(txtAddress.Text), "\s+", " "))
                Zaji.addParameter("DateCreated", dtpDCreated.Value)
                Zaji.addParameter("CompanyName", txtCompanyName.Text)
                Zaji.addParameter("DueDate", dtpDueDate.Value)
                Zaji.addParameter("QuoteNo", txtQuote.Text)
                Zaji.dbAED("SP_UpdateRFQPurbyID")

                RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
            Else
                Zaji.addParameter("ID", txtID.Text)
                Zaji.addParameter("SuppName", Regex.Replace(Trim(txtSupName.Text), "\s+", " "))
                Zaji.addParameter("Contact", Regex.Replace(Trim(txtContact.Text), "\s+", " "))
                Zaji.addParameter("Address", Regex.Replace(Trim(txtAddress.Text), "\s+", " "))
                Zaji.addParameter("DateCreated", dtpDCreated.Value)
                Zaji.addParameter("CompanyName", txtCompanyName.Text)
                Zaji.addParameter("DueDate", dtpDueDate.Value)
                Zaji.addParameter("QuoteNo", txtQuote.Text)
                Zaji.addParameter("DateReceived", dtpDateReceived.Value)
                Zaji.dbAED("SP_UpdateRFQPurbyIDwithDate")

                RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If

        End If
    End Sub


    Private Sub rgvItems_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvItems.CellDoubleClick
        If Zaji.IsFormOpen(FrmUpdateRFQChild) Then
            FrmUpdateRFQChild.Focus()
        Else
            FrmUpdateRFQChild.txtID.Text = rgvItems.CurrentRow.Cells("fldID").Value.ToString
            FrmUpdateRFQChild.txtDesc.Text = rgvItems.CurrentRow.Cells("fldDesc").Value.ToString
            FrmUpdateRFQChild.mebQTY.Value = rgvItems.CurrentRow.Cells("fldQTY").Value.ToString
            FrmUpdateRFQChild.ddlUOM.Text = rgvItems.CurrentRow.Cells("fldUOM").Value.ToString
            FrmUpdateRFQChild.txtRemarks.Text = rgvItems.CurrentRow.Cells("fldRemarks").Value.ToString
            FrmUpdateRFQChild.Show()
        End If
    End Sub

    Private Sub cbReport_Click(sender As Object, e As EventArgs) Handles cbReport.Click
        Try
            reporttype = 28
            FrmReportServer.Show()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub cbPrintRFQ_Click(sender As Object, e As EventArgs) Handles cbPrintRFQ.Click
        Try
            reporttype = 1
            globalVariables.RFQNo = rgvList.CurrentRow.Cells("fldRFQPurNo").Value.ToString
            FrmReportServer.Show()
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        globalVariables.RFQNo = rgvList.CurrentRow.Cells("fldRFQPurNo").Value.ToString
        globalVariables.RFQID = rgvList.CurrentRow.Cells("fldID").Value.ToString
        FrmCancelRFQ.ShowDialog()
    End Sub

    Private Sub CBNA_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles CBNA.ToggleStateChanged
        If CBNA.Checked = True Then
            dtpDateReceived.Enabled = False
        Else
            dtpDateReceived.Enabled = True
        End If
    End Sub
End Class
