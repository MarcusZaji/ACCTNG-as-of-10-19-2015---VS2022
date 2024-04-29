Imports Telerik.WinControls

Public Class FrmUpdatePOI
    Private Sub FrmUpdatePOI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If String.IsNullOrEmpty(ddlItemUOM.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Code", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        ElseIf String.IsNullOrEmpty(txtIMDesc.Text) Then
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Incomplete Input. No Item Description", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)

        Else

            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("Unit", ddlItemUOM.Text)
            Zaji.addParameter("_Desc", txtIMDesc.Text)
            Zaji.dbAED("SP_UpdatePOIByID")
            RadMessageBox.Show("Successfully Updated", "INFORMATION", MessageBoxButtons.OK, RadMessageIcon.Info)

        End If
    End Sub
End Class
