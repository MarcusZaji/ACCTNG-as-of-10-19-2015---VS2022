Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmViewRFQSuppliers
    Private Sub FrmViewRFQSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        dtpDueDate.Value = Today.Date
    End Sub

    Private Sub FrmViewRFQSuppliers_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchRFQData()
    End Sub

    Private Sub FetchRFQData()
        Zaji.addParameter("CreatedBy", globalVariables.EmpName)
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQPurchasingbyCreatedby")
        rgvList.DataSource = dtRFQRec
    End Sub

    Private Sub ReadyGrid()
        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldID"
            .Width = 500
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldID)

        Dim RFQNo As New GridViewTextBoxColumn("RFQ No")
        With RFQNo
            .FieldName = "fldRFQPurNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(RFQNo)

        Dim fldSuppName As New GridViewTextBoxColumn("Supplier Name")
        With fldSuppName
            .FieldName = "fldSuppName"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSuppName)

        Dim fldContact As New GridViewTextBoxColumn("Contact")
        With fldContact
            .FieldName = "fldContact"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldContact)

        Dim fldAddress As New GridViewTextBoxColumn("Address")
        With fldAddress
            .FieldName = "fldAddress"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldAddress)

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

        Dim fldCompanyName As New GridViewTextBoxColumn("Company Name")
        With fldCompanyName
            .FieldName = "fldCompanyName"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCompanyName)


        Dim fldSection As New GridViewTextBoxColumn("Section")
        With fldSection
            .FieldName = "fldSection"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldSection)

        Dim fldDept As New GridViewTextBoxColumn("Department")
        With fldDept
            .FieldName = "fldDept"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldDept)

        Dim fldPurStaff As New GridViewTextBoxColumn("Purchasing Staff")
        With fldPurStaff
            .FieldName = "fldPurStaff"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldPurStaff)

        Dim fldSup As New GridViewTextBoxColumn("Supplier")
        With fldSup
            .FieldName = "fldSup"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldSup)

        Dim fldDueDate As New GridViewDateTimeColumn("Date Date")
        With fldDueDate
            .FieldName = "fldDueDate"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDueDate)
        'rgvList.Columns("fldDueDate").FormatString = "{0:MMM dd, yyyy}"

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

        AddHandler rgvList.CommandCellClick, AddressOf CommandMe

    End Sub

    Private Sub CommandMe()
        If rgvList.CurrentColumn.HeaderText = "Edit RFQ" Then
            Try

            Catch ex As Exception

            End Try
        End If

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
        dtpDCreated.Value = ""
        txtCompanyName.Text = ""
        ddlDept.Text = ""
        ddlSection.Text = ""
        dtpDueDate.Value = DateTime.Now

        ddlClosed.Text = ""
        txtQuote.Text = ""
        txtID.Text = ""
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If RadMessageBox.Show("Are you sure want to update this data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            If txtID.Text Is Nothing Then
                RadMessageBox.Show("No item selected", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            If txtID.Text Is Nothing Then
                RadMessageBox.Show("No selected item", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("SuppName", Regex.Replace(Trim(txtSupName.Text), "\s+", " "))
            Zaji.addParameter("Contact", Regex.Replace(Trim(txtContact.Text), "\s+", " "))
            Zaji.addParameter("Address", Regex.Replace(Trim(txtAddress.Text), "\s+", " "))
            Zaji.addParameter("DateCreated", dtpDCreated.Value)
            Zaji.addParameter("CompanyName", txtCompanyName.Text)
            Zaji.addParameter("DueDate", dtpDueDate.Value)
            Zaji.addParameter("QuoteNo", txtQuote.Text)
            Zaji.addParameter("Closed", ddlClosed.Text)
            Zaji.dbAED("SP_UpdateRFQPurbyID")

            RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If

    End Sub
End Class
