using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using Moo.Helpers;

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
        public static bool SendLog(string usercomment,bool islogattached)
        {
            try
            {
                string mailcontent = usercomment;
                if (islogattached)
                { 
                    mailcontent += Environment.NewLine + Exceptioner.GetLog();
                    //clear the log file
                    Exceptioner.ClearLog();
                } 
                MiscHelper.SendMail("Bug Report", mailcontent);
                return true;
            }
            catch {    }
            return false;
        }

    }
}
