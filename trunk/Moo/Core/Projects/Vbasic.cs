using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Vbasic : Project
    {
        public Vbasic() : base()
        {
            //nothing to do
        }
        public Vbasic(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Vbasic");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Vbasic");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Vbasic");
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
