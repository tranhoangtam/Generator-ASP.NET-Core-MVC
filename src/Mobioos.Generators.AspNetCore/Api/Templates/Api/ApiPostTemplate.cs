﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime : 16.0.0.0
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
    using Mobioos.Scaffold.BaseGenerators.TextTemplating;
    using Common.Generator.Framework.Extensions;
    using Mobioos.Generators.AspNetCore;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class ApiPostTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"

    var action = (ApiActionInfo)Model;

    var firstParameter = action
        .Parameters
        .FirstOrDefault();

            
            #line default
            #line hidden
            this.Write("        {\r\n            if (!ModelState.IsValid)\r\n            {\r\n                r" +
                    "eturn BadRequest(ModelState);\r\n            }\r\n\r\n            try\r\n            {\r\n" +
                    "");
            
            #line 17 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"

    foreach (var entity in firstParameter.DataModel.ModelPropertiesTypes())
    {
        if (firstParameter != null
            && !string.IsNullOrEmpty(firstParameter.Id))
        {

            
            #line default
            #line hidden
            this.Write("                await _");
            
            #line 24 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Key.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service.Save(\r\n                    ");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstParameter.Id));
            
            #line default
            #line hidden
            this.Write(".Get");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Key));
            
            #line default
            #line hidden
            this.Write("FromViewModel());\r\n");
            
            #line 26 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"

        }
    }

    foreach (var entity in firstParameter.DataModel.GetEntityDirectReferences())
    {
        if (firstParameter != null
            && !string.IsNullOrEmpty(firstParameter.Id)
            && !firstParameter
                .DataModel
                .ModelPropertiesTypes()
                .Keys.Contains(entity.Id))
        {

            
            #line default
            #line hidden
            this.Write("                await _");
            
            #line 40 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Id.ToCamelCase()));
            
            #line default
            #line hidden
            this.Write("Service.Save(\r\n                    ");
            
            #line 41 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(firstParameter.Id));
            
            #line default
            #line hidden
            this.Write(".Get");
            
            #line 41 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(entity.Id));
            
            #line default
            #line hidden
            this.Write("FromViewModel());\r\n");
            
            #line 42 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Api\Templates\Api\ApiPostTemplate.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("                return this.Ok(true);\r\n            }\r\n            catch (Exceptio" +
                    "n xcp)\r\n            {\r\n                //log exception\r\n                return S" +
                    "tatusCode((int)HttpStatusCode.InternalServerError);\r\n            }\r\n        }");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}