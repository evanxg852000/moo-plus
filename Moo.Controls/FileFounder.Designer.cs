namespace Moo.Controls
{
    partial class FileFounder
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeamonSearcher = new System.ComponentModel.BackgroundWorker();
            this.FileName = new System.Windows.Forms.ColumnHeader();
            this.FilePath = new System.Windows.Forms.ColumnHeader();
            this.DateModified = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // DeamonSearcher
            // 
            this.DeamonSearcher.WorkerSupportsCancellation = true;
            this.DeamonSearcher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DeamonSearcher_DoWork);
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 150;
            // 
            // FilePath
            // 
            this.FilePath.Text = "Path";
            this.FilePath.Width = 500;
            // 
            // DateModified
            // 
            this.DateModified.Text = "Date Modified";
            this.DateModified.Width = 150;
            // 
            // FileFounder
            // 
            this.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FilePath,
            this.DateModified});
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullRowSelect = true;
            this.GridLines = true;
            this.View = System.Windows.Forms.View.Details;
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker DeamonSearcher;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.ColumnHeader DateModified;
    }
}
