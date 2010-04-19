using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Moo.Helpers;

namespace Moo.Dialogs
{
    public partial class NewBrunchDialog : Form
    {
        public NewBrunchDialog()
        {
            InitializeComponent();
            initialisefield();   
        }
        public static new void Show()
        {
            NewBrunchDialog Instance = new NewBrunchDialog();
            Instance.ShowDialog();
        }

        private void initialisefield()
        {
            this.NameTxt.Text = "Brunch name...";
            this.BruchTypeCbx.SelectedIndex = 0;
            this.BrunchTxt.Text = "Brunch content here...";
            this.StatusMsg.Text = "";
        }
        private void NewClear(object sender, EventArgs e)
        {
            initialisefield();
        }
        private void SaveBrunchHandler(object sender, EventArgs e)
        {
            string bname=this.NameTxt.Text;
            string btype = this.BruchTypeCbx.SelectedItem.ToString();
            string bcontent=this.BrunchTxt.Text;

            if (( bname== "Brunch name..."))
            {
                this.StatusMsg.Text = "Brunch name is required";
                return;
            }
            if ((this.BruchTypeCbx.SelectedIndex ==0))
            {
                this.StatusMsg.Text = "Brunch Type is required";
                return;
            }
            if ((bcontent == "Brunch content here..."))
            {
                this.StatusMsg.Text = "Brunch content is required";
                return;
            }   
            string filepath=Path.GetDirectoryName(Application.ExecutablePath);
            filepath += Moo.Core.AppSettings.GetFolder("brunchs")+btype + @"\" + bname + ".mcb";
            FileHelper.Save(filepath, bcontent);
            this.Close();
        }

       

       
      
       
        
    }
}
