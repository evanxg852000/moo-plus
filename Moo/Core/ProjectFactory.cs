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
        
        public static Project Create(string Profolder, string Proname, PType Protype)
        {
            Project PObject =new Project();
            string Profile = Profolder + @"\" + Proname + @"\" + Proname + ".mpr";
            Profolder = Profolder + @"\" + Proname;
            switch (Protype) {
                case PType.Adobeair:
                    PObject = new Adobeair();
                    break;
                case PType.Csharp:
                        PObject=new Csharp();
                    break;
                case PType.Databse:
                    PObject = new Databse();
                    break;
                case PType.Hydro:
                    PObject = new Hydro();
                    break;
                case PType.Ilasm:
                    PObject = new Ilasm();
                    break;
                case PType.Unmanaged:
                    PObject = new Unmanaged();
                    break;
                case PType.Vbasic:
                        PObject=new Vbasic();
                    break;
                case PType.Website:
                    PObject = new Website();
                    break;
                case PType.Yalamof:
                    PObject = new Yalamof();
                    break;       
            }
            try
            {
                Directory.CreateDirectory(Profolder);
                PObject.CopyTemplate();
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
