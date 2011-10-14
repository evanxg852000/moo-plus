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
        private string currenteditedtable;
        private int currenteditedrowindex;

     
        public DataSet BrunchDataStructure
        {
            get { return this.brunchdatastructure; }
        }

        public BrunchEditorDialog(DataSet brunchdatastructure)
        {
            InitializeComponent();
            this.BrunchTree.UpdateData(brunchdatastructure);
            this.BTypeCbx.Items.Clear();
            foreach (DataTable type in this.BrunchTree.BrunchDataStructure.Tables)
            {
                this.BTypeCbx.Items.Add(type.TableName.ToString());
            }
            initialisefield();
        }

        private void initialisefield(){
            this.BrunchTree.Refresh();
            this.BrunchTxt.Text = String.Empty;
            this.NameTxt.Text = String.Empty;
            this.BTypeCbx.SelectedIndex = 0;
            this.BTypeCbx.Enabled = true;
            this.TrigerTxt.Text = String.Empty;
            this.SaveCurrentEdit.Enabled = false;

            this.KeyTxt.Text = "K";
            this.KeyTxt.Enabled = false;       
        }
        private bool checkinput()
        {
            if (BrunchTxt.Text == String.Empty) { return false; }
            if (NameTxt.Text == String.Empty) { return false; }
            if (BTypeCbx.Text == String.Empty) { return false; }
            if (TrigerTxt.Text == String.Empty) { return false; }
            return true;
        }
      
        private void AddNewBrunch(object sender, EventArgs e)
        {
            if (this.checkinput() == false)
            {
                StatusBarMsg.Text = "Please fill the brunch form";
                return;
            }
            else 
            {
                StatusBarMsg.Text = String.Empty;
            }
            DataRow Brow = BrunchTree.BrunchDataStructure.Tables[BTypeCbx.Text].NewRow();
            Brow["Name"]=NameTxt.Text;
            Brow["Triger"]=TrigerTxt.Text;
            Brow["Content"] = BrunchTxt.Text;
            BrunchTree.BrunchDataStructure.Tables[BTypeCbx.Text].Rows.Add(Brow);
            initialisefield();
        }
        private void RemoveSelectedBrunch(object sender, EventArgs e)
        {
            if ((this.BrunchTree.SelectedNode == null)||(this.BrunchTree.SelectedNode.Level == 1) ) {
                StatusBarMsg.Text = "Please select a brunch";
                return;
            }
            StatusBarMsg.Text = String.Empty;
            string message;
            if (this.BrunchTree.SelectedNode.Level == 2)
            {
                message = "You are about to remove the brunch " + this.BrunchTree.SelectedNode.Text;
                if (MessageBox.Show(message, "Moo { + }", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    return;
                }
                string brunchtable = this.BrunchTree.SelectedNode.Parent.Text;
                this.BrunchTree.BrunchDataStructure.Tables[brunchtable].Rows.RemoveAt(this.BrunchTree.SelectedNode.Index);
            }
            this.BrunchTree.Refresh();

        }      
       
        private void EditSelectedBrunch(object sender, EventArgs e)
        {
            if (this.BrunchTree.SelectedNode == null) {
                StatusBarMsg.Text = "Please select a brunch";
                return;
            }
            StatusBarMsg.Text = String.Empty;
            if (this.BrunchTree.SelectedNode.Level == 2)
            {
                this.currenteditedtable=this.BrunchTree.SelectedNode.Parent.Text;
                this.currenteditedrowindex = this.BrunchTree.SelectedNode.Index;
                DataRow Brow = this.BrunchTree.BrunchDataStructure.Tables[currenteditedtable].Rows[currenteditedrowindex];
                BrunchTxt.Text = Brow["Content"].ToString();
                NameTxt.Text = Brow["Name"].ToString();
                TrigerTxt.Text = Brow["Triger"].ToString();
                BTypeCbx.Text = currenteditedtable;
                BTypeCbx.Enabled = false;
                SaveCurrentEdit.Enabled = true;  
            }
        }
        private void SaveCurrentEditHandler(object sender, EventArgs e)
        {
            DataRow Brow = this.BrunchTree.BrunchDataStructure.Tables[currenteditedtable].Rows[currenteditedrowindex];
            Brow["Name"] = NameTxt.Text;
            Brow["Triger"] = TrigerTxt.Text;
            Brow["Content"] = BrunchTxt.Text;
            initialisefield();
        }
        private void CleanHandler(object sender, EventArgs e)
        {
            this.initialisefield();
        }

        
        private void BruchTypeCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            BrunchTxt.ConfigurationManager.Language = BTypeCbx.SelectedItem.ToString();
        }       
        private void ApplyChangesHandler(object sender, EventArgs e)
        {
            this.brunchdatastructure = this.BrunchTree.BrunchDataStructure;
            this.DialogResult=DialogResult.OK;
        }
        private void CancelChangesHandler(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

             
    }
}
