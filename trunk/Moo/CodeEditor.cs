using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using WeifenLuo.WinFormsUI.Docking;
using ScintillaNet;

namespace Moo
{
    public partial class CodeEditor : DockContent
    {
        private int LineMarginWidth = 20;
        private string filepath;
        private string filename;
        private bool iscustomelexerinit;       // Indicates that calls to the StyleNeeded event should use the custom INI lexer
        private CodeEditorConfig Userconfig; 

        public string FilePath
        {
            get { return filepath; }
            set { filepath = value; }
        }
        public string FileName
        {
            get { return filename; }
            set { filename= value; }
        }
        public Scintilla EdiorViewObject
        {
            get {return EditorView; }
        }
        public bool IsCustomeLexerInit
        {
            get { return iscustomelexerinit; }
            set { iscustomelexerinit = value; }
        }
  
        
        public CodeEditor(CodeEditorConfig codeeditorconfg)
        {
            InitializeComponent();
            Userconfig = codeeditorconfg;    
        }
      
        

    #region EditorView Event Handlers
        private void EditorView_DocumentChange(object sender, NativeScintillaEventArgs e)
        {
            //update line marging to suit the content
            const int LINENUMBER_MARGIN=0;
            if (LineMarginWidth < 10*this.EditorView.Lines.Count.ToString().Length)
            {
                this.LineMarginWidth = 10*this.EditorView.Lines.Count.ToString().Length;
                this.EditorView.Margins[LINENUMBER_MARGIN].Width = this.LineMarginWidth;    
            }
        }
        private void EditorView_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            if (iscustomelexerinit)
                LexerInitializer.StyleNeeded((Scintilla)sender, e.Range);
        }
        private void EditorView_ModifiedChanged(object sender, EventArgs e)
        {
            if (this.EditorView.Modified)
            {
                if (!this.Text.EndsWith(" *"))
                    Text += " *";
            }
            else
            {
                if (this.Text.EndsWith(" *"))
                    Text = Text.Substring(0, Text.Length - 2);
            }
        }
    #endregion

        public void SetLanguage(string language)
        {
            if ("ini".Equals(language, StringComparison.OrdinalIgnoreCase))
            {
                // Reset/set all styles and prepare scintilla for custom lexing
                this.IsCustomeLexerInit = true;
                LexerInitializer.Init(this.EditorView);
            }
            else
            {
                // Use a built-in lexer and configuration
                this.IsCustomeLexerInit = false;
                this.EditorView.ConfigurationManager.Language=language;

                // Smart indenting...
                if ("cs".Equals(language, StringComparison.OrdinalIgnoreCase))
                    this.EditorView.Indentation.SmartIndentType = SmartIndent.CPP;
                else
                    this.EditorView.Indentation.SmartIndentType = SmartIndent.None;
            }
            //apply userconfig
            LexerInitializer.ApplyUserStyle(EditorView, this.Userconfig);
           
        }

       

    }
}
