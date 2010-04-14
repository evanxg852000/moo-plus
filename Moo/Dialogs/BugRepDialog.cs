using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;

namespace Moo.Dialogs
{
    public partial class BugRepDialog : Form
    {
        public BugRepDialog()
        {
            InitializeComponent();
        }
        public static new void Show()
        {
            BugRepDialog Instance = new BugRepDialog();
            Instance.ShowDialog();
        }
        private void SendReport(object sender, EventArgs e)
        {
            if (Exceptioner.SendLog(BugContentTx.Text, AttachLogCkbx.Checked))
                BugContentTx.Text = "Report Sended Successfully !";
            else
                BugContentTx.Text = "Some Errors ocurrs , please try it later ";
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
