Imports System.ComponentModel
Imports Telerik.WinControls.Data
Imports Telerik.WinControls.UI

Public Class FrmHomeNew
    Private Sub FrmHomeNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        rlvMenu.ViewType = ListViewType.IconsView
        rlvMenu.EnableGrouping = True
        rlvMenu.ShowGroups = True
        rlvMenu.ItemSize = New Size(200, 75)

        Dim groupByValue As New GroupDescriptor(New SortDescriptor() {New SortDescriptor("Group", ListSortDirection.Ascending)})
        rlvMenu.GroupDescriptors.Add(groupByValue)
    End Sub

    Private Sub rlvMenu_SelectedItemChanged(sender As Object, e As EventArgs) Handles rlvMenu.SelectedItemChanged

    End Sub
End Class
