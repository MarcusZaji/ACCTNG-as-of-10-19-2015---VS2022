Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmSupplier


    Public linestat As String
    Public lineNo As Integer
    Private Sub FrmSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGridSupplier()
        ReadyGridImport()
    End Sub

    Private Sub FrmSupplier_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchSupplier()
    End Sub
    Public Sub FetchSupplier()

        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectAllSuppliers")
        rgvList.DataSource = DTSBud
    End Sub
    Private Sub ReadyGridImport()
        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "STATUS"
            .Width = 60
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvImport.Columns.Add(fldStatColumn)

        Dim fldSuppCode As New GridViewTextBoxColumn("SUPPLIER CODE")
        With fldSuppCode
            .FieldName = "fldSuppCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
        End With
        rgvImport.Columns.Add(fldSuppCode)

        Dim fldSuppName As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldSuppName
            .FieldName = "fldSuppName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 200
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldSuppName)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrency
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldCurrency)

        Dim fldAddress As New GridViewTextBoxColumn("ADDRESS")
        With fldAddress
            .FieldName = "fldAddress"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 200
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldAddress)

        Dim fldTIN As New GridViewTextBoxColumn("TIN")
        With fldTIN
            .FieldName = "fldTIN"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldTIN)

        Dim fldTerms As New GridViewTextBoxColumn("TERM")
        With fldTerms
            .FieldName = "fldTerms"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldTerms)



    End Sub
    Private Sub ReadyGridSupplier()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldSID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
            .IsPinned = Right()
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldID)

        Dim fldSuppCode As New GridViewTextBoxColumn("SUPPLIER CODE")
        With fldSuppCode
            .FieldName = "fldSuppCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
        End With
        rgvList.Columns.Add(fldSuppCode)

        Dim fldSuppName As New GridViewTextBoxColumn("SUPPLIER NAME")
        With fldSuppName
            .FieldName = "fldSuppName"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 200
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldSuppName)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrency
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldCurrency)

        Dim fldAddress As New GridViewTextBoxColumn("ADDRESS")
        With fldAddress
            .FieldName = "fldAddress"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 350
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldAddress)

        Dim fldTIN As New GridViewTextBoxColumn("TIN")
        With fldTIN
            .FieldName = "fldTIN"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldTIN)

        Dim fldTerms As New GridViewTextBoxColumn("TERM")
        With fldTerms
            .FieldName = "fldTerms"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldTerms)

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
        rgvList.Columns.Add(fldUpdate)

        rgvList.AllowAddNewRow = False
        AddHandler rgvList.CommandCellClick, AddressOf UpdateMe
    End Sub
    Private Sub UpdateMe()
        If rgvList.CurrentColumn.HeaderText = "UPDATE" Then

            Try
                txtID.Text = rgvList.CurrentRow.Cells("fldSID").Value.ToString
                txtSupplierCode.Text = rgvList.CurrentRow.Cells("fldSuppCode").Value.ToString
                txtSuppliersName.Text = rgvList.CurrentRow.Cells("fldSuppName").Value.ToString
                ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
                txtAddress.Text = rgvList.CurrentRow.Cells("fldAddress").Value.ToString
                txtTIN.Text = rgvList.CurrentRow.Cells("fldTIN").Value.ToString
                txtTemrs.Text = rgvList.CurrentRow.Cells("fldTerms").Value.ToString
                txtSupplierCode.Enabled = False
                btnUpdate.Enabled = True
                btnSave.Enabled = False
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Zaji.addParameter("SuppCode", txtSupplierCode.Text)
        Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckSuppCode")

        If DTCheck.Rows.Count = 1 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Item Already Exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtSupplierCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Supplier Code", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtSuppliersName.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Supplier Name", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtAddress.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Address", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtTIN.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No TIN", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtTemrs.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Terms", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            Zaji.addParameter("SuppCode", txtSupplierCode.Text)
            Zaji.addParameter("SuppName", txtSuppliersName.Text)
            Zaji.addParameter("Currency", ddlCurrency.Text)
            Zaji.addParameter("Address", txtAddress.Text)
            Zaji.addParameter("TIN", txtTIN.Text)
            Zaji.addParameter("Terms", txtTemrs.Text)
            Zaji.dbAED("SP_InsertSupplier")

            FetchSupplier()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtSupplierCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Supplier Code", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtSuppliersName.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Supplier Name", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtAddress.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Address", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtTIN.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No TIN", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtTemrs.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Terms", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else

            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("SuppCode", txtSupplierCode.Text)
            Zaji.addParameter("SuppName", txtSuppliersName.Text)
            Zaji.addParameter("Currency", ddlCurrency.Text)
            Zaji.addParameter("Address", txtAddress.Text)
            Zaji.addParameter("TIN", txtTIN.Text)
            Zaji.addParameter("Terms", txtTemrs.Text)
            Zaji.dbAED("SP_UpdateSupplier")
            FetchSupplier()
            txtSupplierCode.Enabled = True
            btnUpdate.Enabled = False
            btnSave.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim filename As String = rbeGetData.Value.ToString

        Dim cn As System.Data.OleDb.OleDbConnection
        Dim cmd As System.Data.OleDb.OleDbDataAdapter
        Dim dt As New DataTable

        cn = New System.Data.OleDb.OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & filename & ";Extended Properties=Excel 12.0;")

        cmd = New System.Data.OleDb.OleDbDataAdapter("select * from [Sheet1$]", cn)
        cn.Open()
        cmd.Fill(dt)
        cn.Close()

        globalVariables.dtImport = dt
        ImportSupplier()
    End Sub
    Public Sub ImportSupplier()
        Try
            rgvImport.DataSource = Nothing

            Dim table As DataTable = globalVariables.dtImport

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                                .fldSuppCode = Regex.Replace(Trim(T0.Item(0)), "\s+", " ").ToString(),
                                                .fldSuppName = Regex.Replace(Trim(T0.Item(1)), "\s+", " ").ToString(),
                                                .fldCurrency = Regex.Replace(Trim(T0.Item(2)), "\s+", " ").ToString(),
                                                .fldAddress = Regex.Replace(Trim(T0.Item(3)), "\s+", " ").ToString(),
                                                .fldTerms = Regex.Replace(Trim(T0.Item(4)), "\s+", " ").ToString(),
                                                .fldTIN = Regex.Replace(Trim(T0.Item(5)), "\s+", " ").ToString()
                                             }).ToList
            rgvImport.DataSource = Query
        Catch ex As Exception
            MessageBox.Show("Error please contact MIS")
        End Try

    End Sub

    Private Sub btnSaveImport_Click(sender As Object, e As EventArgs) Handles btnSaveImport.Click
        bwUpload.RunWorkerAsync()
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30
        For counter As Integer = 0 To rgvImport.Rows.Count - 1

            Zaji.addParameter("SuppCode", Regex.Replace(rgvImport.Rows(counter).Cells("fldSuppCode").Value, "\s+", " "))
            Zaji.addParameter("SuppName", Regex.Replace(rgvImport.Rows(counter).Cells("fldSuppName").Value, "\s+", " "))
            Zaji.addParameter("Currency", Regex.Replace(rgvImport.Rows(counter).Cells("fldCurrency").Value, "\s+", " "))
            Zaji.addParameter("Address", Regex.Replace(rgvImport.Rows(counter).Cells("fldAddress").Value, "\s+", " "))
            Zaji.addParameter("TIN", Regex.Replace(rgvImport.Rows(counter).Cells("fldTIN").Value, "\s+", " "))
            Zaji.addParameter("Terms", Regex.Replace(rgvImport.Rows(counter).Cells("fldTerms").Value, "\s+", " "))

            If Zaji.dbAED("SP_InsertSupplier") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / rgvImport.Rows.Count * 100
            lineNo = counter
            RadProgressBar1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
            Threading.Thread.Sleep(delay)
        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        rgvImport.CurrentRow = rgvImport.Rows(lineNo)
        rgvImport.CurrentRow.Cells(0).Value = linestat
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBar1.Text = "Done"
        RadProgressBar1.Value1 = 100
        RadMessageBox.Show("Successfully Uploaded", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
End Class