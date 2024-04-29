Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmRateLogsBC

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable

    Private Sub GetConRate()
       
    End Sub

    Private Sub frmRateLogsBC_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmRateLogsBC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '-----moveable form :)
        ReadyGrid()
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        dtLoadData = Chinita.fetchDBTable_BC("SELECT * FROM tblConversionRateLogs ORDER BY fldDate")
    End Sub

    Private Sub bwLoadData_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwLoadData.ProgressChanged
        Me.Cursor = Cursors.WaitCursor
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
        Me.Cursor = Cursors.Default
        imBusy = False
    End Sub

    Private Sub ReadyGrid()
        Dim fldBIDColumn As New GridViewDecimalColumn("ID")
        With fldBIDColumn
            .FieldName = "fldID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldBIDColumn)

        Dim fldDateColumn As New GridViewDateTimeColumn("DATE")
        With fldDateColumn
            .FieldName = "fldDate"
            .Width = 100
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy "
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDateColumn)
        rgvList.Columns("fldDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldTDateColumn As New GridViewDateTimeColumn("TRANSACTION DATE")
        With fldTDateColumn
            .FieldName = "fldTDate"
            .Width = 100
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy "
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldTDateColumn)
        rgvList.Columns("fldTDate").FormatString = "{0:MMM dd, yyyy}"

        Dim fldJPYColumn As New GridViewTextBoxColumn("JPY")
        With fldJPYColumn
            .FieldName = "fldJPY"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldJPYColumn)
        rgvList.Columns("fldJPY").FormatString = "{0:N6}"

        Dim fldPHPColumn As New GridViewTextBoxColumn("PHP")
        With fldPHPColumn
            .FieldName = "fldPHP"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldPHPColumn)
        rgvList.Columns("fldPHP").FormatString = "{0:N6}"

        Dim fldUSDColumn As New GridViewTextBoxColumn("USD")
        With fldUSDColumn
            .FieldName = "fldUSD"
            .Width = 110
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldUSDColumn)
        rgvList.Columns("fldUSD").FormatString = "{0:N6}"


        With rgvList
            '.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
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

End Class
