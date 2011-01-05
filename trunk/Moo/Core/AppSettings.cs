using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using ScintillaNet;
using System.Drawing;


namespace Moo.Core
{
    [Serializable]
   public  class CodeEditorConfig
    {
        public string Font;
        public int FontSize;
        public FoldMarkerScheme FoldingMarker;
        public FontStyle FontStyle ;
        public bool IsAutosave;
        public int AutosaveTimer; 
        public bool IsMarginLine;
        public bool IsLineHilighting;
        public CodeEditorConfig()
        {
            Font = "Consolas";
            FontSize = 11;
            FoldingMarker = FoldMarkerScheme.BoxPlusMinus;
            FontStyle = FontStyle.Regular;
            IsAutosave = false;
            AutosaveTimer = 300000;//5mn-> ms
            IsMarginLine = true;
            IsLineHilighting = false;
        }     
    }
    
    [Serializable]
    public class AppSettings
    {
        private List<string> activeplugins;
        private List<string> recentprojects;
        private List<string> recentfiles;
        
        [NonSerialized] //because we don't wana load with the last current project
        private Project currentproject = null;
        private string lastworkingdir;
        private CodeEditorConfig editorconfig=null;

        private bool Isshowtips = true;
        private bool Issavelayout = false;
        private bool Isprojectbrowser = true;
        private bool Isbrunchbrowser = true;
        private bool Isfilebrowser = true;
        private bool Isfilesearcher = true;
        private bool Isbuildoutput = true;

        private string csharp;
        private string vbnet;
        private string ilasm;
        private string java;
        private string hydro;
        private string database;

        public List<string> ActivePlugins
        {
            get { return activeplugins;}
            set { activeplugins=value;}
        }
        public List<string> RecentProjects 
        {
            get {return recentprojects ;}
            set { recentprojects=value;}
        }
        public List<string> RecentFiles
        {
            get { return recentfiles;}
            set { recentfiles=value;}
        }
       
        public Project CurrentProject
        {
            get { return currentproject; }
            set { currentproject = value; }
        }
        public string LastWorkingDir 
        {
            get { return lastworkingdir;}
            set { lastworkingdir=value;}
        }
        public CodeEditorConfig EditorConfig
        {
            get { return editorconfig;}
            set { editorconfig=value;}
        } 

        public bool IsShowTips {
            get { return Isshowtips;}
            set { Isshowtips=value;}
        }
        public bool IsSaveLayout 
        {
            get {return Issavelayout ;}
            set { Issavelayout=value;}
        }
        public bool IsProjectBrowser
        {
            get { return Isprojectbrowser;}
            set { Isprojectbrowser=value;}
        }
        public bool IsBrunchBrowser 
        {
            get { return Isbrunchbrowser;}
            set { Isbrunchbrowser=value;}
        }
        public bool IsFileBrowser 
        {
            get { return Isfilebrowser;}
            set { Isfilebrowser=value;}
        }
        public bool IsFileSearcher
        {
            get {return Isfilesearcher ;}
            set {Isfilesearcher=value ;}
        }
        public bool IsBuildOutput 
        {
            get { return Isbuildoutput;}
            set { Isbuildoutput=value;}
        }

        public string Csharp{
            get{return csharp;}
            set{csharp=value;}
        }
        public string Vbnet
        {
            get { return vbnet; }
            set { vbnet = value; }
        }
        public string Ilasm
        {
            get { return ilasm; }
            set { ilasm = value; }
        }
        public string Java
        {
            get { return java; }
            set { java = value; }
        }
        public string Hydro
        {
            get { return hydro; }
            set { hydro = value; }
        }
        public string Databse
        {
            get { return database; }
            set { database = value; }
        }

        private   AppSettings()
        {
            this.recentfiles = new List<string>();
            this.recentprojects = new List<string>();
            this.activeplugins = new List<string>();
            this.editorconfig = new CodeEditorConfig();
            this.lastworkingdir = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
        }
        public static void Save(AppSettings MooAppSettings)
        {
            //serialize the object to save
            try
            {
                using (FileStream fs = new FileStream(@"Configuration/mooconf.mco", FileMode.Open, FileAccess.Write))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(fs, MooAppSettings);
                }
            }
            catch (Exception e) { Exceptioner.Log(e); }
        }
        public static AppSettings Load()
        {
            //deserialize the object to load
            AppSettings ASObject = new AppSettings();
            try
            {
                using (FileStream fs = new FileStream(@"Configuration/mooconf.mco", FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    ASObject = (AppSettings)bf.Deserialize(fs);
                }
            }
            catch (Exception e) { Exceptioner.Log(e); }
            return ASObject;    
        }
        
        public static string GetFolder(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(key+"folder");
        }
         
        public static string Get(string key)
        {
            return System.Configuration.ConfigurationManager.AppSettings.Get(key);
        }
        public static void Set(string key, string val)
        {
            System.Configuration.ConfigurationManager.AppSettings.Set(key, val);
            System.Configuration.ConfigurationManager.RefreshSection("appSettings");  
        }
    }

}
