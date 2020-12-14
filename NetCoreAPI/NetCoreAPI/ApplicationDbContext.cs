using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreAPI.Entities;
using System.Diagnostics.CodeAnalysis;
using ModelClass.Model;


namespace NetCoreAPI
{
    
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Genre> Genres {get; set;}
        //public DbSet<Customer> Customers { get; set; }
        public DbSet<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public DbSet<TimeSheet> TimeSheets { get; set; }

    }
}
