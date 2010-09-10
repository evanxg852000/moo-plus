using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;

namespace Yalamo.Helpers
{
    class XMail
    {
            public static void SendMail(string subject, string content)
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("esvanxg852000@freeheberg.com");
                message.To.Add(new MailAddress("evanxg852000@yahoo.fr"));
                message.Subject = subject;
                message.Body = content;
                SmtpClient client = new SmtpClient();
                client.Send(message);
            }
    }
}

