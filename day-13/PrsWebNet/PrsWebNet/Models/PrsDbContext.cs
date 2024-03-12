using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using PrsWebNet.Models;

namespace PrsWebNet.Models {
    public class PrsDbContext : DbContext{
        public DbSet<User> Users { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Request> LineItems { get; set; }

        // constructor to support dependency injection (via a service)
        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) {
        }
        public DbSet<PrsWebNet.Models.Product> Product { get; set; } = default!;
        public DbSet<PrsWebNet.Models.LineItem> LineItem { get; set; } = default!;

        //protected override void OnModelCreating(ModelBuilder modelBuilder) {
        //    modelBuilder.Entity<Product>()
        //        .HasOne(e => e.Vendor)
        //        .WithMany(e => e.Products)
        //        .HasForeignKey(e => e.VendorId)
        //        .IsRequired();
        //}
    }
}
