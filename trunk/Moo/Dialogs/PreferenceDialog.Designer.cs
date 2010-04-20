namespace Moo.Dialogs
{
    partial class PreferenceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferenceDialog));
            this.Cancel = new System.Windows.Forms.Button();
            this.SaveBt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.IsBuildOutput = new System.Windows.Forms.CheckBox();
            this.IsFileSearcher = new System.Windows.Forms.CheckBox();
            this.IsFileBrowser = new System.Windows.Forms.CheckBox();
            this.IsBrunchBrowser = new System.Windows.Forms.CheckBox();
            this.IsProjectBrowser = new System.Windows.Forms.CheckBox();
            this.IsSaveLayout = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.CEFoldingMarker = new System.Windows.Forms.ComboBox();
            this.CEIsLineHilighting = new System.Windows.Forms.CheckBox();
            this.CEFontSize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CEFontStyle = new System.Windows.Forms.ComboBox();
            this.CEFont = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CEFontSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(468, 236);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 16;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // SaveBt
            // 
            this.SaveBt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveBt.Location = new System.Drawing.Point(468, 207);
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.Size = new System.Drawing.Size(75, 23);
            this.SaveBt.TabIndex = 15;
            this.SaveBt.Text = "Save";
            this.SaveBt.UseVisualStyleBackColor = true;
            this.SaveBt.Click += new System.EventHandler(this.SaveEditedSettings);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(458, 257);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(450, 230);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ui Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // IsBuildOutput
            // 
            this.IsBuildOutput.AutoSize = true;
            this.IsBuildOutput.Location = new System.Drawing.Point(8, 196);
            this.IsBuildOutput.Name = "IsBuildOutput";
            this.IsBuildOutput.Size = new System.Drawing.Size(234, 18);
            this.IsBuildOutput.TabIndex = 5;
            this.IsBuildOutput.Text = "Expand build output on startup ?";
            this.IsBuildOutput.UseVisualStyleBackColor = true;
            // 
            // IsFileSearcher
            // 
            this.IsFileSearcher.AutoSize = true;
            this.IsFileSearcher.Location = new System.Drawing.Point(8, 161);
            this.IsFileSearcher.Name = "IsFileSearcher";
            this.IsFileSearcher.Size = new System.Drawing.Size(222, 18);
            this.IsFileSearcher.TabIndex = 4;
            this.IsFileSearcher.Text = "Expand file search on startup ?";
            this.IsFileSearcher.UseVisualStyleBackColor = true;
            // 
            // IsFileBrowser
            // 
            this.IsFileBrowser.AutoSize = true;
            this.IsFileBrowser.Location = new System.Drawing.Point(8, 126);
            this.IsFileBrowser.Name = "IsFileBrowser";
            this.IsFileBrowser.Size = new System.Drawing.Size(281, 18);
            this.IsFileBrowser.TabIndex = 3;
            this.IsFileBrowser.Text = "Expand file system browser on startup ?";
            this.IsFileBrowser.UseVisualStyleBackColor = true;
            // 
            // IsBrunchBrowser
            // 
            this.IsBrunchBrowser.AutoSize = true;
            this.IsBrunchBrowser.Location = new System.Drawing.Point(8, 91);
            this.IsBrunchBrowser.Name = "IsBrunchBrowser";
            this.IsBrunchBrowser.Size = new System.Drawing.Size(257, 18);
            this.IsBrunchBrowser.TabIndex = 2;
            this.IsBrunchBrowser.Text = "Expand brunch browser on startup ?";
            this.IsBrunchBrowser.UseVisualStyleBackColor = true;
            // 
            // IsProjectBrowser
            // 
            this.IsProjectBrowser.AutoSize = true;
            this.IsProjectBrowser.Location = new System.Drawing.Point(7, 56);
            this.IsProjectBrowser.Name = "IsProjectBrowser";
            this.IsProjectBrowser.Size = new System.Drawing.Size(258, 18);
            this.IsProjectBrowser.TabIndex = 1;
            this.IsProjectBrowser.Text = "Expand project browser on startup ?";
            this.IsProjectBrowser.UseVisualStyleBackColor = true;
            // 
            // IsSaveLayout
            // 
            this.IsSaveLayout.AutoSize = true;
            this.IsSaveLayout.Location = new System.Drawing.Point(8, 21);
            this.IsSaveLayout.Name = "IsSaveLayout";
            this.IsSaveLayout.Size = new System.Drawing.Size(250, 18);
            this.IsSaveLayout.TabIndex = 0;
            this.IsSaveLayout.Text = "Always save layout before closing ?";
            this.IsSaveLayout.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(450, 230);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Code Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Folding:";
            // 
            // CEFoldingMarker
            // 
            this.CEFoldingMarker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEFoldingMarker.FormattingEnabled = true;
            this.CEFoldingMarker.Location = new System.Drawing.Point(77, 147);
            this.CEFoldingMarker.Name = "CEFoldingMarker";
            this.CEFoldingMarker.Size = new System.Drawing.Size(165, 22);
            this.CEFoldingMarker.TabIndex = 5;
            // 
            // CEIsLineHilighting
            // 
            this.CEIsLineHilighting.AutoSize = true;
            this.CEIsLineHilighting.Location = new System.Drawing.Point(260, 84);
            this.CEIsLineHilighting.Name = "CEIsLineHilighting";
            this.CEIsLineHilighting.Size = new System.Drawing.Size(151, 18);
            this.CEIsLineHilighting.TabIndex = 4;
            this.CEIsLineHilighting.Text = "Hilight current line ?";
            this.CEIsLineHilighting.UseVisualStyleBackColor = true;
            // 
            // CEFontSize
            // 
            this.CEFontSize.Location = new System.Drawing.Point(333, 21);
            this.CEFontSize.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.CEFontSize.Name = "CEFontSize";
            this.CEFontSize.Size = new System.Drawing.Size(86, 22);
            this.CEFontSize.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Size:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Style:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font:";
            // 
            // CEFontStyle
            // 
            this.CEFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEFontStyle.FormattingEnabled = true;
            this.CEFontStyle.Location = new System.Drawing.Point(77, 82);
            this.CEFontStyle.Name = "CEFontStyle";
            this.CEFontStyle.Size = new System.Drawing.Size(165, 22);
            this.CEFontStyle.TabIndex = 0;
            // 
            // CEFont
            // 
            this.CEFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CEFont.FormattingEnabled = true;
            this.CEFont.Location = new System.Drawing.Point(77, 21);
            this.CEFont.Name = "CEFont";
            this.CEFont.Size = new System.Drawing.Size(165, 22);
            this.CEFont.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(545, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 18;
            // 
            // StatusMsg
            // 
            this.StatusMsg.Name = "StatusMsg";
            this.StatusMsg.Size = new System.Drawing.Size(245, 17);
            this.StatusMsg.Text = "Some changes will take effect on next startup";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.IsSaveLayout);
            this.groupBox1.Controls.Add(this.IsBuildOutput);
            this.groupBox1.Controls.Add(this.IsProjectBrowser);
            this.groupBox1.Controls.Add(this.IsFileSearcher);
            this.groupBox1.Controls.Add(this.IsBrunchBrowser);
            this.groupBox1.Controls.Add(this.IsFileBrowser);
            this.groupBox1.Location = new System.Drawing.Point(6, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 221);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.CEFont);
            this.groupBox2.Controls.Add(this.CEFoldingMarker);
            this.groupBox2.Controls.Add(this.CEFontStyle);
            this.groupBox2.Controls.Add(this.CEIsLineHilighting);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.CEFontSize);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(5, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(439, 219);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // PreferenceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 284);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.SaveBt);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferenceDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences  ";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CEFontSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button SaveBt;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox IsSaveLayout;
        private System.Windows.Forms.CheckBox IsFileBrowser;
        private System.Windows.Forms.CheckBox IsBrunchBrowser;
        private System.Windows.Forms.CheckBox IsProjectBrowser;
        private System.Windows.Forms.CheckBox IsFileSearcher;
        private System.Windows.Forms.CheckBox IsBuildOutput;
        private System.Windows.Forms.NumericUpDown CEFontSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CEFont;
        private System.Windows.Forms.CheckBox CEIsLineHilighting;
        private System.Windows.Forms.ComboBox CEFoldingMarker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CEFontStyle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusMsg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}