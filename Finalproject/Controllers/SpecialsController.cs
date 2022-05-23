﻿using Finalproject.Data;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class SpecialsController : Controller
    {

        private readonly AppDbContext _context;
        public SpecialsController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            VmHome model = new VmHome()
            {

                Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).OrderByDescending(m => m.Id).ToList(),
                Advertisings = _context.Advertisings.ToList(),
                Comments = _context.Comments.ToList()

            };
            string cart1 = Request.Cookies["cart1"];
            if (!string.IsNullOrEmpty(cart1))
            {
                model.Cart2 = cart1.Split("-").ToList();
            }


            return View(model);
        }






    }
}
