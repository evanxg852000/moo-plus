using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Moo
{
    public partial class FFileSystBrowser : DockContent
    {
        public FFileSystBrowser()
        {
            InitializeComponent();
            FileBrowserTree.BuildNodes();
        }
    }
}
