namespace Moo.Controls.Test
{
    partial class Form1
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
            this.brunchBrowser1 = new Moo.Controls.BrunchBrowser();
            this.SuspendLayout();
            // 
            // brunchBrowser1
            // 
            this.brunchBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.brunchBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.brunchBrowser1.ImageIndex = 0;
            this.brunchBrowser1.Location = new System.Drawing.Point(0, 0);
            this.brunchBrowser1.Name = "brunchBrowser1";
            this.brunchBrowser1.RootFolder = "brunchs";
            this.brunchBrowser1.SelectedImageIndex = 0;
            this.brunchBrowser1.ShowPlusMinus = false;
            this.brunchBrowser1.ShowRootLines = false;
            this.brunchBrowser1.Size = new System.Drawing.Size(284, 264);
            this.brunchBrowser1.TabIndex = 0;
           
            this.brunchBrowser1.ItemSelected += new Moo.Controls.ItemSelectedHandler(this.brunchBrowser1_ItemSelected);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.brunchBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private BrunchBrowser brunchBrowser1;





    }
}

