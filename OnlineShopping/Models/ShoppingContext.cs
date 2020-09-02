using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopping.Models
{
    public class ShoppingContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=OnlineShopping;user=root;password=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasOne(o => o.Customer);
            modelBuilder.Entity<Order>().HasMany(o => o.OrderProducts);

            modelBuilder.Entity<Product>().HasMany(o => o.OrderProducts);

            modelBuilder.Entity<Customer>().HasMany(o => o.Orders);
            modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

            modelBuilder.Entity<OrderProduct>().HasOne(o => o.Order);
            modelBuilder.Entity<OrderProduct>().HasOne(o => o.Product);

            modelBuilder.Entity<OrderProduct>().HasIndex(op => new {op.OrderId, op.ProductId}).IsUnique();

            modelBuilder.Entity<Payment>().HasOne(o => o.Order);

            modelBuilder.Entity<Delivery>().HasOne(o => o.Order);

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
    }
}
