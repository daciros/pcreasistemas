using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Library;

namespace pruebacs1.Areas.Users.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private LUserRoles _usersRoles;
        private static InputModel _dataInput;
        private ApplicationDbContext _context;
        private AddImage _addImage;
        private IWebHostEnvironment _environment;
        public RegisterModel(
         SignInManager<IdentityUser> signInManager,
         UserManager<IdentityUser> userManager,
         RoleManager<IdentityRole> roleManager,
         ApplicationDbContext context,
         IWebHostEnvironment environment)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _usersRoles = new LUserRoles();
            _context =  context;
            _addImage = new AddImage();
            _environment = environment;
        }
        public void OnGet()
        {
            if (_dataInput != null)
            {
                Input = _dataInput;
                Input.RolesList = _usersRoles.GetRoles(_roleManager);
                Input.AvatarImage = null;
            }
            else
            {
                Input = new InputModel
                {
                    RolesList = _usersRoles.GetRoles(_roleManager)
                };
            }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel: InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            [TempData]
            public string ErrorMessage { get; set; }
            public List<SelectListItem> RolesList { get; set; }
           
        }
        public async Task<IActionResult> OnPost()
        {
            if (await SaveAsync())
            {
                return Redirect("/Users/Users?area=Users");
            }
            else
            {
                return Redirect("/Users/Account/Register");
            }
        }
        private async Task<bool> SaveAsync()
        {
            _dataInput = Input;
            var valor = false;
            if (ModelState.IsValid)
            {
                var userList = _userManager.Users.Where(U => U.Email.Equals(Input.Email)).ToList();
                if (userList.Count.Equals(0))
                {
                    var strategy = _context.Database.CreateExecutionStrategy();
                    await strategy.ExecuteAsync(async()=>
                    {
                    using (var transaction = _context.Database.BeginTransaction())
                        {
                            try
                            {
                                var User = new IdentityUser
                                {
                                    UserName = Input.Email,
                                    Email = Input.Email,
                                    PhoneNumber = Input.PhoneNumber
                                };
                                var result = await _userManager.CreateAsync(User, Input.Password);
                                if (result.Succeeded)
                                {
                                    await _userManager.CreateAsync(User, Input.Role);
                                    var dataUser = _userManager.Users.Where(U => U.Email.Equals(Input.Email)).ToList().Last();
                                    var imageByte = await _addImage.ByteAvatarImageAsync(
                                        Input.AvatarImage, _environment);
                                    var TableUsers = new TableUsers
                                    {
                                        Name = Input.Name,
                                        LastName = Input.LastName,
                                        IdNumber = Input.IdNumber,
                                        Email = Input.Email,
                                        IdUser = dataUser.Id,
                                        Image = imageByte,
                                        PhoneNumber = Input.PhoneNumber,
                                        Role = Input.Role
                                    };
                                    await _context.AddAsync(TableUsers);
                                    _context.SaveChanges();
                                    transaction.Commit();
                                    _dataInput = null;
                                    valor = true;
                                }
                                else
                                {
                                    foreach(var item in result.Errors)
                                    {
                                        _dataInput.ErrorMessage = item.Description;
                                    }
                                    valor = false;
                                    transaction.Rollback();
                                }
                            }
                            catch(Exception ex)
                            {
                                _dataInput.ErrorMessage = ex.Message;
                                transaction.Rollback();
                                valor = false;
                            }
                        }
                    });
                }
                else
                {
                    _dataInput.ErrorMessage = $"The email {Input.Email} is already registered";
                    valor = false;
                }
            }
            else
            {
                foreach(var modelState in ModelState.Values)
                {
                    foreach( var error in modelState.Errors)
                    {
                        _dataInput.ErrorMessage += error.ErrorMessage;
                    }
                }
                 
                valor = false;

            }
           
            return valor;
            
        }
    }
}
