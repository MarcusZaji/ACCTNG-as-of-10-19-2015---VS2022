Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Public Class frmMatrixExpense

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private ds As DataSet
    Private UID As String
    Private RowIndex As Integer = Nothing

    Public LoadCount As Integer

    Private Sub frmMatrixExpense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)

        UID = SelectedDetails

        ReadyGrid()

        'Clear(Me)

        GetUser()

        CheckU()

    End Sub

    Private Sub frmMatrixExpense_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            If bwLoadData.IsBusy Then
                bwLoadData.CancelAsync()
                imBusy = False
            End If
            Me.Close()
        End If

    End Sub

    Private Sub CheckU()
        Try
            If lblUserlvl.Text = "SUPERADMIN" Then
                btnNewMatrix.Visible = True
                btnEditMatrix.Visible = True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Sub GetUser()

        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
       
        lblUserID.Text = drUser.Item("fldUID")

        lblDept.Text = drUser.Item("fldDept").ToString

        lblUserlvl.Text = drUser.Item("fldUserlvl").ToString

    End Sub

    Private Sub frmMatrixExpense_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = True
        Me.Cursor = Cursors.WaitCursor
        bwLoadData.RunWorkerAsync()
        pbOhYeah.Visible = True
    End Sub

    Private Sub ReadyGrid()

        Dim fldIDColumn As New GridViewDecimalColumn("ID")
        With fldIDColumn
            .FieldName = "fldID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldIDColumn)

        Dim fldItemColumn As New GridViewTextBoxColumn("ITEM")
        With fldItemColumn
            .FieldName = "fldItem"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
            '.DropDownStyle = RadDropDownStyle.DropDownList
            .IsPinned = True
            .PinPosition = PinnedColumnPosition.Left
            .ReadOnly = True
            .WrapText = True
        End With
        rgvList.Columns.Add(fldItemColumn)

        Dim fldDefinitionColumn As New GridViewTextBoxColumn("DEFINITION / CRITERIA / NATURE")
        With fldDefinitionColumn
            .FieldName = "fldDefinition"
            .Width = 400
            .TextAlignment = ContentAlignment.MiddleLeft
            .IsPinned = True
            .ReadOnly = True
            .WrapText = True
        End With
        rgvList.Columns.Add(fldDefinitionColumn)

        Dim fldThresholdColumn As New GridViewTextBoxColumn("THRESHOLD / CAPITALIZABLE AMOUNT")
        With fldThresholdColumn
            .FieldName = "fldThreshold"
            .Width = 400
            .TextAlignment = ContentAlignment.MiddleLeft
            .IsPinned = True
            .ReadOnly = True
            .WrapText = True
        End With
        rgvList.Columns.Add(fldThresholdColumn)


        Dim fldSampleColumn As New GridViewTextBoxColumn("SAMPLE")
        With fldSampleColumn
            .FieldName = "fldSample"
            .Width = 250
            .TextAlignment = ContentAlignment.MiddleLeft
            .IsPinned = True
            .ReadOnly = True
            .WrapText = True
        End With
        rgvList.Columns.Add(fldSampleColumn)

        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .AutoScroll = True
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        If bwLoadData.IsBusy Then
            bwLoadData.CancelAsync()
            imBusy = False
        End If

        Me.Close()
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        Try
            dtLoadData = Chinita.fetchDBTable_BC("SELECT * FROM tblMatrixExpense")

            For counter As Integer = 0 To dtLoadData.Rows.Count - 1

                Dim x As Double = counter / dtLoadData.Rows.Count * 100
                bwLoadData.ReportProgress(x)
                Threading.Thread.Sleep(Delay)

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        pbOhYeah.Visible = True
        Me.Cursor = Cursors.WaitCursor
        pbOhYeah.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        Try
            rgvList.DataSource = dtLoadData
            Me.Cursor = Cursors.Default
            pbOhYeah.Visible = False
            imBusy = False
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        Try
            bwLoadData.RunWorkerAsync()
            rgvList.Refresh()

        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Multiple Refresh", "Notification", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
        End Try

    End Sub

    '---------------------------------------'

    Private Sub rgvList_CellClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellClick
        frmMatrixExpenseTrans.GetData()
    End Sub

    Private Sub btnSaveBud_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnNewMatrix_Click(sender As Object, e As EventArgs) Handles btnNewMatrix.Click
        MatrixPicker = 1
        Try
            frmMatrixExpenseTrans.Show(Me)
            frmMatrixExpenseTrans.btnNewMatrix.Text = "Save"
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnEditMatrix_Click(sender As Object, e As EventArgs) Handles btnEditMatrix.Click
        MatrixPicker = 2
        Try
            frmMatrixExpenseTrans.Show(Me)
            frmMatrixExpenseTrans.btnNewMatrix.Text = "Update"
        Catch ex As Exception

        End Try

    End Sub
End Class