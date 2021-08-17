using eCommerceStarterCode.Configuration;
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

            // Assigns Roles. Do not delete or comment out upon Update-Database
            modelBuilder.ApplyConfiguration(new RolesConfiguration());

            // Assigns relationship between User, Product and ShoppingCart tables.
            modelBuilder.Entity<ShoppingCart>()
                .HasKey(sc => new { sc.UserId, sc.ProductId });
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.User)
                .WithMany(sc => sc.ShoppingCarts)
                .HasForeignKey(sc => sc.UserId);
            modelBuilder.Entity<ShoppingCart>()
                .HasOne(sc => sc.Product)
                .WithMany(sc => sc.ShoppingCarts)
                .HasForeignKey(sc => sc.ProductId);

            modelBuilder.Entity<Review>()
                .HasKey(rev => new { rev.UserId, rev.ProductId });
            modelBuilder.Entity<Review>()
                .HasOne(rev => rev.User)
                .WithMany(rev => rev.Reviews)
                .HasForeignKey(rev => rev.UserId);
            modelBuilder.Entity<Review>()
                .HasOne(rev => rev.Product)
                .WithMany(rev => rev.Reviews)
                .HasForeignKey(rev => rev.ProductId);

            modelBuilder.Entity<Category>()
                .HasKey(cat => new { cat.CategoryId });
            modelBuilder.Entity<Category>()
                .HasOne(cat => cat.Product)
                .WithMany(cat => cat.Categories)
                .HasForeignKey(cat => cat.ProductId);
        }

    }
}