Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class TemperamentData

        Public Shared Function GetRowByTemperamentID(ByVal TemperamentID As String) As DataRow
            Return DBManager.GetRowByStoreProcedure("USP_Temperaments_GetByTemperamentID",
                                      {New Generic.KeyValuePair(Of String, Object)("@TemperamentID", TemperamentID)})
        End Function

    End Class
End Namespace