Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.UI.Export
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls.Data

Public Class frmIM

    Dim moveCtrl As MoveControl = Nothing
    Dim dtLoadData As DataTable

    Private Sub frmIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moveCtrl = New MoveControl(Me) '----- MOVEABLE FORM -----'

        ReadyGrid()

        ItemCategory()
        ddlCat.Text = ""

        '----- GET USERNAME FOR SIGNATURE -----'
        Dim drUser As DataRow = Chinita.fetchMySqlRow("SELECT * FROM tblUser WHERE fldUID = '" & frmMain.lblId.Text & "'")
        txtSignature.Text = drUser.Item("fldDept").ToString + "-" + drUser.Item("fldName").ToString

    End Sub

    Private Sub frmIM_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        imBusy = False
        bwLoadData.RunWorkerAsync()
    End Sub

    Private Sub bwLoadData_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bwLoadData.RunWorkerCompleted
        rgvList.DataSource = dtLoadData
    End Sub

    Private Sub bwLoadData_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bwLoadData.DoWork
        dtLoadData = Chinita.fetchDBTable("SELECT fldIMID, fldIMItemCode, fldIMItemDesc, fldIMCat, fldIMUOM, fldStat, fldSignature from tblIM where fldStat = 'OPEN'")
    End Sub

    Private Sub ReadyGrid()

        Dim fldIMIDColumn As New GridViewDecimalColumn("ID")
        With fldIMIDColumn
            .FieldName = "fldIMID"
            .ReadOnly = True
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 30
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldIMIDColumn)

        Dim fldItemCodeColumn As New GridViewTextBoxColumn("ITEM CODE")
        With fldItemCodeColumn
            .FieldName = "fldIMItemCode"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldItemCodeColumn)

        Dim fldIMItemDesc As New GridViewTextBoxColumn("ITEM DESCRIPTION")
        With fldIMItemDesc
            .FieldName = "fldIMItemDesc"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldIMItemDesc)

        Dim fldIMCatColumn As New GridViewTextBoxColumn("ITEM CATEGORY")
        With fldIMCatColumn
            .FieldName = "fldIMCat"
            .Width = 140
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldIMCatColumn)

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
            '.SummaryRowsBottom.Add(SummaryRowItem)
        End With

    End Sub

    Private Sub Clear()

        ddlCat.Text = ""
        txtIC.Text = ""
        txtItemDesc.Text = ""
        ddlItemUOM.Text = ""

    End Sub

    Private Sub lblBack_Click(sender As Object, e As EventArgs) Handles lblBack.Click
        Me.Close()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "select (Select fldIMItemCode from tblIM where fldIMItemCode = '" & txtIC.Text & "') as CheckIM"

        myCmd.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("CheckIM").ToString

        '------------------------------------------------------------
        If String.IsNullOrEmpty(ddlCat.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Category. Please Select One", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtIC.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Code. Please Check Input", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(txtItemDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Item Code Description. Please Check Input", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        ElseIf String.IsNullOrEmpty(ddlItemUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("No Unit of Measurement Selected. Please Select One", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Error)

        Else

            If txtIC.Text = x Then
                RadMessageBox.Show("Item Code Already Exist, Please Check Input", "Notification", MessageBoxButtons.OK)
                Exit Sub
            End If

            BabyGirl.AddIMItem(ddlCat.Text, txtIC.Text, txtItemDesc.Text, ddlItemUOM.Text, "OPEN", txtSignature.Text)
            RadMessageBox.SetThemeName("Windows8Theme1")
            RadMessageBox.Show("Item Code Added!", "Notification", MessageBoxButtons.OK)
            Clear()
            bwLoadData.RunWorkerAsync()
            txtIC.Focus()

        End If

    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click

        If RadMessageBox.Show("WARNING. This operation is irreversable. Are you sure you want to delete this Item Code?", _
                                   "Delete Item", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
            BabyGirl.DeleteIM(rgvList.CurrentRow.Cells("fldIMID").Value)
            RadMessageBox.Show("Item Code Deleted!", "Notification", MessageBoxButtons.OK)
            Clear()
            bwLoadData.RunWorkerAsync()
        End If

    End Sub

End Class
