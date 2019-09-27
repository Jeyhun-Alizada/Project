using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontToASP.DAL;

namespace FrontToASP.Areas.Admin.Controllers
{
    public class ProductsController : Controller
    {
        private readonly FrontEndASP _context;
        public ProductsController(FrontEndASP context)
        {
            _context = context;
        }
        [Area("Admin")]
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }
    }
}