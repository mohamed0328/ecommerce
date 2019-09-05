using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Controllers
{
    public class ProductsController : Controller
    {
        private SomaliDbContext db;
        public ProductsController(Models.SomaliDbContext somaliDb)
        {
            db = somaliDb;
        }


        public IActionResult Index()
        {
            var products = db.Products.Include(x => x.Orders).ToList();


            return View(products);
        }
    }
}