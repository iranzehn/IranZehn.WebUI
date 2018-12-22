Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager
    Public Class QuestionData
        Public Shared Function GetAll() As DataTable
            Return DBManager.GetTableByStoreProcedure("USP_Questions_SelectAll")
        End Function
    End Class
End Namespace