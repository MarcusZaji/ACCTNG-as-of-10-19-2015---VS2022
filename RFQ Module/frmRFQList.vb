Imports Telerik.WinControls
Imports Telerik.WinControls.UI

Public Class FrmRFQList
    Private Sub FrmRFQList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadyGrid()
    End Sub
    Private Sub FrmRFQList_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'getEmployeeRec()
        GetRFQList()
        If (globalVariables.LoginRFQ = "YES") Then
            btnRFQPur.Visible = True
            btnViewRFQ.Visible = True
        Else
            btnRFQPur.Visible = False
        End If
    End Sub
    Private Sub ReadyGrid()
        Dim fldNo As New GridViewTextBoxColumn("RFQ No")
        With fldNo
            .FieldName = "fldRFQNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldNo)

        Dim RFQNo As New GridViewTextBoxColumn("RFQ No")
        With RFQNo
            .FieldName = "RFQNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(RFQNo)

        Dim fldDateRequest As New GridViewDateTimeColumn("Date Request")
        With fldDateRequest
            .FieldName = "fldDateRequest"
            .Width = 120
            .Format = DateTimePickerFormat.Custom
            .CustomFormat = "MMM dd, yyyy"
            .TextAlignment = ContentAlignment.MiddleCenter
            .ReadOnly = True
        End With
        rgvList.Columns.Add(fldDateRequest)
        rgvList.Columns("fldDateRequest").FormatString = "{0:MMM dd, yyyy}"

        Dim fldEmpNo As New GridViewTextBoxColumn("Emp. No")
        With fldEmpNo
            .FieldName = "fldEmpNo"
            .Width = 100
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldEmpNo)

        Dim fldEmpName As New GridViewTextBoxColumn("Name")
        With fldEmpName
            .FieldName = "fldEmpName"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldEmpName)

        Dim fldSection As New GridViewTextBoxColumn("Section")
        With fldSection
            .FieldName = "fldSection"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldSection)

        Dim fldDept As New GridViewTextBoxColumn("Department")
        With fldDept
            .FieldName = "fldDept"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
        End With
        rgvList.Columns.Add(fldDept)

        Dim fldCheckedBy As New GridViewTextBoxColumn("Checked By")
        With fldCheckedBy
            .FieldName = "fldCheckedBy"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCheckedBy)

        Dim fldApprovedBy As New GridViewTextBoxColumn("Approved By")
        With fldApprovedBy
            .FieldName = "fldApprovedBy"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldApprovedBy)

        Dim fldCPosition As New GridViewTextBoxColumn("Checked Position")
        With fldCPosition
            .FieldName = "fldCPosition"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldCPosition)

        Dim fldAPosition As New GridViewTextBoxColumn("Approved Position")
        With fldAPosition
            .FieldName = "fldAPosition"
            .Width = 150
            .TextAlignment = ContentAlignment.MiddleCenter
            .IsVisible = False
        End With
        rgvList.Columns.Add(fldAPosition)

        Dim View As New GridViewCommandColumn("View RFQ")
        With View
            .FieldName = "View"
            .TextAlignment = ContentAlignment.MiddleCenter
            .Width = 70
            .IsVisible = True
            .DefaultText = "View"
            .UseDefaultText = True
            .PinPosition = PinnedColumnPosition.Left
        End With
        rgvList.Columns.Add(View)

        AddHandler rgvList.CommandCellClick, AddressOf ViewItem

    End Sub
    Private Sub ViewItem()
        If rgvList.CurrentColumn.HeaderText = "View RFQ" Then
            Try

                globalVariables.RFQNo = rgvList.CurrentRow.Cells("RFQNo").Value.ToString
                FrmRFQ.txtID.Text = rgvList.CurrentRow.Cells("fldRFQNo").Value.ToString
                globalVariables.CheckedBy = rgvList.CurrentRow.Cells("fldCheckedBy").Value.ToString
                globalVariables.ApprovedBy = rgvList.CurrentRow.Cells("fldApprovedBy").Value.ToString
                globalVariables.DateRequest = rgvList.CurrentRow.Cells("fldDateRequest").Value.ToString
                globalVariables.CPosition = rgvList.CurrentRow.Cells("fldCPosition").Value.ToString
                globalVariables.APosition = rgvList.CurrentRow.Cells("fldAPosition").Value.ToString

                FrmRFQ.Show(Me)
            Catch ex As Exception
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
            End Try
        End If
    End Sub
    Public Sub GetRFQList()
        Zaji.addParameter("Dept", globalVariables.Dept)
        Zaji.addParameter("Section", globalVariables.Section)
        Dim dtRFQRec As DataTable = Zaji.dbSelect("SP_SelectRFQBySecDept")
        rgvList.DataSource = dtRFQRec
    End Sub

    Private Sub btnAddRFQ_Click(sender As Object, e As EventArgs) Handles btnAddRFQ.Click
        Try
            FrmRFQ.txtRFQNo.Text = ""
            FrmRFQ.txtID.Text = ""
            FrmRFQ.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub btnRFQPur_Click(sender As Object, e As EventArgs) Handles btnRFQPur.Click
        Try
            FrmRFQPur.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub

    Private Sub btnViewRFQ_Click(sender As Object, e As EventArgs) Handles btnViewRFQ.Click
        Try
            FrmViewRFQPur.Show(Me)
        Catch ex As Exception
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Form Already Open!", "Notification", MessageBoxButtons.OK, RadMessageIcon.Info)
        End Try
    End Sub
End Class
