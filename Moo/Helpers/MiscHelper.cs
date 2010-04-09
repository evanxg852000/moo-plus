using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Helpers
{
    class MiscHelper
    {
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
