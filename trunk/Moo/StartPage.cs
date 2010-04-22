using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using WeifenLuo.WinFormsUI.Docking;

namespace Moo
{
    public partial class StartPage : DockContent
    {
        public event NewProjectRequestHandler NewProjectRequested;
        public event OpenProjectRequestHandler OpenProjectRequested;

        public StartPage()
        {
            InitializeComponent();
        }
        private void RequestNewProject(object sender, EventArgs e)
        {
            if (NewProjectRequested != null)
            {
                try
                {
                    NewProjectRequested(this,e);
                }
                catch (Exception ex)
                {
                    Exceptioner.Log(ex);
                }
            }
        }
        private void RequestOpenProject(object sender, EventArgs e)
        {
            if (OpenProjectRequested != null)
            {
                try
                {
                    OpenProjectRequested(this,e);
                }
                catch (Exception ex)
                {
                    Exceptioner.Log(ex);
                }
            }
        }
        private void GetHelpContent(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mooplus.evansofts.com/");
        }        
        private void GotoEvansoft(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://evansofts.com/");
        }


    }
}
