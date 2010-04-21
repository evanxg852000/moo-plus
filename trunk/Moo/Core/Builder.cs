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
        private Project ProjectToBuild;
        private BuildOutput ConsoleBuildOutput;
        private string BuidTool;
        private string BuildCommandArgs;
        private string BuiltAssembly; 
        private string ProcessOutputMessage;

        public Builder(Project project,BuildOutput console)
        {
            this.ProjectToBuild = project;
            this.ConsoleBuildOutput = console;
            this.BuidTool = project.GetBuildTool();
            this.BuildCommandArgs = project.GetBuildCommandLineArguments();
            this.BuiltAssembly = project.GetBuiltAssembly();           
        }
        public void Build()
        {
            if ((this.ProjectToBuild.ProjectType == ProjectCategory.Unmanaged) ||(this.ProjectToBuild.ProjectType == ProjectCategory.Website))
            {
                this.ConsoleBuildOutput.AppendContent("Sorry You can't build this kind of project .... \n");
                return ;
            }
            //run external exe assyc
            this.ConsoleBuildOutput.AppendContent("Build started .... \n");
            try
            {
                using (Process BuildProcess = new Process())
                {
                    BuildProcess.StartInfo.FileName =this.BuidTool;
                    BuildProcess.StartInfo.Arguments = this.BuildCommandArgs;
                    BuildProcess.StartInfo.CreateNoWindow = true;
                    BuildProcess.StartInfo.UseShellExecute = false;
                    BuildProcess.StartInfo.RedirectStandardOutput = true;
                    BuildProcess.EnableRaisingEvents = true;
                    BuildProcess.Start();
                    BuildProcess.WaitForExit();
                    this.ProcessOutputMessage = BuildProcess.StandardOutput.ReadToEnd();
                    //set the output content
                    this.ConsoleBuildOutput.AppendContent("\n"+this.ProcessOutputMessage);
                    this.ConsoleBuildOutput.AppendContent("\n\nBuild finished ....");    
                }
            }
            catch (Exception ex)
            {
                this.ConsoleBuildOutput.AppendContent("\n Unable to compile the project \n Error : \n "+ex.Message); 
            }
        }       
        public void Run()
        {
            if (this.ProjectToBuild.ProjectType == ProjectCategory.Unmanaged)
            {
                this.ConsoleBuildOutput.AppendContent("An Unmanaged project can't be built neither ran");
                return;
            }     
            if ((!File.Exists(this.BuiltAssembly)) && (this.ProjectToBuild.ProjectType != ProjectCategory.Website))
            {
                this.ConsoleBuildOutput.AppendContent("The Executable can not be found !\n Make sure you build before running");
                return;
            }
            if(this.ProjectToBuild.ProjectType==ProjectCategory.Unmanaged)
            {
                return ;
            }
            if (this.ProjectToBuild.ProjectType == ProjectCategory.Website)
            { 
                Process.Start(this.BuiltAssembly); //lunch the user web browser 
                return;
            }
            try
            { 
                using (Process RunProcess = new Process())
                {
                  RunProcess.StartInfo.CreateNoWindow = false;
                  RunProcess.StartInfo.UseShellExecute = true;
                  RunProcess.StartInfo.FileName = "moorunner.exe";
                  RunProcess.StartInfo.Arguments = this.BuiltAssembly;
                  RunProcess.Start();
                  RunProcess.WaitForExit();
                }
            }
            catch (Exception ex)
            {
               this.ConsoleBuildOutput.AppendContent("\n  Unable to start the application .... \n Error : \n" + ex.Message);
            }   
        }
        
    }
}
