namespace Moo.Dialogs
{
    partial class NewBrunchDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBrunchDialog));
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewBrunch = new System.Windows.Forms.ToolStripButton();
            this.NameTxt = new System.Windows.Forms.ToolStripTextBox();
            this.BruchTypeCbx = new System.Windows.Forms.ToolStripComboBox();
            this.SaveBrunch = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrunchTxt = new ScintillaNet.Scintilla();
            this.ToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackgroundImage = global::Moo.Properties.Resources.tbackground;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewBrunch,
            this.NameTxt,
            this.BruchTypeCbx,
            this.SaveBrunch});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(378, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // NewBrunch
            // 
            this.NewBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewBrunch.Image = global::Moo.Properties.Resources.brunch_add;
            this.NewBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBrunch.Name = "NewBrunch";
            this.NewBrunch.Size = new System.Drawing.Size(23, 22);
            this.NewBrunch.Text = "Add Brunch";
            this.NewBrunch.Click += new System.EventHandler(this.NewClear);
            // 
            // NameTxt
            // 
            this.NameTxt.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(120, 25);
            this.NameTxt.Text = "Name";
            this.NameTxt.ToolTipText = "Brunch name";
            // 
            // BruchTypeCbx
            // 
            this.BruchTypeCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BruchTypeCbx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BruchTypeCbx.Items.AddRange(new object[] {
            "Select brunch type",
            "cpp",
            "cs",
            "html",
            "hydro",
            "il",
            "java",
            "js",
            "misc",
            "php",
            "vb"});
            this.BruchTypeCbx.Name = "BruchTypeCbx";
            this.BruchTypeCbx.Size = new System.Drawing.Size(135, 25);
            this.BruchTypeCbx.ToolTipText = "Select The brunch Type";
            // 
            // SaveBrunch
            // 
            this.SaveBrunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveBrunch.Image = global::Moo.Properties.Resources.save;
            this.SaveBrunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBrunch.Name = "SaveBrunch";
            this.SaveBrunch.Size = new System.Drawing.Size(23, 22);
            this.SaveBrunch.Text = "Remove Brunch";
            this.SaveBrunch.Click += new System.EventHandler(this.SaveBrunchHandler);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 232);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(378, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 3;
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // BrunchTxt
            // 
            this.BrunchTxt.ConfigurationManager.Language = "cs";
            this.BrunchTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrunchTxt.Folding.MarkerScheme = ScintillaNet.FoldMarkerScheme.PlusMinus;
            this.BrunchTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrunchTxt.IsBraceMatching = true;
            this.BrunchTxt.Location = new System.Drawing.Point(0, 25);
            this.BrunchTxt.Margins.Margin0.Width = 20;
            this.BrunchTxt.Margins.Margin1.Width = 5;
            this.BrunchTxt.Margins.Margin2.Width = 17;
            this.BrunchTxt.Name = "BrunchTxt";
            this.BrunchTxt.Size = new System.Drawing.Size(378, 207);
            this.BrunchTxt.TabIndex = 0;
            this.BrunchTxt.UseFont = true;
            // 
            // NewBrunchDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 254);
            this.Controls.Add(this.BrunchTxt);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NewBrunchDialog";
            this.ShowInTaskbar = false;
            this.Text = "New Brunch ";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripButton NewBrunch;
        private System.Windows.Forms.ToolStripButton SaveBrunch;
        private System.Windows.Forms.ToolStripComboBox BruchTypeCbx;
        private System.Windows.Forms.ToolStripTextBox NameTxt;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private ScintillaNet.Scintilla BrunchTxt;
    }
}