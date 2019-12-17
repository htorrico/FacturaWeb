using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebFactura.Models
{
    public class FacturaViewModel
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string office { get; set; }
        public string start_date { get; set; }
        public decimal salary { get; set; }
    }
}
