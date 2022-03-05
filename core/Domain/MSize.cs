using System;
using System.ComponentModel.DataAnnotations;
namespace core.Domain
{
    public class MSize
    {
        public int Id { get; set; }
        public string Size { get; set; }
        [Required(ErrorMessage = "Please Enter An Id")]
        public int IdProduct { get; set; }
    }
}