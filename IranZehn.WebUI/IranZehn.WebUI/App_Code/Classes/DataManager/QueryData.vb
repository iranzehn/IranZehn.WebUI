Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class QueryData
        Public Shared Function GetTypePercentByTestResultID(ByVal TestResultID As Integer) As DataTable
            Return DBManager.GetTableByStoreProcedure("USP_Questions_GetDetailsByTestResultID",
                                                      {New Generic.KeyValuePair(Of String, Object)("@TestResultID", TestResultID)})
        End Function
    End Class
End Namespace