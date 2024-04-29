Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmAddEtc

    Dim moveCtrl As MoveControl = Nothing
    Private dtLoadData As DataTable
    Private dtLoadData2 As DataTable
    Private dtLoadData3 As DataTable
    Private dtLoadData4 As DataTable
    Private picker As Integer
    Private deletepicker As Integer

    Private Sub frmAddEtc_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frmAddEtc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moveCtrl = New MoveControl(Me) '----- MOVEABLE FORM -----'

        RefreshGrid()

        rgvList.DataSource = dtLoadData

        If frmMain.lblAccesslvl.Text = "SUPERADMIN" Then
            btnDeleteEtc.Visible = True
        Else
            btnDeleteEtc.Visible = False
        End If
    End Sub

    Private Sub frmAddEtc_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
    End Sub

    Private Sub RefreshGrid()

        If picker = 1 Then
            rgvList.Columns.Clear()

            dtLoadData = Chinita.fetchDBTable("SELECT fldCCode, fldCLassCode, fldClassDesc from tblClass")

            ReadyGridClass()
            rgvList.DataSource = dtLoadData

        ElseIf picker = 2 Then
            rgvList.Columns.Clear()

            dtLoadData2 = Chinita.fetchDBTable("SELECT fldDeptID, fldDeptCode, fldDeptDesc from tblDepartment")

            ReadyGridDept()
            rgvList.DataSource = dtLoadData2

        ElseIf picker = 3 Then
            rgvList.Columns.Clear()

            dtLoadData3 = Chinita.fetchDBTable("SELECT fldPCode, fldProcessCode, fldProcessDesc from tblProcess")

            ReadyGridProcess()
            rgvList.DataSource = dtLoadData3

        ElseIf picker = 4 Then
            rgvList.Columns.Clear()

            dtLoadData4 = Chinita.fetchDBTable("SELECT fldSCID, fldSCCode, fldSCDesc from tblClassPPE")

            ReadyGridSubClass()
            rgvList.DataSource = dtLoadData4

        End If

    End Sub

    Private Sub ReadyGridSubClass()

        Dim fldCIDColumn As New GridViewDecimalColumn("ID")
        With fldCIDColumn
            .FieldName = "fldSCID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCIDColumn)

        Dim fldCatCodeColumn As New GridViewTextBoxColumn("SUB CLASS CODE")
        With fldCatCodeColumn
            .FieldName = "fldSCCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCatCodeColumn)

        Dim fldCatDescColumn As New GridViewTextBoxColumn("SUB CLASS DESCRIPTION")
        With fldCatDescColumn
            .FieldName = "fldSCDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldCatDescColumn)

        With rgvList
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub ReadyGridProcess()

        Dim fldCIDColumn As New GridViewDecimalColumn("ID")
        With fldCIDColumn
            .FieldName = "fldPCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCIDColumn)

        Dim fldClassCodeColumn As New GridViewTextBoxColumn("PROCESS CODE")
        With fldClassCodeColumn
            .FieldName = "fldProcessCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassCodeColumn)

        Dim fldClassDescColumn As New GridViewTextBoxColumn("PROCESS DESCRIPTION")
        With fldClassDescColumn
            .FieldName = "fldProcessDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassDescColumn)

        With rgvList
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub ReadyGridDept()

        Dim fldCIDColumn As New GridViewDecimalColumn("ID")
        With fldCIDColumn
            .FieldName = "fldDeptID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCIDColumn)

        Dim fldClassCodeColumn As New GridViewTextBoxColumn("DEPARTMENT CODE")
        With fldClassCodeColumn
            .FieldName = "fldDeptCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassCodeColumn)

        Dim fldClassDescColumn As New GridViewTextBoxColumn("DEPARTMENT DESCRIPTION")
        With fldClassDescColumn
            .FieldName = "fldDeptDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassDescColumn)

        With rgvList
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub ReadyGridClass()

        Dim fldCIDColumn As New GridViewDecimalColumn("ID")
        With fldCIDColumn
            .FieldName = "fldCCode"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCIDColumn)

        Dim fldClassCodeColumn As New GridViewTextBoxColumn("CLASSIFICATION CODE")
        With fldClassCodeColumn
            .FieldName = "fldClassCode"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassCodeColumn)

        Dim fldClassDescColumn As New GridViewTextBoxColumn("CLASSIFICATION DESCRIPTION")
        With fldClassDescColumn
            .FieldName = "fldClassDesc"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldClassDescColumn)

        With rgvList
            .AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill
            .EnableAlternatingRowColor = True
            '.EnableFiltering = True
            .ShowFilteringRow = True
            '.ShowGroupPanel = True
            '.EnableGrouping = True

            .AllowRowReorder = True
            .MultiSelect = False
            .AllowRowResize = False
            .AllowAddNewRow = False
        End With

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub rbAddClass_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbAddClass.ToggleStateChanged
        picker = 1
        RefreshGrid()

        txtActivityCode.Enabled = False
    End Sub

    Private Sub rbAddDept_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbAddDept.ToggleStateChanged
        picker = 2
        RefreshGrid()

        txtActivityCode.Enabled = True
    End Sub

    Private Sub rbAddProcess_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbAddProcess.ToggleStateChanged
        picker = 3
        RefreshGrid()

        txtActivityCode.Enabled = False
    End Sub

    Private Sub rbAddSC_ToggleStateChanged(sender As Object, args As StateChangedEventArgs) Handles rbAddSC.ToggleStateChanged
        picker = 4
        RefreshGrid()

        txtActivityCode.Enabled = False
    End Sub

    Private Sub clear()
        txtAddCode.Text = ""
        txtAddDesc.Text = ""
    End Sub

    Private Sub btnAddEtc_Click(sender As Object, e As EventArgs) Handles btnAddEtc.Click

        If String.IsNullOrEmpty(txtAddCode.Text & txtAddDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Null Input is invalid.", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            If picker = 1 Then
                If BabyGirl.AddClass(txtAddCode.Text, txtAddDesc.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Classification Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                    clear()
                    RefreshGrid()
                    txtAddCode.Focus()
                End If

            ElseIf picker = 2 Then
                If String.IsNullOrEmpty(txtActivityCode.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Null Input is invalid.", "Invalid Input", MessageBoxButtons.OK, RadMessageIcon.Info)

                Else
                    If BabyGirl.AddDept(txtAddCode.Text, txtAddDesc.Text, txtActivityCode.Text) Then
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("Department Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                        clear()
                        RefreshGrid()
                        txtAddCode.Focus()
                    End If
                End If

            ElseIf picker = 3 Then
                If BabyGirl.AddProcess(txtAddCode.Text, txtAddDesc.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Process Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                    clear()
                    RefreshGrid()
                    txtAddCode.Focus()
                End If

            ElseIf picker = 4 Then
                If BabyGirl.AddSubClass(txtAddCode.Text, txtAddDesc.Text) Then
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("Sub Class Added!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                    clear()
                    RefreshGrid()
                    txtAddCode.Focus()
                End If

            End If
        End If

    End Sub

    Private Sub btnDeleteEtc_Click(sender As Object, e As EventArgs) Handles btnDeleteEtc.Click

        If picker = 1 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this Classification?",
                            "Delete Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BabyGirl.DeleteClass(rgvList.CurrentRow.Cells("fldCCode").Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Classification Deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                RefreshGrid()
            End If

        ElseIf picker = 2 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this Department?",
                            "Delete Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BabyGirl.DeleteDept(rgvList.CurrentRow.Cells("fldDeptID").Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Department Deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                RefreshGrid()
            End If

        ElseIf picker = 3 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this Process?",
                            "Delete Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BabyGirl.DeleteProcess(rgvList.CurrentRow.Cells("fldPCode").Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Process Deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                RefreshGrid()
            End If

        ElseIf picker = 3 Then
            RadMessageBox.SetThemeName("Windows8")
            If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this Sub Class?",
                            "Delete Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                BabyGirl.DeleteSubClass(rgvList.CurrentRow.Cells("fldSCID").Value)
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Sub Class Deleted!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
                RefreshGrid()
            End If

        End If

    End Sub

End Class
