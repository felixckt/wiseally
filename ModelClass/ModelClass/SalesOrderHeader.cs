using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelClass.Model
{
    
    public class SalesOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SalesOrderID { get; set; }

        [Display(Name = "Ship Date")]
        public DateTime ShipDate { get; set; }

       
        [Display(Name = "Ship Method")]
        public string ShipMethod { get; set; }


    }

    public class TimeSheet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Display(Name = "Staff Name")]
        public string StaffName { get; set; }

        [Display(Name = "Week")]
        public int Week { get; set; }

        [Display(Name = "Month")]
        public int Month { get; set; }

        [Display(Name = "Hours")]
        public int Hours { get; set; }

        [Display(Name = "RFQ Number")]
        public string RFQNumber { get; set; }

        [Display(Name = "Project Code")]
        public string ProjectCode { get; set; }

        [Display(Name = "Admin Code")]
        public string AdminCode { get; set; }

        [Display(Name = "Remark")]
        public string remark { get; set; }
    }

}

