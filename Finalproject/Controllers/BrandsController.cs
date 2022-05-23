using Finalproject.Data;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class BrandsController : Controller
    {
        private readonly AppDbContext _context;
        public BrandsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {

                Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).ToList(),
                Advertisings = _context.Advertisings.ToList()


            };
         

            return View(model);
        }
    }
}
