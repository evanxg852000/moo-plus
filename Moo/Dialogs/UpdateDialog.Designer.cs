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
            this.DownloadProgress = new System.Windows.Forms.ProgressBar();
            this.DownloadBt = new System.Windows.Forms.Button();
            this.DeamonBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.UpdateDetails = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DownloadProgress
            // 
            this.DownloadProgress.Location = new System.Drawing.Point(3, 150);
            this.DownloadProgress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadProgress.Name = "DownloadProgress";
            this.DownloadProgress.Size = new System.Drawing.Size(268, 9);
            this.DownloadProgress.TabIndex = 1;
            // 
            // DownloadBt
            // 
            this.DownloadBt.Enabled = false;
            this.DownloadBt.Location = new System.Drawing.Point(3, 166);
            this.DownloadBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DownloadBt.Name = "DownloadBt";
            this.DownloadBt.Size = new System.Drawing.Size(82, 25);
            this.DownloadBt.TabIndex = 2;
            this.DownloadBt.Text = "Download";
            this.DownloadBt.UseVisualStyleBackColor = true;
            this.DownloadBt.Click += new System.EventHandler(this.InstallUpdate);
            // 
            // DeamonBt
            // 
            this.DeamonBt.Enabled = false;
            this.DeamonBt.Location = new System.Drawing.Point(85, 166);
            this.DeamonBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeamonBt.Name = "DeamonBt";
            this.DeamonBt.Size = new System.Drawing.Size(122, 25);
            this.DeamonBt.TabIndex = 3;
            this.DeamonBt.Text = "Run As Deamon";
            this.DeamonBt.UseVisualStyleBackColor = true;
            this.DeamonBt.Click += new System.EventHandler(this.RunAsDeamon);
            // 
            // CancelBt
            // 
            this.CancelBt.Location = new System.Drawing.Point(207, 166);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(64, 25);
            this.CancelBt.TabIndex = 4;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelUpdate);
            // 
            // UpdateDetails
            // 
            this.UpdateDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UpdateDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UpdateDetails.Location = new System.Drawing.Point(3, 7);
            this.UpdateDetails.Multiline = true;
            this.UpdateDetails.Name = "UpdateDetails";
            this.UpdateDetails.ReadOnly = true;
            this.UpdateDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.UpdateDetails.Size = new System.Drawing.Size(268, 137);
            this.UpdateDetails.TabIndex = 5;
            this.UpdateDetails.Text = "No Update";
            // 
            // UpdateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 196);
            this.Controls.Add(this.UpdateDetails);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.DeamonBt);
            this.Controls.Add(this.DownloadBt);
            this.Controls.Add(this.DownloadProgress);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.ShowInTaskbar = false;
            this.Text = "Moo Update ...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar DownloadProgress;
        private System.Windows.Forms.Button DownloadBt;
        private System.Windows.Forms.Button DeamonBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.TextBox UpdateDetails;
    }
}