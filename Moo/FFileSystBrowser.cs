using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui.Dock;
using Moo.Core;

namespace Moo
{
    public partial class FFileSystBrowser : DockContent
    {
        public event OpenFileRequestHandler OpenSelectedFileRequested;

        public FFileSystBrowser()
        {
            InitializeComponent();
            FileBrowserTree.BuildNodes();
        }
        private void RefreshViev(object sender, EventArgs e)
        {
            this.FileBrowserTree.Refresh();
        }
        private void RequestOpenSelectedFile(string itemTag)
        {
            if (OpenSelectedFileRequested != null)
            {
                try
                {
                    OpenSelectedFileRequested(itemTag);
                }
                catch(Exception e)
                {
                    Exceptioner.Log(e);
                }
            }
        }
		   

    }
}
