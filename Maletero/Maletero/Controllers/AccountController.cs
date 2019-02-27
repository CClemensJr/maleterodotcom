using Maletero.Models;
using Maletero.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    [AllowAnonymous]
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
                    Birthday = register.Birthday,
                    State = register.State
                };

                var result = await _userManager.CreateAsync(user, register.Password);

                if (result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("FullName", $"{ user.FirstName } {user.LastName }");

                    Claim birthDateClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"), ClaimValueTypes.DateTime);

                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    Claim stateClaim = new Claim(ClaimTypes.StateOrProvince, user.State.ToString());

                    List<Claim> allClaims = new List<Claim> { fullNameClaim, birthDateClaim, emailClaim, stateClaim };

                    await _userManager.AddClaimsAsync(user, allClaims);

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

        /// <summary>
        /// this method allows the user to logout out of their account
        /// </summary>
        /// <returns>returns to home page upon logout</returns>
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ExternalLogin(string serviceprovider)
        {
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account");
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(serviceprovider, redirectUrl);
            
            //challenge starts the grant access process
            //return of challenge redirects to callback url
            return Challenge(properties, serviceprovider);
        }

        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string error = null)
        {
            if(error != null)
            {
                TempData["Error"] = "Service Provider Error";
                return RedirectToAction("Login");
            }

            //verify that the app supports the service provider
            var info = await _signInManager.GetExternalLoginInfoAsync();

            if (info ==  null)
            {
                return RedirectToAction(nameof(Login));
            }

        }
    }
}
