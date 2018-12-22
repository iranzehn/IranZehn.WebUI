Imports Microsoft.VisualBasic
Imports System.Data

Namespace Classes.DataManager

    Public Class NoticeData

        Public Shared Function GetAll() As DataTable
            Return DBManager.GetTableByStoreProcedure("USP_Notices_SelectAll")
        End Function

        Public Shared Function GetRowByNoticeID(ByVal NoticeID As String) As DataRow

            Return DBManager.GetRowByStoreProcedure("USP_Notices_SelectByNoticeId",
                                                    {New Generic.KeyValuePair(Of String, Object)("@NoticeID", NoticeID)})

        End Function

        Public Shared Function GetTableByPageIndex(ByVal PageIndex As Integer) As DataTable
            Dim query As String = "Select *,dbo.ReverseDate(NoticeDate) as NDate," + _
                                  "(select count(*) from Notices as A2 Where A2.NoticeID<=A1.NoticeID ) " + _
                                  "From Notices as A1 " + _
                                  "Where (select count(*) from Notices as A2 Where A2.NoticeID<=A1.NoticeID ) >" + (PageIndex * 5).ToString '+ " and  " + _
            Return DBManager.GetTableByStoreProcedure("USP_Notices_SelectByPageIndex",
                                                     {New Generic.KeyValuePair(Of String, Object)("@PageIndex", PageIndex)})
        End Function

    End Class
End Namespace