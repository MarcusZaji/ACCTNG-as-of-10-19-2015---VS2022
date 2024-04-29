Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Public Class ReportServer

    Shared Function addParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New MySqlParameter(name, value)
        myParam.Add(newParameter)

        Return True
    End Function

    Shared Function dbAED(ByVal query As String) As Boolean

        Dim myConn As New MySqlConnection(ConnReportServer)

        Try
            myConn.Open()

            myCmd = New MySqlCommand(query, myConn)
            myCmd.CommandType = CommandType.StoredProcedure
            myParam.ForEach(Function(p) myCmd.Parameters.Add(p))
            myCmd.ExecuteNonQuery()
            myParam.Clear()

            myConn.Close()

        Catch ex As Exception
            myConn.Close()
            myParam.Clear()

            If aedType = 0 Then
                RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)
            Else
                errorMessage = ex.Message
            End If

            Return False
        End Try

        Return True
    End Function

    Shared Function dbSelect(ByVal query As String) As DataTable

        Dim myData As DataTable = Nothing

        Dim myConn As New MySqlConnection(ConnReportServer)

        Try
            myConn.Open()

            myCmd = New MySqlCommand(query, myConn)
            myCmd.CommandType = CommandType.StoredProcedure
            myCmd.CommandTimeout = 0
            myParam.ForEach(Function(p) myCmd.Parameters.Add(p))

            myData = New DataTable
            myAdapter = New MySqlDataAdapter(myCmd)
            myAdapter.Fill(myData)

            myParam.Clear()

            myConn.Close()
        Catch ex As Exception
            myConn.Close()
            myParam.Clear()

            RadMessageBox.Show(ex.Message, "WARNING", MessageBoxButtons.OK, RadMessageIcon.Exclamation)

        End Try

        myConn = Nothing

        Return myData
    End Function
    Shared Function addReportParameter(ByVal name As String, ByVal value As Object) As Boolean
        Dim newParameter As New Telerik.Reporting.Parameter(name, value)
        myReportParam.Add(newParameter)

        Return True
    End Function

    Public Shared Function convertToDatatable(Of T)(ByVal data As IList(Of T)) As DataTable
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))
        Dim table As DataTable = New DataTable()
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name)
        Next

        For Each item As T In data
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next

            table.Rows.Add(row)
        Next

        Return table
    End Function

    Shared Function getClipboard() As DataTable

        Dim ClipboardData As IDataObject = Clipboard.GetDataObject()

        Dim Table As New DataTable With {.TableName = "ExcelData"}

        If Not ClipboardData Is Nothing Then
            If (ClipboardData.GetDataPresent(DataFormats.CommaSeparatedValue)) Then

                Dim ClipboardStream As New IO.StreamReader(
                       CType(ClipboardData.GetData(DataFormats.CommaSeparatedValue), IO.Stream))

                Dim FormattedData As String = ""

                While (ClipboardStream.Peek() > 0)
                    Dim SingleRowData As Array
                    Dim LoopCounter As Integer = 0

                    FormattedData = ClipboardStream.ReadLine()

                    SingleRowData = FormattedData.Split(",".ToCharArray)

                    If Table.Columns.Count <= 0 Then
                        For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                            Table.Columns.Add()
                        Next
                        LoopCounter = 0
                    End If

                    Dim rowNew As DataRow
                    rowNew = Table.NewRow()

                    For LoopCounter = 0 To SingleRowData.GetUpperBound(0)
                        rowNew(LoopCounter) = SingleRowData.GetValue(LoopCounter)
                    Next

                    LoopCounter = 0

                    Table.Rows.Add(rowNew)

                    rowNew = Nothing
                End While

                ClipboardStream.Close()

            Else
                RadMessageBox.Show("Clipboard data does not seem to be copied from Excel!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
            End If
        Else
            RadMessageBox.Show("Clipboard is empty!", "FEAP HRMS", MessageBoxButtons.OK, RadMessageIcon.Error)
        End If

        Return Table

    End Function
    Shared Function IsFormOpen(ByVal frm As Form) As Boolean
        If System.Windows.Forms.Application.OpenForms.OfType(Of Form).Contains(frm) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
