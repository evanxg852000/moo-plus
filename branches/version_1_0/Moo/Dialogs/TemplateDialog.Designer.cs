namespace Moo.Dialogs
{
    partial class TemplateDialog
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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.cureentFilelabel = new System.Windows.Forms.Label();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(6, 41);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(282, 17);
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.UseWaitCursor = true;
            // 
            // cureentFilelabel
            // 
            this.cureentFilelabel.AutoSize = true;
            this.cureentFilelabel.Font = new System.Drawing.Font("Verdana", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cureentFilelabel.Location = new System.Drawing.Point(8, 25);
            this.cureentFilelabel.Name = "cureentFilelabel";
            this.cureentFilelabel.Size = new System.Drawing.Size(234, 12);
            this.cureentFilelabel.TabIndex = 5;
            this.cureentFilelabel.Text = "C:/Users/Adam/Docs/Moo/Projects/main.cpp";
            this.cureentFilelabel.UseWaitCursor = true;
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CopyFolderAsyc);
            this.Worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkCompleted);
            this.Worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UpdateUi);
            // 
            // TemplateDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Border.Bottom = 0;
            this.Border.Left = 0;
            this.Border.Right = 0;
            this.Border.Top = 20;
            this.ClientSize = new System.Drawing.Size(294, 62);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.cureentFilelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TemplateDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting Up ...";
            this.TopMost = true;
            this.UseWaitCursor = true;
            this.Controls.SetChildIndex(this.cureentFilelabel, 0);
            this.Controls.SetChildIndex(this.ProgressBar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label cureentFilelabel;
        private System.ComponentModel.BackgroundWorker Worker;
    }
}