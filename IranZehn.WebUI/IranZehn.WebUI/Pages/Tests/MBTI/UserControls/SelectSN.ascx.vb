Namespace Pages.Tests.MBTI.UserControls
    Public Class SelectSN
        Inherits System.Web.UI.UserControl

        Public ReadOnly Property IsSensitive() As Integer
            Get
                Try
                    If rbN.Checked Then
                        Return 0
                    ElseIf rbS.Checked Then
                        Return 1
                    End If
                    Return -1
                Catch ex As Exception
                    MsgBox("SelectSN-IsSensor")
                    Return -1
                End Try
            End Get
        End Property
    End Class

End Namespace