using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelClass.Model
{
    [Table("dbo.SalesOrder")]
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

