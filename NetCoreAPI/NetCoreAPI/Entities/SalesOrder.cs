using System;
using System.Collections.Generic;

namespace NetCoreAPI.Entities
{
    public partial class SalesOrder
    {
        public int SalesOrderId { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipMethod { get; set; }
    }
}
