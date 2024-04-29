Imports MySql.Data.MySqlClient
Imports Telerik.Reporting
Imports System.Data.SqlClient
Module globalVariables
    Public currentUser As DataRow = Nothing
    Public myParamSAP As New List(Of SqlParameter)
    Public myParam As New List(Of MySqlParameter)
    Public myCmdSAP As New SqlCommand
    Public myCmd As New MySqlCommand
    Public myAdapterSAP As New SqlDataAdapter
    Public myAdapter As New MySqlDataAdapter
    Public aedType As Integer = 0
    Public aedTypeSAP As Integer = 0
    Public errorMessage As String

    Public Section As String
    Public Dept As String
    Public EmpName As String

    Public myReportParam As New List(Of Parameter)
    Public RID As String
    Public EmpGroup As String
    Public RFQNo As String
    Public Department As String
    Public d1 As DateTime
    Public d2 As DateTime
    Public BudRefNo As String
    Public Budget As Decimal
    Public UPO As Decimal
    Public PO As Decimal
    Public PRNPO As Decimal
    Public RBLessPR As Decimal
    Public PassBudRefNo As String
    Public _PO As String

    Public Desc As String
    Public JPY As Decimal
    Public Dpt As String
    Public SubRef As String
    Public SubRefDesc As String
    Public Year As String
    Public YearReport As String
    Public _Class As String
    Public dtRepSource As DataTable
    Public dtImport As DataTable
    Public ImportSelect As String


    Public RFQID As String
    Public CheckedBy As String
    Public ApprovedBy As String
    Public DateRequest As Date
    Public CPosition As String
    Public APosition As String

    Public Process As String
    Public Choice As String
    Public Choose As String
    '------------User Info-------------------------

    Public LoginUID As String
    Public LoginUserLvl As String
    Public LoginDept As String
    Public LoginSignature As String
    Public LoginRFQ As String
    Public InvstmentNo As String
    Public LoginRFQSection As String

    Public OBLine As String
    Public POID As String
    Public MID As String
    Public ModelSearchValue As String

    Public ReportServer As String
    Public ReportUser As String
    Public ReportPass As String

    Public ReportCategory As String

End Module

