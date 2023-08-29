using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalServiceEntity.Entity;

namespace TechnicalServiceDataAccess.Context
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceStatus> ServiceStatuses { get; set; }
        public DbSet<Technician> Technicians { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Customer>().Property(a => a.Id).HasDefaultValueSql("uuid_generate_v4()").ValueGeneratedOnAdd();
            modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Device>().Property(a => a.Id).HasDefaultValueSql("uuid_generate_v4()").ValueGeneratedOnAdd();
            modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Service>().Property(a => a.Id).HasDefaultValueSql("uuid_generate_v4()").ValueGeneratedOnAdd();
            modelBuilder.HasPostgresExtension("uuid-ossp").Entity<ServiceStatus>().Property(a => a.Id).HasDefaultValueSql("uuid_generate_v4()").ValueGeneratedOnAdd();
            modelBuilder.HasPostgresExtension("uuid-ossp").Entity<Technician>().Property(a => a.Id).HasDefaultValueSql("uuid_generate_v4()").ValueGeneratedOnAdd();
        }
    }
}
