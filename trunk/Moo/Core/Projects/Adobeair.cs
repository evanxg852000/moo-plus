using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Adobeair :Project
    {
        public Adobeair() : base()  
        { 
         
        }

        

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate(this.ToString());
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles(this.ToString());
        }
        public override List<string> GetKeywords()
        {
            return base.GetKeywords(this.ToString());
        }

        public override void Build()
        {

        }
        public override void Run()
        {

        }
        public override void GetBuildTool()
        {

        }
        public override void GetCmdArgs()
        {

        }
        

        #endregion
   
    }
}
