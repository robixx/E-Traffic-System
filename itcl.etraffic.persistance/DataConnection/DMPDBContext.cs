using itcl.etraffic.application.ViewDto;
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
        public DbSet<Vehicleseriesno> VehicleSeriesNo { get; set; } = null!;
        public DbSet<SerialNoType> SerialNoType { get; set; } = null!;
        public DbSet<DocumentSeized> DocumentSeized { get; set; } = null!;
        public DbSet<Sergeant> Sergeant { get; set; } = null!;
        public DbSet<Division> Division { get; set; } = null!;
        public DbSet<V2_Division_Filter_ForUser> V2_Division_Filter_ForUser { get; set; } = null!;
        public DbSet<ProsecutionComments> ProsecutionComments { get; set; } = null!;
        public DbSet<RoleGetAllDto> RoleGetAllDto { get; set; } = null!;
        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<VehicleRegistration>().HasKey(c => c.IId);
            modelBuilder.Entity<Vehicleseriesno>().HasKey(c => c.IId);
            modelBuilder.Entity<SerialNoType>().HasKey(c => c.IId);
            modelBuilder.Entity<DocumentSeized>().HasKey(c => c.IId);
            modelBuilder.Entity<Sergeant>().HasKey(c => c.IId);
            modelBuilder.Entity<Division>().HasKey(c => c.IId);
            modelBuilder.Entity<V2_Division_Filter_ForUser>().HasKey(c => c.ID);
            modelBuilder.Entity<ProsecutionComments>().HasKey(c => c.CID);
            modelBuilder.Entity<RoleGetAllDto>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
