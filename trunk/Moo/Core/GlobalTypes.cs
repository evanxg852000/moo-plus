using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core
{
   public enum ProjectCategory
    {
        Csharp=0 ,
        Hydro,
        Ilasm,
        Website,
        Vbasic,
        Unmanaged
    }
   
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

}
