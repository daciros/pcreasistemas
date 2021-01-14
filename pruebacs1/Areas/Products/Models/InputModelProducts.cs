using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Areas.Products.Models
{
    public class InputModelProducts
    {
        public int ID { get; set; }
        public int Code { get; set; }
        public string Name_Product { get; set; }
        public string Description { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

    }
}
