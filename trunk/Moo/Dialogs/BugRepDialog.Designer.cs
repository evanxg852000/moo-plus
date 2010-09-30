namespace Moo.Dialogs
{
    partial class BugRepDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BugRepDialog));
            this.AttachLogCkbx = new System.Windows.Forms.CheckBox();
            this.BugContentTx = new System.Windows.Forms.TextBox();
            this.ReportBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(0, 29);
            this.Logo.Size = new System.Drawing.Size(384, 1);
            // 
            // AttachLogCkbx
            // 
            this.AttachLogCkbx.AutoSize = true;
            this.AttachLogCkbx.Checked = true;
            this.AttachLogCkbx.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AttachLogCkbx.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttachLogCkbx.Location = new System.Drawing.Point(5, 35);
            this.AttachLogCkbx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.AttachLogCkbx.Name = "AttachLogCkbx";
            this.AttachLogCkbx.Size = new System.Drawing.Size(154, 22);
            this.AttachLogCkbx.TabIndex = 0;
            this.AttachLogCkbx.Text = "Attach log file content";
            this.AttachLogCkbx.UseVisualStyleBackColor = true;
            // 
            // BugContentTx
            // 
            this.BugContentTx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BugContentTx.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BugContentTx.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.BugContentTx.Location = new System.Drawing.Point(3, 62);
            this.BugContentTx.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BugContentTx.Multiline = true;
            this.BugContentTx.Name = "BugContentTx";
            this.BugContentTx.Size = new System.Drawing.Size(330, 181);
            this.BugContentTx.TabIndex = 3;
            this.BugContentTx.Text = "Your bug details here ...";
            // 
            // ReportBt
            // 
            this.ReportBt.Image = global::Moo.Properties.Resources.Sendbug;
            this.ReportBt.Location = new System.Drawing.Point(338, 62);
            this.ReportBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ReportBt.Name = "ReportBt";
            this.ReportBt.Size = new System.Drawing.Size(32, 32);
            this.ReportBt.TabIndex = 1;
            this.ReportBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBt.UseVisualStyleBackColor = true;
            this.ReportBt.Click += new System.EventHandler(this.SendReport);
            // 
            // CancelBt
            // 
            this.CancelBt.Image = global::Moo.Properties.Resources.Stop;
            this.CancelBt.Location = new System.Drawing.Point(338, 100);
            this.CancelBt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(32, 32);
            this.CancelBt.TabIndex = 1;
            this.CancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.Cancel);
            // 
            // BugRepDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 247);
            this.Controls.Add(this.BugContentTx);
            this.Controls.Add(this.AttachLogCkbx);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.ReportBt);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BugRepDialog";
            this.ShowInTaskbar = false;
            this.Text = "Bugs";
            this.TopMargin = 30;
            this.Controls.SetChildIndex(this.ReportBt, 0);
            this.Controls.SetChildIndex(this.CancelBt, 0);
            this.Controls.SetChildIndex(this.AttachLogCkbx, 0);
            this.Controls.SetChildIndex(this.BugContentTx, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox AttachLogCkbx;
        private System.Windows.Forms.Button ReportBt;
        private System.Windows.Forms.TextBox BugContentTx;
        private System.Windows.Forms.Button CancelBt;
    }
}