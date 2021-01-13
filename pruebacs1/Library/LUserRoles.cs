using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Library
{
    public class LUserRoles
    {
        public List<SelectListItem> GetRoles(RoleManager<IdentityRole> roleManager)
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var roles = roleManager.Roles.ToList();
            roles.ForEach(item => {
                _selectList.Add(new SelectListItem
                {
                    Value = item.Id,
                    Text = item.Name
                });
            });
            return _selectList;
        }
        public async Task<List<SelectListItem>> getRole(UserManager<IdentityUser> userManager, 
            RoleManager<IdentityRole> roleManager, string ID)
        {
            List<SelectListItem> _selectList = new List<SelectListItem>();
            var Users = await userManager.FindByIdAsync(ID);
            var role = await userManager.GetRolesAsync(Users);
            if (role.Count.Equals(0))
            {
                _selectList.Add(new SelectListItem
                {
                    Value = "0",
                    Text = "No Role"
                });
            }
            else
            {
                var roleUser = roleManager.Roles.Where(m => m.Equals(role[0]));
                foreach (var Data in roleUser)
                {
                    _selectList.Add(new SelectListItem
                    {
                        Value = Data.Id,
                        Text = Data.Name
                    });
                }
            }
            return _selectList;
        }

        
        
    }
}
