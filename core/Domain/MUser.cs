using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace core.Domain
{
    public class MUser
    {
       public int Id { get; set; }

        [Display(Name = "Phone Number ")]
        [Required(ErrorMessage = "You Have To Use 11 Charactor")]
        public string Mobile { get; set; }

        [Display(Name = " Password ")]
        [Required(ErrorMessage = " You Have To Use At Least 8 Charactor")]
        public string Password { get; set; }


        [Display(Name = "First Name & Last Name")]
        public string FullName { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "CodeMeli ")]
        public string CodeMeli { get; set; }

        public string Role { get; set; }

        public bool IsActive { get; set; }

    }
}