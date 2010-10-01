using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Hydro : Project
    {
        public Hydro():base()
        {
            //nothing to do
        }
        public Hydro(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Hydro");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Hydro");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Hydro");
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
