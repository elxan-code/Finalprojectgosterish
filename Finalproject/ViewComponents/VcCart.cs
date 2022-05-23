using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.ViewComponents
{
    public class VcCart : ViewComponent
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public VcCart(AppDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;

        }
        public IViewComponentResult Invoke()
        {
            VmHome vm = new VmHome()
            {
                Products = new List<Product>()
            };

            string cart = Request.Cookies["cart1"];
            //List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();
                vm.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();

            }

            return View(vm);
        }
    }
}
