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
        private string brunchfile;
        private DataSet brunchdatastructure;
        

        public string BrunchFile {
            get { return brunchfile; }
        }
        public DataSet BrunchDataStructure {
            get { return brunchdatastructure; }
        }
        
        public BrunchBrowser(){  
            InitializeComponent();
            this.brunchfile =Path.GetDirectoryName(Application.ExecutablePath) +@"\Configuration\brunchs.xml";
            this.GetData();
            //add handler
            this.DoubleClick += new EventHandler(BrunchBrowser_DoubleClick);
        }       
        public override void Refresh(){
            this.Nodes.Clear();
            this.BuildNodes(this.brunchdatastructure);           
        }
        public void SaveData(){
            this.brunchdatastructure.WriteXml(this.brunchfile);
        }

        protected override void OnPaint(PaintEventArgs pe){
            base.OnPaint(pe);
        }                                      
        public void BuildNodes(DataSet DataStructure)
        {   
            //building the root node 
            TreeNode Root = new TreeNode("Brunches");    
            Root.Name = "Brunches";
            Root.StateImageIndex = (int)FBrunchImages.Bundle;
            Root.SelectedImageIndex = (int)FBrunchImages.Bundle;
            Root.Tag = "Brunches";
            //build the nodes using structure
            if (DataStructure == null) { return; }

            foreach (DataTable table in DataStructure.Tables)
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
                    Brunch.Name = Brow["Name"].ToString();
                    Brunch.ImageIndex = (int)FBrunchImages.Brunch;
                    Brunch.SelectedImageIndex = (int)FBrunchImages.Brunch;
                    Brunch.Tag = Brow["Content"].ToString();
                    Brunch.ToolTipText = Brow["Triger"].ToString();

                    BType.Nodes.Add(Brunch);
                }
                //add the folder to the root
                Root.Nodes.Add(BType);
            }
            //add the root to the brunchbrowserview
            Root.Expand();
            this.Nodes.Add(Root);  
        }
        public void UpdateData(DataSet datastructure)
        {
            this.brunchdatastructure = datastructure;
        }

        public Dictionary<string, string> GetBrunchDictionary(string brunchtype) 
        {
            Dictionary<string, string> Dic = new Dictionary<string, string>();
            foreach (DataRow dr in this.brunchdatastructure.Tables[brunchtype].Rows)
            {
                if (!Dic.ContainsKey(dr["Triger"].ToString()))
                {
                    Dic.Add(dr["Triger"].ToString(), dr["Content"].ToString());
                }
            }
            if (brunchtype == "TEXT")
            {
                return Dic;
            }
            foreach (DataRow dr in this.brunchdatastructure.Tables["TEXT"].Rows)
            {
                if (!Dic.ContainsKey(dr["Triger"].ToString()))
                {
                    Dic.Add(dr["Triger"].ToString(), dr["Content"].ToString());
                }   
            }            
            return Dic;
        }
        private void GetData() 
        {  
            //read the xml file
            DataSet XmlDs = new DataSet();
            try
            {

                XmlDs.ReadXml(this.brunchfile);
            }
            catch {return;}
            //sort the dataset structure
            foreach (DataTable category in XmlDs.Tables)
            {
                DataView dv = new DataView(category);
                dv.Sort = "Name";
            }
            //fill the structure field  
            this.brunchdatastructure = XmlDs;
        }
        
        private void BrunchBrowser_DoubleClick(object sender, EventArgs e)
        {
            if (this.SelectedNode==null){return;}
    
            if (this.SelectedNode.Level == 2) {
                if (ItemSelected != null){
                    try{
                        ItemSelected(this.SelectedNode.Tag.ToString());
                    }
                    catch{ /*do nothing*/ }
                }
            }
        }
        
    }
}
