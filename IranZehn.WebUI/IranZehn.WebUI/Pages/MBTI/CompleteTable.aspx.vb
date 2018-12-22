Public Class CompleteTable
    Inherits Classes.BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Exit Sub
        End If

        'PlaceHolder1.Controls.Add(New LiteralControl(CreateTable))
        FillDropDown(Me.ddlType01)
        FillDropDown(Me.ddlType02)

    End Sub

    Private Sub FillDropDown(ByRef ddl As DropDownList)
        ddl.Items.Clear()
        For Each s As String In Classes.DataManager.TypeData.GetTypes()
            ddl.Items.Add(s)
        Next
    End Sub

    Private Function CreateTable() As String
        Dim HC As String = ""
        HC += "<table>"
        Dim str() As String = Classes.DataManager.TypeData.GetTypes
        Dim iCount As Integer = str.Length - 1
        For r As Integer = 0 To iCount
            HC += "<tr>"
            For c As Integer = 0 To iCount
                If c = 0 And r = 0 Then
                    HC += "<td style='border: 1px solid black;width:30px;font-family:Tahoma;font-size:small;text-align:center;vertical-align:middle;color:Black;'>"
                    HC += "<img alt='Corner' id='cornerImage' src='Images/Corner.png' align='top' style='padding: 0px;margin: 0px;' />"
                ElseIf c = 0 Then
                    HC += "<td style='border: 1px solid black;width:30px;font-family:Tahoma;font-size:small;text-align:center;vertical-align:middle;background:#FFFF99;color:Black;' onmouseover='txt_onmouseover(this)' onmouseout='txt_onmouseout(this)'>"
                    HC += "<input id='txt" + Format(r, "00") + Format(c, "00") + "' type='hidden' style='background:#FFFF99;    border-style: none; border-width: 0px;width:32px;'value='" + str(r - 1).Trim.ToString + "'/>"
                    HC += str(r - 1).Trim.ToString
                ElseIf r = 0 Then
                    HC += "<td style='border: 1px solid black;width:30px;font-family:Tahoma;font-size:small;text-align:center;vertical-align:middle;background:#0066FF;color:Black;' onmouseover='txt_onmouseover(this)' onmouseout='txt_onmouseout(this)'>"
                    HC += "<input id='txt" + Format(r, "00") + Format(c, "00") + "' type='hidden' style='background:#0066FF;    border-style: none; border-width: 0px;width:32px;'value='" + str(c - 1).Trim.ToString + "'/>"
                    HC += str(c - 1).Trim.ToString
                Else
                    HC += "<td style='border: 1px solid black;width:30px;font-family:Tahoma;font-size:small;text-align:center;vertical-align:middle;color:Black;'>"
                    HC += "<input id='txt" + Format(r, "00") + Format(c, "00") + "' type='text' style='background:transparent;  border-style: none; border-width: 0px;width:30px;font-size:small;cursor:pointer;' onmouseover='txt_onmouseover(this)' onmousedown='txt_onmousedown(this)' onmouseout='txt_onmouseout(this)' value='" + Classes.Relations.GetRelation(str(r - 1), str(c - 1)) + "'/>"
                End If
                HC += "</td>"
            Next
        Next
        HC += "</table>"
        Return HC
    End Function

    Private Function CreateResult(ByVal Type1 As String, ByVal Type2 As String) As String
        Dim Relation As String = Classes.Relations.GetRelation(Type1, Type2)
        'MsgBox(Relation)
        Dim dr As Data.DataRow = Classes.DataManager.RelationData.GetRowByRelationID(Relation.Replace("&lt;", "").Replace("&gt;", ""))
        If dr Is Nothing Then
            Return ""
        End If
        Dim HC As String = ""
        HC += "<Table>"
        HC += "<tr>"
        HC += "<td>"
        HC += "<p style='font-family:tahoma;font-size:small;text-align: right'>"
        HC += "<br/>"
        HC += "<span style='color: black'>&nbsp;رابطه</span> "
        HC += "<span style='color: #FF0000'>" + dr("PersianTitle").ToString + "(" + dr("EnglishTitle").ToString + ")" + "</span>"
        HC += "<span style='color: black'>&nbsp;بین تیپ های شخصیتی :</span>"
        For i As Integer = 1 To dr("StarCount")
            HC += "<img alt='' src='Images/Star.png'/>"
        Next
        If Relation.Contains("&lt;") Then
            HC += "<br/>"
            HC += "<span style='color: black'>در این رابطه </span> "
            HC += "<span style='color: #FF0000'>" + Type1 + "</span>"
            HC += "<span style='color: black'>" + dr("Title01Persian").ToString + "(" + dr("Title01English").ToString + ")" + "</span>"
            HC += "<span style='color: black'> و </span> "
            HC += "<span style='color: #FF0000'>" + Type2 + "</span>"
            HC += "<span style='color: black'>" + dr("Title02Persian").ToString + "(" + dr("Title02English").ToString + ")" + "</span>"
            HC += "<span style='color: black'> می باشند. </span> "
        ElseIf Relation.Contains("&gt;") Then
            HC += "<br/>"
            HC += "<span style='color: black'>در این رابطه </span> "
            HC += "<span style='color: #FF0000'>" + Type1 + "</span>"
            HC += "<span style='color: black'>&nbsp;" + dr("Title02Persian").ToString + "(" + dr("Title02English").ToString + ")" + "</span>"
            HC += "<span style='color: black'> و </span> "
            HC += "<span style='color: #FF0000'>" + Type2 + "</span>"
            HC += "<span style='color: black'>&nbsp;" + dr("Title01Persian").ToString + "(" + dr("Title01English").ToString + ")" + "</span>"
            HC += "<span style='color: black'> می باشند. </span> "
        End If
        HC += "</p>"
        HC += "</td>"
        HC += "</tr>"
        HC += "<tr>"
        HC += "<td>"
        HC += "<p style='font-family:tahoma;font-size:small;text-align: justify'>"

        HC += "<span style='color: black'>" + Classes.MyStrings.ToHtmlString(dr("RelationDescription")) + "</span>"
        HC += "</p>"
        HC += "</td>"
        HC += "</tr>"
        HC += "</Table>"
        Return HC
    End Function

    Protected Sub btnRelation_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRelation.Click
        ibPrint.Visible = True
        PlaceHolder1.Controls.Add(New LiteralControl(CreateResult(ddlType01.SelectedValue, ddlType02.SelectedValue)))
    End Sub

    Protected Sub ibPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibPrint.Click
        Session("PrintContent") = CreateResult(ddlType01.SelectedValue, ddlType02.SelectedValue)
        Response.Redirect("~/PrintPreview.aspx")
    End Sub

End Class
 