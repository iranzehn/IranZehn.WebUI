Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager

    Public Class TestResultDetailData

        Shared Sub InsertRow(TestResultID As Integer, QuestionID As Integer, QuestionScore As Integer)

            DBManager.InsertByStoredProcedure("USP_TestResultDetails_Insert",
                                              {New Generic.KeyValuePair(Of String, Object)("@TestResultID", TestResultID),
                                               New Generic.KeyValuePair(Of String, Object)("@QuestionID", QuestionID),
                                               New Generic.KeyValuePair(Of String, Object)("@Score", QuestionScore)})
        End Sub

    End Class

End Namespace