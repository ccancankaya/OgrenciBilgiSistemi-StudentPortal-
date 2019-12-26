using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Obs.WebUI.Entities;
using Obs.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Obs.WebUI.Controllers
{
    public class TeacherAccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        public TeacherAccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(TeacherRegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {  
                var user = new CustomIdentityUser
                {
                    UserName = registerViewModel.UserName
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Teacher").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Teacher"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Rol eklenemedi");
                            return View(registerViewModel);
                        }
                    }
                    _userManager.AddToRoleAsync(user, "Teacher").Wait();
                    return RedirectToAction("Login", "TeacherAccount");
                }
            }

            return View(registerViewModel);
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(TeacherLoginViewModel teacherLoginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(teacherLoginViewModel.UserName, teacherLoginViewModel.Password, false, false).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Teacher");
                }

                ModelState.AddModelError("", "Giriş başarızsız");
            }

            return View(teacherLoginViewModel);

        }


        public ActionResult LogOut()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }



    }
}
