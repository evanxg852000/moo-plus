using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Yalamo.Gui.Dock;
using Moo.Helpers;
using Moo.Core;

namespace Moo
{
    public partial class FBrunchBrowser : DockContent
    {
        public event InsertBrunchRequestHandler InsertSelectedBrunchNodeRequested;
        
        //provide data to the main window to instanciate brunch editor from main menu
        public DataSet BrunchDataStructure {
            get { return this.BrunchBrowserTree.BrunchDataStructure; }
        }
        
        public FBrunchBrowser(){
            InitializeComponent();
            this.BrunchBrowserTree.Refresh();
        }
        
        //this will be called when user edit brunch and click apply 
        public void UpdateData(DataSet NewBrunchDataStructure){
            this.BrunchBrowserTree.BrunchDataStructure = NewBrunchDataStructure;
            this.BrunchBrowserTree.Refresh();
        }

        private void RefreshView(object sender, EventArgs e)
        {
            this.BrunchBrowserTree.Refresh();
        }
        private void NewBrunch(object sender, EventArgs e){
            Moo.Dialogs.BrunchEditorDialog.Show(this.BrunchBrowserTree.BrunchDataStructure);
        }
        private void BrunchEditor(object sender, EventArgs e){
            Moo.Dialogs.BrunchEditorDialog.Show(this.BrunchBrowserTree.BrunchDataStructure);
        }
        
        private void RequestInsertSelectedBrunchNode(string itemTag)
        {
            if (InsertSelectedBrunchNodeRequested != null)
            {
                try
                {
                    InsertSelectedBrunchNodeRequested(itemTag);
                }
                catch(Exception e)
                {
                    Exceptioner.Log(e);
                }
            }
        }
        

        

        
   
    }
    
}
