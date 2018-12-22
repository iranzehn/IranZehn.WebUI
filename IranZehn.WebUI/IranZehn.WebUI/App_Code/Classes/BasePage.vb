Imports Microsoft.VisualBasic

Namespace Classes

    Public Class BasePage
        Inherits System.Web.UI.Page

        Protected Sub Page_PreInit(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.PreInit

            ''This is necessary because Safari and Chrome browsers don't display the Menu control correctly.
            ''All webpages displaying an ASP.NET menu control must inherit this class.
            'If (Request.ServerVariables("http_user_agent").IndexOf("Safari", StringComparison.CurrentCultureIgnoreCase) <> -1) Then
            '    Page.ClientTarget = "uplevel"
            'End If

        End Sub

    End Class

End Namespace
