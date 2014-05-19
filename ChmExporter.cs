using System;
using System.Xml;
using SharpDox.Model.Repository;
using SharpDox.Sdk.Exporter;
using SharpDox.Plugins.Chm.Templates.Strings;
using SharpDox.Plugins.Chm.Steps;
using System.IO;
using SharpDox.Model;
using System.Collections.Generic;

namespace SharpDox.Plugins.Chm
{
    public class ChmExporter : IExporter
    {
        public event Action<string> OnRequirementsWarning;
        public event Action<string> OnStepMessage;
        public event Action<int> OnStepProgress;

        private double _docCount;
        private double _docIndex;

        private readonly ChmConfig _chmConfig;
        private readonly ChmStrings _chmStrings;

        public ChmExporter(ChmConfig chmConfig, ChmStrings chmStrings)
        {
            _chmConfig = chmConfig;
            _chmStrings = chmStrings;
        }

        public void Export(SDProject sdProject, string outputPath)
        {
            _docCount = sdProject.DocumentationLanguages.Count;
            _docIndex = 1;
            foreach (var docLanguage in sdProject.DocumentationLanguages)
            {
                StepInput.InitStepinput(sdProject, Path.Combine(outputPath, docLanguage), docLanguage, GetCurrentStrings(docLanguage, sdProject.DocLanguage), _chmStrings, _chmConfig);

                var steps = new List<StepBase>();
                steps.Add(new CopyStep(0, 10));
                steps.Add(new TemplateStep(10, 50));
                steps.Add(new CompileStep(50, 90));
                steps.Add(new SaveAndCleanStep(90, 100));

                foreach (var step in steps)
                {
                    step.OnStepMessage += ExecuteOnStepMessage;
                    step.OnStepProgress += ExecuteOnStepProgress;
                    step.RunStep();
                }

                _docIndex++;
            }
        }

        public bool CheckRequirements()
        {
            var config = Helper.LoadConfig();
            var compilerPath = config.SelectSingleNode("CompilerPath");
            var requirements = compilerPath != null && !string.IsNullOrEmpty(compilerPath.InnerText) && File.Exists(Path.Combine(compilerPath.InnerText, "hhc.exe"));
            if (!requirements)
            {
                ExecuteOnRequirementsWarning(_chmStrings.CompilerNotFound);
            }

            return requirements;
        }

        private IStrings GetCurrentStrings(string docLanguage, string defaultLanguage)
        {
            IStrings strings = new EnStrings();
            if (docLanguage == "de" || (docLanguage == "default" && defaultLanguage == "de"))
            {
                strings = new DeStrings();
            }
            return strings;
        }

        internal void ExecuteOnStepMessage(string message)
        {
            var handler = OnStepMessage;
            if (handler != null)
            {
                handler(string.Format("({0}) - {1}", StepInput.CurrentLanguage, message));
            }
        }

        internal void ExecuteOnStepProgress(int progress)
        {
            var handler = OnStepProgress;
            if (handler != null)
            {
                handler(progress);
            }
        }

        internal void ExecuteOnRequirementsWarning(string message)
        {
            var handler = OnRequirementsWarning;
            if (handler != null)
            {
                handler(message);
            }
        }

        public string ExporterName { get { return "Chm"; } }
    }
}
