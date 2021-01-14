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
using Newtonsoft.Json;
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
        public static InputModel _dataInput;
        private ApplicationDbContext _context;
        private AddImage _addImage;
        public InputModelRegister _dataUser1, _dataUser2;
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
        public void OnGet(int id)
        {
            if (id.Equals(0))
            {
                _dataUser1 = null;
            }
           if (_dataInput != null || _dataUser1 != null || _dataUser2 != null)
            {
                if (_dataInput != null)
                {
                    Input = _dataInput;
                    Input.RolesList = _usersRoles.GetRoles(_roleManager);
                    Input.AvatarImage = null;
                }
                else
                {
                    if (_dataUser1 != null || _dataUser2 != null)
                    {
                        if (_dataUser2 != null)
                        {
                            _dataUser1 = _dataUser2;
                            Input = new InputModel
                            {
                                Name = _dataUser1.Name,
                                LastName = _dataUser1.LastName,
                                IdNumber = _dataUser1.IdNumber,
                                Email = _dataUser1.Email,
                                Image = _dataUser1.Image,
                                PhoneNumber = _dataUser1.identityUser.PhoneNumber,
                                RolesList = getRoles(_dataUser1.Role)
                            };
                            if (_dataInput != null)
                            {
                                _dataInput.ErrorMessage = _dataInput.ErrorMessage;
                            }
                        }
                    }
                }
            }
            else
            {
                Input = new InputModel
                {
                    RolesList = _usersRoles.GetRoles(_roleManager)
                };
            }
           
            _dataUser2 = _dataUser1;
            _dataUser1 = null;
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel: InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
            //[TempData]
            //public string ErrorMessage { get; set; }
            public List<SelectListItem> RolesList { get; set; }
           
        }
        public async Task<IActionResult> OnPost(String dataUser)
        {
            if (dataUser == null)
            {
                if (_dataUser2 == null)
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
                else
                {
                    if(await UpdateAsync())
                    {
                        var url = $"/Users/Account/Details?id={_dataUser2.Id}";
                        _dataUser2 = null;
                        return Redirect(url);
                    }
                    else
                    {
                        return Redirect("/Users/Account/Register");
                    }
                }
            }
            else
            {
                _dataUser1 = JsonConvert.DeserializeObject<InputModelRegister>(dataUser);
                return Redirect("/Users/Account/Register?id=1");
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
                                        Input.AvatarImage, _environment, "");
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
                                    foreach (var item in result.Errors)
                                    {
                                        _dataInput.ErrorMessage = item.Description;
                                    }
                                    valor = false;
                                    transaction.Rollback();
                                }
                            }
                            catch (Exception ex)
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
                foreach (var modelState in ModelState.Values)
                {
                    foreach ( var error in modelState.Errors)
                    {
                        _dataInput.ErrorMessage += error.ErrorMessage;
                    }
                }
                 
                valor = false;

            }
           
            return valor;
            
        }
        private List<SelectListItem>getRoles (string Role)
        {
            List<SelectListItem> rolesLista = new List<SelectListItem>();
            rolesLista.Add(new SelectListItem
            {
                Text = Role
            });
            var roles = _usersRoles.GetRoles(_roleManager);
            roles.ForEach(item =>
            {
                if (item.Text != Role)
                {
                    rolesLista.Add(new SelectListItem
                    {
                        Text = item.Text
                    });
                }
            });
            return rolesLista;
        }
        private async Task<bool> UpdateAsync()
        {
            var valor = false;
            byte[] imageByte = null;
            var strategy = _context.Database.CreateExecutionStrategy();
            await strategy.ExecuteAsync(async () =>
            {
                using (var trnsaction = _context.Database.BeginTransaction())
                {
                    try
                    {
                        var identityUser = _userManager.Users.Where(u => u.Id.Equals(_dataUser2.Id)).ToList().Last();
                        identityUser.UserName = Input.Email;
                        identityUser.Email = Input.Email;
                        identityUser.PhoneNumber = Input.PhoneNumber;
                        _context.Update(identityUser);
                        await _context.SaveChangesAsync();

                        if (Input.AvatarImage == null)
                        {
                            imageByte = _dataUser2.Image;
                        }
                        else
                        {
                            imageByte = await _addImage.ByteAvatarImageAsync(Input.AvatarImage, _environment, " ");
                        }
                        var tUser = new TableUsers
                        {
                            ID = _dataUser2.Id,
                            Name = Input.Name,
                            LastName = Input.LastName,
                            IdNumber = Input.IdNumber,
                            Email = Input.Email,
                            IdUser = _dataUser2.ID,
                            Role = Input.Role,
                            Image = imageByte
                        };
                        _context.Update(tUser);
                        _context.SaveChanges();
                        if (_dataUser2.Role != Input.Role)
                        {
                            await _userManager.RemoveFromRoleAsync(identityUser, _dataUser2.Role);
                            await _userManager.AddToRoleAsync(identityUser, Input.Role);
                        }
                        trnsaction.Commit();
                        valor = true;
                    }
                    catch ( Exception ex)
                    {
                        _dataInput.ErrorMessage = ex.Message;
                        trnsaction.Rollback();
                        valor = false;
                    }
                }
            });
            return valor;
        }
    }
}
