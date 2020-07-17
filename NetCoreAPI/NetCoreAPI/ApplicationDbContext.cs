using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreAPI.Entities;
using System.Diagnostics.CodeAnalysis;

namespace NetCoreAPI
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext([NotNullAttribute] DbContextOptions options) : base(options)
        {

        }

        public DbSet<Genre> Genres {get; set;}
    }
}
