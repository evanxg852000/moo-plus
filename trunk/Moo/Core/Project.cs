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
        private string projectfile = "";   // is a fullpath like c:\\projects\sample\sample.mpr
        private string projectname = "";   // is a file name sample.mpr without extention
        private string projectfolder = ""; // is a fullpath like c:\\projects\sample\
        private ProjectCategory projecttype;
        private DateTime creationdate;
        private string projecticon = "";
        //only for C# and Ilasm project
        private string assemblyname;
        private string assemblytype ; //or dll
        private string buildtarget;
        private List<string> refferences;
        

        public string ProjectFile
        {
            get { return projectfile;}
        }
        public string ProjectName
        {
            get { return projectname;}
        }
        public string ProjectFolder
        {
            get { return projectfolder;}
        }
        public ProjectCategory ProjectType
        {
            get { return projecttype; }
        }
        public DateTime CreationDate
        {
            get { return creationdate; }
        }
        public string ProjectIcon
        {
            get { return projecticon; }
            set { projecticon = value; }
        }
        public string AssemblyType
        {
            get { return assemblytype; }
            set { assemblytype = value; }
        }
        public string AssemblyName
        {
            get { return assemblyname; }
            set { assemblyname = value; }
        }
        public string BuildTarget
        {
            get { return buildtarget; }
            set { buildtarget = value; }
        }
        public List<string> Refferences
        {
            get { return refferences; }
            set { refferences = value; }
        }

        public Project()
        { 
            //default constructor for deserialization
        }
        public Project(string projectfilepath,  ProjectCategory ptype)
        {
            this.projectfile= projectfilepath;
            this.projectfolder = Path.GetDirectoryName(projectfilepath);
            this.projectname = Path.GetFileNameWithoutExtension(projectfilepath);
            this.projecttype = ptype;
            this.creationdate = DateTime.Now.Date;
            this.projecticon = "moo.ico";
            this.assemblyname=this.projectname;
            this.assemblytype = "Executable (.exe)";//Dll
            this.buildtarget = "Debug";//Release
            this.refferences = new List<string>();
        }
        public List<string> GetProjectFiles(string filter) 
        {
            //to get the project folder content for compilation
            //searchterm=*.cs, *.il, *.php
            return Moo.Helpers.FileHelper.GetFolderFileList(this.projectfolder,filter,SearchOption.AllDirectories);
        }
        private void CopyTemplate()
        {
            string source = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + @"\templates\";
            string destination = this.projectfolder;
            switch (this.projecttype)
            {
                case ProjectCategory.Csharp:
                    FileHelper.CopyFolder(source + @"csharp\", destination);
                    break;
                case ProjectCategory.Hydro:
                    FileHelper.CopyFolder(source + @"hydro\", destination);
                    break;
                case ProjectCategory.Ilasm:
                    FileHelper.CopyFolder(source + @"ilasm\", destination);
                    break;
                case ProjectCategory.Vbasic:
                    FileHelper.CopyFolder(source + @"vbasic\", destination);
                    break;
                case ProjectCategory.Website:
                    FileHelper.CopyFolder(source + @"website\", destination);
                    break;
            }
        }
        
       
        public static Project Create(string pfolder, string pname, ProjectCategory ptype)
        {
            //pfolder= c:\\projects\
            //pname= myfirstproject
            string ppath=pfolder+@"\"+pname+@"\"+pname+".mpr" ;
            pfolder = pfolder +@"\"+ pname;
            //create the object that will be serialised
            Project projectObject = new Project(ppath, ptype);
            try
            {
                //create the project folder
                Directory.CreateDirectory(pfolder);
                //copy the template file in the folder
                projectObject.CopyTemplate();
                projectObject.Save();  
            }
            catch (Exception e)
            {
                //use ecexptioner
                e.ToString();
            }
            return projectObject;
        }
        public static Project Open(string pfile)
        {
            Project projectObject = new Project( );
            try
            {
                using (FileStream fs = new FileStream(pfile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    projectObject = (Project)bf.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                //Log exception MooExceptioner.Log(e, dateTime) 
                e.ToString();
            }
            
            return projectObject;
        }
        public void Save()
        {
            try
            {
               // Serialise and save
                using (FileStream fs = new FileStream(this.projectfile, FileMode.Create, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, this);
                }
            }
            catch (Exception e)
            {
                //use ecexptioner
                e.ToString();
            }
        }
    }
}
