using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui;
using System.IO;
using Yalamo.Core;
using System.Threading;

namespace Moo.Dialogs
{
    public partial class TemplateDialog : YForm
    {
        private string from;
        private string to;
        private int total, counter;

        public TemplateDialog()
        {
            InitializeComponent();
        }
        void CopyFolderAsyc(object sender, DoWorkEventArgs e)
        {
            this.CopyFolder(this.from,this.to);
        }

        void UpdateUi(object sender, ProgressChangedEventArgs e)
        {
            this.ProgressBar.Value = e.ProgressPercentage;
            this.cureentFilelabel.Text = e.UserState.ToString();
        }

        void WorkCompleted(object sender, RunWorkerCompletedEventArgs e) {
            this.Close();
        }

        public void CopyTemplate(string from, string to)
        {
            this.Show();
            this.from = from;
            this.to = to;
            this.counter = 0;
            try
            {
                this.total = new DirectoryInfo(from).GetFiles("*.*", SearchOption.AllDirectories).Length;
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
            }
            
            this.Worker.RunWorkerAsync(); 
        }

        private void CopyFolder(string from, string to)
        {
            try
            {
                DirectoryInfo source = new DirectoryInfo(from);
                DirectoryInfo destination = new DirectoryInfo(to);
                string fullpath;
                if (!destination.Exists)
                    destination.Create();
                FileInfo[] Files = source.GetFiles();
                foreach (FileInfo fi in Files)
                {
                    fullpath = Path.Combine(destination.FullName, fi.Name);
                    fi.CopyTo(fullpath, true);
                    this.counter++;
                    int p = (this.counter * 100) / this.total;
                    this.Worker.ReportProgress(p, fullpath);   
                }
                // for subfolders
                DirectoryInfo[] folders = source.GetDirectories();
                foreach (DirectoryInfo folder in folders)
                {
                    //construct new destination 
                    string newdestination = Path.Combine(destination.FullName, folder.Name);
                    //recursive CopyFolder()
                    CopyFolder(folder.FullName, newdestination);
                }
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
            }
        }

    }
}
