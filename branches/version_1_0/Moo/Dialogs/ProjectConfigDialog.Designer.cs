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
            this.RefType = new System.Windows.Forms.ColumnHeader();
            this.RefPath = new System.Windows.Forms.ColumnHeader();
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
            this.Statusbar = new System.Windows.Forms.StatusStrip();
            this.statusProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.AssemblySearcher = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RefreshBt = new System.Windows.Forms.Button();
            this.configtab = new System.Windows.Forms.TabControl();
            this.dotnettab = new System.Windows.Forms.TabPage();
            this.ilasmtab = new System.Windows.Forms.TabPage();
            this.webtab = new System.Windows.Forms.TabPage();
            this.javatab = new System.Windows.Forms.TabPage();
            this.databasetab = new System.Windows.Forms.TabPage();
            this.hydrotab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Statusbar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.configtab.SuspendLayout();
            this.dotnettab.SuspendLayout();
            this.webtab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AssemblyNameTbx
            // 
            this.AssemblyNameTbx.Location = new System.Drawing.Point(124, 19);
            this.AssemblyNameTbx.Name = "AssemblyNameTbx";
            this.AssemblyNameTbx.Size = new System.Drawing.Size(216, 22);
            this.AssemblyNameTbx.TabIndex = 0;
            // 
            // RefferencesListView
            // 
            this.RefferencesListView.CheckBoxes = true;
            this.RefferencesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.RefName,
            this.RefType,
            this.RefPath});
            this.RefferencesListView.FullRowSelect = true;
            this.RefferencesListView.GridLines = true;
            this.RefferencesListView.Location = new System.Drawing.Point(6, 125);
            this.RefferencesListView.MultiSelect = false;
            this.RefferencesListView.Name = "RefferencesListView";
            this.RefferencesListView.ShowItemToolTips = true;
            this.RefferencesListView.Size = new System.Drawing.Size(656, 137);
            this.RefferencesListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RefferencesListView.TabIndex = 2;
            this.RefferencesListView.UseCompatibleStateImageBehavior = false;
            this.RefferencesListView.View = System.Windows.Forms.View.Details;
            // 
            // RefName
            // 
            this.RefName.Text = "Refferences";
            this.RefName.Width = 274;
            // 
            // RefType
            // 
            this.RefType.Text = "Type";
            this.RefType.Width = 77;
            // 
            // RefPath
            // 
            this.RefPath.Text = "Path";
            this.RefPath.Width = 183;
            // 
            // ProjectIconTbx
            // 
            this.ProjectIconTbx.Location = new System.Drawing.Point(465, 19);
            this.ProjectIconTbx.Name = "ProjectIconTbx";
            this.ProjectIconTbx.Size = new System.Drawing.Size(132, 22);
            this.ProjectIconTbx.TabIndex = 3;
            this.ProjectIconTbx.Text = "moo.ico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Assembly Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "Build Target";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Application Icon";
            // 
            // BrowseIconBt
            // 
            this.BrowseIconBt.Location = new System.Drawing.Point(599, 18);
            this.BrowseIconBt.Name = "BrowseIconBt";
            this.BrowseIconBt.Size = new System.Drawing.Size(29, 23);
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
            this.BuildTargetCbx.Location = new System.Drawing.Point(124, 78);
            this.BuildTargetCbx.Name = "BuildTargetCbx";
            this.BuildTargetCbx.Size = new System.Drawing.Size(216, 22);
            this.BuildTargetCbx.TabIndex = 11;
            // 
            // SaveBt
            // 
            this.SaveBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBt.Image = global::Moo.Properties.Resources.Fsave;
            this.SaveBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SaveBt.Location = new System.Drawing.Point(555, 352);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 25);
            this.SaveBt.TabIndex = 13;
            this.SaveBt.Text = "Save";
            this.SaveBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveBt_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Image = global::Moo.Properties.Resources.Stop;
            this.Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.Location = new System.Drawing.Point(636, 352);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 25);
            this.Cancel.TabIndex = 14;
            this.Cancel.Text = "Cancel";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // ProjectCreateDateTbx
            // 
            this.ProjectCreateDateTbx.Enabled = false;
            this.ProjectCreateDateTbx.Location = new System.Drawing.Point(465, 46);
            this.ProjectCreateDateTbx.Name = "ProjectCreateDateTbx";
            this.ProjectCreateDateTbx.Size = new System.Drawing.Size(132, 22);
            this.ProjectCreateDateTbx.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Created";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
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
            "Console Executable (.exe)",
            "Windows Executable (.exe)",
            "Dynamic Library (.dll)"});
            this.AssemblyTypeCbx.Location = new System.Drawing.Point(124, 47);
            this.AssemblyTypeCbx.Name = "AssemblyTypeCbx";
            this.AssemblyTypeCbx.Size = new System.Drawing.Size(216, 22);
            this.AssemblyTypeCbx.TabIndex = 11;
            // 
            // RemoveRefBt
            // 
            this.RemoveRefBt.Image = global::Moo.Properties.Resources.Remove;
            this.RemoveRefBt.Location = new System.Drawing.Point(668, 237);
            this.RemoveRefBt.Name = "RemoveRefBt";
            this.RemoveRefBt.Size = new System.Drawing.Size(25, 25);
            this.RemoveRefBt.TabIndex = 5;
            this.RemoveRefBt.UseVisualStyleBackColor = true;
            this.RemoveRefBt.Click += new System.EventHandler(this.RemoveRefference);
            // 
            // AddRefBt
            // 
            this.AddRefBt.Image = global::Moo.Properties.Resources.Add;
            this.AddRefBt.Location = new System.Drawing.Point(668, 183);
            this.AddRefBt.Name = "AddRefBt";
            this.AddRefBt.Size = new System.Drawing.Size(25, 25);
            this.AddRefBt.TabIndex = 4;
            this.AddRefBt.UseVisualStyleBackColor = true;
            this.AddRefBt.Click += new System.EventHandler(this.AddRefference);
            // 
            // Statusbar
            // 
            this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusProgress,
            this.StatusMsg});
            this.Statusbar.Location = new System.Drawing.Point(0, 379);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(717, 22);
            this.Statusbar.SizingGrip = false;
            this.Statusbar.TabIndex = 15;
            this.Statusbar.Text = "statusStrip1";
            // 
            // statusProgress
            // 
            this.statusProgress.Name = "statusProgress";
            this.statusProgress.Size = new System.Drawing.Size(100, 16);
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(10, 17);
            this.StatusMsg.Text = " ";
            // 
            // AssemblySearcher
            // 
            this.AssemblySearcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SearchAssemblies);
            this.AssemblySearcher.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SearchAssembliesCompleted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BuildTargetCbx);
            this.groupBox1.Controls.Add(this.AssemblyNameTbx);
            this.groupBox1.Controls.Add(this.ProjectCreateDateTbx);
            this.groupBox1.Controls.Add(this.ProjectIconTbx);
            this.groupBox1.Controls.Add(this.AssemblyTypeCbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.BrowseIconBt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 113);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Global ";
            // 
            // RefreshBt
            // 
            this.RefreshBt.Image = global::Moo.Properties.Resources.Refresh;
            this.RefreshBt.Location = new System.Drawing.Point(668, 210);
            this.RefreshBt.Name = "RefreshBt";
            this.RefreshBt.Size = new System.Drawing.Size(25, 25);
            this.RefreshBt.TabIndex = 17;
            this.RefreshBt.UseVisualStyleBackColor = true;
            this.RefreshBt.Click += new System.EventHandler(this.RefreshAssembliesListView);
            // 
            // configtab
            // 
            this.configtab.Controls.Add(this.dotnettab);
            this.configtab.Controls.Add(this.ilasmtab);
            this.configtab.Controls.Add(this.webtab);
            this.configtab.Controls.Add(this.javatab);
            this.configtab.Controls.Add(this.databasetab);
            this.configtab.Controls.Add(this.hydrotab);
            this.configtab.Location = new System.Drawing.Point(5, 55);
            this.configtab.Name = "configtab";
            this.configtab.SelectedIndex = 0;
            this.configtab.Size = new System.Drawing.Size(709, 295);
            this.configtab.TabIndex = 18;
            // 
            // dotnettab
            // 
            this.dotnettab.BackColor = System.Drawing.Color.Transparent;
            this.dotnettab.Controls.Add(this.RefferencesListView);
            this.dotnettab.Controls.Add(this.groupBox1);
            this.dotnettab.Controls.Add(this.RefreshBt);
            this.dotnettab.Controls.Add(this.AddRefBt);
            this.dotnettab.Controls.Add(this.RemoveRefBt);
            this.dotnettab.Location = new System.Drawing.Point(4, 23);
            this.dotnettab.Name = "dotnettab";
            this.dotnettab.Padding = new System.Windows.Forms.Padding(3);
            this.dotnettab.Size = new System.Drawing.Size(701, 268);
            this.dotnettab.TabIndex = 0;
            this.dotnettab.Text = "Ms .Net";
            this.dotnettab.UseVisualStyleBackColor = true;
            // 
            // ilasmtab
            // 
            this.ilasmtab.BackColor = System.Drawing.Color.Transparent;
            this.ilasmtab.Location = new System.Drawing.Point(4, 23);
            this.ilasmtab.Name = "ilasmtab";
            this.ilasmtab.Padding = new System.Windows.Forms.Padding(3);
            this.ilasmtab.Size = new System.Drawing.Size(701, 268);
            this.ilasmtab.TabIndex = 5;
            this.ilasmtab.Text = "ILasm";
            this.ilasmtab.UseVisualStyleBackColor = true;
            // 
            // webtab
            // 
            this.webtab.BackColor = System.Drawing.Color.Transparent;
            this.webtab.Controls.Add(this.textBox1);
            this.webtab.Controls.Add(this.label6);
            this.webtab.Location = new System.Drawing.Point(4, 23);
            this.webtab.Name = "webtab";
            this.webtab.Padding = new System.Windows.Forms.Padding(3);
            this.webtab.Size = new System.Drawing.Size(701, 268);
            this.webtab.TabIndex = 1;
            this.webtab.Text = "Web";
            this.webtab.UseVisualStyleBackColor = true;
            // 
            // javatab
            // 
            this.javatab.BackColor = System.Drawing.Color.Transparent;
            this.javatab.Location = new System.Drawing.Point(4, 23);
            this.javatab.Name = "javatab";
            this.javatab.Size = new System.Drawing.Size(701, 268);
            this.javatab.TabIndex = 2;
            this.javatab.Text = "Java";
            this.javatab.UseVisualStyleBackColor = true;
            // 
            // databasetab
            // 
            this.databasetab.BackColor = System.Drawing.Color.Transparent;
            this.databasetab.Location = new System.Drawing.Point(4, 23);
            this.databasetab.Name = "databasetab";
            this.databasetab.Padding = new System.Windows.Forms.Padding(3);
            this.databasetab.Size = new System.Drawing.Size(701, 268);
            this.databasetab.TabIndex = 3;
            this.databasetab.Text = "Database";
            this.databasetab.UseVisualStyleBackColor = true;
            // 
            // hydrotab
            // 
            this.hydrotab.BackColor = System.Drawing.Color.Transparent;
            this.hydrotab.Location = new System.Drawing.Point(4, 23);
            this.hydrotab.Name = "hydrotab";
            this.hydrotab.Padding = new System.Windows.Forms.Padding(3);
            this.hydrotab.Size = new System.Drawing.Size(701, 268);
            this.hydrotab.TabIndex = 4;
            this.hydrotab.Text = "Hydro";
            this.hydrotab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(388, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "http://localhost/";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 14);
            this.label6.TabIndex = 8;
            this.label6.Text = "Run Url";
            // 
            // ProjectConfigDialog
            // 
            this.AcceptButton = this.SaveBt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border.Bottom = 0;
            this.Border.Left = 0;
            this.Border.Right = 0;
            this.Border.Top = 50;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(717, 401);
            this.Controls.Add(this.configtab);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.SaveBt);
            this.Controls.Add(this.Cancel);
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
            this.Controls.SetChildIndex(this.Cancel, 0);
            this.Controls.SetChildIndex(this.SaveBt, 0);
            this.Controls.SetChildIndex(this.Statusbar, 0);
            this.Controls.SetChildIndex(this.configtab, 0);
            this.Statusbar.ResumeLayout(false);
            this.Statusbar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.configtab.ResumeLayout(false);
            this.dotnettab.ResumeLayout(false);
            this.webtab.ResumeLayout(false);
            this.webtab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AssemblyNameTbx;
        private System.Windows.Forms.ListView RefferencesListView;
        private System.Windows.Forms.ColumnHeader RefName;
        private System.Windows.Forms.ColumnHeader RefPath;
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
        private System.Windows.Forms.ColumnHeader RefType;
        private System.Windows.Forms.StatusStrip Statusbar;
        private System.ComponentModel.BackgroundWorker AssemblySearcher;
        private System.Windows.Forms.ToolStripProgressBar statusProgress;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button RefreshBt;
        private System.Windows.Forms.TabControl configtab;
        private System.Windows.Forms.TabPage dotnettab;
        private System.Windows.Forms.TabPage webtab;
        private System.Windows.Forms.TabPage javatab;
        private System.Windows.Forms.TabPage databasetab;
        private System.Windows.Forms.TabPage hydrotab;
        private System.Windows.Forms.TabPage ilasmtab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
    }
}