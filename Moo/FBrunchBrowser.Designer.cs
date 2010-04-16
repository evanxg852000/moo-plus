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
            this.BrunchBrowserTree = new Moo.Controls.BrunchBrowser();
            this.BrunchBCtxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBrunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newBrunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertSelectedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expandAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collapseAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.AddBrunch = new System.Windows.Forms.ToolStripButton();
            this.RemoveBrunch = new System.Windows.Forms.ToolStripButton();
            this.RefreshBrunch = new System.Windows.Forms.ToolStripButton();
            this.BrunchBCtxtMenu.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // BrunchBrowserTree
            // 
            this.BrunchBrowserTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BrunchBrowserTree.ContextMenuStrip = this.BrunchBCtxtMenu;
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
            // BrunchBCtxtMenu
            // 
            this.BrunchBCtxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createFolderToolStripMenuItem,
            this.createBrunchToolStripMenuItem,
            this.toolStripSeparator1,
            this.refreshToolStripMenuItem,
            this.expandAllToolStripMenuItem,
            this.collapseAllToolStripMenuItem});
            this.BrunchBCtxtMenu.Name = "BrunchBCtxtMenu";
            this.BrunchBCtxtMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.BrunchBCtxtMenu.Size = new System.Drawing.Size(137, 120);
            // 
            // createFolderToolStripMenuItem
            // 
            this.createFolderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFolderToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.createFolderToolStripMenuItem.Image = global::Moo.Properties.Resources.folder;
            this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
            this.createFolderToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.createFolderToolStripMenuItem.Text = "Folder";
            // 
            // newFolderToolStripMenuItem
            // 
            this.newFolderToolStripMenuItem.Name = "newFolderToolStripMenuItem";
            this.newFolderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newFolderToolStripMenuItem.Text = "New ";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // createBrunchToolStripMenuItem
            // 
            this.createBrunchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBrunchToolStripMenuItem,
            this.deleteSelectedToolStripMenuItem,
            this.insertSelectedToolStripMenuItem1});
            this.createBrunchToolStripMenuItem.Image = global::Moo.Properties.Resources.file;
            this.createBrunchToolStripMenuItem.Name = "createBrunchToolStripMenuItem";
            this.createBrunchToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.createBrunchToolStripMenuItem.Text = "Brunch";
            // 
            // newBrunchToolStripMenuItem
            // 
            this.newBrunchToolStripMenuItem.Name = "newBrunchToolStripMenuItem";
            this.newBrunchToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.newBrunchToolStripMenuItem.Text = "New ";
            // 
            // deleteSelectedToolStripMenuItem
            // 
            this.deleteSelectedToolStripMenuItem.Image = global::Moo.Properties.Resources.brunch_rmv;
            this.deleteSelectedToolStripMenuItem.Name = "deleteSelectedToolStripMenuItem";
            this.deleteSelectedToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.deleteSelectedToolStripMenuItem.Text = "Delete ";
            // 
            // insertSelectedToolStripMenuItem1
            // 
            this.insertSelectedToolStripMenuItem1.Image = global::Moo.Properties.Resources.brunch_add;
            this.insertSelectedToolStripMenuItem1.Name = "insertSelectedToolStripMenuItem1";
            this.insertSelectedToolStripMenuItem1.Size = new System.Drawing.Size(110, 22);
            this.insertSelectedToolStripMenuItem1.Text = "Insert";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::Moo.Properties.Resources.projet_brow_refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            // 
            // expandAllToolStripMenuItem
            // 
            this.expandAllToolStripMenuItem.Name = "expandAllToolStripMenuItem";
            this.expandAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.expandAllToolStripMenuItem.Text = "Expand All";
            // 
            // collapseAllToolStripMenuItem
            // 
            this.collapseAllToolStripMenuItem.Name = "collapseAllToolStripMenuItem";
            this.collapseAllToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.collapseAllToolStripMenuItem.Text = "Collapse All";
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideInstead);
            this.BrunchBCtxtMenu.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip BrunchBCtxtMenu;
        private System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createBrunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expandAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collapseAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBrunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertSelectedToolStripMenuItem1;
    }
}