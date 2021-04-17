using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage ="لطفا نام خود را وارد کنید")]
        [MinLength(3)]
        public string Name { get; set; }

        [EmailAddress(ErrorMessage ="Email Format is incorect")]
        [Required]
        [MinLength(5)]
        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Service { get; set; }
    }
}
