Imports Microsoft.VisualBasic
Imports System.Data


Namespace Classes

    'Public Class ReportCreator
    '    Public Sub ShowReport(ByVal plc As PlaceHolder, ByVal type As Integer)
    '        Dim HC As String = ""
    '        Select Case type
    '            Case 0
    '                HC += Overall()
    '            Case 1
    '                HC += Sex()
    '            Case 2
    '                HC += Marriage()
    '            Case 3
    '                HC += Graduate()
    '        End Select
    '        plc.Controls.Clear()
    '        plc.Controls.Add(New LiteralControl(HC))
    '    End Sub
    '    Private Function Overall() As String
    '        Dim HC As String = ""
    '        HC += "<table style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; border-left: black thin solid; width: 248px; border-bottom: black thin solid; font-family: tahoma; border-collapse: collapse; height: 72px;text-align: center;'>"
    '        HC += "<tr>"
    '        HC += "<td style='border-top-width: thin; border-left-width: thin; border-left-color: black; border-bottom-width: thin; border-bottom-color: black; vertical-align: middle; direction: rtl; border-top-color: black; height: 30px; background-color: #ffffff; text-align: center; border-right-width: thin; border-right-color: black;' colspan='3'>"
    '        HC += "گزارش فراوانی تیپ های مختلف</td>"
    '        HC += "</tr><tr>"

    '        HC += "<td style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; vertical-align: middle; border-left: black thin solid; clip: rect(auto auto auto auto); direction: rtl; border-bottom: black thin solid; border-collapse: collapse; background-color: #c0c0ff; text-align: center;'>تیپ</td>"
    '        HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid; direction: rtl; padding-top: 0px; border-bottom: black thin solid; height: 30px; background-color: #c0c0ff; text-align: center;' colspan='2'>تعداد</td></tr>"
    '        Dim dt As DataTable = DataManager.ReportData.GetAll

    '        For Each dr As DataRow In dt.Rows
    '            HC += "<tr>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;Text(-align) : center'>"
    '            HC += dr("TypeID").ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;Text(-align) : center'>"
    '            HC += dr("ItemCounts").ToString
    '            HC += "</td>"
    '            HC += "</tr>"
    '        Next
    '        HC += "</table>"
    '        HC += "<br />"
    '        Return HC
    '    End Function
    '    Private Function Sex() As String
    '        Dim HC As String = ""
    '        HC += "<table style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; border-left: black thin solid; width: 416px; border-bottom: black thin solid; font-family: tahoma; border-collapse: collapse; height: 80px; text-align: left'>"
    '        HC += "<tr><td style='border-top-width: thin; border-left-width: thin; border-left-color: black; border-bottom-width: thin; border-bottom-color: black; vertical-align: middle; direction: rtl; border-top-color: black; height: 30px; background-color: #ffffff; text-align: center; border-right-width: thin; border-right-color: black;' colspan='4'>"
    '        HC += "گزارش فراوانی تیپ ها به تفکیک جنسیت</td>"
    '        HC += "</tr><tr><td style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; vertical-align: middle; border-left: black thin solid; clip: rect(auto auto auto auto); direction: rtl; border-bottom: black thin solid; border-collapse: collapse; background-color: #c0c0ff; text-align: center; width: 33%; height: 34px;' rowspan='2'>تیپ</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 33%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>مرد</td>"
    '        HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid; direction: rtl; padding-top: 0px; border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center; width: 33%;' colspan='2' rowspan='2'>زن</td>"
    '        HC += "</tr>"
    '        HC += "<tr></tr>"
    '        Dim dt As DataTable = DataManager.TypeData.GetAll
    '        For Each dr As DataRow In dt.Rows
    '            HC += "<tr>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += dr("TypeID")
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += GetCountByTypeIDSexID(dr("TypeID"), 0).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += GetCountByTypeIDSexID(dr("TypeID"), 1).ToString
    '            HC += "</td>"
    '            HC += "</tr>"
    '        Next
    '        HC += "</table>"
    '        HC += "<BR/>"
    '        Return HC
    '    End Function
    '    Private Function Marriage() As String
    '        Dim HC As String = ""
    '        HC += "<table style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; border-left: black thin solid; width: 416px; border-bottom: black thin solid; font-family: tahoma; border-collapse: collapse; height: 80px; text-align: left'>"
    '        HC += "<tr><td style='border-top-width: thin; border-left-width: thin; border-left-color: black; border-bottom-width: thin; border-bottom-color: black; vertical-align: middle; direction: rtl; border-top-color: black; height: 30px; background-color: #ffffff; text-align: center; border-right-width: thin; border-right-color: black;' colspan='4'>گزارش فراوانی تیپ ها به تفکیک وضعیت تاهل</td></tr>"
    '        HC += "<tr><td style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; vertical-align: middle; border-left: black thin solid; clip: rect(auto auto auto auto); direction: rtl; border-bottom: black thin solid; border-collapse: collapse; background-color: #c0c0ff; text-align: center; width: 33%; height: 34px;' rowspan='2'>تیپ</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 33%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>مجرد</td>"
    '        HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid; direction: rtl; padding-top: 0px; border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center; width: 33%;' colspan='2' rowspan='2'>متاهل</td>"
    '        HC += "</tr>"
    '        HC += "<tr></tr>"

    '        Dim dt As DataTable = DataManager.TypeData.GetAll
    '        For Each dr As DataRow In dt.Rows
    '            HC += "<tr>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += dr("TypeID")
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += GetCountByTypeIDMarriageStatusID(dr("TypeID"), 0).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 109px; height: 31px;'>"
    '            HC += GetCountByTypeIDMarriageStatusID(dr("TypeID"), 1).ToString
    '            HC += "</td>"
    '            HC += "</tr>"
    '        Next

    '        HC += "</table><BR/>"
    '        Return HC
    '    End Function
    '    Private Function Graduate() As String
    '        Dim HC As String = ""
    '        HC += "<table style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; border-left: black thin solid; width: 504px; border-bottom: black thin solid; font-family: tahoma; border-collapse: collapse; height: 112px; text-align: left'>"
    '        HC += "<tr><td style='border-top-width: thin; border-left-width: thin; border-left-color: black; border-bottom-width: thin; border-bottom-color: black; vertical-align: middle; direction: rtl; border-top-color: black; height: 30px; background-color: #ffffff; text-align: center; border-right-width: thin; border-right-color: black;' colspan='9'>گزارش فراوانی تیپ ها به تفکیک میزان تحصیلات</td>"
    '        HC += "</tr>"
    '        HC += "<tr><td style='border-right: black thin solid; table-layout: auto; border-top: black thin solid; vertical-align: middle; border-left: black thin solid; clip: rect(auto auto auto auto); direction: rtl; border-bottom: black thin solid; border-collapse: collapse; background-color: #c0c0ff; text-align: center; width: 12.5%; height: 34px;' rowspan='2'>تیپ</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 12.5%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>زیر دیپلم</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 2548px; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>دیپلم</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 12.5%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>فوق دیپلم</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 12.5%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>لیسانس</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 12.5%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>فوق لیسانس</td>"
    '        HC += "<td colspan='1' rowspan='2' style='border-right: black thin solid; padding-right: 0px;border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle;border-left: black thin solid; width: 12.5%; direction: rtl; padding-top: 0px;border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center'>دکترا</td>"
    '        HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid; padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid; direction: rtl; padding-top: 0px; border-bottom: black thin solid; height: 34px; background-color: #c0c0ff; text-align: center; width: 12.5%;' colspan='2' rowspan='2'>بالای دکترا</td>"
    '        HC += "</tr><tr></tr>"
    '        Dim dt As DataTable = DataManager.TypeData.GetAll
    '        For Each dr As DataRow In dt.Rows
    '            HC += "<tr>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += dr("TypeID")
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 0).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 1).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 2).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 3).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 4).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 5).ToString
    '            HC += "</td>"
    '            HC += "<td style='border-right: black thin solid; padding-right: 0px; border-top: black thin solid;padding-left: 0px; padding-bottom: 0px; vertical-align: middle; border-left: black thin solid;direction: rtl; padding-top: 0px; border-bottom: black thin solid; background-color: linen;text-align: center; width: 12%; height: 31px;'>"
    '            HC += GetCountByTypeIDGraduateID(dr("TypeID"), 6).ToString
    '            HC += "</td>"

    '            HC += "</tr>"
    '        Next

    '        HC += "</table><BR/>"
    '        Return HC
    '    End Function
    '    Private Function GetCountByTypeIDGraduateID(ByVal TypeID As String, ByVal GraduateID As Integer) As Integer
    '        Dim dr As DataRow = DataManager.ReportData.GetRowByTypeIDGraduateID(TypeID, GraduateID)
    '        If dr Is Nothing Then
    '            Return 0
    '        End If
    '        Return dr("ItemCounts")
    '    End Function
    '    Private Function GetCountByTypeIDMarriageStatusID(ByVal TypeID As String, ByVal MarriageStatusID As Integer) As Integer
    '        Dim dr As DataRow = DataManager.ReportData.GetRowByTypeIDMarriageStatusID(TypeID, MarriageStatusID)
    '        If dr Is Nothing Then
    '            Return 0
    '        End If
    '        Return dr("ItemCounts")
    '    End Function
    '    Private Function GetCountByTypeIDSexID(ByVal TypeID As String, ByVal SexID As Integer) As Integer
    '        Dim dr As DataRow = DataManager.ReportData.GetRowByTypeIDSexID(TypeID, SexID)
    '        If dr Is Nothing Then
    '            Return 0
    '        End If
    '        Return dr("ItemCounts")
    '    End Function
    'End Class


End Namespace