namespace Moo.Controls.Test
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.fileBrowser1 = new Moo.Controls.FileBrowser();
            this.brunchBrowser1 = new Moo.Controls.BrunchBrowser();
            this.projectBrowser1 = new Moo.Controls.ProjectBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileBrowser1
            // 
            this.fileBrowser1.ImageIndex = 0;
            this.fileBrowser1.Location = new System.Drawing.Point(364, 12);
            this.fileBrowser1.Name = "fileBrowser1";
            this.fileBrowser1.SelectedImageIndex = 0;
            this.fileBrowser1.ShowPlusMinus = false;
            this.fileBrowser1.Size = new System.Drawing.Size(402, 341);
            this.fileBrowser1.TabIndex = 3;
            // 
            // brunchBrowser1
            // 
            this.brunchBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.brunchBrowser1.ImageIndex = 0;
            this.brunchBrowser1.Location = new System.Drawing.Point(12, 194);
            this.brunchBrowser1.Name = "brunchBrowser1";
            this.brunchBrowser1.RootFolder = "brunchs";
            this.brunchBrowser1.SelectedImageIndex = 0;
            this.brunchBrowser1.ShowPlusMinus = false;
            this.brunchBrowser1.ShowRootLines = false;
            this.brunchBrowser1.Size = new System.Drawing.Size(320, 159);
            this.brunchBrowser1.TabIndex = 2;
            // 
            // projectBrowser1
            // 
            this.projectBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.projectBrowser1.HideSelection = false;
            this.projectBrowser1.ImageIndex = 0;
            this.projectBrowser1.Location = new System.Drawing.Point(12, 12);
            this.projectBrowser1.Name = "projectBrowser1";
            this.projectBrowser1.SelectedImageIndex = 0;
            this.projectBrowser1.ShowPlusMinus = false;
            this.projectBrowser1.ShowRootLines = false;
            this.projectBrowser1.Size = new System.Drawing.Size(320, 147);
            this.projectBrowser1.TabIndex = 0;
            this.projectBrowser1.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.projectBrowser1_ItemSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 365);
            this.Controls.Add(this.fileBrowser1);
            this.Controls.Add(this.brunchBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ProjectBrowser projectBrowser1;
        private System.Windows.Forms.Button button1;
        private BrunchBrowser brunchBrowser1;
        private FileBrowser fileBrowser1;






    }
}

