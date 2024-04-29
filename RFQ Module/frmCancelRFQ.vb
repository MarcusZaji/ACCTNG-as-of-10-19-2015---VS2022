Imports Telerik.WinControls

Public Class FrmCancelRFQ
    Private Sub FrmCancelRFQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtRFQNo.Text = globalVariables.RFQNo
        txtID.Text = globalVariables.RFQID
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If RadMessageBox.Show("Are you sure want to cancel this data?", "Confirmation", MessageBoxButtons.YesNo, RadMessageIcon.Question) = DialogResult.Yes Then

            Zaji.addParameter("ID", txtID.Text)
            Zaji.addParameter("Reason", txtReason.Text)
            Zaji.dbAED("SP_CancelRFQbyID")

            FrmViewRFQPur.ViewRFQDesc()

            RadMessageBox.Show("Record successfully updated", "information", MessageBoxButtons.OK, RadMessageIcon.Info)
        End If
    End Sub
End Class
