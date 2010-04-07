using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Moo.Helpers
{
    class FileHelper
    {
        public static string GetContent(string filepath)
        {
            try 
            {
               return File.ReadAllText(filepath);     
            }
            catch(Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
            return string.Empty;   
        }
        public static string GetContent(string filter, string initialdir)
        {         
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Open ...";
            openfiledialog.Filter = filter;
            openfiledialog.InitialDirectory = initialdir;
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = openfiledialog.FileName;
                return GetContent(filepath);
            }
            else
            {
                return string.Empty;
            }
            
        }     
        public static bool Save(string filepath, string content)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    sw.Write(content);
                    return true;
                }
            }
            catch (Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime)
                e.ToString();
            }
            return false;
        }
        public static bool SaveAs(string content,string filter,string initialdir)
        {
           SaveFileDialog savefiledialog = new SaveFileDialog();
           savefiledialog.Title = "Save As ...";
           savefiledialog.Filter = filter;
           savefiledialog.InitialDirectory = initialdir;
           if (savefiledialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = savefiledialog.FileName;
                return Save(filepath, content);
            }
           else
           {
               return false;
           }
        }

    }
}
