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
            this.ImgList = new System.Windows.Forms.ImageList(this.components);
            this.CreateBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.TypeCbx = new System.Windows.Forms.ComboBox();
            this.NameTbx = new System.Windows.Forms.TextBox();
            this.FolderTbx = new System.Windows.Forms.TextBox();
            this.BrowseBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Size = new System.Drawing.Size(600, 50);
            // 
            // ImgList
            // 
            this.ImgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList.ImageStream")));
            this.ImgList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList.Images.SetKeyName(0, "pro.png");
            this.ImgList.Images.SetKeyName(1, "script.png");
            // 
            // CreateBt
            // 
            this.CreateBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBt.Image = global::Moo.Properties.Resources.Fnew;
            this.CreateBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreateBt.Location = new System.Drawing.Point(419, 328);
            this.CreateBt.Name = "CreateBt";
            this.CreateBt.Size = new System.Drawing.Size(75, 25);
            this.CreateBt.TabIndex = 4;
            this.CreateBt.Text = "Create";
            this.CreateBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CreateBt.UseVisualStyleBackColor = true;
            this.CreateBt.Click += new System.EventHandler(this.CreateBt_Click);
            // 
            // CancelBt
            // 
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBt.Image = global::Moo.Properties.Resources.Stop;
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(511, 328);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 25);
            this.CancelBt.TabIndex = 5;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelBt_Click);
            // 
            // TypeCbx
            // 
            this.TypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeCbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeCbx.FormattingEnabled = true;
            this.TypeCbx.Items.AddRange(new object[] {
            "Select type"});
            this.TypeCbx.Location = new System.Drawing.Point(132, 66);
            this.TypeCbx.Name = "TypeCbx";
            this.TypeCbx.Size = new System.Drawing.Size(253, 22);
            this.TypeCbx.TabIndex = 1;
            // 
            // NameTbx
            // 
            this.NameTbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTbx.Location = new System.Drawing.Point(132, 110);
            this.NameTbx.Name = "NameTbx";
            this.NameTbx.Size = new System.Drawing.Size(253, 22);
            this.NameTbx.TabIndex = 2;
            this.NameTbx.Text = "< Project / File Name >";
            // 
            // FolderTbx
            // 
            this.FolderTbx.Enabled = false;
            this.FolderTbx.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FolderTbx.Location = new System.Drawing.Point(132, 154);
            this.FolderTbx.Name = "FolderTbx";
            this.FolderTbx.Size = new System.Drawing.Size(223, 22);
            this.FolderTbx.TabIndex = 6;
            this.FolderTbx.Text = "< Project / File Folder >";
            // 
            // BrowseBt
            // 
            this.BrowseBt.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowseBt.Location = new System.Drawing.Point(357, 154);
            this.BrowseBt.Name = "BrowseBt";
            this.BrowseBt.Size = new System.Drawing.Size(28, 23);
            this.BrowseBt.TabIndex = 3;
            this.BrowseBt.Text = "...";
            this.BrowseBt.UseVisualStyleBackColor = true;
            this.BrowseBt.Click += new System.EventHandler(this.BrowseBt_Click);
            // 
            // NewProFileDialog
            // 
            this.AcceptButton = this.CreateBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelBt;
            this.ClientSize = new System.Drawing.Size(597, 362);
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
            this.Name = "NewProFileDialog";
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
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
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
    }
}