using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Areas.Users.Models
{
    public class InputModelLogin
    {
        [Required(ErrorMessage = "The field Email is required")]
        [EmailAddress(ErrorMessage = "the field Email is invalid")]
        public string Email { get; set; }

        [Display(Name = "Paswd")]
        [Required(ErrorMessage = "The password is required")]
        [StringLength(100, ErrorMessage = "the password field must contain a number " +
            "of {0} characters of must be at least {2}.",
            MinimumLength = 6)]
        public string Password { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }
    }
}
