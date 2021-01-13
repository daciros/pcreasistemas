using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Library
{
    public class ListObject
    {
        public IdentityError _identityError;
        public SignInManager<IdentityUser> _signInManager;
        public UserManager<IdentityUser> _userManager;
        public RoleManager<IdentityRole> _roleManager;
        public ApplicationDbContext _context;
        public IWebHostEnvironment _environment;
        public DataPaginator<InputModelRegister> _dataPaginator;
        public LPaginator<InputModelRegister> _Paginator;
        public LUserRoles _userRoles;
    }
}
