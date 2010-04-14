using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Moo.Helpers;

namespace Moo.Dialogs
{
    public partial class UpdateDialog : Form
    {
        private List<Update> Updates;
        private WebClient DownloadClient; 
        
        private UpdateDialog(List<Update> mooiupdates)
        {
            InitializeComponent();
            this.Updates = mooiupdates;
            if (this.Updates.Count!=0)
            {
                this.DownloadBt.Enabled = true;
                this.DeamonBt.Enabled = true;
                UpdateDetails.Text="";
                foreach (Update u in this.Updates)
                {
                    this.UpdateDetails.Text += String.Format("\n {0} \n {1}  \n", u.Name, u.Link);
                }
                DownloadClient = new WebClient();
                DownloadClient.DownloadProgressChanged +=new DownloadProgressChangedEventHandler(DownloadClientWorkProgressChanged);
                DownloadClient.DownloadFileCompleted +=new AsyncCompletedEventHandler(DownloadClientWorkCompleted);
            }  
        }
        private void DownloadClientWorkProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.DownloadProgress.Value = e.ProgressPercentage;
        }
        private void DownloadClientWorkCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("");
            }
            else
            {
               //success
            }
            this.DownloadBt.Enabled = false;
        }


        private void CancelUpdate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RunAsDeamon(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void InstallUpdate(object sender, EventArgs e)
        { 
            Update u = this.Updates[0];
            DownloadClient.DownloadFileAsync(new Uri("http://evansofts.com/moo/updatefiles/fireg.dll"), @"C:\sample");
            this.DownloadBt.Enabled = false;
            this.DeamonBt.Enabled = false;
        }

        public static void Show(List<Update> MooUpdates)
        {
            UpdateDialog Instance = new UpdateDialog(MooUpdates);
            Instance.ShowDialog();
        }

        

       

      

    }
}
