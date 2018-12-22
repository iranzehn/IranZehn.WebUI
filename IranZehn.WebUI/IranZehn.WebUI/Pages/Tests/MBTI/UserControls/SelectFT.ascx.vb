Namespace Pages.Tests.MBTI.UserControls
    Public Class SelectFT
        Inherits System.Web.UI.UserControl

        Public ReadOnly Property IsThinker() As Integer
            Get
                Try
                    If rbF.Checked Then
                        Return 0
                    ElseIf rbT.Checked Then
                        Return 1
                    End If
                    Return -1
                Catch ex As Exception
                    MsgBox("SelectFT-IsThinker")
                    Return -1
                End Try
            End Get
        End Property

    End Class

End Namespace