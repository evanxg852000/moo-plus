using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Moo.Core;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Moo
{
    
    public partial class FProjectBrowser : DockContent
    {
        public event NewProjectRequestHandler NewProjectRequested;
        public event OpenProjectRequestHandler OpenProjectRequested;
        public event NewFileRequestHandler NewFileRequested;
        public event OpenFileRequestHandler OpenSelectedFileNodeRequested;

        public FProjectBrowser()
        {
            InitializeComponent();
        }
        public void BuildNodes(string pfolder, string pfile, string pname)
        {
            ProjectBrowserTree.BuildNodes(pfolder,pfile,pname);
        }
        public void ReLoad()
        {
            ProjectBrowserTree.Refresh();
        }
        private void TRefresh_Click(object sender, EventArgs e)
        {
            this.ReLoad();
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
                    OpenProjectRequested(this, e);
                }
                catch(Exception ex)
                {
                    Exceptioner.Log(ex);
                }
            }
        }
        private void RequestNewFile(object sender, EventArgs e)
        {
            if (NewFileRequested != null)
            {
                try
                {
                    NewFileRequested(this, e);
                }
                catch (Exception ex)
                {
                    Exceptioner.Log(ex);
                }
            }
        }
        private void RequestOpenSelectedFileNode(string itemTag)
        {
            if (OpenSelectedFileNodeRequested != null)
            {
                try
                {
                    OpenSelectedFileNodeRequested(itemTag);
                }
                catch (Exception e)
                {
                    Exceptioner.Log(e);
                }
            }
        }
       
        
       
        
    
    }
}
