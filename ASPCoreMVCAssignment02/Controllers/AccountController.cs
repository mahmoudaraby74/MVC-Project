﻿using Assignment02.Helper;
using Assignment02.Models.Account;
using DAL.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Assignment02.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        #region Sign Up
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(RegisterViewModel registerViewModel)
        {
            if(ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.Email.Split('@')[0],
                    IsAgree = registerViewModel.IsAgree

                };

                var result =await _userManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

            }
			return RedirectToAction("SignIn");

		}
		#endregion
		#region SignIn
		public IActionResult SignIn()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(loginViewModel.Email);
                if (user is not null)
                {
                    var password = await _userManager.CheckPasswordAsync(user, loginViewModel.Password);
                    if (password)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, loginViewModel.Password, loginViewModel.RemeberMe, false);
						if (result.Succeeded)
                        {
							return RedirectToAction("Index", "Home");

						}
                    }
                    ModelState.AddModelError(string.Empty, "Invalid Password");
                }
                ModelState.AddModelError(string.Empty, "Invalid Email");
            }
			return RedirectToAction("Index", "Home");
		}

		#endregion
		#region Sign Out
		public new async Task<IActionResult> SignOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("SignIn");
		}
		#endregion
		#region Forget Password
		public IActionResult ForgetPassword()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> SendEmail(ForgetPasswordViewModel forgetPasswordViewModel)
		{
			if (ModelState.IsValid)
			{
				var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Email);
				if (user is not null)
				{
					var token = await _userManager.GeneratePasswordResetTokenAsync(user); 
					var resetPasswordLink = Url.Action("ResetPassword", "Account", new { Email = forgetPasswordViewModel.Email, Token = token }, Request.Scheme);
					var email = new Email()
					{
						Title = "Reset Password",
						Body = resetPasswordLink,
						To = forgetPasswordViewModel.Email
					};
					EmailSettings.SendEmail(email);
					return RedirectToAction("CompleteForgetPassword");
				}
				ModelState.AddModelError(string.Empty, "Invalid Email");
			}
			return View(forgetPasswordViewModel);
		}
		#endregion

		public IActionResult CompleteForgetPassword()
		{
			return View();
		}
		#region Reset Password

		public IActionResult ResetPassword(string email, string token)
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
		{
			if (ModelState.IsValid)
			{
			

				var user = await _userManager.FindByEmailAsync(resetPasswordViewModel.Email);
				if(user is not null)
				{
					var result = await _userManager.ResetPasswordAsync(user, resetPasswordViewModel.Token, resetPasswordViewModel.Password);
					if (result.Succeeded)
						return RedirectToAction("ResetPasswordDone");
					foreach (var error in result.Errors)
						ModelState.AddModelError(string.Empty, error.Description);
				}
				
			}
			return View(resetPasswordViewModel);
		}
		public IActionResult ResetPasswordDone()
		{
			return View();
		} 


















		//{
		//	var prop = new AuthenticationProperties { RedirectUri = Url.Action("GoogleResponse") };
		//	return Challenge(prop, GoogleDefaults.AuthenticationScheme);
		//}

		//public async Task<IActionResult> GoogleResponse()
		//{
		//	var result = await HttpContext.AuthenticateAsync(GoogleDefaults.AuthenticationScheme);
		//	var Claims = result.Principal.Identities.FirstOrDefault().Claims.Select(cliam => new
		//	{
		//		cliam.Issuer,
		//		cliam.OriginalIssuer,
		//		cliam.Type,
		//		cliam.Value
		//	});
		//	return Json(Claims);
		//}

		#endregion
	}
}
