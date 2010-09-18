using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls
{
    public partial class ProjectBrowser : TreeView
    {
        public event ItemSelectedHandler ItemSelected;
        private string projectfolder ="";  // is a fullpath like c:\\projects\sample\
        private string projectfile = "";              // is a fullpath like c:\\projects\sample\sample.mpr
        private string projectname = "";            // is a file name sample.mpr without extention

        public ProjectBrowser()
        {
            InitializeComponent();
            this.ShowPlusMinus = true;
        }
        public override void Refresh()
        {
            this.Nodes.Clear();
            BuildNodes(this.projectfolder,this.projectfile,this.projectname);
            this.ExpandAll();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public void BuildNodes(string pfolder, string pfile,string pname)
        {
            //clear everything
            this.Nodes.Clear();

            this.projectfolder = pfolder;
            this.projectfile = pfile;
            this.projectname = pname;

            //building the root node of the project  
            TreeNode Root = new TreeNode(this.projectname);
            Root.Name = this.projectname;
            Root.StateImageIndex = (int)FProjectImages.Workspace;
            Root.SelectedImageIndex = (int)FProjectImages.Workspace;
            Root.Tag = this.projectfolder;


            try
            {
                ScanDir(this.projectfolder, Root); 
            }
            catch
            {
                //be sillent to say that notthing was found as brunch
            }
            //add the root(workspace) to the brunchbrowserview
            this.Nodes.Add(Root);
            this.ExpandAll();
            //add handler
            this.DoubleClick += new EventHandler(ProjectBrowser_DoubleClick);       
        }       
        private void ScanDir(string dirpath, TreeNode  parent)
        {
            
            if (parent.Nodes.Count != 0)
                return ;
            try
            {
                DirectoryInfo di = new DirectoryInfo(dirpath);

                //for folders
                foreach (DirectoryInfo folder in di.GetDirectories())
                {
                    TreeNode sbn = new TreeNode(folder.Name);
                    sbn.Name = folder.Name;
                    sbn.ImageIndex = (int)FProjectImages.Foclose;
                    sbn.SelectedImageIndex = (int)FProjectImages.Foopen;
                    sbn.Tag = folder.FullName;
                    //add to tn
                    parent.Nodes.Add(sbn);
                }
                //for files
                foreach (FileInfo fi in di.GetFiles())
                {
                    TreeNode sbn = new TreeNode(fi.Name);
                    sbn.Name = fi.Name;
                    sbn.ImageIndex = (int)FProjectImages.File;
                    sbn.SelectedImageIndex = (int)FProjectImages.File;
                    sbn.Tag = fi.FullName;
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
           bool isfile= Path.HasExtension(this.SelectedNode.Tag.ToString());
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
