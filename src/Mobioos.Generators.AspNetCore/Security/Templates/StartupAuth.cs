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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class StartupAuth : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 2 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write(@"using System;
using System.Text;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using ");
            
            #line 11 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models;\r\nusing ");
            
            #line 12 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Auth;\r\n\r\nnamespace ");
            
            #line 14 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend\r\n{\r\n    public partial class Startup\r\n    {\r\n        // todo: get this f" +
                    "rom somewhere secure\r\n        private const string SecretKey = \"iNivDmHLpUA223sq" +
                    "sfhqGbMRdRj1PVkH\";\r\n\r\n        private readonly SymmetricSecurityKey _signingKey " +
                    "= new SymmetricSecurityKey(\r\n            Encoding.ASCII.GetBytes(SecretKey));\r\n\r" +
                    "\n        public void ConfigureAuth(IServiceCollection services)\r\n        {\r\n    " +
                    "        services.AddTransient<IJwtFactory, JwtFactory>();\r\n\r\n            service" +
                    "s\r\n                .AddIdentity<ApplicationUser, IdentityRole>()\r\n              " +
                    "  .AddEntityFrameworkStores<ApplicationDbContext>()\r\n                .AddDefault" +
                    "TokenProviders();\r\n\r\n            var jwtSettingOptions = Configuration.GetSectio" +
                    "n(nameof(JwtIssuerOptions));\r\n\r\n            // Configure JwtIssuerOptions\r\n     " +
                    "       services.Configure<JwtIssuerOptions>(options =>\r\n            {\r\n         " +
                    "       options.Issuer = jwtSettingOptions[nameof(JwtIssuerOptions.Issuer)];\r\n   " +
                    "             options.Audience = jwtSettingOptions[nameof(JwtIssuerOptions.Audien" +
                    "ce)];\r\n                options.SigningCredentials = new SigningCredentials(\r\n   " +
                    "                 _signingKey,\r\n                    SecurityAlgorithms.HmacSha256" +
                    ");\r\n            });\r\n\r\n            // Get options from app settings\r\n           " +
                    " var authSettings = Configuration.GetSection(nameof(AuthSettings));\r\n\r\n         " +
                    "   // Configure AuthSettings\r\n            services.Configure<AuthSettings>(optio" +
                    "ns =>\r\n            {\r\n                options.FacebookAppId = authSettings[nameo" +
                    "f(AuthSettings.FacebookAppId)];\r\n                options.FacebookAppSecret = aut" +
                    "hSettings[nameof(AuthSettings.FacebookAppSecret)];\r\n                options.Twit" +
                    "terAppId = authSettings[nameof(AuthSettings.TwitterAppId)];\r\n                opt" +
                    "ions.TwitterAppSecret = authSettings[nameof(AuthSettings.TwitterAppSecret)];\r\n  " +
                    "              options.GoogleAppId = authSettings[nameof(AuthSettings.GoogleAppId" +
                    ")];\r\n                options.GoogleAppSecret = authSettings[nameof(AuthSettings." +
                    "GoogleAppSecret)];\r\n                options.MicrosoftAppId = authSettings[nameof" +
                    "(AuthSettings.MicrosoftAppId)];\r\n                options.MicrosoftAppSecret = au" +
                    "thSettings[nameof(AuthSettings.MicrosoftAppSecret)];\r\n            });\r\n\r\n       " +
                    "     var tokenValidationParameters = new TokenValidationParameters\r\n            " +
                    "{\r\n                ValidateIssuer = true,\r\n                ValidIssuer = jwtSett" +
                    "ingOptions[nameof(JwtIssuerOptions.Issuer)],\r\n\r\n                ValidateAudience" +
                    " = true,\r\n                ValidAudience = jwtSettingOptions[nameof(JwtIssuerOpti" +
                    "ons.Audience)],\r\n\r\n                ValidateIssuerSigningKey = true,\r\n           " +
                    "     IssuerSigningKey = _signingKey,\r\n\r\n                RequireExpirationTime = " +
                    "false,\r\n                ValidateLifetime = true,\r\n                ClockSkew = Ti" +
                    "meSpan.Zero\r\n            };\r\n\r\n");
            
            #line 77 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

    if (AuthenticationKeys != null)
    {

            
            #line default
            #line hidden
            this.Write(@"            var authServices = services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(cfg => cfg.SlidingExpiration = true)
            .AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });
