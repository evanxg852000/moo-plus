using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moo.Dialogs
{
    public partial class NewProFileDialog : Form
    {
        public string RType
        {
            get { return TypeCbx.SelectedItem.ToString(); }
        }
        public string RName
        {
            get { return NameTbx.Text; }
        }
        public string RFolder
        {
            get { return FolderTbx.Text; }
        }

 
        public NewProFileDialog(string type,string currentprojectfolder)
        {
            InitializeComponent();
            
            if (type == "FILE")
            {
                this.Text += "File";
                this.NameTbx.Text = "< File Name >";
                this.FolderTbx.Text = "< File Folder >";
                if (currentprojectfolder!=String.Empty)
                {
                    this.FolderTbx.Text = currentprojectfolder;
                }
                this.TypeCbx.Items.AddRange(new string[]{"C#","C++","Html","Php"});
            }
            else 
            {
                this.Text += "Project";
                this.NameTbx.Text = "< Project Name >";
                this.FolderTbx.Text = "< Project Folder >";
                this.TypeCbx.Items.AddRange(new string[] { "C Sharp", "Hydro", "Ilasm", "Website", "Unmanaged" });

            }
           this.TypeCbx.SelectedIndex = 0; 
        }
        private void BrowseBt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            if (fb.ShowDialog() == DialogResult.OK)
            {
               FolderTbx.Text = fb.SelectedPath;
            }
        }  
        private void CancelBt_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void CreateBt_Click(object sender, EventArgs e)
        {
            //check for validation before closing
            //a litle hard code in this area (really d'ont like ) 
            if(TypeCbx.SelectedIndex !=0 )                 
            {
                if ((NameTbx.Text != "< File Name >") && (NameTbx.Text != "< Project Name >"))
                {
                    if ((FolderTbx.Text != "< File Folder >") && (FolderTbx.Text != "< Project Folder >"))
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                        return;
                    }
                }
            }
            MessageBox.Show("Please Complete the form !","Moo {+}",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }



    }
}
