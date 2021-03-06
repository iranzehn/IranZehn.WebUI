Imports Microsoft.VisualBasic
Imports System.Data

Namespace IranZehn.TestGenerator

    Public MustInherit Class BaseTestGenerator

        Public MustOverride Sub ShowStartQuestions()
        Public MustOverride Sub SaveStartQuestionsResults(ByVal data As Object)
        Public MustOverride Sub ShowTestQuestions()
        Public MustOverride Sub SaveTestQuestionsResults()
        Public MustOverride Sub ShowFinalResults()
        'Public MustOverride Sub RunTest()

        Protected Sub RandomizeTable(ByRef myTable As DataTable)
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