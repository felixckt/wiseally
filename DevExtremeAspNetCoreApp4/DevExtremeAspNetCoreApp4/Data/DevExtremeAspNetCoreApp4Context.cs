using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevExtremeAspNetCoreApp4.Models
{
    public class DevExtremeAspNetCoreApp4Context : DbContext
    {
        public DevExtremeAspNetCoreApp4Context (DbContextOptions<DevExtremeAspNetCoreApp4Context> options)
            : base(options)
        {
        }

        public DbSet<DevExtremeAspNetCoreApp4.Models.Order> Order { get; set; }
    }
}
