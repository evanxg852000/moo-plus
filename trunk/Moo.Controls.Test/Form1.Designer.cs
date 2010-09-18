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
            this.button2 = new System.Windows.Forms.Button();
            this.searchterm = new System.Windows.Forms.TextBox();
            this.fileFounder1 = new Moo.Controls.FileFounder();
            this.fileBrowser1 = new Moo.Controls.FileBrowser();
            this.brunchBrowser1 = new Moo.Controls.BrunchBrowser();
            this.projectBrowser1 = new Moo.Controls.ProjectBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(273, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "serch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // searchterm
            // 
            this.searchterm.Location = new System.Drawing.Point(373, 123);
            this.searchterm.Name = "searchterm";
            this.searchterm.Size = new System.Drawing.Size(100, 20);
            this.searchterm.TabIndex = 5;
            // 
            // fileFounder1
            // 
            this.fileFounder1.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileFounder1.FullRowSelect = true;
            this.fileFounder1.GridLines = true;
            this.fileFounder1.IsRecurssive = false;
            this.fileFounder1.Location = new System.Drawing.Point(228, 256);
            this.fileFounder1.Name = "fileFounder1";
            this.fileFounder1.SearchFolder = "C:\\";
            this.fileFounder1.Size = new System.Drawing.Size(611, 97);
            this.fileFounder1.TabIndex = 6;
            this.fileFounder1.UseCompatibleStateImageBehavior = false;
            this.fileFounder1.View = System.Windows.Forms.View.Details;
            // 
            // fileBrowser1
            // 
            this.fileBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.fileBrowser1.ImageIndex = 0;
            this.fileBrowser1.Location = new System.Drawing.Point(520, 12);
            this.fileBrowser1.Name = "fileBrowser1";
            this.fileBrowser1.SelectedImageIndex = 0;
            this.fileBrowser1.ShowPlusMinus = false;
            this.fileBrowser1.Size = new System.Drawing.Size(232, 147);
            this.fileBrowser1.TabIndex = 3;
            this.fileBrowser1.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.fileBrowser1_ItemSelected);
            // 
            // brunchBrowser1
            // 
            this.brunchBrowser1.File = "C:\\Users\\Administrator\\Documents\\Visual Studio 2008\\Projects\\Moo\\Moo.Controls.Tes" +
                "t\\bin\\Debug\\brunchs\\BRUNCHES.xml";
            this.brunchBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.brunchBrowser1.ImageIndex = 0;
            this.brunchBrowser1.Location = new System.Drawing.Point(12, 194);
            this.brunchBrowser1.Name = "brunchBrowser1";
            this.brunchBrowser1.SelectedImageIndex = 0;
            this.brunchBrowser1.ShowPlusMinus = false;
            this.brunchBrowser1.ShowRootLines = false;
            this.brunchBrowser1.Size = new System.Drawing.Size(210, 159);
            this.brunchBrowser1.TabIndex = 2;
            this.brunchBrowser1.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.projectBrowser1_ItemSelected);
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
            this.projectBrowser1.Size = new System.Drawing.Size(210, 147);
            this.projectBrowser1.TabIndex = 0;
            this.projectBrowser1.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.projectBrowser1_ItemSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 365);
            this.Controls.Add(this.fileFounder1);
            this.Controls.Add(this.searchterm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fileBrowser1);
            this.Controls.Add(this.brunchBrowser1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.projectBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProjectBrowser projectBrowser1;
        private System.Windows.Forms.Button button1;
        private BrunchBrowser brunchBrowser1;
        private FileBrowser fileBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox searchterm;
        private FileFounder fileFounder1;






    }
}

