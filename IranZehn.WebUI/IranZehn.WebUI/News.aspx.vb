Imports System.Data

Public Class News
    Inherits Classes.BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then

            Dim param As Object = Request.Params("ID")
            If Not param Is Nothing Then
                Dim dr As DataRow = Classes.DataManager.NoticeData.GetRowByNoticeID(param)
                If Not dr Is Nothing Then
                    lblTitle.Text = Classes.MyStrings.ReverseDate(dr("NoticeDate")) + "   -   " + dr("NoticeTitle")
                    PlaceHolder1.Controls.Add(New LiteralControl(dr("NoticeContent").ToString()))
                End If
            End If

        End If

    End Sub

End Class
 