Public Class DataPersistence

    Public Shared Property LastErrorException As Exception
        Get
            Return HttpContext.Current.Session("LastError")
        End Get
        Set(value As Exception)
            HttpContext.Current.Session("LastError") = value
        End Set
    End Property

    Public Shared Property LastErrorUrl As String
        Get
            Return HttpContext.Current.Session("LastErrorUrl")
        End Get
        Set(value As String)
            HttpContext.Current.Session("LastErrorUrl") = value
        End Set
    End Property

End Class
