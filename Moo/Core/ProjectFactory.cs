using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.AccessControl;
using System.IO;
using Moo.Helpers;
using Moo.Core.Projects;

namespace Moo.Core
{
    class ProjectFactory
    {
        
        public static Project Create(string Profolder, string Proname, PType Protype, bool Inctemplate)
        {
            Project PObject ;
            Protype = PType.Adobeair;
            string Profile = Profolder + @"\" + Proname + @"\" + Proname + ".mpr";
            Profolder = Profolder + @"\" + Proname;
            switch (Protype) {
                case PType.Adobeair:
                    PObject = new Adobeair(Profile);
                    break;
                case PType.Csharp:
                    PObject = new Csharp(Profile);
                    break;
                case PType.Databse:
                    PObject = new Database(Profile);
                    break;
                case PType.Hydro:
                    PObject = new Hydro(Profile);
                    break;
                case PType.Ilasm:
                    PObject = new Ilasm(Profile);
                    break;
                case PType.Unmanaged:
                    PObject = new Unmanaged(Profile);
                    break;
                case PType.Vbasic:
                    PObject = new Vbasic(Profile);
                    break;
                case PType.Website:
                    PObject = new Website(Profile);
                    break;
                case PType.Yalamof:
                    PObject = new Yalamof(Profile);
                    break;    
                default:
                    PObject = new Unmanaged();
                    break;
            }
            try
            {
                Directory.CreateDirectory(Profolder);
                if (Inctemplate == true) 
                {
                    PObject.CopyTemplate();
                }         
                PObject.Save();
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
            }
            return PObject;
        }
        public static Project Open(string Profile)
        {
            Project PObject = new Project();
            try
            {
                using (FileStream fs = new FileStream(Profile, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    PObject = (Project)bf.Deserialize(fs);
                }
            }
            catch (Exception e)
            {
                Exceptioner.Log(e);
            }
            return PObject;
        }
     
    }
}
