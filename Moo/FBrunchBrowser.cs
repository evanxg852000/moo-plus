using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui.Dock;
using Moo.Helpers;
using Moo.Core;

namespace Moo
{
    public partial class FBrunchBrowser : DockContent
    {
        public event InsertBrunchRequestHandler InsertSelectedBrunchNodeRequested;
      
        public FBrunchBrowser()
        {
            InitializeComponent();
            BrunchBrowserTree.BuildNodes();
        }

        private void RefreshView(object sender, EventArgs e)
        {
            this.BrunchBrowserTree.Refresh();
        }
        private void DeleteBruch(object sender, EventArgs e)
        {
            string path =this.BrunchBrowserTree.SelectedNode.Tag.ToString();
            if(FileHelper.IsFile(path))
            {
                DialogResult dr= MessageBox.Show("Do you want to delete the brunch '" + this.BrunchBrowserTree.SelectedNode.Text + "' ", "Moo {+}",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(dr==DialogResult.Yes)
                {
                    this.BrunchBrowserTree.SelectedNode.Remove();
                    FileHelper.DeleteFile(path);
                }
            }
        }
        private void NewBrunch(object sender, EventArgs e)
        {
            Moo.Dialogs.NewBrunchDialog.Show();
        }
        private void RequestInsertSelectedBrunchNode(string itemTag)
        {
            if (InsertSelectedBrunchNodeRequested != null)
            {
                try
                {
                    InsertSelectedBrunchNodeRequested(itemTag);
                }
                catch(Exception e)
                {
                    Exceptioner.Log(e);
                }
            }
        }

        

        
   
    }
    
}
