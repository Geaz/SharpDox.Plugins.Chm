using System.ComponentModel;
using System;
using SharpDox.Sdk.Config;
using SharpDox.Sdk.Config.Attributes;
using System.Xml;
using System.IO;
using SharpDox.Sdk;

namespace SharpDox.Plugins.Chm
{
    [Name(typeof(ChmStrings), "ConfigTitle")]
    public class ChmConfig : IConfigSection
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private SDPath _compilerPath;
        private string _backgroundColor;
        private string _textColor;
        private string _linkColor;
        private string _linkHoverColor;
        private string _tableHeaderBackgroundColor;
        private string _tableHeaderBorderColor;
        private string _breadCrumbBorderColor;
        private string _breadCrumLinkColor;
        private string _breadCrumLinkHoverColor;
        private string _syntaxBoxBackgroundColor;
        private string _syntaxBoxBorderColor;
        private string _syntaxBoxTextColor;
        private string _breadCrumBackgroundColor;

        [Required]
        [Name(typeof(ChmStrings), "CompilerPath")]
        [ConfigEditor(EditorType.Folderpicker)]
        public SDPath CompilerPath
        {
            get { return _compilerPath; }
            set
            {
                _compilerPath = value;
                OnPropertyChanged("CompilerPath");
            }
        }

        [Name(typeof(ChmStrings), "BackgroundColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string BackgroundColor
        {
            get { return _backgroundColor ?? "#FFFFFF"; }
            set
            {
                _backgroundColor = value;
                OnPropertyChanged("BackgroundColor");
            }
        }

        [Name(typeof(ChmStrings), "TextColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string TextColor
        {
            get { return _textColor ?? "#636363"; }
            set
            {
                _textColor = value;
                OnPropertyChanged("TextColor");
            }
        }

        [Name(typeof(ChmStrings), "LinkColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string LinkColor
        {
            get { return _linkColor ?? "#1382CE"; }
            set
            {
                _linkColor = value;
                OnPropertyChanged("LinkColor");
            }
        }

        [Name(typeof(ChmStrings), "LinkHoverColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string LinkHoverColor
        {
            get { return _linkHoverColor ?? "#F58026"; }
            set
            {
                _linkHoverColor = value;
                OnPropertyChanged("LinkHoverColor");
            }
        }

        [Name(typeof(ChmStrings), "TableHeaderBackgroundColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string TableHeaderBackgroundColor
        {
            get { return _tableHeaderBackgroundColor ?? "#F6F5F1"; }
            set
            {
                _tableHeaderBackgroundColor = value;
                OnPropertyChanged("TableHeaderBackgroundColor");
            }
        }

        [Name(typeof(ChmStrings), "TableHeaderBorderColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string TableHeaderBorderColor
        {
            get { return _tableHeaderBorderColor ?? "#C2C2C2"; }
            set
            {
                _tableHeaderBorderColor = value;
                OnPropertyChanged("TableHeaderBorderColor");
            }
        }

        [Name(typeof(ChmStrings), "BreadCrumbBackgroundColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string BreadCrumbBackgroundColor
        {
            get { return _breadCrumBackgroundColor ?? "#EEEEEE"; }
            set
            {
                _breadCrumBackgroundColor = value;
                OnPropertyChanged("BreadCrumBackgroundColor");
            }
        }

        [Name(typeof(ChmStrings), "BreadCrumbBorderColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string BreadCrumbBorderColor
        {
            get { return _breadCrumbBorderColor ?? "#B4A9AC"; }
            set
            {
                _breadCrumbBorderColor = value;
                OnPropertyChanged("BreadCrumBorderColor");
            }
        }

        [Name(typeof(ChmStrings), "BreadCrumbLinkColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string BreadCrumbLinkColor
        {
            get { return _breadCrumLinkColor ?? "#8C7F83"; }
            set
            {
                _breadCrumLinkColor = value;
                OnPropertyChanged("BreadCrumLinkColor");
            }
        }

        [Name(typeof(ChmStrings), "BreadCrumbLinkHoverColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string BreadCrumbLinkHoverColor
        {
            get { return _breadCrumLinkHoverColor ?? "#574C4F"; }
            set
            {
                _breadCrumLinkHoverColor = value;
                OnPropertyChanged("BreadCrumLinkHoverColor");
            }
        }

        [Name(typeof(ChmStrings), "SyntaxBoxBackgroundColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string SyntaxBoxBackgroundColor
        {
            get { return _syntaxBoxBackgroundColor ?? "#EEEEEE"; }
            set
            {
                _syntaxBoxBackgroundColor = value;
                OnPropertyChanged("SyntaxBoxBackgroundColor");
            }
        }

        [Name(typeof(ChmStrings), "SyntaxBoxBorderColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string SyntaxBoxBorderColor
        {
            get { return _syntaxBoxBorderColor ?? "#CCCCCC"; }
            set
            {
                _syntaxBoxBorderColor = value;
                OnPropertyChanged("SyntaxBoxBorderColor");
            }
        }

        [Name(typeof(ChmStrings), "SyntaxBoxTextColor")]
        [ConfigEditor(EditorType.Colorpicker)]
        public string SyntaxBoxTextColor
        {
            get { return _syntaxBoxTextColor ?? "#636363"; }
            set
            {
                _syntaxBoxTextColor = value;
                OnPropertyChanged("SyntaxBoxTextColor");
            }
        }

        public Guid Guid { get { return new Guid("36db802f-af3f-456d-910f-e2f9255e8150"); } }         
    }
}
