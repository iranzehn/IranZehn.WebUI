Imports Microsoft.VisualBasic
Imports System.Data
Namespace Classes.DataManager

    Public Class ReportData
        '    Public Shared Function GetAll() As DataTable
        '        Return DBManager.GetTableBySelectCommand("SELECT     Types.TypeID, COUNT(TestResults.TypeID) AS ItemCounts FROM Types " + _
        '        "LEFT OUTER JOIN TestResults ON Types.TypeID = TestResults.TypeID " + _
        '        "GROUP BY Types.TypeID ORDER BY COUNT(TestResults.TypeID) DESC ")
        '    End Function
        '    Public Shared Function GetRowByTypeIDGraduateID(ByVal TypeID As String, ByVal GraduateID As Integer) As DataRow
        '        Return DBManager.GetRowBySelectCommand("SELECT     Types.TypeID, COUNT(TestResults.TypeID) AS ItemCounts FROM  Types " + _
        '        "LEFT OUTER JOIN TestResults ON Types.TypeID = TestResults.TypeID " + _
        '        "where GraduateID=" + GraduateID.ToString + " and Types.TypeID='" + TypeID.ToString + "' " + _
        '        "GROUP BY Types.TypeID ORDER BY COUNT(TestResults.TypeID) DESC")
        '    End Function
        '    Public Shared Function GetRowByTypeIDMarriageStatusID(ByVal TypeID As String, ByVal MarriageStatusID As Integer) As DataRow
        '        Return DBManager.GetRowBySelectCommand("SELECT     Types.TypeID, COUNT(TestResults.TypeID) AS ItemCounts FROM  Types " + _
        '        "LEFT OUTER JOIN TestResults ON Types.TypeID = TestResults.TypeID " + _
        '        "where MarriageStatusID=" + MarriageStatusID.ToString + " and Types.TypeID='" + TypeID.ToString + "' " + _
        '        "GROUP BY Types.TypeID ORDER BY COUNT(TestResults.TypeID) DESC")
        '    End Function
        '    Public Shared Function GetRowByTypeIDSexID(ByVal TypeID As String, ByVal SexID As Integer) As DataRow
        '        Return DBManager.GetRowBySelectCommand("SELECT     Types.TypeID, COUNT(TestResults.TypeID) AS ItemCounts FROM  Types " + _
        '        "LEFT OUTER JOIN TestResults ON Types.TypeID = TestResults.TypeID " + _
        '        "where SexID=" + SexID.ToString + " and Types.TypeID='" + TypeID.ToString + "' " + _
        '        "GROUP BY Types.TypeID ORDER BY COUNT(TestResults.TypeID) DESC")
        '    End Function
        Public Shared Function GetAllTestResults() As DataTable
            Return DBManager.GetTableByStoreProcedure("USP_Reports_GetAll")
        End Function

    End Class
End Namespace