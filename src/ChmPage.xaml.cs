using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using SharpDox.Sdk.UI;

namespace SharpDox.Plugins.Chm
{
    public partial class ChmPage : IPage
    {
        private XmlDocument _config;
        private readonly ChmConfig _chmConfig;

        public ChmPage(ChmStrings strings, ChmConfig chmConfig)
        {
            _chmConfig = chmConfig;

            Strings = strings;
            DataContext = chmConfig;

            InitializeComponent();
            LoadConfig();
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            _chmConfig.BackgroundColor = null;
            _chmConfig.TextColor = null;
            _chmConfig.LinkColor = null;
            _chmConfig.LinkHoverColor = null;
            _chmConfig.TableHeaderBackgroundColor = null;
            _chmConfig.TableHeaderBorderColor = null;
            _chmConfig.BreadCrumbBackgroundColor = null;
            _chmConfig.BreadCrumbBorderColor = null;
            _chmConfig.BreadCrumbLinkColor = null;
            _chmConfig.BreadCrumbLinkHoverColor = null;
            _chmConfig.SyntaxBoxBackgroundColor = null;
            _chmConfig.SyntaxBoxBorderColor = null;
            _chmConfig.SyntaxBoxTextColor = null;
        }

        private void OnBrowseCompiler(object sender, RoutedEventArgs e)
        {
            var dlg = new System.Windows.Forms.FolderBrowserDialog();
            dlg.ShowNewFolderButton = true;
            dlg.ShowDialog();
            if (!String.IsNullOrEmpty(dlg.SelectedPath))
            {
                var tb = ((TextBox)sender);
                tb.Text = dlg.SelectedPath;
            }
        }

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            SetConfig(tbInputPath.Text);
        }

        private void LoadConfig()
        {
            _config = Helper.LoadConfig();
            var compilerPath = _config.SelectSingleNode("CompilerPath");
            if (compilerPath != null)
            {
                tbInputPath.Text = compilerPath.InnerText;
            }
        }

        private void SetConfig(string path)
        {
            var compilerPath = _config.SelectSingleNode("CompilerPath");
            if (compilerPath == null)
            {
                compilerPath = _config.CreateNode(XmlNodeType.Entity, "CompilerPath", null);
            }

            compilerPath.InnerText = path;
            _config.Save(Path.Combine(Path.GetDirectoryName(GetType().Assembly.Location), "config.xml"));
        }

        public ChmStrings Strings { get; private set; }
        public new int Height { get { return int.Parse(mainGrid.Height.ToString()); } }
        public new int Width { get { return int.Parse(mainGrid.Width.ToString()); } }
        public string PageName { get { return "Chm"; } }
    }
}
