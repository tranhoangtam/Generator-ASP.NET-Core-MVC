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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class ApiGetAllTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            this.Write("\r\n");
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
var action = (ApiActionInfo)Model;
            
            #line default
            #line hidden
            
            #line 3 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
var lastEntity = Entities.LastOrDefault();
            
            #line default
            #line hidden
            
            #line 4 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
var firstParameter = action.Parameters.AsEnumerable().FirstOrDefault();
            
            #line default
            #line hidden
            
            #line 5 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
var keyProperty = action.ReturnType?.AllProperties().FirstOrDefault(p=>p.IsKey);
            
            #line default
            #line hidden
            
            #line 6 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
var keyType = keyProperty !=null ? keyProperty.ModelProperty?.Substring(0, keyProperty.ModelProperty.IndexOf(".")) : "";
            
            #line default
            #line hidden
            
            #line 7 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
if(string.IsNullOrEmpty(keyType)) { var reference = action.ReturnType?.AllReferences().FirstOrDefault(p=>p.Target != null && !p.Target.IsAbstract); keyType = reference?.CSharpType(); keyProperty=reference?.Target.AllProperties()?.FirstOrDefault(p=>p.IsKey);}
            
            #line default
            #line hidden
            this.Write("\t\t\ttry\r\n\t\t\t{\r\n");
            
            #line 10 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
if(action.ReturnType != null){
            
            #line default
            #line hidden
            this.Write("\t\t\t\tvar list = new List<");
            
            #line 11 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnType.Id));
            
            #line default
            #line hidden
            this.Write(">();\r\n");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
if(!string.IsNullOrEmpty(keyType)){
            
            #line default
            #line hidden
            this.Write("\t\t\t\tvar result = _");
            
            #line 13 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(keyType));
            
            #line default
            #line hidden
            this.Write("Service.GetAll();\r\n\t\t\t\tif(result != null)\r\n\t\t\t\t{\r\n\t\t\t\t\tforeach(var item in result" +
                    ")\r\n\t\t\t\t\t{\r\n\t\t\t\t\t\t//Todo, put your mapping implementation here\r\n\t\t\t\t\t}\r\n\r\n\t\t\t\t\tre" +
                    "turn this.Ok(await Task.FromResult(list));\r\n\t\t\t\t}\r\n\t\t\t\r\n\t\t\t\treturn NotFound();\r\n" +
                    "");
            
            #line 25 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
}else{
            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn this.Ok(await Task.FromResult(list));\r\n");
            
            #line 27 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
}}else{
            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn NotFound();\r\n");
            
            #line 29 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n\t\t\tcatch (Exception xcp)\r\n\t\t\t{\r\n\t\t\t\t//log error\r\n");
            
            #line 34 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
if(action.ReturnType !=null){
            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn Ok(Enumerable.Empty <");
            
            #line 35 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(action.ReturnType.Id));
            
            #line default
            #line hidden
            this.Write("> ().AsQueryable());\r\n");
            
            #line 36 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
}else{
            
            #line default
            #line hidden
            this.Write("\t\t\t\treturn NotFound();\r\n");
            
            #line 38 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Api\Templates\Api\ApiGetAllTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\t\t\t}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
