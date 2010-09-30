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
           {"CPP", ".cpp"},{"CPPB", ".h"}, {"D", ".d"}, {"HTML", ".html"},{"HTMLB", ".htm"},
           {"HTMLC", ".xhtml"},{"HYDRO", ".hyd"},{"ILASM", ".il"},{"JAVA", ".java"},{"JAVASCRIPT", ".js"},
           {"PASCAL", ".pas"},{"PHP", ".php"},{"SQL", ".sql"},{"VB", ".vb"},{"XML", ".xml"}
       };

       public static string GetExtension(string title){
           if(SupportedFiles.Supportedfiles.ContainsKey(title))
           {
               return SupportedFiles.Supportedfiles[title];
           }
           else
           {
            return String.Empty;
           }
           
       }
       public static string GetLexer(string title){
           if(SupportedFiles.Supportedfiles.ContainsKey(title))
           {
               return SupportedFiles.Supportedfiles[title].Replace(".", ""); 
           }
           else
           {
            return String.Empty;
           }
       }
   
   }




}
