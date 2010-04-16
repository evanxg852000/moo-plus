using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Moo
{
    public partial class BuildOutput : DockContent
    {
        public BuildOutput()
        {
            InitializeComponent();
        }
        public void SetOutputContent(string content)
        {
            this.Content.Text = content;
        }
        private void HideInstead(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    
    }
}
