using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Library;
using pruebacs1.Models;

namespace pruebacs1.Areas.Users.Controllers
{

    [Area("Users")]
    public class UsersController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private LUsers _Users;
        private static DataPaginator<InputModelRegister> modelos;
        

        public UsersController(
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _Users = new LUsers(signInManager, roleManager, userManager, context);
        }
        public IActionResult Users( int id, string filter)
        {
            //if (_signInManager.IsSignedIn(User))
           // {
                object[] Objets = new object[3];
                var Data = _Users.getTableUsersAsync(filter, 0);
                if (0 < Data.Result.Count)
                {
                    var url = Request.Scheme + "://" + Request.Host.Value;
                    Objets = new LPaginator<InputModelRegister>().Paginator(Data.Result, id, 10,"Users", "Users", "Users", url);
                }
                else
                {
                    Objets[0] = "No data exist";
                    Objets[1] = "No data exist";
                    Objets[2] = new List<InputModelRegister>();
                }
                modelos = new DataPaginator<InputModelRegister>
                {
                    List = (List<InputModelRegister>) Objets[2],
                    Pag_info = (String)Objets[0],
                    Pag_navigation = (string)Objets[1],
                    Input = new InputModelRegister()
                     
                 };
            
            return View(modelos);
            /*}
            /*else
            {
                return Redirect("/");
            }*/

        }
    }
}
