namespace Moo.Dialogs
{
    partial class ProjectConfigDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectConfigDialog));
            this.AssemblyNameTbx = new System.Windows.Forms.TextBox();
            this.RefferencesListView = new System.Windows.Forms.ListView();
            this.RefName = new System.Windows.Forms.ColumnHeader();
            this.Path = new System.Windows.Forms.ColumnHeader();
            this.ProjectIconTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BrowseIconBt = new System.Windows.Forms.Button();
            this.BuildTargetCbx = new System.Windows.Forms.ComboBox();
            this.SaveBt = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.ProjectCreateDateTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AssemblyTypeCbx = new System.Windows.Forms.ComboBox();
            this.RemoveRefBt = new System.Windows.Forms.Button();
            this.AddRefBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AssemblyNameTbx
            // 
            this.AssemblyNameTbx.Location = new System.Drawing.Point(124, 7);
            this.AssemblyNameTbx.Name = "AssemblyNameTbx";
            this.AssemblyNameTbx.Size = new System.Drawing.Size(216, 22);
            this.AssemblyNameTbx.TabIndex = 0;
            // 
            // RefferencesListView
            // 
            this.RefferencesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefName,
            this.Path});
            this.RefferencesListView.FullRowSelect = true;
            this.RefferencesListView.GridLines = true;
            this.RefferencesListView.Location = new System.Drawing.Point(7, 150);
            this.RefferencesListView.MultiSelect = false;
            this.RefferencesListView.Name = "RefferencesListView";
            this.RefferencesListView.ShowItemToolTips = true;
            this.RefferencesListView.Size = new System.Drawing.Size(300, 117);
            this.RefferencesListView.TabIndex = 2;
            this.RefferencesListView.UseCompatibleStateImageBehavior = false;
            this.RefferencesListView.View = System.Windows.Forms.View.Details;
            // 
            // RefName
            // 
            this.RefName.Text = "Refferences";
            this.RefName.Width = 106;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 190;
            // 
            // ProjectIconTbx
            // 
            this.ProjectIconTbx.Location = new System.Drawing.Point(124, 94);
            this.ProjectIconTbx.Name = "ProjectIconTbx";
            this.ProjectIconTbx.Size = new System.Drawing.Size(185, 22);
            this.ProjectIconTbx.TabIndex = 3;
            this.ProjectIconTbx.Text = "moo.ico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assembly Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Build Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Application Icon";
            // 
            // BrowseIconBt
            // 
            this.BrowseIconBt.Location = new System.Drawing.Point(313, 93);
            this.BrowseIconBt.Name = "BrowseIconBt";
            this.BrowseIconBt.Size = new System.Drawing.Size(27, 23);
            this.BrowseIconBt.TabIndex = 10;
            this.BrowseIconBt.Text = "...";
            this.BrowseIconBt.UseVisualStyleBackColor = true;
            this.BrowseIconBt.Click += new System.EventHandler(this.SetAppIcon);
            // 
            // BuildTargetCbx
            // 
            this.BuildTargetCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BuildTargetCbx.FormattingEnabled = true;
            this.BuildTargetCbx.Items.AddRange(new object[] {
            "Debug",
            "Release"});
            this.BuildTargetCbx.Location = new System.Drawing.Point(124, 66);
            this.BuildTargetCbx.Name = "BuildTargetCbx";
            this.BuildTargetCbx.Size = new System.Drawing.Size(216, 22);
            this.BuildTargetCbx.TabIndex = 11;
            // 
            // SaveBt
            // 
            this.SaveBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBt.Location = new System.Drawing.Point(335, 215);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 23);
            this.SaveBt.TabIndex = 13;
            this.SaveBt.Text = "Save";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(335, 244);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ProjectCreateDateTbx
            // 
            this.ProjectCreateDateTbx.Enabled = false;
            this.ProjectCreateDateTbx.Location = new System.Drawing.Point(124, 121);
            this.ProjectCreateDateTbx.Name = "ProjectCreateDateTbx";
            this.ProjectCreateDateTbx.Size = new System.Drawing.Size(216, 22);
            this.ProjectCreateDateTbx.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Created";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 14);
            this.label5.TabIndex = 6;
            this.label5.Text = "Assembly Type";
            // 
            // AssemblyTypeCbx
            // 
            this.AssemblyTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AssemblyTypeCbx.FormattingEnabled = true;
            this.AssemblyTypeCbx.Items.AddRange(new object[] {
            "Executable (.exe)",
            "Dynamic Library (.dll)"});
            this.AssemblyTypeCbx.Location = new System.Drawing.Point(124, 35);
            this.AssemblyTypeCbx.Name = "AssemblyTypeCbx";
            this.AssemblyTypeCbx.Size = new System.Drawing.Size(216, 22);
            this.AssemblyTypeCbx.TabIndex = 11;
            // 
            // RemoveRefBt
            // 
            this.RemoveRefBt.Image = global::Moo.Properties.Resources.delete;
            this.RemoveRefBt.Location = new System.Drawing.Point(313, 179);
            this.RemoveRefBt.Name = "RemoveRefBt";
            this.RemoveRefBt.Size = new System.Drawing.Size(27, 23);
            this.RemoveRefBt.TabIndex = 5;
            this.RemoveRefBt.UseVisualStyleBackColor = true;
            this.RemoveRefBt.Click += new System.EventHandler(this.RemoveRefference);
            // 
            // AddRefBt
            // 
            this.AddRefBt.Image = global::Moo.Properties.Resources.add;
            this.AddRefBt.Location = new System.Drawing.Point(313, 150);
            this.AddRefBt.Name = "AddRefBt";
            this.AddRefBt.Size = new System.Drawing.Size(27, 23);
            this.AddRefBt.TabIndex = 4;
            this.AddRefBt.UseVisualStyleBackColor = true;
            this.AddRefBt.Click += new System.EventHandler(this.AddRefference);
            // 
            // ProjectConfigDialog
            // 
            this.AcceptButton = this.SaveBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(413, 279);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.AssemblyTypeCbx);
            this.Controls.Add(this.BuildTargetCbx);
            this.Controls.Add(this.BrowseIconBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveRefBt);
            this.Controls.Add(this.AddRefBt);
            this.Controls.Add(this.ProjectIconTbx);
            this.Controls.Add(this.ProjectCreateDateTbx);
            this.Controls.Add(this.RefferencesListView);
            this.Controls.Add(this.AssemblyNameTbx);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectConfigDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AssemblyNameTbx;
        private System.Windows.Forms.ListView RefferencesListView;
        private System.Windows.Forms.ColumnHeader RefName;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.TextBox ProjectIconTbx;
        private System.Windows.Forms.Button AddRefBt;
        private System.Windows.Forms.Button RemoveRefBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BrowseIconBt;
        private System.Windows.Forms.ComboBox BuildTargetCbx;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox ProjectCreateDateTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AssemblyTypeCbx;
    }
}