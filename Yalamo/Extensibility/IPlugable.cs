using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yalamo.Gui.Dock;

namespace Yalamo.Extensibility
{
     //each plugin must implement IPlugable 

    //this class hold the properties of a plugin
    public class PluginProperties
    {   
        private string name;
        private string author;
        private string description; 
        private string website;
        private string version;
        public string Name { get { return name; } }
        public string Author { get { return author; } }
        public string Description { get { return description; } }
        public string Website { get { return website; } }
        public string Version { get { return version; } }

        public PluginProperties(string name, string author, string description, string website, string version)
        {
            this.name = name;
            this.author = author;
            this.description = description;
            this.website = website;
            this.version = version;
        }
    }
    //the plugin interface  
    public interface IPlugable
    {
        DockContent Main();         //return the Mainpanel of the plugin
        Image Icon();               //return the image of the plugin
        DockContent Toolbox();      //return the Tolbox of the plugin
        PluginProperties About();   //return the plugin properties Object
    }

}
