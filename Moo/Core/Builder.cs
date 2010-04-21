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
                    if(BuildProcess.HasExited)
                    {
                        this.ProcessOutputMessage = BuildProcess.StandardOutput.ReadToEnd();
                        //set the output content
                        this.ConsoleBuildOutput.AppendContent("\n"+this.ProcessOutputMessage);
                        this.ConsoleBuildOutput.AppendContent("\n\nBuild finished ...."); 
                    }
                    
                }
            }
            catch (Exception ex)
            {
                this.ConsoleBuildOutput.AppendContent("\n Unable to compile the project \n Error : \n "+ex.Message); 
            }
        }
        public Process Run()
        {
            Process RunProcess = new Process();
            RunProcess.StartInfo.CreateNoWindow = false;
            RunProcess.StartInfo.UseShellExecute = true;

            if (!File.Exists(this.BuiltAssembly))
            {
                this.ConsoleBuildOutput.AppendContent("The Executable can not be found !\n Make sure you build before running");
                return RunProcess;
            }

            if(this.ProjectToBuild.ProjectType==ProjectCategory.Unmanaged)
            {
                return RunProcess;
            }
            else if (this.ProjectToBuild.ProjectType == ProjectCategory.Website)
            {
                //luch for website
                return RunProcess;
            }
            else
            {
                switch (this.ProjectToBuild.AssemblyType)
                {
                    case "Console Executable (.exe)":
                        try {
                            string runnercontent = String.Format("ECHO OFF \n{0} \nPAUSE \nEXIT ", this.BuiltAssembly);
                            FileHelper.Save(Path.GetDirectoryName(Application.ExecutablePath) + @"\moorunner.bat", runnercontent);
                            RunProcess.StartInfo.FileName = "moorunner.bat";
                        } catch { }
                        break;
                    case "Windows Executable (.exe)":
                          RunProcess.StartInfo.FileName = this.BuiltAssembly; 
                        break;
                    case "Dynamic Library (.dll)":
                        MessageBox.Show("A dinamic library Application can not be run directly !");
                        break;
                }
                try
                {
                    RunProcess.Start();
                }
                catch (Exception ex)
                {
                    this.ConsoleBuildOutput.AppendContent("\n  Unable to start the application .... \n Error : \n" + ex.Message);
                }
                return RunProcess;
            }    
        }




    }
}
