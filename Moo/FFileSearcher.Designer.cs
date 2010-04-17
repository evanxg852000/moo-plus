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
            this.FileFounderList = new Moo.Controls.FileFounder();
            this.TSearchFolder = new System.Windows.Forms.ToolStripButton();
            this.TRecursive = new System.Windows.Forms.ToolStripButton();
            this.SearchKey = new System.Windows.Forms.ToolStripTextBox();
            this.TSearch = new System.Windows.Forms.ToolStripButton();
            this.SearchProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.FileFounderList.ItemDoubleClicked += new Moo.Controls.ItemSelectedHandler(this.RequestOpenSelectedFile);
            this.FileFounderList.SearchProgressChanged += new Moo.Controls.DeamonProgressChanged(this.SearchProgressChanged);
            this.FileFounderList.SearchCompleted += new Moo.Controls.DeamonWorkcompleted(this.SearchCompleted);
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
            this.TSearchFolder.Click += new System.EventHandler(this.SetFolder);
            // 
            // TRecursive
            // 
            this.TRecursive.CheckOnClick = true;
            this.TRecursive.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TRecursive.Image = global::Moo.Properties.Resources.projet_brow_refresh;
            this.TRecursive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TRecursive.Name = "TRecursive";
            this.TRecursive.Size = new System.Drawing.Size(23, 22);
            this.TRecursive.Text = "Search in subfolder";
            this.TRecursive.Click += new System.EventHandler(this.RecursiveHandler);
            // 
            // SearchKey
            // 
            this.SearchKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SearchKey.Name = "SearchKey";
            this.SearchKey.Size = new System.Drawing.Size(200, 25);
            this.SearchKey.Text = "Search...";
            // 
            // TSearch
            // 
            this.TSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSearch.Image = global::Moo.Properties.Resources.zoom;
            this.TSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSearch.Name = "TSearch";
            this.TSearch.Size = new System.Drawing.Size(23, 22);
            this.TSearch.Text = "Search";
            this.TSearch.Click += new System.EventHandler(this.SearchFileHandler);
            // 
            // SearchProgress
            // 
            this.SearchProgress.Margin = new System.Windows.Forms.Padding(5, 2, 1, 1);
            this.SearchProgress.Name = "SearchProgress";
            this.SearchProgress.Size = new System.Drawing.Size(100, 22);
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackgroundImage = global::Moo.Properties.Resources.tbackground;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSearchFolder,
            this.TRecursive,
            this.SearchKey,
            this.TSearch,
            this.SearchProgress});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(804, 25);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.Text = "Tolstrip";
            // 
            // FFileSearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 175);
            this.Controls.Add(this.FileFounderList);
            this.Controls.Add(this.ToolStrip);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.DockBottom)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FFileSearcher";
            this.TabText = " Search File";
            this.Text = " Search File";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Moo.Controls.FileFounder FileFounderList;
        private System.Windows.Forms.ToolStripButton TSearchFolder;
        private System.Windows.Forms.ToolStripButton TRecursive;
        private System.Windows.Forms.ToolStripTextBox SearchKey;
        private System.Windows.Forms.ToolStripButton TSearch;
        private System.Windows.Forms.ToolStripProgressBar SearchProgress;
        private System.Windows.Forms.ToolStrip ToolStrip;
    }
}