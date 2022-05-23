using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewComponents
{
    public class VcChat : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public VcChat(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
            _signInManager = signInManager;

        }
        public IViewComponentResult Invoke(string reciverid= "8b0b7538-8b71-4af2-9c64-3709144afd65")
        {

            string senderid = _userManager.GetUserId((System.Security.Claims.ClaimsPrincipal)User);
            VmChat model = new VmChat();
            model.Reciever = _context.CustomUsers.Find(reciverid);
            model.Messages = _context.Chats.Where(m => (m.SenderId == senderid && m.RecieverId == reciverid) ||
                                                          (m.SenderId == reciverid && m.RecieverId == senderid))
                                              .ToList();
            return View(model);
        }
    }
}
