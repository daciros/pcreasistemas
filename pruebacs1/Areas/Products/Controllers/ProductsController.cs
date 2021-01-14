using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pruebacs1.Data;

namespace pruebacs1.Areas.Products.Controllers
{
    [Area("Products")]
    public class ProductsController : Controller
    {
        public ApplicationDbContext _context;
        public IActionResult Products(int code, string name, string description, int price)
        {
            return View();
        }
        public ProductsController( ApplicationDbContext context)
        {
            _context = context;
        }
       
    }
}
