using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Website: Project
    {
        public Website() : base()
        {
            this.type = PType.Website;
        }
        public Website(string filepath) : base(filepath)
        {
            this.type = PType.Website;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Website");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Website");
        }
        public override string[] GetKeywords()
        {
            return base.GetKeywords("website");
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
