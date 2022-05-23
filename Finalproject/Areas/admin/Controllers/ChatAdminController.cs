using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Areas.admin.Controllers
{
    [Area("admin")]
    [Authorize]
    public class ChatAdminController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public ChatAdminController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            List<CustomUser> users = _context.CustomUsers.Where(u => u.Id != _userManager.GetUserId(User)).ToList();
            return View(users);
        }
        public IActionResult Message(string reciverid)
        {
            string senderid = _userManager.GetUserId((System.Security.Claims.ClaimsPrincipal)User);
            VmChat model = new VmChat();
            model.Reciever = _context.CustomUsers.Find(reciverid);
            model.Messages = _context.Chats.Where(m => (m.SenderId == senderid && m.RecieverId == reciverid) ||
                                                          (m.SenderId == reciverid && m.RecieverId == senderid))
                                              .ToList();
            return View(model);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contact = await _context.Contacts
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contact == null)
            {
                return NotFound();
            }

            return View(contact);
        }

        public IActionResult Delete(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Contact message = _context.Contacts.Find(id);


            if (message == null)
            {
                return NotFound();
            }
            _context.Contacts.Remove(message);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}