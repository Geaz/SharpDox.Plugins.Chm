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
    using System.Collections.Generic;
    using SharpDox.Model.Repository;
    using SharpDox.Plugins.Chm.Steps;
    using MarkdownSharp;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class FieldsTemplate : FieldsTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write(@"

<html>
    <head>
        <title>Fields</title>
        <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/reset.css"">
        <link rel=""stylesheet"" type=""text/css"" href=""css/style.css"">

    </head>
    <body>
		<div id=""header"">
			<h2 class=""type-title"">");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Fields));
            
            #line default
            #line hidden
            this.Write("</h2>\n\t\t\t<span class=\"namespace-title\">");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Fullname));
            
            #line default
            #line hidden
            this.Write("</span>\n\t\t</div>\n\t\t<div id=\"subheader\">\n\t\t\t<a href=\"");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.SDProject.ProjectName.Replace(" ", "")));
            
            #line default
            #line hidden
            this.Write("-Index.html\">Start</a> > <a href=\"");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Namespace.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Namespace.Fullname));
            
            #line default
            #line hidden
            this.Write("</a> > <a href=\"");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Name));
            
            #line default
            #line hidden
            this.Write("</a>\n\t\t</div>\n\n\t\t<div id=\"content\">\n\t\t\t<div class=\"table-box\">\n\t\t\t\t<table>\n\t\t\t\t\t<" +
                    "thead>\n\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t<td></td>\n\t\t\t\t\t\t\t<td>");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Name));
            
            #line default
            #line hidden
            this.Write("</td>\n\t\t\t\t\t\t\t<td>");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(StepInput.DocStrings.Description));
            
            #line default
            #line hidden
            this.Write("</td>\n\t\t\t\t\t\t</tr>\n\t\t\t\t\t</thead>\n\t\t\t\t\t<tbody>\n\n\t\t\t\t\t");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
 foreach(var field in SDType.Fields) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\n\t\t\t\t\t\t<tr>\n\t\t\t\t\t\t\t<td class=\"icon-column\">\n\t\t\t\t\t\t\t\t<img alt=\"Fields-Icon\" s" +
                    "rc=\"icons/Field_");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Accessibility));
            
            #line default
            #line hidden
            this.Write(".png\">\n\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t\t<td>\n\t\t\t\t\t\t\t\t<a title=\"");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("\" href=\"");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Guid));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(field.Name));
            
            #line default
            #line hidden
            this.Write("</a>\n\t\t\t\t\t\t\t</td>\t\n\t\t\t\t\t\t\t<td class=\"markdown\">\n\t\t\t\t\t\t\t\t");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
 var documentation = field.Documentations.GetElementOrDefault(StepInput.CurrentLanguage); 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t\t");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(documentation != null ? new Markdown().Transform(documentation.Summary.ToString()) : ""));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t\t</td>\n\t\t\t\t\t\t</tr>\n\n\t\t\t\t\t");
            
            #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t\t\t</tbody>\n\t\t\t\t</table>\n\t\t\t</div>\n\t\t</div>\n    </body>\n</html>\n\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "D:\Github\SharpDox.Plugins.Chm\src\Templates\Sites\FieldsTemplate.tt"
 public SDType SDType { get; set; } 
        
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
    public class FieldsTemplateBase
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
