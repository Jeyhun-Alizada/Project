using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrontToASP.Models;
using FrontToASP.DAL;
using FrontToASP.ViewsModels;
namespace FrontToASP.Controllers
{
    public class HomeController : Controller
    {
        private readonly FrontEndASP _context;
        public HomeController(FrontEndASP context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeIndexVM homeIndexVM = new HomeIndexVM
            {
                CustomerComment = _context.CustomerComments.ToList(),
                CustomerCommentItems = _context.CustomerCommentsItems.ToList(),
                Product = _context.Products.ToList(),
                ProductItems = _context.ProductItems.ToList()
            };
            return View(homeIndexVM);
        }
    }
}
