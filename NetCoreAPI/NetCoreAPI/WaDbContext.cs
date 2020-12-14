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
    
    public class WaDbContext : DbContext
    {
        public WaDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<NPIMasterList> NPIMasterLists {get; set;}
        public DbSet<QuoteNumber> QuoteNumber { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuoteNumber>()
                .HasNoKey();
        }
    }
}
