using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevExtremeAspNetCoreApp2.Models
{
    public class DevExtremeAspNetCoreApp2Context : DbContext
    {
        public DevExtremeAspNetCoreApp2Context (DbContextOptions<DevExtremeAspNetCoreApp2Context> options)
            : base(options)
        {
        }

        public DbSet<DevExtremeAspNetCoreApp2.Models.Order> Order { get; set; }
    }
}
