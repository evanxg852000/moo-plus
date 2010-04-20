using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        //only for C#,Vb and Ilasm project
        private string assemblyname;
        private string assemblytype ; //exe ,winexe or dll
        private string buildtarget;
        private string builtassembly;
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
        public string BuiltAssembly
        {
            get { return builtassembly; }
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
            this.projecticon =  this.projectfolder+@"\moobuild.ico";
            this.assemblyname=this.projectname;
            this.assemblytype = "Console Executable (.exe)";//Dll
            this.buildtarget = "Debug";//Release
            this.refferences = new List<string>();
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
        public List<string> GetProjectFiles()
        {   //to get the project folder content for compilation
            string filter = "";
            switch (this.projecttype)
            {
                case ProjectCategory.Csharp:
                    filter = "*.cs";
                    break;
                case ProjectCategory.Hydro:
                    filter = "*.hy";
                    break;
                case ProjectCategory.Ilasm:
                    filter = "*.il";
                    break;
                case ProjectCategory.Unmanaged:
                    filter = "";
                    break;
                case ProjectCategory.Vbasic:
                    filter = "*.vb";
                    break;
                case ProjectCategory.Website:
                    filter = "*.php";
                    break;
            }
            return Moo.Helpers.FileHelper.GetFolderFileList(this.projectfolder, filter, SearchOption.AllDirectories);
        }

        //for build process  
        private string GetBuildTool()
        {
            string buildtool = Path.GetDirectoryName(Application.ExecutablePath);
            switch (this.projecttype)
            {
                case ProjectCategory.Csharp:
                    buildtool += AppSettings.GetSdk("csharp");
                    break;
                case ProjectCategory.Hydro:
                    buildtool += AppSettings.GetSdk("hydro");
                    break;
                case ProjectCategory.Ilasm:
                    buildtool += AppSettings.GetSdk("ilasm");
                    break;
                case ProjectCategory.Unmanaged:
                    buildtool += AppSettings.GetSdk("unmanaged");
                    break;
                case ProjectCategory.Vbasic:
                    buildtool += AppSettings.GetSdk("vbasic");
                    break;
                case ProjectCategory.Website:
                    buildtool += AppSettings.GetSdk("web");
                    break;
            }
            return buildtool;
        }
        private string GetAssemblyType()
        {
            string targetparam = "";
            if (this.projecttype == ProjectCategory.Ilasm)
            {
                switch (this.assemblytype)
                {
                    case "Console Executable (.exe)":
                        targetparam = "/exe ";
                        break;
                    case "Windows Executable (.exe)":
                        targetparam = "/exe ";
                        break;
                    case "Dynamic Library (.dll)":
                        targetparam = "/dll ";
                        break;
                }
            }
            else
            {
                switch (this.assemblytype)
                {
                    case "Console Executable (.exe)":
                        targetparam = "/target:exe ";
                        break;
                    case "Windows Executable (.exe)":
                        targetparam = "/target:winexe ";
                        break;
                    case "Dynamic Library (.dll)":
                        targetparam = "/target:library ";
                        break;
                }
            }
            return targetparam;
        }
        private string GetOutput()
        {
            if (this.projecttype == ProjectCategory.Website)
            {
                this.builtassembly = "http://localhost/" + this.projectfolder;
               return "http://localhost/"+this.projectfolder;
            }
            string prefixe = "/out:";
            if(this.projecttype ==ProjectCategory.Ilasm)
            {
                prefixe="/output:";
            }
            switch (this.assemblytype)
            {
                case "Console Executable (.exe)": 
                    this.builtassembly = this.assemblyname + ".exe ";
                    break;
                case "Windows Executable (.exe)":
                    this.builtassembly = this.assemblyname + ".exe ";
                    break;
                case "Dynamic Library (.dll)":
                    this.builtassembly = this.assemblyname + ".dll";
                    break;
            }
            return prefixe + this.builtassembly;
        }
        private string GetSourceFiles()
        {
            string sourcefiles = "";
            foreach (string s in this.GetProjectFiles())
            {
                sourcefiles += s + " "; 
            }
            return sourcefiles;
        }
        private string GetReferences()
        {
            string references = "";
            foreach (string s in this.refferences)
            {
                references += s + " ";
            }
            return references;
        }
        private string GetIcon()
        {
            return "/win32icon:"+this.projecticon;
        }  
      
        public string GetBuiltAssembly()
        {
            return this.builtassembly;
        }     
        public string GetBuildCommand()
        {
            string command ="";
            switch (this.projecttype)
            {
                case ProjectCategory.Csharp:
                    command = this.GetBuildTool() + this.GetAssemblyType() + this.GetOutput() + this.GetSourceFiles() + this.GetReferences() + this.GetIcon();
                    break;
                case ProjectCategory.Hydro:
                    command = this.GetBuildTool() + this.GetAssemblyType() + this.GetOutput() + this.GetSourceFiles() + this.GetReferences() + this.GetIcon();
                    break;
                case ProjectCategory.Ilasm:
                    command = this.GetBuildTool() + this.GetAssemblyType() + this.GetOutput() + this.GetSourceFiles() ;
                    break;
                case ProjectCategory.Unmanaged:
                    command = "";
                    break;
                case ProjectCategory.Vbasic:
                    command = this.GetBuildTool() + this.GetAssemblyType() + this.GetOutput() + this.GetSourceFiles() + this.GetReferences() + this.GetIcon();
                    break;
                case ProjectCategory.Website:
                    command = this.GetBuildTool() + GetBuiltAssembly();
                    break;
            }
            return command;
        }
        

    }
}
