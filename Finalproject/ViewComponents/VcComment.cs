using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewComponents
{
    public class VcComment : ViewComponent
    {
        private readonly AppDbContext _context;


        public VcComment(AppDbContext context)
        {
            _context = context;

        }
        public IViewComponentResult Invoke()
        {

            Comment model = new Comment();
            return View(model);

        }
    }
}
