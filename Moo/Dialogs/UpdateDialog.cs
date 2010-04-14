using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Windows.Forms;
using Moo.Helpers;

namespace Moo.Dialogs
{
    public partial class UpdateDialog : Form
    {
        private static UpdateDialog Instance;
        private MooOnlineInfo OnLineInfo;
        private WebClient DownloadClient;
        public UpdateDialog(MooOnlineInfo info)
        {
            InitializeComponent();
            this.OnLineInfo = info;
            if ((this.OnLineInfo.Plugins.Count != 0) || (this.OnLineInfo.Updates.Count != 0))
            {
                //add element to listview
                
                DownloadClient = new WebClient();
                DownloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadClientWorkProgressChanged);
                DownloadClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadClientWorkCompleted);
            }
        }
        public static void Show(MooOnlineInfo info)
        {
            if (UpdateDialog.Instance == null)
            {
                Instance = new UpdateDialog(info);
            }
            Instance.ShowDialog();
        }

        private void DownloadClientWorkProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.DownloadProgress.Value = e.ProgressPercentage;
        }
        private void DownloadClientWorkCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.InnerException.ToString());
                //send Exceptioner e.InnerException   
            }
            else
            {
                if (!this.Visible)
                {
                    MessageBox.Show("Update Completed !!");
                }
            }
            
        }


    }
}
