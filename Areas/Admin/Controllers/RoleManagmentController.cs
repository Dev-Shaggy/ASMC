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
    [Authorize(Roles = "Admin")]
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
                foreach (var err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }
            }
            return View(model);
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
        public async Task<IActionResult> Edit(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("_NotFound");
            }
            var model = new EditRoleVM
            {
                Id = role.Id,
                Name = role.Name
            };

            foreach (var user in userManager.Users)
            {
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    model.Users.Add(user.UserName);
                }
            }

            return View(model);
        }
        public async Task<IActionResult> EditUsersInRoles(string roleId)
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {roleId} cannot be found";
                return View("_NotFound");
            }
            var model = new List<UserRoleVM>();

            foreach (var user in userManager.Users)
            {
                var userRoleVM = new UserRoleVM
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };
                if (await userManager.IsInRoleAsync(user, role.Name))
                {
                    userRoleVM.IsSelected = true;
                }
                else
                {
                    userRoleVM.IsSelected = false;
                }
                model.Add(userRoleVM);
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUsersInRoles(List<UserRoleVM> model, string roleId)
        {
            if (model.Count == 0)
            {
                ViewBag.ErrorMessage = "No users found";
                return View("_NotFound");
            }

            var role = await roleManager.FindByIdAsync(roleId);
            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with id = {roleId} cannot be found";
                return View("_NotFound");
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;
                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if (!result.Succeeded)
                {

                    return View(model);
                }
            }

            return RedirectToAction("Edit", new { Id = roleId });
        }
    }
}
