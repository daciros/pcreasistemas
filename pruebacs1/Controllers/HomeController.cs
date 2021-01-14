using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using pruebacs1.Areas.Billing.Controllers;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Library;
using pruebacs1.Models;

namespace pruebacs1.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //IServiceProvider _serviceProvider;
        public static InputModelLogin _inputModelLogin;
        public LUsers _usuario;
        public SignInManager<IdentityUser> _signInManager;

        public HomeController(SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context,
            IServiceProvider serviceProvider)
        {
            _usuario = new LUsers(signInManager, roleManager, userManager, context);
            _signInManager = signInManager;
            //_serviceProvider = serviceProvider;
        }
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        [HttpPost]
        public async Task<IActionResult> Index(InputModelLogin inputModelLogin)
        {
            
            _inputModelLogin = inputModelLogin;
            if (ModelState.IsValid)
            {
                var result = await _usuario.UserLoginAsync(inputModelLogin);
               if (result.Succeeded)
                {
                    return Redirect("/Billing/Billing");
                }
                else
                {
                    _inputModelLogin.ErrorMessage = "Email or Password are invalids";
                    return Redirect("/");
                }
            }
            else
            {
                foreach (var modelState in ModelState.Values)
                {
                    foreach (var error in modelState.Errors)
                    {
                        _inputModelLogin.ErrorMessage = error.ErrorMessage;
                    }
                }
                return Redirect("/");
            }
           
        }
        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
            {
                return RedirectToAction(nameof(BillingController.Billing), "Billing");
            }
            else
            {
                if (_inputModelLogin != null)
                {
                    return View(_inputModelLogin);
                }
                else
                {
                    return View();
                }
                
            }
            //await CreateRolesAsync(_serviceProvider);
           
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        //private async Task CreateRolesAsync(IServiceProvider serviceProvider)
        //{
        //    var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        //    String[] rolesName = { "Admin", "User", "Client" };
        //    foreach (var i in rolesName)
        //    {
        //        var rolExist = await roleManager.RoleExistsAsync(i);
        //        if (!rolExist)
        //        {
        //            await roleManager.CreateAsync(new IdentityRole(i));
        //        }
        //    }
        //}
    }
}
