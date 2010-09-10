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
using Yalamo.Gui.Dock;
using ScintillaNet;

namespace Moo
{
   
    public delegate void CaretPositionHandler(int line, int col);

    public partial class CodeEditor : DockContent
    {
        
        public event CaretPositionHandler CaretPositionChanged;
        private int LineMarginWidth = 20;
        private string filepath;
        private string filename;
        private bool iscustomelexerinit;       // Indicates that calls to the StyleNeeded event should use the custom INI lexer
        private CodeEditorConfig Userconfig;
        private ImageList CompletionImages;

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
            CompletionImages = new ImageList();
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Keyword_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Namespace_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Class_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Structure_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Method_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Event_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Function_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Constant_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Enum_icon);
            CompletionImages.Images.Add(global::Moo.Properties.Resources.Var_icon);
            this.EditorView.AutoComplete.RegisterImages(CompletionImages,Color.Black);
            //this.EditorView.AutoComplete.

            Userconfig = codeeditorconfg;
            this.FilePath = filepath;
            this.Text = filepath;
            this.TabText = this.FileName;
        }

        //code edition
        public void SetContent(string content)
        { 
            this.EditorView.Text = content;
            this.EditorView.Modified=false;
            if (this.TabText.EndsWith(" *"))
                this.TabText = this.TabText.Substring(0, this.TabText.Length - 2);
        }
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
        public void SetEncoding(string enc)
        {
            //juste keep it for now
            //this.EditorView.Encoding.EncodingName = enc; 
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
            if (FileHelper.Save(this.filepath, this.EditorView.Text))
            {
                //update the editor
                this.EditorView.Modified = false;
                if (this.TabText.EndsWith(" *"))
                    this.TabText = this.TabText.Substring(0, this.TabText.Length - 2);
                return true;
            }
            return false;  
        }
        public bool SaveAs()
        {
            string filter="Text file (*.txt)|*.txt|Html file ((*.html))|*.html|Xml file(*.xml)|*.xml|All files (*.*)|*.*";
            string newfilepath;
            string newfilename;
            if( FileHelper.SaveAs(this.EditorView.Text, filter,out newfilepath,out newfilename) )
            {
                //update the editor
                this.filepath=newfilepath;
                this.filename = newfilename;
                this.TabText = newfilename;
                this.EditorView.Modified = false;
                this.SetLanguage(Path.GetExtension(filepath));
                if (this.TabText.EndsWith(" *"))
                    this.TabText = this.TabText.Substring(0, this.TabText.Length - 2);
                return true;
            }
            return false;
        }
        public bool Reload()
        {
            this.EditorView.Text = FileHelper.GetContent(this.FilePath);
            this.EditorView.Modified = false;
            if (this.TabText.EndsWith(" *"))
                this.TabText = this.TabText.Substring(0, this.TabText.Length - 2);
            if(this.EditorView.Text!=String.Empty) 
            return true ;
            else 
            return false;
        }


    #region EditorView Event Handlers
        private void EditorView_DocumentChange(object sender, NativeScintillaEventArgs e)
        {
            //update line marging to suit the content
            const int LINENUMBER_MARGIN=0;
            const int STYLE_LINENUMBER = 33;
            int Ratio = (int)this.EditorView.Styles[STYLE_LINENUMBER].Size;

            if (LineMarginWidth < Ratio * this.EditorView.Lines.Count.ToString().Length)
            {
                this.LineMarginWidth = Ratio * this.EditorView.Lines.Count.ToString().Length;
                this.EditorView.Margins[LINENUMBER_MARGIN].Width = this.LineMarginWidth;    
            }
            //update the title to notify that the doc has changed
            if (this.EditorView.Modified)
            {
                if (!this.TabText.EndsWith(" *"))
                    TabText += " *";
            }
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
                // Prompt if not saved
                string message =String.Format( "The text in {0} has changed.{1} Do you want to save the changes?",this.FileName,Environment.NewLine);
                DialogResult dr = MessageBox.Show(this, message,"Moo { + }", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
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
        private void CaretPositionChangedEmiter(object sender, EventArgs e)
        {
            //fire the event
            if (CaretPositionChanged != null)
            {
                try
                {
                    CaretPositionChanged(this.EditorView.Caret.LineNumber, this.EditorView.Caret.Position);
                }
                catch(Exception ex)
                {
                    Exceptioner.Log(ex);
                }
            }
        }
    #endregion

    
    }
}
