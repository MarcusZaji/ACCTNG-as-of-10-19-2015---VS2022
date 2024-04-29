Imports Telerik.WinControls
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI
Public Class FrmRFQItems
    Private Sub FrmRFQItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
    End Sub
    Private Sub ReadyGrid()

        Dim fldStatColumn As New GridViewCheckBoxColumn(" ")
        With fldStatColumn
            .FieldName = "checkme"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = False
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            rgvlIST.Columns.Add(fldStatColumn)
        End With

        Dim RFQNo As New GridViewTextBoxColumn("RFQ No")
        With RFQNo
            .FieldName = "RFQNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        rgvlIST.Columns.Add(RFQNo)

        Dim fldNo As New GridViewTextBoxColumn("No")
        With fldNo
            .FieldName = "fldNo"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        rgvlIST.Columns.Add(fldNo)

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldID"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvlIST.Columns.Add(fldID)

        Dim fldDateRequest As New GridViewDateTimeColumn("Date Request")
        With fldDateRequest
            .FieldName = "fldDateRequest"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldDateRequest)
        rgvlIST.Columns("fldDateRequest").FormatString = "{0:MMM dd, yyyy}"

        Dim fldEmpNo As New GridViewTextBoxColumn("Emp. No")
        With fldEmpNo
            .FieldName = "fldEmpNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvlIST.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("Name")
        With fldEmpName
            .FieldName = "fldEmpName"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldEmpName)

        Dim fldSection As New GridViewTextBoxColumn("Section")
        With fldSection
            .FieldName = "fldSection"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldSection)

        Dim fldDept As New GridViewTextBoxColumn("Department")
        With fldDept
            .FieldName = "fldDept"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvlIST.Columns.Add(fldDept)

        Dim fldTypeExpense As New GridViewTextBoxColumn("Type of Expense")
        With fldTypeExpense
            .FieldName = "fldTypeExpense"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldTypeExpense)

        Dim fldDesc As New GridViewTextBoxColumn("Descripion")
        With fldDesc
            .FieldName = "fldDesc"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldDesc)

        Dim fldQTY As New GridViewTextBoxColumn("QTY")
        With fldQTY
            .FieldName = "fldQTY"
            .Width = 50
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldQTY)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldUOMColumn)

        Dim fldDateNeeded As New GridViewDateTimeColumn("Date Needed")
        With fldDateNeeded
            .FieldName = "fldDateNeeded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldDateNeeded)
        rgvlIST.Columns("fldDateNeeded").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarks As New GridViewTextBoxColumn("Remarks")
        With fldRemarks
            .FieldName = "fldRemarks"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldRemarks)

        Dim fldChemical As New GridViewTextBoxColumn("Chemical")
        With fldChemical
            .FieldName = "fldChemical"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldChemical)

        Dim fldRFQby As New GridViewTextBoxColumn("RFQ BY")
        With fldRFQby
            .FieldName = "fldRFQby"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldRFQby)

        Dim fldPPE As New GridViewTextBoxColumn("PPE")
        With fldPPE
            .FieldName = "fldPPE"
            .Width = 80
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvlIST.Columns.Add(fldPPE)

    End Sub

    Private Sub FrmRFQItems_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectAllRFQ")
        rgvlIST.DataSource = dtRFQRec
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        For counter As Integer = 0 To rgvlIST.Rows.Count - 1
            If rgvlIST.Rows(counter).Cells("checkme").Value = True Then
                Dim ID As String = rgvlIST.Rows(counter).Cells("fldID").Value
                Dim Desc As String = rgvlIST.Rows(counter).Cells("fldDesc").Value
                Dim QTY As String = rgvlIST.Rows(counter).Cells("fldQTY").Value
                Dim UOM As String = rgvlIST.Rows(counter).Cells("fldUOM").Value
                Dim Remarks As String = rgvlIST.Rows(counter).Cells("fldRemarks").Value
                Dim DueDate As DateTime = rgvlIST.Rows(counter).Cells("fldDateNeeded").Value

                FrmRFQPur.rgvItems.Rows.Add("", ID, Desc, QTY, UOM, Remarks, DueDate)
                FrmRFQPur.txtDept.Text = rgvlIST.Rows(counter).Cells("fldDept").Value
                FrmRFQPur.txtSection.Text = rgvlIST.Rows(counter).Cells("fldSection").Value
                FrmRFQPur.dtpDateNeeded.Text = rgvlIST.Rows(counter).Cells("fldDateNeeded").Value
            End If
        Next
        Me.Close()
    End Sub

    Private Sub rgvlIST_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles rgvlIST.RowFormatting

        If e.RowElement.RowInfo.Cells("fldRFQby").Value.ToString = "None" Then
            e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
        Else
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.MediumOrchid
        End If

    End Sub
End Class
