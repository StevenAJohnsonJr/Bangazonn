using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Http.Json;
using Bangazonn.Models;
using System.Runtime.CompilerServices;
using System;
using System.Collections.Generic;

namespace Bangazonn
{ 
        public class BangazonnDbContext : DbContext
    {

        public DbSet<Users> Users { get; set; }
        public DbSet<UserPayments> UserPayments { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<PaymentTypes> PaymentTypes { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatus { get; set; }

        public BangazonnDbContext(DbContextOptions<BangazonnDbContext> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            _ = modelBuilder.Entity<Users>().HasData(new Users[]
           {
            new Users {Id = 1, Name = "Trent Jones", Username = "Trent3000", Created_at = new DateTime(2023,4,20), isSeller = true},
            new Users {Id = 2, Name = "Jack James", Username = "Jack9000", Created_at = new DateTime(2023,8,20), isSeller = false},
            new Users {Id = 3, Name = "Barry Holmes", Username = "Barcoder1500", Created_at = new DateTime(2023,1,2), isSeller = true},
            new Users {Id = 4, Name = "Manny Marzone", Username = "ZoneTyme5000", Created_at = new DateTime(2023,4,3), isSeller = true},
            new Users {Id = 5, Name = "Travis Sharp", Username = "Sharpx6", Created_at = new DateTime(2023,7,20), isSeller = false},
           });

            modelBuilder.Entity<UserPayments>().HasData(new UserPayments[]
            {
            new UserPayments {Id = 1, UserId = 1, PaymentId = 1,},
            new UserPayments {Id = 2, UserId = 2, PaymentId = 2,},
            new UserPayments {Id = 3, UserId = 3, PaymentId = 3,},
            new UserPayments {Id = 4, UserId = 4, PaymentId = 4,},
            new UserPayments {Id = 5, UserId = 5, PaymentId = 5,},
            });

            modelBuilder.Entity<Products>().HasData(new Products[]
            {
            new Products {Id = 4, Name = "iPhone 14", Price = 1099, CategoryId = 4},
            new Products {Id = 2, Name = "The Godfather", Price = 20, CategoryId = 2},
            new Products {Id = 3, Name = "Towerl Set", Price = 15, CategoryId = 3},
            new Products {Id = 1, Name = "Silverware Set ", Price = 100, CategoryId = 1},
            new Products {Id = 5, Name = "lawn Mower", Price = 255, CategoryId = 5},

            });


            modelBuilder.Entity<ProductCategories>().HasData(new ProductCategories[]
            {
            new ProductCategories {Id = 1, Name = "Kitchen",},
            new ProductCategories {Id = 2, Name = "Books",},
            new ProductCategories {Id = 3, Name = "Home",},
            new ProductCategories {Id = 4, Name = "Electronics",},
            new ProductCategories {Id = 5, Name = "Outdoors",},
            });

            modelBuilder.Entity<PaymentTypes>().HasData(new PaymentTypes[]
            {
            new PaymentTypes {Id = 1, Name = "Cash",},
            new PaymentTypes {Id = 2, Name = "Card",},
        
            });

            modelBuilder.Entity<OrderStatus>().HasData(new OrderStatus[]
          {
            new OrderStatus {Id = 1, Name = "Completed",},
            new OrderStatus {Id = 2, Name = "Not Completed",},

          });

            _ = modelBuilder.Entity<Orders>().HasData(new Orders[]
         {
            new Orders {Id = 1, Userid = 1, ProductId = 1, OrderDate = new DateTime(2023,4,20), StatusUpdateDate = new DateTime(2023,4,21)},
            new Orders {Id = 2, Userid = 2, ProductId = 2, OrderDate = new DateTime(2023,6,2), StatusUpdateDate = new DateTime(2023,6,3)},
            new Orders {Id = 3, Userid = 3, ProductId = 3, OrderDate = new DateTime(2023,8,15), StatusUpdateDate = new DateTime(2023,8,16)},
            new Orders {Id = 4, Userid = 4, ProductId = 4, OrderDate = new DateTime(2023,1,28), StatusUpdateDate = new DateTime(2023,1,28)},
            new Orders {Id = 5, Userid = 5, ProductId = 5, OrderDate = new DateTime(2023,7,4), StatusUpdateDate = new DateTime(2023,7,6)},
         });

            ;
            
        }
    }
}