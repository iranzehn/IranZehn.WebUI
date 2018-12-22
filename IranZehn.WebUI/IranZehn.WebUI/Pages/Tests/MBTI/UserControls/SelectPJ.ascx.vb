Namespace Pages.Tests.MBTI.UserControls

    Public Class SelectPJ
        Inherits System.Web.UI.UserControl
        Public ReadOnly Property IsJudger() As Integer
            Get
                Try
                    If rbP.Checked Then
                        Return 0
                    ElseIf rbJ.Checked Then
                        Return 1
                    End If
                    Return -1
                Catch ex As Exception
                    MsgBox("SelectPJ-IsJudger")
                    Return -1
                End Try
            End Get
        End Property
    End Class

End Namespace