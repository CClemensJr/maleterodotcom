using Maletero.Models;
using Maletero.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
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
        private IEmailSender _emailSender;

        /// <summary>
        /// This custom constructer assigns the values of an object at create to the class properties
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="signInManager"></param>
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, IEmailSender emailSender)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailSender = emailSender;
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

        /// <summary>
        /// This method sends user info to the service provider
        /// </summary>
        /// <param name="serviceprovider"></param>
        /// <returns>grant access</returns>
        [HttpPost]
        public IActionResult ExternalLogin(string serviceprovider)
        {
            //set the redirect for after OAUTH is established
            var redirectUrl = Url.Action(nameof(ExternalLoginCallback), "Account");
            //properties for the providers
            var properties = _signInManager.ConfigureExternalAuthenticationProperties(serviceprovider, redirectUrl);
            
            //challenge starts the grant access process
            return Challenge(properties, serviceprovider);
        }

        /// <summary>
        /// if there is an error, the user with be redirected to login.  If successful, redirect to home page
        /// </summary>
        /// <param name="error"></param>
        /// <returns>external login</returns>
        [HttpGet]
        public async Task<IActionResult> ExternalLoginCallback(string error = null)
        {
            //if there is a login error, redirect them to login
            if(error != null)
            {
                TempData["Error"] = "Service Provider Error";
                return RedirectToAction("Login");
            }

            //verify that the app supports the service provider
            var info = await _signInManager.GetExternalLoginInfoAsync();

            //if there is no info, return back to login
            if (info ==  null)
            {
                return RedirectToAction(nameof(Login));
            }

            //login with the external provider using the info from the sign in manager
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);

            //if login is successful, redirect to home page
            if (result.Succeeded)
            {
                //go to index on the home
                return RedirectToAction("Index", "Home");
            }

            //get email if this is the first request
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);

            //redirect to external login for the user to log in
            return View("ExternalLoginConfirmation", new ExternalLoginViewModel { Email = email });
        }

        /// <summary>
        /// Confirms external login by either returning a loading error or signing in the user
        /// </summary>
        /// <param name="elvm"></param>
        /// <returns>external login view model</returns>
        [HttpPost]
        public async Task<IActionResult> ExternalLoginConfirmation(ExternalLoginViewModel elvm)
        {
            if (ModelState.IsValid)
            {
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    TempData["Error"] = "Loading error";
                }

                //create a user
                var user = new ApplicationUser {
                    UserName = elvm.Email,
                    Email = elvm.Email,
                    FirstName = elvm.FirstName,
                    LastName = elvm.LastName
                };
                var result = await _userManager.CreateAsync(user);
                
                if(result.Succeeded)
                {
                    Claim fullNameClaim = new Claim("FullName", $"{ user.FirstName } {user.LastName }");
                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    List<Claim> allClaims = new List<Claim> { fullNameClaim, emailClaim };

                    await _userManager.AddClaimsAsync(user, allClaims);

                    result = await _userManager.AddLoginAsync(user, info);

                    if (result.Succeeded)
                    {
                        await _signInManager.SignInAsync(user, isPersistent: false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }
            return View(elvm);
        }
    }
}
