using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
 

namespace Moo.Controls
{
    public partial class BrunchBrowser : TreeView
    {
        public event ItemSelectedHandler ItemSelected;
        private DataSet structure;
        private Dictionary<string, string> brunchdictionary;
        private string file;
        public DataSet Structure {
            get { return structure; }
        }
        public Dictionary<string, string> BrunchDictionary
        {
            get { return brunchdictionary; }
        }
        
        public string File {
            get { return file; }
            set { file = value; }
        }

        public BrunchBrowser()
        {  
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }                              
        public override void Refresh()
        {
            this.Nodes.Clear();
            BuildNodes();
            this.CollapseAll();
        }      
        public void BuildNodes()
        {
            this.GetData();
            //building the root node 
            TreeNode Root = new TreeNode("Brunches");    
            Root.Name = "Brunches";
            Root.StateImageIndex = (int)FBrunchImages.Bundle;
            Root.SelectedImageIndex = (int)FBrunchImages.Bundle;
            Root.Tag = "Brunches";
            //build the nodes using structure
            if (this.structure == null){return; }

            foreach (DataTable table in this.structure.Tables)
            {
                //create brunch category  node
                TreeNode BType = new TreeNode(table.TableName);
                BType.Name = table.TableName;
                BType.ImageIndex = (int)FBrunchImages.Btype;
                BType.SelectedImageIndex = (int)FBrunchImages.Btype;
                BType.Tag = table.TableName;
                foreach(DataRow Brow in table.Rows)
                {
                    TreeNode Brunch = new TreeNode(Brow["Name"].ToString());
                    Brunch.Name = Brow["Num"].ToString();
                    Brunch.ImageIndex = (int)FBrunchImages.Brunch;
                    Brunch.SelectedImageIndex = (int)FBrunchImages.Brunch;
                    Brunch.Tag = Brow["Content"].ToString();

                    BType.Nodes.Add(Brunch);
                }
                //add the folder to the root
                Root.Nodes.Add(BType);
            }
            //add the root to the brunchbrowserview
            this.Nodes.Add(Root);
            this.CollapseAll();
            //add handler
            this.DoubleClick += new EventHandler(BrunchBrowser_DoubleClick);
        }

        private void GetData() 
        {  
            //read the xml file
            DataSet XmlDs = new DataSet();
            try
            {
                XmlDs.ReadXml(Path.GetDirectoryName(Application.ExecutablePath) +@"\"+ this.file);
            }
            catch {return;}
            //sort the dataset structure
            foreach (DataTable category in XmlDs.Tables)
            {
                DataView dv = new DataView(category);
                dv.Sort = "Name";
            }
            //fill the structure field  
            this.structure = new DataSet();
            this.structure = XmlDs;

            //fill the dictionarry
            this.brunchdictionary = new Dictionary<string, string>();
            foreach (DataTable category in XmlDs.Tables) {
                foreach (DataRow item in category.Rows) { 
                    this.brunchdictionary.Add(item["Triger"].ToString(),item["Content"].ToString());
                }
            }
        }
        private void BrunchBrowser_DoubleClick(object sender, EventArgs e)
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
