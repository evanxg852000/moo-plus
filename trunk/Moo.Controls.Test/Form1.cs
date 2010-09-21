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
            projectBrowser1.BuildNodes(@"c:\\fakep\",
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

        private void fileBrowser1_ItemSelected(string itemTag)
        {
            MessageBox.Show(itemTag);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            fileFounder1.SearchTerm =searchterm.Text;
            fileFounder1.SearchFile();
        }

        private void fileFounder1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(brunchBrowser1.File);
            brunchBrowser1.Refresh();
           object o=(object) brunchBrowser1.Structure;
            DataSet S = brunchBrowser1.Structure;
        }

        
        
    }
}
