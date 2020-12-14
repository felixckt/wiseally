using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreAPI.Entities;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Configuration;

namespace BlazorApp3
{
    public class ApplicationDbContext: DbContext
    { 
        public DbSet<Genre> Genres { get; set; }

        //public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        //{

        //}
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string conString = Microsoft.Extensions.Configuration.ConfigurationExtensions.GetConnectionString(this.Configuration, "DefaultConnection");

            //string conString = ConfigurationExtensions.GetConnectionString(, "DefaultConnection");

            optionsBuilder.UseSqlServer("Server=tcp:wamssql.database.windows.net,1433;Initial Catalog=wadb;Persist Security Info=False;User ID=wamsadmin;Password=WiseAlly212;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
