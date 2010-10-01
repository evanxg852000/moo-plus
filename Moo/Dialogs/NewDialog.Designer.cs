namespace Moo.Dialogs
{
    partial class NewDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDialog));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Desktop"}, 2, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Web "}, 3, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Database"}, 4, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ajax"}, 5, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "File"}, 6, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Unmanaged"}, 7, System.Drawing.SystemColors.WindowFrame, System.Drawing.Color.Empty, new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.CreateBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.TypeCbx = new System.Windows.Forms.ComboBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.FolderTbx = new System.Windows.Forms.TextBox();
            this.BrowseBt = new System.Windows.Forms.Button();
            this.NewCategory = new System.Windows.Forms.ListView();
            this.IncTemplate = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.statusbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(0, 49);
            this.Logo.Size = new System.Drawing.Size(600, 1);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "pro.png");
            this.ImgList.Images.SetKeyName(1, "script.png");
            this.ImgList.Images.SetKeyName(2, "Prodesktop.png");
            this.ImgList.Images.SetKeyName(3, "Proweb.png");
            this.ImgList.Images.SetKeyName(4, "Prodbdesign.png");
            this.ImgList.Images.SetKeyName(5, "Proadobe.png");
            this.ImgList.Images.SetKeyName(6, "Profile.png");
            this.ImgList.Images.SetKeyName(7, "Protodo.png");
            // 
            // CreateBt
            // 
            this.CreateBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CreateBt.Image = global::Moo.Properties.Resources.Fnew;
            this.CreateBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBt.Location = new System.Drawing.Point(425, 281);
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(75, 27);
            this.CreateBt.TabIndex = 4;
            this.CreateBt.Text = "Create";
            this.CreateBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBt.UseVisualStyleBackColor = true;
            this.CreateBt.Click += new System.EventHandler(this.CreateBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelBt.Image = global::Moo.Properties.Resources.Stop;
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(506, 281);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 27);
            this.CancelBt.TabIndex = 5;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // TypeCbx
            // 
            this.TypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCbx.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCbx.FormattingEnabled = true;
            this.TypeCbx.Location = new System.Drawing.Point(308, 82);
            this.TypeCbx.Name = "TypeCbx";
            this.TypeCbx.Size = new System.Drawing.Size(273, 26);
            this.TypeCbx.TabIndex = 1;
            // 
            // NameTbx
            // 
            this.NameTbx.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTbx.Location = new System.Drawing.Point(309, 130);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(273, 23);
            this.NameTbx.TabIndex = 2;
            // 
            // FolderTbx
            // 
            this.FolderTbx.Enabled = false;
            this.FolderTbx.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderTbx.Location = new System.Drawing.Point(308, 180);
            this.FolderTbx.Name = "FolderTbx";
            this.FolderTbx.Size = new System.Drawing.Size(243, 23);
            this.FolderTbx.TabIndex = 6;
            // 
            // BrowseBt
            // 
            this.BrowseBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBt.Location = new System.Drawing.Point(553, 180);
            this.BrowseBt.Name = "BrowseBt";
            this.BrowseBt.Size = new System.Drawing.Size(28, 23);
            this.BrowseBt.TabIndex = 3;
            this.BrowseBt.Text = "...";
            this.BrowseBt.UseVisualStyleBackColor = true;
            this.BrowseBt.Click += new System.EventHandler(this.BrowseBt_Click);
            // 
            // NewCategory
            // 
            this.NewCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            listViewItem1.Tag = "DESKTOP";
            listViewItem1.ToolTipText = "Create a desktop project";
            listViewItem2.Tag = "WEB";
            listViewItem2.ToolTipText = "Create a web project";
            listViewItem3.Tag = "DATABASE";
            listViewItem3.ToolTipText = "Create a databse project";
            listViewItem4.Tag = "AJAX";
            listViewItem4.ToolTipText = "Create an Ajax project";
            listViewItem5.Tag = "FILE";
            listViewItem5.ToolTipText = "Create a new file";
            listViewItem6.Tag = "UNMANAGED";
            listViewItem6.ToolTipText = "Create an unmanaged project";
            this.NewCategory.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.NewCategory.LargeImageList = this.ImgList;
            this.NewCategory.Location = new System.Drawing.Point(1, 51);
            this.NewCategory.MultiSelect = false;
            this.NewCategory.Name = "NewCategory";
            this.NewCategory.Scrollable = false;
            this.NewCategory.ShowItemToolTips = true;
            this.NewCategory.Size = new System.Drawing.Size(192, 262);
            this.NewCategory.SmallImageList = this.ImgList;
            this.NewCategory.TabIndex = 7;
            this.NewCategory.UseCompatibleStateImageBehavior = false;
            this.NewCategory.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.ProjectCategoryChangeHandler);
            // 
            // IncTemplate
            // 
            this.IncTemplate.AutoSize = true;
            this.IncTemplate.Checked = true;
            this.IncTemplate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncTemplate.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IncTemplate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IncTemplate.Location = new System.Drawing.Point(424, 230);
            this.IncTemplate.Name = "IncTemplate";
            this.IncTemplate.Size = new System.Drawing.Size(158, 22);
            this.IncTemplate.TabIndex = 8;
            this.IncTemplate.Text = "Use default template ?";
            this.IncTemplate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Location :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type :";
            // 
            // statusbar
            // 
            this.statusbar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMsg});
            this.statusbar.Location = new System.Drawing.Point(0, 314);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(589, 22);
            this.statusbar.SizingGrip = false;
            this.statusbar.TabIndex = 12;
            this.statusbar.Text = "statusStrip1";
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // NewDialog
            // 
            this.AcceptButton = this.CreateBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBt;
            this.ClientSize = new System.Drawing.Size(589, 336);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IncTemplate);
            this.Controls.Add(this.NewCategory);
            this.Controls.Add(this.TypeCbx);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.BrowseBt);
            this.Controls.Add(this.FolderTbx);
            this.Controls.Add(this.NameTbx);
            this.Controls.Add(this.CreateBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New ";
            this.TopMargin = 50;
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.CreateBt, 0);
            this.Controls.SetChildIndex(this.NameTbx, 0);
            this.Controls.SetChildIndex(this.FolderTbx, 0);
            this.Controls.SetChildIndex(this.BrowseBt, 0);
            this.Controls.SetChildIndex(this.CancelBt, 0);
            this.Controls.SetChildIndex(this.TypeCbx, 0);
            this.Controls.SetChildIndex(this.NewCategory, 0);
            this.Controls.SetChildIndex(this.IncTemplate, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.statusbar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.statusbar.ResumeLayout(false);
            this.statusbar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList ImgList;
        private System.Windows.Forms.Button CreateBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.ComboBox TypeCbx;
        private System.Windows.Forms.TextBox NameTbx;
        private System.Windows.Forms.TextBox FolderTbx;
        private System.Windows.Forms.Button BrowseBt;
        private System.Windows.Forms.ListView NewCategory;
        private System.Windows.Forms.CheckBox IncTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusbar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
    }
}