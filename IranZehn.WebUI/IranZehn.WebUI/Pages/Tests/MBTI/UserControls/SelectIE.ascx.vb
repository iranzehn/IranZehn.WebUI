Namespace Pages.Tests.MBTI.UserControls

    Public Class SelectIE
        Inherits System.Web.UI.UserControl


        Public ReadOnly Property IsIntroverted() As Integer
            Get
                Try
                    If rbE.Checked Then
                        Return 0
                    ElseIf rbI.Checked Then
                        Return 1
                    End If
                    Return -1
                Catch ex As Exception
                    MsgBox("SelectIE-IsIntroverted")
                    Return -1
                End Try
            End Get
        End Property


    End Class

End Namespace