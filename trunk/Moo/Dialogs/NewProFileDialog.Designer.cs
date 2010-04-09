namespace Moo.Dialogs
{
    partial class NewProFileDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewProFileDialog));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Project"}, 0, System.Drawing.Color.Empty, System.Drawing.SystemColors.Window, new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "File"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.NewTypeList = new System.Windows.Forms.ListView();
            this.CreateBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.TypeCbx = new System.Windows.Forms.ComboBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.FolderTbx = new System.Windows.Forms.TextBox();
            this.BrowseBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "pro.png");
            this.ImgList.Images.SetKeyName(1, "script.png");
            // 
            // NewTypeList
            // 
            this.NewTypeList.Dock = System.Windows.Forms.DockStyle.Left;
            listViewItem1.StateImageIndex = 0;
            listViewItem1.Tag = "Project";
            listViewItem1.ToolTipText = "Create Project";
            listViewItem2.Tag = "Source";
            listViewItem2.ToolTipText = "Create fource file";
            this.NewTypeList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.NewTypeList.LabelWrap = false;
            this.NewTypeList.LargeImageList = this.ImgList;
            this.NewTypeList.Location = new System.Drawing.Point(0, 0);
            this.NewTypeList.MultiSelect = false;
            this.NewTypeList.Name = "NewTypeList";
            this.NewTypeList.Scrollable = false;
            this.NewTypeList.ShowItemToolTips = true;
            this.NewTypeList.Size = new System.Drawing.Size(150, 204);
            this.NewTypeList.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.NewTypeList.TabIndex = 0;
            this.NewTypeList.UseCompatibleStateImageBehavior = false;
            // 
            // CreateBt
            // 
            this.CreateBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBt.Location = new System.Drawing.Point(241, 166);
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(75, 23);
            this.CreateBt.TabIndex = 4;
            this.CreateBt.Text = "Create";
            this.CreateBt.UseVisualStyleBackColor = true;
            // 
            // CancelBt
            // 
            this.CancelBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBt.Location = new System.Drawing.Point(322, 166);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 23);
            this.CancelBt.TabIndex = 5;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.UseVisualStyleBackColor = true;
            // 
            // TypeCbx
            // 
            this.TypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCbx.FormattingEnabled = true;
            this.TypeCbx.Items.AddRange(new object[] {
            "Project / File Type"});
            this.TypeCbx.Location = new System.Drawing.Point(174, 20);
            this.TypeCbx.Name = "TypeCbx";
            this.TypeCbx.Size = new System.Drawing.Size(223, 22);
            this.TypeCbx.TabIndex = 1;
            // 
            // NameTbx
            // 
            this.NameTbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTbx.Location = new System.Drawing.Point(174, 69);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(223, 22);
            this.NameTbx.TabIndex = 2;
            this.NameTbx.Text = "< Project / File Name >";
            // 
            // FolderTbx
            // 
            this.FolderTbx.Enabled = false;
            this.FolderTbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderTbx.Location = new System.Drawing.Point(174, 117);
            this.FolderTbx.Name = "FolderTbx";
            this.FolderTbx.Size = new System.Drawing.Size(192, 22);
            this.FolderTbx.TabIndex = 6;
            this.FolderTbx.Text = "< Project / File Folder >";
            // 
            // BrowseBt
            // 
            this.BrowseBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBt.Location = new System.Drawing.Point(369, 115);
            this.BrowseBt.Name = "BrowseBt";
            this.BrowseBt.Size = new System.Drawing.Size(28, 23);
            this.BrowseBt.TabIndex = 3;
            this.BrowseBt.Text = "...";
            this.BrowseBt.UseVisualStyleBackColor = true;
            // 
            // NewProFileDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 204);
            this.Controls.Add(this.BrowseBt);
            this.Controls.Add(this.FolderTbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.TypeCbx);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.CreateBt);
            this.Controls.Add(this.NewTypeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewProFileDialog";
            this.ShowInTaskbar = false;
            this.Text = "New Project / File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.ListView NewTypeList;
        private System.Windows.Forms.Button CreateBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.ComboBox TypeCbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.TextBox FolderTbx;
        private System.Windows.Forms.Button BrowseBt;
    }
}