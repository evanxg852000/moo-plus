﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using Moo.Core;

namespace Moo.Helpers
{
    class MiscHelper
    {
        public static ProjectCategory GetProjectType(string type)
        {
            ProjectCategory pcat = ProjectCategory.Unmanaged;
            switch (type)
            {       
                case "C Sharp":
                    pcat = ProjectCategory.Csharp;
                    break;
                case "Hydro":
                    pcat = ProjectCategory.Hydro;
                    break;
                case "Ilasm":
                    pcat = ProjectCategory.Ilasm;
                    break;
                case "Website":
                    pcat = ProjectCategory.Website;
                    break;
                case "V Basic":
                    pcat = ProjectCategory.Vbasic;
                    break;
                case "Unmanaged":
                    pcat = ProjectCategory.Unmanaged;
                    break;
            }
            return pcat;
        }
        public static string GetFileExtention(string type)
        {                         
            string fileextention = ".txt"; //default
            switch (type)
            {
                case "ASP":
                    fileextention = ".asp";
                    break;
                case "Batch":
                    fileextention = ".bat";
                    break;
                case "C++ Source":
                    fileextention = ".cpp";
                    break;
                case "C++ Header":
                    fileextention = ".h";
                    break;
                case "C#":
                    fileextention = ".cs";
                    break;
                case "D":
                    fileextention = ".d";
                    break;
                case "Html":
                    fileextention = ".html";
                    break;
                case "Hydro":
                    fileextention = ".hy";
                    break;
                case "Ilasm":
                    fileextention = ".il";
                    break;
                case "Java":
                    fileextention = ".java";
                    break;
                case "Javascript":
                    fileextention = ".js";
                    break;
                case "Pascal":
                    fileextention = ".pas";
                    break;
                case "Php":
                    fileextention = ".php";
                    break;
                case "SQL":
                    fileextention = ".sql";
                    break;
                case "V Basic":
                    fileextention = ".vb";
                    break;
                case "XML":
                    fileextention = ".xml";
                    break;
            }
            return fileextention;
        }
        public static string GetLanguage(string FileExtention)
        {
            string language =FileExtention.Replace(".","");
            return language;
        }
        public static void SendMail(string subject, string content )
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