Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class TypeData
        Public Shared Function GetAll() As DataTable
            Return DBManager.GetTableByStoreProcedure("USP_Types_SelectAll")
        End Function
        Public Shared Function GetTypes() As String()
            Static types() As String = Nothing
            If types Is Nothing Then
                Dim dt As DataTable = DBManager.GetTableByStoreProcedure("USP_Types_SelectAllTypeIDs")
                If dt Is Nothing Then
                    Return Nothing
                End If
                Dim str(dt.Rows.Count - 1) As String
                For Index As Integer = 0 To dt.Rows.Count - 1
                    Dim dr As DataRow = dt.Rows(Index)
                    str(Index) = dr(0)
                Next
                types = str
            End If
            Return types
        End Function
        Public Shared Function GetRowByTypeID(ByVal TypeID As String) As DataRow
            Return DBManager.GetRowByStoreProcedure("USP_Types_SelectByTypeID",
                                                    {New Generic.KeyValuePair(Of String, Object)("@TypeID", TypeID)})
        End Function
    End Class
End Namespace