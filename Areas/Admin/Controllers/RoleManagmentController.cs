using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdvancedSchoolManagment.Models;
using AdvancedSchoolManagment.Models.DbAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using AdvancedSchoolManagment.Areas.Identity.Models;
using AdvancedSchoolManagment.Models.Data;
using System.Threading.Tasks;
using AdvancedSchoolManagment.Areas.Admin.Models;

namespace AdvancedSchoolManagment.Areas.Admin.Controllers
{
    public class RoleManagmentController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUserDTO> userManager;

        public RoleManagmentController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUserDTO> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RoleVM model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole
                {
                    Name = model.Name
                };
                var result = await roleManager.CreateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                foreach(var err in result.Errors){
                    ModelState.AddModelError("",err.Description);
                }
            }
            return View(model);
        }
    
        public IActionResult Index(){
            var roles = roleManager.Roles; 
            return View(roles);
        }
        public async Task<IActionResult> Edit(string id){
            var role = await roleManager.FindByIdAsync(id);
            
            if(role == null){
                ViewBag.ErrorMessage =$"Role with Id = {id} cannot be found";
                return View("_NotFound");
            }
            var model = new EditRoleVM{
                Id = role.Id,
                Name = role.Name
            };

            foreach(var user in userManager.Users){
                if(await userManager.IsInRoleAsync(user,role.Name)){
                    model.Users.Add(user.UserName);
                }
            }
            
            return View(model);
        }
    }
}
