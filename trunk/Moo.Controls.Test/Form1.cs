using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void brunchBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            projectBrowser1.BuildNodes(@"C:\Users\Administrator\Desktop\projects\sample",
                "sample.mpr", 
                "sample");
            brunchBrowser1.BuildNodes();
            fileBrowser1.BuildNodes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectBrowser1.Refresh();
            fileBrowser1.Refresh();
        }

        private void projectBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);
        }

        
        
    }
}
