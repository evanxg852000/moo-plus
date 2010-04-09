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
using Moo.Helpers;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;
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
        private List<Type> MOO_PLUGIN_LIST;
        #endregion
       
        public MMainWindow()
        {
            InitializeComponent();
            UiInitialisation();
            LoadAppState();
            LoadPlugins();
            test();
        }
        private void UiInitialisation()
        {
            //startpage
            MOO_START_PAGE = new StartPage();
            MOO_START_PAGE.Show(MDockArea);
            MOO_START_PAGE.DockState = DockState.Document;

            //project Browser
            MOO_PROJECT_BROWSER = new FProjectBrowser();
            MOO_PROJECT_BROWSER.Show(MDockArea);
            MOO_PROJECT_BROWSER.DockState = DockState.DockLeftAutoHide;

            //brunch Browser
            MOO_BRUNCH_BROWSER = new FBrunchBrowser();
            MOO_BRUNCH_BROWSER.Show(MDockArea);
            MOO_BRUNCH_BROWSER.DockState = DockState.DockLeftAutoHide;

            //file system  Browser
            MOO_FILE_SYSTBROWSER = new FFileSystBrowser();
            MOO_FILE_SYSTBROWSER.Show(MDockArea);
            MOO_FILE_SYSTBROWSER.DockState = DockState.DockRightAutoHide;  

             //file Searcher
            MOO_FILE_SEARCHER = new FFileSearcher();
            MOO_FILE_SEARCHER.Show(MDockArea);
            MOO_FILE_SEARCHER.DockState = DockState.DockBottomAutoHide; 
            

            //creating buildoutput window
            MOO_BUILD_OUTPUT = new BuildOutput();
            MOO_BUILD_OUTPUT.Show(MDockArea);
            MOO_BUILD_OUTPUT.DockState = DockState.DockBottomAutoHide;    
        }
        private void LoadAppState()
        {
            MOO_APPLICATION_SETTINGS = AppSettings.Load();
        }
        private void SaveAppState()
        {
             AppSettings.Save(MOO_APPLICATION_SETTINGS);
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
       

        
        
        //just for test to be deleted 
        public void test()
        {

            MOO_BUILD_OUTPUT.SetOutputContent("some log out put");
        }
          

        #region Menu Event Handlers
        //file menu handlers
        private void NewFile(object sender, EventArgs e)
        {
            //open the new dialog
            Moo.Dialogs.NewProFileDialog newdialog = new Moo.Dialogs.NewProFileDialog("FILE");
            if (newdialog.ShowDialog() == DialogResult.OK)
            {
                string fileExtention=Moo.Helpers.MiscHelper.GetFileExtention(newdialog.RType);
                string fileLanguage = Moo.Helpers.MiscHelper.GetLanguage(newdialog.RType);
                string filename = newdialog.RFolder +@"\"+ newdialog.RName + fileExtention;
                
                CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, filename);
                MCED.SetLanguage(fileLanguage);
                MCED.Show(MDockArea);
                MCED.DockState = DockState.Document;
                MCED.CaretPositionChanged += new CaretPositionHandler(UpdateSatutsLineColumn);   
            }  
        }
        private void NewProject(object sender, EventArgs e)
        {
            //new project code 
        }
        private void SaveCurrentEditor(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Save();
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
        private void InsertCodeBrunch(object sender, EventArgs e)
        {
            //show code brunch dialog
            //get content and 
            string content = "to be writtent";
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
                ce.SetLanguage(m.Tag.ToString());
                m.Checked=true;
                foreach (MenuItem item in MLanguage.MenuItems)
                {
                    if (item.Tag.ToString() != m.Tag.ToString())
                    {
                        item.Checked = false;
                    }
                }
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

        
        //toolbar
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
        
        #endregion

        
       
        

        


       
        

        

        
        
        
       
    }
}
