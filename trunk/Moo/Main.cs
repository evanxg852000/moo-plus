using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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


            //creating buildoutput window
            BuildOutput MBuildOutput = new BuildOutput();
            MBuildOutput.Content.Text = "some log out put";
            MBuildOutput.Show(MDockArea);
            MBuildOutput.DockState = DockState.DockBottomAutoHide;    
        }
       


    }
}
