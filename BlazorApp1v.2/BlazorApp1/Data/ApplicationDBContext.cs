using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ModelClass;

namespace BlazorApp1.Data
{
    public class ApplicationDBContext : DbContext

    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {


        }

        public DbSet<ModelClass.Model.SalesOrder> SalesOrder {get; set;}

    }
}
