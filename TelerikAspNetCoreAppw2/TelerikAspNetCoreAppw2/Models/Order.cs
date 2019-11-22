using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelerikAspNetCoreAppw2.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string ShipCountry { get; set; }
        public string ShipCity { get; set; }
    }
}
