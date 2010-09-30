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
            this.BrunchBrowserTree.UpdateData(NewBrunchDataStructure);
            this.BrunchBrowserTree.Refresh();
        }
        public Dictionary<string, string> GetBrunchDictionary(string brunchtype)
        {
           return this.BrunchBrowserTree.GetBrunchDictionary(brunchtype);
        }


        private void RefreshView(object sender, EventArgs e)
        {
            this.BrunchBrowserTree.Refresh();
        }
        private void BrunchEditor(object sender, EventArgs e){
            Moo.Dialogs.BrunchEditorDialog BEditorInstance = new Moo.Dialogs.BrunchEditorDialog (this.BrunchDataStructure);
            if (BEditorInstance.ShowDialog() == DialogResult.OK)
            {
               this.UpdateData(BEditorInstance.BrunchDataStructure);
            }
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
        private void InsertBrunchHandler(object sender, EventArgs e)
        {
            if (this.BrunchBrowserTree.SelectedNode == null) { return; }
            if(this.BrunchBrowserTree.SelectedNode.Level==2)
            {
                if (InsertSelectedBrunchNodeRequested != null)
                {
                    try
                    {
                        InsertSelectedBrunchNodeRequested(this.BrunchBrowserTree.SelectedNode.Tag.ToString());
                    }
                    catch (Exception ex)
                    {
                        Exceptioner.Log(ex);
                    }
                }
            
            }
            
        }
        

        

        
   
    }
    
}
