using System;
using System.Collections.Generic;
using System.Text;
using BackendProject.Entities.Concrete;
using Core.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BackendProject.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<Product>().Property(p => p.ProductId).HasColumnName("ProductID");
            modelBuilder.Entity<Product>().Property(p => p.ProductName).HasColumnName("ProductName");
            modelBuilder.Entity<Product>().Property(p => p.CategoryId).HasColumnName("CategoryId");
            modelBuilder.Entity<Product>().Property(p => p.UnitPrice).HasColumnName("UnitPrice");
            modelBuilder.Entity<Product>().Property(p => p.UnitsInStock).HasColumnName("UnitsInStock");

            modelBuilder.Entity<Category>().ToTable("Categories");
            modelBuilder.Entity<Category>().Property(c => c.CategoryId).HasColumnName("CategoryID");
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasColumnName("CategoryName");

            modelBuilder.Entity<Customer>().ToTable("Customers");
            modelBuilder.Entity<Customer>().Property(c => c.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<Customer>().Property(c => c.City).HasColumnName("City");
            modelBuilder.Entity<Customer>().Property(c => c.CompanyName).HasColumnName("CompanyName");
            modelBuilder.Entity<Customer>().Property(c => c.ContactName).HasColumnName("ContactName");

            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<Order>().Property(o => o.CustomerId).HasColumnName("CustomerID");
            modelBuilder.Entity<Order>().Property(o => o.EmployeeId).HasColumnName("EmployeeID");
            modelBuilder.Entity<Order>().Property(o => o.OrderDate).HasColumnName("OrderDate");
            modelBuilder.Entity<Order>().Property(o => o.OrderId).HasColumnName("OrderID");
            modelBuilder.Entity<Order>().Property(o => o.ShipCity).HasColumnName("ShipCity");

        }
    }
}
