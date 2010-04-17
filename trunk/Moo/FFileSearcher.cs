using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using Moo.Core;

namespace Moo
{
    public partial class FFileSearcher : DockContent
    {
        public event OpenFileRequestHandler OpenSelectedFileRequested;
        
        public FFileSearcher()
        {
            InitializeComponent();
        }

        private void SetFolder(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.FileFounderList.SearchFolder = fbd.SelectedPath;
            }
        }
        private void SearchFileHandler(object sender, EventArgs e)
        {
            if (this.SearchKey.Text=="Search...")
            {
                this.SearchKey.Text = "Search Term required !";
                return;
            }
            this.TSearchFolder.Enabled =false;
            this.TSearch.Enabled = false;
            this.TRecursive.Enabled = false;
            this.SearchProgress.Style = ProgressBarStyle.Marquee;
            this.FileFounderList.SearchTerm=this.SearchKey.Text;
            this.FileFounderList.SearchFile();
        }
        private void RecursiveHandler(object sender, EventArgs e)
        {
            this.FileFounderList.IsRecurssive = TRecursive.Checked;
        }
        
        private void SearchProgressChanged(int percentage)
        {
            this.SearchProgress.Value = percentage;
        }
        private void SearchCompleted(RunWorkerCompletedEventArgs e)
        {
            this.TSearchFolder.Enabled = true;
            this.TSearch.Enabled = true;
            this.TRecursive.Enabled = true;
            this.SearchProgress.Style = ProgressBarStyle.Blocks;
        }
        private void RequestOpenSelectedFile(string itemTag)
        {
            if (OpenSelectedFileRequested != null)
            {
                try
                {
                    OpenSelectedFileRequested(itemTag);
                }
                catch
                {
                    //do nothing
                }
            }
        }
      

       
        
    }
}
