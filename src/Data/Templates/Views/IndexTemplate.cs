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
    using Mobioos.Scaffold.TextTemplating;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class IndexTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
 var model = (EntityInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model IEnumerable<");
            
            #line 2 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels.");
            
            #line 2 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(">\r\n\r\n@{\r\n    ViewBag.Title = \"Index\";\r\n    Layout = \"~/Views/Shared/_Layout.cshtm" +
                    "l\";\r\n}\r\n\r\n<h2>");
            
            #line 9 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" Index</h2>\r\n\r\n<p>\r\n    @Html.ActionLink(\"Create New\", \"Create\")\r\n</p>\r\n<table cl" +
                    "ass=\"table\">\r\n    <tr>\r\n\t\t");
            
            #line 16 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
 foreach(var property in model.AllProperties()){
            
            #line default
            #line hidden
            this.Write("\t\t<th>\r\n            @Html.DisplayNameFor(m => m.");
            
            #line 18 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(")\r\n        </th>\r\n\t\t");
            
            #line 20 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("        <th></th>\r\n    </tr>\r\n\r\n@foreach (var item in Model) {\r\n    <tr>\r\n\t\t");
            
            #line 26 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
 foreach(var property in model.AllProperties()){
            
            #line default
            #line hidden
            this.Write("\t\t<th>\r\n            @Html.DisplayFor(modelItem => item.");
            
            #line 28 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(property.Id));
            
            #line default
            #line hidden
            this.Write(")\r\n        </th>\r\n\t\t");
            
            #line 30 "D:\DEV\Generators\Mobioos\Data\Templates\Views\IndexTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write(@"        <td>
            @Html.ActionLink(""Edit"", ""Edit"", new { id=item.Id }) |
            @Html.ActionLink(""Details"", ""Details"", new { id=item.Id }) |
            @Html.ActionLink(""Delete"", ""Delete"", new { id=item.Id })
        </td>
    </tr>
}

</table>
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}