
Partial Class Facebook
    Inherits Classes.BasePage

    Protected Sub btnSendToFacebook_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSendToFacebook.Click

        If Session("Facebook_Type") IsNot Nothing Then
            Response.Redirect("http://www.facebook.com/add.php?api_key=&next=?MBTI=" + Session("Facebook_Type").ToString)
        End If

    End Sub

End Class
