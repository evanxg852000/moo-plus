using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Moo.Core
{
    class Builder
    {
        private Project ProjectToBuild;
        private string BuildCommand;
        private string BuiltAssembly;

        public Builder(Project project)
        {
            this.ProjectToBuild = project;
            this.BuildCommand = project.GetBuildCommand();
            this.BuiltAssembly = project.GetBuiltAssembly();
        }

        public void Build()
        {
            //run external exe assyc
        }      
        public void Run()
        {
            
        }



    }
}
