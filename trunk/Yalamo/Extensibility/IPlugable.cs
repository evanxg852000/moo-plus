using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yalamo.Gui.Dock;

namespace Yalamo.Extensibility
{
     //each plugin must implement IPlugable 
    public interface IPlugable
    {
        DockContent Main();         
        Bitmap Icon();               
        DockContent Toolbox();                    
    }

    //each plugin must inherit PluginBase 
    public class PluginBase {
        protected string name;
        protected string author;
        protected string description;
        protected string website;
        protected string version;
        public string Name { get { return name; } }
        public string Author { get { return author; } }
        public string Description { get { return description; } }
        public string Website { get { return website; } }
        public string Version { get { return version; } }

        public PluginBase() 
        {
            this.name = String.Empty;
            this.author = String.Empty;
            this.description = String.Empty;
            this.website = String.Empty;
            this.version = String.Empty;     
        }       
        public void About()
        {
            IPAbout.ShowAboutPlugin(this.Name,this.author,this.description,this.website,this.version);
        } 
    
    }

}
