Imports System.Data
Imports IranZehn.Classes



Public Class MBTITypes
    Inherits Classes.BasePage

    Private _TypeObject As Classes.TypeObject

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If IsPostBack Then
            Exit Sub
        End If

        pnlSend0.Visible = False
        pnlSend1.Visible = False


        Me.PlaceHolder1.Controls.Clear()
        If Not Request.Params("type") Is Nothing Then

            _TypeObject = Session("TestObject")
            Session("PrintTypeObject") = _TypeObject
            ibPrint.Visible = True
            If _TypeObject Is Nothing Then   'Simple Information
                Dim TypeID As String = Request.Params("type")
                Dim dr As DataRow = Classes.DataManager.TypeData.GetRowByTypeID(TypeID)
                If Not dr Is Nothing Then
                    Me.PlaceHolder1.Controls.Add(New LiteralControl(CreateResult(dr)))
                End If
            Else                    'Percent + Information

                '*  For Facebook
                'pnlSend0.Visible = True
                'pnlSend1.Visible = True
                Session("Facebook_Type") = _TypeObject.ToString

                Dim dr As DataRow = DataManager.TypeData.GetRowByTypeID(_TypeObject.ToString)
                If Not dr Is Nothing Then
                    Me.PlaceHolder1.Controls.Add(New LiteralControl(CreateResultByTypePercent(_TypeObject, dr)))
                    Session("TestObject") = Nothing
                End If
            End If

        End If

    End Sub

    Private Function CreateResult(ByVal dr As DataRow) As String
        Dim HC As String = "<table>"
        HC += GetBlock(dr, "عنوان", "Label")
        HC += GetBlock(dr, "کلیات", "Description")
        HC += GetBlock(dr, "محل کار", "WorkPlace")
        HC += GetBlock(dr, "عناوین شغلی", "JobTitle")
        HC += GetBlock(dr, "ارتباط با دیگران", "Communication")
        HC += GetBlock(dr, "اوقات فراقت", "Leisure")
        HC += GetBlock(dr, "پیشنهاد", "Advice")
        HC += GetBlock(dr, "شکل ظاهری", "Figure")
        HC += GetBlock(dr, "نقاط مثبت", "PositivePoints")
        HC += GetBlock(dr, "نقاط منفی", "NegativePoints")
        HC += GetBlock(dr, "اطلاعات بیشتر", "UltraInformation")
        HC += GetBlock(dr, "رشد شخصیت", "PersonalGrowth")
        HC += GetBlock(dr, "چگونه با این تیپ در آرامش زندگی کنیم؟", "LiveInPeace")
        HC += GetBlock(dr, "ترجیحات", "Preferences")
        HC += "</table>"
        Return HC
    End Function

    Public Function CreateResultByTypePercent(ByVal myTP As TypeObject, ByVal TypeRow As DataRow) As String

        Dim str As String = ""

        Try
            str += "<table style='width: 90%; direction: rtl; height: 112px; text-align: right'>"
            str += "<tr>"
            str += "<td colspan='5' style='width: 105px; font-family: Tahoma; background-color: #99ccff;text-align: center'>"
            str += "<span style='font-size: 10pt; font-family: Tahoma'>"
            str += "تیپ شما : " + myTP.ToString
            str += "</span>"
            str += "</td>"
            str += "</tr>"
            str += "<tr>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 13px; background-color: lightsteelblue;text-align: center'>"
            str += "تیپ"
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 13px; background-color: lightsteelblue;text-align: center'>"
            str += myTP.Item(4)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 13px; background-color: lightsteelblue;text-align: center'>"
            str += myTP.Item(3)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 13px; background-color: lightsteelblue;text-align: center'>"
            str += myTP.Item(2)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 13px; background-color: lightsteelblue;text-align: center'>"
            str += myTP.Item(1)
            str += "</td>"
            str += "</tr>"
            str += "<tr>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 2px; background-color: #99ccff;text-align: center'>"
            str += "درصد"
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 2px; background-color: #99ccff;text-align: center'>"
            str += myTP.ItemPercent(4)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 2px; background-color: #99ccff;text-align: center'>"
            str += myTP.ItemPercent(3)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 2px; background-color: #99ccff;text-align: center'>"
            str += myTP.ItemPercent(2)
            str += "</td>"
            str += "<td style='font-size: 10pt; width: 105px; font-family: Tahoma; height: 2px; background-color: #99ccff;text-align: center'>"
            str += myTP.ItemPercent(1)
            str += "</td>"
            str += "</tr>"
            str += "</table>"
            str += "<br />"
            str += "<br />"
            str += CreateResult(TypeRow)
            Return str
        Catch ex As Exception
            'CommonFunctions.SendErrorEmail(ex)
            LogManagement.BLL.LogManagement.LogError(String.Format("Stealth Error: {0}", ex.Message))
        End Try
        Return ""
    End Function
    Private Function GetBlock(ByVal dr As DataRow, ByVal Caption As String, ByVal ColumnName As String) As String
        If Not IsDBNull(dr(ColumnName)) AndAlso Not String.IsNullOrEmpty(dr(ColumnName)) Then
            Return CreateSubResult(Caption, dr(ColumnName))
        End If
        Return ""
    End Function
    Private Function CreateSubResult(ByVal header As String, ByVal content As String) As String
        Dim HC As String = "<tr>"
        HC += "<td style='text-align: right; vertical-align: middle;  font-weight: bold; color: #000000;' class=''>"
        HC += "<img alt='' src='Images/Type/Star.png' style='vertical-align: middle;'/>"
        HC += header
        HC += "</td>"
        HC += "</tr>"
        HC += "<tr>"
        HC += "<td style='color: #0000FF; text-align: justify;'>"
        HC += content.Replace(vbCrLf, "<br/>")
        HC += "</td>"
        HC += "</tr>"
        Return HC
    End Function

    Protected Sub ibPrint_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ibPrint.Click

        _TypeObject = Session("PrintTypeObject")
        If _TypeObject Is Nothing Then   'Simple Information
            Dim TypeID As String = Request.Params("type")
            Dim dr As DataRow = DataManager.TypeData.GetRowByTypeID(TypeID)
            If Not dr Is Nothing Then
                Session("PrintContent") = CreateResult(dr)
            End If
        Else                    'Percent + Information
            Dim dr As DataRow = DataManager.TypeData.GetRowByTypeID(_TypeObject.ToString)
            If Not dr Is Nothing Then
                Session("PrintContent") = CreateResultByTypePercent(_TypeObject, dr)
                Session("TestObject") = Nothing
            End If
        End If
        Response.Redirect("PrintPreview.aspx")

    End Sub


    Protected Sub btnSendToFacebook_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles btnSendToFacebook0.Click, _
                                                                                                                        btnSendToFacebook1.Click

        If Session("Facebook_Type") IsNot Nothing Then
            Response.Redirect("FaceBook.aspx")
        End If


    End Sub

End Class
