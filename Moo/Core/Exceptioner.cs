using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Net;

namespace Moo.Core
{
    public class Exceptioner
    {

        public static void Log(Exception e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"errorlog\mooerrorlogs.log", true))
                {
                    sw.WriteLine("");
                    sw.WriteLine("=======================NEW EXCEPTION================");
                    sw.WriteLine(DateTime.Now.ToString());
                    sw.WriteLine("------------Source------------");
                    sw.WriteLine(e.Source);
                    sw.WriteLine("------------Message------------");
                    sw.WriteLine(e.Message);
                    sw.WriteLine("------------Data------------");
                    foreach (object tv in e.Data.Values)
                    {
                         sw.WriteLine(tv.ToString());
                    }
                    
                }
            }
             catch {/*nithing */ }
        }
        public static string GetLog()
        {
            string result = "Unable to get the log content ....";
            try
            {
                using (StreamReader sr = new StreamReader(@"errorlog\mooerrorlogs.log"))
                {
                   result =  sr.ReadToEnd();
                }
            }
            catch {/*nithing */ }
            return result;
        }
        public static void ClearLog()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"errorlog\mooerrorlogs.log", false))
                {
                    sw.WriteLine("==========================SYSTEM INFO============================");
                    sw.WriteLine("OS Platform:"+Environment.OSVersion.Platform.ToString());
                    sw.WriteLine("OS Service Pack:"+Environment.OSVersion.ServicePack);
                    sw.WriteLine("OS Version:"+Environment.OSVersion.Version.ToString());
                    sw.WriteLine("Machine Name :"+Environment.MachineName);
                    sw.WriteLine("Nb Processors :"+Environment.ProcessorCount);
                    sw.WriteLine("User DomainName :"+Environment.UserDomainName);
                    sw.WriteLine("User Name :"+Environment.UserName);
                    sw.WriteLine("======================================================="); 
                }
            }
            catch {/*nithing */ }
        }
        public static void SendLog(string usercomment)
        {
            string mailcontent = usercomment + Environment.NewLine+Exceptioner.GetLog();
            
            //test for now send mail to be completed
            System.Windows.Forms.Form f = new System.Windows.Forms.Form();
            System.Windows.Forms.TextBox tb = new System.Windows.Forms.TextBox();
            tb.Multiline = true;
            tb.Dock = System.Windows.Forms.DockStyle.Fill;
            tb.Text = mailcontent;
            f.Controls.Add(tb);
            f.Show();
        }

    }
}
