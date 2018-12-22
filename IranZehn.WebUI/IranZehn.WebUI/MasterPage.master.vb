
Public Class MasterPage
    Inherits System.Web.UI.MasterPage


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '*  Set Current Year
        lblCurrentYear.Text = Now.Year.ToString
        lblVersion.Text = "v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString()
    End Sub

End Class
