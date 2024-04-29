Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmInactiveSupp
    Private dtLoadData As DataTable
    Private dtInacSup As DataTable
    Private Sub FrmInactiveSupp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GridView()
    End Sub

    Private Sub FrmInactiveSupp_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GetSuppGrid()
        ClearField()
        FetchinactiveData()
    End Sub
    Private Sub FetchinactiveData()
        dtInacSup = Zaji.dbSelect("SP_SelectAllInactiveSupp")
        rgvItemSelect.DataSource = dtInacSup
    End Sub

    Private Sub GetSuppGrid()
        Dim myData As New DataTable
        Dim myCmd As New SqlClient.SqlCommand
        Dim myAdapter As New SqlClient.SqlDataAdapter

        Dim conn As New SqlClient.SqlConnection(Sapsap)

        conn.Open()
        myCmd.Connection = conn
        myCmd.CommandText = "SELECT T0.[CardName], T0.CardCode,T0.Currency " _
            & "FROM OCRD T0 WHERE T0.[CardType] ='S' " _
            & "ORDER BY T0.[CardName] ASC"

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        rgvSupplier.Columns.Clear()

        ReadySupplierGrid()
        rgvSupplier.DataSource = myData

    End Sub

    Private Sub GridView()
        Dim fldIID As New GridViewTextBoxColumn("ID")
        With fldIID
            .FieldName = "fldIID"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvItemSelect.Columns.Add(fldIID)

        Dim fldSuppName As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldSuppName
            .FieldName = "fldSuppName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 500
        End With
        rgvItemSelect.Columns.Add(fldSuppName)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("VENDOR CODE")
        With fldBudRefColumn
            .FieldName = "fldVendorCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvItemSelect.Columns.Add(fldBudRefColumn)


        Dim fldRemarks As New GridViewTextBoxColumn("INACTIVE REASON")
        With fldRemarks
            .FieldName = "fldRemarks"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 300
            .AllowResize = False
        End With
        rgvItemSelect.Columns.Add(fldRemarks)

        Dim fldApprovedBy As New GridViewTextBoxColumn("APPROVED BY")
        With fldApprovedBy
            .FieldName = "fldApprovedBy"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 200
            .AllowResize = False
        End With
        rgvItemSelect.Columns.Add(fldApprovedBy)

        Dim fldStatus As New GridViewTextBoxColumn("STATUS")
        With fldStatus
            .FieldName = "fldStatus"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            .AllowResize = False
        End With
        rgvItemSelect.Columns.Add(fldStatus)

        Dim fldDateCreated As New GridViewDateTimeColumn("APPROVAL DATE")
        With fldDateCreated
            .FieldName = "fldApprovalDate"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItemSelect.Columns.Add(fldDateCreated)
        rgvItemSelect.Columns("fldApprovalDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldInactiveDate As New GridViewDateTimeColumn("INACTIVE DATE")
        With fldInactiveDate
            .FieldName = "fldInactiveDate"
            .Width = 140
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvItemSelect.Columns.Add(fldInactiveDate)
        rgvItemSelect.Columns("fldInactiveDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldUpdate As New GridViewCommandColumn("UPDATE")
        With fldUpdate
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .UseDefaultText = True
            .DefaultText = "UPDATE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvItemSelect.Columns.Add(fldUpdate)

        Dim fldDelete As New GridViewCommandColumn("DELETE")
        With fldDelete
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .UseDefaultText = True
            .DefaultText = "DELETE"
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvItemSelect.Columns.Add(fldDelete)

        AddHandler rgvItemSelect.CommandCellClick, AddressOf UpdateMe
    End Sub
    Private Sub UpdateMe()
        If rgvItemSelect.CurrentColumn.HeaderText = "UPDATE" Then
            txtID.Text = rgvItemSelect.CurrentRow.Cells("fldIID").Value.ToString
            ddlSup.Text = rgvItemSelect.CurrentRow.Cells("fldSuppName").Value.ToString
            ddlVenCode.Text = rgvItemSelect.CurrentRow.Cells("fldVendorCode").Value.ToString
            txtReason.Text = rgvItemSelect.CurrentRow.Cells("fldRemarks").Value.ToString
            txtApprovedBy.Text = rgvItemSelect.CurrentRow.Cells("fldApprovedBy").Value.ToString
            ddlStat.Text = rgvItemSelect.CurrentRow.Cells("fldStatus").Value.ToString
            dtpAppDate.Value = Convert.ToDateTime(rgvItemSelect.CurrentRow.Cells("fldApprovalDate").Value)

            If String.IsNullOrEmpty(rgvItemSelect.CurrentRow.Cells("fldInactiveDate").Value.ToString) Then
                cbInactive.Checked = True
                dtpInactiveDate.Enabled = False
            Else
                cbInactive.Checked = False
                dtpInactiveDate.Value = rgvItemSelect.CurrentRow.Cells("fldInactiveDate").Value
            End If
            btnUpdate.Visible = True
            btnSave.Visible = False
        ElseIf rgvItemSelect.CurrentColumn.HeaderText = "DELETE" Then
            If RadMessageBox.Show("WARNING. This operation is irreversible. Are you sure you want to remove this Item?",
                                         "Remove Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Zaji.addParameter("IID", rgvItemSelect.CurrentRow.Cells("fldIID").Value.ToString)
                Zaji.dbAED("SP_DeleteInactiveSup")
                FetchinactiveData()
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Selected Item has been deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
        End If
    End Sub

    Private Sub ReadySupplierGrid()

        Dim fldMOIID As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldMOIID
            .FieldName = "CardName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 500
        End With
        rgvSupplier.Columns.Add(fldMOIID)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("VENDOR CODE")
        With fldBudRefColumn
            .FieldName = "CardCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldBudRefColumn)

        Dim fldCurrencyColumn As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "Currency"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvSupplier.Columns.Add(fldCurrencyColumn)

        With rgvSupplier
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False '------
            .AllowRowResize = False
            .AllowAddNewRow = False

        End With
    End Sub


    Private Sub ClearField()
        dtpAppDate.Value = Date.Today
        ddlSup.Text = ""
        ddlVenCode.Text = ""

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(ddlSup.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please input Supplier Name", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If
        If String.IsNullOrEmpty(txtReason.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Please input Reason", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            Exit Sub
        End If
        If cbInactive.Checked = False Then
            If String.IsNullOrEmpty(txtApprovedBy.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Please input Approved By", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub
            End If
        End If

        Dim InacDate As String
        If (cbInactive.Checked = True) Then
            InacDate = Nothing
        Else
            InacDate = dtpInactiveDate.Value
        End If


        Zaji.addParameter("SuppName", ddlSup.Text)
        Zaji.addParameter("VendorCode", ddlVenCode.Text)
        Zaji.addParameter("Remarks", txtReason.Text)
        Zaji.addParameter("ApprovalDate", Convert.ToDateTime(dtpAppDate.Value))
        Zaji.addParameter("ApprovedBy", txtApprovedBy.Text)
        Zaji.addParameter("InactiveDate", InacDate)
        Zaji.addParameter("_ID", "0")
        Zaji.addParameter("_Status", ddlStat.Text)
        Zaji.dbAED("SP_InsertUpdateInactiveSupplier")
        FetchinactiveData()
        RadMessageBox.SetThemeName("Windows8")
        RadMessageBox.Show("Successfully added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)




    End Sub

    Private Sub rgvSupplier_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvSupplier.CellDoubleClick
        Try
            ddlSup.Text = rgvSupplier.CurrentRow.Cells("CardName").Value.ToString
            ddlVenCode.Text = rgvSupplier.CurrentRow.Cells("CardCode").Value.ToString

            GetRateSap()
        Catch ex As Exception
            ddlSup.Text = vbNullChar
            ddlVenCode.Text = vbNullChar
        End Try
    End Sub

    Private Sub cbInactive_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles cbInactive.ToggleStateChanged
        If (cbInactive.Checked = True) Then
            dtpInactiveDate.Enabled = False
        ElseIf (cbInactive.Checked = False) Then
            dtpInactiveDate.Enabled = True
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If RadMessageBox.Show("WARNING.  Are you sure you want to update this supplier?",
                         "Suppliers Info", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            Dim InacDate As String
            If (cbInactive.Checked = True) Then
                InacDate = Nothing
            Else
                InacDate = dtpInactiveDate.Value
            End If

            Zaji.addParameter("SuppName", ddlSup.Text)
            Zaji.addParameter("VendorCode", ddlVenCode.Text)
            Zaji.addParameter("Remarks", txtReason.Text)
            Zaji.addParameter("ApprovalDate", Convert.ToDateTime(dtpAppDate.Value))
            Zaji.addParameter("ApprovedBy", txtApprovedBy.Text)
            Zaji.addParameter("InactiveDate", InacDate)
            Zaji.addParameter("_ID", txtID.Text)
            Zaji.addParameter("_Status", ddlStat.Text)
            Zaji.dbAED("SP_InsertUpdateInactiveSupplier")
            FetchinactiveData()
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Successfully Updated!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            btnUpdate.Visible = False
            btnSave.Visible = True
        End If
    End Sub
End Class