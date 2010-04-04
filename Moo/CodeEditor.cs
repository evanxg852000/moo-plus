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

namespace Moo
{
    public partial class CodeEditor : DockContent
    {
       
        
        public CodeEditor(CodeEditorConfig CeConfg)
        {
            InitializeComponent();
            
            //settup this-> from CeConfg
        }
    }
}
