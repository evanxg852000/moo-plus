namespace Moo
{
    partial class FBrunchBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBrunchBrowser));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddBrunch = new System.Windows.Forms.ToolStripButton();
            this.RemoveBrunch = new System.Windows.Forms.ToolStripButton();
            this.RefreshBrunch = new System.Windows.Forms.ToolStripButton();
            this.BrunchBrowserTree = new Moo.Controls.BrunchBrowser();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackgroundImage = global::Moo.Properties.Resources.tbackground;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddBrunch,
            this.RemoveBrunch,
            this.RefreshBrunch});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(216, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // AddBrunch
            // 
            this.AddBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddBrunch.Image = global::Moo.Properties.Resources.brunch_add;
            this.AddBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddBrunch.Name = "AddBrunch";
            this.AddBrunch.Size = new System.Drawing.Size(23, 22);
            this.AddBrunch.Text = "Add Brunch";
            // 
            // RemoveBrunch
            // 
            this.RemoveBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RemoveBrunch.Image = global::Moo.Properties.Resources.brunch_rmv;
            this.RemoveBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RemoveBrunch.Name = "RemoveBrunch";
            this.RemoveBrunch.Size = new System.Drawing.Size(23, 22);
            this.RemoveBrunch.Text = "Remove Brunch";
            // 
            // RefreshBrunch
            // 
            this.RefreshBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshBrunch.Image = global::Moo.Properties.Resources.projet_brow_refresh;
            this.RefreshBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBrunch.Name = "RefreshBrunch";
            this.RefreshBrunch.Size = new System.Drawing.Size(23, 22);
            this.RefreshBrunch.Text = "Refresh View";
            // 
            // BrunchBrowserTree
            // 
            this.BrunchBrowserTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BrunchBrowserTree.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.BrunchBrowserTree.ImageIndex = 0;
            this.BrunchBrowserTree.Location = new System.Drawing.Point(0, 24);
            this.BrunchBrowserTree.Name = "BrunchBrowserTree";
            this.BrunchBrowserTree.RootFolder = "brunchs";
            this.BrunchBrowserTree.SelectedImageIndex = 0;
            this.BrunchBrowserTree.ShowPlusMinus = false;
            this.BrunchBrowserTree.ShowRootLines = false;
            this.BrunchBrowserTree.Size = new System.Drawing.Size(216, 240);
            this.BrunchBrowserTree.TabIndex = 1;
            // 
            // FBrunchBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 264);
            this.Controls.Add(this.BrunchBrowserTree);
            this.Controls.Add(this.ToolStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)(((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockLeft)
                        | WeifenLuo.WinFormsUI.Docking.DockAreas.DockRight)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FBrunchBrowser";
            this.TabText = "Brunch Browser";
            this.Text = "Brunch Browser";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton AddBrunch;
        private System.Windows.Forms.ToolStripButton RemoveBrunch;
        private System.Windows.Forms.ToolStripButton RefreshBrunch;
        private Moo.Controls.BrunchBrowser BrunchBrowserTree;
    }
}