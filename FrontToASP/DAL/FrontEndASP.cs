using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontToASP.Models;

namespace FrontToASP.DAL
{
    public class FrontEndASP : DbContext
    {
        public FrontEndASP(DbContextOptions<FrontEndASP> options) : base(options)
        {
        }
        public DbSet<CustomerComment> CustomerComments { get; set; }
        public DbSet<CustomerCommentItems> CustomerCommentsItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductItems> ProductItems { get; set; }
    }
}
