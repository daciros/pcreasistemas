﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Areas.Billing.Models
{
    public class TableBilling
    {
        public int ID { get; set; }
        public int Id_User { get; set; }
        public int Bill_Num { get; set; }
        public string Name_Product { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Email_User { get; set; }
        public string PhoneNumber { get; set; }
        public Byte[] print { get; set; }
    }
}
