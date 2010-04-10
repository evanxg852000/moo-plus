using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Moo.Core;

namespace Moo.Helpers
{
    class MiscHelper
    {
        public static ProjectCategory GetProjectType(string type)
        {
            ProjectCategory pcat = ProjectCategory.Unmanaged;
            switch (type)
            {       
                case "C Sharp":
                    pcat = ProjectCategory.Csharp;
                    break;
                case "Hydro":
                    pcat = ProjectCategory.Hydro;
                    break;
                case "Ilasm":
                    pcat = ProjectCategory.Ilasm;
                    break;
                case "Website":
                    pcat = ProjectCategory.Website;
                    break;
                case "Unmanaged":
                    pcat = ProjectCategory.Unmanaged;
                    break;
            }
            return pcat;
        }
        public static string GetFileExtention(string type)
        {
            string fileextention = ".txt";
            switch (type)
            {
                case "C#":
                    fileextention = ".cs";
                    break;
                case "C++":
                    fileextention = ".cpp";
                    break;
                case "Php":
                    fileextention = ".php";
                    break;
                case "Html":
                    fileextention = ".html";
                    break;
            }
            return fileextention;
        }
        public static string GetLanguage(string type)
        {
            string language = "none";
            switch (type)
            {
                case "C#":
                    language = "cs";
                    break;
                case "C++":
                    language = "cpp";
                    break;
                case "Php":
                    language = "php";
                    break;
                case "Html":
                    language = "html";
                    break;
            }
            return language;
        }


    }
}
