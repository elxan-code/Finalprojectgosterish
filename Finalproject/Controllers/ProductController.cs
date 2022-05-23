using Finalproject.Data;
using Finalproject.Models;
using Finalproject.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        public ProductController(AppDbContext context)
        {
            _context = context;

        }
        public IActionResult Subcategory(int? id)
        {
            VmHome model = new VmHome()
            {
                SubCategories = _context.SubCategories.Where(m => m.CategoryId == id).ToList(),
                Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).ToList(),
                Advertisings = _context.Advertisings.ToList()



            };

            return View(model);

        }
        public IActionResult Product(string searchData, int? id)
        {
            VmHome model = new VmHome()
            {
                Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).ToList(),
                Advertisings = _context.Advertisings.ToList()
            };
            string cart1 = Request.Cookies["cart1"];
            if (!string.IsNullOrEmpty(cart1))
            {
                model.Cart2 = cart1.Split("-").ToList();
            }
            string cart2 = Request.Cookies["cart2"];
            if (!string.IsNullOrEmpty(cart1))
            {
                model.Cart1 = cart2.Split("-").ToList();
            }



            return View(model);

        }



        public IActionResult ProductDetails(int? id)
        {
            VmComment model = new VmComment()
            {
                Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).FirstOrDefault(p => p.Id == id),
                //Products= _context.Products.Where(pi => pi.Id == id).Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).ToList(),
                Comments = _context.Comments.OrderByDescending(pi => pi.CreatedDate).Where(pi => pi.ProductId == id).ToList(),


            };
            ViewBag.Id = id;
            //Product product = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).FirstOrDefault(p => p.Id == id);

            return View(model);
        }

        public IActionResult Message(Comment model, int star)
        {

            if (ModelState.IsValid)
            {
                model.CreatedDate = DateTime.Now;
                model.Star = star;
                _context.Add(model);
                _context.SaveChanges();
                ViewBag.salam = "sasaasas";
                HttpContext.Session.SetString("Success", "Your message has been sent successfully!");
                return RedirectToAction("ProductDetails", new { id = model.ProductId });
            };
            HttpContext.Session.SetString("Error", "Model is not valid");
            return RedirectToAction("ProductDetails", new { id = model.ProductId });

        }

        public IActionResult AddToCart(int id)
        {
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };

            string oldData = Request.Cookies["cart1"];
            string newData = null;
            //int basketCount = 0;

            if (!string.IsNullOrEmpty(oldData))
            {
                List<string> dataList = oldData.Split("-").ToList();

                if (!dataList.Any(c => c == id.ToString()))
                {

                    newData = oldData + "-" + id;
                    //basketCount = dataList.Count + 1;
                }
                else
                {
                    dataList.Remove(id.ToString());
                    newData = string.Join("-", dataList);
                    //return RedirectToAction("Cart", "Product");
                    //basketCount = dataList.Count;
                }
            }
            else
            {
                newData = id.ToString();

                //basketCount = 1;
            }

            Response.Cookies.Append("cart1", newData, options);
            //TempData["BasketCount"]  = basketCount;

            return RedirectToAction("Index", "Home");
        }

        public IActionResult DeleteToCart(int id)
        {
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };

            string oldData = Request.Cookies["cart1"];
            string newData = null;
            //int basketCount = 0;

            if (!string.IsNullOrEmpty(oldData))
            {
                List<string> dataList = oldData.Split("-").ToList();

                if (!dataList.Any(c => c == id.ToString()))
                {

                    newData = oldData + "-" + id;
                    //basketCount = dataList.Count + 1;
                }
                else
                {
                    dataList.Remove(id.ToString());
                    newData = string.Join("-", dataList);
                    //return RedirectToAction("Cart", "Product");
                    //basketCount = dataList.Count;
                }
            }
            else
            {
                newData = id.ToString();

                //basketCount = 1;
            }

            Response.Cookies.Append("cart1", newData, options);
            //TempData["BasketCount"]  = basketCount;

            return RedirectToAction("Index", "Home");
        }






        public IActionResult Cart()
        {
            VmHome vm = new VmHome()
            {
                Products = new List<Product>(),
                Comments = _context.Comments.ToList()


            };


            string cart1 = Request.Cookies["cart1"];
            if (!string.IsNullOrEmpty(cart1))
            {
                vm.Cart2 = cart1.Split("-").ToList();
            }
            string cart2 = Request.Cookies["cart2"];
            if (!string.IsNullOrEmpty(cart2))
            {
                vm.Cart1 = cart2.Split("-").ToList();
            }
            string cart = Request.Cookies["cart1"];
            //List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();
                vm.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();

            }



            return View(vm);
        }














        public IActionResult AddToWishlest(int id)
        {
            CookieOptions options = new CookieOptions()
            {
                Expires = DateTime.Now.AddYears(1)
            };

            string oldData = Request.Cookies["cart2"];
            string newData = null;
            //int basketCount = 0;

            if (!string.IsNullOrEmpty(oldData))
            {
                List<string> dataList = oldData.Split("-").ToList();

                if (!dataList.Any(c => c == id.ToString()))
                {

                    newData = oldData + "-" + id;
                    //basketCount = dataList.Count + 1;
                }
                else
                {
                    dataList.Remove(id.ToString());
                    newData = string.Join("-", dataList);
                    //return RedirectToAction("Cart", "Product");
                    //basketCount = dataList.Count;
                }
            }
            else
            {
                newData = id.ToString();

                //basketCount = 1;
            }

            Response.Cookies.Append("cart2", newData, options);
            //TempData["BasketCount"]  = basketCount;

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Wishlest()
        {
            VmHome vm = new VmHome()
            {
                Products = new List<Product>(),
                Comments = _context.Comments.ToList()


            };
            string cart1 = Request.Cookies["cart1"];
            if (!string.IsNullOrEmpty(cart1))
            {
                vm.Cart2 = cart1.Split("-").ToList();
            }
            string cart2 = Request.Cookies["cart2"];
            if (!string.IsNullOrEmpty(cart2))
            {
                vm.Cart1 = cart2.Split("-").ToList();
            }

            string cart = Request.Cookies["cart2"];
            List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();
                vm.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();

            }

            return View(vm);
        }






        public IActionResult Search(string searchData, int? id)
        {
            VmHome model = new VmHome()
            {
                Products = _context.Products.Where(p => (searchData != null ? p.Model.Contains(searchData) : true)).ToList(),
                Advertisings = _context.Advertisings.ToList()
            };
            return View(model);
        }


        public IActionResult Checkout()
        {
            VmOrder model = new VmOrder();
            string cart = Request.Cookies["cart1"];
            List<Product> products = new List<Product>();
            if (!string.IsNullOrEmpty(cart))
            {
                List<string> cartList = cart.Split("-").ToList();
                model.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages).Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();

            }

            return View(model);
        }
        [HttpPost]
        public IActionResult Checkout(VmOrder model)
        {
            if (ModelState.IsValid)
            {
                //Request to Bank api
                //
                //
                //
                //
                bool canWithdraw = true;


                if (canWithdraw)
                {
                    //Create customer
                    CustomUser costomer = new CustomUser();

                    if (!_context.CustomUsers.Any(c => c.Email == model.CustomUser.Email))
                    {
                        CustomUser newCostomer = new CustomUser()
                        {
                            Name = model.CustomUser.Name,
                            Surname = model.CustomUser.Surname,
                            Email = model.CustomUser.Email,
                            Phone = model.CustomUser.Phone,
                            Address = model.CustomUser.Address,
                            UserName = model.CustomUser.Email
                        };
                        _context.CustomUsers.Add(newCostomer);
                        _context.SaveChanges();

                        costomer = newCostomer;
                    }
                    else
                    {
                        costomer = _context.CustomUsers.FirstOrDefault(c => c.Email == model.CustomUser.Email);
                    }

                    //Update stock
                    string cart = Request.Cookies["cart1"];
                    List<Product> sizeColorToProducts = new List<Product>();
                    if (!string.IsNullOrEmpty(cart))
                    {
                        List<string> cartList = cart.Split("-").ToList();

                        sizeColorToProducts = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages)
                                                                          .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
                    }

                    foreach (var item in sizeColorToProducts)
                    {
                        _context.Products.Find(item.Id).Stock--;
                    }
                    _context.SaveChanges();


                    //Invoice
                    Sale sale = new Sale();
                    int invoiceNo = 1;
                    if (_context.Sales.Any())
                    {
                        invoiceNo = Convert.ToInt32(_context.Sales.OrderBy(o => o.Id).LastOrDefault().No) + 1;
                    }

                    sale.No = invoiceNo.ToString().PadLeft(11, '0');
                    if (sizeColorToProducts.Sum(s => s.Price) < 100)
                    {
                        sale.Shipping = 10;
                    }
                    sale.CustomerId = costomer.Id;
                    sale.CreatedDate = DateTime.Now;
                    _context.Sales.Add(sale);
                    _context.SaveChanges();


                    foreach (var item in sizeColorToProducts)
                    {
                        SaleItem saleItem = new SaleItem();
                        if (item.DiscountDate != null && item.DiscountDate > DateTime.Now)
                        {
                            saleItem.Price = (decimal)item.DiscountPrice;
                        }
                        else
                        {
                            saleItem.Price = item.Price;
                        }
                        saleItem.Stock = 1;
                        saleItem.ProductId = item.Id;
                        saleItem.SaleId = sale.Id;

                        _context.SaleItems.Add(saleItem);
                    }

                    _context.SaveChanges();
                    Response.Cookies.Delete("cart1");


                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress("khan.web.mmc@gmail.com", "GoBazar Best Online Shop");
                    mail.To.Add(costomer.Email);
                    mail.Subject = "Product invoice";
                    string body = "<h1 style='font-size:30px; color:green; font-weight: bold;'>You shopping complate successfully</h1>" +
                        "<h3>The invoice is below:</h3>";
                    foreach (var item in sizeColorToProducts)
                    {
                        body += $"<p>Product: {item.Brand}, {item.Model}, Quantity: 1, Price: {item.Price}</p>";
                    }
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


                    HttpContext.Session.SetString("success", "You shopping complate successfully");
                    return RedirectToAction("cart","product");
                }

                //HttpContext.Session.SetString("BankError","You do not have enough money");
                ModelState.AddModelError("BankError", "You do not have enough money");
                string cart2 = Request.Cookies["cart1"];
                if (!string.IsNullOrEmpty(cart2))
                {
                    List<string> cartList = cart2.Split("-").ToList();

                    model.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages)
                                                                           .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
                }
                return View(model);
            }


            string cart3 = Request.Cookies["cart1"];
            if (!string.IsNullOrEmpty(cart3))
            {
                List<string> cartList = cart3.Split("-").ToList();

                model.Products = _context.Products.Include(cp => cp.ProductToProduct).ThenInclude(pi => pi.ProductImages)
                                                                                      .Where(sp => cartList.Any(cl => cl == sp.Id.ToString())).ToList();
            }
            return View(model);
        }




    } }


