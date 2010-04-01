using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls
{
    #region Global
        public enum Images { home = 0, folder, ofolder, file, brunch }
        public delegate void ItemSelectedHandler(string itemTag);
    #endregion

    public partial class BrunchBrowser : TreeView
    {
        public event ItemSelectedHandler ItemSelected;
        private string rootfolder = "brunchs";
        public string RootFolder
        {
            get { return rootfolder; }
            set { rootfolder = value; }
        }

        public BrunchBrowser()
        {
            InitializeComponent();
            BuildNodes();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        
        private void BuildNodes()
        {
            //building the root node 
            TreeNode Root = new TreeNode("Brunchs");
            Root.Name = "Brunchs";
            Root.StateImageIndex = (int)Images.home;
            Root.SelectedImageIndex = (int)Images.home;
            Root.Tag = this.RootFolder;

            try
            {
                DirectoryInfo di = new DirectoryInfo(this.RootFolder);
                foreach (DirectoryInfo item in di.GetDirectories())
                {
                    TreeNode BrunchFolder = new TreeNode(item.Name);
                    BrunchFolder.Name = item.Name;
                    BrunchFolder.ImageIndex = (int)Images.folder;
                    BrunchFolder.SelectedImageIndex = (int)Images.ofolder;
                    BrunchFolder.Tag = item.FullName;

                    DirectoryInfo dibis = new DirectoryInfo(item.FullName);
                    foreach (FileInfo itembis in dibis.GetFiles())
                    {
                        TreeNode BrunchItem = new TreeNode(itembis.Name.Split('.')[0]);
                        BrunchItem.Name = itembis.Name;
                        BrunchItem.ImageIndex = (int)Images.brunch;
                        BrunchItem.SelectedImageIndex = (int)Images.brunch;
                        BrunchItem.Tag = itembis.FullName;

                        BrunchFolder.Nodes.Add(BrunchItem);
                    }
                    //add the folder to the root
                    Root.Nodes.Add(BrunchFolder);
                }
            }
            catch
            {
                //be sillent to say that notthing was found as brunch
            }
            //add the root to the brunchbrowserview
            this.Nodes.Add(Root);
            this.CollapseAll();
            //add handler
            this.DoubleClick += new EventHandler(BrunchBrowser_DoubleClick);

        }

        void BrunchBrowser_DoubleClick(object sender, EventArgs e)
        {  
            if (this.SelectedNode.Level == 2)
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
        }

        
    }
}
