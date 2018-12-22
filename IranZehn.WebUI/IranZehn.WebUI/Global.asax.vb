Imports System.Web.SessionState
Imports IranZehn.Classes
Imports LogManagement.BLL.Configurations

Public Class Global_asax
    Inherits System.Web.HttpApplication

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        LogManagement.BLL.LogManagement.ApplicationName = ApplicationCache.ApplicationName
        LogManagement.BLL.LogManagement.Configurations.Database = New Database(ApplicationCache.Log_Database)
        LogManagement.BLL.LogManagement.Configurations.Email = New Email(ApplicationCache.SMTP_Server, _
                                                                         ApplicationCache.SMTP_Port, _
                                                                         ApplicationCache.SMTP_Username, _
                                                                         ApplicationCache.SMTP_Password, _
                                                                         ApplicationCache.SMTP_Sender, _
                                                                         ApplicationCache.SMTP_Recipient)

        LogManagement.BLL.LogManagement.Configurations.File = New File(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _
                                                                                              ApplicationCache.LogFileFilename))
        LogManagement.BLL.LogManagement.EnableDatabaseLog = True
        LogManagement.BLL.LogManagement.EnableEmailLog = True
        LogManagement.BLL.LogManagement.EnableFileLog = True
        LogManagement.BLL.LogManagement.EnableEventLog = False

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session is started

    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)

        ' Get the exception object.
        Dim exc As Exception = Server.GetLastError

        Dim sessionId As String = "null"

        Try
            sessionId = Session.SessionID
        Catch ex As Exception
            sessionId = "null"
        End Try

        ' Log the exception and notify system operators
        LogManagement.BLL.LogManagement.LogErrorWebExtensive(exc, Request.Url.ToString(), Request.UserHostAddress.ToString(), sessionId)


    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
    End Sub

    Private Sub Global_asax_PreSendRequestHeaders(sender As Object, e As EventArgs) Handles Me.PreSendRequestHeaders
        Response.AddHeader("X-Frame-Options", "SAMEORIGIN")
    End Sub

End Class