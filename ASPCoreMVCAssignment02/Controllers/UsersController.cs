﻿using AutoMapper;
using DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment02.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string SearchValue = "")
        {

            if (string.IsNullOrEmpty(SearchValue))
            {
                var users = _userManager.Users.ToList();
                return View(users);
            }

            else
            {
                var user = await _userManager.FindByNameAsync(SearchValue);
                return View(new List<ApplicationUser> { user });
            }


        }
        public async Task<IActionResult> Details(string id)
        {
            if (id is null)
                return NotFound();

            var user = await _userManager.FindByIdAsync(id);


            if (user is null)
                return NotFound();

            return View(user);
        }
        public async Task<IActionResult> Update(string id)
        {

            if (id is null)
                return NotFound();

            var user = await _userManager.FindByIdAsync(id);


            if (user is null)
                return NotFound();

            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(string id, ApplicationUser applicationUser)
        {
            if (id != applicationUser.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var user = await _userManager.FindByIdAsync(id);

                    user.UserName = applicationUser.UserName;
                    user.NormalizedUserName = applicationUser.UserName.ToUpper();
                    user.PhoneNumber = applicationUser.PhoneNumber;

                    var result = await _userManager.UpdateAsync(user);

                    if (result.Succeeded)
                        return RedirectToAction("Index");

                    foreach (var error in result.Errors)
                        ModelState.AddModelError(string.Empty, error.Description);



                }
                catch (Exception ex)
                {
                    throw;
                }
            }
            return View();

        }
        
        public async Task<IActionResult> Delete(string id)
        {
            if (id is null)
                return NotFound();
            try
            {
                var user = await _userManager.FindByIdAsync(id);

                var result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);

            }
            catch (Exception ex)
            {
                throw;
            }
            return RedirectToAction("Index");
        }
    }
        
}
