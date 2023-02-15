using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebmvc.Models
{
    public class SalesWebmvcContext : DbContext
    {
        public SalesWebmvcContext (DbContextOptions<SalesWebmvcContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebmvc.Models.Departament> Departament { get; set; }
    }
}
