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
            this.EditorView.Caret.CurrentLineBackgroundColor = System.Drawing.Color.Lavender;
            this.EditorView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorView.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditorView.IsBraceMatching = true;
            this.EditorView.LineWrap.VisualFlags = ScintillaNet.WrapVisualFlag.End;
            this.EditorView.Location = new System.Drawing.Point(0, 0);
            this.EditorView.Margins.Margin0.Width = 20;
            this.EditorView.Margins.Margin1.IsClickable = true;
            this.EditorView.Margins.Margin1.Width = 10;
            this.EditorView.Margins.Margin2.Width = 16;
            this.EditorView.Name = "EditorView";
            this.EditorView.Size = new System.Drawing.Size(475, 239);
            this.EditorView.Styles.BraceBad.FontName = "Verdana";
            this.EditorView.Styles.BraceBad.Size = 9F;
            this.EditorView.Styles.BraceLight.FontName = "Verdana";
            this.EditorView.Styles.BraceLight.Size = 9F;
            this.EditorView.Styles.ControlChar.BackColor = System.Drawing.Color.White;
            this.EditorView.Styles.ControlChar.Bold = true;
            this.EditorView.Styles.ControlChar.CharacterSet = ScintillaNet.CharacterSet.Ansi;
            this.EditorView.Styles.ControlChar.FontName = "Consolas";
            this.EditorView.Styles.ControlChar.Size = 8.25F;
            this.EditorView.Styles.Default.FontName = "Verdana";
            this.EditorView.Styles.Default.Size = 9F;
            this.EditorView.Styles.IndentGuide.FontName = "Verdana";
            this.EditorView.Styles.IndentGuide.Size = 9F;
            this.EditorView.Styles.LastPredefined.FontName = "Verdana";
            this.EditorView.Styles.LastPredefined.Size = 9F;
            this.EditorView.Styles.LineNumber.Bold = true;
            this.EditorView.Styles.LineNumber.FontName = "Consolas";
            this.EditorView.Styles.LineNumber.ForeColor = System.Drawing.Color.Black;
            this.EditorView.Styles.LineNumber.Size = 8.25F;
            this.EditorView.Styles.Max.FontName = "Verdana";
            this.EditorView.Styles.Max.Size = 9F;
            this.EditorView.TabIndex = 0;
            this.EditorView.TextChanged += new System.EventHandler<System.EventArgs>(this.CaretPositionChangedEmiter);
            this.EditorView.StyleNeeded += new System.EventHandler<ScintillaNet.StyleNeededEventArgs>(this.EditorView_StyleNeeded);
            this.EditorView.DocumentChange += new System.EventHandler<ScintillaNet.NativeScintillaEventArgs>(this.EditorView_DocumentChange);
            // 
            // CodeEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 239);
            this.Controls.Add(this.EditorView);
            this.DockAreas = Yalamo.Gui.Dock.DockAreas.Document;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CodeEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseSafely);
            ((System.ComponentModel.ISupportInitialize)(this.EditorView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ScintillaNet.Scintilla EditorView;
    }
}