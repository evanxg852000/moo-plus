using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using Moo.Core;
using Moo.Dialogs;
using Moo.Helpers;
using Yalamo.Gui.Dock;
using Evansofts.Extension;

namespace Moo
{
    public partial class MMainWindow : Form
    {
        #region Global Shared Members
        private AppSettings MOO_APPLICATION_SETTINGS;
        private StartPage MOO_START_PAGE;
        private FProjectBrowser MOO_PROJECT_BROWSER;
        private FBrunchBrowser MOO_BRUNCH_BROWSER;
        private FFileSystBrowser MOO_FILE_SYSTBROWSER;
        private FFileSearcher MOO_FILE_SEARCHER;
        private BuildOutput MOO_BUILD_OUTPUT;
        private TodoList MOO_TODO_LIST;
        private List<Type> MOO_PLUGIN_LIST;
        private Builder MOO_BUILDER;
        #endregion
       
        #region Utility Fields
        private int QuickFileCounter = 0;
        #endregion

        public MMainWindow()
        {
            InitializeComponent();   
            UiInitialisation();
            LoadAppState();
            LoadPlugins();
            ApplyLoadedSettings();  
        }
        private void UiInitialisation()
        {
            //startpage
            MOO_START_PAGE = new StartPage();
            MOO_START_PAGE.Show(MDockArea);
            MOO_START_PAGE.DockState = DockState.Document;
            MOO_START_PAGE.NewProjectRequested += new NewProjectRequestHandler(NewPrjectFile);
            MOO_START_PAGE.OpenProjectRequested += new OpenProjectRequestHandler(OpenPrjectFile);

            //project Browser
            MOO_PROJECT_BROWSER = new FProjectBrowser();
            MOO_PROJECT_BROWSER.Show(MDockArea);
            MOO_PROJECT_BROWSER.DockState = DockState.DockLeftAutoHide;
            MOO_PROJECT_BROWSER.NewProjectRequested +=new NewProjectRequestHandler(NewPrjectFile);
            MOO_PROJECT_BROWSER.NewFileRequested +=new NewFileRequestHandler(NewPrjectFile);
            MOO_PROJECT_BROWSER.OpenProjectRequested += new OpenProjectRequestHandler(OpenPrjectFile);
            MOO_PROJECT_BROWSER.OpenSelectedFileNodeRequested+=new OpenFileRequestHandler(OpenSelectedFileNode);

            //brunch Browser
            MOO_BRUNCH_BROWSER = new FBrunchBrowser();
            MOO_BRUNCH_BROWSER.Show(MDockArea);
            MOO_BRUNCH_BROWSER.DockState = DockState.DockLeftAutoHide;
            MOO_BRUNCH_BROWSER.InsertSelectedBrunchNodeRequested += new InsertBrunchRequestHandler(InsertCodeBrunch);
            
            //file system  Browser
            MOO_FILE_SYSTBROWSER = new FFileSystBrowser();
            MOO_FILE_SYSTBROWSER.Show(MDockArea);
            MOO_FILE_SYSTBROWSER.DockState = DockState.DockRightAutoHide;
            MOO_FILE_SYSTBROWSER.OpenSelectedFileRequested += new OpenFileRequestHandler(OpenSelectedFileNode);

             //file Searcher
            MOO_FILE_SEARCHER = new FFileSearcher();
            MOO_FILE_SEARCHER.Show(MDockArea);
            MOO_FILE_SEARCHER.DockState = DockState.DockBottomAutoHide;
            MOO_FILE_SEARCHER.OpenSelectedFileRequested += new OpenFileRequestHandler(OpenSelectedFileNode);
            
            //creating buildoutput window
            MOO_BUILD_OUTPUT = new BuildOutput();
            MOO_BUILD_OUTPUT.Show(MDockArea);
            MOO_BUILD_OUTPUT.DockState = DockState.DockBottomAutoHide; 
            
            //todo list
            MOO_TODO_LIST = new TodoList();
            MOO_TODO_LIST.Show(MDockArea);
            MOO_TODO_LIST.DockState = DockState.DockBottomAutoHide;
        }
        private void LoadAppState()
        {
            MOO_APPLICATION_SETTINGS = AppSettings.Load();
        }
        private void SaveAppState()
        {
            if (MOO_APPLICATION_SETTINGS.IsSaveLayout)
            {
                if (MOO_PROJECT_BROWSER.DockState == DockState.DockLeft) { MOO_APPLICATION_SETTINGS.IsProjectBrowser = true; }
                else { MOO_APPLICATION_SETTINGS.IsProjectBrowser = false; }
                if (MOO_BRUNCH_BROWSER.DockState == DockState.DockLeft) { MOO_APPLICATION_SETTINGS.IsBrunchBrowser = true; }
                else {MOO_APPLICATION_SETTINGS.IsBrunchBrowser = false; }
                if (MOO_FILE_SYSTBROWSER.DockState == DockState.DockRight) { MOO_APPLICATION_SETTINGS.IsFileBrowser = true; }
                else { MOO_APPLICATION_SETTINGS.IsFileBrowser = false; }
                if (MOO_BUILD_OUTPUT.DockState == DockState.DockBottom) {  MOO_APPLICATION_SETTINGS.IsBuildOutput = true; }
                else { MOO_APPLICATION_SETTINGS.IsBuildOutput = false; }
                if (MOO_FILE_SEARCHER.DockState == DockState.DockBottom) { MOO_APPLICATION_SETTINGS.IsFileSearcher = true; }
                else { MOO_APPLICATION_SETTINGS.IsFileSearcher = false; }
            }
             AppSettings.Save(MOO_APPLICATION_SETTINGS);
        }
        private List<CodeEditor> GetCodeEditors()
        {
            List<CodeEditor> lce = new List<CodeEditor>();
            foreach (DockContent Doc in MDockArea.Documents)
            {
                if (Doc.GetType().Equals(typeof(CodeEditor)))
                    lce.Add((CodeEditor)Doc);
            }
            return lce;
        }
        private void LoadPlugins()
        {
            MOO_PLUGIN_LIST = new List<Type>();
            //load plugins here
             string PluginPath = Path.GetDirectoryName(Application.ExecutablePath)+@"\plugins\"; 
            DirectoryInfo dirInfo = new DirectoryInfo(PluginPath);
            FileInfo[] PluginFiles = dirInfo.GetFiles("*.dll");

            foreach (FileInfo f in PluginFiles)
            { 
                Assembly dinamicDll = Assembly.LoadFile(f.FullName);
                Type[] pluginDefineTypes = dinamicDll.GetTypes();

                if (pluginDefineTypes.Count() != 0)
                {
                    foreach (Type t in pluginDefineTypes)
                    {
                        //check if that type is a class and iplement Iplugable
                        if ((t.IsClass) && (t.GetInterface("Evansofts.Extension.IPlugable") != null))
                        {
                            //check if it does implement the Run methode 
                            MethodInfo method = t.GetMethod("Run");
                            if (method != null)
                            {
                                MenuItem mi = new MenuItem(t.Name, new EventHandler(PluginLauncher));
                                mi.Tag = t.Name;
                                this.MPlugins.MenuItems.Add(mi);
                                MOO_PLUGIN_LIST.Add(t);
                            }
                        }


                    }

                }
            }
            //create
        }
        private void ApplyLoadedSettings()
        {
            if(MOO_APPLICATION_SETTINGS.IsProjectBrowser){ MOO_PROJECT_BROWSER.DockState=DockState.DockLeft;}
            if(MOO_APPLICATION_SETTINGS.IsBrunchBrowser){ MOO_BRUNCH_BROWSER.DockState = DockState.DockLeft;}
            if(MOO_APPLICATION_SETTINGS.IsFileBrowser){ MOO_FILE_SYSTBROWSER.DockState = DockState.DockRight;} 
            if(MOO_APPLICATION_SETTINGS.IsBuildOutput){ MOO_BUILD_OUTPUT.DockState = DockState.DockBottom;}
            if(MOO_APPLICATION_SETTINGS.IsFileSearcher){MOO_FILE_SEARCHER.DockState = DockState.DockBottom;} 
            foreach(string file in MOO_APPLICATION_SETTINGS.RecentFiles )
            {
                MenuItem mi = new MenuItem(Path.GetFileName(file));
                mi.Tag = file;
                mi.Click += new EventHandler(OpenRecentHandler);
                MRecentFiles.MenuItems.Add(mi);
            }
            foreach (string file in  MOO_APPLICATION_SETTINGS.RecentProjects)
            {
                MenuItem mi = new MenuItem(Path.GetFileName(file));
                mi.Tag = file;
                mi.Click += new EventHandler(OpenRecentHandler);
                MRecentProjects.MenuItems.Add(mi);
            }
        }
        private CodeEditor CreateEditor(string filename,string filetype) 
        {
            string lexer = SupportedFiles.GetLexer(filetype);
            filename += SupportedFiles.GetExtension(filetype);
            CodeEditor ce = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, filename);
           
