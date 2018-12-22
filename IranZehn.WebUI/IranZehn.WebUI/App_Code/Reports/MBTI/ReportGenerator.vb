Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Namespace Classes.Reports.MBTI

    Public Class ReportGenerator

        Public Function GetData() As List(Of Classes.TableStructure.TestResults)
            Dim l As New List(Of TableStructure.TestResults)
            For Each dr As DataRow In DataManager.ReportData.GetAllTestResults.Rows
                Dim r As New TableStructure.TestResults(dr)
                l.Add(r)
            Next
            Return l
        End Function

    End Class

End Namespace