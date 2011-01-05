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
        protected PType type= PType.Unmanaged;
       
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
            get { return this.type; }
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
            Dialogs.TemplateDialog td = new Moo.Dialogs.TemplateDialog();
            td.CopyTemplate(source, this.folder);  
        }
        protected List<string> GetFiles(string filters)
        {
            //TODO : implement the right here because it is common
            return new List<string>();
        }
        protected string[] GetKeywords(string datafile) 
        {
            //TODO: implement the right here because it is common
            string file = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\Keywords\" + datafile + ".txt";
            string content=FileHelper.GetContent(file);
            string[] ls= content.Split(',');
            return ls;
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
        public virtual string[] GetKeywords()
        {
            return new string[] {};
        }

        public virtual void Build(BuildOutput console)
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
