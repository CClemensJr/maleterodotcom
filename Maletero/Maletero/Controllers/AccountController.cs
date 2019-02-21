using Maletero.Models;
using Maletero.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        /// <summary>
        /// This custom constructer assigns the values of an object at create to the class properties
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// This action directs the user to the View page when the Register route is accessed
        /// </summary>
        /// <returns>A View page</returns>
        [HttpGet]
        public IActionResult Register() => View();

        /// <summary>
        /// Upon form submission this assigns the form values to an ApplicationUser object if the viewmodel is valid. It then redirects to the home page
        /// </summary>
        /// <param name="rvm"></param>
        /// <returns>A view action result</returns>
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel register)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = register.Email,
                    Email = register.Email,
                    FirstName = register.FirstName,
                    LastName = register.LastName,
                    Birthday = register.Birthday
                };

                var result = await _userManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("FullName", $"{ user.FirstName } {user.LastName }");

                    await _signInManager.SignInAsync(user, isPersistent: false);

                    return RedirectToAction("Index", "Home");
                }
            }

            return View(register);
        }

        /// <summary>
        /// This action directs the user to the View page when the Login route is accessed
        /// </summary>
        /// <returns>A View page</returns>
        [HttpGet]
        public IActionResult Login() => View();

        /// <summary>
        /// This method takes in the email and password from a form and redirects to a home page if login is valid
        /// </summary>
        /// <param name="login"></param>
        /// <returns>A View</returns>
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid Login");

            return View(login);
        }
    }
}
