Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.Export
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export

Public Class FrmItemNonRM
    Public linestat As String
    Public lineNo As Integer
    Private Sub FrmItemNonRM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        ReadyGridImport()
    End Sub

    Private Sub FrmItemNonRM_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchRate()
    End Sub
    Public Sub FetchRate()

        Dim DTSBud As DataTable = Zaji.dbSelect("SP_SelectAllItemNonRM")
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

        Dim fldItemNo As New GridViewTextBoxColumn("ITEM CODE")
        With fldItemNo
            .FieldName = "fldItemNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvImport.Columns.Add(fldItemNo)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDesc
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 300
            .AllowResize = False
        End With
        rgvImport.Columns.Add(fldDesc)
    End Sub
    Private Sub ReadyGrid()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldIID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldID)

        Dim fldItemNo As New GridViewTextBoxColumn("ITEM CODE")
        With fldItemNo
            .FieldName = "fldItemNo"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 150
        End With
        rgvList.Columns.Add(fldItemNo)

        Dim fldDesc As New GridViewTextBoxColumn("DESCRIPTION")
        With fldDesc
            .FieldName = "fldDesc"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 450
            .AllowResize = False
        End With
        rgvList.Columns.Add(fldDesc)

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

        rgvList.EnableFiltering = True
        AddHandler rgvList.CommandCellClick, AddressOf UpdateMe
    End Sub
    Private Sub UpdateMe()
        If rgvList.CurrentColumn.HeaderText = "UPDATE" Then

            Zaji.addParameter("ItemNo", txtItemCode.Text)
            Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckItemNonRM")

            If DTCheck.Rows.Count = 1 Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Item Already Exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)
            Else

                Try
                    txtID.Text = rgvList.CurrentRow.Cells("fldIID").Value.ToString
                    txtItemCode.Text = rgvList.CurrentRow.Cells("fldItemNo").Value.ToString
                    txtIMDesc.Text = rgvList.CurrentRow.Cells("fldDesc").Value.ToString

                    txtItemCode.Enabled = False
                    btnUpdate.Enabled = True
                    btnSave.Enabled = False
                Catch ex As Exception

                End Try
            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Zaji.addParameter("ItemNo", txtItemCode.Text)
        Dim DTCheck As DataTable = Zaji.dbSelect("SP_CheckItemNonRM")

        If DTCheck.Rows.Count = 1 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Item Already Exist", "Warning", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtItemCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Code", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Description", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("ItemNo", txtItemCode.Text)
            Zaji.addParameter("_Desc", txtIMDesc.Text)
            Zaji.dbAED("SP_InsertItemNonRM")

            FetchRate()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(txtItemCode.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Code", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Description", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("ItemNo", txtItemCode.Text)
            Zaji.addParameter("_Desc", txtIMDesc.Text)
            Zaji.dbAED("SP_UpdateItemNonRM")
            FetchRate()
            txtItemCode.Enabled = True
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
        ImportNonRM()

    End Sub
    Public Sub ImportNonRM()
        Try
            rgvImport.DataSource = Nothing

            Dim table As DataTable = globalVariables.dtImport

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                                .fldItemNo = Regex.Replace(Trim(T0.Item(0)), "\s+", " ").ToString(),
                                                .fldDesc = Regex.Replace(Trim(T0.Item(1)), "\s+", " ")
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

            Zaji.addParameter("ItemNo", Regex.Replace(rgvImport.Rows(counter).Cells("fldItemNo").Value, "\s+", " "))
            Zaji.addParameter("_Desc", Regex.Replace(rgvImport.Rows(counter).Cells("fldDesc").Value, "\s+", " "))

            If Zaji.dbAED("SP_InsertItemNonRM") Then
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
