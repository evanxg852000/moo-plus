using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using Moo.Helpers;
using System.Windows.Forms;

namespace Moo.Core
{
    class Builder
    {
        Project project;
        BuildOutput console;

        public Builder(Project project, BuildOutput console)
        {
            this.project = project;
            this.console = console;
        }
        public void Build()
        {
            this.console.SetOutputContent("Start building.... \n");
            this.project.Build(this.console);
            this.console.SetOutputContent("Process terminated ..."); 
        }
        public void Run()
        {
            this.project.Run();  
        }

    }
}
