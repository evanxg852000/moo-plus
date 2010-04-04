namespace Moo
{
    partial class CodeEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CodeEditor));
            this.EditorView = new ScintillaNet.Scintilla();
            ((System.ComponentModel.ISupportInitialize)(this.EditorView)).BeginInit();
            this.SuspendLayout();
            // 
            // EditorView
            // 
            this.EditorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorView.IsBraceMatching = true;
            this.EditorView.Location = new System.Drawing.Point(0, 0);
            this.EditorView.Margins.Margin0.IsFoldMargin = true;
            this.EditorView.Margins.Margin0.IsMarkerMargin = true;
            this.EditorView.Name = "EditorView";
            this.EditorView.Size = new System.Drawing.Size(475, 239);
            this.EditorView.Styles.BraceBad.FontName = "Verdana";
            this.EditorView.Styles.BraceLight.FontName = "Verdana";
            this.EditorView.Styles.ControlChar.FontName = "Verdana";
            this.EditorView.Styles.Default.FontName = "Verdana";
            this.EditorView.Styles.IndentGuide.FontName = "Verdana";
            this.EditorView.Styles.LastPredefined.FontName = "Verdana";
            this.EditorView.Styles.LineNumber.Bold = true;
            this.EditorView.Styles.LineNumber.FontName = "Verdana";
            this.EditorView.Styles.Max.FontName = "Verdana";
            this.EditorView.TabIndex = 0;
            // 
            // CodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 239);
            this.Controls.Add(this.EditorView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeEditor";
            this.TabText = "CodeEditor";
            this.Text = "CodeEditor";
            ((System.ComponentModel.ISupportInitialize)(this.EditorView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNet.Scintilla EditorView;
    }
}