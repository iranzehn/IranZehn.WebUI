using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;

namespace LogManagement.BLL
{
    public class LogManagement
    {


        static LogManagement()
        {
            LogManagement.ApplicationName = string.Empty;
            LogManagement.Configurations = new Configurations.Configurations();
        }

        #region Properties

        public static Configurations.Configurations Configurations { get; set; }
        public static string ApplicationName { get; set; }
        public static bool EnableDatabaseLog { get; set; }
        public static bool EnableFileLog { get; set; }
        public static bool EnableEmailLog { get; set; }
        public static bool EnableEventLog { get; set; }

        #endregion

        #region Public Methods

        public static void LogError(string message, bool database, bool email, bool eventlog, bool file)
        {
            if (database)
                LogToDatabase(message, Enums.LogTypes.Error);
            if (file)
                LogToFile(message);
            if (email && Configurations.Email != null)
                LogToEmail(message);
            if (eventlog)
                LogToEventLog(message);
        }

        public static void LogError(string message)
        {
            LogError(message, EnableDatabaseLog, EnableEmailLog, EnableEventLog, EnableFileLog);
        }

        public static void LogErrorWeb(string message, string sourceIP)
        {
            LogError(string.Format("IP Address: {0} \r\n Message: \r\r {1}", message, sourceIP));
        }

        public static void LogErrorWebExtensive(Exception err, string lastErrorURL, string sourceIP, string sessionId)
        {
            System.Text.StringBuilder sb = new StringBuilder();
            sb.AppendLine(String.Format("Page URL: {0}", lastErrorURL));
            sb.AppendLine();
            sb.AppendLine(String.Format("Message: {0}", err.Message));
            sb.AppendLine(String.Format("Source: {0}", err.Source));
            if (err.InnerException != null)
                sb.AppendLine(String.Format("Inner Exception: {0}", err.InnerException.ToString()));
            sb.AppendLine(String.Format("Stack Trace: {0}", err.StackTrace));
            sb.AppendLine(String.Format("IP Address: {0}", sourceIP));
            sb.AppendLine(String.Format("Session Id: {0}", sessionId));
            LogError(sb.ToString());
        }

        public static void LogTrace(string location, string id, string message)
        {
            LogToDatabase(string.Format("Trace: \r\nLocation: {0}\r\nId: {1}\r\nMessage:\r\n{2} ", location, id, message), Enums.LogTypes.Trace);
        }

        public static void LogPaymentRequest(string accessCode, string invoiceNumber, string invoiceReference,
            int amount)
        {
            LogToDatabasePaymentRequest(accessCode, invoiceNumber, invoiceReference, amount);
        }

        public static void LogPaymentResponse(string accessCode, string responseCode, string responseMessage,
            int amount)
        {
            LogToDatabasePaymentResponse(accessCode, responseCode, responseMessage, amount);
        }

        #endregion

        #region Private Methods
        private static void LogToEmail(string message)
        {
            try
            {
                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();

                client.Host = Configurations.Email.SMTP_Server;
                client.Port = Configurations.Email.SMTP_Port;
                client.EnableSsl = true;
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(Configurations.Email.SMTP_Username,
                                                                      Configurations.Email.SMTP_Password);
                client.Send(Configurations.Email.Sender,
                    Configurations.Email.Recipient,
                    string.Format("{0} Log Report", ApplicationName),
                    message);
            }
            catch (Exception ex)
            {
                string errorMessage;
                errorMessage = string.Format("Error in LogToEmail:\r\n{0}\r\nInner Exception:\r\n{1}\r\nOriginalMessage:\r\n{2}",
                        ex.Message,
                        (ex.InnerException != null ? ex.InnerException.Message : string.Empty),
                        message);
                LogToFile(errorMessage);
            }
        }

        private static void LogToFile(string message)
        {
            try
            {
                System.IO.File.AppendAllText(Configurations.File.Filename, string.Format("{0}   ------------------------------------------\r\n{1}",
                    DateTime.Now.ToString("yyyy/mm/dd hh:mm:ss"), message));
            }
            catch (Exception)
            {

            }
        }

        private static void LogToDatabase(string message, Enums.LogTypes logTypeId)
        {

            System.Data.SqlClient.SqlConnection cnn = null;

            try
            {
                cnn = new System.Data.SqlClient.SqlConnection(Configurations.Database.ConnectionString);
                var cmd = new System.Data.SqlClient.SqlCommand
                {
                    CommandText = "SP_ErroLogs_Insert",
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = cnn
                };
                cmd.Parameters.AddWithValue("@ApplicationName", ApplicationName);
                cmd.Parameters.AddWithValue("@LogTypeId", logTypeId);
                cmd.Parameters.AddWithValue("@ErrorDescription", message);
                cnn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                try
                {
                    if (cnn != null)
                        cnn.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private static void LogToDatabasePaymentRequest(string accessCode, string invoiceNumber, string invoiceReference, decimal amount)
        {

            System.Data.SqlClient.SqlConnection cnn = null;

            try
            {
                cnn = new System.Data.SqlClient.SqlConnection(Configurations.Database.ConnectionString);
                var cmd = new System.Data.SqlClient.SqlCommand
                {
                    CommandText = "SP_PaymentRequests_Insert",
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = cnn
                };
                cmd.Parameters.AddWithValue("@ApplicationName", ApplicationName);
                cmd.Parameters.AddWithValue("@AccessCode", accessCode);
                cmd.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
                cmd.Parameters.AddWithValue("@InvoiceReference", invoiceReference);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cnn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                try
                {
                    if (cnn != null)
                        cnn.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private static void LogToDatabasePaymentResponse(string accessCode, string responseCode, string responseMessage, decimal amount)
        {

            System.Data.SqlClient.SqlConnection cnn = null;

            try
            {
                cnn = new System.Data.SqlClient.SqlConnection(Configurations.Database.ConnectionString);
                var cmd = new System.Data.SqlClient.SqlCommand
                {
                    CommandText = "SP_PaymentResponses_Insert",
                    CommandType = System.Data.CommandType.StoredProcedure,
                    Connection = cnn
                };
                cmd.Parameters.AddWithValue("@ApplicationName", ApplicationName);
                cmd.Parameters.AddWithValue("@AccessCode", accessCode);
                cmd.Parameters.AddWithValue("@ResponseCode", responseCode);
                cmd.Parameters.AddWithValue("@ResponseMessage", responseMessage);
                cmd.Parameters.AddWithValue("@Amount", amount);
                cnn.Open();
                cmd.ExecuteScalar();
            }
            catch (Exception)
            {
                // ignored
            }
            finally
            {
                try
                {
                    if (cnn != null)
                        cnn.Close();
                }
                catch (Exception)
                {
                    // ignored
                }
            }
        }

        private static void LogToEventLog(string message)
        {

        }

        #endregion

    }
}
