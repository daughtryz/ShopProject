using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Database.DataContext
{
   public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }


        public DbSet<Role> Roles { get; set; }

        public DbSet<UserRole> UserRoles { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Payment> Payments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=localhost;Database=Shop;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserRole>().HasOne<User>(u => u.User).WithMany(u => u.UserRoles).HasForeignKey(f => f.UserId);

            modelBuilder.Entity<UserRole>().HasOne<Role>(u => u.Role).WithMany(u => u.UserRoles).HasForeignKey(f => f.RoleId);


            modelBuilder.Entity<UserRole>().HasKey(x => new { x.RoleId, x.UserId });


            modelBuilder.Entity<Product>().HasOne(x => x.Payment).WithMany(p => p.Products).HasForeignKey(f => f.PaymentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

