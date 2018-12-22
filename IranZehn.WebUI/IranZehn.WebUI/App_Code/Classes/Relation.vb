Imports Microsoft.VisualBasic

Namespace Classes

    Public Class Relations

        Public Shared Function GetRelation(ByVal Type1 As String, ByVal Type2 As String) As String
            Dim t1(3), t2(3) As Char
            t1 = Type1.ToCharArray
            t2 = Type2.ToCharArray
            Dim result As String = CheckLetters(t1, t2)
            '&lt; >
            '&gt; <
            Select Case result
                Case "0000" '0
                    Return "CNF"
                Case "0001" '1
                    Return "DLT"
                Case "0010" '2
                    Return IIf(t1(3) = "P", "&lt;SP", "&gt;SP")
                Case "0011" '3
                    Return IIf(t1(3) = "P", "SDL", "ILL")
                Case "0100" '4
                    Return IIf(t1(3) = "P", "&gt;SP", "&lt;SP")
                Case "0101" '5
                    Return IIf(t1(3) = "P", "ILL", "SDL")
                Case "0110" '6
                    Return "MRR"
                Case "0111" '7
                    Return "CNT"
                Case "1000" '8
                    Return "ACT"
                Case "1001" '9
                    Return "EGO"
                Case "1010" '10
                    Return IIf(t1(3) = "P", "&gt;BN", "&lt;BN")
                Case "1011" '11
                    Return IIf(t1(3) = "P", "LKL", "CMP")
                Case "1100" '12
                    Return IIf(t1(3) = "P", "&lt;BN", "&gt;BN")
                Case "1101" '13
                    Return IIf(t1(3) = "P", "CMP", "LKL")
                Case "1110"
                    Return "QID"
                Case "1111"
                    Return "IDN"
            End Select
            Return "-"
        End Function

        Private Shared Function CheckLetters(ByVal t1 As Char(), ByVal t2 As Char()) As String
            Dim b(3) As Char
            For index As Integer = 0 To 3
                b(index) = IIf(t1(index) = t2(index), "1", "0")
            Next
            Return New String(b)
        End Function

    End Class

End Namespace