using System;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;

namespace {projectname}
{
    public partial class MainWindow : Form
    {
		
		
		/// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
		
        public MainWindow ()
        {
            InitializeComponent();
        }
		
		#region Designer
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);

            
			this.ResumeLayout(false);
            this.PerformLayout();

        }
		#endregion


    }
}
