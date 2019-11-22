using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Corewebapi2.Model;

namespace Corewebapi2.Models
{
    public class Corewebapi2Context : DbContext
    {
        public Corewebapi2Context (DbContextOptions<Corewebapi2Context> options)
            : base(options)
        {
        }

        public DbSet<Corewebapi2.Model.Order> Order { get; set; }
    }
}
