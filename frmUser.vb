Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmUser

    Dim moveCtrl As MoveControl = Nothing
    Private UID As String
    Private RowIndex As Integer = Nothing
    Private dtLoadData As DataTable

    Private Sub frmUser_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub FrmUser_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
        bwLoadData.RunWorkerAsync()

    End Sub

    Private Sub frmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) 'moveable form :)

        DepartmentUser()

        UID = SelectedDetails
        ReadyGrid()

        Clear()

    End Sub

    Private Sub GetUser()
        

    End Sub

    Private Sub Clear()

        btnAdd.Enabled = False

        txtName.Text = ""
        txtUN.Text = ""
        txtPW.Text = ""
        txtconPW.Text = ""
        ddlDept.Text = ""
        ddlUserlvl.Text = ""

    End Sub

    Private Sub ReadyUpdate()

        Try
            txtName.Text = rgvList.CurrentRow.Cells("fldName").Value.ToString
            txtUN.Text = rgvList.CurrentRow.Cells("fldUsername").Value.ToString
            'txtPW.Text = rgvList.CurrentRow.Cells("fldPassword").Value.ToString
            'txtconPW.Text = rgvList.CurrentRow.Cells("fldPassword").Value.ToString
            ddlDept.Text = rgvList.CurrentRow.Cells("fldDept").Value.ToString
            ddlUserlvl.Text = rgvList.CurrentRow.Cells("fldUserlvl").Value.ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ReadyGrid()
        Dim fldIDColumn As New GridViewDecimalColumn("ID")
        With fldIDColumn
            .FieldName = "fldUID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldIDColumn)

        Dim fldUsernameColumn As New GridViewTextBoxColumn("USERNAME")
        With fldUsernameColumn
            .FieldName = "fldUsername"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldUsernameColumn)

        Dim fldNameColumn As New GridViewTextBoxColumn("NAME")
        With fldNameColumn
            .FieldName = "fldName"
            .Width = 200
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldNameColumn)

        Dim fldUserlvlColumn As New GridViewComboBoxColumn("USER LEVEL")
        With fldUserlvlColumn
            .FieldName = "fldUserlvl"
            fldUserlvlColumn.Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"USER", _
                                          "MANAGER", _
                                          "PROFESSIONAL", _
                                          "ADMINISTRATOR", _
                                          "SUPERADMIN"}
        End With
        rgvList.Columns.Add(fldUserlvlColumn)

        Dim fldDeptColumn As New GridViewComboBoxColumn("DEPARTMENT")
        With fldDeptColumn
            .FieldName = "fldDept"
            .Width = 120
            .TextAlignment = ContentAlignment.MiddleCenter
            .DropDownStyle = RadDropDownStyle.DropDownList
            .DataSource = New [String]() {"PRESIDENT", _
                                          "HRGA", _
                                          "ACCTG", _
                                          "LOG", _
                                          "EVAL", _
                                          "FACILITY", _
                                          "ENGG", _
                                          "PROD", _
                                          "PC", _
                                          "QA", _
                                          "WH", _
                                          "FAB", _
                                          "FFCLAMI", _
                                          "PROJECT", _
                                          "COMMON"}
        End With
        rgvList.Columns.Add(fldDeptColumn)

        Dim fldDateAddedColumn As New GridViewDateTimeColumn("DATE ADDED")
        With fldDateAddedColumn
            .FieldName = "fldDateAdded"
            .Width = 90
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDateAddedColumn)
        rgvList.Columns("fldDateAdded").FormatString = "{0:MMM dd, yyyy}"

        With rgvList
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            .EnableFiltering = True
            .ShowFilteringRow = False
            .ShowGroupPanel = False

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        dtLoadData = Chinita.fetchDBTable("SELECT * FROM tblUser")
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim USuperAdmin As String = rgvList.CurrentRow.Cells("fldUserlvl").Value.ToString

        RadMessageBox.SetThemeName("Windows8")
        If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this user?",
                              "Delete User", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

            If USuperAdmin = "SUPERADMIN" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Cannot Delete this User.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

            Else
                Tomboy.DeleteUser(rgvList.CurrentRow.Cells("fldUID").Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("User '" & rgvList.CurrentRow.Cells("fldUsername").Value.ToString & "' successfully deleted", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End If
            bwLoadData.RunWorkerAsync()
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim match = String.Compare(txtPW.Text, txtconPW.Text, ignoreCase:=False)

        If String.IsNullOrEmpty(txtUN.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Null username is invalid.", "Invalid Username", MessageBoxButtons.OK, RadMessageIcon.Error)
        ElseIf Not match = 0 Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("The same password should be entered in both fields. Please re-enter the password correctly.", "Password Mismatch", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else
            If Tomboy.AddUser(txtUN.Text, Chinita.getMD5Hash(txtPW.Text), txtName.Text, ddlUserlvl.Text, ddlDept.Text) Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("User Added!", "Notification", MessageBoxButtons.OK)
                Clear()
                bwLoadData.RunWorkerAsync()
                btnAdd.Enabled = True

            End If
        End If

    End Sub

    Private Sub RadLabel7_Click(sender As Object, e As EventArgs) Handles RadLabel7.Click
        frmMain.Show()
        Me.Close()
    End Sub

    '----GRID----
    Private cellOriginalValue As String

    Private Sub rgvList_CellBeginEdit(sender As Object, e As GridViewCellCancelEventArgs) Handles rgvList.CellBeginEdit
       Try
            Dim USuperAdmin As String = rgvList.CurrentRow.Cells("fldUserlvl").Value.ToString

            If USuperAdmin = "SUPERADMIN" Then
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Cannot Edit this User.", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                Exit Sub
            Else
                Try
                    cellOriginalValue = rgvList.CurrentCell.Value.ToString
                Catch ex As Exception

                End Try

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub rgvList_CellEndEdit(sender As Object, e As GridViewCellEventArgs) Handles rgvList.CellEndEdit
        Dim USuperAdmin As String = rgvList.CurrentRow.Cells("fldUserlvl").Value.ToString

        If String.IsNullOrEmpty(rgvList.CurrentRow.Cells("fldUsername").Value.ToString) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Null username is invalid.", "Invalid Username", MessageBoxButtons.OK, RadMessageIcon.Error)
            rgvList.CurrentCell.Value = cellOriginalValue

        Else
            If Not Tomboy.UpdateUser(rgvList.CurrentRow.Cells("fldUID").Value, _
                                     rgvList.CurrentRow.Cells("fldUsername").Value.ToString, _
                                     rgvList.CurrentRow.Cells("fldName").Value.ToString, _
                                     rgvList.CurrentRow.Cells("fldDept").Value.ToString, _
                                     rgvList.CurrentRow.Cells("fldUserlvl").Value.ToString) Then
                rgvList.CurrentCell.Value = cellOriginalValue
            End If
        End If

    End Sub

    Private Sub rgvList_FilterChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.FilterChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub rgvList_RowsChanged(sender As Object, e As GridViewCollectionChangedEventArgs) Handles rgvList.RowsChanged
        leRecordCount.Text = rgvList.ChildRows.Count.ToString
    End Sub

    Private Sub btnChangePW_Click(sender As Object, e As EventArgs) Handles btnChangePW.Click
        ChangePassword()
    End Sub

    Private Sub ChangePassword()
        If Chinita.isOpenForm(FrmChangePW) Then
            FrmChangePW.txtPW.Focus()
        Else
            frmsplash.busy()
            FrmChangePW.lblID.Text = rgvList.CurrentRow.Cells("fldUID").Value.ToString
            FrmChangePW.Show(Me)
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If String.IsNullOrEmpty(txtName.Text) Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If

    End Sub

End Class

