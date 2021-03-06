﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moo.Core;
using ScintillaNet;
using System.Drawing;
using System.Diagnostics;

namespace Moo
{
    class LexerInitializer
    {

  #region Config Style
        private const int EOL = -1;
        //Margings Indexes
        private const int LINENUMBER_MARGIN= 0;
        private const int MARKER_MARGIN = 1;
        private const int FOLD_MARGIN = 2;

        // SciLexer's weird choice for a default style index
        private const int DEFAULT_STYLE = 32;
        private const int STYLE_LINENUMBER = 33;


        // Our custom styles (indexes chosen not to conflict with anything else)
        private const int KEY_STYLE = 11;
        private const int VALUE_STYLE = 12;
        private const int ASSIGNMENT_STYLE = 13;
        private const int SECTION_STYLE = 14;
        private const int COMMENT_STYLE = 15;
        private const int QUOTED_STYLE = 16;

        public static void Init(Scintilla scintilla)
        {
            // Reset any current language and enable the StyleNeeded
            // event by setting the lexer to container.
            scintilla.Indentation.SmartIndentType = SmartIndent.None;
            scintilla.ConfigurationManager.Language = String.Empty;
            scintilla.Lexing.LexerName = "container";
            scintilla.Lexing.Lexer = Lexer.Container;

            // Add our custom styles to the collection
            scintilla.Styles[QUOTED_STYLE].ForeColor = Color.FromArgb(153, 51, 51);
            scintilla.Styles[KEY_STYLE].ForeColor = Color.FromArgb(0, 0, 153);
            scintilla.Styles[ASSIGNMENT_STYLE].ForeColor = Color.OrangeRed;
            scintilla.Styles[VALUE_STYLE].ForeColor = Color.FromArgb(102, 0, 102);
            scintilla.Styles[COMMENT_STYLE].ForeColor = Color.FromArgb(102, 102, 102);
            scintilla.Styles[SECTION_STYLE].ForeColor = Color.FromArgb(0, 0, 102);
            scintilla.Styles[SECTION_STYLE].Bold = true;
        }
        public static void StyleNeeded(Scintilla scintilla, Range range)
        {
            // Create an instance of our lexer and bada-bing the line!
            LexerInitializer lexer = new LexerInitializer(scintilla, range.Start, range.StartingLine.Length);
            lexer.Style();
        }     
        public static void ApplyUserStyle(Scintilla scintilla,CodeEditorConfig codeeditorcong )//apply custom style
        {
            Font userFont = new Font(codeeditorcong.Font, codeeditorcong.FontSize, codeeditorcong.FontStyle, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            //config-style line marging 
            scintilla.Styles[STYLE_LINENUMBER].BackColor = Color.White;
            scintilla.Styles[STYLE_LINENUMBER].ForeColor = Color.DarkTurquoise;
            scintilla.Styles[STYLE_LINENUMBER].Bold = true;
           
            //apply user configuration
            scintilla.UseFont = true;
            scintilla.Font = userFont;
            scintilla.Styles[STYLE_LINENUMBER].Size =(float)codeeditorcong.FontSize;

            int Ratio = (int)codeeditorcong.FontSize;
            scintilla.Margins[LINENUMBER_MARGIN].Width = Ratio * scintilla.Lines.Count.ToString().Length + 4;

            

            scintilla.Folding.MarkerScheme = codeeditorcong.FoldingMarker;
            scintilla.Caret.HighlightCurrentLine = codeeditorcong.IsLineHilighting;
        }
  #endregion

        private Scintilla scintilla;
        private int startPos;
        private int index;
        private string text;

        
        private LexerInitializer (Scintilla scintilla, int startPos, int length)
		{
			this.scintilla = scintilla;
			this.startPos = startPos;
			// One line of text
			this.text = scintilla.GetRange(startPos, startPos + length).Text;
		}
        public void Style()
        {
            // TODO Still using the old API
            // Signals that we're going to begin styling from this point.
            ((INativeScintilla)scintilla).StartStyling(startPos, 0x1F);

            // Run our humble lexer...
            StyleWhitespace();            
            switch (Read())
            {
                case '[':

                    // Section, default, comment
                    StyleUntilMatch(SECTION_STYLE, new char[] { ']' });
                    StyleCh(SECTION_STYLE);
                    StyleUntilMatch(DEFAULT_STYLE, new char[] { ';' });
                    goto case ';';

                case ';':

                    // Comment
                    SetStyle(COMMENT_STYLE, text.Length - index);
                    break;

                default:

                    // Key, assignment, quote, value, comment
                    StyleUntilMatch(KEY_STYLE, new char[] { '=', ';' });
                    switch (Read())
                    {
                        case '=':

                            // Assignment, quote, value, comment
                            StyleCh(ASSIGNMENT_STYLE);
                            switch (Read())
                            {
                                case '"':

                                    // Quote
                                    StyleCh(QUOTED_STYLE);  // '"'
                                    StyleUntilMatch(QUOTED_STYLE, new char[] { '"' });

                                    // Make sure it wasn't an escaped quote
                                    if (index > 0 && index < text.Length && text[index - 1] == '\\')
                                        goto case '"';

                                    StyleCh(QUOTED_STYLE); // '"'
                                    goto default;

                                default:

                                    // Value, comment
                                    StyleUntilMatch(VALUE_STYLE, new char[] { ';' });
                                    SetStyle(COMMENT_STYLE, text.Length - index);
                                    break;
                            }
                            break;

                        default: // ';', EOL

                            // Comment
                            SetStyle(COMMENT_STYLE, text.Length - index);
                            break;
                    }
                    break;
            }
        }
        private int Read()
        {
            if (index < text.Length)
                return text[index];

            return EOL;
        }
        private void SetStyle(int style, int length)
        {
            if (length > 0)
            {
                // TODO Still using old API
                // This will style the length of chars and advance the style pointer.
                ((INativeScintilla)scintilla).SetStyling(length, style);
            }
        }
        private void StyleCh(int style)
        {
            // Style just one char and advance
            SetStyle(style, 1);
            index++;
        }
        private void StyleUntilMatch(int style, char[] chars)
        {
            // Advance until we match a char in the array
            int startIndex = index;
            while (index < text.Length && Array.IndexOf<char>(chars, text[index]) < 0)
                index++;

            if (startIndex != index)
                SetStyle(style, index - startIndex);
        }
        private void StyleWhitespace()
        {
            // Advance the index until non-whitespace character
            int startIndex = index;
            while (index < text.Length && Char.IsWhiteSpace(text[index]))
                index++;

            SetStyle(DEFAULT_STYLE, index - startIndex);
        }
    
        
    }
}
