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
        private DataSet brunchstructure;
        private string file = "";
        public DataSet BrunchStructure {
            get { return brunchstructure; }
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
        public void BuildNodes()
        {
            //read the xml file
            try {
                this.brunchstructure = new DataSet();
                this.brunchstructure.ReadXml(Path.GetDirectoryName(Application.ExecutablePath)+this.file);
            } catch {  /*Silence is golden*/ }
            DataSet Structure = this.brunchstructure;
            DataView categoryTable = new DataView(Structure.Tables["Btype"]);
            categoryTable.Sort = "Name";
            DataView brunchTable = new DataView(Structure.Tables["Brunch"]);

            //building the root node 
            TreeNode Root = new TreeNode("Brunches");    
            Root.Name = "Brunches";
            Root.StateImageIndex = (int)FBrunchImages.Bundle;
            Root.SelectedImageIndex = (int)FBrunchImages.Bundle;
            Root.Tag = "Brunches";

            foreach (DataRowView Row in categoryTable)
            {
                //counter to check the relation key
                int counter = 0;
                //create brunch type  node
                TreeNode BType = new TreeNode(Row["Name"].ToString());
                BType.Name = Row["Name"].ToString();
                BType.ImageIndex = (int)FBrunchImages.Btype;
                BType.SelectedImageIndex = (int)FBrunchImages.Btype;
                BType.Tag = Row["Name"].ToString();
                
                foreach (DataRowView BRow in brunchTable)
                {
                    if(counter== int.Parse(BRow["Btid"].ToString()) ){
                        TreeNode Brunch = new TreeNode(BRow["Name"].ToString());
                        Brunch.Name = BRow["Name"].ToString();
                        Brunch.ImageIndex = (int)FBrunchImages.Brunch;
                        Brunch.SelectedImageIndex = (int)FBrunchImages.Brunch;
                        Brunch.Tag = BRow["Content"].ToString();

                        BType.Nodes.Add(Brunch);
                    }
                }
                
                counter++;
                //add the folder to the root
                Root.Nodes.Add(BType);
            }
            
            

            //add the root to the brunchbrowserview
            this.Nodes.Add(Root);
            this.CollapseAll();
            //add handler
            this.DoubleClick += new EventHandler(BrunchBrowser_DoubleClick);

        }
       

        
    }
}
