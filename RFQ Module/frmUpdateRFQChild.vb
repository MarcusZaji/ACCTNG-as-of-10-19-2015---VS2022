Imports System.Text.RegularExpressions
Imports Telerik.WinControls

Public Class FrmUpdateRFQChild
    Private Sub FrmUpdateRFQChild_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If RadMessageBox.Show("Are you sure want to update this data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then
            If txtDesc.Text Is Nothing Then
                RadMessageBox.Show("No Prepared by", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            If mebQTY.Value = 0.00 Then
                RadMessageBox.Show("Zero QTY not vallid", "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
                Exit Sub
            End If
            Zaji.addParameter("ID", Regex.Replace(Trim(txtID.Text), "\s+", " "))
            Zaji.addParameter("_Desc", Regex.Replace(Trim(txtDesc.Text), "\s+", " "))
            Zaji.addParameter("QTY", Regex.Replace(Trim(mebQTY.Text), "\s+", " "))
            Zaji.addParameter("UOM", Regex.Replace(Trim(ddlUOM.Text), "\s+", " "))
            Zaji.addParameter("Remarks", Regex.Replace(Trim(txtRemarks.Text), "\s+", " "))
            Zaji.dbAED("SP_UpdateRFQPurChildbyID")

            RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub

End Class
