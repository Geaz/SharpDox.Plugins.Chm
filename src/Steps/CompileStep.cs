using System.IO;
using System.Diagnostics;

namespace SharpDox.Plugins.Chm.Steps
{
    internal class CompileStep : StepBase
    {
        public CompileStep(int progressStart, int progressEnd) : base(new StepRange(progressStart, progressEnd)) { }

        public override void RunStep()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.Compiling);

            var p = new Process();
            p.StartInfo.FileName = Path.Combine(StepInput.ChmConfig.CompilerPath, "hhc.exe");
            p.StartInfo.Arguments = "\"" + Path.Combine(StepInput.TmpPath, StepInput.SDProject.ProjectName.Replace(" ", "") + ".hhp") + "\"";
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            p.Start();

            p.StandardOutput.ReadToEnd();
            p.WaitForExit();
        }
    }
}
