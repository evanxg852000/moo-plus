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
    public partial class PreferenceDialog : Form
    {
        private static PreferenceDialog Instance;
        private AppSettings AppSettings;

        private PreferenceDialog(AppSettings appsettings)
        {
            InitializeComponent();
            this.AppSettings = appsettings;
        }     
        public static void Show(AppSettings appsettings)
        {
            if (PreferenceDialog.Instance == null)
            {
                Instance = new PreferenceDialog(appsettings);
            }
            Instance.ShowDialog();
        }



    }
}
