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
                    NewProjectRequested(sender,e);
                }
                catch
                {
                    //do nothing
                }
            }
        }
        private void RequestOpenProject(object sender, EventArgs e)
        {
            if (OpenProjectRequested != null)
            {
                try
                {
                    OpenProjectRequested(sender,e);
                }
                catch
                {
                    //do nothing
                }
            }
        }


    }
}
