﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 14.0.0.0
//  
//     Änderungen an dieser Datei können fehlerhaftes Verhalten verursachen und gehen verloren, wenn
//     der Code neu generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpDox.Plugins.Chm.Templates.Sites
{
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.IO;
    using System.Collections.Generic;
    using SharpDox.Model.Repository;
    using SharpDox.Model.Repository.Members;
    using SharpDox.Plugins.Chm.Steps;
    using SharpDox.Model.Documentation.Token;
    using SharpDox.UML;
    using MarkdownSharp;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class MemberTemplate : MemberTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n<div id=\"");
            
            #line 15 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Guid));
            
            #line default
            #line hidden
            this.Write("\" class=\"typesite\">\r\n\t<div id=\"header\">\r\n\t\t<h2 class=\"type-title\">");
            
            #line 17 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Name));
            
            #line default
            #line hidden
            this.Write("</h2>\r\n\t\t<span class=\"namespace-title\">");
            
            #line 18 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.DeclaringType.Type.Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write("</span>\r\n\t</div>\r\n\t<div id=\"subheader\">\r\n\t\t<a href=\"");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.SDProject.ProjectName.Replace(" ", "")));
            
            #line default
            #line hidden
            this.Write("-Index.html\">Start</a> > <a href=\"");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.DeclaringType.Type.Namespace.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.DeclaringType.Type.Fullname));
            
            #line default
            #line hidden
            this.Write("</a> > <a href=\"");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.DeclaringType.Type.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.DeclaringType.Type.Name));
            
            #line default
            #line hidden
            this.Write(" > <a href=\"");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 21 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Name));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t</div>\r\n\r\n\t<div id=\"content\">\r\n\t\t<h3 class=\"box-title\">");
            
            #line 25 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Syntax));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t<div class=\"syntax-box\">\r\n\t\t\t");
            
            #line 27 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(WebUtility.HtmlEncode(SDMember.Syntax)));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t</div>\r\n        \r\n\t\t");
            
            #line 30 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentations.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 32 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 var documentation = SDMember.Documentations.GetElementOrDefault(StepInput.CurrentLanguage);
			if(documentation.Summary.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 34 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Summary));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 36 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(documentation.Summary.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 38 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 40 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.Remarks.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 41 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Remarks));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 43 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(documentation.Remarks.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 45 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 47 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.Example.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 48 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Example));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 50 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(documentation.Example.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 52 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 54 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.Returns.ContainsKey("default")) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 55 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Returns));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 57 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(documentation.Returns["default"].ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 59 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 61 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.Exceptions.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 62 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Exceptions));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 64 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 foreach(var exception in documentation.Exceptions) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<p>");
            
            #line 65 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t");
            
            #line 67 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(exception.Value.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            
            #line 69 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</div>\r\n\t\t\t");
            
            #line 71 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 73 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.Params.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 74 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Parameters));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 76 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 foreach(var parameter in documentation.Params) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<p>");
            
            #line 77 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t");
            
            #line 79 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(parameter.Value.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            
            #line 81 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</div>\r\n\t\t\t");
            
            #line 83 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 85 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.TypeParams.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 86 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.TypeParameters));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"doc-box markdown\">\r\n\t\t\t\t\t");
            
            #line 88 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 foreach(var typeParameter in documentation.TypeParams) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<p>");
            
            #line 89 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeParameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\t\t\t\t\t\t<div class=\"inline\">\r\n\t\t\t\t\t\t\t");
            
            #line 91 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(typeParameter.Value.ToMarkdown(StepInput.SDProject.Tokens).Transform(Helper.TransformLinkToken))));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t");
            
            #line 93 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</div>\r\n\t\t\t");
            
            #line 95 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t");
            
            #line 97 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 if(documentation.SeeAlsos.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<h3 class=\"box-title\">");
            
            #line 98 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.SeeAlso));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t\t\t<div class=\"list-box\">\r\n\t\t\t\t\t<ul>\r\n\t\t\t\t\t");
            
            #line 101 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 foreach(var sdToken in documentation.SeeAlsos) 
					{ 
						var seeAlso = (SDSeeToken)sdToken;
						if(!string.IsNullOrEmpty(seeAlso.DeclaringType))
						{
							var identifier = string.Format("{0}.{1}", seeAlso.DeclaringType, seeAlso.Name);
							var sdMember = SDRepository.GetMemberByIdentifier(identifier);
							if(sdMember != null)
                            {
								
            
            #line default
            #line hidden
            this.Write(" <li><a href=\"../type/");
            
            #line 110 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.DeclaringType.Type.Guid));
            
            #line default
            #line hidden
            this.Write(".html#");
            
            #line 110 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.Guid));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 110 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.Name));
            
            #line default
            #line hidden
            this.Write("</a></li> ");
            
            #line 110 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"

                            }
						}
						else
						{
							var identifier = string.Format("{0}.{1}", seeAlso.Namespace, seeAlso.Name);
							var sdType = SDRepository.GetTypeByIdentifier(identifier);
							if(sdType != null)
                            {
								
            
            #line default
            #line hidden
            this.Write(" <li><a href=\"../type/");
            
            #line 119 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 119 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li> ");
            
            #line 119 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"

                            }
						} 
					} 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t</ul>\r\n\t\t\t\t</div>\r\n\t\t\t");
            
            #line 125 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 127 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t");
            
            #line 129 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
	if(SDMember is SDMethod && !((SDMethod)SDMember).IsSequenceDiagramEmpty()) { 
			((SDMethod)SDMember).GetSequenceDiagram(SDRepository).ToPng(Path.Combine(StepInput.TmpPath, "diagrams", SDMember.Guid + ".png")); 
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t<div class=\"diagram-box\">\r\n\t\t\t\t<img class=\"diagram-image\" src=\"diagrams/");
            
            #line 133 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Guid));
            
            #line default
            #line hidden
            this.Write(".png\"/>\r\n\t\t\t</div>\r\n\r\n\t\t");
            
            #line 136 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t</div>\r\n</div>\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 140 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\MemberTemplate.tt"
 
public SDMemberBase SDMember { get; set; }
public SDRepository SDRepository { get; set; } 

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class MemberTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
