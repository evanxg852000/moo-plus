using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    class Csharp: Project
    {
        public Csharp() : base()
        {
            //nothing to do
        }
        public Csharp(string filepath) : base(filepath)
        {
            //just initialise with the base constructor
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Csharp");
            base.CopyTemplate();
        }
        public override List<string> GetFiles()
        {
            base.GetFiles();
            return base.GetFiles("Csharp");
        }
        public override List<string> GetKeywords()
        {
            base.GetKeywords();
            return base.GetKeywords("Csharp");
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
