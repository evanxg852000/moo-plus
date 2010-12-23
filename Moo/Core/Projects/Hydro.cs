using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Hydro : Project
    {
        public Hydro():base()
        {
            this.type = PType.Hydro;
        }
        public Hydro(string filepath) : base(filepath)
        {
            this.type = PType.Hydro;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Hydro");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Hydro");
        }
        public override List<string> GetKeywords()
        {
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
