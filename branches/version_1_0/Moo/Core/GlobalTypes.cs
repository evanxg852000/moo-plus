using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core
{
      
    /// <summary>
   /// delegate for dock windows that need to provide general fuctionality
   /// like open project on start page 
   /// this sort of action needs to be redirected on the main cintainer 
   /// which implement the fuctionality instead of duplicating the code
    /// </summary>
   public delegate void NewProjectRequestHandler(object sender, EventArgs e);
   public delegate void OpenProjectRequestHandler(object sender, EventArgs e);
   public delegate void NewFileRequestHandler(object sender, EventArgs e);
   public delegate void OpenFileRequestHandler ( string file);
   public delegate void InsertBrunchRequestHandler( string file);



   class SupportedFiles{
       private static Dictionary<string, string> Supportedfiles = new Dictionary<string, string>()
       {
           {"TEXT",".txt"}, {"ASP", ".asp"}, {"BATCH", ".bat"}, {"CS", ".cs"}, {"CSS", ".css"},
           {"CPP", ".cpp"},{"CPPH", ".h"}, {"D", ".d"}, {"HTML", ".html"},{"HTM", ".htm"},
           {"XHTML", ".xhtml"},{"HYDRO", ".hyd"},{"ILASM", ".il"},{"JAVA", ".java"},{"JAVASCRIPT", ".js"},
           {"PASCAL", ".pas"},{"PHP", ".php"},{"SQL", ".sql"},{"VB", ".vb"},{"XML", ".xml"}
       };
       private static Dictionary<string, string> FilesSupported = new Dictionary<string, string>()
       {
           {"txt","TEXT"}, {"asp", "ASP"}, {"bat", "BATCH"}, {"cs", "CS"}, {"css", "CSS"},
           {"cpp", "CPP"},{"h", "CPPH"}, {"d", "D"}, {"html", "HTML"},{"htm", "HTM"},
           {"xhtml", "XHTML"},{"hyd", "HYDRO"},{"il", "ILASM"},{"java", "JAVA"},{"js", "JAVASCRIPT"},
           {"pas", "PASCAL"},{"php", "PHP"},{"sql", "SQL"},{"vb", "VB"},{"xml", "XML"}
       };

       public static string GetExtension(string title){
           string val;
           SupportedFiles.Supportedfiles.TryGetValue(title, out val);
           return val;
       }
       public static string GetLexer(string title){
           string val;
           SupportedFiles.Supportedfiles.TryGetValue(title, out val);
           return val.Replace(".", "");
       }
       public static string GetType(string extension) {
           string val;
           SupportedFiles.FilesSupported.TryGetValue(extension,out val);
           return val;
       }
   
   }




}
