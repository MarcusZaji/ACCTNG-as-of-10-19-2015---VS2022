Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Public Class FrmImportMasterBudget
    Public linestat As String
    Public lineNo As Integer
    Dim DTMjrBud As DataTable = New DataTable
    Private Sub FrmImportMasterBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        dtpDate.Value = Today()
        dtpDate.CustomFormat = "yyyy"
        dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        dtpDate.ShowUpDown = True
    End Sub
    Public Sub ReadyGrid()

        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        fldStatColumn.FieldName = "STATUS"
        fldStatColumn.Width = 60
        fldStatColumn.TextAlignment = ContentAlignment.MiddleCenter
        fldStatColumn.ReadOnly = True
        fldStatColumn.IsPinned = True
        fldStatColumn.PinPosition = PinnedColumnPosition.Left
        gvData.Columns.Add(fldStatColumn)

        Dim CheckifExist As New GridViewTextBoxColumn("Check")
        With CheckifExist
            .FieldName = "CheckifExist"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        gvData.Columns.Add(CheckifExist)

        Dim fldMjorRefNo As New GridViewTextBoxColumn("Major Ref. No")
        With fldMjorRefNo
            .FieldName = "fldMajorRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = True
        End With
        gvData.Columns.Add(fldMjorRefNo)

        Dim fldDesc As New GridViewTextBoxColumn("Description")
        With fldDesc
            .FieldName = "fldDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        gvData.Columns.Add(fldDesc)

        Dim fldJpyAmount As New GridViewTextBoxColumn("JPY Amount")
        With fldJpyAmount
            .FieldName = "fldJpyAmount"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        gvData.Columns.Add(fldJpyAmount)
        gvData.Columns("fldJpyAmount").FormatString = "{0:N2}"

        Dim fldDeptColumn As New GridViewTextBoxColumn("Department")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        gvData.Columns.Add(fldDeptColumn)

        Dim fldDateAdded As New GridViewDateTimeColumn("Date Added")
        With fldDateAdded
            .FieldName = "fldDateAdded"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = False
        End With
        gvData.Columns.Add(fldDateAdded)
        gvData.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy}"

        Dim fldProject As New GridViewTextBoxColumn("PROJECT")
        With fldProject
            .FieldName = "fldProject"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        gvData.Columns.Add(fldProject)

        With gvData
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            '.ShowFilteringRow = True
            .ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub
    Private Sub cbbPaste_Click(sender As Object, e As EventArgs) Handles cbbPaste.Click
        gvData.DataSource = Nothing

        Dim table As DataTable = Zaji.getClipboard

        DTMjrBud = Zaji.dbSelect("SP_SelectAllMajorBudget")

        Dim Query = (From T0 In table.AsEnumerable()
                     Select New With
                        {
                        ._fldMajorRefNo = Regex.Replace(Trim(T0.Item(0)), "\s+", " "),
                        ._fldDesc = Regex.Replace(Trim(T0.Item(1)), "\s+", " "),
                        ._fldJpyAmount = IIf(Not String.IsNullOrEmpty(T0.Item(2)), T0.Item(2), 0),
                        ._fldDept = Regex.Replace(Trim(T0.Item(3)), "\s+", " "),
                        ._fldProject = Regex.Replace(Trim(T0.Item(4)), "\s+", " ")
                        }).ToList

        Dim FinalQuery = (From i In Query.DefaultIfEmpty()
                          Let _CheckifExist = CheckifExist(i._fldMajorRefNo)
                          Select New With
                            {
                            .fldMajorRefNo = i._fldMajorRefNo,
                            .fldDesc = i._fldDesc,
                            .fldJpyAmount = i._fldJpyAmount,
                            .fldDept = i._fldDept,
                            .CheckifExist = If(_CheckifExist Is Nothing, "doesn't exist", "existing"),
                            .fldProject = i._fldProject
                            })
        gvData.DataSource = FinalQuery



    End Sub
    Function CheckifExist(ByVal MjrBud As String)
        Dim Query = (From i In DTMjrBud.AsEnumerable()
                     Where Convert.ToString(i("fldMajorRefNo")) = MjrBud
                     Select Convert.ToString(i("fldMajorRefNo"))).FirstOrDefault()

        Return Convert.ToString(Query)
    End Function

    Private Sub cbbStartImport_Click(sender As Object, e As EventArgs) Handles cbbStartImport.Click
        If RadMessageBox.Show("Are you sure you want to Save " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            bwUpload.RunWorkerAsync()
        End If

    End Sub

    Private Sub cbbDeleteSelected_Click(sender As Object, e As EventArgs) Handles cbbDeleteSelected.Click
        If RadMessageBox.Show("Are you sure you want to delete " & gvData.SelectedRows.Count & " selected row(s)?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            Dim rows As GridViewDataRowInfo() = New GridViewDataRowInfo(Me.gvData.SelectedRows.Count - 1) {}
            Me.gvData.SelectedRows.CopyTo(rows, 0)

            For i As Integer = 0 To rows.Length - 1
                Me.gvData.Rows.Remove(rows(i))
            Next
        End If
    End Sub

    Private Sub cbbClearList_Click(sender As Object, e As EventArgs) Handles cbbClearList.Click
        If RadMessageBox.Show("Are you sure you want to clear the list?", "CONFIRMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            gvData.DataSource = Nothing
        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If gvData.ChildRows.Count > 0 Then

            Dim spreadStreamExport As New GridViewSpreadStreamExport(Me.gvData)
            spreadStreamExport.HiddenColumnOption = HiddenOption.DoNotExport
            spreadStreamExport.HiddenRowOption = HiddenOption.DoNotExport

            SaveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*"
            SaveFileDialog1.FilterIndex = 1
            SaveFileDialog1.RestoreDirectory = True

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                AddHandler spreadStreamExport.AsyncExportProgressChanged, AddressOf SpreadStreamExport_AsyncExportProgressChanged
                AddHandler spreadStreamExport.AsyncExportCompleted, AddressOf SpreadStreamExport_AsyncExportCompleted
                spreadStreamExport.RunExportAsync(SaveFileDialog1.FileName, New SpreadStreamExportRenderer())
            End If

        End If
    End Sub
    Private Sub SpreadStreamExport_AsyncExportCompleted(ByVal sender As Object, ByVal e As AsyncCompletedEventArgs)
        RadMessageBox.Show("Export Completed", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
    Private Sub SpreadStreamExport_AsyncExportProgressChanged(ByVal sender As Object, ByVal e As ProgressChangedEventArgs)
        RadProgressBarElement1.Text = e.ProgressPercentage & "%"
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 20
        For counter As Integer = 0 To gvData.Rows.Count - 1

            Zaji.addParameter("MajorRefNo", Regex.Replace(gvData.Rows(counter).Cells("fldMajorRefNo").Value, "\s+", " "))
            Zaji.addParameter("_Desc", Regex.Replace(gvData.Rows(counter).Cells("fldDesc").Value, "\s+", " "))
            Zaji.addParameter("JpyAmount", gvData.Rows(counter).Cells("fldJpyAmount").Value)
            Zaji.addParameter("Dept", Regex.Replace(gvData.Rows(counter).Cells("fldDept").Value, "\s+", " "))
            Zaji.addParameter("_Year", dtpDate.Value)
            Zaji.addParameter("Project", Regex.Replace(gvData.Rows(counter).Cells("fldProject").Value, "\s+", " "))

            If Zaji.dbAED("SP_InsertMajorBudgetv2") Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / gvData.Rows.Count * 100
            lineNo = counter
            Threading.Thread.Sleep(delay)
            RadProgressBarElement1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))
        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        gvData.CurrentRow = gvData.Rows(lineNo)
        gvData.CurrentRow.Cells(0).Value = linestat
        RadProgressBarElement1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBarElement1.Text = "Done"
        RadProgressBarElement1.Value1 = 100
        FrmMajorBudget.Shown()
        RadMessageBox.Show("Successfully Uploaded", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub

    Private Sub gvData_RowFormatting(sender As Object, e As RowFormattingEventArgs) Handles gvData.RowFormatting
        If e.RowElement.RowInfo.Cells("CheckifExist").Value = "existing" Then
            e.RowElement.DrawFill = True
            e.RowElement.GradientStyle = GradientStyles.Solid
            e.RowElement.BackColor = Color.Gold
        Else
            e.RowElement.ResetValue(LightVisualElement.DrawFillProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.BackColorProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.NumberOfColorsProperty, ValueResetFlags.Local)
            e.RowElement.ResetValue(LightVisualElement.ForeColorProperty, ValueResetFlags.Local)
        End If
    End Sub
End Class
