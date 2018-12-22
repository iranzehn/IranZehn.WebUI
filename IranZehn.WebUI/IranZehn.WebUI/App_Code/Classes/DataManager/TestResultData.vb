Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class TestResultData


 
        Public Shared Sub UpdateRow(ByVal p() As Object)
            'First Parameter is ID
            DBManager.RunStoredProcedure("SP_UpdateTestDetail", p)
        End Sub
        Public Shared Function GetRowByTestResultID(ByVal TestResultID As Integer) As DataRow

            Return DBManager.GetRowByStoreProcedure("USP_TestResults_SelectByTestResultID]",
                                                    {New Generic.KeyValuePair(Of String, Object)("@TestResultID", TestResultID)})

        End Function

        Public Shared Function InsertRow(IPAddress As String, BornData As String, SexID As Integer, MarriageStatusID As Integer, GraduateID As Integer, _
                                         TypeID As String, Percent1 As String, Percent2 As String, Percent3 As String, Percent4 As String) As Integer

            Return DBManager.RunStoredProcedure("USP_TestResults_Insert",
                                                {New Generic.KeyValuePair(Of String, Object)("@IPAddress", IPAddress),
                                                 New Generic.KeyValuePair(Of String, Object)("@BornDate", BornData),
                                                 New Generic.KeyValuePair(Of String, Object)("@SexID", SexID),
                                                 New Generic.KeyValuePair(Of String, Object)("@MarriageStatusID", MarriageStatusID),
                                                 New Generic.KeyValuePair(Of String, Object)("@GraduateID", GraduateID),
                                                 New Generic.KeyValuePair(Of String, Object)("@TypeID", TypeID),
                                                 New Generic.KeyValuePair(Of String, Object)("@Percent1", Percent1),
                                                 New Generic.KeyValuePair(Of String, Object)("@Percent2", Percent2),
                                                 New Generic.KeyValuePair(Of String, Object)("@Percent3", Percent3),
                                                 New Generic.KeyValuePair(Of String, Object)("@Percent4", Percent4)})

        End Function

    End Class
End Namespace