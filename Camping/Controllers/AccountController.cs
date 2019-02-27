using Camping.Models;
using Camping.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Camping.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> _userManager;
        private SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        /// <summary>
        /// Default Register Page
        /// </summary>
        /// <returns>Return the view of the register page</returns>
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel rvm)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new ApplicationUser()
                {
                    UserName = rvm.Email,
                    Email = rvm.Email,
                    FirstName = rvm.FirstName,
                    LastName = rvm.LastName,
                    Birthday = rvm.Birthday
                };

                var result = await _userManager.CreateAsync(user, rvm.Password);

                if (result.Succeeded)
                {
                    //CLAIMS
                    Claim fullNameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");

                    Claim birthdayClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"),
                    ClaimValueTypes.DateTime);

                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);

                    //LIST OF CLAIMS
                    List<Claim> claims = new List<Claim> { fullNameClaim, birthdayClaim, emailClaim };
                    await _userManager.AddClaimsAsync(user, claims);

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(rvm);
        }

        [HttpGet]
        public IActionResult Login() => View();

        //Logs a user in if password and email if credentials are valid
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel lvm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(lvm.Email, lvm.Password, false, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError(string.Empty, "Invalid Login Attempt");

            return View(lvm);
        }
        //Logout
        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult ExternalLogin(string provider)
        {
            var redirectedUrl = Url.Action(nameof(ExternalLoginCallback), "Account");
            var prop = _signInManager.ConfigureExternalAuthenticationProperties(provider, redirectedUrl);

            return Challenge(prop, provider);
        }

        [HttpGet]
        public async Task<IActionResult>ExternalLoginCallback(string error = null)
        {
            //if there are errors make them go back to try again
            if (error != null)
            {
                TempData["Error"] = "Error with the provider";
                return RedirectToAction("Login");
            }
            //check to see if out app supports the login provider
            var info = await _signInManager.GetExternalLoginInfoAsync();

            if (info == null)
            {
                return RedirectToAction("Login");
            }
            //login with the external provider given the info from our sign in manager
            var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, isPersistent: false, bypassTwoFactor: true);
            // redirect to home if successfull 
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }

            //get email
            var email = info.Principal.FindFirstValue(ClaimTypes.Email);

            //redirect to external login page
            return View("ExternalLogin", new ExternalLoginViewModel { Email = email });
        }

        public async Task<IActionResult>ExternalLoginConfirmation(ExternalLoginViewModel elvm)
        {
            if (ModelState.IsValid)
            {
                var info = await _signInManager.GetExternalLoginInfoAsync();
                if (info == null)
                {
                    TempData["Error"] = "Error loading information";
                }
                //create user
                //YOU CAN FORCE USER TO MAKE A PASSWORD HERE
                var user = new ApplicationUser {
                    UserName = elvm.Email,
                    Email = elvm.Email,
                    FirstName = elvm.FirstName,
                    LastName = elvm.LastName,
                    Birthday = elvm.Birthday
                };

                var result = await _userManager.CreateAsync(user);

                if (result.Succeeded)
                {

                    //CLAIMS
                    Claim fullNameClaim = new Claim("FullName", $"{user.FirstName} {user.LastName}");

                    Claim birthdayClaim = new Claim(ClaimTypes.DateOfBirth, new DateTime(user.Birthday.Year, user.Birthday.Month, user.Birthday.Day).ToString("u"),
                    ClaimValueTypes.DateTime);

                    Claim emailClaim = new Claim(ClaimTypes.Email, user.Email, ClaimValueTypes.Email);


                    //LIST OF CLAIMS
                    List<Claim> claims = new List<Claim> { fullNameClaim, birthdayClaim, emailClaim };
                    await _userManager.AddClaimsAsync(user, claims);

                    result = await _userManager.AddLoginAsync(user, info);
                    if (result.Succeeded)
                    {
                    //sign in the user redirect to home
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                    }
                }
            }
        return View(elvm);
        }
    }
}
