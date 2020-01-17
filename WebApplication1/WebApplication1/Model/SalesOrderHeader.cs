
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    [Table("SalesOrder")]
    public class SalesOrder
    {
        [Key]
        public int SalesOrderID { get; set; }

        [Display(Name = "送貨日期")]
        public DateTime ShipDate { get; set; }

        [Display(Name = "送貨方法")]
        public string ShipMethod { get; set; }


    }
}


