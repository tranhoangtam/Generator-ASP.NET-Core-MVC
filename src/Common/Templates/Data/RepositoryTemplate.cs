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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Data\RepositoryTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class RepositoryTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Data\RepositoryTemplate.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write("using Microsoft.EntityFrameworkCore; \r\nusing System; \r\nusing System.Collections.G" +
                    "eneric; \r\nusing System.Linq; \r\nusing System.Threading.Tasks; \r\nusing  ");
            
            #line 7 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Data\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models;\r\n\r\nnamespace ");
            
            #line 9 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Data\RepositoryTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Repositories\r\n{ \r\n    public class Repository<T> : IRepository<T> where " +
                    "T : class\r\n    { \r\n        protected readonly ApplicationDbContext DbContext;\r\n " +
                    "\r\n        public Repository(ApplicationDbContext context) \r\n        { \r\n        " +
                    "    DbContext = context; \r\n        }\r\n\r\n        public IQueryable<T> GetAll() \r\n" +
                    "        { \r\n            return DbContext.Set<T>().AsNoTracking(); \r\n        } \r\n" +
                    "        \r\n\t\tpublic async Task<T> Get(object[] param)\r\n        {\r\n            ret" +
                    "urn await DbContext.Set<T>().FindAsync(param);\r\n        }\r\n\r\n        public asyn" +
                    "c Task Insert(T entity) \r\n        { \r\n            if (entity == null) \r\n        " +
                    "    { \r\n                throw new ArgumentNullException(nameof(entity)); \r\n     " +
                    "       } \r\n\r\n           \tawait DbContext.Set<T>().AddAsync(entity); \r\n          " +
                    "  await DbContext.SaveChangesAsync(); \r\n        } \r\n \r\n        public async Task" +
                    " Update(T entity) \r\n        { \r\n            if (entity == null) \r\n            { " +
                    "\r\n                throw new ArgumentNullException(nameof(entity)); \r\n           " +
                    " } \r\n\t\t\t\r\n\t\t\tDbContext.Set<T>().Update(entity); \r\n            await DbContext.Sa" +
                    "veChangesAsync(); \r\n        }\r\n\r\n\t\tpublic async Task Update(T oldEntity, T entit" +
                    "y) \r\n\t\t{ \r\n\t\t\tif (entity == null) \r\n\t\t\t{ \r\n\t\t\t\tthrow new ArgumentNullException(n" +
                    "ameof(entity)); \r\n\t\t\t}\r\n\r\n\t\t\tvar contextEntry = DbContext.Entry<T>(oldEntity);\r\n" +
                    "\t\t\tcontextEntry.State = EntityState.Detached;\r\n\t\t\tDbContext.Attach(entity);\r\n\t\t\t" +
                    "\r\n\t\t\tDbContext.Set<T>().Update(entity); \r\n\t\t\tawait DbContext.SaveChangesAsync();" +
                    " \r\n        } \r\n \r\n        public async Task Delete(T entity) \r\n        { \r\n     " +
                    "       if (entity == null) \r\n            { \r\n                throw new ArgumentN" +
                    "ullException(nameof(entity)); \r\n            } \r\n\r\n            DbContext.Set<T>()" +
                    ".Remove(entity); \r\n            await DbContext.SaveChangesAsync(); \r\n        } \r" +
                    "\n    } \r\n}");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
