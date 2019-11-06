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

namespace AdvancedSchoolManagment.Areas.Identity.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUserDTO> _userManager;
        private readonly SignInManager<ApplicationUserDTO> _signInManager;

        public AccountController(UserManager<ApplicationUserDTO> userManager, SignInManager<ApplicationUserDTO> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                
                var result = await _signInManager.PasswordSignInAsync(model.Login,model.Password,model.RememberMe,false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home", new {area = ""});
                }
                    ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }
            return View(model);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUserDTO
                {
                    UserName = model.Login,
                    Email = model.Email
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
    }
}
