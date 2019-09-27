using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToASP.Models
{
    public class CustomerComment
    {
        public int Id { get; set; }
        [StringLength(150)]
        public string Header { get; set; }
        [StringLength(255)]
        public string Content { get; set; }
    }
}