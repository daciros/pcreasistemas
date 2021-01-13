using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Areas.Users.Models
{
    public class TableUsers
    {
        public int ID  { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string IdNumber { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string IdUser { get; set; }
        public string Role { get; set; }
        public byte[] Image { get; set; }

        public static implicit operator TableUsers(string v)
        {
            throw new NotImplementedException();
        }
    }
}
