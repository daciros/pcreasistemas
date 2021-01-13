using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Library;

namespace pruebacs1.Areas.Users.Pages.Account
{
    public class DetailsModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        private LUsers _User;
        public DetailsModel(SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _User = new LUsers(signInManager, roleManager, userManager, context);
        }
        public void OnGet(int Id)
        {
            var data = _User.getTableUsersAsync(null, Id);
            if (0 < data.Result.Count)
            {
                Input = new InputModel
                {
                    DataUser = data.Result.ToList().Last(),
                };
            }
        }
            [BindProperty]
            public InputModel Input { get; set; }
        public class InputModel
        {
            public InputModelRegister DataUser { get; set; }
        }
    }
}

