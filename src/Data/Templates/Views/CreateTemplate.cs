﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime : 15.0.0.0
//  
//     Les changements apportés à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Mobioos.Generators.AspNetCore
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using Mobioos.Foundation.Jade.Models;
    using Mobioos.Foundation.Jade.Extensions;
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class CreateTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
 var model = (EntityInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels.");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n@{\r\n    ViewBag.Title = \"Create\";\r\n    Layout = \"~/Views/Shared/_Layout.cshtm" +
                    "l\";\r\n}\r\n\r\n<h2>Create</h2>\r\n\r\n\r\n@using (Html.BeginForm()) \r\n{\r\n    @Html.AntiForg" +
                    "eryToken()\r\n    \r\n    <div class=\"form-horizontal\">\r\n        <h4>");
            
            #line 17 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("</h4>\r\n        <hr />\r\n        @Html.ValidationSummary(true, \"\", new { @class = \"" +
                    "text-danger\" })\r\n\t\t");
            
            #line 20 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
foreach(var property in model.AllProperties()) {
            
            #line default
            #line hidden
            this.Write("\t\t<div class=\"form-group\">\r\n            @Html.LabelFor(m => m.");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(", htmlAttributes: new { @class = \"control-label col-md-2\" })\r\n            <div cl" +
                    "ass=\"col-md-10\">\r\n                @Html.EditorFor(m => m.");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(", new { htmlAttributes = new { @class = \"form-control\" } })\r\n                @Htm" +
                    "l.ValidationMessageFor(m => m.");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(", \"\", new { @class = \"text-danger\" })\r\n            </div>\r\n        </div>\r\n\t\t");
            
            #line 28 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\CreateTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(@"
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
}

<div>
    @Html.ActionLink(""Back to List"", ""Index"")
</div>

@section Scripts {
    @Scripts.Render(""~/bundles/jqueryval"")
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
