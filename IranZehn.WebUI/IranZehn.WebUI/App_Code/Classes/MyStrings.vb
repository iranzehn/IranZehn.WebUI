Imports Microsoft.VisualBasic

Namespace Classes

    Public Class MyStrings

        Public Shared Function QuteStr(ByVal str As String) As String
            Return ("'" + str + "'")
        End Function

        Public Shared Function ToHtmlString(ByVal str As String) As String
            Return str.Replace(vbCrLf, "<br/>") '.Replace(" ", "&nbsp")
        End Function

        Public Shared Function ReverseDate(ByVal str As String) As String
            If str.Length <> 10 Then
                Return str
            End If
            Return str.Substring(8, 2) + "/" + str.Substring(5, 2) + "/" + str.Substring(0, 4)
        End Function

    End Class

End Namespace
