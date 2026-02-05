using itcl.etraffic.domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itcl.etraffic.persistance.DataConnection
{
    public class DMPDBContext : DbContext
    {
        public DMPDBContext(DbContextOptions<DMPDBContext> options) : base(options)
        {

        }

        public DbSet<VehicleRegistration> Vehicleregistration { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VehicleRegistration>().HasKey(c => c.IId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
