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
using Moo.Core;
using Moo.Helpers;
using Yalamo.Gui;

namespace Moo.Dialogs
{
    public partial class UpdateDialog : YForm
    {
        private static UpdateDialog Instance;
        private OnlineInfo OnLineInfo;
        private WebClient DownloadClient;
        private UpdateDialog()
        {
            InitializeComponent();
            PluginDescription.Text = "Retrieving online info ...";
            DownloadProgress.Style = ProgressBarStyle.Marquee;
            DownloadClient = new WebClient();
            DownloadClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadClientWorkProgressChanged);
            DownloadClient.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadClientWorkCompleted);
            UpdateRetriever.RunWorkerAsync();
        }
      

        private void URGetOnlineInfo(object sender, DoWorkEventArgs e)
        {
            if (OnlineInfo.IsInternet())
            {
                OnlineInfo.CheckOutForUpdate();
            }    
        }
        private void URGetOnlineInfoCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.OnLineInfo = OnlineInfo.GetInstance();
            if ((this.OnLineInfo.Plugins.Count != 0) || (this.OnLineInfo.Updates.Count != 0))
            {
                //add updates to the list
                foreach (Update u in this.OnLineInfo.Updates)
                {
                    ListViewItem item = new ListViewItem(new string[] { "Update", u.Name, u.Link });
                    item.Tag = u.TargetLocation;
                    PluginListView.Items.Add(item);
                }
                //add plugin to listview
                foreach (Plugin p in this.OnLineInfo.Plugins)
                {
                    string localfile = Path.GetDirectoryName(Application.ExecutablePath) + AppSettings.GetFolder("pluginsfolder") + Path.GetFileName(p.Link);
                    if (!new FileInfo(localfile).Exists)
                    {
                        ListViewItem item = new ListViewItem(new string[] { "Plugin", p.Name, p.Link });
                        item.Tag = p.Description;
                        PluginListView.Items.Add(item);
                    }

                }  
            }
            PluginDescription.Text = "";
            DownloadProgress.Style = ProgressBarStyle.Blocks;
        }

        public static new void Show()
        {
            if (UpdateDialog.Instance == null)
            {
                Instance = new UpdateDialog();
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
                PluginDescription.Text=e.Error.InnerException.ToString();
                //send Exceptioner e.InnerException   
            }
            else
            {
                      PluginDescription.Text="Update Completed !!";
            }
            
        }
        private void InstallHandler(object sender, EventArgs e)
        {
           
            if (PluginListView.SelectedItems.Count==0)
            {
               PluginDescription.Text ="No item selected";
               return;
            }
            ListViewItem selectedItem = PluginListView.SelectedItems[0];
            Uri fileurl =new Uri(selectedItem.SubItems[2].Text);
            string localfile = Path.GetFileName(selectedItem.SubItems[2].Text);
            string localfilepath = "";
            if (File.Exists(localfile))
            {
                PluginDescription.Text = "This update is already installed";
                return;
            }
            switch (selectedItem.SubItems[0].Text)
            { 
                case "Plugin":
                    try
                    {
                        localfilepath = Path.GetDirectoryName(Application.ExecutablePath) + AppSettings.GetFolder("plugins") + localfile;
                        DownloadClient.DownloadFileAsync(fileurl, localfilepath);
                    }
                    catch (Exception ex) { Exceptioner.Log(ex); }                                             
                    break;
                case "Update":
                        localfilepath = Path.GetDirectoryName(Application.ExecutablePath) + localfile;
                        DownloadClient.DownloadFileAsync(fileurl,localfilepath);
                    break;
            }

        }
        private void SelectedItemChangedHandler(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (PluginListView.SelectedItems.Count != 0)
            {
                PluginDescription.Text = PluginListView.SelectedItems[0].Tag.ToString(); 
            } 
        }
        private void CancelHandler(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
