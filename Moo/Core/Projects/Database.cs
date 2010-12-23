using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core.Projects
{
    [Serializable]
    class Database : Project
    {
        public Database() : base()             
        {
            this.type = PType.Databse;
        }
        public Database(string filepath) : base(filepath)
        {
            this.type = PType.Databse;
        }

        #region Overriden Methods

        public override void CopyTemplate()
        {
            base.CopyTemplate("Database");
        }
        public override List<string> GetFiles()
        {
            return base.GetFiles("Database");
        }
        public override List<string> GetKeywords()
        {
            return base.GetKeywords("Database");
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
