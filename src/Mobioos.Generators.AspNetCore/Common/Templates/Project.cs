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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class Project : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("<Project Sdk=\"Microsoft.NET.Sdk.Web\">\r\n    <PropertyGroup>\r\n      <TargetFramewor" +
                    "k>netcoreapp2.0</TargetFramework>\r\n      <PreserveCompilationContext>true</Prese" +
                    "rveCompilationContext>\r\n      <AssemblyName>");
            
            #line 7 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend</AssemblyName>\r\n      <OutputType>Exe</OutputType>\r\n      <PackageId>");
            
            #line 9 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write("</PackageId>\r\n      <UserSecretsId>aspnet-");
            
            #line 10 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(UserSecret));
            
            #line default
            #line hidden
            this.Write("</UserSecretsId>\r\n      <AssetTargetFallback>$(AssetTargetFallback);portable-net4" +
                    "5+win8+wp8+wpa81;</AssetTargetFallback>\r\n      <RootNamespace>");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Common\Templates\Project.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend</RootNamespace>\r\n    </PropertyGroup>\r\n    <ItemGroup>\r\n      <PackageRe" +
                    "ference Include = \"BuildBundlerMinifier\" Version=\"2.9.406\" />\r\n      <PackageRef" +
                    "erence Include = \"Microsoft.ApplicationInsights.AspNetCore\" Version=\"2.7.1\" />\r\n" +
                    "      <PackageReference Include = \"Microsoft.AspNetCore\" Version=\"2.0.1\" />\r\n   " +
                    "   <PackageReference Include = \"Microsoft.AspNetCore.Authentication.Cookies\" Ver" +
                    "sion=\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft.AspNetCore\" Versio" +
                    "n=\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft.AspNetCore.Authentica" +
                    "tion.Abstractions\" Version=\"2.0.1\" />\r\n      <PackageReference Include = \"Micros" +
                    "oft.AspNetCore.Authentication.Cookies\" Version=\"2.0.1\" />\r\n      <PackageReferen" +
                    "ce Include = \"Microsoft.AspNetCore.Authentication.Core\" Version=\"2.0.1\" />\r\n    " +
                    "  <PackageReference Include = \"Microsoft.AspNetCore.Authentication.Facebook\" Ver" +
                    "sion=\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft.AspNetCore.Authent" +
                    "ication.Google\" Version=\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft" +
                    ".AspNetCore.Authentication.JwtBearer\" Version=\"2.0.1\" />\r\n      <PackageReferenc" +
                    "e Include = \"Microsoft.AspNetCore.Authentication.MicrosoftAccount\" Version=\"2.0." +
                    "1\" />\r\n      <PackageReference Include = \"Microsoft.AspNetCore.Authentication.Tw" +
                    "itter\" Version=\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft.AspNetCo" +
                    "re.Diagnostics.EntityFrameworkCore\" Version=\"2.0.1\" />\r\n      <PackageReference " +
                    "Include = \"Microsoft.AspNetCore.Identity.EntityFrameworkCore\" Version=\"2.0.1\" />" +
                    "\r\n      <PackageReference Include = \"Microsoft.AspNetCore.Mvc\" Version=\"2.0.2\" /" +
                    ">\r\n      <PackageReference Include = \"Microsoft.AspNetCore.StaticFiles\" Version=" +
                    "\"2.0.1\" />\r\n      <PackageReference Include = \"Microsoft.EntityFrameworkCore.Des" +
                    "ign\" Version=\"2.0.1\" PrivateAssets = \"All\" />\r\n      <PackageReference Include =" +
                    " \"Microsoft.EntityFrameworkCore.SqlServer\" Version=\"2.0.1\" />\r\n      <PackageRef" +
                    "erence Include = \"Microsoft.EntityFrameworkCore.SqlServer.Design\" Version=\"1.1.5" +
                    "\" PrivateAssets = \"All\" />\r\n      <PackageReference Include = \"Microsoft.EntityF" +
                    "rameworkCore.Tools\" Version=\"2.0.1\" PrivateAssets = \"All\" />\r\n      <PackageRefe" +
                    "rence Include = \"Microsoft.Extensions.Configuration.UserSecrets\" Version=\"2.0.0\"" +
                    " />\r\n      <PackageReference Include = \"Microsoft.Extensions.Logging.Debug\" Vers" +
                    "ion=\"2.0.0\" />\r\n      <PackageReference Include = \"Microsoft.VisualStudio.Web.Co" +
                    "deGeneration.Design\" Version=\"2.0.2\" PrivateAssets = \"All\" />\r\n      <PackageRef" +
                    "erence Include = \"Microsoft.VisualStudio.Web.BrowserLink\" Version=\"2.0.1\" />\r\n  " +
                    "    <PackageReference Include = \"Swashbuckle.AspNetCore\" Version=\"1.1.0\" />\r\n   " +
                    " </ItemGroup>\r\n    <ItemGroup>\r\n      <DotNetCliToolReference Include = \"Microso" +
                    "ft.EntityFrameworkCore.Tools.DotNet\" Version=\"2.0.1\" />\r\n      <DotNetCliToolRef" +
                    "erence Include = \"Microsoft.Extensions.SecretManager.Tools\" Version=\"2.0.0\" />\r\n" +
                    "      <DotNetCliToolReference Include = \"Microsoft.VisualStudio.Web.CodeGenerati" +
                    "on.Tools\" Version=\"2.0.2\" />\r\n    </ItemGroup>\r\n  </Project>");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}