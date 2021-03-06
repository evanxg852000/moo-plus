﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Unmanaged: Project
    {
        public Unmanaged() : base()
        {
            this.type = PType.Unmanaged;
        }
        public Unmanaged(string filepath) : base(filepath)
        {
            this.type = PType.Unmanaged;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Unmanaged");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Unmanaged");
        }
        public override string[] GetKeywords()
        {
            return base.GetKeywords("unmanaged");
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
