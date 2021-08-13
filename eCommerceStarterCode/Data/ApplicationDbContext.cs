﻿using eCommerceStarterCode.Configuration;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eCommerceStarterCode.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            : base(options)
        { }
         public DbSet<Product> Products { get; set; }

        // Creating a Joint Table for our Shopping Cart
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //   modelBuilder.ApplyConfiguration(new RolesConfiguration());
            modelBuilder.Entity<ShoppingCart>()
                   .HasKey(bc => new { bc.UserId, bc.ProductId });
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.ShoppingCarts)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(bc => bc.Product)
                .WithMany(c => c.ShoppingCarts)
                .HasForeignKey(bc => bc.ProductId);
            {
                base.OnModelCreating(modelBuilder);

                modelBuilder.Entity<Review>()
                    .HasKey(bc => new { bc.UserId, bc.ProductId });
                modelBuilder.Entity<Review>()
                    .HasOne(bc => bc.User)
                    .WithMany(b => b.Reviews)
                    .HasForeignKey(bc => bc.UserId);
                modelBuilder.Entity<Review>()
                    .HasOne(bc => bc.Product)
                    .WithMany(c => c.Reviews)
                    .HasForeignKey(bc => bc.ProductId);

            }
        }

    }
}