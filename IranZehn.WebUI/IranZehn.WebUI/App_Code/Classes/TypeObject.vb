Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Collections.Generic

Namespace Classes

    Public Class TypeObject
        Public Structure TestResultBlock
            Public QuestionID As Integer
            Public QuestionScore As Integer
            Public QuestionType As String
        End Structure

        Public I As Integer = 0
        Public E As Integer = 0
        Public S As Integer = 0
        Public N As Integer = 0
        Public F As Integer = 0
        Public T As Integer = 0
        Public P As Integer = 0
        Public J As Integer = 0
        Private Const MaxScore As Integer = 20

        Public Sub New(ByVal trbArray As List(Of TestResultBlock))
            I = 0
            E = 0
            S = 0
            N = 0
            F = 0
            T = 0
            P = 0
            J = 0
            For Each trb As TestResultBlock In trbArray
                Select Case trb.QuestionType
                    Case "I"
                        I += trb.QuestionScore
                    Case "E"
                        E += trb.QuestionScore
                    Case "S"
                        S += trb.QuestionScore
                    Case "N"
                        N += trb.QuestionScore
                    Case "F"
                        F += trb.QuestionScore
                    Case "T"
                        T += trb.QuestionScore
                    Case "P"
                        P += trb.QuestionScore
                    Case "J"
                        J += trb.QuestionScore
                End Select
            Next
        End Sub
        Public Sub New(ByVal TypeID As String)
            If TypeID.Length = 4 Then
                If TypeID.Substring(0, 1) = "I" Then
                    Me.I = 1
                    Me.E = 0
                Else
                    Me.I = 0
                    Me.E = 1
                End If
                If TypeID.Substring(1, 1) = "S" Then
                    Me.S = 1
                    Me.N = 0
                Else
                    Me.S = 0
                    Me.N = 1
                End If
                If TypeID.Substring(2, 1) = "T" Then
                    Me.T = 1
                    Me.F = 0
                Else
                    Me.T = 0
                    Me.F = 1
                End If
                If TypeID.Substring(3, 1) = "P" Then
                    Me.P = 1
                    Me.J = 0
                Else
                    Me.P = 0
                    Me.J = 1
                End If
            End If
        End Sub
        Public Shadows ReadOnly Property ToString() As String
            Get
                Return IIf(E > I, "E", "I") + IIf(S > N, "S", "N") + IIf(F > T, "F", "T") + IIf(P > J, "P", "J")
            End Get
        End Property
        Public ReadOnly Property Item(ByVal Index As Integer) As String
            Get
                Return Me.ToString.Substring(Index - 1, 1)
            End Get
        End Property
        Public ReadOnly Property ItemPercent(ByVal Index As Integer) As String
            Get
                Dim percent As Integer = 0
                Select Case Index
                    Case 1
                        percent = Math.Abs(I - E) * 100 / MaxScore
                    Case 2
                        percent = Math.Abs(S - N) * 100 / MaxScore
                    Case 3
                        percent = Math.Abs(F - T) * 100 / MaxScore
                    Case 4
                        percent = Math.Abs(P - J) * 100 / MaxScore
                    Case Else
                        percent = 0
                End Select

                Return percent
            End Get
        End Property

    End Class

End Namespace