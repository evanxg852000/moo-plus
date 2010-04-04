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
        public MMainWindow()
        {
            InitializeComponent();
            UiInitialisation();
            
        }

        private void UiInitialisation()
        {
            //startpage
            StartPage MStartPage = new StartPage();
            MStartPage.Show(MDockArea);
            MStartPage.DockState = DockState.Document;

            //project Browser
            FProjectBrowser MProjectBrowser = new FProjectBrowser();
            MProjectBrowser.Show(MDockArea);
            MProjectBrowser.DockState = DockState.DockLeftAutoHide;

            //brunch Browser
            FBrunchBrowser MBrunchBrowser = new FBrunchBrowser();
            MBrunchBrowser.Show(MDockArea);
            MBrunchBrowser.DockState = DockState.DockLeftAutoHide;

            //file system  Browser
            FFileSystBrowser MFileSystBrowser = new FFileSystBrowser();
            MFileSystBrowser.Show(MDockArea);
            MFileSystBrowser.DockState = DockState.DockRightAutoHide;  

             //file Searcher
            FFileSearcher MFileSearcher = new FFileSearcher();
            MFileSearcher.Show(MDockArea);
            MFileSearcher.DockState = DockState.DockBottomAutoHide; 
            

            //creating buildoutput window
            BuildOutput MBuildOutput = new BuildOutput();
            MBuildOutput.Content.Text = "some log out put";
            MBuildOutput.Show(MDockArea);
            MBuildOutput.DockState = DockState.DockBottomAutoHide;    
        }
       
        public void test()
        {
            CodeEditorConfig cec = new CodeEditorConfig() ;
            
            //startpage
            CodeEditor MCED = new CodeEditor(cec);
            MCED.Show(MDockArea);
            MCED.DockState = DockState.Document;

            
            //loading
            //AppSettings appset =AppSettings.Load();
            //MessageBox.Show(appset.EditorConfig.Font);

            ////saving
            //appset.EditorConfig = cec;
            //MessageBox.Show(appset.EditorConfig.Font);
            //AppSettings.Save(appset);

        }

    }
}
