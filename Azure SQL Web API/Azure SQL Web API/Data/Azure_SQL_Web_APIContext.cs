using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Azure_SQL_Web_API.Model;

namespace Azure_SQL_Web_API.Data
{
    public class Azure_SQL_Web_APIContext : DbContext
    {
        public Azure_SQL_Web_APIContext (DbContextOptions<Azure_SQL_Web_APIContext> options)
            : base(options)
        {
        }

        public DbSet<Azure_SQL_Web_API.Model.SalesOrder> SalesOrder { get; set; }
    }
}
