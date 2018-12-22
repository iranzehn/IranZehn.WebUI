Imports System.Data

Public Class uNotices
    Inherits System.Web.UI.UserControl

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        'Dim sds As New SqlDataSource(

        With Me.GridView1
            .DataSource = Classes.DataManager.NoticeData.GetAll
            .DataBind()
        End With
        'End If
        'Else
        'Dim c As New PostBackOptions(Me)
        'c.AutoPostBack = False
        'End If
    End Sub

    Protected Sub GridView1_PageIndexChanging(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewPageEventArgs) Handles GridView1.PageIndexChanging
        With Me.GridView1
            .DataSource = Classes.DataManager.NoticeData.GetTableByPageIndex(e.NewPageIndex)
            .DataBind()
        End With
    End Sub

    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged

    End Sub
End Class
