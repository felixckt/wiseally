using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Azure_SQL_Web_API.Model
{
    
    public class SalesOrder
    {
        [Key]
        public int SalesOrderID { get; set; }

        [Display(Name = "Ship Date")]
        public DateTime ShipDate { get; set; }

        [Display(Name = "Ship Method")]
        public string ShipMethod { get; set; }

        
    }
}

