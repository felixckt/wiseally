using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DevExtremeAspNetCoreApp1.Models
{
    public class DevExtremeAspNetCoreApp1Context : DbContext
    {
        public DevExtremeAspNetCoreApp1Context (DbContextOptions<DevExtremeAspNetCoreApp1Context> options)
            : base(options)
        {
        }

        public DbSet<DevExtremeAspNetCoreApp1.Models.Order> Order { get; set; }
    }
}
