namespace Moo.Dialogs
{
    partial class BrunchEditorDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrunchEditorDialog));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrunchTxt = new ScintillaNet.Scintilla();
            this.brunchBrowser1 = new Moo.Controls.BrunchBrowser();
            this.AddCatBt = new System.Windows.Forms.Button();
            this.AddBrunchBt = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrigerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApplyBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.KeyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTypeCbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(0, 49);
            this.Logo.Size = new System.Drawing.Size(624, 1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 373);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(611, 22);
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
            this.BrunchTxt.Folding.MarkerScheme = ScintillaNet.FoldMarkerScheme.PlusMinus;
            this.BrunchTxt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrunchTxt.IsBraceMatching = true;
            this.BrunchTxt.Location = new System.Drawing.Point(189, 54);
            this.BrunchTxt.Margins.Margin0.Width = 20;
            this.BrunchTxt.Margins.Margin1.Width = 5;
            this.BrunchTxt.Margins.Margin2.Width = 17;
            this.BrunchTxt.Name = "BrunchTxt";
            this.BrunchTxt.Size = new System.Drawing.Size(378, 194);
            this.BrunchTxt.TabIndex = 0;
            this.BrunchTxt.UseFont = true;
            // 
            // brunchBrowser1
            // 
            this.brunchBrowser1.File = null;
            this.brunchBrowser1.Font = new System.Drawing.Font("Verdana", 9.75F);
            this.brunchBrowser1.ImageIndex = 0;
            this.brunchBrowser1.Location = new System.Drawing.Point(2, 54);
            this.brunchBrowser1.Name = "brunchBrowser1";
            this.brunchBrowser1.SelectedImageIndex = 0;
            this.brunchBrowser1.ShowRootLines = false;
            this.brunchBrowser1.Size = new System.Drawing.Size(178, 313);
            this.brunchBrowser1.TabIndex = 4;
            // 
            // AddCatBt
            // 
            this.AddCatBt.Image = global::Moo.Properties.Resources.Add;
            this.AddCatBt.Location = new System.Drawing.Point(573, 83);
            this.AddCatBt.Name = "AddCatBt";
            this.AddCatBt.Size = new System.Drawing.Size(35, 25);
            this.AddCatBt.TabIndex = 5;
            this.AddCatBt.UseVisualStyleBackColor = true;
            // 
            // AddBrunchBt
            // 
            this.AddBrunchBt.Image = global::Moo.Properties.Resources.Add;
            this.AddBrunchBt.Location = new System.Drawing.Point(573, 54);
            this.AddBrunchBt.Name = "AddBrunchBt";
            this.AddBrunchBt.Size = new System.Drawing.Size(35, 25);
            this.AddBrunchBt.TabIndex = 6;
            this.AddBrunchBt.UseVisualStyleBackColor = true;
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(248, 262);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(160, 22);
            this.NameTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type :";
            // 
            // TrigerTxt
            // 
            this.TrigerTxt.Location = new System.Drawing.Point(248, 301);
            this.TrigerTxt.Name = "TrigerTxt";
            this.TrigerTxt.Size = new System.Drawing.Size(160, 22);
            this.TrigerTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trigger :";
            // 
            // ApplyBt
            // 
            this.ApplyBt.Image = global::Moo.Properties.Resources.Fsave;
            this.ApplyBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyBt.Location = new System.Drawing.Point(457, 341);
            this.ApplyBt.Name = "ApplyBt";
            this.ApplyBt.Size = new System.Drawing.Size(66, 26);
            this.ApplyBt.TabIndex = 13;
            this.ApplyBt.Text = "Apply";
            this.ApplyBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyBt.UseVisualStyleBackColor = true;
            this.ApplyBt.Click += new System.EventHandler(this.ApplyChangesHandler);
            // 
            // CancelBt
            // 
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Image = global::Moo.Properties.Resources.Stop;
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(534, 341);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(74, 26);
            this.CancelBt.TabIndex = 14;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBt.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Image = global::Moo.Properties.Resources.Remove;
            this.Remove.Location = new System.Drawing.Point(573, 114);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(35, 25);
            this.Remove.TabIndex = 15;
            this.Remove.UseVisualStyleBackColor = true;
            // 
            // KeyTxt
            // 
            this.KeyTxt.Location = new System.Drawing.Point(504, 301);
            this.KeyTxt.Name = "KeyTxt";
            this.KeyTxt.Size = new System.Drawing.Size(104, 22);
            this.KeyTxt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key :  Ctrl+";
            // 
            // BTypeCbx
            // 
            this.BTypeCbx.FormattingEnabled = true;
            this.BTypeCbx.Items.AddRange(new object[] {
            "PHP",
            "HTML",
            "JS"});
            this.BTypeCbx.Location = new System.Drawing.Point(472, 262);
            this.BTypeCbx.Name = "BTypeCbx";
            this.BTypeCbx.Size = new System.Drawing.Size(136, 22);
            this.BTypeCbx.TabIndex = 18;
            // 
            // BrunchEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 395);
            this.Controls.Add(this.BTypeCbx);
            this.Controls.Add(this.KeyTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.ApplyBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrigerTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.AddBrunchBt);
            this.Controls.Add(this.AddCatBt);
            this.Controls.Add(this.brunchBrowser1);
            this.Controls.Add(this.BrunchTxt);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BrunchEditorDialog";
            this.ShowInTaskbar = false;
            this.Text = "Brunch Editor ";
            this.TopMargin = 50;
            this.Controls.SetChildIndex(this.BrunchTxt, 0);
            this.Controls.SetChildIndex(this.brunchBrowser1, 0);
            this.Controls.SetChildIndex(this.AddCatBt, 0);
            this.Controls.SetChildIndex(this.AddBrunchBt, 0);
            this.Controls.SetChildIndex(this.NameTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TrigerTxt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ApplyBt, 0);
            this.Controls.SetChildIndex(this.CancelBt, 0);
            this.Controls.SetChildIndex(this.Remove, 0);
            this.Controls.SetChildIndex(this.statusStrip1, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.KeyTxt, 0);
            this.Controls.SetChildIndex(this.BTypeCbx, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private ScintillaNet.Scintilla BrunchTxt;
        private Moo.Controls.BrunchBrowser brunchBrowser1;
        private System.Windows.Forms.Button AddCatBt;
        private System.Windows.Forms.Button AddBrunchBt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrigerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ApplyBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox KeyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BTypeCbx;
    }
}