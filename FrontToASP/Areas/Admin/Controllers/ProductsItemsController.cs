using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontToASP.DAL;
using FrontToASP.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using FrontToASP.Extations;

namespace FrontToASP.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductsItemsController : Controller
    {
        private readonly FrontEndASP _context;
        private readonly IHostingEnvironment _env;
        public ProductsItemsController(FrontEndASP context, IHostingEnvironment env)
        {
            _env = env;
            _context = context;
        }
        public IActionResult Index()
        {
            var productItems = _context.ProductItems.ToList();
            return View(productItems);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductItems productItems)
        {
            if (!ModelState.IsValid)
            {
                return View(productItems);
            }
            if (productItems.Photo == null)
            {
                ModelState.AddModelError("Photo", "Photo shuld be selected.");
                return View(productItems);
            }
            if (!productItems.Photo.ContentType.Contains("image/"))
            {
                ModelState.AddModelError("Photo", "Photo is not valid.");
                return View(productItems);
            }
            productItems.Image = await productItems.Photo.SaveFileAsync(_env.WebRootPath);
            await _context.ProductItems.AddAsync(productItems);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}