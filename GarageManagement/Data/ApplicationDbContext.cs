using Microsoft.EntityFrameworkCore;
using GarageManagement.Models;

namespace GarageManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<MaintenanceRecord> MaintenanceRecords { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<InventoryItem> InventoryItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints here if needed
            // For example, modelBuilder.Entity<Customer>().HasMany(c => c.Vehicles);
            // Other configurations...

            // Specify SQL Server column types for decimal properties
            modelBuilder.Entity<InventoryItem>()
                .Property(i => i.Price)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Invoice>()
                .Property(i => i.TotalAmount)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<MaintenanceRecord>()
                .Property(m => m.Cost)
                .HasColumnType("decimal(18, 2)");

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)");

            // Call base method
            base.OnModelCreating(modelBuilder);
        }
    }
}
