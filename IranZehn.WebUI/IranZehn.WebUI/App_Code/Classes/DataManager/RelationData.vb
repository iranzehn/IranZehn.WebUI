Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class RelationData
        Public Shared Function GetAll() As DataTable
            Return DBManager.GetTableBySelectCommand("USP_Relations_SelectAll")
        End Function
        Public Shared Function GetRowByRelationID(ByVal RelationID As String) As DataRow
            Return DBManager.GetRowByStoreProcedure("USP_Relations_USP_Relations_SelectByRelationID",
                                                   {New Generic.KeyValuePair(Of String, Object)("@RelationID", RelationID)})
        End Function
    End Class
End Namespace