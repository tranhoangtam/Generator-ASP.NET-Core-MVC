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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Views\Account\ResetPassword.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ResetPassword : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Views\Account\ResetPassword.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Views\Account\ResetPassword.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models.ResetPasswordViewModel\r\n@{\r\n    ViewData[\"Title\"] = \"Reset passwo" +
                    "rd\";\r\n}\r\n\r\n<h2>@ViewData[\"Title\"].</h2>\r\n\r\n<form asp-controller=\"Account\" asp-ac" +
                    "tion=\"ResetPassword\" method=\"post\" class=\"form-horizontal\">\r\n    <h4>Reset your " +
                    "password.</h4>\r\n    <hr />\r\n    <div asp-validation-summary=\"All\" class=\"text-da" +
                    "nger\"></div>\r\n    <input asp-for=\"Code\" type=\"hidden\" />\r\n    <div class=\"form-g" +
                    "roup\">\r\n        <label asp-for=\"Email\" class=\"col-md-2 control-label\"></label>\r\n" +
                    "        <div class=\"col-md-10\">\r\n            <input asp-for=\"Email\" class=\"form-" +
                    "control\" />\r\n            <span asp-validation-for=\"Email\" class=\"text-danger\"></" +
                    "span>\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label " +
                    "asp-for=\"Password\" class=\"col-md-2 control-label\"></label>\r\n        <div class=\"" +
                    "col-md-10\">\r\n            <input asp-for=\"Password\" class=\"form-control\" />\r\n    " +
                    "        <span asp-validation-for=\"Password\" class=\"text-danger\"></span>\r\n       " +
                    " </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label asp-for=\"Confi" +
                    "rmPassword\" class=\"col-md-2 control-label\"></label>\r\n        <div class=\"col-md-" +
                    "10\">\r\n            <input asp-for=\"ConfirmPassword\" class=\"form-control\" />\r\n    " +
                    "        <span asp-validation-for=\"ConfirmPassword\" class=\"text-danger\"></span>\r\n" +
                    "        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"co" +
                    "l-md-offset-2 col-md-10\">\r\n            <button type=\"submit\" class=\"btn btn-defa" +
                    "ult\">Reset</button>\r\n        </div>\r\n    </div>\r\n</form>\r\n\r\n@section Scripts {\r\n" +
                    "    @{ await Html.RenderPartialAsync(\"_ValidationScriptsPartial\"); }\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
