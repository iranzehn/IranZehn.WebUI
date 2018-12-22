Imports Microsoft.VisualBasic
Imports System.Data

Namespace Classes.DataManager

    Public Class DBManager

        Public Shared Function ConnectionString() As String

            'Return "Data Source=.\sql2008r2;Initial Catalog=IranZehn;Integrated Security=True"
            'Return "Server=223.252.25.161,25000;Database=235_IranZehn;Uid=DB235_tyloman;Password=ULsNs9j8WSjj;"
            Return ApplicationCache.IranZehnDB '"Server=qwe\sql2014;Database=IranZehn;;Uid=sa;Password=qweewq1!;"
        End Function

        Public Shared Function GetTableBySelectCommand(ByVal cmdText As String) As DataTable

            Dim da As New SqlClient.SqlDataAdapter(cmdText, ConnectionString)
            Dim dt As New DataTable
            da.Fill(dt)
            Return dt

        End Function

        Public Shared Function GetRowBySelectCommand(ByVal cmdText As String) As DataRow

            Dim da As New SqlClient.SqlDataAdapter(cmdText, ConnectionString)
            Dim dt As New DataTable
            da.Fill(dt)
            If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            End If
            Return Nothing

        End Function

        Public Shared Function InsertByStoredProcedure(ByVal SpName As String, params() As Generic.KeyValuePair(Of String, Object)) As Integer

            Dim cmd As New SqlClient.SqlCommand(SpName, New SqlClient.SqlConnection(ConnectionString))

            If (params IsNot Nothing) Then
                For Each pair As Generic.KeyValuePair(Of String, Object) In params
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value)
                Next
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection.Open()
            Dim ID As Integer = cmd.ExecuteScalar()
            cmd.Connection.Close()

            Return ID

        End Function

        Public Shared Function RunStoredProcedure(ByVal SpName As String) As Integer

            Return RunStoredProcedure(SpName, Nothing)

        End Function

        Public Shared Function RunStoredProcedure(ByVal SpName As String, ByVal params As Object) As Integer

            Dim cmd As New SqlClient.SqlCommand(SpName, New SqlClient.SqlConnection(ConnectionString))

            If (params IsNot Nothing) Then
                For Each pair As Generic.KeyValuePair(Of String, Object) In params
                    cmd.Parameters.AddWithValue(pair.Key, pair.Value)
                Next
            End If

            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection.Open()
            Dim ID As Integer = cmd.ExecuteScalar()
            cmd.Connection.Close()
            Return ID

        End Function

        Public Shared Function GetTableByStoreProcedure(spName As String) As DataTable
            Return GetTableByStoreProcedure(spName, Nothing)
        End Function

        Public Shared Function GetTableByStoreProcedure(spName As String, params() As Generic.KeyValuePair(Of String, Object)) As DataTable
            Dim da As New SqlClient.SqlDataAdapter(spName, ConnectionString)
            Dim dt As New DataTable

            If (params IsNot Nothing) Then
                For Each pair As Generic.KeyValuePair(Of String, Object) In params
                    da.SelectCommand.Parameters.AddWithValue(pair.Key, pair.Value)
                Next
            End If

            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.Fill(dt)
            Return dt
        End Function

        Public Shared Function GetRowByStoreProcedure(spName As String) As DataRow
            Return GetRowByStoreProcedure(spName, Nothing)
        End Function

        Public Shared Function GetRowByStoreProcedure(spName As String, params() As Generic.KeyValuePair(Of String, Object)) As DataRow
            Dim dt As DataTable = GetTableByStoreProcedure(spName, params)
            If (dt IsNot Nothing AndAlso dt.Rows.Count > 0) Then
                Return dt.Rows(0)
            End If
            Return Nothing
        End Function

    End Class

End Namespace