using SharpDox.Model;
using SharpDox.Plugins.Chm.Templates.Strings;
using System.IO;

namespace SharpDox.Plugins.Chm.Steps
{
    internal static class StepInput
    {
        public static void InitStepinput(SDProject sdProject, string outputPath, string currentLanguage, IStrings docStrings, ChmStrings chmStrings, ChmConfig chmConfig)
        {
            SDProject = sdProject;
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
        public static IStrings DocStrings { get; set; }
        public static ChmStrings ChmStrings { get; set; }
        public static ChmConfig ChmConfig { get; set; }
    }
}
