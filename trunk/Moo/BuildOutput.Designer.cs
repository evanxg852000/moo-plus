namespace Moo
{
    partial class BuildOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuildOutput));
            this.Content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Content
            // 
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(0, 0);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Content.Size = new System.Drawing.Size(284, 156);
            this.Content.TabIndex = 0;
            // 
            // BuildOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 156);
            this.Controls.Add(this.Content);
            this.DockAreas = ((Yalamo.Gui.Dock.DockAreas)(((((Yalamo.Gui.Dock.DockAreas.Float | Yalamo.Gui.Dock.DockAreas.DockLeft)
                        | Yalamo.Gui.Dock.DockAreas.DockRight)
                        | Yalamo.Gui.Dock.DockAreas.DockBottom)
                        | Yalamo.Gui.Dock.DockAreas.Document)));
            this.HideOnClose = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BuildOutput";
            this.TabText = "Build Output";
            this.Text = "Build Output";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Content;


    }
}