using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Moo.Core;
using Moo.Helpers;
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
            set { filepath = value; filename = Path.GetFileName(value); }
        }
        public string FileName
        {
            get { return filename; }
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
 
        public CodeEditor(CodeEditorConfig codeeditorconfg,string filepath)
        {
            InitializeComponent();
            Userconfig = codeeditorconfg;
            this.FilePath = filepath;
            this.Text = filepath;
            this.TabText = this.FileName;
            
        }

        //code edition
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
                this.EditorView.ConfigurationManager.Language = language;

                // Smart indenting...
                if ("cs".Equals(language, StringComparison.OrdinalIgnoreCase))
                    this.EditorView.Indentation.SmartIndentType = SmartIndent.CPP;
                else
                    this.EditorView.Indentation.SmartIndentType = SmartIndent.None;
            }
            //apply userconfig
            LexerInitializer.ApplyUserStyle(EditorView, this.Userconfig);

        }
        public void ShowSnippet()
        {
            this.EditorView.Snippets.ShowSnippetList();
        }
        public void SurroundWithSnippet()
        {
            this.EditorView.Snippets.ShowSurroundWithList();
        }
        
        //edit methods
        public void UndoAction()
        {
            this.EditorView.Commands.Execute(BindableCommand.Undo);
        }
        public void RedoAction()
        {
            this.EditorView.Commands.Execute(BindableCommand.Redo);
        }
        public void Cut()
        {
            this.EditorView.Clipboard.Cut();
        }
        public void Copy()
        {
            this.EditorView.Clipboard.Copy();
        }
        public void Paste()
        {
            this.EditorView.Clipboard.Paste();
        }
        public void Delete()
        {   
            this.EditorView.Commands.Execute(BindableCommand.DeleteBackNotLine);
        }
        public void SelectAll()
        {
            this.EditorView.Commands.Execute(BindableCommand.SelectAll);
        }
        public void CommentLine()
        { 
            this.EditorView.Commands.Execute(BindableCommand.LineComment);
        }
        public void UnCommentLine()
        {
            this.EditorView.Commands.Execute(BindableCommand.LineUncomment); 
        }
        public void CommentStream()
        {
            this.EditorView.Commands.Execute(BindableCommand.StreamComment);
        }    
        public void ToUpperCase()
        {
            this.EditorView.Commands.Execute(BindableCommand.UpperCase);
        }
        public void ToLowerCase()
        {
            this.EditorView.Commands.Execute(BindableCommand.LowerCase);
        }
        public void Insert(string s)
        {
            this.EditorView.InsertText(s);
        }
        public void InsertCodeBrunch(string codebrunchcontent)
        {
            Insert(codebrunchcontent);
        }
        public void InsertCodeSummary()
        {
            string s = "/// <summary> \n/// \n/// </summary> \n/// <param name=\"ParamName\" ></param>";         
            Insert(s);
        }
        //view methods
        public void ShowWhiteSpace(bool isShown)
        {
            if (isShown)
            {
                this.EditorView.Whitespace.Mode = WhitespaceMode.VisibleAlways;
            }
            else 
            {
                this.EditorView.Whitespace.Mode = WhitespaceMode.Invisible;
            }
        }
        public void ShowEndOfLine(bool isShown)
        {
            this.EditorView.EndOfLine.IsVisible=isShown;
        }
        public void ShowLineNubers(bool isShown)
        {
            if (isShown)
            {
                this.EditorView.Margins[0].Width=0;
            }
            else
            {
                this.EditorView.Margins[0].Width=this.LineMarginWidth;
            }
            
        }
        public void FoldAll()
        {
            foreach (Line l in this.EditorView.Lines) 
            {
                l.FoldExpanded = true;
            }
        }
        public void UnFoldAll()
        {
            foreach (Line l in this.EditorView.Lines)
            {
                l.FoldExpanded = false;
            }
        }

        //navigation methods
        public void Search()
        {
            this.EditorView.FindReplace.ShowFind();
        }
        public void Replace()
        {
            this.EditorView.FindReplace.ShowReplace();
        }
        public void FindNext()
        {
            this.EditorView.Commands.Execute(BindableCommand.FindNext);
        }
        public void FindPrevious()
        {
            this.EditorView.Commands.Execute(BindableCommand.FindPrevious);
        }
        public void GotoLine()
        {
            this.EditorView.GoTo.ShowGoToDialog();
        }

        //print methods
        public void PageSetup()
        {
            this.EditorView.Printing.ShowPageSetupDialog();
        }
        public void Print()
        {
            this.EditorView.Printing.Print();
        }
        public void PrintPreview()
        {  
            this.EditorView.Printing.PrintPreview();
            
        }
        
        //zoom methods
        public void ZoomIn()
        {
            this.EditorView.Zoom++;
        }
        public void ZoomOut()
        {
            this.EditorView.Zoom-- ;    
        }
        public void ResetZoom()
        {
            this.EditorView.Zoom = 0;
        }
           
        //saving methods
        public bool Save()
        {
            return FileHelper.Save(this.filepath, this.EditorView.Text);
        }
        public bool SaveAs()
        {
            string filter="Text File|*.txt|Html File|*.html|*.ini|Xml File|*.xml|Dopa File|*.dpa";
            string lastworkingdir = @"C:\";
            return FileHelper.SaveAs(this.EditorView.Text, filter, lastworkingdir);
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
            //update the title to notify that the doc has changed
            if (!this.TabText.EndsWith(" *"))
               TabText += " *";     
        }
        private void EditorView_StyleNeeded(object sender, StyleNeededEventArgs e)
        {
            if (iscustomelexerinit)
                LexerInitializer.StyleNeeded((Scintilla)sender, e.Range);
        }
        private void CloseSafely(object sender, FormClosingEventArgs e)
        {
            if(this.EditorView.Modified)
            {
                this.Save();
                // Prompt if not saved
                string message =String.Format( "The text in the {0} has changed.{1} Do you want to save the changes?",this.FileName,Environment.NewLine);
                DialogResult dr = MessageBox.Show(this, message,"Moo { + }", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (dr == DialogResult.Cancel)
                {
                    // Stop closing
                    e.Cancel = true;
                    return;
                }
                else if (dr == DialogResult.Yes)
                {
                    // Try to save before closing
                    e.Cancel = !this.Save();
                    return;
                }
            }
        }
    #endregion

        



    }
}
