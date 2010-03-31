using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls
{

    public enum Images { home = 0, folder, ofolder, brunch, file }

    public partial class BrunchBrowser : TreeView
    {
        public BrunchBrowser()
        {
            InitializeComponent();
            BuildNodes();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private string rootfolder = "brunchs";
        public string RootFolder
        {
            get { return rootfolder; }
            set { rootfolder = value; }
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

        }

        
    }
}
