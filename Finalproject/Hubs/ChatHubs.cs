using Finalproject.Data;
using Finalproject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Hubs
{
    public class ChatHubs : Hub
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public ChatHubs(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }


        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }



        public async Task SendPrivate(string reciverid, string senderid, string message)
        {
            await Clients.User(reciverid).SendAsync("ReceiveMessage", senderid, message);
            Chat newMessage = new Chat();
            newMessage.Text = message;
            newMessage.SenderId = senderid;
            newMessage.RecieverId = reciverid;

            _context.Chats.Add(newMessage);
            _context.SaveChanges();

            //await Clients.All.SendAsync("ReceiveMessage", reciverid, message);
        }
    }
}

