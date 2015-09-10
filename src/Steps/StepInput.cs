using SharpDox.Model;
using SharpDox.Model.Repository;
using System.IO;

namespace SharpDox.Plugins.Chm.Steps
{
    internal static class StepInput
    {
        public static void InitStepinput(SDProject sdProject, SDTargetFx targetFx, string outputPath, string currentLanguage, ChmStrings docStrings, ChmStrings chmStrings, ChmConfig chmConfig)
        {
            SDProject = sdProject;
            CurrentTargetFx = targetFx;
            OutputPath = outputPath;
            TmpPath = Path.Combine(outputPath, "tmp-" + currentLanguage);
            CurrentLanguage = currentLanguage;
            DocStrings = docStrings;
            ChmStrings = chmStrings;
            ChmConfig = chmConfig;
        }

        public static SDProject SDProject { get; set; }
        public static string OutputPath { get; set; }
        public static string TmpPath { get; set; }
        public static string CurrentLanguage { get; set; }
        public static SDTargetFx CurrentTargetFx { get; set; }
        public static ChmStrings DocStrings { get; set; }
        public static ChmStrings ChmStrings { get; set; }
        public static ChmConfig ChmConfig { get; set; }
    }
}
