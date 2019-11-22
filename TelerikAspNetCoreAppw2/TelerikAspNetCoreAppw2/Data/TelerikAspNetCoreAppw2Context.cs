using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TelerikAspNetCoreAppw2.Models
{
    public class TelerikAspNetCoreAppw2Context : DbContext
    {
        public TelerikAspNetCoreAppw2Context (DbContextOptions<TelerikAspNetCoreAppw2Context> options)
            : base(options)
        {
        }

        public DbSet<TelerikAspNetCoreAppw2.Models.Order> Order { get; set; }
    }
}
