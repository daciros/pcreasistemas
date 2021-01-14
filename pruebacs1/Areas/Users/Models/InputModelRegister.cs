using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace pruebacs1.Areas.Users.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "The field Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The field Lastname is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The field Id number is required")]
        public string IdNumber { get; set; }

        [Required(ErrorMessage = "The field phone number is required")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-, ]?([0-9]{3})?[-, ]?([0-9]{4})$", ErrorMessage ="The field Phonenumber is invalid")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The field Email is required")]
        [EmailAddress(ErrorMessage = "the field Email is invalid")]
        public string Email { get; set; }

        [Display(Name ="Paswd")]
        [Required(ErrorMessage = "The password is required")]
        [StringLength(100,ErrorMessage = "the password field must contain a number " +
            "of {0} characters of must be at least {2}.",
            MinimumLength = 6)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Select a role")]
        public string Role { get; set; }
        public byte[] Image { get; set; }
        public int Id { get; set; }
        public string ID { get; set; }
        public IdentityUser identityUser { get; set; }
       
        [TempData]
        public string ErrorMessage { get; set; }
    }
}
