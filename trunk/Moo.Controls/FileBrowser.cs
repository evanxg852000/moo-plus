using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls
{
    public partial class FileBrowser : TreeView
    {
        public event ItemSelectedHandler ItemSelected;
        
        public FileBrowser()
        {
            InitializeComponent();
            //add handler
            this.DoubleClick += new EventHandler(ProjectBrowser_DoubleClick);
        }     
        public override void Refresh()
        {
            this.Nodes.Clear();
            BuildNodes();
            this.ExpandAll();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public void BuildNodes()
        {
            try
            {
                //building the drives node 
                string[] drives = Directory.GetLogicalDrives();
                foreach (string s in drives)
                {
                    TreeNode drive = new TreeNode(s);
                    drive.Name = s;
                    drive.StateImageIndex = (int)FSystemImages.Drive;
                    drive.SelectedImageIndex = (int)FSystemImages.Drive;
                    drive.Tag = s;
                    drive.ToolTipText = s;
                    this.Nodes.Add(drive);
                }   
            }
            catch
            {
                //be sillent to say that notthing was found as brunch
            }
            this.ExpandAll();
        }
        private void ScanDir(string dirpath, TreeNode parent)
        {

            if (parent.Nodes.Count != 0)
                return;
            try
            {
                DirectoryInfo di = new DirectoryInfo(dirpath);

                //for folders
                foreach (DirectoryInfo folder in di.GetDirectories())
                {
                    //do not show Hidden,System and tempo folders
                   if( ((folder.Attributes & FileAttributes.System) == FileAttributes.System))
                       continue;
                   if (((folder.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden))
                       continue;
                   if (((folder.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary))
                        continue;
                   
                        TreeNode sbn = new TreeNode(folder.Name);
                        sbn.Name = folder.Name;
                        sbn.ImageIndex = (int)FSystemImages.Foclose;
                        sbn.SelectedImageIndex = (int)FSystemImages.Foopen;
                        sbn.Tag = folder.FullName;
                        sbn.ToolTipText = folder.FullName;    
                        //add to tn
                        parent.Nodes.Add(sbn);
                    
                }
                //for files
                foreach (FileInfo fi in di.GetFiles())
                {
                    //do not show Hidden,System and tempo files
                    if (((fi.Attributes & FileAttributes.System) == FileAttributes.System))
                        continue;
                    if (((fi.Attributes & FileAttributes.Hidden) == FileAttributes.Hidden))
                        continue;
                    if (((fi.Attributes & FileAttributes.Temporary) == FileAttributes.Temporary))
                        continue;

                    TreeNode sbn = new TreeNode(fi.Name);
                    sbn.Name = fi.Name;
                    sbn.ImageIndex = (int)FSystemImages.File;
                    sbn.SelectedImageIndex = (int)FSystemImages.File;
                    sbn.Tag = fi.FullName;
                    sbn.ToolTipText = fi.FullName;
                    //add to tn
                    parent.Nodes.Add(sbn);
                }
            }
            catch
            {
                //be sillent
            }
            parent.ExpandAll();
        }
        void ProjectBrowser_DoubleClick(object sender, EventArgs e)
        {
            bool isfile = Path.HasExtension(this.SelectedNode.Tag.ToString());
            if (isfile)
            {
                if (ItemSelected != null)
                {
                    try
                    {
                        ItemSelected(this.SelectedNode.Tag.ToString());
                    }
                    catch
                    {
                        //do nothing
                    }
                }
            }
            else
            {
                ScanDir(this.SelectedNode.Tag.ToString(), this.SelectedNode);
            }
        }

    }
}
