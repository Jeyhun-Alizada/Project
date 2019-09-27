using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontToASP.Models
{
    public class ProductItems
    {
        public int Id { get; set; }
        [Display(Name = "Product name")]
        public string Name { get; set; }
        public string Image { get; set; }
        public string ImageAlt { get; set; }
        public bool HasDiscount { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Rating { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}