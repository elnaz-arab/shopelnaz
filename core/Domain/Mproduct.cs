using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace core.Domain
{
    public class MProduct
    {
        public int Id { get; set; }

        [Display(Name = "Name Of Product ")]
        [Required(ErrorMessage = "Please Enter ProductName")]
        public string Name { get; set; }
        public double price { get; set; }
        public int Count { get; set; }
        public string discription { get; set; }
        public string MainImage { get; set; }

        [Required(ErrorMessage = "Please Enter An Id")]
        public int IdCategory { get; set; }
        public bool Status { get; set; }
        public int IdColor { get; set; }
        public int IdSize { get; set; }
        public int discount { get; set; }
        public string Type { get; set; }
        
        
    }
}