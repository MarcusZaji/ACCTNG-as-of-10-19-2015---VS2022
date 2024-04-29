Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class Activity
    Private Sub Activity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
    End Sub

    Private Sub Activity_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        FetchActivity()
    End Sub
    Public Sub FetchActivity()

        Dim DtActivity As DataTable = Zaji.dbSelect("SP_SelectAllActivity")
        rgvList.DataSource = DtActivity
    End Sub
    Private Sub ReadyGrid()

        Dim fldID As New GridViewTextBoxColumn("ID")
        With fldID
            .FieldName = "fldAID"
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
            .Width = 200
        End With
        rgvList.Columns.Add(fldActivity)


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
    Private Sub CommandMe()
        If rgvList.CurrentColumn.HeaderText = "DELETE" Then
            If RadMessageBox.Show("Are you sure you want to delete this Activity?",
                          "INFORMATION", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then
                Zaji.addParameter("AID", rgvList.CurrentRow.Cells("fldAID").Value.ToString)
                Zaji.dbAED("SP_DeleteActivitybyID")
                RadMessageBox.Show("Activity has been deleted saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
                FetchActivity()
            End If

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrEmpty(txtActivity.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Activity!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("Activity", txtActivity.Text)
            Zaji.dbAED("SP_InsertActivity")
            RadMessageBox.Show("Successfully saved", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)
            FetchActivity()
        End If
    End Sub
End Class
