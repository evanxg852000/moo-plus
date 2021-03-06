﻿namespace Moo
{
    partial class FFileSystBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFileSystBrowser));
            this.FileBrowserTree = new Moo.Controls.FileBrowser();
            this.ToolTtrip = new System.Windows.Forms.ToolStrip();
            this.TRefresh = new System.Windows.Forms.ToolStripButton();
            this.ToolTtrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileBrowserTree
            // 
            this.FileBrowserTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FileBrowserTree.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.FileBrowserTree.ImageIndex = 0;
            this.FileBrowserTree.Location = new System.Drawing.Point(0, 24);
            this.FileBrowserTree.Name = "FileBrowserTree";
            this.FileBrowserTree.SelectedImageIndex = 0;
            this.FileBrowserTree.Size = new System.Drawing.Size(197, 240);
            this.FileBrowserTree.TabIndex = 0;
            this.FileBrowserTree.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.RequestOpenSelectedFile);
            // 
            // ToolTtrip
            // 
            this.ToolTtrip.BackgroundImage = global::Moo.Properties.Resources.Tbackground;
            this.ToolTtrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TRefresh});
            this.ToolTtrip.Location = new System.Drawing.Point(0, 0);
            this.ToolTtrip.Name = "ToolTtrip";
            this.ToolTtrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolTtrip.Size = new System.Drawing.Size(197, 25);
            this.ToolTtrip.TabIndex = 1;
            this.ToolTtrip.Text = "toolStrip1";
            // 
            // TRefresh
            // 
            this.TRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TRefresh.Image = global::Moo.Properties.Resources.Refresh;
            this.TRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TRefresh.Name = "TRefresh";
            this.TRefresh.Size = new System.Drawing.Size(23, 22);
            this.TRefresh.Text = "Refresh View";
            this.TRefresh.Click += new System.EventHandler(this.RefreshViev);
            // 
            // FFileSystBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 264);
            this.Controls.Add(this.ToolTtrip);
            this.Controls.Add(this.FileBrowserTree);
            this.DockAreas = ((Yalamo.Gui.Dock.DockAreas)(((Yalamo.Gui.Dock.DockAreas.Float | Yalamo.Gui.Dock.DockAreas.DockLeft)
                        | Yalamo.Gui.Dock.DockAreas.DockRight)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFileSystBrowser";
            this.TabText = "File System";
            this.Text = "File System";
            this.ToolTtrip.ResumeLayout(false);
            this.ToolTtrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Moo.Controls.FileBrowser FileBrowserTree;
        private System.Windows.Forms.ToolStrip ToolTtrip;
        private System.Windows.Forms.ToolStripButton TRefresh;
    }
}