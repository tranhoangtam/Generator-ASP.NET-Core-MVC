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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class IServiceTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
 var model = (EntityInfo)Model; var key = ((EntityInfo)Model).AllProperties() != null ? ((EntityInfo)Model).AllProperties().FirstOrDefault(p=>p.IsKey) : null; 
            
            #line default
            #line hidden
            this.Write("﻿using System; \r\nusing System.Collections.Generic; \r\nusing System.Linq; \r\nusing S" +
                    "ystem.Threading.Tasks;\r\nusing ");
            
            #line 6 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.DataModels;\r\n \r\nnamespace ");
            
            #line 8 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(ApplicationId));
            
            #line default
            #line hidden
            this.Write(".Backend.Services\r\n{ \r\n    public interface I");
            
            #line 10 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("Service\r\n    { \r\n\t\tIQueryable<");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("> GetAll(); \r\n\t\tTask<");
            
            #line 13 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("> GetById(");
            
            #line 13 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id);      \r\n        Task Save(");
            
            #line 14 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(" entity); \r\n        Task Delete(");
            
            #line 15 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Data\Templates\IServiceTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(key.CSharpType()));
            
            #line default
            #line hidden
            this.Write(" id); \r\n    } \r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
