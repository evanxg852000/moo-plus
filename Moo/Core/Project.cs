using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.IO;

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
        private bool createflag = false;

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
        public bool CreateFlag
        {
            get { return createflag; }
            set { createflag = value; }
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
        }
        public static Project Create(string pfolder, string pname, ProjectCategory ptype)
        {
            //pfolder= c:\\projects\
            //pname= myfirstproject
            string ppath=pfolder+pname+@"\"+pname+".mpr" ;
            pfolder = pfolder + pname;
            //create the object that will be serialised
            Project projectObject = new Project(ppath, ptype);
            try
            {
                //create the project folder
                Directory.CreateDirectory(pfolder);
                //serialize and save 
                using (FileStream fs = new FileStream(ppath, FileMode.Open, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, projectObject);
                    projectObject.CreateFlag = true;
                }
               
            }
            catch 
            {
            
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

    }
}
