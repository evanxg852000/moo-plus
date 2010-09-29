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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.BrunchTxt = new ScintillaNet.Scintilla();
            this.BrunchTree = new Moo.Controls.BrunchBrowser();
            this.EditBrunchBt = new System.Windows.Forms.Button();
            this.AddBrunchBt = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TrigerTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ApplyBt = new System.Windows.Forms.Button();
            this.CancelBt = new System.Windows.Forms.Button();
            this.RemoveBrunchBt = new System.Windows.Forms.Button();
            this.KeyTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTypeCbx = new System.Windows.Forms.ComboBox();
            this.SaveCurrentEdit = new System.Windows.Forms.Button();
            this.CleanBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Location = new System.Drawing.Point(0, 49);
            this.Logo.Size = new System.Drawing.Size(624, 1);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMsg,
            this.StatusBarMsg});
            this.statusBar.Location = new System.Drawing.Point(0, 369);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(611, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 3;
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusBarMsg
            // 
            this.StatusBarMsg.Name = "StatusBarMsg";
            this.StatusBarMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // BrunchTxt
            // 
            this.BrunchTxt.ConfigurationManager.Language = "cs";
            this.BrunchTxt.Folding.MarkerScheme = ScintillaNet.FoldMarkerScheme.PlusMinus;
            this.BrunchTxt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrunchTxt.IsBraceMatching = true;
            this.BrunchTxt.Location = new System.Drawing.Point(189, 53);
            this.BrunchTxt.Margins.Margin0.Width = 20;
            this.BrunchTxt.Margins.Margin1.Width = 5;
            this.BrunchTxt.Margins.Margin2.Width = 17;
            this.BrunchTxt.Name = "BrunchTxt";
            this.BrunchTxt.Size = new System.Drawing.Size(378, 194);
            this.BrunchTxt.TabIndex = 0;
            this.BrunchTxt.UseFont = true;
            // 
            // BrunchTree
            // 
            this.BrunchTree.BrunchDataStructure = null;
            this.BrunchTree.BrunchTriggerDictionary = null;
            this.BrunchTree.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrunchTree.ImageIndex = 0;
            this.BrunchTree.Location = new System.Drawing.Point(2, 53);
            this.BrunchTree.Name = "BrunchTree";
            this.BrunchTree.SelectedImageIndex = 0;
            this.BrunchTree.ShowRootLines = false;
            this.BrunchTree.Size = new System.Drawing.Size(178, 313);
            this.BrunchTree.TabIndex = 4;
            // 
            // EditBrunchBt
            // 
            this.EditBrunchBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBrunchBt.Image = global::Moo.Properties.Resources.Edit;
            this.EditBrunchBt.Location = new System.Drawing.Point(573, 166);
            this.EditBrunchBt.Name = "EditBrunchBt";
            this.EditBrunchBt.Size = new System.Drawing.Size(35, 25);
            this.EditBrunchBt.TabIndex = 5;
            this.EditBrunchBt.UseVisualStyleBackColor = true;
            this.EditBrunchBt.Click += new System.EventHandler(this.EditSelectedBrunch);
            // 
            // AddBrunchBt
            // 
            this.AddBrunchBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBrunchBt.Image = global::Moo.Properties.Resources.Add;
            this.AddBrunchBt.Location = new System.Drawing.Point(573, 53);
            this.AddBrunchBt.Name = "AddBrunchBt";
            this.AddBrunchBt.Size = new System.Drawing.Size(35, 25);
            this.AddBrunchBt.TabIndex = 6;
            this.AddBrunchBt.UseVisualStyleBackColor = true;
            this.AddBrunchBt.Click += new System.EventHandler(this.AddNewBrunch);
            // 
            // NameTxt
            // 
            this.NameTxt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTxt.Location = new System.Drawing.Point(248, 264);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(160, 23);
            this.NameTxt.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type :";
            // 
            // TrigerTxt
            // 
            this.TrigerTxt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrigerTxt.Location = new System.Drawing.Point(248, 303);
            this.TrigerTxt.Name = "TrigerTxt";
            this.TrigerTxt.Size = new System.Drawing.Size(160, 23);
            this.TrigerTxt.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trigger :";
            // 
            // ApplyBt
            // 
            this.ApplyBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBt.Image = global::Moo.Properties.Resources.Fsave;
            this.ApplyBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ApplyBt.Location = new System.Drawing.Point(453, 338);
            this.ApplyBt.Name = "ApplyBt";
            this.ApplyBt.Size = new System.Drawing.Size(75, 27);
            this.ApplyBt.TabIndex = 13;
            this.ApplyBt.Text = "Apply";
            this.ApplyBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyBt.UseVisualStyleBackColor = true;
            this.ApplyBt.Click += new System.EventHandler(this.ApplyChangesHandler);
            // 
            // CancelBt
            // 
            this.CancelBt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBt.Image = global::Moo.Properties.Resources.Stop;
            this.CancelBt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CancelBt.Location = new System.Drawing.Point(534, 338);
            this.CancelBt.Name = "CancelBt";
            this.CancelBt.Size = new System.Drawing.Size(75, 27);
            this.CancelBt.TabIndex = 14;
            this.CancelBt.Text = "Cancel";
            this.CancelBt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CancelBt.UseVisualStyleBackColor = true;
            this.CancelBt.Click += new System.EventHandler(this.CancelChangesHandler);
            // 
            // RemoveBrunchBt
            // 
            this.RemoveBrunchBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBrunchBt.Image = global::Moo.Properties.Resources.Remove;
            this.RemoveBrunchBt.Location = new System.Drawing.Point(573, 81);
            this.RemoveBrunchBt.Name = "RemoveBrunchBt";
            this.RemoveBrunchBt.Size = new System.Drawing.Size(35, 25);
            this.RemoveBrunchBt.TabIndex = 15;
            this.RemoveBrunchBt.UseVisualStyleBackColor = true;
            this.RemoveBrunchBt.Click += new System.EventHandler(this.RemoveSelectedBrunch);
            // 
            // KeyTxt
            // 
            this.KeyTxt.Enabled = false;
            this.KeyTxt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTxt.Location = new System.Drawing.Point(504, 300);
            this.KeyTxt.Name = "KeyTxt";
            this.KeyTxt.Size = new System.Drawing.Size(104, 23);
            this.KeyTxt.TabIndex = 17;
            this.KeyTxt.Text = "K";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Key :  Ctrl+";
            // 
            // BTypeCbx
            // 
            this.BTypeCbx.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTypeCbx.FormattingEnabled = true;
            this.BTypeCbx.Location = new System.Drawing.Point(472, 261);
            this.BTypeCbx.Name = "BTypeCbx";
            this.BTypeCbx.Size = new System.Drawing.Size(136, 26);
            this.BTypeCbx.TabIndex = 18;
            // 
            // SaveCurrentEdit
            // 
            this.SaveCurrentEdit.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCurrentEdit.Image = global::Moo.Properties.Resources.Fsave;
            this.SaveCurrentEdit.Location = new System.Drawing.Point(573, 193);
            this.SaveCurrentEdit.Name = "SaveCurrentEdit";
            this.SaveCurrentEdit.Size = new System.Drawing.Size(35, 25);
            this.SaveCurrentEdit.TabIndex = 19;
            this.SaveCurrentEdit.UseVisualStyleBackColor = true;
            this.SaveCurrentEdit.Click += new System.EventHandler(this.SaveCurrentEditHandler);
            // 
            // CleanBt
            // 
            this.CleanBt.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CleanBt.Image = global::Moo.Properties.Resources.Clean;
            this.CleanBt.Location = new System.Drawing.Point(573, 222);
            this.CleanBt.Name = "CleanBt";
            this.CleanBt.Size = new System.Drawing.Size(35, 25);
            this.CleanBt.TabIndex = 20;
            this.CleanBt.UseVisualStyleBackColor = true;
            this.CleanBt.Click += new System.EventHandler(this.CleanHandler);
            // 
            // BrunchEditorDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 391);
            this.Controls.Add(this.CleanBt);
            this.Controls.Add(this.SaveCurrentEdit);
            this.Controls.Add(this.BTypeCbx);
            this.Controls.Add(this.KeyTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.RemoveBrunchBt);
            this.Controls.Add(this.CancelBt);
            this.Controls.Add(this.ApplyBt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TrigerTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.AddBrunchBt);
            this.Controls.Add(this.EditBrunchBt);
            this.Controls.Add(this.BrunchTree);
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
            this.Controls.SetChildIndex(this.BrunchTree, 0);
            this.Controls.SetChildIndex(this.EditBrunchBt, 0);
            this.Controls.SetChildIndex(this.AddBrunchBt, 0);
            this.Controls.SetChildIndex(this.NameTxt, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.TrigerTxt, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.ApplyBt, 0);
            this.Controls.SetChildIndex(this.CancelBt, 0);
            this.Controls.SetChildIndex(this.RemoveBrunchBt, 0);
            this.Controls.SetChildIndex(this.statusBar, 0);
            this.Controls.SetChildIndex(this.Logo, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.KeyTxt, 0);
            this.Controls.SetChildIndex(this.BTypeCbx, 0);
            this.Controls.SetChildIndex(this.SaveCurrentEdit, 0);
            this.Controls.SetChildIndex(this.CleanBt, 0);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrunchTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private ScintillaNet.Scintilla BrunchTxt;
        private System.Windows.Forms.Button EditBrunchBt;
        private System.Windows.Forms.Button AddBrunchBt;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TrigerTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ApplyBt;
        private System.Windows.Forms.Button CancelBt;
        private System.Windows.Forms.Button RemoveBrunchBt;
        private System.Windows.Forms.TextBox KeyTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox BTypeCbx;
        private Moo.Controls.BrunchBrowser BrunchTree;
        private System.Windows.Forms.Button SaveCurrentEdit;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMsg;
        private System.Windows.Forms.Button CleanBt;
    }
}