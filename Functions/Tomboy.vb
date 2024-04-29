Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports System.Text

'-------------------------------------'
'---- ADD UPDATE DELETE ON MODULE ----'
'-------------------------------------'

Public Class Tomboy
    'ADD USER
    Shared Function AddUser(ByVal Username As String, _
                            ByVal Password As String, _
                            ByVal Name As String, _
                            ByVal Userlvl As String, _
                            ByVal Dept As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblUser (fldUsername,fldPassword,fldName,fldUserlvl,fldDept,fldDateAdded) " _
                & "VALUES (@fldUsername,@fldPassword,@fldName,@fldUserlvl,@fldDept,@fldDateAdded)"

            With myCmd.Parameters
                .AddWithValue("@fldUsername", Username)
                .AddWithValue("@fldPassword", Password)
                .AddWithValue("@fldName", Name)
                .AddWithValue("@fldUserlvl", Userlvl)
                .AddWithValue("@fldDept", Dept)
                .AddWithValue("@fldDateAdded", Today)
            End With

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateUser(ByVal UID As Integer, _
                               ByVal Username As String, _
                               ByVal Name As String, _
                               ByVal Dept As String, _
                               ByVal Userlvl As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        'UPDATE USER - GRID
        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE tblUser SET fldUsername=@fldUsername,fldName=@fldName,fldDept=@fldDept,fldUserlvl=@fldUserlvl WHERE fldUID=@fldUID"

            With myCmd.Parameters
                .AddWithValue("@fldUID", UID)
                .AddWithValue("@fldUsername", Username)
                .AddWithValue("@fldName", Name)
                .AddWithValue("@fldDept", Dept)
                .AddWithValue("@fldUserlvl", Userlvl)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    'DELETE USER
    Shared Function DeleteUser(ByVal ID As Integer) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "DELETE FROM tblUser WHERE fldUID=@fldUID"
            myCmd.Parameters.AddWithValue("@fldUID", ID)
            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    '--------- CHANGE PASSWORD ---------'

    Shared Function ChangePassword(ByVal ID As Integer, ByVal Password As String) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE tblUser SET fldPassword=@fldPassword WHERE fldUID=@fldUID"
            myCmd.Parameters.AddWithValue("@fldUID", ID)
            myCmd.Parameters.AddWithValue("@fldPassword", Password)
            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function
    '-------------------------'
    '---------Cancel INVESTMENT----------'
    '-------------------------'

    '-----Cancel INVESTMENT-----'
    Shared Function CancelInvestment(ByRef ID As String) As Boolean
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        conn.Open()
        Try
            myCmd.Connection = conn

            myCmd.CommandText = "call CancelInvestment(@ID)"

            With myCmd
                .Parameters.AddWithValue("@ID", ID)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success
    End Function

    '-------------------------'
    '---------UPDATE INVESTMENT----------'
    '-------------------------'

    '-----UPDATE INVESTMENT-----'
    Shared Function UpdateInvesment(ByVal IID As String, _
                              ByVal IYear As String, _
                              ByVal Dept As String, _
                              ByVal IDate As Date, _
                              ByVal ProjTitle As String, _
                              ByVal Details As String, _
                              ByVal Currency As String, _
                              ByVal CivilWorks As Decimal, _
                              ByVal MechanicalWork As Decimal, _
                              ByVal ElecWorks As Decimal, _
                              ByVal Others As Decimal, _
                              ByVal ProdCostOrg As Decimal, _
                              ByVal ProdCostJPY As Decimal, _
                              ByVal ApprovedBudget As Decimal, _
                              ByVal DateInstallation As Date, _
                              ByVal DateCompletion As Date, _
                              ByVal PreparedBy As String, _
                              ByVal BudRefNum As String, _
                              ByVal InvestmentType As String, _
                              ByVal ExistingMachine As String, _
                              ByVal Depreciation As Date, _
                              ByVal Status As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        conn.Open()
        Try
            myCmd.Connection = conn

            myCmd.CommandText = "call SP_UpdateInvestment(@IID,@IYear,@Dept,@IDate,@ProjTitle,@Details,@Currency,@CivilWorks," _
                & "@MechanicalWork,@ElecWorks,@Others,@ProdCostOrg,@ProdCostJPY,@ApprovedBudget,@DateInstallation,@DateCompletion,@PreparedBy,@BudRefNum," _
                & "@InvestmentType,@ExistingMachine,@Depreciation,@Status)"

            With myCmd
                .Parameters.AddWithValue("@IID", IID)
                .Parameters.AddWithValue("@IYear", IYear)
                .Parameters.AddWithValue("@Dept", Dept)
                .Parameters.AddWithValue("@IDate", IDate)
                .Parameters.AddWithValue("@ProjTitle", ProjTitle)
                .Parameters.AddWithValue("@Details", Details)
                .Parameters.AddWithValue("@Currency", Currency)
                .Parameters.AddWithValue("@CivilWorks", CivilWorks)
                .Parameters.AddWithValue("@MechanicalWork", MechanicalWork)
                .Parameters.AddWithValue("@ElecWorks", ElecWorks)
                .Parameters.AddWithValue("@Others", Others)
                .Parameters.AddWithValue("@ProdCostOrg", ProdCostOrg)
                .Parameters.AddWithValue("@ProdCostJPY", ProdCostJPY)
                .Parameters.AddWithValue("@ApprovedBudget", ApprovedBudget)
                .Parameters.AddWithValue("@DateInstallation", DateInstallation)
                .Parameters.AddWithValue("@DateCompletion", DateCompletion)
                .Parameters.AddWithValue("@PreparedBy", PreparedBy)
                .Parameters.AddWithValue("@BudRefNum", BudRefNum)
                .Parameters.AddWithValue("@InvestmentType", InvestmentType)
                .Parameters.AddWithValue("@ExistingMachine", ExistingMachine)
                .Parameters.AddWithValue("@Depreciation", Depreciation)
                .Parameters.AddWithValue("@Status", Status)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    '-------------------------'
    '---------ADD INVESTMENT----------'
    '-------------------------'

    '-----ADD NEW INVESTMENT-----'
    Shared Function AddInvesment(ByVal IYear As String, _
                              ByVal Dept As String, _
                              ByVal IDate As Date, _
                              ByVal InvestmentNo As String, _
                              ByVal ProjTitle As String, _
                              ByVal Details As String, _
                              ByVal Currency As String, _
                              ByVal CivilWorks As Decimal, _
                              ByVal MechanicalWork As Decimal, _
                              ByVal ElecWorks As Decimal, _
                              ByVal Others As Decimal, _
                              ByVal ProdCostOrg As Decimal, _
                              ByVal ProdCostJPY As Decimal, _
                              ByVal ApprovedBudget As Decimal, _
                              ByVal DateInstallation As Date, _
                              ByVal DateCompletion As Date, _
                              ByVal PreparedBy As String, _
                              ByVal BudRefNum As String, _
                              ByVal InvestmentType As String, _
                              ByVal ExistingMachine As String, _
                              ByVal Depreciation As Date, _
                              ByVal Status As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        conn.Open()
        Try
            myCmd.Connection = conn

            myCmd.CommandText = "call SP_InsertInvestment(@IYear,@Dept,@IDate,@InvestmentNo,@ProjTitle,@Details,@Currency,@CivilWorks," _
                & "@MechanicalWork,@ElecWorks,@Others,@ProdCostOrg,@ProdCostJPY,@ApprovedBudget,@DateInstallation,@DateCompletion,@PreparedBy,@BudRefNum," _
                & "@InvestmentType,@ExistingMachine,@Depreciation,@Status)"

            With myCmd
                .Parameters.AddWithValue("@IYear", IYear)
                .Parameters.AddWithValue("@Dept", Dept)
                .Parameters.AddWithValue("@IDate", IDate)
                .Parameters.AddWithValue("@InvestmentNo", InvestmentNo)
                .Parameters.AddWithValue("@ProjTitle", ProjTitle)
                .Parameters.AddWithValue("@Details", Details)
                .Parameters.AddWithValue("@Currency", Currency)
                .Parameters.AddWithValue("@CivilWorks", CivilWorks)
                .Parameters.AddWithValue("@MechanicalWork", MechanicalWork)
                .Parameters.AddWithValue("@ElecWorks", ElecWorks)
                .Parameters.AddWithValue("@Others", Others)
                .Parameters.AddWithValue("@ProdCostOrg", ProdCostOrg)
                .Parameters.AddWithValue("@ProdCostJPY", ProdCostJPY)
                .Parameters.AddWithValue("@ApprovedBudget", ApprovedBudget)
                .Parameters.AddWithValue("@DateInstallation", DateInstallation)
                .Parameters.AddWithValue("@DateCompletion", DateCompletion)
                .Parameters.AddWithValue("@PreparedBy", PreparedBy)
                .Parameters.AddWithValue("@BudRefNum", BudRefNum)
                .Parameters.AddWithValue("@InvestmentType", InvestmentType)
                .Parameters.AddWithValue("@ExistingMachine", ExistingMachine)
                .Parameters.AddWithValue("@Depreciation", Depreciation)
                .Parameters.AddWithValue("@Status", Status)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function
    '-------------------------'
    '---------BUDGET----------'
    '-------------------------'

    '-----ADD NEW BUDGET-----'
    Shared Function AddBudget(ByVal BudRefNum As String, _
                              ByVal Dept As String, _
                              ByVal Classification As String, _
                              ByVal Desc As String, _
                              ByVal Process As String, _
                              ByVal QTY As Decimal, _
                              ByVal UOM As String, _
                              ByVal SOU As Date, _
                              ByVal Currency As String, _
                              ByVal Amount As Decimal, _
                              ByVal YEN As Decimal, _
                              ByVal MBudgeted As Date, _
                              ByVal Stat As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd3.Connection = conn

        myCmd3.CommandText = "select (Select fldBudRefNum from tblBudget where fldBudRefNum = '" & frmBudget.txtBRNum.Text & "') as RefNum"

        myCmd3.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd3
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("RefNum").ToString

        If String.IsNullOrEmpty(x) Then

            Try
                myCmd.Connection = conn

                myCmd.CommandText = "INSERT INTO tblBudget (fldBudRefNum,fldDept,fldClass,fldDesc,fldProcess,fldQTY,fldUOM,fldSOU,fldCurrency,fldAmount,fldYen,fldMBudgeted,fldStat) " _
                    & "VALUES (@fldBudRefNum,@fldDept,@fldClass,@fldDesc,@fldProcess,@fldQTY,@fldUOM,@fldSOU,@fldCurrency,@fldAmount,@fldYen,@fldMBudgeted,@fldStat)"
                myCmd2.CommandText = "INSERT INTO tblRevision (fldBudRefNum,fldStat,fldRevAmount,fldDesc,fldYen,fldCurrency,fldQTY,fldUOM,fldSOU) VALUES (@fldBudRefNum,@fldStat,@fldRevAmount,@fldDesc,@fldYen,@fldCurrency,@fldQTY,@fldUOM,@fldSOU)"

                With myCmd
                    .Parameters.AddWithValue("@fldBudRefNum", BudRefNum)
                    .Parameters.AddWithValue("@fldDept", Dept)
                    .Parameters.AddWithValue("@fldClass", Classification)
                    .Parameters.AddWithValue("@fldDesc", Desc)
                    .Parameters.AddWithValue("@fldProcess", Process)
                    .Parameters.AddWithValue("@fldQTY", QTY)
                    .Parameters.AddWithValue("@fldUOM", UOM)
                    .Parameters.AddWithValue("@fldSOU", SOU)
                    .Parameters.AddWithValue("@fldCurrency", Currency)
                    .Parameters.AddWithValue("@fldAmount", Amount)
                    .Parameters.AddWithValue("@fldYen", YEN)
                    .Parameters.AddWithValue("@fldMBudgeted", MBudgeted)
                    .Parameters.AddWithValue("@fldStat", Stat)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With

                myCmd2.Connection = conn

                With myCmd2
                    .Parameters.AddWithValue("@fldBudRefNum", BudRefNum)
                    .Parameters.AddWithValue("@fldStat", Stat)
                    .Parameters.AddWithValue("@fldRevAmount", Amount)
                    .Parameters.AddWithValue("@fldDesc", Desc)
                    .Parameters.AddWithValue("@fldCurrency", Currency)
                    .Parameters.AddWithValue("@fldYen", YEN)
                    .Parameters.AddWithValue("@fldQTY", QTY)
                    .Parameters.AddWithValue("@fldUOM", UOM)
                    .Parameters.AddWithValue("@fldSOU", SOU)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With

                conn.Close()

            Catch ex As Exception
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

            Return success

        Else
            RadMessageBox.Show("Reference Number Already Exist! Kindly Change Budget Reference Number. Arigatou Gozaimasu!", "Notification", MessageBoxButtons.OK)
            success = False
            Return success
            Exit Function

        End If

        Return success

    End Function

    '----- REVISE BUDGET -----'
    Shared Function ReviseBudget(ByVal RevNum As Integer, _
                                 ByVal BudRevNum As String, _
                                 ByVal BudRefNum As String, _
                                 ByVal Desc As String, _
                                 ByVal Currency As String, _
                                 ByVal Yen As Decimal, _
                                 ByVal QTY As Decimal, _
                                 ByVal UOM As String, _
                                 ByVal SOU As Date, _
                                 ByVal Amount As Decimal, _
                                 ByVal MForecasted As Date, _
                                 ByVal Stat As String, _
                                 ByVal RemBal As Decimal, _
                                 ByVal Remarks As String, _
                                 ByVal ReviseBy As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand
        Dim myCmd4 As New MySqlCommand
        Dim myAdapter As New MySql.Data.MySqlClient.MySqlDataAdapter
        Dim myData As New DataTable
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Dim x As String

        conn.Open()
        myCmd4.Connection = conn

        myCmd4.CommandText = "select(select fldBudRevNum from tblRevision where fldBudRevNum = '" & BudRevNum & "') as RevNum"

        myCmd4.ExecuteNonQuery()

        myAdapter.SelectCommand = myCmd4
        myAdapter.Fill(myData)

        x = myData.Rows(0).Item("RevNum").ToString

        If String.IsNullOrEmpty(x) Then

            Try
                myCmd.Connection = conn

                myCmd.CommandText = "INSERT INTO tblRevision (fldRevNum,fldBudRevNum,fldBudRefNum,fldDesc,fldCurrency,fldYen,fldQTY,fldUOM,fldSOU,fldMRevise,fldStat,fldRevAmount,fldRemarks,fldReviseBy) " _
               & "VALUES (@fldRevNum+1,@fldBudRevNum,@fldBudRefNum,@fldDesc,@fldCurrency,@fldYen,@fldQTY,@fldUOM,@fldSOU,@fldMRevise,@fldStat,@fldRevAmount,@fldRemarks,@fldReviseBy)"
                myCmd2.CommandText = "UPDATE tblRevision SET fldStat = 'CLOSE' WHERE fldBudRefNum = @fldBudRefNum AND fldRevNum = '" & frmBudget.lblRevNum.Text & "'"
                myCmd3.CommandText = "UPDATE tblBudget SET fldMForecasted = @fldMForecasted WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "'"

                With myCmd.Parameters
                    .AddWithValue("@fldRevNum", RevNum)
                    .AddWithValue("@fldBudRevNum", BudRevNum)
                    .AddWithValue("@fldBudRefNum", BudRefNum)
                    .AddWithValue("@fldRevAmount", Amount)
                    .AddWithValue("@fldDesc", Desc)
                    .AddWithValue("@fldCurrency", Currency)
                    .AddWithValue("@fldYen", Yen)
                    .AddWithValue("@fldQTY", QTY)
                    .AddWithValue("@fldUOM", UOM)
                    .AddWithValue("@fldSOU", SOU)
                    .AddWithValue("@fldMRevise", MForecasted)
                    .AddWithValue("@fldStat", Stat)
                    .AddWithValue("@fldRemarks", Remarks)
                    .AddWithValue("@fldReviseBy", ReviseBy)
                End With
                myCmd.ExecuteNonQuery()
                myCmd.Parameters.Clear()

                myCmd2.Connection = conn

                myCmd2.Parameters.AddWithValue("@fldBudRefNum", BudRefNum)
                myCmd2.ExecuteNonQuery()
                myCmd2.Parameters.Clear()

                myCmd3.Connection = conn

                myCmd3.Parameters.AddWithValue("@fldMForecasted", MForecasted)
                myCmd3.ExecuteNonQuery()
                myCmd3.Parameters.Clear()

                conn.Close()
            Catch ex As Exception
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

            Return success
        Else
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("Revision Number Already Exist! Please Click the 'Refresh' Button and try to Revise again. Arigatou Gozaimasu!", "Notification", MessageBoxButtons.OK)
            success = False
            Return success
            Exit Function
        End If

        Return success

    End Function

    Shared Function CloseBudget()
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd2.Connection = conn

            myCmd.CommandText = "UPDATE tblBudget SET fldStat = 'CLOSE' WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "'"
            myCmd2.CommandText = "UPDATE tblRevision SET fldSignature = '" & frmBudget.txtSignature.Text & "', " _
                & "fldStat = 'CLOSE' WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "' AND fldBudRevNum = '" & frmBudget.txtBudRevNum.Text & "'"

            myCmd.ExecuteNonQuery()
            myCmd2.ExecuteNonQuery()

        Catch ex As Exception

        End Try

        Return success

    End Function

    '----- Force Close of Budget -----'
    Shared Function ForceCloseBudget()
        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn
            myCmd2.Connection = conn

            myCmd.CommandText = "UPDATE tblBudget SET fldStat = 'CLOSE' " _
                & "WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "'"

            myCmd2.CommandText = "UPDATE tblRevision SET fldStat = 'CLOSE' " _
                & "WHERE fldBudRefNum = '" & frmBudget.txtBRNum.Text & "'"

            myCmd.ExecuteNonQuery()
            myCmd2.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    '-------------------------'
    '----------ORDER----------'
    '-------------------------'

    '-----ADD NEW ORDER-----'
    Shared Function AddOrder(ByVal BudRefNum As String, _
                             ByVal PONum As String, _
                             ByVal PRNum As String, _
                             ByVal MonthOrder As Date, _
                             ByVal Supplier As String, _
                             ByVal Desc As String, _
                             ByVal Classification As String, _
                             ByVal Dept As String, _
                             ByVal Process As String, _
                             ByVal QTY As Integer, _
                             ByVal UOM As String, _
                             ByVal Currency As String, _
                             ByVal JPYAmount As Decimal, _
                             ByVal MonthDelivery As Date, _
                             ByVal Stat As String, _
                             ByVal Reason As String, _
                             ByVal Remarks As String, _
                             ByVal Signature As String) As Boolean


        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO `tblOrder` " _
                & "(fldBudRefNum, fldPONo, fldPRNo, fldMonthOrder, fldOrderSupplier, fldOrderDesc, " _
                & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, fldCurrency, fldAmountJPY, fldMonthDelivery, " _
                & "fldReason, fldOrderStatus, fldOrderRemarks, fldSignature)" _
                & "VALUES " _
                & "(@fldBudRefNum,@fldPONo,@fldPRNo,@fldMonthOrder,@fldOrderSupplier,@fldOrderDesc," _
                & "@fldClassification,@fldOrderDepartment,@fldProcess,@fldQTY, @fldUOM, @fldCurrency, @fldAmountJPY, @fldMonthDelivery," _
                & "@fldReason, @fldOrderStatus,@fldOrderRemarks,@fldSignature)"

            With myCmd.Parameters
                .AddWithValue("@fldBudRefNum", BudRefNum)
                .AddWithValue("@fldPONo", PONum)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                .AddWithValue("@fldOrderSupplier", Supplier)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                .AddWithValue("@fldCurrency", Currency)
                .AddWithValue("@fldAmountJPY", JPYAmount)
                '.AddWithValue("@fldYEN", YEN)
                .AddWithValue("@fldMonthDelivery", MonthDelivery)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function
    Shared Function AddInvestmentRecord(ByVal BudRefNum As String, _
                              ByVal TransCode As String, _
                              ByVal PRNum As String, _
                              ByVal MonthOrder As Date, _
                              ByVal Desc As String, _
                              ByVal Classification As String, _
                              ByVal Dept As String, _
                              ByVal Process As String, _
                              ByVal QTY As Integer, _
                              ByVal UOM As String, _
                              ByVal Stat As String, _
                              ByVal Reason As String, _
                              ByVal Remarks As String, _
                              ByVal Signature As String, _
                              ByVal MO As Date, _
                              ByVal DN As Date, _
                              ByVal Currency As String, _
                              ByVal PRAmount As Decimal, _
                              ByVal EPRA As Decimal, _
                              ByVal TOPRA As Decimal, _
                              ByVal TDOPRA As Decimal, _
                              ByVal RBLPR As Decimal, _
                              ByVal RDBLPR As Decimal, _
                              ByVal RB As Decimal, _
                              ByVal RDB As Decimal, _
                              ByVal RN As String, _
                              ByVal Rate As Decimal, _
                              ByVal MoldDie As String, _
                              ByVal InvestmentNo As String) As Boolean


        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO `tblInvestmentRecord` " _
                & "(fldBudRefNum, fldTransCode, fldPRNo, fldMonthOrder, fldOrderDesc, " _
                & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, " _
                & "fldReason, fldOrderStatus, fldOrderRemarks, fldSignature, fldMO, fldDN, " _
                & "fldEC, fldEOA, fldEJPY, fldTOPRA, fldTDOPRA, fldRBLPR, fldRDBLPR, fldRB, fldRDB, fldPrint, fldRN, fldRate, fldMoldDie, fldInvestmentNo)" _
                & "VALUES " _
                & "(@fldBudRefNum, @fldTransCode, @fldPRNo, @fldMonthOrder, @fldOrderDesc," _
                & "@fldClassification, @fldOrderDepartment, @fldProcess, @fldQTY, @fldUOM, " _
                & "@fldReason, @fldOrderStatus, @fldOrderRemarks, @fldSignature, @fldMO, @fldDN, " _
                & "@fldEC, @fldEOA, @fldEJPY, @fldTOPRA, @fldTDOPRA, @fldRBLPR, @fldRDBLPR, @fldRB, @fldRDB,'YES', @fldRN, @fldRate, @fldMoldDie, @fldInvestmentNo)"

            With myCmd.Parameters
                .AddWithValue("@fldBudRefNum", BudRefNum)
                .AddWithValue("@fldTransCode", TransCode)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
                .AddWithValue("@fldMO", MO)
                .AddWithValue("@fldDN", DN)
                .AddWithValue("@fldEC", Currency)
                .AddWithValue("@fldEOA", PRAmount)
                .AddWithValue("@fldEJPY", EPRA)
                .AddWithValue("@fldTOPRA", TOPRA)
                .AddWithValue("@fldTDOPRA", TDOPRA)
                .AddWithValue("@fldRBLPR", RBLPR)
                .AddWithValue("@fldRDBLPR", RDBLPR)
                .AddWithValue("@fldRB", RB)
                .AddWithValue("@fldRDB", RDB)
                .AddWithValue("@fldRN", RN)
                .AddWithValue("@fldRate", Rate)
                .AddWithValue("@fldMoldDie", MoldDie)
                .AddWithValue("@fldInvestmentNo", InvestmentNo)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddOrderM(ByVal BudRefNum As String,
                              ByVal TransCode As String,
                              ByVal PRNum As String,
                              ByVal MonthOrder As Date,
                              ByVal Desc As String,
                              ByVal Classification As String,
                              ByVal Dept As String,
                              ByVal Process As String,
                              ByVal QTY As Integer,
                              ByVal UOM As String,
                              ByVal Stat As String,
                              ByVal Reason As String,
                              ByVal Remarks As String,
                              ByVal Signature As String,
                              ByVal MO As Date,
                              ByVal DN As Date,
                              ByVal Currency As String,
                              ByVal PRAmount As Decimal,
                              ByVal EPRA As Decimal,
                              ByVal TOPRA As Decimal,
                              ByVal TDOPRA As Decimal,
                              ByVal RBLPR As Decimal,
                              ByVal RDBLPR As Decimal,
                              ByVal RB As Decimal,
                              ByVal RDB As Decimal,
                              ByVal RN As String,
                              ByVal Rate As Decimal,
                              ByVal MoldDie As String,
                              ByVal NReason As String) As Boolean


        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        'Try
        conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO `tblOrder` " _
                & "(fldBudRefNum, fldTransCode, fldPRNo, fldMonthOrder, fldOrderDesc, " _
                & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, " _
                & "fldReason, fldOrderStatus, fldOrderRemarks, fldSignature, fldMO, fldDN, " _
                & "fldEC, fldEOA, fldEJPY, fldTOPRA, fldTDOPRA, fldRBLPR, fldRDBLPR, fldRB, " _
                & "fldRDB, fldPrint, fldRN, fldRate, fldMoldDie, fldNReason)" _
                & "VALUES " _
                & "(@fldBudRefNum, @fldTransCode, @fldPRNo, @fldMonthOrder, @fldOrderDesc," _
                & "@fldClassification, @fldOrderDepartment, @fldProcess, @fldQTY, @fldUOM, " _
                & "@fldReason, @fldOrderStatus, @fldOrderRemarks, @fldSignature, @fldMO, @fldDN, " _
                & "@fldEC, @fldEOA, @fldEJPY, @fldTOPRA, @fldTDOPRA, @fldRBLPR, @fldRDBLPR, @fldRB, " _
                & "@fldRDB,'YES', @fldRN, @fldRate, @fldMoldDie, @fldNReason)"

            With myCmd.Parameters
                .AddWithValue("@fldBudRefNum", BudRefNum)
                .AddWithValue("@fldTransCode", TransCode)
                '.AddWithValue("@fldPONo", PONum)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                '.AddWithValue("@fldOrderSupplier", Supplier)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                '.AddWithValue("@fldCurrency", Currency)
                '.AddWithValue("@fldYen", Yen)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                '.AddWithValue("@fldAmountJPY", JPYAmount)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
                .AddWithValue("@fldMO", MO)
                .AddWithValue("@fldDN", DN)
                .AddWithValue("@fldEC", Currency)
                .AddWithValue("@fldEOA", PRAmount)
                .AddWithValue("@fldEJPY", EPRA)
                .AddWithValue("@fldTOPRA", TOPRA)
                .AddWithValue("@fldTDOPRA", TDOPRA)
                .AddWithValue("@fldRBLPR", RBLPR)
                .AddWithValue("@fldRDBLPR", RDBLPR)
                .AddWithValue("@fldRB", RB)
                .AddWithValue("@fldRDB", RDB)
                .AddWithValue("@fldRN", RN)
                .AddWithValue("@fldRate", Rate)
                .AddWithValue("@fldMoldDie", MoldDie)
                .AddWithValue("@fldNReason", NReason)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        'Catch ex As Exception
        '    success = False
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End Try

        Return success

    End Function

    Shared Function AddOrderB(ByVal BudRefNum As String, _
                         ByVal PRNum As String, _
                         ByVal MonthOrder As Date, _
                         ByVal Supplier As String, _
                         ByVal Desc As String, _
                         ByVal Classification As String, _
                         ByVal Dept As String, _
                         ByVal Process As String, _
                         ByVal QTY As Integer, _
                         ByVal UOM As String, _
                         ByVal Currency As String, _
                         ByVal JPYAmount As Decimal, _
                         ByVal MonthDelivery As Date, _
                         ByVal Stat As String, _
                         ByVal Reason As String, _
                         ByVal Remarks As String, _
                         ByVal Signature As String, _
                         ByVal UserID As Integer, _
                         ByVal MO As Date) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO `tblOrder` " _
                & "(fldBudRefNum, fldPONo, fldPRNo, fldMonthOrder, fldOrderSupplier, fldOrderDesc, " _
                & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, fldCurrency, fldAmountJPY, fldYEN, fldMonthDelivery, " _
                & "fldReason, fldOrderStatus, fldOrderRemarks, fldSignature, fldUID, fldMO)" _
                & "VALUES " _
                & "(@fldBudRefNum,@fldPONo,@fldPRNo,@fldMonthOrder,@fldOrderSupplier,@fldOrderDesc," _
                & "@fldClassification,@fldOrderDepartment,@fldProcess,@fldQTY, @fldUOM, @fldCurrency, @fldAmountJPY, @fldYEN, @fldMonthDelivery," _
                & "@fldReason, @fldOrderStatus,@fldOrderRemarks,@fldSignature,@fldUID,@fldMO)"

            With myCmd.Parameters
                .AddWithValue("@fldBudRefNum", BudRefNum)
                '.AddWithValue("@fldPONo", PONum)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                .AddWithValue("@fldOrderSupplier", Supplier)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                .AddWithValue("@fldCurrency", Currency)
                .AddWithValue("@fldAmountJPY", JPYAmount)
                '.AddWithValue("@fldYEN", YEN)
                .AddWithValue("@fldMonthDelivery", MonthDelivery)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
                .AddWithValue("@fldUID", UserID)
                .AddWithValue("@fldMO", MO)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddOrderMB(ByVal BudRefNum As String, _
                              ByVal TransCode As String, _
                              ByVal PRNum As String, _
                              ByVal MonthOrder As Date, _
                              ByVal Desc As String, _
                              ByVal Classification As String, _
                              ByVal Dept As String, _
                              ByVal Process As String, _
                              ByVal QTY As Decimal, _
                              ByVal UOM As String, _
                              ByVal Stat As String, _
                              ByVal Reason As String, _
                              ByVal Remarks As String, _
                              ByVal Signature As String, _
                              ByVal UserID As Integer, _
                              ByVal MO As Date, _
                              ByVal DN As Date, _
                              ByVal Currency As String, _
                              ByVal PRAmount As Decimal, _
                              ByVal EPRA As Decimal, _
                              ByVal TOPRA As Decimal, _
                              ByVal TDOPRA As Decimal, _
                              ByVal RBLPR As Decimal, _
                              ByVal RDBLPR As Decimal, _
                              ByVal RB As Decimal, _
                              ByVal RDB As Decimal, _
                              ByVal RN As String, _
                              ByVal Rate As Decimal) As Boolean


        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO `tblOrder` " _
                & "(fldBudRefNum, fldTransCode, fldPRNo, fldMonthOrder, fldOrderDesc, " _
                & "fldClassification, fldOrderDepartment, fldProcess, fldQTY, fldUOM, " _
                & "fldReason, fldOrderStatus, fldOrderRemarks, fldSignature, fldUID, fldMO, fldDN, " _
                & "fldEC, fldEOA, fldEJPY, fldTOPRA, fldTDOPRA, fldRBLPR, fldRDBLPR, fldRB, fldRDB, fldPrint, fldRN, fldRate)" _
                & "VALUES " _
                & "(@fldBudRefNum,@fldTransCode,@fldPRNo,@fldMonthOrder,@fldOrderDesc," _
                & "@fldClassification,@fldOrderDepartment,@fldProcess,@fldQTY,@fldUOM," _
                & "@fldReason, @fldOrderStatus,@fldOrderRemarks,@fldSignature,@fldUID,@fldMO,@fldDN," _
                & "@fldEC, @fldEOA, @fldEJPY, @fldTOPRA, @fldTDOPRA, @fldRBLPR, @fldRDBLPR, @fldRB, @fldRDB,'YES', @fldRN, @fldRate)"


            With myCmd.Parameters
                .AddWithValue("@fldBudRefNum", BudRefNum)
                .AddWithValue("@fldTransCode", TransCode)
                '.AddWithValue("@fldPONo", PONum)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                '.AddWithValue("@fldOrderSupplier", Supplier)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                '.AddWithValue("@fldCurrency", Currency)
                '.AddWithValue("@fldYen", Yen)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                '.AddWithValue("@fldAmountJPY", JPYAmount)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
                .AddWithValue("@fldUID", UserID)
                .AddWithValue("@fldMO", MO)
                .AddWithValue("@fldDN", DN)
                .AddWithValue("@fldEC", Currency)
                .AddWithValue("@fldEOA", PRAmount)
                .AddWithValue("@fldEJPY", EPRA)
                .AddWithValue("@fldTOPRA", TOPRA)
                .AddWithValue("@fldTDOPRA", TDOPRA)
                .AddWithValue("@fldRBLPR", RBLPR)
                .AddWithValue("@fldRDBLPR", RDBLPR)
                .AddWithValue("@fldRB", RB)
                .AddWithValue("@fldRDB", RDB)
                .AddWithValue("@fldRN", RN)
                .AddWithValue("@fldRate", Rate)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateOrder(ByVal OrderID As Integer, _
                                ByVal BudRefNum As String, _
                                ByVal PONum As String, _
                                ByVal PRNum As String, _
                                ByVal MonthOrder As Date, _
                                ByVal Supplier As String, _
                                ByVal Desc As String, _
                                ByVal Classification As String, _
                                ByVal Dept As String, _
                                ByVal Process As String, _
                                ByVal QTY As Integer, _
                                ByVal UOM As String, _
                                ByVal JPYAmount As Decimal, _
                                ByVal MonthDelivery As Date, _
                                ByVal Stat As String, _
                                ByVal Reason As String, _
                                ByVal Remarks As String, _
                                ByVal Signature As String) As Boolean


        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE `tblOrder` SET " _
            & "fldBudRefNum=@fldBudRefNum, fldPONo=@fldPONo, fldPRNo=@fldPRNo, fldMonthOrder=@fldMonthOrder, " _
            & "fldOrderSupplier=@fldOrderSupplier, fldOrderDesc=@fldOrderDesc, " _
            & "fldClassification=@fldClassification, fldOrderDepartment=@fldOrderDepartment, " _
            & "fldProcess=@fldProcess, fldQTY=@fldQTY, fldUOM=@fldUOM, fldAmountJPY=@fldAmountJPY, fldMonthDelivery=@fldMonthDelivery, " _
            & "fldReason=@fldReason, fldOrderStatus=@fldOrderStatus, fldOrderRemarks=@fldOrderRemarks, fldSignature=@fldSignature " _
            & "WHERE fldOrderID=@fldOrderID"

            With myCmd.Parameters
                .AddWithValue("@fldOrderID", OrderID)
                .AddWithValue("@fldBudRefNum", BudRefNum)
                .AddWithValue("@fldPONo", PONum)
                .AddWithValue("@fldPRNo", PRNum)
                .AddWithValue("@fldMonthOrder", MonthOrder)
                .AddWithValue("@fldOrderSupplier", Supplier)
                .AddWithValue("@fldOrderDesc", Desc)
                .AddWithValue("@fldClassification", Classification)
                .AddWithValue("@fldOrderDepartment", Dept)
                .AddWithValue("@fldProcess", Process)
                .AddWithValue("@fldQTY", QTY)
                .AddWithValue("@fldUOM", UOM)
                .AddWithValue("@fldAmountJPY", JPYAmount)
                .AddWithValue("@fldMonthDelivery", MonthDelivery)
                .AddWithValue("@fldOrderStatus", Stat)
                .AddWithValue("@fldReason", Reason)
                .AddWithValue("@fldOrderRemarks", Remarks)
                .AddWithValue("@fldSignature", Signature)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function CloseOrder()

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE tblOrder SET fldOrderStatus = 'CLOSE' " _
                & "WHERE fldOrderID='" & frmOrder.lblOrderID.Text & "'"

            myCmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function SetConversionRate(ByVal PHPRate As Decimal, _
                                      ByVal USDRate As Decimal, _
                                      ByVal JPYRate As Decimal, _
                                      ByVal Year As Date)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "INSERT INTO `tblConversion`" _
            & "(`fldcurrency`, `fldAmount`, `fldDate`) " _
            & "VALUES ('PHP-USD', @fldAmountPHP, @fldDate), " _
            & "('USD-JPY', @fldAmountUSD, @fldDate), " _
            & "('JPY-PHP', @fldAmountYEN, @fldDate)"

        With myCmd.Parameters
            .AddWithValue("fldAmountPHP", PHPRate)
            .AddWithValue("fldAmountUSD", USDRate)
            .AddWithValue("fldAmountYEN", JPYRate)
            .AddWithValue("fldDate", Year)
        End With

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    '---- BUDGET CREATION -----'

    Shared Function AddCreatedBudget(ByVal RefNo As String,
                                     ByVal Dept As String,
                                     ByVal ActivityCode As String,
                                     ByVal Classification As String,
                                     ByVal ClassCode As String,
                                     ByVal Desc As String,
                                     ByVal Process As String,
                                     ByVal QTY As Decimal,
                                     ByVal UOM As String,
                                     ByVal SOU As Date,
                                     ByVal Currency As String,
                                     ByVal UnitPrice As Decimal,
                                     ByVal Amount As Decimal,
                                     ByVal MBudgeted As Date,
                                     ByVal Remarks As String,
                                     ByVal Signature As String,
                                     ByVal SubRefNo As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim BCRNo As String = Nothing
        Dim Index As Integer

        conn.Open()

        If frmBudgetCreation.txtBCRefNo.Text = "" Then

            Dim drBCRNO As DataRow = Chinita.fetchMySqlRow_BC("select CONCAT('" & ClassCode & "', '-' ,'" & Dept & "', '-' ,(select count(fldIndex)+1 from tblBudget " _
                                                              & "where fldDept = '" & Dept & "' AND year(fldMonthBudgeted) = '" & MBudgeted.Year & "' " _
                                                              & "AND fldIndex = '1'),'-','" & MBudgeted.Year & "') as BCRefNum")

            If drBCRNO IsNot Nothing Then
                BCRNo = drBCRNO.Item("BCRefNum").ToString

                If ClassCode <> Nothing And BCRNo <> "" Then

                    Try
                        myCmd.Connection = conn

                        myCmd.CommandText = "INSERT INTO tblBudget " _
                            & "(fldBCRefNo, fldDept, fldActivityCode, fldClass, fldClassCode, fldDesc, fldProcess, " _
                            & "fldQTY, fldUOM, fldSOU, fldCurrency, fldUAmount, fldAmount, " _
                            & "fldMonthBudgeted, fldRemarks, fldSignature, fldSubRefNo) " _
                            & "VALUES " _
                            & "(@fldBCRefNo, @fldDept, @fldActivityCode, @fldClass, @fldClassCode, @fldDesc, @fldProcess, " _
                            & "@fldQTY, @fldUOM, @fldSOU, @fldCurrency, @fldUAmount, @fldAmount, " _
                            & "@fldMonthBudgeted, @fldRemarks, @fldSignature, @fldSubRefNo)"

                        With myCmd
                            .Parameters.AddWithValue("@fldBCRefNo", BCRNo)
                            .Parameters.AddWithValue("@fldDept", Dept)
                            .Parameters.AddWithValue("@fldActivityCode", ActivityCode)
                            .Parameters.AddWithValue("@fldClass", Classification)
                            .Parameters.AddWithValue("@fldClassCode", ClassCode)
                            .Parameters.AddWithValue("@fldDesc", Desc)
                            .Parameters.AddWithValue("@fldProcess", Process)
                            .Parameters.AddWithValue("@fldQTY", QTY)
                            .Parameters.AddWithValue("@fldUOM", UOM)
                            .Parameters.AddWithValue("@fldSOU", SOU)
                            .Parameters.AddWithValue("@fldCurrency", Currency)
                            .Parameters.AddWithValue("@fldUAmount", UnitPrice)
                            .Parameters.AddWithValue("@fldAmount", Amount)
                            .Parameters.AddWithValue("@fldMonthBudgeted", MBudgeted)
                            .Parameters.AddWithValue("@fldRemarks", Remarks)
                            .Parameters.AddWithValue("@fldSignature", Signature)
                            .Parameters.AddWithValue("@fldSubRefNo", SubRefNo)
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        conn.Close()

                    Catch ex As Exception
                        success = False
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
                    End Try

                    Return success

                Else
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No Reference Number Generated.", "Notification", MessageBoxButtons.OK)
                    success = False
                    Return success
                    Exit Function
                End If

            Else
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Reference Number Generated.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If

        Else

            Try

                Dim drIndex As DataRow = Chinita.fetchMySqlRow_BC("select if(max(fldIndex) is null,count(fldIndex)+1,max(fldIndex)+1) as fldIndex from tblBudget  " _
                                                                  & "where fldBCRefno = '" & RefNo & "' AND fldStatus = 'OPEN' ")
                Index = drIndex.Item("fldIndex")

                myCmd.Connection = conn

                myCmd.CommandText = "INSERT INTO tblBudget " _
                    & "(fldBCRefNo, fldIndex, fldDept, fldActivityCode, fldClass, fldClassCode, fldDesc, fldProcess, " _
                    & "fldQTY, fldUOM, fldSOU, fldCurrency, fldUAmount, fldAmount, " _
                    & "fldMonthBudgeted, fldRemarks, fldSignature) " _
                    & "VALUES " _
                    & "(@fldBCRefNo, @fldIndex, @fldDept, @fldActivityCode, @fldClass, @fldClassCode, @fldDesc, @fldProcess, " _
                    & "@fldQTY, @fldUOM, @fldSOU, @fldCurrency, @fldUAmount, @fldAmount, " _
                    & "@fldMonthBudgeted, @fldRemarks, @fldSignature)"

                With myCmd
                    .Parameters.AddWithValue("@fldBCRefNo", RefNo)
                    .Parameters.AddWithValue("@fldIndex", Index)
                    .Parameters.AddWithValue("@fldDept", Dept)
                    .Parameters.AddWithValue("@fldActivityCode", ActivityCode)
                    .Parameters.AddWithValue("@fldClass", Classification)
                    .Parameters.AddWithValue("@fldClassCode", ClassCode)
                    .Parameters.AddWithValue("@fldDesc", Desc)
                    .Parameters.AddWithValue("@fldProcess", Process)
                    .Parameters.AddWithValue("@fldQTY", QTY)
                    .Parameters.AddWithValue("@fldUOM", UOM)
                    .Parameters.AddWithValue("@fldSOU", SOU)
                    .Parameters.AddWithValue("@fldCurrency", Currency)
                    .Parameters.AddWithValue("@fldUAmount", UnitPrice)
                    .Parameters.AddWithValue("@fldAmount", Amount)
                    .Parameters.AddWithValue("@fldMonthBudgeted", MBudgeted)
                    .Parameters.AddWithValue("@fldRemarks", Remarks)
                    .Parameters.AddWithValue("@fldSignature", Signature)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With

                conn.Close()

            Catch ex As Exception
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

            Return success

        End If

        Return success

    End Function

    Shared Function AddCreatedBudgetPPE(ByVal RefNo As String,
                                        ByVal Dept As String,
                                        ByVal ActivityCode As String,
                                        ByVal Classification As String,
                                        ByVal ClassCode As String,
                                        ByVal SubClass As String,
                                        ByVal SubClassCode As String,
                                        ByVal Desc As String,
                                        ByVal Process As String,
                                        ByVal QTY As Decimal,
                                        ByVal UOM As String,
                                        ByVal SOU As Date,
                                        ByVal Currency As String,
                                        ByVal UnitPrice As Decimal,
                                        ByVal Amount As Decimal,
                                        ByVal MBudgeted As Date,
                                        ByVal Remarks As String,
                                        ByVal Signature As String,
                                        ByVal SubRefNo As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim BCRNo As String = Nothing
        Dim Index As Integer

        conn.Open()

        If frmBudgetCreation.txtBCRefNo.Text = "" Then

            Dim drBCRNO As DataRow = Chinita.fetchMySqlRow_BC("select CONCAT('" & SubClassCode & "', '-' ,'" & Dept & "', '-' ,(select count(fldIndex)+1 from tblBudget " _
                                                              & "where fldDept = '" & Dept & "' AND year(fldMonthBudgeted) = '" & MBudgeted.Year & "' " _
                                                              & "AND fldIndex = '1'),'-','" & MBudgeted.Year & "') as BCRefNum")

            If drBCRNO IsNot Nothing Then
                BCRNo = drBCRNO.Item("BCRefNum").ToString

                If ClassCode <> Nothing And BCRNo <> "" Then

                    Try
                        myCmd.Connection = conn

                        myCmd.CommandText = "INSERT INTO tblBudget " _
                            & "(fldBCRefNo, fldDept, fldActivityCode, fldClass, fldClassCode, fldSubClass, fldSubClassCode, " _
                            & "fldDesc, fldProcess, fldQTY, fldUOM, fldSOU, fldCurrency, fldUAmount, fldAmount, " _
                            & "fldMonthBudgeted, fldRemarks, fldSignature, fldSubRefNo) " _
                            & "VALUES " _
                            & "(@fldBCRefNo, @fldDept, @fldActivityCode, @fldClass, @fldClassCode, @fldSubClass, @fldSubClassCode, " _
                            & "@fldDesc, @fldProcess, @fldQTY, @fldUOM, @fldSOU, @fldCurrency, @fldUAmount, @fldAmount, " _
                            & "@fldMonthBudgeted, @fldRemarks, @fldSignature, @fldSubRefNo)"

                        With myCmd
                            .Parameters.AddWithValue("@fldBCRefNo", BCRNo)
                            .Parameters.AddWithValue("@fldDept", Dept)
                            .Parameters.AddWithValue("@fldActivityCode", ActivityCode)
                            .Parameters.AddWithValue("@fldClass", Classification)
                            .Parameters.AddWithValue("@fldClassCode", ClassCode)
                            .Parameters.AddWithValue("@fldSubClass", SubClass)
                            .Parameters.AddWithValue("@fldSubClassCode", SubClassCode)
                            .Parameters.AddWithValue("@fldDesc", Desc)
                            .Parameters.AddWithValue("@fldProcess", Process)
                            .Parameters.AddWithValue("@fldQTY", QTY)
                            .Parameters.AddWithValue("@fldUOM", UOM)
                            .Parameters.AddWithValue("@fldSOU", SOU)
                            .Parameters.AddWithValue("@fldCurrency", Currency)
                            .Parameters.AddWithValue("@fldUAmount", UnitPrice)
                            .Parameters.AddWithValue("@fldAmount", Amount)
                            .Parameters.AddWithValue("@fldMonthBudgeted", MBudgeted)
                            .Parameters.AddWithValue("@fldRemarks", Remarks)
                            .Parameters.AddWithValue("@fldSignature", Signature)
                            .Parameters.AddWithValue("@fldSubRefNo", SubRefNo)
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        conn.Close()

                    Catch ex As Exception
                        success = False
                        RadMessageBox.SetThemeName("Windows8")
                        RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
                    End Try

                    Return success

                Else
                    RadMessageBox.SetThemeName("Windows8")
                    RadMessageBox.Show("No Reference Number Generated.", "Notification", MessageBoxButtons.OK)
                    success = False
                    Return success
                    Exit Function
                End If

            Else
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("No Reference Number Generated.", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If

        Else

            Try

                Dim drIndex As DataRow = Chinita.fetchMySqlRow_BC("select if(max(fldIndex) is null,count(fldIndex)+1,max(fldIndex)+1) as fldIndex from tblBudget  " _
                                                                  & "where fldBCRefno = '" & RefNo & "' AND fldStatus = 'OPEN' ")
                Index = drIndex.Item("fldIndex")

                myCmd.Connection = conn

                myCmd.CommandText = "INSERT INTO tblBudget " _
                    & "(fldBCRefNo, fldIndex, fldDept, fldActivityCode, fldClass, fldClassCode, fldSubClassCode, fldDesc, fldProcess, " _
                    & "fldQTY, fldUOM, fldSOU, fldCurrency, fldUAmount, fldAmount, " _
                    & "fldMonthBudgeted, fldRemarks, fldSignature) " _
                    & "VALUES " _
                    & "(@fldBCRefNo, @fldIndex, @fldDept, @fldActivityCode, @fldClass, @fldClassCode, @ fldSubClassCode, @fldDesc, @fldProcess, " _
                    & "@fldQTY, @fldUOM, @fldSOU, @fldCurrency, @fldUAmount, @fldAmount, " _
                    & "@fldMonthBudgeted, @fldRemarks, @fldSignature)"

                With myCmd
                    .Parameters.AddWithValue("@fldBCRefNo", RefNo)
                    .Parameters.AddWithValue("@fldIndex", Index)
                    .Parameters.AddWithValue("@fldDept", Dept)
                    .Parameters.AddWithValue("@fldActivityCode", ActivityCode)
                    .Parameters.AddWithValue("@fldClass", Classification)
                    .Parameters.AddWithValue("@fldClassCode", ClassCode)
                    .Parameters.AddWithValue("@fldSubClassCode", SubClassCode)
                    .Parameters.AddWithValue("@fldDesc", Desc)
                    .Parameters.AddWithValue("@fldProcess", Process)
                    .Parameters.AddWithValue("@fldQTY", QTY)
                    .Parameters.AddWithValue("@fldUOM", UOM)
                    .Parameters.AddWithValue("@fldSOU", SOU)
                    .Parameters.AddWithValue("@fldCurrency", Currency)
                    .Parameters.AddWithValue("@fldUAmount", UnitPrice)
                    .Parameters.AddWithValue("@fldAmount", Amount)
                    .Parameters.AddWithValue("@fldMonthBudgeted", MBudgeted)
                    .Parameters.AddWithValue("@fldRemarks", Remarks)
                    .Parameters.AddWithValue("@fldSignature", Signature)
                    .ExecuteNonQuery()
                    .Parameters.Clear()
                End With

                conn.Close()

            Catch ex As Exception
                success = False
                RadMessageBox.SetThemeName("Windows8")
                RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
            End Try

            Return success

        End If

        Return success

    End Function

    Shared Function UpdateCreatedBudget(ByVal RefNo As String, _
                                        ByVal Dept As String, _
                                        ByVal ActivityCode As String, _
                                        ByVal Classification As String, _
                                        ByVal ClassCode As String, _
                                        ByVal Desc As String, _
                                        ByVal Process As String, _
                                        ByVal QTY As Decimal, _
                                        ByVal UOM As String, _
                                        ByVal SOU As Date, _
                                        ByVal Currency As String, _
                                        ByVal UnitPrice As Decimal, _
                                        ByVal Amount As Decimal, _
                                        ByVal MBudgeted As Date, _
                                        ByVal Remarks As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim BC_ID As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldBudID").Value.ToString
        Dim BC_ID_Month As Integer = Month(frmBudgetCreation.rgvList.CurrentRow.Cells("fldMonthBudgeted").Value)
        Dim BC_ClassCode As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldClassCode").Value.ToString

        Dim Signature As String = frmBudgetCreation.txtSignature.Text

        Dim BCRNo As String

        conn.Open()

        Dim drBCRNO As DataRow = Chinita.fetchMySqlRow_BC("select CONCAT('" & ClassCode & "', '-' ,'" & Dept & "', '-' ,(select count(fldIndex)+1 from tblBudget " _
                                                        & "where fldDept = '" & Dept & "' AND year(fldMonthBudgeted) = '" & MBudgeted.Year & "' " _
                                                        & "AND fldIndex = '1'),'-','" & MBudgeted.Year & "') as BCRefNum")
        BCRNo = drBCRNO.Item("BCRefNum").ToString

        Try
            myCmd.Connection = conn
            myCmd2.Connection = conn
            myCmd3.Connection = conn

            If RadMessageBox.Show("BC Control Number: '" & RefNo & "' and its items will be updated. ",
                                  "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If MBudgeted.Month = BC_ID_Month Then

                    If ClassCode <> BC_ClassCode Then
                        Dim s As String = RefNo
                        Dim leftString As String = s.Substring(s.IndexOf("-"))
                        Dim New_RefNo As String = ClassCode + leftString



                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    Else

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    End If

                Else

                    Dim dtchkMonth As DataTable = Chinita.fetchDBTable_BC _
                                    ("select month(fldMonthBudgeted) as chkMonth from tblBudget " _
                                     & "where fldBCRefNo = '" & RefNo & "' AND fldStatus = 'OPEN' ")

                    For x As Integer = 0 To dtchkMonth.Rows.Count - 1
                        If MBudgeted.Month = dtchkMonth.Rows(x).Item("chkMonth").ToString Then

                            success = False
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("Budget Already set to this month.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
                            Return success

                        End If
                    Next

                    If ClassCode <> BC_ClassCode Then
                        Dim s As String = RefNo
                        Dim leftString As String = s.Substring(s.IndexOf("-"))
                        Dim New_RefNo As String = ClassCode + leftString

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    Else

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldActivityCode = '" & ActivityCode & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & DBNull.Value & "', " _
                            & "fldSubClassCode = '" & DBNull.Value & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    End If

                End If

                conn.Close()

            End If

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateCreatedBudgetPPE(ByVal RefNo As String, _
                                           ByVal Dept As String, _
                                           ByVal ActivityCode As String, _
                                           ByVal Classification As String, _
                                           ByVal ClassCode As String, _
                                           ByVal SubClass As String, _
                                           ByVal SubClassCode As String, _
                                           ByVal Desc As String, _
                                           ByVal Process As String, _
                                           ByVal QTY As Decimal, _
                                           ByVal UOM As String, _
                                           ByVal SOU As Date, _
                                           ByVal Currency As String, _
                                           ByVal UnitPrice As Decimal, _
                                           ByVal Amount As Decimal, _
                                           ByVal MBudgeted As Date, _
                                           ByVal Remarks As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim myCmd2 As New MySqlCommand
        Dim myCmd3 As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        Dim BC_ID As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldBudID").Value.ToString
        Dim BC_ID_Month As Integer = Month(frmBudgetCreation.rgvList.CurrentRow.Cells("fldMonthBudgeted").Value)
        Dim BC_SubClassCode As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldSubClassCode").Value.ToString

        Dim Signature As String = frmBudgetCreation.txtSignature.Text

        Dim BCRNo As String

        conn.Open()

        Dim drBCRNO As DataRow = Chinita.fetchMySqlRow_BC("select CONCAT('" & SubClassCode & "', '-' ,'" & Dept & "', '-' ,(select count(fldIndex)+1 from tblBudget " _
                                                        & "where fldDept = '" & Dept & "' AND year(fldMonthBudgeted) = '" & MBudgeted.Year & "' " _
                                                        & "AND fldIndex = '1'),'-','" & MBudgeted.Year & "') as BCRefNum")
        BCRNo = drBCRNO.Item("BCRefNum").ToString

        Try
            myCmd.Connection = conn
            myCmd2.Connection = conn
            myCmd3.Connection = conn

            If RadMessageBox.Show("BC Control Number: '" & RefNo & "' and its items will be updated. ",
                                  "Budget Creation", MessageBoxButtons.YesNo, RadMessageIcon.Question, MessageBoxDefaultButton.Button2) = DialogResult.Yes Then

                If MBudgeted.Month = BC_ID_Month Then

                    If SubClassCode <> BC_SubClassCode Then
                        Dim s As String = RefNo
                        Dim leftString As String = s.Substring(s.IndexOf("-"))
                        Dim New_RefNo As String = SubClassCode + leftString

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    Else

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldDesc = '" & Desc & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    End If

                Else

                    Dim dtchkMonth As DataTable = Chinita.fetchDBTable_BC _
                                    ("select month(fldMonthBudgeted) as chkMonth from tblBudget " _
                                     & "where fldBCRefNo = '" & RefNo & "' AND fldStatus = 'OPEN' ")

                    For x As Integer = 0 To dtchkMonth.Rows.Count - 1
                        If MBudgeted.Month = dtchkMonth.Rows(x).Item("chkMonth").ToString Then

                            success = False
                            RadMessageBox.SetThemeName("Windows8")
                            RadMessageBox.Show("Budget Already set to this month.", "Incomplete Input", MessageBoxButtons.OK, RadMessageIcon.Info)
                            Return success

                        End If
                    Next

                    If ClassCode <> BC_SubClassCode Then
                        Dim s As String = RefNo
                        Dim leftString As String = s.Substring(s.IndexOf("-"))
                        Dim New_RefNo As String = SubClassCode + leftString

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET fldBCRefNo = '" & New_RefNo & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldDesc = '" & Desc & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    Else

                        myCmd.CommandText = "UPDATE tblBudget SET " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldProcess = '" & Process & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldQTY = '" & QTY & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldAmount = '" & Amount & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldMonthBudgeted = '" & (String.Format("{0:yyyy-MM-dd}", MBudgeted)) & "', " _
                            & "fldSOU = '" & (String.Format("{0:yyyy-MM-dd}", SOU)) & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBudID = '" & BC_ID & "'"
                        With myCmd
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                        myCmd2.CommandText = "UPDATE tblBudget SET fldDesc = '" & Desc & "', " _
                            & "fldClass = '" & Classification & "', " _
                            & "fldClassCode = '" & ClassCode & "', " _
                            & "fldSubClass = '" & SubClass & "', " _
                            & "fldSubClassCode = '" & SubClassCode & "', " _
                            & "fldDesc = '" & Replace(Desc, "'", "''") & "', " _
                            & "fldUOM = '" & UOM & "', " _
                            & "fldUAmount = '" & UnitPrice & "', " _
                            & "fldCurrency = '" & Currency & "', " _
                            & "fldRemarks = '" & Replace(Remarks, "'", "''") & "', " _
                            & "fldSignature = '" & Signature & "' " _
                            & "WHERE fldBCRefNo = '" & RefNo & "'"
                        With myCmd2
                            .ExecuteNonQuery()
                            .Parameters.Clear()
                        End With

                    End If

                End If

                conn.Close()

            End If

            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function DeleteCreatedBudget(ByVal Status As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        'Dim BC_ID As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldBudID").Value.ToString
        'Dim Signature As String = frmBudgetCreation.txtSignature.Text
        'conn.Open()

        'Try
        '    myCmd.Connection = conn

        '    myCmd.CommandText = "UPDATE tblBudget SET " _
        '        & "fldStatus = '" & Status & "' " _
        '        & "WHERE fldBudID = '" & BC_ID & "'"

        '    With myCmd
        '        .ExecuteNonQuery()
        '        .Parameters.Clear()
        '    End With

        '    conn.Close()

        'Catch ex As Exception
        '    success = False
        '    RadMessageBox.SetThemeName("Windows8")
        '    RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        'End Try

        'Return success


        'Dim BC_ID As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldBudID").Value.ToString
        Dim Signature As String = frmBudgetCreation.txtSignature.Text

        frmBudgetCreation.LoadCount = frmBudgetCreation.rgvList.Rows.Count

        conn.Open()

        With frmBudgetCreation
            .pbOlrayt.Minimum = 1
            .pbOlrayt.Maximum = frmBudgetCreation.LoadCount
            .pbOlrayt.Value = 1
            .pbOlrayt.Step = 1
        End With

        Try
            myCmd.Connection = conn
            frmBudgetCreation.pbOlrayt.Visible = True

            For x As Integer = 0 To frmBudgetCreation.rgvList.ChildRows.Count - 1
                Dim chk As Boolean = frmBudgetCreation.rgvList.ChildRows(x).Cells("chk").Value
                imBusy = True

                If chk = True Then
                    Dim BC_ID As String = frmBudgetCreation.rgvList.ChildRows(x).Cells("fldBudID").Value

                    myCmd.CommandText = "UPDATE tblBudget SET " _
                        & "fldStatus = '" & Status & "' " _
                        & "WHERE fldBudID = '" & BC_ID & "'"

                    With myCmd
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With

                End If

                frmBudgetCreation.pbOlrayt.PerformStep()
            Next

            imBusy = False
            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function FinalizeCreatedBudget(ByVal Status As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        'Dim BC_ID As String = frmBudgetCreation.rgvList.CurrentRow.Cells("fldBudID").Value.ToString
        Dim Signature As String = frmBudgetCreation.txtSignature.Text

        frmBudgetCreation.LoadCount = frmBudgetCreation.rgvList.Rows.Count

        conn.Open()

        With frmBudgetCreation
            .pbOlrayt.Minimum = 1
            .pbOlrayt.Maximum = frmBudgetCreation.LoadCount
            .pbOlrayt.Value = 1
            .pbOlrayt.Step = 1
        End With

        Try
            myCmd.Connection = conn
            frmBudgetCreation.pbOlrayt.Visible = True

            For x As Integer = 0 To frmBudgetCreation.rgvList.ChildRows.Count - 1
                Dim chk As Boolean = frmBudgetCreation.rgvList.ChildRows(x).Cells("chk").Value
                imBusy = True

                If chk = True Then
                    Dim BC_ID As String = frmBudgetCreation.rgvList.ChildRows(x).Cells("fldBudID").Value

                    myCmd.CommandText = "UPDATE tblBudget SET " _
                        & "fldStatus = '" & Status & "' " _
                        & "WHERE fldBudID = '" & BC_ID & "'"

                    With myCmd
                        .ExecuteNonQuery()
                        .Parameters.Clear()
                    End With

                End If

                frmBudgetCreation.pbOlrayt.PerformStep()
            Next

            imBusy = False
            conn.Close()

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateConversionRateBC(ByVal PHPRate As Decimal, _
                                           ByVal USDRate As Decimal, _
                                           ByVal JPYRate As Decimal, _
                                           ByVal Year As Date)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "UPDATE `tblConversion` SET fldAmount = '" & PHPRate & "' WHERE Year(fldDate) = '" & Year.Year & "' AND fldCurrency = 'PHP-USD'; " _
                          & "UPDATE `tblConversion` SET fldAmount = '" & USDRate & "' WHERE Year(fldDate) = '" & Year.Year & "' AND fldCurrency = 'USD-JPY'; " _
                          & "UPDATE `tblConversion` SET fldAmount = '" & JPYRate & "' WHERE Year(fldDate) = '" & Year.Year & "' AND fldCurrency = 'JPY-PHP'; "

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddConversionRateLogs(ByVal PHPRate As Decimal, _
                                          ByVal USDRate As Decimal, _
                                          ByVal JPYRate As Decimal, _
                                          ByVal ConLogRate As Date, _
                                          ByVal ConTransDate As Date)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "INSERT INTO `tblConversionRateLogs`" _
            & "(fldDate, fldTDate, fldJPY, fldPHP, fldUSD, fldSignature) " _
            & "VALUES " _
            & "(@fldDate, @fldTDate, @fldJPY, @fldPHP, @fldUSD, '" & frmBudgetCreation.txtSignature.Text & "')"

        With myCmd.Parameters
            .AddWithValue("fldJPY", JPYRate)
            .AddWithValue("fldPHP", PHPRate)
            .AddWithValue("fldUSD", USDRate)
            .AddWithValue("fldDate", ConLogRate)
            .AddWithValue("fldTDate", ConTransDate)
        End With

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function SetConversionRateBC(ByVal PHPRate As Decimal, _
                                        ByVal USDRate As Decimal, _
                                        ByVal JPYRate As Decimal, _
                                        ByVal Year As Date)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "INSERT INTO `tblConversion`" _
            & "(`fldcurrency`, `fldAmount`, `fldDate`) " _
            & "VALUES " _
            & "('PHP-USD', @fldAmountPHP, @fldDate), " _
            & "('USD-JPY', @fldAmountUSD, @fldDate), " _
            & "('JPY-PHP', @fldAmountYEN, @fldDate)"

        With myCmd.Parameters
            .AddWithValue("fldAmountPHP", PHPRate)
            .AddWithValue("fldAmountUSD", USDRate)
            .AddWithValue("fldAmountYEN", JPYRate)
            .AddWithValue("fldDate", Year)
        End With

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function SetModule(ByVal Status As String)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "UPDATE `tblSetting` SET fldCode = '" & Status & "' WHERE fldSettingID = 1 "

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateBudgetSetting(ByVal Limit As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(ConnString)
        'UPDATE USER - GRID
        Try
            conn.Open()
            myCmd.Connection = conn

            myCmd.CommandText = "UPDATE tblSettings SET fldLimit = @fldLimit WHERE fldProID = '4'"

            With myCmd.Parameters
                .AddWithValue("@fldLimit", Limit)
            End With

            myCmd.ExecuteNonQuery()
            myCmd.Parameters.Clear()

            conn.Close()
        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function AddNewMatrixExpense(ByVal Item As String, _
                                        ByVal Definition As String, _
                                        ByVal Threshold As String, _
                                        ByVal Sample As String)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "INSERT INTO `tblMatrixExpense`" _
            & "(fldItem, fldDefinition, fldThreshold, fldSample ) " _
            & "VALUES " _
            & "(@fldItem, @fldDefinition, @fldThreshold, @fldSample ) "

        With myCmd.Parameters
            .AddWithValue("fldItem", Item)
            .AddWithValue("fldDefinition", Definition)
            .AddWithValue("fldThreshold", Threshold)
            .AddWithValue("fldSample", Sample)
        End With

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function

    Shared Function UpdateNewMatrixExpense(ByVal ID As Integer, _
                                           ByVal Item As String, _
                                           ByVal Definition As String, _
                                           ByVal Threshold As String, _
                                           ByVal Sample As String)

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)

        conn.Open()
        myCmd.Connection = conn

        myCmd.CommandText = "UPDATE tblMatrixExpense SET " _
                       & "fldStatus = '" & Item & "', " _
                       & "fldStatus = '" & Definition & "', " _
                       & "fldStatus = '" & Threshold & "', " _
                       & "fldStatus = '" & Sample & "' " _
                       & "WHERE fldID = '" & ID & "'"

        myCmd.ExecuteNonQuery()
        myCmd.Parameters.Clear()

        Try

        Catch ex As Exception
            success = False
            RadMessageBox.SetThemeName("Windows8")
            RadMessageBox.Show("" & ex.Message & "", "Warning", MessageBoxButtons.OK, RadMessageIcon.Error)
        End Try

        Return success

    End Function
    '----------------------------function for Upload BCS------------------------------------------------------------------
    Shared Function AddCreatedBudgetPPEUpload(ByVal fldBCRefNo As String,
                                        ByVal fldDept As String,
                                        ByVal fldActivityCode As String,
                                        ByVal fldClass As String,
                                        ByVal fldClassCode As String,
                                        ByVal fldSubClass As String,
                                        ByVal fldSubClassCode As String,
                                        ByVal fldDesc As String,
                                        ByVal fldProcess As String,
                                        ByVal fldQTY As Decimal,
                                        ByVal fldUOM As String,
                                        ByVal fldSOU As Date,
                                        ByVal fldCurrency As String,
                                        ByVal fldUAmount As Decimal,
                                        ByVal fldAmount As Decimal,
                                        ByVal fldMonthBudgeted As Date,
                                        ByVal fldRemarks As String,
                                        ByVal fldSignature As String,
                                        ByVal fldSubRefNo As String) As Boolean

        Dim success As Boolean = True
        Dim myCmd As New MySqlCommand

        Dim conn As New MySql.Data.MySqlClient.MySqlConnection(BC_ConnString)



        conn.Open()


        Try
            myCmd.Connection = conn

            myCmd.CommandText = "INSERT INTO tblBudget " _
                & "(fldBCRefNo, fldDept, fldActivityCode, fldClass, fldClassCode, fldSubClass, fldSubClassCode, " _
                & "fldDesc, fldProcess, fldQTY, fldUOM, fldSOU, fldCurrency, fldUAmount, fldAmount, " _
                & "fldMonthBudgeted, fldRemarks, fldSignature, fldSubRefNo) " _
                & "VALUES " _
                & "(@fldBCRefNo, @fldDept, @fldActivityCode, @fldClass, @fldClassCode, @fldSubClass, @fldSubClassCode, " _
                & "@fldDesc, @fldProcess, @fldQTY, @fldUOM, @fldSOU, @fldCurrency, @fldUAmount, @fldAmount, " _
                & "@fldMonthBudgeted, @fldRemarks, @fldSignature, @fldSubRefNo)"

            With myCmd
                .Parameters.AddWithValue("@fldBCRefNo", fldBCRefNo)
                .Parameters.AddWithValue("@fldDept", fldDept)
                .Parameters.AddWithValue("@fldActivityCode", fldActivityCode)
                .Parameters.AddWithValue("@fldClass", fldClass)
                .Parameters.AddWithValue("@fldClassCode", fldClassCode)
                .Parameters.AddWithValue("@fldSubClass", fldSubClass)
                .Parameters.AddWithValue("@fldSubClassCode", fldSubClassCode)
                .Parameters.AddWithValue("@fldDesc", fldDesc)
                .Parameters.AddWithValue("@fldProcess", fldProcess)
                .Parameters.AddWithValue("@fldQTY", fldQTY)
                .Parameters.AddWithValue("@fldUOM", fldUOM)
                .Parameters.AddWithValue("@fldSOU", fldSOU)
                .Parameters.AddWithValue("@fldCurrency", fldCurrency)
                .Parameters.AddWithValue("@fldUAmount", fldUAmount)
                .Parameters.AddWithValue("@fldAmount", fldAmount)
                .Parameters.AddWithValue("@fldMonthBudgeted", fldMonthBudgeted)
                .Parameters.AddWithValue("@fldRemarks", fldRemarks)
                .Parameters.AddWithValue("@fldSignature", fldSignature)
                .Parameters.AddWithValue("@fldSubRefNo", fldSubRefNo)
                .ExecuteNonQuery()
                .Parameters.Clear()
            End With

            conn.Close()

        Catch ex As Exception
            If conn.State = ConnectionState.Open Then
                conn.Close()
            End If
            success = False

            MsgBox(ex.Message)
        End Try

        Return success

    End Function
    '--------------------------------------------------------------------------------------------------------------------
End Class
