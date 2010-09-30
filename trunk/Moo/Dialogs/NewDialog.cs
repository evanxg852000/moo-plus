using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using Yalamo.Gui;

namespace Moo.Dialogs
{
    public partial class NewDialog : YForm
    {
        private Project createdproject;
        private string currentfolder;
        public Project CreateProject {
            get { return createdproject; }
        }

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

 
        public NewDialog(Project currentProject)
        {
            InitializeComponent();
            this.SetupMargin();
            this.currentfolder=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Moo Workspace";
            if (currentProject != null)
            {
                this.currentfolder = currentProject.Folder;
            }
            
            //initialise           
            this.TypeCbx.Items.AddRange(new string[]{"C Sharp Project","Visual Basic Project","Ilasm Project","Hydro Project" });
            this.NameTbx.Text="";
            this.FolderTbx.Text = this.currentfolder;  
            this.TypeCbx.SelectedIndex = 0; 
        }
        private void ProjectCategoryChangeHandler(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.TypeCbx.Items.Clear();
            switch (e.Item.Tag.ToString())
            {
                case "DESKTOP":
                    this.TypeCbx.Items.AddRange(new string[] { "C Sharp Project", "Visual Basic Project", "Ilasm Project", "Hydro Project" });
                    break;
                case "WEB":
                    this.TypeCbx.Items.AddRange(new string[] { "Html Website", "Yalamo Framework Project" });
                    break;
                case "DATABASE":
                    this.TypeCbx.Items.AddRange(new string[] { "Edml Project"});
                    break;
                case "AJAX":
                    this.TypeCbx.Items.AddRange(new string[] { "Adobe Air Project" });
                    break;
                case "FILE":
                    this.TypeCbx.Items.AddRange(new string[]{"Asp","Batch","C++","C#","D","Html", "Hydro","Java","Javascript",
                                                             "Pascal","Php","Sql","VBasic","Xml" });
                    break;
                case "UNMANAGED":
                    this.TypeCbx.Items.AddRange(new string[] { "Unmanaged" });
                    break;
            }
            this.StatusMsg.Text = e.Item.ToolTipText;
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
                if (NameTbx.Text !=String.Empty)
                {
                    if (FolderTbx.Text != String.Empty)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.createdproject = new Project();
                        this.Close();
                        return;
                    }
                }
            this.StatusMsg.Text="Please Complete the form !";
        }

        

        

        



    }
}
