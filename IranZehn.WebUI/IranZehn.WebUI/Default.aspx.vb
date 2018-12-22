
Public Class Default2

    Inherits Classes.BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


        If Not IsPostBack Then

            Classes.DataManager.VisitData.DoVisit()

            Dim visitResult As Classes.DataManager.VisitData.VisitResult
            visitResult = Classes.DataManager.VisitData.GetVisitCount()

            lblTodayVisit.Text = visitResult.Today
            lblTotalVisit.Text = visitResult.Total

        End If

    End Sub

End Class
