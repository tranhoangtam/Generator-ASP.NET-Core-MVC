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
    
    #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Controllers\RoleAdminController.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class RoleAdminController : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            this.Write("\r\n");
            
            #line 1 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Controllers\RoleAdminController.tt"
 var model = (SmartAppInfo)Model; 
            
            #line default
            #line hidden
            this.Write(@"using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using ");
            
            #line 11 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Controllers\RoleAdminController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Models;\r\n\r\nnamespace ");
            
            #line 13 "C:\Users\PC\Documents\Gits\ASP.NET-Core-MVC\src\Common\Templates\Controllers\RoleAdminController.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(model.Id));
            
            #line default
            #line hidden
            this.Write(".Backend.Controllers\r\n{\r\n\t[Authorize]\r\n    public partial class RoleAdminControll" +
                    "er : Controller\r\n    {\r\n\t\tprivate readonly UserManager<ApplicationUser> _userMan" +
                    "ager;\r\n        private readonly RoleManager<IdentityRole> _roleManager;\r\n       " +
                    " \r\n        public RoleAdminController()\r\n        {\r\n\r\n        }\r\n        \r\n     " +
                    "   public RoleAdminController(UserManager<ApplicationUser> userManager,\r\n       " +
                    " RoleManager<IdentityRole> roleManager)\r\n        {\r\n            _userManager = u" +
                    "serManager;\r\n\t\t\t_roleManager = roleManager;\r\n        }\r\n        \r\n        \r\n    " +
                    "    //\r\n        // GET: /Roles/\r\n        public ActionResult Index()\r\n        {\r" +
                    "\n            return View(this._roleManager.Roles);\r\n        }\r\n        \r\n       " +
                    " //\r\n        // GET: /Roles/Details/5\r\n        public async Task < ActionResult " +
                    "> Details(string id)\r\n        {\r\n            if (id == null) {\r\n                " +
                    "return new StatusCodeResult((int)HttpStatusCode.BadRequest);\r\n            }\r\n   " +
                    "         var role = await _roleManager.FindByIdAsync(id);\r\n            // Get th" +
                    "e list of Users in this Role\r\n            var users = new List <ApplicationUser>" +
                    "();\r\n            \r\n            // Get the list of Users in this Role\r\n          " +
                    "  foreach( var user in _userManager.Users.ToList())\r\n            {\r\n            " +
                    "    if (await _userManager.IsInRoleAsync(user, role.Name))\r\n                {\r\n " +
                    "                   users.Add(user);\r\n                }\r\n            }\r\n         " +
                    "   \r\n            ViewBag.Users = users;\r\n            ViewBag.UserCount = users.C" +
                    "ount();\r\n            return View(role);\r\n        }\r\n        \r\n        //\r\n      " +
                    "  // GET: /Roles/Create\r\n        public ActionResult Create()\r\n        {\r\n      " +
                    "      return View();\r\n        }\r\n        \r\n        //\r\n        // POST: /Roles/C" +
                    "reate\r\n        [HttpPost]\r\n        public async Task <IActionResult> Create(Role" +
                    "ViewModel roleViewModel)\r\n        {\r\n            if (ModelState.IsValid) {\r\n    " +
                    "            var role = new IdentityRole(roleViewModel.Name);\r\n                va" +
                    "r roleresult = await _roleManager.CreateAsync(role);\r\n                if (!roler" +
                    "esult.Succeeded) {\r\n                    ModelState.AddModelError(\"\", roleresult." +
                    "Errors.First().Description);\r\n                    return View();\r\n              " +
                    "  }\r\n                return RedirectToAction(\"Index\");\r\n            }\r\n         " +
                    "   return View();\r\n        }\r\n        \r\n        //\r\n        // GET: /Roles/Edit/" +
                    "Admin\r\n        public async Task <IActionResult> Edit(string id)\r\n        {\r\n   " +
                    "         if (id == null) {\r\n                return new StatusCodeResult((int)Htt" +
                    "pStatusCode.BadRequest);\r\n            }\r\n            var role = await _roleManag" +
                    "er.FindByIdAsync(id);\r\n            if (role == null) {\r\n                return N" +
                    "otFound();\r\n            }\r\n            RoleViewModel roleModel = new RoleViewMod" +
                    "el{ Id = role.Id, Name = role.Name };\r\n            return View(roleModel);\r\n    " +
                    "    }\r\n        \r\n        //\r\n        // POST: /Roles/Edit/5\r\n        [HttpPost]\r" +
                    "\n\r\n        [ValidateAntiForgeryToken]\r\n        public async Task <IActionResult>" +
                    " Edit([Bind(\"Name,Id\")] RoleViewModel roleModel)\r\n        {\r\n            if (Mod" +
                    "elState.IsValid) {\r\n                var role = await _roleManager.FindByIdAsync(" +
                    "roleModel.Id);\r\n                role.Name = roleModel.Name;\r\n                awa" +
                    "it _roleManager.UpdateAsync(role);\r\n                return RedirectToAction(\"Ind" +
                    "ex\");\r\n            }\r\n            return View();\r\n        }\r\n        \r\n        /" +
                    "/\r\n        // GET: /Roles/Delete/5\r\n        public async Task <IActionResult> De" +
                    "lete(string id)\r\n        {\r\n            if (id == null) {\r\n                retur" +
                    "n new StatusCodeResult((int)HttpStatusCode.BadRequest);\r\n            }\r\n        " +
                    "    var role = await _roleManager.FindByIdAsync(id);\r\n            if (role == nu" +
                    "ll) {\r\n                return NotFound();\r\n            }\r\n            return Vie" +
                    "w(role);\r\n        }\r\n        \r\n        //\r\n        // POST: /Roles/Delete/5\r\n   " +
                    "     [HttpPost, ActionName(\"Delete\")]\r\n        [ValidateAntiForgeryToken]\r\n     " +
                    "   public async Task <IActionResult> DeleteConfirmed(string id, string deleteUse" +
                    "r)\r\n        {\r\n            if (ModelState.IsValid) {\r\n                if (id == " +
                    "null) {\r\n                    return new StatusCodeResult((int)HttpStatusCode.Bad" +
                    "Request);\r\n                }\r\n                var role = await _roleManager.Find" +
                    "ByIdAsync(id);\r\n                if (role == null) {\r\n                    return " +
                    "NotFound();\r\n                }\r\n                \r\n                if (Security.R" +
                    "oles.GetAll().Any(r => role.Name.Equals(r.Key, StringComparison.OrdinalIgnoreCas" +
                    "e)))\r\n                {\r\n                    ModelState.AddModelError(\"\", new Ar" +
                    "gumentException(\"cant_delete_default_role\"), null);\r\n                    return " +
                    "View();\r\n                }\r\n                \r\n                \r\n                " +
                    "IdentityResult result;\r\n                if (deleteUser != null) {\r\n             " +
                    "       result = await _roleManager.DeleteAsync(role);\r\n                }\r\n      " +
                    "          else {\r\n                    result = await _roleManager.DeleteAsync(ro" +
                    "le);\r\n                }\r\n                if (!result.Succeeded) {\r\n             " +
                    "       ModelState.AddModelError(\"\", result.Errors.First().Description);\r\n       " +
                    "             return View();\r\n                }\r\n                return RedirectT" +
                    "oAction(\"Index\");\r\n            }\r\n            return View();\r\n        }\r\n    }\r\n" +
                    "}\r\n");
            return this.GenerationEnvironment.ToString();
        }
    }
    
    #line default
    #line hidden
}
