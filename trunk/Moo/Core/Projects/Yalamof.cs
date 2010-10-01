using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Yalamof: Project
    {
        public Yalamof(): base()
        {
            //nothing to do
        }
        public Yalamof(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Yalamof");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Yalamof");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Yalamof");
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
