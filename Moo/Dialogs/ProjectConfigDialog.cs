using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using Moo.Core;
using Moo.Helpers;
using Yalamo.Gui;


namespace Moo.Dialogs
{
    public partial class ProjectConfigDialog : YForm
    {
        private static ProjectConfigDialog Instance;
        private Project CurrentProject;
        private List<string> ProjectAssemblies;
        private List<string> GlobalAssemblies = new List<string>();
        

        private ProjectConfigDialog(Project Project)
        {
            InitializeComponent();
            this.CurrentProject = Project;
            //this.ProjectAssemblies = Project.Refferences;
            InitializeToCurrentproject();
        }
        public static void Show(Project currentproject)
        {
            if (Instance == null)
            {
                Instance = new ProjectConfigDialog(currentproject);
            }
            Instance.ShowDialog();
        }

        private void InitializeToCurrentproject()
        {
            /*
            this.Text += " [ " + CurrentProject.ProjectName + " ]";
            this.AssemblyNameTbx.Text = CurrentProject.AssemblyName;
            if (CurrentProject.AssemblyType == "Console Executable (.exe)")
            {
                this.AssemblyTypeCbx.SelectedIndex = 0;
            }
            else if (CurrentProject.AssemblyType == "Windows Executable (.exe)")
            {
                this.AssemblyTypeCbx.SelectedIndex = 1;
            }
            else
            {
                this.AssemblyTypeCbx.SelectedIndex = 2;
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
            if ((CurrentProject.ProjectType == ProjectCategory.Unmanaged) || (CurrentProject.ProjectType == ProjectCategory.Website))
            {
                this.AssemblyTypeCbx.Enabled = false;
                this.BuildTargetCbx.Enabled = false;
                this.RefferencesListView.Enabled = false;
                this.AddRefBt.Enabled = false;
                this.RemoveRefBt.Enabled = false;
                return;
            }
            //retrieve installed assemblies
            StatusMsg.Text = "Retrieving Assemblies ...";
            statusProgress.Style = ProgressBarStyle.Marquee;
            this.AssemblySearcher.RunWorkerAsync();  
             */
             
        }      
        private void SetAppIcon(object sender, EventArgs e)
        {
            this.ProjectIconTbx.Text = FileHelper.SelectFile("Icon file (*.ico)|*.ico");
        }
        private void AddRefference(object sender, EventArgs e)
        {
            string path = FileHelper.SelectFile("Dynamic Library file (*.dll)|*.dll");
            if (path != String.Empty)
            {
                this.AddAssemblyToList(path, "Custom",true);
            }
        }
        private void RefreshAssembliesListView(object sender, EventArgs e)
        {
            //retrieve installed assemblies
            this.RefferencesListView.Clear();
            StatusMsg.Text = "Retrieving Assemblies ...";
            statusProgress.Style = ProgressBarStyle.Marquee;
            this.AssemblySearcher.RunWorkerAsync();
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
            /*
             apply changes and save the project state
            CurrentProject.AssemblyName = this.AssemblyNameTbx.Text;
            CurrentProject.AssemblyType = this.AssemblyTypeCbx.SelectedItem.ToString();
            CurrentProject.BuildTarget = this.BuildTargetCbx.SelectedItem.ToString();
            CurrentProject.Icon = this.ProjectIconTbx.Text;
            CurrentProject.Refferences.Clear();
            foreach (ListViewItem item in RefferencesListView.Items )
            {
                if(item.Checked==true)
                {
                    this.CurrentProject.Refferences.Add(item.Tag.ToString());
                }
            }
            CurrentProject.Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
           */ 
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        
        #region Assembly searcher (BGworker)          
        private static bool IsNetAssembly(string path)
            {
                try {
                    AssemblyName testAssembly = AssemblyName.GetAssemblyName(path);
                    return true;
                }
                catch(Exception e)
                {
                    Exceptioner.Log(e); 
                }
                return false;
            }
        private static void GetAssemblies(string folder, ref List<string> ListAssembly)
            {
                try
                {
                    DirectoryInfo di = new DirectoryInfo(folder);
                    FileInfo[] files = di.GetFiles("*.dll", SearchOption.AllDirectories);
                    foreach (FileInfo fi in files)
                    {
                        if (IsNetAssembly(fi.FullName))
                        {
                            ListAssembly.Add(fi.FullName);
                        }
                    }
                }
                catch(Exception e)
                {
                    Exceptioner.Log(e); 
                }
            }
        private void SearchAssemblies(object sender, DoWorkEventArgs e)
        {
            GetAssemblies(@"C:\Windows\Microsoft.NET\Framework\", ref this.GlobalAssemblies);
            if (Environment.OSVersion.Platform <= PlatformID.Win32NT)
            {
                GetAssemblies(@"C:\Windows\assembly\", ref this.GlobalAssemblies);
            }
            else
            {
                GetAssemblies(@"C:\WINNT\assembly\", ref this.GlobalAssemblies);
            }            
        }
        private void SearchAssembliesCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //add global assembly to list
            foreach (string assemblypath in this.GlobalAssemblies)
            {
                this.AddAssemblyToList(assemblypath, "Gac",false);
            }
            //add custom assembly
            foreach (string assemblypath in this.ProjectAssemblies)
            {
                if ((assemblypath.Contains(@"C:\Windows\Microsoft.NET\Framework\")) ||
                    (assemblypath.Contains(@"C:\Windows\assembly\")) ||
                    (assemblypath.Contains(@"C:\WINNT\assembly\")))
                {
                    this.AddAssemblyToList(assemblypath, "Gac",true);
                }
                else
                {
                    this.AddAssemblyToList(assemblypath, "Custom",true);
                }
            }
            //for speed uptimasation
            this.RefferencesListView.Sort();
            StatusMsg.Text = "";
            statusProgress.Style = ProgressBarStyle.Blocks;
        }
       /// <summary>
       /// to add to the  dll listview ech item
       /// </summary>
       /// <param name="assemblypath"></param>
       /// <param name="assemblytype"></param>
       /// <param name="isfromproject">specify if we are adding from the projrct references to check</param>
        private void AddAssemblyToList(string assemblypath, string assemblytype, bool isfromproject)
        {
            string assemblyname = System.IO.Path.GetFileName(assemblypath);
            ListViewItem item = new ListViewItem(new string[] { assemblyname, assemblytype, assemblypath });
            item.Tag = assemblypath.ToString();
            item.Text=assemblyname;
            if (!isfromproject)
            {
                this.RefferencesListView.Items.Add(item);
            }
            else
            {
                //check if the item does'n already exist
                //if it does : we checked it as already referenced in the project
                ListViewItem foundItem = null;
                if (this.RefferencesListView.Items.Count != 0)
                    foundItem = this.RefferencesListView.FindItemWithText(item.Text, false, 0, false);

                if (foundItem != null)
                {
                    int index = this.RefferencesListView.Items.IndexOf(foundItem);
                    this.RefferencesListView.Items[index].Checked = true;
                }
                else
                {
                    item.Checked = true;
                    this.RefferencesListView.Items.Add(item);
                }  
            }

            
        }
        #endregion

        
        
           
    }
}
