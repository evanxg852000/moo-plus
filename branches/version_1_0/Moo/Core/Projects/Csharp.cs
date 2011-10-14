using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Csharp: Project
    {
        public Csharp() : base()
        {
            this.type = PType.Csharp;
        }
        public Csharp(string filepath) :base(filepath)
        {
            this.type = PType.Csharp;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("csharp");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Csharp");
        }
        public override string[] GetKeywords()
        {
            return base.GetKeywords("csharp");
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
