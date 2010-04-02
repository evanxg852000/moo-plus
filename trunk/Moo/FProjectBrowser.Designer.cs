namespace Moo
{
    partial class FProjectBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProjectBrowser));
            this.projectBrowser1 = new Moo.Controls.ProjectBrowser();
            this.BrowserTool = new System.Windows.Forms.ToolStrip();
            this.TNewProject = new System.Windows.Forms.ToolStripButton();
            this.TopenProject = new System.Windows.Forms.ToolStripButton();
            this.TRefresh = new System.Windows.Forms.ToolStripButton();
            this.BrowserTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // projectBrowser1
            // 
            this.projectBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.projectBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.projectBrowser1.ImageIndex = 0;
            this.projectBrowser1.Location = new System.Drawing.Point(1, 25);
            this.projectBrowser1.Name = "projectBrowser1";
            this.projectBrowser1.SelectedImageIndex = 0;
            this.projectBrowser1.ShowPlusMinus = false;
            this.projectBrowser1.ShowRootLines = false;
            this.projectBrowser1.Size = new System.Drawing.Size(206, 240);
            this.projectBrowser1.TabIndex = 0;
            // 
            // BrowserTool
            // 
            this.BrowserTool.BackgroundImage = global::Moo.Properties.Resources.tbackground;
            this.BrowserTool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TNewProject,
            this.TopenProject,
            this.TRefresh});
            this.BrowserTool.Location = new System.Drawing.Point(0, 0);
            this.BrowserTool.Name = "BrowserTool";
            this.BrowserTool.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BrowserTool.Size = new System.Drawing.Size(206, 25);
            this.BrowserTool.TabIndex = 1;
            this.BrowserTool.Text = "toolStrip1";
            // 
            // TNewProject
            // 
            this.TNewProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TNewProject.Image = global::Moo.Properties.Resources.project;
            this.TNewProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TNewProject.Name = "TNewProject";
            this.TNewProject.Size = new System.Drawing.Size(23, 22);
            this.TNewProject.Text = "New Project";
            // 
            // TopenProject
            // 
            this.TopenProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TopenProject.Image = global::Moo.Properties.Resources.folder;
            this.TopenProject.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TopenProject.Name = "TopenProject";
            this.TopenProject.Size = new System.Drawing.Size(23, 22);
            this.TopenProject.Text = "Open Project";
            // 
            // TRefresh
            // 
            this.TRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TRefresh.Image = global::Moo.Properties.Resources.projet_brow_refresh;
            this.TRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TRefresh.Name = "TRefresh";
            this.TRefresh.Size = new System.Drawing.Size(23, 22);
            this.TRefresh.Text = "Refresh";
            // 
            // FProjectBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 264);
            this.Controls.Add(this.projectBrowser1);
            this.Controls.Add(this.BrowserTool);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FProjectBrowser";
            this.TabText = "Project ";
            this.Text = "Project ";
            this.BrowserTool.ResumeLayout(false);
            this.BrowserTool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Moo.Controls.ProjectBrowser projectBrowser1;
        private System.Windows.Forms.ToolStrip BrowserTool;
        private System.Windows.Forms.ToolStripButton TNewProject;
        private System.Windows.Forms.ToolStripButton TopenProject;
        private System.Windows.Forms.ToolStripButton TRefresh;
    }
}