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
        private string newoption;
        private Project createdproject;
        private string currentfolder;
        public Project CreateProject {
            get { return createdproject; }
        }

        public string ResultObjectType
        {
            get { return TypeCbx.SelectedItem.ToString(); }
        }
        public string ResultObjectName
        {
            get { return NameTbx.Text; }
        }
        public string ResultObjectFolder
        {
            get { return FolderTbx.Text; }
        }
        public string NewOption 
        {
            get { return newoption; }
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
            this.newoption = "PROJECT";
            this.createdproject = null;
            this.TypeCbx.Items.AddRange(new string[] { "C SHARP", "ILASM", "HYDRO", "V BASIC" });
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
                    this.TypeCbx.Items.AddRange(new string[] { "C SHARP", "ILASM", "HYDRO", "V BASIC" });
                    this.newoption = "PROJECT";
                    break;
                case "WEB":
                    this.TypeCbx.Items.AddRange(new string[] { "HTML WEBSITE", "YALAMO WEBSITE" });
                    this.newoption = "PROJECT";
                    break;
                case "DATABASE":
                    this.TypeCbx.Items.AddRange(new string[] { "DATABASE"});
                    this.newoption = "PROJECT";
                    break;
                case "AJAX":
                    this.TypeCbx.Items.AddRange(new string[] { "ADOBE AIR" });
                    this.newoption = "PROJECT";
                    break;
                case "FILE":
                    this.TypeCbx.Items.AddRange(new string[]{"TEXT","ASP","BATCH","CS","CSS","CPP","CPPH","D","HTML","HTM",
                                           "XHTML","HYDRO","ILASM", "JAVA","JAVASCRIPT","PASCAL","PHP", "SQL","VB","XML" });
                    this.newoption = "FILE";
                    break;
                case "UNMANAGED":
                    this.TypeCbx.Items.AddRange(new string[] { "UNMANAGED" });
                    this.newoption = "PROJECT";
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
            if (NameTbx.Text == String.Empty) { this.StatusMsg.Text = "Please Complete the form !"; return; }
            if (FolderTbx.Text == String.Empty) { this.StatusMsg.Text = "Please Complete the form !"; return; }
            //if the user setsup a project we create it , if he sets up a file we just leave properties to be taken by the caller
            if (this.newoption == "PROJECT")
            {
                PType protype= PType.Unmanaged;
                switch (TypeCbx.SelectedItem.ToString())
                {
                    case "ADOBE AIR":
                        protype = PType.Adobeair;
                        break;
                    case "C SHARP":
                        protype = PType.Csharp;
                        break;
                    case "DATABASE":
                        protype = PType.Databse;
                        break;
                    case "ILASM":
                        protype = PType.Ilasm;
                        break;
                    case "HTML WEBSITE":
                        protype = PType.Website;
                        break;
                    case "HYDRO":
                        protype = PType.Hydro;
                        break;
                    case "UNMANAGED":
                        protype = PType.Unmanaged;
                        break;
                    case "V BASIC":
                        protype = PType.Vbasic;
                        break;
                    case "YALAMO WEBSITE":
                        protype = PType.Yalamof;
                        break;
                }
                this.createdproject = ProjectFactory.Create(FolderTbx.Text, NameTbx.Text, protype,IncTemplate.Checked);
            }    
            this.DialogResult = DialogResult.OK;
            this.Close();           
            
        }

        

        

        



    }
}
