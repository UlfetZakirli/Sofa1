using Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ShoppingDB:IdentityDbContext<User>
    {

        public ShoppingDB(DbContextOptions opt):base(opt)
        {
                
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            builder.Entity<IdentityRole>().ToTable("Roles");
            builder.Entity<User>().HasData(
                new User
                {
                    Id = "1023",
                    Email = "ulfet@gmail.com",
                    Name = "Ulfet",
                    Address = "Azərbaycan",
                    PhoneNumber = "+994-55-5454452",
                    UserName = "ulfet@gmail.com",
                    ConcurrencyStamp = "sdchsuicmkms",
                    EmailConfirmed = true,
                    NormalizedEmail = "ULFET@GMAIL.COM",
                    PhoneNumberConfirmed = true,
                    LockoutEnabled = true,
                    NormalizedUserName = "ULFET@GMAIL.COM",
                    TwoFactorEnabled = true,
                    AccessFailedCount = 1,
                    LockoutEnd = DateTime.Now,
                    PasswordHash = null,
                    SecurityStamp = null,
                });

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "abs21",
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                    ConcurrencyStamp = "sdxjwdxjmskm"
                }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "abs21",
                    UserId = "1023"
                });

            builder.Entity<Category>().HasData(
                new Category {ID=1, Name = "Kitchen" },
                new Category {ID=2, Name = "Living Room" },
                new Category {ID=3, Name = "Bedroom" },
                new Category {ID=4, Name = "Office" }
                );
            builder.Entity<Product>().HasData(
               new Product {
                   ID=1,
                   Name = "Kitchen",
                   Price =2400,
                   Discount=2219,
                   CategoryID=1,
                   IsFeatured = false

               },
                new Product
                {
                    ID=2,
                    Name = "Bedroom",
                    Price = 2300,
                    Discount=2100,
                    CategoryID = 2,
                    IsFeatured = true,
                }
               );
        }


    }
}
