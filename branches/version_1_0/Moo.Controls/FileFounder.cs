using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Moo.Controls
{
    public delegate void DeamonProgressChanged(int percentage);
    public delegate void DeamonWorkcompleted(RunWorkerCompletedEventArgs e);

    public partial class FileFounder : ListView
    {
        public event ItemSelectedHandler    ItemDoubleClicked;
        public event DeamonProgressChanged  SearchProgressChanged;
        public event DeamonWorkcompleted    SearchCompleted;

        private string searchfolder=@"C:\";
        private bool isrecurssive = false;
        private string searchterm = "*.*";
        private List<ListViewItem> li;

        public string SearchFolder
        {
            get { return searchfolder; }
            set { searchfolder = value; }
        }
        public bool IsRecurssive
        {
            get { return isrecurssive; }
            set { isrecurssive = value; }
        }
        public string SearchTerm
        {
            //get { }
            set { searchterm = value; }
        }
       
        public FileFounder()
        {
            InitializeComponent();
            li = new List<ListViewItem>();
            this.DoubleClick += new EventHandler(FileFounder_DoubleClick);
            this.DeamonSearcher.ProgressChanged += new ProgressChangedEventHandler(DeamonSearcher_ProgressChanged);
            this.DeamonSearcher.RunWorkerCompleted += new RunWorkerCompletedEventHandler(DeamonSearcher_RunWorkerCompleted);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
        public void SearchFile()
        {
            //start the deamon worker here
            //clear_content
            this.Items.Clear();
            this.li.Clear();
            DeamonSearcher.RunWorkerAsync();
        }      
        private void FileFounder_DoubleClick(object sender, EventArgs e)
        {
            if (this.SelectedItems.Count != 0)
            {
                if (ItemDoubleClicked != null)
                {
                    try
                    {
                        ItemDoubleClicked(this.SelectedItems[0].Tag.ToString());
                    }
                    catch
                    {
                        //do nothing
                    }
                }
            }
        }
        private void DeamonSearcher_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (ListViewItem item in this.li)
            {
                this.Items.Add(item);
            }
            if (SearchCompleted != null)
                {
                    try
                    {
                        SearchCompleted(e);
                    }
                    catch
                    {
                        //do nothing
                    }
                }
        }
        private void DeamonSearcher_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (SearchProgressChanged != null)
            {
                try
                {
                    SearchProgressChanged(e.ProgressPercentage);
                }
                catch
                {
                    //do nothing
                }
            }
        }
        private void DeamonSearcher_DoWork(object sender, DoWorkEventArgs e)
        {
            //search file and update
            if (this.searchterm != "*.*")
            { 
                this.searchterm="*"+this.searchterm+"*";
            }

            try { 
                DirectoryInfo di = new DirectoryInfo(this.SearchFolder);
                FileInfo[] files = di.GetFiles(this.searchterm, SearchOption.TopDirectoryOnly); 
                if(this.IsRecurssive)
                {
                     files= di.GetFiles(this.searchterm, SearchOption.AllDirectories);
                }
                foreach (FileInfo file in files)
                { 
                   
                    ListViewItem item = new ListViewItem(new string[] { file.Name, file.FullName, file.LastAccessTime.Date.ToString() });
                    item.Tag = file.FullName;
                    this.li.Add(item);
                }
            }
            catch
            {
                //keep quiet if something wrong happened
            }
        }
        
    
    }
}
