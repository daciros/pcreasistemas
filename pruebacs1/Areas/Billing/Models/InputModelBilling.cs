using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Areas.Billing.Models
{
    public class InputModelBilling
    {
        [Required (ErrorMessage = "Please Input Id User")]
        public int Id_User { get; set; }
        [Required (ErrorMessage ="Please Select Product Name")]
        public string Name_Product { get; set; }
        public string Description { get; set; }
        [Required (ErrorMessage ="Please Input Date")]
        public DateTime Date { get; set; }
        public string Email_User { get; set; }
        public string PhoneNumber { get; set; }
        public Byte[] print { get; set; }
    }
}
