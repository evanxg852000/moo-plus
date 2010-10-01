using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.IO;
using System.Data;
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
       

        protected void CopyTemplate(string templatename) 
        {
            string source = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\Templates\" + templatename;
            FileHelper.CopyFolder(source,this.folder);
        }
        protected List<string> GetFiles(string filters)
        {
            //TODO : implement the right here because it is common
            return new List<string>();
        }
        protected List<string> GetKeywords(string datafile) 
        {
            //TODO: implement the right here because it is common
            string file = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\Keywords\" + datafile + ".xml";
            try
            {
                DataSet Ds = new DataSet();
                Ds.ReadXml(file);
                List<string> keywords= new List<string>();
                foreach(DataRow r in  Ds.Tables[0].Rows)
                {
                    keywords.Add(r[0].ToString());
                }
                return keywords;
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
                return new List<string>();
            }    
        }
        
        #region Overridable Members

        public virtual void CopyTemplate() 
        {
            //nothing to do here
        }
        public virtual List<string> GetFiles()
        {
            return new List<string>();
        }
        public virtual List<string> GetKeywords()
        {
            return new List<string>();
        }

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
        
        #endregion

    }   



}
