using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Java : Project
    {
        public Java() : base()  
        {
            this.type = PType.Java;
        }
        public Java(string filepath): base(filepath)
        {
            this.type = PType.Java;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {  
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Adobeair");
        }
        public override string[] GetKeywords()
        {
            return base.GetKeywords("java");
        }

        public override void Build(BuildOutput console)
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
