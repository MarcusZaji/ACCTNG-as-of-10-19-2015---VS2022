Imports System.Text.RegularExpressions
Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmModel
    Public linestat As String
    Public lineNo As Integer
    Private Sub FrmModel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
        ReadyGridImport()
    End Sub

    Private Sub FrmModel_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchModel()
        Activity()
    End Sub
    Public Sub FetchModel()
        Dim dtModel As DataTable = Zaji.dbSelect("SP_SelectAllModel")
        rgvList.DataSource = dtModel
    End Sub
    Public Sub Activity()
        Dim dtAct As DataTable = Zaji.dbSelect("SP_SelectAllActivity")
        ddlActivity.DataSource = dtAct
        ddlActivity.DisplayMember = "fldActivity"

    End Sub
    Private Sub ReadyGrid()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldMID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 50
            .AllowResize = False
            .IsPinned = Right
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldID)

        Dim fldActivity As New GridViewTextBoxColumn("ACTIVITY")
        With fldActivity
            .FieldName = "fldActivity"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvList.Columns.Add(fldActivity)


        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        With fldModel
            .FieldName = "fldModel"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvList.Columns.Add(fldModel)

        Dim fldDelete As New GridViewCommandColumn("DELETE")
        With fldDelete
            .FieldName = "DELETE"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "DELETE"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Right
        End With
        rgvList.Columns.Add(fldDelete)


        rgvList.AllowAddNewRow = False
        AddHandler rgvList.CommandCellClick, AddressOf CommandMe
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

        Dim fldActivity As New GridViewTextBoxColumn("ACTIVITY")
        With fldActivity
            .FieldName = "fldActivity"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvImport.Columns.Add(fldActivity)


        Dim fldModel As New GridViewTextBoxColumn("MODEL")
        With fldModel
            .FieldName = "fldModel"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 120
        End With
        rgvImport.Columns.Add(fldModel)
    End Sub
    Private Sub CommandMe()
        If rgvList.CurrentColumn.HeaderText = "DELETE" Then
            If RadMessageBox.Show("Are you sure you want to delete this model?",
                          "INFORMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                Zaji.addParameter("_MID", rgvList.CurrentRow.Cells("fldMID").Value.ToString)
                Zaji.dbAED("SP_DeleteModelbyID")
                RadMessageBox.Show("Activity has been deleted saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                FetchModel()
            End If

        End If

    End Sub



    Private Sub rgvList_CellDoubleClick(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellDoubleClick
        btnSave.Enabled = False
        btnUpdate.Enabled = True
        txtModel.Text = rgvList.CurrentRow.Cells("fldModel").Value.ToString
        ddlActivity.Text = rgvList.CurrentRow.Cells("fldActivity").Value.ToString
        globalVariables.MID = rgvList.CurrentRow.Cells("fldMID").Value.ToString
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrEmpty(ddlActivity.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Activity!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(txtModel.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Model!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            Zaji.addParameter("_MID", globalVariables.MID)
            Zaji.addParameter("Activity", ddlActivity.Text)
            Zaji.addParameter("Model", txtModel.Text)
            Zaji.dbAED("SP_UpdateModelbyID")
            RadMessageBox.Show("Successfully updated", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            btnSave.Enabled = True
            btnUpdate.Enabled = False
            FetchModel()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(ddlActivity.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Activity!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        ElseIf String.IsNullOrEmpty(txtModel.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Model!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        Else
            Zaji.addParameter("Activity", ddlActivity.Text)
            Zaji.addParameter("Model", txtModel.Text)
            Zaji.dbAED("SP_InsertModel")
            RadMessageBox.Show("Successfully saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            FetchModel()
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
        ImportModel()
    End Sub

    Public Sub ImportModel()
        Try
            rgvImport.DataSource = Nothing

            Dim table As DataTable = globalVariables.dtImport

            Dim Query As IEnumerable = (From T0 In table.AsEnumerable()
                                        Select New With
                                             {
                                                .fldActivity = Regex.Replace(Trim(T0.Item(0)), "\s+", " ").ToString(),
                                                .fldModel = Regex.Replace(Trim(T0.Item(1)), "\s+", " ").ToString()
                                            }).ToList
            rgvImport.DataSource = Query
        Catch ex As Exception
            MessageBox.Show("Error please contact MIS")
        End Try

    End Sub

    Private Sub btnSaveImport_Click(sender As Object, e As EventArgs) Handles btnSaveImport.Click
        bwUpload.RunWorkerAsync()
    End Sub

    Private Sub bwUpload_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwUpload.DoWork
        Dim delay As Integer = 30
        For counter As Integer = 0 To rgvImport.Rows.Count - 1

            Zaji.addParameter("Activity", Regex.Replace(rgvImport.Rows(counter).Cells("fldActivity").Value, "\s+", " "))
            Zaji.addParameter("Model", Regex.Replace(rgvImport.Rows(counter).Cells("fldModel").Value, "\s+", " "))
            If Zaji.dbAED("SP_InsertModel") Then
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

    Private Sub bwUpload_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles bwUpload.ProgressChanged
        rgvImport.CurrentRow = rgvImport.Rows(lineNo)
        rgvImport.CurrentRow.Cells(0).Value = linestat
        RadProgressBar1.Value1 = e.ProgressPercentage
    End Sub

    Private Sub bwUpload_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwUpload.RunWorkerCompleted
        RadProgressBar1.Text = "Done"
        RadProgressBar1.Value1 = 100
        RadMessageBox.Show("Successfully Uploaded", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
    End Sub
End Class
