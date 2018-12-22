Namespace Classes

    Public Class ApplicationCache

        Public Shared ReadOnly Property ApplicationName As String
            Get
                Return "IranZehn"
            End Get
        End Property

        Public Shared ReadOnly Property IranZehnDB As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("IranZehnDB")
            End Get
        End Property

        Public Shared ReadOnly Property Log_Database As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Database")
            End Get
        End Property

        Public Shared ReadOnly Property SMTP_Server() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.SMTP.Server")
            End Get
        End Property


        Public Shared ReadOnly Property SMTP_Port() As Integer
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.SMTP.Port")
            End Get
        End Property


        Public Shared ReadOnly Property SMTP_Username() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.SMTP.Username")
            End Get
        End Property


        Public Shared ReadOnly Property SMTP_Password() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.SMTP.Password")
            End Get
        End Property


        Public Shared ReadOnly Property SMTP_Sender() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.Sender")
            End Get
        End Property


        Public Shared ReadOnly Property SMTP_Recipient() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.Email.Recipient")
            End Get
        End Property

        Public Shared ReadOnly Property LogFileFilename() As String
            Get
                Return System.Configuration.ConfigurationManager.AppSettings("Log.File.Filename")
            End Get
        End Property
    End Class

End Namespace