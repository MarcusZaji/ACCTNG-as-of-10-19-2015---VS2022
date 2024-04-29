Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmRate
    Private Sub FrmRate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.Value = DateTime.Today
        ReadyGrid()
    End Sub

    Private Sub FrmRate_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchRate()
    End Sub

    Public Sub FetchRate()

        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectAllRate")
        rgvList.DataSource = DTSBud
    End Sub

    Private Sub btnSaveMulOrder_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Zaji.addParameter("Currency", ddlCurrency.Text)
        Zaji.addParameter("_Date", dtpDate.Value)
        Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckRate")


        If DTCheck.Rows.Count = 1 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Item Already Exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(mebRate.Value = 0.0000) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Major Budget Reference Number Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("Currency", ddlCurrency.Text)
            Zaji.addParameter("Rate", mebRate.Value)
            Zaji.addParameter("_Date", dtpDate.Value)
            Zaji.dbAED("SP_InsertRate")

            FetchRate()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(ddlCurrency.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Currency", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(mebRate.Value = 0.0000) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Major Budget Reference Number Selected!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("RID", txtID.Text)
            Zaji.addParameter("Currency", ddlCurrency.Text)
            Zaji.addParameter("Rate", mebRate.Value)
            Zaji.dbAED("SP_UpdateRate")
            FetchRate()

            btnUpdate.Enabled = False
            btnSave.Enabled = True
            dtpDate.Enabled = True
        End If
    End Sub
    Private Sub ReadyGrid()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldRID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldID)

        Dim fldCurrency As New GridViewTextBoxColumn("CURRENCY")
        With fldCurrency
            .FieldName = "fldCurrency"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
        End With
        rgvList.Columns.Add(fldCurrency)

        Dim fldICColumn As New GridViewTextBoxColumn("RATE")
        With fldICColumn
            .FieldName = "fldRate"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 100
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldICColumn)

        Dim fldDate As New GridViewDateTimeColumn("DATE")
        With fldDate
            .FieldName = "fldDate"
            .Width = 110
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDate)
        rgvList.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

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


        AddHandler rgvList.CommandCellClick, AddressOf UpdateMe
    End Sub
    Private Sub UpdateMe()
        If rgvList.CurrentColumn.HeaderText = "UPDATE" Then
            Try
                txtID.Text = rgvList.CurrentRow.Cells("fldRID").Value.ToString
                ddlCurrency.Text = rgvList.CurrentRow.Cells("fldCurrency").Value.ToString
                dtpDate.Value = Convert.ToDateTime(rgvList.CurrentRow.Cells("fldDate").Value.ToString)
                mebRate.Value = rgvList.CurrentRow.Cells("fldRate").Value.ToString

                btnUpdate.Enabled = True
                btnSave.Enabled = False
                dtpDate.Enabled = False
            Catch ex As Exception

            End Try

        End If
    End Sub
End Class
