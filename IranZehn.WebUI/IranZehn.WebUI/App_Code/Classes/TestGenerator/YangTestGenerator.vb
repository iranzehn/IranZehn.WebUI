Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Namespace Classes.TestGenerator
    Public Class YangTestGenerator
        Public Class TestResultObject
            Public IPAddress As String = "-"
            Public BornData As String
            Public SexID As Integer
            Public GraduateID As Integer
            Public MarriageStatusID As Integer
            Public TestDetails As List(Of TypeObject.TestResultBlock)
        End Class

        Public Function GetExamTable() As Data.DataTable
            Dim dt As DataTable = DataManager.QuestionData.GetAll
            RandomizeTable(dt)
            Return dt
        End Function
        Public Function CheckExamResult(ByVal objArray As List(Of TypeObject.TestResultBlock)) As TypeObject
            Return New TypeObject(objArray)
        End Function
        Public Sub SaveTestResultDetails(ByVal tro As TestResultObject, ByVal tp As TypeObject)


            Dim TestResultID As Integer = DataManager.TestResultData.InsertRow(
                                               tro.IPAddress,
                                               tro.BornData,
                                               tro.SexID,
                                               tro.MarriageStatusID,
                                               tro.GraduateID,
                                               tp.ToString,
                                               tp.ItemPercent(1),
                                               tp.ItemPercent(2),
                                               tp.ItemPercent(3),
                                               tp.ItemPercent(4))
            If TestResultID > 0 Then
                For Each trb As TypeObject.TestResultBlock In tro.TestDetails
                    Dim QuestionScore As Integer = trb.QuestionScore
                    Dim QuestionID As Integer = trb.QuestionID
                    DataManager.TestResultDetailData.InsertRow(TestResultID, QuestionID, QuestionScore)
                Next
            End If

        End Sub

        Private Sub RandomizeTable(ByRef myTable As DataTable)
            Dim newTable As DataTable = myTable.Clone
            newTable.Rows.Clear()
            Dim mArray(myTable.Rows.Count - 1) As Integer
            For i As Integer = 0 To myTable.Rows.Count - 1
                Dim r As DataRow = myTable.Rows(i)
                mArray(i) = r("QuestionID")
            Next
            RandomizeArray(mArray)
            For Each ID As Integer In mArray
                Dim r As DataRow = myTable.Select("QuestionID=" + ID.ToString)(0)
                Dim rNew As DataRow = newTable.NewRow
                rNew.ItemArray = r.ItemArray
                rNew.Table.Rows.Add(rNew)
            Next
            myTable = newTable
        End Sub
        Private Sub RandomizeArray(ByRef indexes() As Integer)
            Dim num_items As Integer
            Dim j As Integer
            Dim tmp As Integer

            ' Randomize the array.
            Randomize()
            num_items = indexes.GetUpperBound(0)
            For i As Integer = 0 To num_items - 2
                ' Pick a random entry.
                j = CInt(Int((num_items - i) * Rnd() + i))

                'Swap the numbers.
                tmp = indexes(i)
                indexes(i) = indexes(j)
                indexes(j) = tmp
            Next i
        End Sub



    End Class



End Namespace