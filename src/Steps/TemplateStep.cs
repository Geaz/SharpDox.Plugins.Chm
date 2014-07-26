using System.IO;
using SharpDox.Plugins.Chm.Templates;
using SharpDox.Plugins.Chm.Templates.Sites;
using SharpDox.Plugins.Chm.Templates.Nav;
using System.Collections.Generic;
using SharpDox.Model.Documentation;
using SharpDox.UML;
using SharpDox.Model.Documentation.Article;

namespace SharpDox.Plugins.Chm.Steps
{
    internal class TemplateStep : StepBase
    {
        public TemplateStep(int progressStart, int progressEnd) : base(new StepRange(progressStart, progressEnd)) { }

        public override void RunStep()
        {
            CreateStylesheet();
            CreateTocFile();
            CreateProjectFile();
            CreateArticleFiles();
            CreateIndexFile();
            CreateApiIndexFiles();
            CreateTypeFiles();
        }

        private void CreateStylesheet()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.CreateStylesheet);
            var styleSheetFile = Path.Combine(StepInput.TmpPath, "css", "style.css");
            var template = new StylesheetTemplate();
            File.WriteAllText(styleSheetFile, template.TransformText());
        }

        private void CreateTocFile()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.CreateToc);
            var tocHtmlFile = Path.Combine(StepInput.TmpPath, StepInput.SDProject.ProjectName.Replace(" ", "") + ".hhc");
            var template = new HhcTemplate();
            File.WriteAllText(tocHtmlFile, template.TransformText());
        }

        private void CreateProjectFile()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.CreateProject);
            var projectFile = Path.Combine(StepInput.TmpPath, StepInput.SDProject.ProjectName.Replace(" ", "") + ".hhp");
            var template = new HhpTemplate();
            File.WriteAllText(projectFile, template.TransformText());
        }

        private void CreateArticleFiles()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.CreateArticles);
            if (StepInput.SDProject.Articles.Count > 0)
            {
                var articles = StepInput.SDProject.Articles.ContainsKey(StepInput.CurrentLanguage) ?
                                StepInput.SDProject.Articles[StepInput.CurrentLanguage] :
                                StepInput.SDProject.Articles["default"];
                CreateArticles(articles);
            }
        }

        private void CreateArticles(IEnumerable<SDArticle> articles)
        {
            foreach (var article in articles)
            {
                var articleHtmlFile = Path.Combine(StepInput.TmpPath, Helper.RemoveIllegalCharacters(article.Title.Replace(" ", "_")) + ".html");

                if (article.Content != null)
                {
                    var template = new EmptyArticleTemplate { SDArticle = article };
                    File.WriteAllText(articleHtmlFile, template.TransformText());
                }
                else
                {
                    var template = new ArticleTemplate { SDArticle = article };
                    File.WriteAllText(articleHtmlFile, template.TransformText());
                }

                CreateArticles(article.Children);
            }
        }

        private void CreateIndexFile()
        {
            ExecuteOnStepMessage(StepInput.ChmStrings.CreateIndex);
            var indexHtmlFile = Path.Combine(StepInput.TmpPath, StepInput.SDProject.ProjectName.Replace(" ", "") + "-Index.html");
            var template = new IndexTemplate();
            File.WriteAllText(indexHtmlFile, template.TransformText());
        }

        private void CreateApiIndexFiles()
        {
            foreach (var repository in StepInput.SDProject.Repositories.Values)
            {
                foreach (var sdNamespace in repository.GetAllNamespaces())
                {
                    ExecuteOnStepMessage(string.Format("{0}: {1}", StepInput.ChmStrings.CreateIndexFilesFor, sdNamespace.Fullname));

                    var namespaceHtmlFile = Path.Combine(StepInput.TmpPath, sdNamespace.Guid + ".html");
                    var template = new NamespaceTemplate { SDNamespace = sdNamespace };
                    File.WriteAllText(namespaceHtmlFile, template.TransformText());

                    foreach (var sdType in sdNamespace.Types)
                    {
                        var fieldsIndexHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + "-Fields.html");
                        var fieldsTemplate = new FieldsTemplate { SDType = sdType };
                        File.WriteAllText(fieldsIndexHtmlFile, fieldsTemplate.TransformText());

                        var eveIndexHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + "-Events.html");
                        var eventsTemplate = new EventsTemplate { SDType = sdType };
                        File.WriteAllText(eveIndexHtmlFile, eventsTemplate.TransformText());

                        var propertiesIndexHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + "-Properties.html");
                        var propertiesTemplate = new PropertiesTemplate { SDType = sdType };
                        File.WriteAllText(propertiesIndexHtmlFile, propertiesTemplate.TransformText());

                        var constructorsIndexHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + "-Constructors.html");
                        var constructorsTemplate = new ConstructorsTemplate { SDType = sdType };
                        File.WriteAllText(constructorsIndexHtmlFile, constructorsTemplate.TransformText());

                        var methodsIndexHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + "-Methods.html");
                        var methodsTemplate = new MethodsTemplate { SDType = sdType };
                        File.WriteAllText(methodsIndexHtmlFile, methodsTemplate.TransformText());
                    }
                }
            }
        }

        private void CreateTypeFiles()
        {
            foreach (var repository in StepInput.SDProject.Repositories.Values)
            {
                foreach (var sdNamespace in repository.GetAllNamespaces())
                {
                    foreach (var sdType in sdNamespace.Types)
                    {
                        ExecuteOnStepMessage(string.Format("{0}: {1}", StepInput.ChmStrings.CreateType, sdType.Name));

                        var typeHtmlFile = Path.Combine(StepInput.TmpPath, sdType.Guid + ".html");

                        var template = new TypeTemplate { SDType = sdType };

                        if (!sdType.IsClassDiagramEmpty())
                        {
                            sdType.GetClassDiagram().ToPng(Path.Combine(StepInput.TmpPath, "diagrams", sdType.Guid + ".png"));
                        }

                        File.WriteAllText(typeHtmlFile, template.TransformText());
                    }
                }
            }
        }
    }
}