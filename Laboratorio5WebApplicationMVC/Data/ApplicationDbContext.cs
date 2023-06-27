using Laboratorio5WebApplicationMVC.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Laboratorio5WebApplicationMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasIndex(c => new { c.LastName, c.FirstName })
                .HasDatabaseName("IndexCustomerName");

            modelBuilder.Entity<Order>()
                .HasIndex(o => o.CustomerId)
                .HasDatabaseName("IndexOrderCustomerId");
            modelBuilder.Entity<Order>()
                .HasIndex(o => o.OrderDate)
                .HasDatabaseName("IndexOrderOrderDate");

            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.OrderId)
                .HasDatabaseName("IndexOrderItemOrderId");
            modelBuilder.Entity<OrderItem>()
                .HasIndex(oi => oi.ProductId)
                .HasDatabaseName("IndexOrderItemProductId");

            modelBuilder.Entity<Product>()
                .HasIndex(p => p.SupplierId)
                .HasDatabaseName("IndexProductSupplierId");
            modelBuilder.Entity<Product>()
                .HasIndex(p => p.ProductName)
                .HasDatabaseName("IndexProductName");

            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.CompanyName)
                .HasDatabaseName("IndexSupplierName");
            modelBuilder.Entity<Supplier>()
                .HasIndex(s => s.Country)
                .HasDatabaseName("IndexSupplierCountry");

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}