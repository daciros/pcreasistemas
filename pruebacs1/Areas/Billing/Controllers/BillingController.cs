using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace pruebacs1.Areas.Billing.Controllers
{
    [Area ("Billing")]
    public class BillingController : Controller
    {
        public IActionResult Billing()
        {
            return View();
        }
    }
}
