
Public Class PrintPreview
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Exit Sub
        End If
        If Session("PrintContent") Is Nothing Then
            Response.Redirect("~")
        Else
            Me.PlaceHolder1.Controls.Add(New LiteralControl(Session("PrintContent")))
        End If

    End Sub
End Class
