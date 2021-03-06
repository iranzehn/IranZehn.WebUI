Imports System.Collections.Generic
Imports System.Data
Imports IranZehn.Classes

Namespace Pages.Tests.MBTI.UserControls
    Partial Class Step02
        Inherits System.Web.UI.UserControl
        Private myTestGenerator As New TestGenerator.YangTestGenerator


        Public ReadOnly Property Step02Result() As List(Of TypeObject.TestResultBlock)
            Get
                Dim _Step02Result As New List(Of TypeObject.TestResultBlock)
                For Each ctl As Control In Me.Repeater1.Controls
                    If Not ctl.FindControl("RadioButton1") Is Nothing Then
                        Dim c As New TypeObject.TestResultBlock With {
                            .QuestionID = CType(ctl.FindControl("RadioButton1"), RadioButton).GroupName,
                            .QuestionScore = GetQuestionScore(ctl.Controls(0)),
                            .QuestionType = CType(ctl.FindControl("PreferenceID"), TextBox).Text
                        }
                        _Step02Result.Add(c)
                    End If
                Next
                Return _Step02Result
            End Get
        End Property
        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
            If Not IsPostBack Then
                Dim c As New TestGenerator.YangTestGenerator
                Session("CurrentQuestions") = c.GetExamTable
                Repeater1.DataSource = Session("CurrentQuestions")
                Repeater1.DataBind()
            End If
        End Sub
        Private Function GetQuestionScore(ByVal c As Control) As Integer
            If CType(c.FindControl("RadioButton1"), RadioButton).Checked Then
                Return 0
            End If
            If CType(c.FindControl("RadioButton2"), RadioButton).Checked Then
                Return 1
            End If
            If CType(c.FindControl("RadioButton3"), RadioButton).Checked Then
                Return 2
            End If
            Return 0
        End Function


        Protected Sub IbPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibPrint.Click
            Dim dt As DataTable
            dt = Session("CurrentQuestions")
            Dim HC As New StringBuilder
            HC.AppendLine("<Table style='width: 100%'>")

            For Index As Integer = 0 To dt.Rows.Count - 1
                Dim dr As DataRow = dt.Rows(Index)
                HC.AppendLine("<tr>")
                HC.AppendLine("<td colspan='3' style='width: 100%'>")
                HC.AppendLine((Index + 1).ToString + " - " + dr("QuestionContent").ToString())
                HC.AppendLine("</td>")
                HC.AppendLine("</tr>")


                HC.AppendLine("<tr>")

                HC.AppendLine("<td style='width: 33%'>")
                HC.AppendLine("ابدا اینطور نیستم")
                HC.AppendLine("</td>")
                HC.AppendLine("<td style='width: 33%'>")
                HC.AppendLine("تا اندازه ای اینطور هستم ")
                HC.AppendLine("</td>")
                HC.AppendLine("<td style='width: 33%'>")
                HC.AppendLine("کاملا اینطور هستم")
                HC.AppendLine("</td>")

                HC.AppendLine("</tr>")

                HC.AppendLine("<tr>")
                HC.AppendLine("<td colspan='3' style='width: 100%'>")
                HC.AppendLine("<BR/>")
                HC.AppendLine("</td>")
                HC.AppendLine("</tr>")

            Next
            HC.AppendLine("</Table>")

            Session("PrintContent") = HC.ToString
            Response.Redirect("~/PrintPreview.aspx")

        End Sub

    End Class

End Namespace