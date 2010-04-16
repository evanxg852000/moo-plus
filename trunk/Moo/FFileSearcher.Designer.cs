namespace Moo
{
    partial class FFileSearcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFileSearcher));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.TSearchFolder = new System.Windows.Forms.ToolStripButton();
            this.SearchKey = new System.Windows.Forms.ToolStripTextBox();
            this.TSearch = new System.Windows.Forms.ToolStripButton();
            this.TRefresh = new System.Windows.Forms.ToolStripButton();
            this.FileFounderList = new Moo.Controls.FileFounder();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackgroundImage = global::Moo.Properties.Resources.tbackground;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSearchFolder,
            this.SearchKey,
            this.TSearch,
            this.TRefresh});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(804, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "Tolstrip";
            // 
            // TSearchFolder
            // 
            this.TSearchFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSearchFolder.Image = global::Moo.Properties.Resources.folder;
            this.TSearchFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSearchFolder.Name = "TSearchFolder";
            this.TSearchFolder.Size = new System.Drawing.Size(23, 22);
            this.TSearchFolder.Text = "Search Folder";
            this.TSearchFolder.ToolTipText = "Specify Search Folder";
            // 
            // SearchKey
            // 
            this.SearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(200, 25);
            this.SearchKey.Text = "search ...";
            // 
            // TSearch
            // 
            this.TSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSearch.Image = global::Moo.Properties.Resources.zoom;
            this.TSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(23, 22);
            this.TSearch.Text = "Search";
            // 
            // TRefresh
            // 
            this.TRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TRefresh.Image = global::Moo.Properties.Resources.projet_brow_refresh;
            this.TRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TRefresh.Name = "TRefresh";
            this.TRefresh.Size = new System.Drawing.Size(23, 22);
            this.TRefresh.Text = "Refresh View";
            // 
            // FileFounderList
            // 
            this.FileFounderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FileFounderList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileFounderList.FullRowSelect = true;
            this.FileFounderList.GridLines = true;
            this.FileFounderList.IsRecurssive = false;
            this.FileFounderList.Location = new System.Drawing.Point(0, 28);
            this.FileFounderList.Name = "FileFounderList";
            this.FileFounderList.SearchFolder = "C:\\";
            this.FileFounderList.Size = new System.Drawing.Size(804, 146);
            this.FileFounderList.TabIndex = 1;
            this.FileFounderList.UseCompatibleStateImageBehavior = false;
            this.FileFounderList.View = System.Windows.Forms.View.Details;
            // 
            // FFileSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 175);
            this.Controls.Add(this.FileFounderList);
            this.Controls.Add(this.ToolStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFileSearcher";
            this.TabText = " Search File";
            this.Text = " Search File";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HideInstead);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private Moo.Controls.FileFounder FileFounderList;
        private System.Windows.Forms.ToolStripButton TSearchFolder;
        private System.Windows.Forms.ToolStripTextBox SearchKey;
        private System.Windows.Forms.ToolStripButton TSearch;
        private System.Windows.Forms.ToolStripButton TRefresh;
    }
}