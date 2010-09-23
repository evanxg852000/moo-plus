using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Yalamo.Gui;
using Moo.Core;
using Moo.Helpers;


namespace Moo.Dialogs
{
    public partial class BrunchEditorDialog : YForm
    {
        private DataSet brunchdatastructure;
        private Dictionary<string, string> brunchtrigerdictionary;

        public DataSet BrunchDataStructure{
            get { return this.brunchdatastructure; }
        }
        public Dictionary<string, string> BrunchTrigerDictionary {
            get { return this.brunchtrigerdictionary; }
        }

        public BrunchEditorDialog(DataSet brunchdatastructure)
        {
            InitializeComponent();
            this.SetupMargin();
            this.brunchdatastructure = brunchdatastructure;
            this.brunchtrigerdictionary = new Dictionary<string, string>();
            this.BrunchTree.BuildNodes(this.brunchdatastructure);
            foreach (DataTable type in this.brunchdatastructure.Tables)
            {
                this.BTypeCbx.Items.Add(type.TableName.ToString());
            }
            this.SaveCurrentEdit.Enabled = false;
            this.KeyTxt.Enabled = false;
        }
        public static void Show(DataSet bruncstructure)
        {
            BrunchEditorDialog Instance = new BrunchEditorDialog(bruncstructure);
            Instance.ShowDialog();
        }

        private void initialisefield(){
            this.SaveCurrentEdit.Enabled = true;
            this.BrunchTxt.Text = String.Empty;
            this.NameTxt.Text = String.Empty;
            this.BTypeCbx.SelectedIndex = 0;
            this.TrigerTxt.Text = String.Empty;       
        }
        
      
        private void AddNewBrunch(object sender, EventArgs e)
        {

        }
        private void EditSelectedBrunch(object sender, EventArgs e)
        {
            MessageBox.Show("edit todo");
        }
        private void RemoveSelectedBrunch(object sender, EventArgs e)
        {
            MessageBox.Show("remove todo");
        }      

        private void BruchTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrunchTxt.ConfigurationManager.Language = BTypeCbx.SelectedItem.ToString();
        }
        private void ApplyChangesHandler(object sender, EventArgs e)
        {
            string bname = this.NameTxt.Text;
            string btype = this.BTypeCbx.SelectedItem.ToString();
            string bcontent = this.BrunchTxt.Text;

            if ((bname == "Brunch name..."))
            {
                this.StatusMsg.Text = "Brunch name is required";
                return;
            }
            if ((this.BTypeCbx.SelectedIndex == 0))
            {
                this.StatusMsg.Text = "Brunch Type is required";
                return;
            }
            if ((bcontent == "Brunch content here..."))
            {
                this.StatusMsg.Text = "Brunch content is required";
                return;
            }
            string filepath = Path.GetDirectoryName(Application.ExecutablePath);
            filepath += Moo.Core.AppSettings.GetFolder("brunchs") + btype + @"\" + bname + ".mcb";
            FileHelper.Save(filepath, bcontent);
            this.Close();
        }
 
       
        
    }
}
