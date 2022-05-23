using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{

    public class AccountController : Controller
    {
      
            private readonly UserManager<IdentityUser> _userManager;
            private readonly SignInManager<IdentityUser> _signInManager;
               private readonly AppDbContext _context;

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
            {
                _userManager = userManager;
                _signInManager = signInManager;
               _context = context;
        }
            public IActionResult Register()
            {
                return View();
            }
            [HttpPost]
        public async Task<IActionResult> Register(VmUserRegister model)
        {
            if (ModelState.IsValid)
            {

                CustomUser user = new CustomUser()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    UserName = model.Email,
                    Email = model.Email,
                    IsAdmin = model.IsAdmin
                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("khan.web.mmc@gmail.com", "GoBazar Best Online Shop");
                    mail.To.Add(user.Email);
                    mail.Subject = "Thanks For Register";
                    string body = "<h1 style='font-size:30px; color:green; font-weight: bold;'>The register complate successfully</h1>";
                 
                    mail.Body = body;
                    mail.IsBodyHtml = true;
                    //mail.CC.Add("shohret550@gmail.com");
                    //mail.Bcc.Add("shohrat@code.edu.az");

                    SmtpClient client = new SmtpClient();
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential("khan.web.mmc@gmail.com", "qorod789");

                    client.Send(mail);
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("index", "home");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);

                    }
                }
                return View(model);
            }
            return View(model);
        }
        public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
        public async Task<IActionResult> Login(VmUserLogin model)
        {
            if (ModelState.IsValid)
            {           

                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("index", "home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Email or Password is not Valid");
                        return View(model);
                    }
                }

            
            return View(model);
        }

        public async Task<IActionResult> Logout()
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("login");
            }

        }



    
}
