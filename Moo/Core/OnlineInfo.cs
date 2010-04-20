using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.ComponentModel;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;

namespace Moo.Core
{

    public struct Configuration
    {
        public string ModuleName;
        public string CodeName;
        public string Version;
        public string Author;
        public string AdminMail;
        public string HelpPage;
        public string Message;
    }
    public struct Update
    {
        public string Name;
        public string Link;
        public string TargetLocation;
    }
    public struct Plugin
    {
        public string Name;
        public string Link;
        public string Description;
    }

    public class OnlineInfo
    {
        private static OnlineInfo OnLineInfoIstance;
        private static string hosturl="www.evansofts.com";
        private static string configfileurl="http://evansofts.com/moo/moo-online-info.xml";
        private Configuration config;
        private List<Update> updates;
        private List<Plugin> plugins;
        public Configuration Config
        {
            get {return config ;}
            set { config=value;}
        }
        public List<Update> Updates
        {
            get {return updates ;}
            set { updates=value;}
        }
        public List<Plugin> Plugins
        {
            get { return plugins;}
            set { plugins=value;}
        }
       
        private  OnlineInfo()
        {
            this.updates = new List<Update>();
            this.plugins = new List<Plugin>();
            this.config.Author = "Evance Soumaoro";
            this.config.AdminMail = "evanxg852000@yahoo.fr";
            this.config.ModuleName = "Moo Plus";
            this.config.Version = Assembly.GetExecutingAssembly().GetName().Version.ToString();
            this.config.CodeName = "Regeneration-X";
        }
        private void ParseInfo()
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(OnlineInfo.configfileurl);
                while (reader.Read())
                {
                    switch (reader.Name)
                    {
                        case "configuration":
                            XmlReader configurationreader = reader.ReadSubtree();
                            while (configurationreader.Read())
                            {
                                switch (configurationreader.Name)
                                {
                                    case "modulename":
                                        this.config.ModuleName = configurationreader.ReadString();
                                        break;
                                    case "codename":
                                        this.config.CodeName = configurationreader.ReadString();
                                        break;
                                    case "version":
                                        this.config.Version = configurationreader.ReadString();
                                        break;
                                    case "author":
                                        this.config.Author = configurationreader.ReadString();
                                        break;
                                    case "adminmail":
                                        this.config.AdminMail = configurationreader.ReadString();
                                        break;
                                    case "helppage":
                                        this.config.HelpPage = configurationreader.ReadString();
                                        break;
                                    case "message":
                                        this.config.Message = configurationreader.ReadString();
                                        break;
                                }
                            }
                            break;
                        case "updates":
                            XmlReader updatereader = reader.ReadSubtree();
                            while (updatereader.Read())
                            {
                                if(updatereader.Name=="update")
                                {
                                    XmlReader updatesubreader = updatereader.ReadSubtree(); 
                                    Update updateItem = new Update();
                                    while (updatesubreader.Read())
                                    {
                                        switch (updatesubreader.Name)
                                        {
                                            case "name":
                                                updateItem.Name = updatesubreader.ReadString();
                                                break;
                                            case "link":
                                                updateItem.Link = updatesubreader.ReadString();
                                                break;
                                            case "targetlocation":
                                                updateItem.TargetLocation = updatesubreader.ReadString();
                                                break;
                                        }   
                                    }
                                    if (updateItem.Name != null)
                                    {
                                        this.Updates.Add(updateItem);
                                    }
                                }   
                            }
                            break;
                        case "plugins":
                            XmlReader pluginreader = reader.ReadSubtree();
                            while (pluginreader.Read())
                            {
                                if (pluginreader.Name == "plugin")
                                {
                                    XmlReader pluginsubreader = pluginreader.ReadSubtree();
                                    Plugin pluginItem = new Plugin();
                                    while (pluginsubreader.Read())
                                    {
                                        switch (pluginsubreader.Name)
                                        {
                                            case "name":
                                                pluginItem.Name = pluginsubreader.ReadString();
                                                break;
                                            case "link":
                                                pluginItem.Link = pluginsubreader.ReadString();
                                                break;
                                            case "description":
                                                pluginItem.Description = pluginsubreader.ReadString();
                                                break;
                                        }  
                                    }
                                    if (pluginItem.Name != null)
                                    {
                                        this.Plugins.Add(pluginItem);
                                    } 
                                }
                            }
                            break;
                    }
                }
            }
            catch { /* do nothing */}
        }

        public static void CheckOutForUpdate()
        {
            if (OnLineInfoIstance==null)
            {
                OnLineInfoIstance = new OnlineInfo();
            }
            //call the parse methode to fill the object of online info
            OnLineInfoIstance.ParseInfo(); 
        }
        public static OnlineInfo GetInstance()
        {
            return OnlineInfo.OnLineInfoIstance;
        }
        public static bool IsInternet()
        {
            Ping PingObject = new Ping();
            try
            {
                PingReply result = PingObject.Send(OnlineInfo.hosturl, 3000);
                if (result.Status == IPStatus.Success)
                    return true;
            }
            catch (Exception e) { e.ToString(); /*do nothing*/  }
            return false;
        }
      
       


    }
}
