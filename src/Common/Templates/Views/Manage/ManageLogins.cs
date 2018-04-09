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
    
    #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageLogins.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ManageLogins : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageLogins.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("@model ");
            
            #line 2 "D:\DEV\Generators\Mobioos\Common\Templates\Views\Manage\ManageLogins.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models.ManageLoginsViewModel\r\n@using Microsoft.AspNetCore.Http.Authentic" +
                    "ation\r\n@{\r\n    ViewData[\"Title\"] = \"Manage your external logins\";\r\n}\r\n\r\n<h2>@Vie" +
                    "wData[\"Title\"].</h2>\r\n\r\n<p class=\"text-success\">@ViewData[\"StatusMessage\"]</p>\r\n" +
                    "@if (Model.CurrentLogins.Count > 0)\r\n{\r\n    <h4>Registered Logins</h4>\r\n    <tab" +
                    "le class=\"table\">\r\n        <tbody>\r\n            @for (var index = 0; index < Mod" +
                    "el.CurrentLogins.Count; index++)\r\n            {\r\n                <tr>\r\n         " +
                    "           <td>@Model.CurrentLogins[index].LoginProvider</td>\r\n                 " +
                    "   <td>\r\n                        @if ((bool)ViewData[\"ShowRemoveButton\"])\r\n     " +
                    "                   {\r\n                            <form asp-controller=\"Manage\" " +
                    "asp-action=\"RemoveLogin\" method=\"post\" class=\"form-horizontal\">\r\n               " +
                    "                 <div>\r\n                                    <input asp-for=\"@Mod" +
                    "el.CurrentLogins[index].LoginProvider\" name=\"LoginProvider\" type=\"hidden\" />\r\n  " +
                    "                                  <input asp-for=\"@Model.CurrentLogins[index].Pr" +
                    "oviderKey\" name=\"ProviderKey\" type=\"hidden\" />\r\n                                " +
                    "    <input type=\"submit\" class=\"btn btn-default\" value=\"Remove\" title=\"Remove th" +
                    "is @Model.CurrentLogins[index].LoginProvider login from your account\" />\r\n      " +
                    "                          </div>\r\n                            </form>\r\n         " +
                    "               }\r\n                        else\r\n                        {\r\n     " +
                    "                       @: &nbsp;\r\n                        }\r\n                   " +
                    " </td>\r\n                </tr>\r\n            }\r\n        </tbody>\r\n    </table>\r\n}\r" +
                    "\n@if (Model.OtherLogins.Count > 0)\r\n{\r\n    <h4>Add another service to log in.</h" +
                    "4>\r\n    <hr />\r\n    <form asp-controller=\"Manage\" asp-action=\"LinkLogin\" method=" +
                    "\"post\" class=\"form-horizontal\">\r\n        <div id=\"socialLoginList\">\r\n           " +
                    " <p>\r\n                @foreach (var provider in Model.OtherLogins)\r\n            " +
                    "    {\r\n                    <button type=\"submit\" class=\"btn btn-default\" name=\"p" +
                    "rovider\" value=\"@provider.AuthenticationScheme\" title=\"Log in using your @provid" +
                    "er.DisplayName account\">@provider.AuthenticationScheme</button>\r\n               " +
                    " }\r\n            </p>\r\n        </div>\r\n    </form>\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}