using SharpDox.Sdk.Local;

namespace SharpDox.Plugins.Chm
{
    public class ChmStrings : ILocalStrings
    {
        private string _configTitle = "CHM";
        private string _createStylesheet = "Creating stylesheet";
        private string _createIndex = "Creating index file";
        private string _createToc = "Creating toc file";
        private string _createProject = "Creating project file";
        private string _createArticles = "Creating article files";
        private string _createIndexFilesFor = "Creating index files for";
        private string _createType = "Creating type";
        private string _compiling = "Compiling chm";
        private string _saving = "Saving chm to output";
        private string _cleaning = "Cleaning temporary folder";
        private string _defaultColorsHeaderText = "Default Colors";
        private string _customColorHeaderText = "Custom Color";
        private string _reset = "Reset";
        private string _backgroundColor = "Background Color";
        private string _textColor = "Text Color";
        private string _linkColor = "Link Color";
        private string _linkHoverColor = "Link Hover Color";
        private string _tableHeaderBackgroundColor = "Tableheader Color";
        private string _tableHeaderBorderColor = "Tableheader Border Color";
        private string _breadCrumbBackgroundColor = "Breadcrumb Background Color";
        private string _breadCrumbBorderColor = "Breadcrumb Border Color";
        private string _breadCrumbLinkColor = "Breadcrumb Link Color";
        private string _breadCrumbLinkHoverColor = "Breadcrumb Link Hover Color";
        private string _syntaxBoxBackgroundColor = "Syntaxbox Background Color";
        private string _syntaxBoxBorderColor = "Syntaxbox Border Color";
        private string _syntaxBoxTextColor = "Syntaxbox Text Color";
        private string _compilerNotFound = "Could not find the chm compiler. Please set the correct path in the chm settings.";
        private string _compilerPath = "Path to chm compiler";

        private string _constructors = "Contructors";
        private string _fields = "Fields";
        private string _properties = "Properties";
        private string _methods = "Methods";
        private string _events = "Events";
        private string _name = "Name";
        private string _description = "Description";
        private string _seeAlso = "See also";
        private string _syntax = "Syntax";
        private string _summary = "Summary";
        private string _remarks = "Remarks";
        private string _example = "Example";
        private string _returns = "Returns";
        private string _exceptions = "Exceptions";
        private string _parameters = "Parameters";
        private string _typeParameters = "Type Parameters";
        private string _types = "Types";
        private string _uses = "Uses";
        private string _usedBy = "Used By";
        private string _basetype = "Base Type";
        private string _implements = "Implements";
        private string _article = "Article";
        private string _members = "Members";

        public string DisplayName { get { return "ChmExporter"; } }

        public string ConfigTitle
        {
            get { return _configTitle; }
            set { _configTitle = value; }
        }

        public string CreateStylesheet
        {
            get { return _createStylesheet; }
            set { _createStylesheet = value; }
        }

        public string CreateIndex
        {
            get { return _createIndex; }
            set { _createIndex = value; }
        }

        public string CreateToc
        {
            get { return _createToc; }
            set { _createToc = value; }
        }

        public string CreateProject
        {
            get { return _createProject; }
            set { _createProject = value; }
        }

        public string CreateArticles
        {
            get { return _createArticles; }
            set { _createArticles = value; }
        }

        public string Compiling
        {
            get { return _compiling; }
            set { _compiling = value; }
        }

        public string Saving
        {
            get { return _saving; }
            set { _saving = value; }
        }

        public string Cleaning
        {
            get { return _cleaning; }
            set { _cleaning = value; }
        }

        public string DefaultColorsHeaderText
        {
            get { return _defaultColorsHeaderText; }
            set { _defaultColorsHeaderText = value; }
        }

        public string CustomColorHeaderText
        {
            get { return _customColorHeaderText; }
            set { _customColorHeaderText = value; }
        }

        public string Reset
        {
            get { return _reset; }
            set { _reset = value; }
        }

        public string BackgroundColor
        {
            get { return _backgroundColor; }
            set { _backgroundColor = value; }
        }

        public string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }

        public string LinkColor
        {
            get { return _linkColor; }
            set { _linkColor = value; }
        }

        public string LinkHoverColor
        {
            get { return _linkHoverColor; }
            set { _linkHoverColor = value; }
        }

        public string TableHeaderBackgroundColor
        {
            get { return _tableHeaderBackgroundColor; }
            set { _tableHeaderBackgroundColor = value; }
        }

        public string TableHeaderBorderColor
        {
            get { return _tableHeaderBorderColor; }
            set { _tableHeaderBorderColor = value; }
        }

        public string BreadCrumbBackgroundColor
        {
            get { return _breadCrumbBackgroundColor; }
            set { _breadCrumbBackgroundColor = value; }
        }

        public string BreadCrumbBorderColor
        {
            get { return _breadCrumbBorderColor; }
            set { _breadCrumbBorderColor = value; }
        }

        public string BreadCrumbLinkColor
        {
            get { return _breadCrumbLinkColor; }
            set { _breadCrumbLinkColor = value; }
        }

        public string BreadCrumbLinkHoverColor
        {
            get { return _breadCrumbLinkHoverColor; }
            set { _breadCrumbLinkHoverColor = value; }
        }

        public string SyntaxBoxBackgroundColor
        {
            get { return _syntaxBoxBackgroundColor; }
            set { _syntaxBoxBackgroundColor = value; }
        }

        public string SyntaxBoxBorderColor
        {
            get { return _syntaxBoxBorderColor; }
            set { _syntaxBoxBorderColor = value; }
        }

        public string SyntaxBoxTextColor
        {
            get { return _syntaxBoxTextColor; }
            set { _syntaxBoxTextColor = value; }
        }

        public string CreateIndexFilesFor
        {
            get { return _createIndexFilesFor; }
            set { _createIndexFilesFor = value; }
        }

        public string CreateType
        {
            get { return _createType; }
            set { _createType = value; }
        }

        public string CompilerNotFound
        {
            get { return _compilerNotFound; }
            set { _compilerNotFound = value; }
        }

        public string CompilerPath
        {
            get { return _compilerPath; }
            set { _compilerPath = value; }
        }

        public string Constructors
        {
            get { return _constructors; }
            set { _constructors = value; }
        }

        public string Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }
        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public string Methods
        {
            get { return _methods; }
            set { _methods = value; }
        }

        public string Events
        {
            get { return _events; }
            set { _events = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string SeeAlso
        {
            get { return _seeAlso; }
            set { _seeAlso = value; }
        }

        public string Syntax
        {
            get { return _syntax; }
            set { _syntax = value; }
        }

        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string Example
        {
            get { return _example; }
            set { _example = value; }
        }

        public string Returns
        {
            get { return _returns; }
            set { _returns = value; }
        }

        public string Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }

        public string Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        public string TypeParameters
        {
            get { return _typeParameters; }
            set { _typeParameters = value; }
        }

        public string Types
        {
            get { return _types; }
            set { _types = value; }
        }

        public string Uses
        {
            get { return _uses; }
            set { _uses = value; }
        }

        public string UsedBy
        {
            get { return _usedBy; }
            set { _usedBy = value; }
        }

        public string Basetype
        {
            get { return _basetype; }
            set { _basetype = value; }
        }

        public string Implements
        {
            get { return _implements; }
            set { _implements = value; }
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public string Members
        {
            get { return _members; }
            set { _members = value; }
        }
    }
}
