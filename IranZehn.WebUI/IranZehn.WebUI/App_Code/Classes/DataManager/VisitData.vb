Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager

    Public Class VisitData

        Public Structure VisitResult
            Public Today As String
            Public Total As String
        End Structure

        Public Shared Function GetVisitCount() As VisitResult

            Dim dr As DataRow = DBManager.GetRowBySelectCommand("select * from Visits")
            Dim visitResult As New VisitResult With {
                .Today = "0",
                .Total = "0"
            }

            If Not dr Is Nothing Then
                visitResult.Today = Format(dr("TodayVisitCount"), "###,###,###,###,###,##0")
                visitResult.Total = Format(dr("VisitCount"), "###,###,###,###,###,##0")
            End If

            Return visitResult

        End Function

        Public Shared Sub DoVisit()
            DBManager.RunStoredProcedure("USP_Visits_Save")
        End Sub

    End Class

End Namespace