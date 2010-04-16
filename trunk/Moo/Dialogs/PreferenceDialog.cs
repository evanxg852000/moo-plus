using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Moo.Core;
using ScintillaNet;

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
           //start setting up the ui based on current config
            this.IsSaveLayout.Checked = this.AppSettings.IsSaveLayout;
            this.IsProjectBrowser.Checked = this.AppSettings.IsProjectBrowser;
            this.IsBrunchBrowser.Checked = this.AppSettings.IsBrunchBrowser;
            this.IsFileBrowser.Checked = this.AppSettings.IsFileBrowser;
            this.IsFileSearcher.Checked = this.AppSettings.IsFileSearcher;
            this.IsBuildOutput.Checked = this.AppSettings.IsBuildOutput;
           
            //font
            InstalledFontCollection fonts = new InstalledFontCollection();
            for(int i=0; i< fonts.Families.Length; i++)
            {
                this.CEFont.Items.Add(fonts.Families[i].Name);   
            }
            this.CEFont.SelectedItem = AppSettings.EditorConfig.Font;
            //font style
            this.CEFontStyle.Items.Add(FontStyle.Regular);
            this.CEFontStyle.Items.Add(FontStyle.Bold);
            this.CEFontStyle.Items.Add(FontStyle.Italic);
            this.CEFontStyle.SelectedItem = AppSettings.EditorConfig.FontStyle;
            //fontsize
            this.CEFontSize.Value = AppSettings.EditorConfig.FontSize;
            //folding
            this.CEFoldingMarker.Items.Add(FoldMarkerScheme.Arrow);
            this.CEFoldingMarker.Items.Add(FoldMarkerScheme.BoxPlusMinus);
            this.CEFoldingMarker.Items.Add(FoldMarkerScheme.CirclePlusMinus);
            this.CEFoldingMarker.Items.Add(FoldMarkerScheme.PlusMinus);
            this.CEFoldingMarker.SelectedItem=AppSettings.EditorConfig.FoldingMarker;
            //line hilighting
            this.CEIsLineHilighting.Checked = AppSettings.EditorConfig.IsLineHilighting;   
        }      
        public static void Show(AppSettings appsettings)
        {
            if (PreferenceDialog.Instance == null)
            {
                Instance = new PreferenceDialog(appsettings);
            }
            Instance.ShowDialog();
        }
        private void SaveEditedSettings(object sender, EventArgs e)
        {
            this.AppSettings.IsSaveLayout= this.IsSaveLayout.Checked;
            this.AppSettings.IsProjectBrowser = this.IsProjectBrowser.Checked  ;
            this.AppSettings.IsBrunchBrowser = this.IsBrunchBrowser.Checked ;
            this.IsFileBrowser.Checked = this.AppSettings.IsFileBrowser;
            this.AppSettings.IsFileSearcher = this.IsFileSearcher.Checked;
            this.AppSettings.IsBuildOutput = this.IsBuildOutput.Checked;
            this.AppSettings.EditorConfig.Font = this.CEFont.SelectedItem.ToString() ;
            this.AppSettings.EditorConfig.FontStyle =(FontStyle) this.CEFontStyle.SelectedItem ;
            this.AppSettings.EditorConfig.FontSize =(int) this.CEFontSize.Value ;
            this.AppSettings.EditorConfig.FoldingMarker = (FoldMarkerScheme)this.CEFoldingMarker.SelectedItem ;
            this.AppSettings.EditorConfig.IsLineHilighting =  this.CEIsLineHilighting.Checked ;
            // don't need to persist here ->( AppSettings.Save(this.AppSettings))
            //because  it will be saved when the application is shutting down
        }

    }
}
