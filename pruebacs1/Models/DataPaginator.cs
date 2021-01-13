using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebacs1.Models
{
    public class DataPaginator<T>
    {
        public List<T> List { get; set; }
        public string Pag_info { get; set; }
        public string Pag_navigation { get; set; }
        public T Input { get; set; }
        public string Search { get; set; }

    }
}
