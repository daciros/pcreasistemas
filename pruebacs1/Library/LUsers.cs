using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using pruebacs1.Areas.Users.Models;
using pruebacs1.Data;
using pruebacs1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Library
{
    public class LUsers : ListObject
    {

        public LUsers(
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _roleManager = roleManager;
            _userManager = userManager;
            _context = context;
            _userRoles = new LUserRoles();

        }




        public async Task<List<InputModelRegister>> getTableUsersAsync(string value, int id)
        {
            List<TableUsers> ListUsers;
            List<SelectListItem> ListRoles;
            List<InputModelRegister> userlist = new List<InputModelRegister>();
            if (value == null && id.Equals(0))
            {
                ListUsers = _context.TableUsers.ToList();
            }
            else
            {
                if (id.Equals(0))
                {
                    ListUsers = _context.TableUsers.Where(u => u.IdNumber.StartsWith(value) || u.IdUser.StartsWith(value) || u.Name.StartsWith(value)
                    || u.LastName.StartsWith(value) || u.Email.StartsWith(value)).ToList();
                }
                else
                {
                    ListUsers = _context.TableUsers.Where(u => u.ID.Equals(id)).ToList();
                }
            }

            if (!ListUsers.Count.Equals(0))
            {
                foreach (var item in ListUsers)
                {
                    ListRoles = await _userRoles.getRole(_userManager, _roleManager, item.IdUser);
                    var user = _context.TableUsers.Where(u => u.IdUser.Equals(item.IdUser)).ToList().Last();
                    userlist.Add(item: new InputModelRegister
                    {
                        Id = item.ID,
                        ID = item.IdUser,
                        IdNumber = item.IdNumber,
                        Name = item.Name,
                        LastName = item.LastName,
                        Email = item.Email,
                        PhoneNumber = item.PhoneNumber,
                        Role = ListRoles[0].Text,
                        Image = item.Image
                    });
                    ListRoles.Clear();
                }

            }
            return userlist;
        }
    }

}
