Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class FrmUploadBCSBudget

    Public linestat As String
    Public lineNo As Integer
    Dim fldSubClass, fldSubClassCode, fldRemarks
    Dim dtBudget As DataTable
    Dim drClass As DataTable
    Dim drClassPPE As DataTable

    Private Sub FrmUploadBCSBudget_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = New Point(0, 2)
    End Sub
    Private Sub FrmUploadBCSBudget_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        drClass = Chinita.fetchMySqlRowDataTable("select fldClassCode,fldClassDesc from tblClass")
        drClassPPE = Chinita.fetchMySqlRowDataTable("SELECT fldSCCode,fldSCDesc FROM tblClassPPE")
        dtBudget = Chinita.fetchDBTable_BC("select * from tblBudget")

    End Sub

    Private Sub ReadyGrid()
        '-----------------'
        '--MASTER BUDGET--'
        '-----------------'


        Dim fldStatColumn As New GridViewTextBoxColumn("STATUS")
        With fldStatColumn
            .FieldName = "STATUS"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
            .IsVisible = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldStatColumn)

        Dim fldDupe As New GridViewTextBoxColumn("DUPLICATE")
        With fldDupe
            .FieldName = "DUPLICATE"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
            .IsVisible = True
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(fldDupe)

        Dim fldBudRefColumn As New GridViewTextBoxColumn("SUB REF NO.")
        With fldBudRefColumn
            .FieldName = "fldBCRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True

            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldBudRefColumn)

        Dim fldSubRefNo As New GridViewTextBoxColumn("MAJOR REF NO.")
        With fldSubRefNo
            .FieldName = "fldSubRefNo"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldSubRefNo)

        Dim fldDeptColumn As New GridViewTextBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldActivityCodeColumn As New GridViewTextBoxColumn("ACTIVITY CODE")
        With fldActivityCodeColumn
            .FieldName = "fldActivityCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldActivityCodeColumn)

        Dim fldClassColumn As New GridViewTextBoxColumn("CLASSIFICATION")
        With fldClassColumn
            .FieldName = "fldClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldClassColumn)

        Dim fldClassCodeColumn As New GridViewTextBoxColumn("CLASS CODE")
        With fldClassCodeColumn
            .FieldName = "fldClassCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldClassCodeColumn)

        Dim fldSubClassColumn As New GridViewTextBoxColumn("SUB CLASSIFICATION")
        With fldSubClassColumn
            .FieldName = "fldSubClass"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSubClassColumn)

        Dim fldSubClassCodeColumn As New GridViewTextBoxColumn("SUB CLASS CODE")
        With fldSubClassCodeColumn
            .FieldName = "fldSubClassCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSubClassCodeColumn)

        Dim fldDescColumn As New GridViewTextBoxColumn("BUDGET DESCRIPTION")
        With fldDescColumn
            .FieldName = "fldDesc"
            .Width = 400
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDescColumn)

        Dim fldProcessColumn As New GridViewTextBoxColumn("PROCESS")
        With fldProcessColumn
            .FieldName = "fldProcess"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldProcessColumn)

        Dim fldQTYColumn As New GridViewDecimalColumn("QUANTITY")
        With fldQTYColumn
            .FieldName = "fldQTY"
            .Width = 70
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldQTYColumn)

        Dim fldUOMColumn As New GridViewComboBoxColumn("MEASUREMENT UNIT")
        With fldUOMColumn
            .FieldName = "fldUOM"
            .Width = 125
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PCS", "LOT"}
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldUOMColumn)

        Dim fldSOUColumn As New GridViewDateTimeColumn("START OF USE")
        With fldSOUColumn
            .FieldName = "fldSOU"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSOUColumn)
        rgvList.Columns("fldSOU").FormatString = "{0:MMM dd, yyyy}"


        Dim fldCurrencyColumn As New GridViewComboBoxColumn("CURRENCY")
        With fldCurrencyColumn
            .FieldName = "fldCurrency"
            .Width = 65
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PHP", "USD", "JPY"}
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldCurrencyColumn)

        Dim fldUAmountColumn As New GridViewTextBoxColumn("UNIT PRICE")
        With fldUAmountColumn
            .FieldName = "fldUAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldUAmountColumn)
        rgvList.Columns("fldUAmount").FormatString = "{0:N2}"

        Dim fldAmountColumn As New GridViewTextBoxColumn("ORIGINAL AMOUNT")
        With fldAmountColumn
            .FieldName = "fldAmount"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldAmountColumn)
        rgvList.Columns("fldAmount").FormatString = "{0:N2}"

        Dim fldMBudgetedColumn As New GridViewDateTimeColumn("MONTH BUDGETED")
        With fldMBudgetedColumn
            .FieldName = "fldMonthBudgeted"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldMBudgetedColumn)
        rgvList.Columns("fldMonthBudgeted").FormatString = "{0:MMM dd, yyyy}"

        Dim fldRemarksColumn As New GridViewTextBoxColumn("REMARKS")
        With fldRemarksColumn
            .FieldName = "fldRemarks"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldRemarksColumn)

        Dim fldSignatureColumn As New GridViewTextBoxColumn("SIGNATURE")
        With fldSignatureColumn
            .FieldName = "fldSignature"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
            .IsVisible = True
        End With
        rgvList.Columns.Add(fldSignatureColumn)

        '-------------------------'
        '-----GRID PROPERTIES-----'
        '-------------------------'

        With rgvList

            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub btnPasteData_Click(sender As Object, e As EventArgs) Handles btnPasteData.Click

        rgvList.DataSource = Nothing

        'Try
        Dim ClipboardData As IDataObject = Clipboard.GetDataObject()

        If Not ClipboardData Is Nothing Then
            If (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                Dim ClipboardStream As New IO.StreamReader( _
                   CType(ClipboardData.GetData(DataFormats.CommaSeparatedValue), IO.Stream))

                Dim FormattedData As String = ""
                Dim Table As New DataTable With {.TableName = "ExcelData"}

                While (ClipboardStream.Peek() > 0)
                    Dim SingleRowData As Array
                    Dim LoopCounter As Integer = 0

                    FormattedData = ClipboardStream.ReadLine()

                    SingleRowData = FormattedData.Split(",".ToCharArray)

                    If Table.Columns.Count <= 0 Then
                        For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                            Table.Columns.Add()
                        Next
                        LoopCounter = 0
                    End If

                    Dim rowNew As DataRow
                    rowNew = Table.NewRow()

                    For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                        rowNew(LoopCounter) = SingleRowData.GetValue(LoopCounter)
                    Next

                    LoopCounter = 0

                    Table.Rows.Add(rowNew)

                    rowNew = Nothing
                End While



                Dim JoinResult As IEnumerable = (From T0 In Table.AsEnumerable()
                                                 Join T1 In drClass.AsEnumerable()
                          On T0.Field(Of String)("Column5") Equals T1.Field(Of String)("fldClassCode")
                                                 Join T2 In drClassPPE.AsEnumerable()
                          On T0.Field(Of String)("Column6") Equals T2.Field(Of String)("fldSCCode")
                                                 Let _CheckBud = CheckBud(T0.Item(1))
                                                 Select New With {
                            Key .fldSubRefNo = T0.Item(0),
                            Key .fldBCRefNo = T0.Item(1),
                            Key .fldDept = T0.Item(2),
                            Key .fldActivityCode = T0.Item(3),
                            Key .fldClass = T1.Field(Of String)("fldClassDesc"),
                            Key .fldClassCode = T0.Item(4),
                            Key .fldSubClass = T2.Field(Of String)("fldSCDesc"),
                            Key .fldSubClassCode = T0.Item(5),
                            Key .fldDesc = T0.Item(6),
                            Key .fldProcess = T0.Item(7),
                            Key .fldQTY = T0.Item(8),
                            Key .fldUOM = T0.Item(9),
                            Key .fldSOU = T0.Item(10),
                            Key .fldCurrency = T0.Item(11),
                            Key .fldUAmount = T0.Item(12),
                            Key .fldAmount = T0.Item(13),
                            Key .fldMonthBudgeted = T0.Item(14),
                            Key .fldRemarks = T0.Item(15),
                            Key .fldSignature = T0.Item(16),
                            Key .DUPLICATE = _CheckBud
                         }).ToList

                ClipboardStream.Close()
                rgvList.DataSource = JoinResult

                'btnImport.Enabled = True
                'btnPasteData.Enabled = False
            Else
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Clipboard data does not seem to be copied from Excel!", "BAP", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Clipboard is empty!", "BAP", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If
        'Catch exp As Exception
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show(exp.Message, "BAP", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End Try
    End Sub
    Function CheckBud(ByVal Bud As String)
        Dim Result As String
        Dim Query = (From i In dtBudget.AsEnumerable()
                     Where Convert.ToString(i("fldBCRefNo")) = Bud
                     Select Convert.ToString(i("fldBudID"))).FirstOrDefault()
        If String.IsNullOrEmpty(Query) Then
            Result = ""
            btnImport.Enabled = True
            btnPasteData.Enabled = False
        Else
            Result = "Duplicate Sub Ref No"
            btnImport.Enabled = False
            btnPasteData.Enabled = False
        End If
        Return Result
    End Function
    Private Sub bwUpload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwUpload.DoWork
        For counter As Integer = 0 To rgvList.Rows.Count - 1
            Dim trysuccess As Boolean

            Dim fldBCRefNo = rgvList.Rows(counter).Cells("fldBCRefNo").Value.ToString()
            Dim fldDept = rgvList.Rows(counter).Cells("fldDept").Value.ToString()
            Dim fldActivityCode = rgvList.Rows(counter).Cells("fldActivityCode").Value.ToString()
            Dim fldClass = rgvList.Rows(counter).Cells("fldClass").Value.ToString()
            Dim fldClassCode = rgvList.Rows(counter).Cells("fldClassCode").Value.ToString()

            If String.IsNullOrEmpty(rgvList.Rows(counter).Cells("fldSubClass").Value.ToString()) Then
                fldSubClass = Nothing
            Else
                fldSubClass = rgvList.Rows(counter).Cells("fldSubClass").Value.ToString()
            End If

            If String.IsNullOrEmpty(rgvList.Rows(counter).Cells("fldSubClassCode").Value.ToString()) Then
                fldSubClassCode = Nothing
            Else
                fldSubClassCode = rgvList.Rows(counter).Cells("fldSubClassCode").Value.ToString()
            End If

            Dim fldDesc = rgvList.Rows(counter).Cells("fldDesc").Value.ToString()
            Dim fldProcess = rgvList.Rows(counter).Cells("fldProcess").Value.ToString()
            Dim fldQTY = rgvList.Rows(counter).Cells("fldQTY").Value.ToString()
            Dim fldUOM = rgvList.Rows(counter).Cells("fldUOM").Value.ToString()
            'RadMessageBox.Show(rgvList.Rows(counter).Cells("fldSOU").Value.ToString(), "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)

            Dim fldSOU As Date = Convert.ToDateTime(String.Format("{0:yyyy-MM-dd}", rgvList.Rows(counter).Cells("fldSOU").Value))
            Dim fldCurrency = rgvList.Rows(counter).Cells("fldCurrency").Value.ToString()
            Dim fldUAmount = rgvList.Rows(counter).Cells("fldUAmount").Value.ToString()
            Dim fldAmount = rgvList.Rows(counter).Cells("fldAmount").Value.ToString()
            Dim fldMonthBudgeted = rgvList.Rows(counter).Cells("fldMonthBudgeted").Value.ToString()

            If String.IsNullOrEmpty(rgvList.Rows(counter).Cells("fldRemarks").Value.ToString()) Then
                fldRemarks = rgvList.Rows(counter).Cells("fldRemarks").Value.ToString()
            Else
                fldRemarks = Nothing
            End If


            Dim fldSignature = rgvList.Rows(counter).Cells("fldSignature").Value.ToString()
            Dim fldSubRefNo = rgvList.Rows(counter).Cells("fldSubRefNo").Value.ToString()


            trysuccess = Tomboy.AddCreatedBudgetPPEUpload(fldBCRefNo,
                                                         fldDept,
                                                         fldActivityCode,
                                                         fldClass,
                                                         fldClassCode,
                                                         fldSubClass,
                                                         fldSubClassCode,
                                                         fldDesc,
                                                         fldProcess,
                                                         fldQTY,
                                                         fldUOM,
                                                         fldSOU,
                                                         fldCurrency,
                                                         fldUAmount,
                                                         fldAmount,
                                                         fldMonthBudgeted,
                                                         fldRemarks,
                                                         fldSignature,
                                                         fldSubRefNo)

            If trysuccess Then
                linestat = "OK"
            Else
                linestat = "NG"
            End If

            Dim percent As Double = counter / rgvList.Rows.Count * 100
            lineNo = counter
            RadProgressBar1.Text = "Saving..."
            bwUpload.ReportProgress(Convert.ToInt32(percent))

        Next
    End Sub

    Private Sub bwUpload_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        rgvList.CurrentRow = rgvList.Rows(lineNo)
        rgvList.CurrentRow.Cells(0).Value = linestat

        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub



    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBar1.Text = "Done"
        RadProgressBar1.Value1 = 100
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        bwUpload.RunWorkerAsync()

        btnImport.Enabled = False

        btnPasteData.Enabled = True

    End Sub
End Class
