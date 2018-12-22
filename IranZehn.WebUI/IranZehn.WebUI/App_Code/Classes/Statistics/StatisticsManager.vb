Imports Microsoft.VisualBasic

Namespace IranZehn.Statistics

    Public Class StatisticsManager
        Public Shared Function GetCounter() As Integer
            Dim xds As New XmlDataSource With {
                .DataFile = "~/Statistics.xml"
            }
            xds.DataBind()
            Dim elem As System.Xml.XmlNode = xds.GetXmlDocument.DocumentElement.FirstChild
            elem.InnerText = Val(elem.InnerText) + 1
            xds.Save()
            Return elem.InnerText
        End Function
    End Class

End Namespace
