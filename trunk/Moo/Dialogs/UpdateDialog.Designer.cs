namespace Moo.Dialogs
{
    partial class UpdateDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDialog));
            this.PluginListView = new System.Windows.Forms.ListView();
            this.PluginName = new System.Windows.Forms.ColumnHeader();
            this.PluginLocation = new System.Windows.Forms.ColumnHeader();
            this.PluginDescription = new System.Windows.Forms.TextBox();
            this.RunAsDeamonBt = new System.Windows.Forms.Button();
            this.AddPlugin = new System.Windows.Forms.Button();
            this.RemovePlugin = new System.Windows.Forms.Button();
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.CancelBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PluginListView
            // 
            this.PluginListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PluginName,
            this.PluginLocation});
            this.PluginListView.Location = new System.Drawing.Point(4, 6);
            this.PluginListView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PluginListView.Name = "PluginListView";
            this.PluginListView.Size = new System.Drawing.Size(347, 146);
            this.PluginListView.TabIndex = 0;
            this.PluginListView.UseCompatibleStateImageBehavior = false;
            this.PluginListView.View = System.Windows.Forms.View.Details;
            // 
            // PluginName
            // 
            this.PluginName.Text = "Name";
            this.PluginName.Width = 157;
            // 
            // PluginLocation
            // 
            this.PluginLocation.Text = "Location";
            this.PluginLocation.Width = 186;
            // 
            // PluginDescription
            // 
            this.PluginDescription.Location = new System.Drawing.Point(4, 157);
            this.PluginDescription.Multiline = true;
            this.PluginDescription.Name = "PluginDescription";
            this.PluginDescription.ReadOnly = true;
            this.PluginDescription.Size = new System.Drawing.Size(347, 75);
            this.PluginDescription.TabIndex = 3;
            // 
            // RunAsDeamonBt
            // 
            this.RunAsDeamonBt.Image = global::Moo.Properties.Resources.workbacgroud;
            this.RunAsDeamonBt.Location = new System.Drawing.Point(354, 68);
            this.RunAsDeamonBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RunAsDeamonBt.Name = "RunAsDeamonBt";
            this.RunAsDeamonBt.Size = new System.Drawing.Size(30, 25);
            this.RunAsDeamonBt.TabIndex = 4;
            this.RunAsDeamonBt.UseVisualStyleBackColor = true;
            // 
            // AddPlugin
            // 
            this.AddPlugin.Image = global::Moo.Properties.Resources.p_add;
            this.AddPlugin.Location = new System.Drawing.Point(354, 6);
            this.AddPlugin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AddPlugin.Name = "AddPlugin";
            this.AddPlugin.Size = new System.Drawing.Size(30, 25);
            this.AddPlugin.TabIndex = 2;
            this.AddPlugin.UseVisualStyleBackColor = true;
            // 
            // RemovePlugin
            // 
            this.RemovePlugin.Image = global::Moo.Properties.Resources.p_delete;
            this.RemovePlugin.Location = new System.Drawing.Point(354, 37);
            this.RemovePlugin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RemovePlugin.Name = "RemovePlugin";
            this.RemovePlugin.Size = new System.Drawing.Size(30, 25);
            this.RemovePlugin.TabIndex = 1;
            this.RemovePlugin.UseVisualStyleBackColor = true;
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(6, 238);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(345, 10);
            this.DownloadProgress.TabIndex = 5;
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Moo.Properties.Resources.stop;
            this.CancelBt.Location = new System.Drawing.Point(354, 99);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(30, 25);
            this.CancelBt.TabIndex = 4;
            this.CancelBt.UseVisualStyleBackColor = true;
            // 
            // UpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 254);
            this.Controls.Add(this.DownloadProgress);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.RunAsDeamonBt);
            this.Controls.Add(this.PluginDescription);
            this.Controls.Add(this.AddPlugin);
            this.Controls.Add(this.RemovePlugin);
            this.Controls.Add(this.PluginListView);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.ShowInTaskbar = false;
            this.Text = "Update Manager ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PluginListView;
        private System.Windows.Forms.Button RemovePlugin;
        private System.Windows.Forms.Button AddPlugin;
        private System.Windows.Forms.TextBox PluginDescription;
        private System.Windows.Forms.ColumnHeader PluginName;
        private System.Windows.Forms.ColumnHeader PluginLocation;
        private System.Windows.Forms.Button RunAsDeamonBt;
        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Button CancelBt;
    }
}