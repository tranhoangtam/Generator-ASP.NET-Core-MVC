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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class DetailsTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
 var model = (EntityInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels.");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n@{\r\n    ViewBag.Title = \"Details\";\r\n    Layout = \"~/Views/Shared/_Layout.csht" +
                    "ml\";\r\n}\r\n\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n\t\t");
            
            #line 15 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
 foreach(var property in model.AllProperties()){
            
            #line default
            #line hidden
            this.Write("\t\t<dt>\r\n            @Html.DisplayNameFor(m => m.");
            
            #line 17 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(")\r\n        </dt>\r\n        <dd>\r\n            @Html.DisplayFor(m => m.");
            
            #line 20 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(")\r\n        </dd>\r\n\t\t");
            
            #line 22 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\Views\DetailsTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("    </dl>\r\n</div>\r\n<p>\r\n    @Html.ActionLink(\"Edit\", \"Edit\", new { id = Model.id " +
                    "}) |\r\n    @Html.ActionLink(\"Back to List\", \"Index\")\r\n</p>\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
