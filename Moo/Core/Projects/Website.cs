using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Website: Project
    {
        public Website() : base()
        {
            //nothing to do
        }
        public Website(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Website");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Website");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Website");
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