");
            
            #line 93 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

        if (AuthenticationKeys.ContainsKey("FacebookAuthConsumerKey")
            && AuthenticationKeys.ContainsKey("FacebookAuthConsumerSecret"))
        {

            
            #line default
            #line hidden
            this.Write(@"            authServices.AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = authSettings[nameof(AuthSettings.FacebookAppId)];
                facebookOptions.AppSecret = authSettings[nameof(AuthSettings.FacebookAppSecret)];
            });
");
            
            #line 103 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

        }

        if (AuthenticationKeys.ContainsKey("TwitterAuthAppId")
            && AuthenticationKeys.ContainsKey("TwitterAuthAppSecret"))
        {

            
            #line default
            #line hidden
            this.Write(@"            authServices.AddTwitter(twitterOptions =>
            {
                twitterOptions.ConsumerKey = authSettings[nameof(AuthSettings.TwitterAppId)];
                twitterOptions.ConsumerSecret = authSettings[nameof(AuthSettings.TwitterAppSecret)];
            });
");
            
            #line 115 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

        }

        if (AuthenticationKeys.ContainsKey("GoogleAuthClientId")
            && AuthenticationKeys.ContainsKey("GoogleAuthSecret"))
        {

            
            #line default
            #line hidden
            this.Write(@"            authServices.AddGoogle(googleOptions =>
            {
                googleOptions.ClientId = authSettings[nameof(AuthSettings.GoogleAppId)];
                googleOptions.ClientSecret = authSettings[nameof(AuthSettings.GoogleAppSecret)];
            });
");
            
            #line 127 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

        }

        if (AuthenticationKeys.ContainsKey("MicrosoftAuthClientId")
            && AuthenticationKeys.ContainsKey("MicrosoftAuthSecret"))
        {

            
            #line default
            #line hidden
            this.Write(@"            services
                .AddAuthentication()
                .AddMicrosoftAccount(microsoftOptions =>
                {
                    microsoftOptions.ClientId = authSettings[nameof(AuthSettings.MicrosoftAppId)];
                    microsoftOptions.ClientSecret = authSettings[nameof(AuthSettings.MicrosoftAppSecret)];
                });
");
            
            #line 141 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Mobioos.Generators.AspNetCore\Security\Templates\StartupAuth.tt"

        }
    }

            
            #line default
            #line hidden
            this.Write("\r\n            services.Configure<IdentityOptions>(options =>\r\n            {\r\n    " +
                    "            // Password settings\r\n\r\n                // Lockout settings\r\n       " +
                    "         options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);\r\n   " +
                    "             options.Lockout.MaxFailedAccessAttempts = 10;\r\n                opti" +
                    "ons.Lockout.AllowedForNewUsers = true;\r\n\r\n                // User settings\r\n    " +
                    "            options.User.RequireUniqueEmail = true;\r\n            });\r\n\r\n        " +
                    "    services.ConfigureApplicationCookie(options =>\r\n            {\r\n             " +
                    "   // Cookie settings\r\n                options.Cookie.HttpOnly = true;\r\n        " +
                    "        options.Cookie.Expiration = TimeSpan.FromDays(150);\r\n                // " +
                    "If the LoginPath is not set here, ASP.NET Core will default to /Account/Login\r\n " +
                    "               options.LoginPath = \"/Account/Login\";\r\n                // If the " +
                    "LogoutPath is not set here, ASP.NET Core will default to /Account/Logout\r\n      " +
                    "          options.LogoutPath = \"/Account/Logout\";\r\n                // If the Acc" +
                    "essDeniedPath is not set here, ASP.NET Core will default to /Account/AccessDenie" +
                    "d\r\n                options.AccessDeniedPath = \"/Account/AccessDenied\";\r\n        " +
                    "        options.SlidingExpiration = true;\r\n            });\r\n        }\r\n\r\n       " +
                    " public void ConfigureAuth(IApplicationBuilder app)\r\n        {\r\n            app." +
                    "UseAuthentication();\r\n\r\n            // Add external authentication middleware be" +
                    "low.\r\n            // To configure them please see https://go.microsoft.com/fwlin" +
                    "k/?LinkID=532715\r\n        }\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}