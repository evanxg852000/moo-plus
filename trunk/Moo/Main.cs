using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using WeifenLuo.WinFormsUI;
using WeifenLuo.WinFormsUI.Docking;

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
           // MOO_BUILD_OUTPUT.SetC "some log out put";
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
            //load plugins here
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
            //startpage
            CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, "C:\\samples\\helloworld.cs");
            MCED.Show(MDockArea);
            MCED.DockState = DockState.Document;
            MCED.SetLanguage("cs");

        }

        #region Menu Event Handlers
        //file menu handlers
        private void NewFile(object sender, EventArgs e)
        {
            //startpage
            CodeEditor MCED = new CodeEditor(MOO_APPLICATION_SETTINGS.EditorConfig, "C:\\samples\\helloworld.java");
            MCED.Show(MDockArea);
            MCED.DockState = DockState.Document;
            MCED.SetLanguage("php");
        }
        private void NewProject(object sender, EventArgs e)
        {
            //new project code 
        }
        private void PrintCode(object sender, EventArgs e)
        {
            if (MDockArea.ActiveDocument.GetType().Equals(typeof(CodeEditor)))
            {
                CodeEditor ce = (CodeEditor)MDockArea.ActiveDocument;
                ce.Print();
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
       
        
        #endregion

        

        

        
        
        
       
    }
}
