using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogManagement.BLL.Configurations
{
    public class Email
    {
        public Email(string SMTP_Server, int SMTP_Port, string SMTP_Username, string SMTP_Password, string sender, string recipient)
        {
            this.SMTP_Server = SMTP_Server;
            this.SMTP_Port = SMTP_Port;
            this.SMTP_Username = SMTP_Username;
            this.SMTP_Password = SMTP_Password;
            this.Sender = sender;
            this.Recipient = recipient;

        }

        public string Recipient { get; set; }

        public string Sender { get; set; }

        public string SMTP_Password { get; set; }

        public string SMTP_Username { get; set; }

        public int SMTP_Port { get; set; }

        public string SMTP_Server { get; set; }
    }
}
