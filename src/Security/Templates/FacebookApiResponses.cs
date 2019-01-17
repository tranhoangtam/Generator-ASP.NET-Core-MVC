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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Security\Templates\FacebookApiResponses.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class FacebookApiResponses : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Security\Templates\FacebookApiResponses.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("using Newtonsoft.Json;\r\n\r\nnamespace ");
            
            #line 4 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Security\Templates\FacebookApiResponses.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(@".Backend.Auth
{
	internal class FacebookUserData
	{
		public long Id { get; set; }
		public string Email { get; set; }
		public string Name { get; set; }
		[JsonProperty(""first_name"")]
		public string FirstName { get; set; }
		[JsonProperty(""last_name"")]
		public string LastName { get; set; }
		public string Gender { get; set; }
		public string Locale { get; set; }
		public FacebookPictureData Picture { get; set; }
	}

	internal class FacebookPictureData
	{
		public FacebookPicture Data { get; set; }
	}

	internal class FacebookPicture
	{
		public int Height { get; set; }
		public int Width { get; set; }
		[JsonProperty(""is_silhouette"")]
		public bool IsSilhouette { get; set; }
		public string Url { get; set; }
	}

	internal class FacebookUserAccessTokenData
	{
		[JsonProperty(""app_id"")]
		public long AppId { get; set; }
		public string Type { get; set; }
		public string Application { get; set; }
		[JsonProperty(""expires_at"")]
		public long ExpiresAt { get; set; }
		[JsonProperty(""is_valid"")]
		public bool IsValid { get; set; }
		[JsonProperty(""user_id"")]
		public long UserId { get; set; }
	}

	internal class FacebookUserAccessTokenValidation
	{
		public FacebookUserAccessTokenData Data { get; set; }
	}

	internal class FacebookAppAccessToken
	{
		[JsonProperty(""token_type"")]
		public string TokenType { get; set; }
		[JsonProperty(""access_token"")]
		public string AccessToken { get; set; }
	}
}
");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
