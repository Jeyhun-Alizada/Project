using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToASP.DAL;
using FrontToASP.Models;
namespace FrontToASP.ViewsModels
{
    public class HomeIndexVM
    {
        public List<CustomerCommentItems> CustomerCommentItems { get; internal set; }
        public List<CustomerComment> CustomerComment { get; internal set; }
        public List<ProductItems> ProductItems { get; internal set; }
        public List<Product> Product { get; internal set; }
    }
}