            //TODO : get keywordlist from current project but keep dummie date for now
            List<string> ls = new List<string>() { "function?0", "Cookie?2", "Load->View()?6", "AppConfig()?6", "Yalamo::Void?8" };
            ce.UpadateCompletionList(ls);

            //add brunchs to editor list
            Dictionary<string,string> dic= MOO_BRUNCH_BROWSER.GetBrunchDictionary(filetype);
            ce.UpdateSnippets(dic);   
            ce.SetLanguage(lexer);         
            ce.CaretPositionChanged += new CaretPositionHandler(UpdateSatutsLineColumn);
            return ce;
        }
        

        #region Menu Event Handlers
        //file menu handlers
        private void NewPrjectFile(object sender, EventArgs e)
        {
            NewDialog newdialog = new NewDialog(null);
            if (newdialog.ShowDialog() != DialogResult.OK) { return; }
            if (newdialog.NewOption == "PROJECT")
            {
                if (newdialog.CreateProject != null)
                {
                    MOO_APPLICATION_SETTINGS.CurrentProject = newdialog.CreateProject;              
                    MOO_PROJECT_BROWSER.BuildNodes(newdialog.CreateProject.Folder, newdialog.CreateProject.File, newdialog.CreateProject.Name);
                }
            }
            else 
            {
                MessageBox.Show(newdialog.ResultObjectType+" only for file");
                CodeEditor MCDE = this.CreateEditor(newdialog.ResultObjectFolder+@"\"+ newdialog.ResultObjectName, newdialog.ResultObjectType);
                MCDE.Show(MDockArea);
                MCDE.DockState = DockState.Document;   
            }
            
        }        
        private void QuickFile(object sender, EventArgs e)
        {    
            QuickFileCounter++;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +@"\New " +QuickFileCounter; 
            CodeEditor MCDE= this.CreateEditor(file,"TEXT");
            MCDE.Show(MDockArea);
            MCDE.DockState = DockState.Document;
        }       
        private void OpenPrjectFile(object sender, EventArgs e)
        {
            string filter = "All files (*.*)|*.*|Moo Project (*.mpr)|*.mpr|Text file (*.txt)|*.txt|Html file ((*.html))|*.html|Xml file(*.xml)|*.xml";
            //we check if the sender was a (StartPage) or a (FProjectBrowser) to restrict for only project file
            //because those components can only send project open event
            if ((sender.GetType() == typeof(StartPage)) || (sender.GetType() == typeof(FProjectBrowser)))
            {
                filter ="Moo Project (*.mpr)|*.mpr";
            }
            string openfilepath;
            string openfilename;
            string openfilecontent = FileHelper.GetContent(filter, out openfilepath, out openfilename);
            string openfileextesion = Path.GetExtension(openfilepath);

            if (openfilepath != String.Empty)
            {
                
                if (openfileextesion == ".mpr")
                {
                    //deal with project
                    Project PRJT = ProjectFactory.Open(openfilepath);
                    MOO_APPLICATION_SETTINGS.CurrentProject = PRJT;
                    //load the project into the project browser
                    MOO_PROJECT_BROWSER.BuildNodes(PRJT.Folder,PRJT.File,PRJT.Name);
                    //add to recent
                    if (MOO_APPLICATION_SETTINGS.RecentProjects.Count <= 5)
                    {
                        MOO_APPLICATION_SETTINGS.RecentProjects.Add(openfilepath);
                    }
                }
                else 
                {
                    //check if it is already opened
                    List<CodeEditor> listeditors = this.GetCodeEditors();
                    foreach (CodeEditor CE in listeditors)
                    {
                        if (CE.FilePath == openfilepath) { CE.Activate(); return;  }
                    }   
                    //deal with file
                    string fileLanguage = Moo.Helpers.MiscHelper.GetLanguage(openfileextesion);
                    CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, openfilepath);
                    MCED.SetLanguage(fileLanguage);
                    MCED.SetContent(openfilecontent);
                    MCED.Show(MDockArea);
                    MCED.DockState = DockState.Document;
                    MCED.CaretPositionChanged += new CaretPositionHandler(UpdateSatutsLineColumn);
                    //add to recent
                    if (MOO_APPLICATION_SETTINGS.RecentFiles.Count <= 5)
                    {
                        MOO_APPLICATION_SETTINGS.RecentFiles.Add(openfilepath);
                    }
                }
            }
        }
        private void OpenRecentHandler(object sender, EventArgs e)
        {
            MenuItem mi=(MenuItem)sender;
            string openfilepath=mi.Tag.ToString();
            if(! new FileInfo(openfilepath).Exists)
            {
                MessageBox.Show(this, "This file has been removed", "Moo { + }", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuItem Parent =(MenuItem) mi.Parent;
                Parent.MenuItems.Remove(mi);
                if(Parent==MRecentFiles)
                {
                    MOO_APPLICATION_SETTINGS.RecentFiles.Remove(mi.Tag.ToString());
                }
                else
                {
                    MOO_APPLICATION_SETTINGS.RecentProjects.Remove(mi.Tag.ToString());
                }
                return;
            }
           
            string openfilecontent = FileHelper.GetContent(openfilepath);
            string openfileextesion = Path.GetExtension(openfilepath);
            if (openfilepath != String.Empty)
            { 
                if (openfileextesion == ".mpr")
                {
                    //deal with project
                    Project PRJT = ProjectFactory.Open(openfilepath);
                    MOO_APPLICATION_SETTINGS.CurrentProject = PRJT;
                    //load the project into the project browser
                    MOO_PROJECT_BROWSER.BuildNodes(PRJT.Folder, PRJT.File, PRJT.Name);
                }
                else
                {
                    //check if it is already opened
                    List<CodeEditor> listeditors = this.GetCodeEditors();
                    foreach (CodeEditor CE in listeditors)
                    {
                        if (CE.FilePath == openfilepath) { CE.Activate(); return; }
                    } 
                    //deal with file
                    string fileLanguage = Moo.Helpers.MiscHelper.GetLanguage(openfileextesion);
                    CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, openfilepath);
                    MCED.SetLanguage(fileLanguage);
                    MCED.SetContent(openfilecontent);
                    MCED.Show(MDockArea);
                    MCED.DockState = DockState.Document;
                    MCED.CaretPositionChanged += new CaretPositionHandler(UpdateSatutsLineColumn);
                }
            }
        }
        private void OpenSelectedFileNode(string file)
        {
            //check if it is already opened
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor CE in listeditors)
            {
                if (CE.FilePath == file)
                {
                    CE.Activate();
                    return;
                }
            }           
            string filecontent = FileHelper.GetContent(file);
            string fileextesion = Path.GetExtension(file);
            if (fileextesion == ".mpr")
            {
                return;
            }
            string fileLanguage = Moo.Helpers.MiscHelper.GetLanguage(fileextesion);
            CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, file);
            MCED.SetLanguage(fileLanguage);
            MCED.SetContent(filecontent);
            MCED.Show(MDockArea);
            MCED.DockState = DockState.Document;
            MCED.CaretPositionChanged += new CaretPositionHandler(UpdateSatutsLineColumn);
            //add to recent
            if (MOO_APPLICATION_SETTINGS.RecentFiles.Count <= 5)
            {
                MOO_APPLICATION_SETTINGS.RecentFiles.Add(file);
            }
        }
        private void ClearRecents(object sender, EventArgs e)
        {
            MenuItem mi = (MenuItem)sender;
            MenuItem Parent = (MenuItem)mi.Parent;
            int cpt = Parent.MenuItems.Count;
            while(Parent.MenuItems.Count>2)
            {
                MenuItem item = Parent.MenuItems[cpt-1];               
                Parent.MenuItems.Remove(item);
                cpt--;
            }

            if (Parent == MRecentFiles)
            {
                MOO_APPLICATION_SETTINGS.RecentFiles.Clear();
            }
            else
            {
                MOO_APPLICATION_SETTINGS.RecentProjects.Clear();
            }
        }
        private void ReloadCurrentEditor(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Reload();
            }
        }
        private void SaveCurrentEditor(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Save();
            }
        }
        private void SaveAs(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.SaveAs();
            }
        }
        private void SaveAll(object sender, EventArgs e)
        {
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.Save();
            } 
        }
        private void CloseCurrentEditor(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Close();
            }
        }
        private void CloseAll(object sender, EventArgs e)
        {
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.Close();
            } 
        }

        //printing
        private void PrintSetup(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.PageSetup();
            }
        }
        private void PrintCode(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Print();
            }
        }
        private void PrintPrevious(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.PrintPreview();
            }
        }
        //edit menu Handlers
        private void UndoPreviousAction(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.UndoAction();
            }
        }
        private void RedoPreviousAction(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.RedoAction();
            }
        }
        private void CutSelection(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Cut();
            }
        }
        private void CopySelection(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Copy();
            }
        }
        private void PasteSelection(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Paste();
            }
        }
        private void DeleteSelection(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Delete();
            }
        }
        private void SelectAll(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.SelectAll();
            }
        }
        private void InsertCodeSumarry(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.InsertCodeSummary();
            }
        }
        private void InsertCodeBrunch(string content)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.InsertCodeBrunch(content);
            }
        }
        private void CommentBlock(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.CommentLine();
            }
        }
        private void UncommentBlock(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.UnCommentLine();
            }
        }
        private void ToUpperCase(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.ToUpperCase();
            }
        }
        private void ToLowerCase(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.ToLowerCase();
            }
        }
        private void FoldAll(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.FoldAll();
            }
        }
        private void UnfoldAll(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.UnFoldAll();
            }
        }

        //view menu handlers (the remaining is define in toolbar section)
        private void SetCodeLanguage(object sender, EventArgs e)
        {
            MenuItem m = (MenuItem)(sender);
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument; 
                foreach (MenuItem item in MLanguage.MenuItems)
                {
                        item.Checked = false;
                }
                //change brunch
                Dictionary<string, string> dic = MOO_BRUNCH_BROWSER.GetBrunchDictionary(m.Text);
                ce.UpdateSnippets(dic);   
                ce.SetLanguage(m.Tag.ToString());
                m.Checked = true;
            } 
        }
        private void ZoomInCode(object sender, EventArgs e)
        {
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.ZoomIn();
            }   
        }
        private void ZoomOutCode(object sender, EventArgs e)
        {
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.ZoomOut();
            }  
        }
        private void ResetZoomCode(object sender, EventArgs e)
        {
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.ResetZoom();
            }  
        }

        //Search menu
        private void SearchDialog(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Search();
            }
        }
        private void ReplaceDialog(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Replace();
            }
        }
        private void FindNext(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.FindNext();
            }
        }
        private void FindPrevious(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.FindPrevious();
            }
        }
        private void GotoLine(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.GotoLine();
            }
        }

        //Project menu
        private void ProjectConfigure(object sender, EventArgs e)
        {
            if (MOO_APPLICATION_SETTINGS.CurrentProject != null)
            {
                ProjectConfigDialog.Show(MOO_APPLICATION_SETTINGS.CurrentProject);  
            }
        }

        //Settings menu
        private void EditPreferences(object sender, EventArgs e)
        {
            PreferenceDialog.Show(MOO_APPLICATION_SETTINGS);
        }
        private void SetEncoding(object sender, EventArgs e)
        {
            MenuItem mi=(MenuItem) sender;
            //clear check and check the current
            this.MEncodingAnsi.Checked = false;
            this.MEncodingUtf8.Checked = false;
            mi.Checked = true;
            MStatusEncodingLabel.Text = mi.Tag.ToString();
            List<CodeEditor> listeditors = this.GetCodeEditors();
            foreach (CodeEditor ce in listeditors)
            {
                ce.SetEncoding(mi.Tag.ToString());
            } 
        }

        //Tools menu
        private void PluginLauncher(object sender, EventArgs e)
        {
            //the text of the menu is the class name
            MenuItem mi = (MenuItem)sender;
            string classname = mi.Tag.ToString();

            foreach (Type t in MOO_PLUGIN_LIST)
            {
                if (t.Name == classname)
                {
                    //create an instance of objecttype
                    object[] pinfos = new object[] { };
                    object thepluginobject = Activator.CreateInstance(t, pinfos);
                    object[] arguments = new object[] { "evance" };
                    //result feedback object 
                    object result;
                    MethodInfo method = t.GetMethod("Run");
                    result = method.Invoke(thepluginobject, arguments);
                }
            }
        }
        private void CreateBrunch(object sender, EventArgs e)
        {
            BrunchEditorDialog BEditorInstance=new BrunchEditorDialog(this.MOO_BRUNCH_BROWSER.BrunchDataStructure);
            if(BEditorInstance.ShowDialog()==DialogResult.OK)
            {
                this.MOO_BRUNCH_BROWSER.UpdateData(BEditorInstance.BrunchDataStructure);
                this.MOO_BRUNCH_BROWSER.Refresh();
            }
        }
        private void ManageUpdate(object sender, EventArgs e)
        {            
            UpdateDialog.Show();
        }

        //Help menu
        private void GetHelpContent(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mooplus.evansofts.com/");
        }
        private void ShowAboutMoo(object sender, EventArgs e)
        {
            AboutDialog AbtDlg = new AboutDialog();
            AbtDlg.ShowDialog();
        }
        private void ReportBug(object sender, EventArgs e)
        {
            BugRepDialog.Show();
        }
      
        //Toolbar
        private void ShowEndLine(object sender, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.ShowEndOfLine(tsb.Checked);
            }
        }
        private void ShowWhiteSpace(object sender, EventArgs e)
        {
            ToolStripButton tsb = (ToolStripButton)sender;
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.ShowWhiteSpace(tsb.Checked);
            }
        }
        private void ToggleStartPage(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(ToolStripButton)))
            {
                ToolStripButton tsb = (ToolStripButton)sender;
                if (tsb.Checked)
                {
                    MStartPage.Checked = true;
                    tsb.Checked = true;
                    MOO_START_PAGE.Show();
                }
                else
                {
                    MStartPage.Checked = false;
                    tsb.Checked = false;
                    MOO_START_PAGE.Hide();
                }
            }
            else
            {
                MenuItem mi = (MenuItem)sender;
                if (mi.Checked)
                {
                    mi.Checked = false;
                    MTBShowStart.Checked = false;
                    MOO_START_PAGE.Hide();
                }
                else
                {
                    mi.Checked = true;
                    MTBShowStart.Checked = true;
                    MOO_START_PAGE.Show();
                }
            }
        }
        private void ToggleConsoleOutput(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(ToolStripButton)))
            {
                ToolStripButton tsb = (ToolStripButton)sender;
                if (tsb.Checked)
                {
                    MBuildOutput.Checked = true;
                    MTBShowConsole.Checked = true;
                    MOO_BUILD_OUTPUT.DockState = DockState.DockBottom;
                }
                else
                {
                    MBuildOutput.Checked = false;
                    MTBShowConsole.Checked = false;
                    MOO_BUILD_OUTPUT.DockState = DockState.DockBottomAutoHide;
                }
            }
            else
            {
                MenuItem mi = (MenuItem)sender;
                if (mi.Checked)
                {
                    mi.Checked = false;
                    MTBShowConsole.Checked = false;
                    MOO_BUILD_OUTPUT.DockState = DockState.DockBottomAutoHide;
                }
                else
                {
                    mi.Checked = true;
                    MTBShowConsole.Checked = true;
                    MOO_BUILD_OUTPUT.DockState = DockState.DockBottom;
                }
            }
        }
        private void ToggleCodeBrucnhExplorer(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(ToolStripButton)))
            {
                ToolStripButton tsb = (ToolStripButton)sender;
                if (tsb.Checked)
                {
                    MCodeBExplorer.Checked = true;
                    MTBShowBrunchBrowser.Checked = true;
                    MOO_BRUNCH_BROWSER.DockState = DockState.DockLeft;
                }
                else
                {
                    MCodeBExplorer.Checked = false;
                    MTBShowBrunchBrowser.Checked = false;
                    MOO_BRUNCH_BROWSER.DockState = DockState.DockLeftAutoHide;
                }
            }
            else
            {
                MenuItem mi = (MenuItem)sender;
                if (mi.Checked)
                {
                    mi.Checked = false;
                    MTBShowBrunchBrowser.Checked = false;
                    MOO_BRUNCH_BROWSER.DockState = DockState.DockLeftAutoHide;
                }
                else
                {
                    mi.Checked = true;
                    MTBShowBrunchBrowser.Checked = true;
                    MOO_BRUNCH_BROWSER.DockState = DockState.DockLeft;
                }
            }
        }
        private void ToggleProjectExplorer(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(ToolStripButton)))
            {
                ToolStripButton tsb = (ToolStripButton)sender;
                if (tsb.Checked)
                {
                    MProjectExplorer.Checked = true;
                    MTBShowProject.Checked = true;
                    MOO_PROJECT_BROWSER.DockState = DockState.DockLeft;
                }
                else
                {
                    MProjectExplorer.Checked = false;
                    MTBShowProject.Checked = false;
                    MOO_PROJECT_BROWSER.DockState = DockState.DockLeftAutoHide;
                }
            }
            else
            {
                MenuItem mi = (MenuItem)sender;
                if (mi.Checked)
                {
                    mi.Checked = false;
                    MTBShowProject.Checked = false;
                    MOO_PROJECT_BROWSER.DockState = DockState.DockLeftAutoHide;
                }
                else
                {
                    mi.Checked = true;
                    MTBShowProject.Checked = true;
                    MOO_PROJECT_BROWSER.DockState = DockState.DockLeft;
                }
            }
        }
        private void ToggleFileBrowser(object sender, EventArgs e)
        {
            if (sender.GetType().Equals(typeof(ToolStripButton)))
            {
                ToolStripButton tsb = (ToolStripButton)sender;
                if (tsb.Checked)
                {
                    MFileExplorer.Checked = true;
                    MTBShowDrive.Checked = true;
                    MOO_FILE_SYSTBROWSER.DockState = DockState.DockRight;
                }
                else
                {
                    MFileExplorer.Checked = false;
                    MTBShowDrive.Checked = false;
                    MOO_FILE_SYSTBROWSER.DockState = DockState.DockRightAutoHide;
                }
            }
            else
            {
                MenuItem mi = (MenuItem)sender;
                if (mi.Checked)
                {
                    mi.Checked = false;
                    MTBShowDrive.Checked = false;
                    MOO_FILE_SYSTBROWSER.DockState = DockState.DockRightAutoHide;
                }
                else
                {
                    mi.Checked = true;
                    MTBShowDrive.Checked = true;
                    MOO_FILE_SYSTBROWSER.DockState = DockState.DockRight;
                }
            }
        }
        
        //BUILD ToolBar handlers
        private void BuildProject(object sender, EventArgs e)
        {
            if (this.MOO_APPLICATION_SETTINGS.CurrentProject != null)
            {
                desactivateBuildtoolbts();
                MOO_BUILD_OUTPUT.SetOutputContent(String.Empty);
                this.MOO_BUILDER = new Builder(MOO_APPLICATION_SETTINGS.CurrentProject, MOO_BUILD_OUTPUT);
                this.MOO_BUILDER.Build();
                activateBuildtoolbts();
            }
        }
        private void RunProject(object sender, EventArgs e)
        {
            if (this.MOO_APPLICATION_SETTINGS.CurrentProject != null)
            {
                desactivateBuildtoolbts();
                this.MOO_BUILDER = new Builder(MOO_APPLICATION_SETTINGS.CurrentProject, MOO_BUILD_OUTPUT);
                this.MOO_BUILDER.Run();
                activateBuildtoolbts();
            }
        }       
        private void BuildAndRunProject(object sender, EventArgs e)
        {
            if (this.MOO_APPLICATION_SETTINGS.CurrentProject != null)
            {
                desactivateBuildtoolbts();
                MOO_BUILD_OUTPUT.SetOutputContent(String.Empty);
                this.MOO_BUILDER = new Builder(MOO_APPLICATION_SETTINGS.CurrentProject, MOO_BUILD_OUTPUT);
                this.MOO_BUILDER.Build();
                this.MOO_BUILDER.Run();
                activateBuildtoolbts();
            }
        }
        private void CleanProject(object sender, EventArgs e)
        {
            if (this.MOO_APPLICATION_SETTINGS.CurrentProject != null)
            {
                FileHelper.EmptyFolder(this.MOO_APPLICATION_SETTINGS.CurrentProject.Folder + @"\bin\");
            }  
        }
        private void activateBuildtoolbts()
        {
            MBuildProject.Enabled = true;
            MRunProject.Enabled = true;
            MBuildRunProject.Enabled = true;
            MStopRunProject.Enabled = false;
            MTBBuild.Enabled = true;
            MTBRun.Enabled = true;
            MTBStop.Enabled = false;
            MStatusLbl.Text = "Ready";
            MStatusProBar.Style = ProgressBarStyle.Blocks;
        }
        private void desactivateBuildtoolbts()
        {
            MBuildProject.Enabled = false;
            MRunProject.Enabled = false;
            MBuildRunProject.Enabled = false;
            MStopRunProject.Enabled = true;
            MTBBuild.Enabled = false;
            MTBRun.Enabled = false;
            MTBStop.Enabled = true;
            MStatusLbl.Text = "Working...";
            MStatusProBar.Style = ProgressBarStyle.Marquee;
        }
       

        //exitting event
        private void AppShuttingDown(object sender, FormClosingEventArgs e)
        {
            SaveAppState();
        }
        private void ExitApplication(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        //window updaters
        private void UpdateSatutsLineColumn(int line, int col)
        {
            this.MStatusLineLabel.Text = "Ln : " + line.ToString();
            this.MStatusColumnLabel.Text = "Col : " + col.ToString();
        }
        private void UIUpdate()
        { //update the ui when the project change
            //we desactivate so build button according to the curren project
            switch (MOO_APPLICATION_SETTINGS.CurrentProject.Type)
            {
                case PType.Unmanaged:
                    MBuildProject.Enabled = false;
                    MRunProject.Enabled = false;
                    MStopRunProject.Enabled = false;

                    MTBBuild.Enabled = false;
                    MTBRun.Enabled = false;
                    MTBStop.Enabled = false;
                    break;
                case PType.Website:
                    MBuildProject.Enabled = false;
                    MTBBuild.Enabled = false;
                    MRunProject.Enabled = true;
                    MTBRun.Enabled = true;
                    MTBStop.Enabled = true;
                    break;
                default:
                    MBuildProject.Enabled = true;
                    MRunProject.Enabled = true;
                    MStopRunProject.Enabled = true;
                    MTBBuild.Enabled = true;
                    MTBRun.Enabled = true;
                    MTBStop.Enabled = true;
                    break;
            }
        }
        
        #endregion      

       

        

       

   
    }
}
