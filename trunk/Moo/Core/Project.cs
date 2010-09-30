using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.IO;
using Moo.Helpers;

namespace Moo.Core
{
    
    [Serializable]
    public class Project
    {
        private string file;   
        private string name;   
        private string folder; 
        private string icon;
        private DateTime date;
        private PType type= PType.Unmanaged;
       
        public string File
        {
            get { return file;}
        }
        public string Name
        {
            get { return name;}
        }
        public string Folder
        {
            get { return folder;}
        }
        public string Icon
        {
            get { return icon; }
            set { icon = value; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public PType Type
        {
            get { return type; }
        }
        
        public Project() {/*default constructor for deserialization */ }
        public Project(string filepath) 
        {
            this.file = filepath;
            this.folder = Path.GetDirectoryName(filepath);
            this.name = Path.GetFileNameWithoutExtension(filepath);
            this.icon = this.folder + @"\moobuild.ico";
            this.date = DateTime.Now.Date; 
        
        }      
        public void Save()
        {
            // Serialise and save
            try
            {
                using (FileStream fs = new FileStream(this.file, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, this);
                }
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
            }
        }
        public void CopyTemplate()
        {
            string source = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\templates\" + this.ToString(); 
            FileHelper.CopyFolder(source, this.folder);
        }
       
        #region Overridable Members

        public virtual void Build()
        {
            
        }

        public virtual void Run()
        {
            
        }

        public virtual void GetBuildTool()
        {
            
        }

        public virtual void GetCmdArgs()
        {
            
        }

        public virtual List<string> GetFiles()
        {
            return new List<string>();
        }

        public virtual List<string> GetKeywords() 
        {
            return new List<string>();
        }

        #endregion

    }   



}
