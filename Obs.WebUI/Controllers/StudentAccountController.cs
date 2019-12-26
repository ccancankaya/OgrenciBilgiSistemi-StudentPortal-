using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Obs.Business.Abstract;
using Obs.WebUI.Entities;
using Obs.WebUI.Models;

namespace Obs.WebUI.Controllers
{
    public class StudentAccountController : Controller
    {
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;

        private IStudentService _studentService;

        public StudentAccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager, IStudentService studentService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _studentService = studentService;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(StudentRegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = new CustomIdentityUser
                {
                    UserName = registerViewModel.StudentNumber.ToString(),
                    Email = registerViewModel.Email
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Student").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Student"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "Rol eklenemedi");
                            return View(registerViewModel);
                        }

                    }

                    _userManager.AddToRoleAsync(user, "Student").Wait();

                    return View("Login", "StudentAccount");
                }

            }
            return View(registerViewModel);
        }

        //[HttpPost]
        //public JsonResult VerifyNumber(int studentNumber)
        //{
        //    return Json(IsUserExist(studentNumber));
        //}

        //public bool IsUserExist(int studentNumber)
        //{
        //    var result = _studentService.GetByNumber(studentNumber);
        //    bool status;
        //    if (result == null)
        //    {
        //        status = false;
        //    }
        //    else
        //    {
        //        status = true;
        //    }

        //    return status;
        //}

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(StudentLoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = _signInManager.PasswordSignInAsync(loginViewModel.StudentNumber.ToString(), loginViewModel.Pssword, false, false).Result;
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Student");
                }

                ModelState.AddModelError("", "Giriş başarısız");
            }

            return View(loginViewModel);
        }

        public ActionResult LogOut()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }




    }
}