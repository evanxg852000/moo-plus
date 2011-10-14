namespace Moo
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.SHelp = new System.Windows.Forms.Button();
            this.SGotoWebsite = new System.Windows.Forms.Button();
            this.SOpenProject = new System.Windows.Forms.Button();
            this.SNewProject = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SHelp
            // 
            this.SHelp.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SHelp.Image = global::Moo.Properties.Resources.Help;
            this.SHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SHelp.Location = new System.Drawing.Point(22, 362);
            this.SHelp.Name = "SHelp";
            this.SHelp.Size = new System.Drawing.Size(189, 55);
            this.SHelp.TabIndex = 3;
            this.SHelp.Text = "Help";
            this.SHelp.UseVisualStyleBackColor = true;
            this.SHelp.Click += new System.EventHandler(this.GetHelpContent);
            // 
            // SGotoWebsite
            // 
            this.SGotoWebsite.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SGotoWebsite.Image = global::Moo.Properties.Resources.Database;
            this.SGotoWebsite.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SGotoWebsite.Location = new System.Drawing.Point(22, 293);
            this.SGotoWebsite.Name = "SGotoWebsite";
            this.SGotoWebsite.Size = new System.Drawing.Size(189, 55);
            this.SGotoWebsite.TabIndex = 4;
            this.SGotoWebsite.Text = "Database";
            this.SGotoWebsite.UseVisualStyleBackColor = true;
            this.SGotoWebsite.Click += new System.EventHandler(this.OpenDatabaseDesigner);
            // 
            // SOpenProject
            // 
            this.SOpenProject.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOpenProject.Image = global::Moo.Properties.Resources.Open;
            this.SOpenProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SOpenProject.Location = new System.Drawing.Point(22, 224);
            this.SOpenProject.Name = "SOpenProject";
            this.SOpenProject.Size = new System.Drawing.Size(189, 55);
            this.SOpenProject.TabIndex = 2;
            this.SOpenProject.Text = "Open";
            this.SOpenProject.UseVisualStyleBackColor = true;
            this.SOpenProject.Click += new System.EventHandler(this.RequestOpenProject);
            // 
            // SNewProject
            // 
            this.SNewProject.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SNewProject.Image = global::Moo.Properties.Resources.Project;
            this.SNewProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SNewProject.Location = new System.Drawing.Point(22, 155);
            this.SNewProject.Name = "SNewProject";
            this.SNewProject.Size = new System.Drawing.Size(189, 55);
            this.SNewProject.TabIndex = 1;
            this.SNewProject.Text = "New ";
            this.SNewProject.UseVisualStyleBackColor = true;
            this.SNewProject.Click += new System.EventHandler(this.RequestNewProject);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Moo.Properties.Resources.Startpage;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1170, 558);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 558);
            this.Controls.Add(this.SGotoWebsite);
            this.Controls.Add(this.SHelp);
            this.Controls.Add(this.SOpenProject);
            this.Controls.Add(this.SNewProject);
            this.Controls.Add(this.pictureBox1);
            this.DockAreas = Yalamo.Gui.Dock.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartPage";
            this.TabText = "Moo {+} Start Page";
            this.Text = "Moo {+} Start Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SNewProject;
        private System.Windows.Forms.Button SOpenProject;
        private System.Windows.Forms.Button SHelp;
        private System.Windows.Forms.Button SGotoWebsite;
    }
}