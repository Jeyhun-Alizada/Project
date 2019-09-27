using System.ComponentModel.DataAnnotations;

namespace FrontToASP.Models
{
    public class CustomerCommentItems
    {
        public int Id { get; set; }
        [StringLength(255)]
        public string Image { get; set; }
        [StringLength(150)]
        public string ImageAlt { get; set; }
        [StringLength(150)]
        public string Comment { get; set; }
        [StringLength(255)]
        public string Name { get; set; }
        [StringLength(150)]
        public string Speciality { get; set; }
    }
}
