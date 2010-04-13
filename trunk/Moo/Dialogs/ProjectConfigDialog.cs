using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using Moo.Helpers;

namespace Moo.Dialogs
{
    public partial class ProjectConfigDialog : Form
    {
        private Project CurrentProject;
        public ProjectConfigDialog(Project currentproject)
        {
            InitializeComponent();
            this.CurrentProject = currentproject;
            InitializeToCurrentproject();
        }
        private void InitializeToCurrentproject()
        {
            this.Text += " [ " + CurrentProject.ProjectName + " ]";
            this.AssemblyNameTbx.Text = CurrentProject.AssemblyName;
            if (CurrentProject.AssemblyType == "Executable (.exe)")
            {
                this.AssemblyTypeCbx.SelectedIndex = 0;
            }
            else
            {
                this.AssemblyTypeCbx.SelectedIndex = 1;
            }

            if (CurrentProject.BuildTarget == "Debug")
            {
                this.BuildTargetCbx.SelectedIndex = 0;
            }
            else
            {
                this.BuildTargetCbx.SelectedIndex = 1;
            }
            this.ProjectIconTbx.Text = CurrentProject.ProjectIcon;
            this.ProjectCreateDateTbx.Text = CurrentProject.CreationDate.ToShortDateString();
            foreach (string s in CurrentProject.Refferences)
            {
                string refname = System.IO.Path.GetFileName(s);
                ListViewItem item = new ListViewItem(new string[] { refname, s });
                RefferencesListView.Items.Add(item);
            }
        }
        private string SelectFile(string filter)
        {
            string filepath = "";
            OpenFileDialog openfiledialog = new OpenFileDialog();
            openfiledialog.Title = "Open ...";
            openfiledialog.Filter = filter; 
            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openfiledialog.FileName;
            }
            return filepath;
        }
        private void SetAppIcon(object sender, EventArgs e)
        {
            this.ProjectIconTbx.Text = this.SelectFile("Icon file (*.ico)|*.ico");
        }
        private void AddRefference(object sender, EventArgs e)
        {
            string refpath = this.SelectFile("Dynamic Library file (*.dll)|*.dll");
            string refname = System.IO.Path.GetFileName(refpath);
            if (refpath != String.Empty)
            {
                ListViewItem item = new ListViewItem(new string[] { refname, refpath });
                RefferencesListView.Items.Add(item);
            }
        }
        private void RemoveRefference(object sender, EventArgs e)
        {
            if(RefferencesListView.SelectedItems.Count!=0)
            {
                RefferencesListView.SelectedItems[0].Remove();
            }
        }
        
        private void SaveBt_Click(object sender, EventArgs e)
        {
            //apply changes and save the project state
            CurrentProject.AssemblyName = this.AssemblyNameTbx.Text;
            CurrentProject.AssemblyType = this.AssemblyTypeCbx.SelectedItem.ToString();
            CurrentProject.BuildTarget = this.BuildTargetCbx.SelectedItem.ToString();
            CurrentProject.ProjectIcon = this.ProjectIconTbx.Text;
            CurrentProject.Refferences.Clear();
            foreach (ListViewItem item in RefferencesListView.Items )
            {
                string refpath = item.SubItems[1].Text;                
                CurrentProject.Refferences.Add(refpath);
            }
            CurrentProject.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

       
       
    }
}
