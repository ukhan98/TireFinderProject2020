﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace TireFinderProject2020.Models
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        { 
        
        }
        public DbSet<Tire> Tires { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ShoppingCartItem> ShopppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "By Vehicle" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "By Brand" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "By Size" });


            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 1,
                Name = "Assorted Chocolate Candy",
                Price = 4.95M,
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque. Tortor posuere ac ut consequat. Sagittis nisl rhoncus mattis rhoncus urna neque viverra justo. Lacus sed turpis tincidunt id aliquet risus feugiat in. Viverra aliquet eget sit amet tellus cras adipiscing enim eu.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 2,
                Name = "Another Assorted Chocolate Candy",
                Price = 3.95M,
                Description = "Venenatis tellus in metus vulputate eu scelerisque felis imperdiet proin. Quisque egestas diam in arcu cursus. Sed viverra tellus in hac. Quis commodo odio aenean sed adipiscing diam donec adipiscing.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            }); modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 3,
                Name = "Another Chocolate Candy",
                Price = 5.75M,
                Description = "Turpis egestas pretium aenean pharetra magna ac placerat vestibulum. Sed faucibus turpis in eu mi bibendum neque egestas. At in tellus integer feugiat scelerisque. Elementum integer enim neque volutpat ac tincidunt.",
                CategoryId = 1,
                ImageUrl = "\\Images\\chocolateCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\chocolateCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 4,
                Name = "Assorted Fruit Candy",
                Price = 3.95M,
                Description = "Vitae congue eu consequat ac felis donec et. Praesent semper feugiat nibh sed pulvinar proin gravida hendrerit. Vel eros donec ac odio. A lacus vestibulum sed arcu non odio euismod lacinia at. Nisl suscipit adipiscing bibendum est ultricies integer. Nec tincidunt praesent semper feugiat nibh.",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 5,
                Name = "Fruit Candy",
                Price = 7.00M,
                Description = "Purus sit amet luctus venenatis lectus magna fringilla. Consectetur lorem donec massa sapien faucibus et molestie ac. Sagittis nisl rhoncus mattis rhoncus urna neque viverra.",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 6,
                Name = "Another Assorted Fruit Candy",
                Price = 11.25M,
                Description = "Ultrices vitae auctor eu augue ut. Leo vel fringilla est ullamcorper eget. A diam maecenas sed enim ut. Massa tincidunt dui ut ornare lectus. Nullam non nisi est sit amet facilisis magna. ",
                CategoryId = 2,
                ImageUrl = "\\Images\\fruitCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\fruitCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 7,
                Name = "Assorted Gummy Candy",
                Price = 3.95M,
                Description = "Diam sit amet nisl suscipit adipiscing bibendum est ultricies integer. Molestie at elementum eu facilisis sed odio morbi quis commodo. Odio facilisis mauris sit amet massa vitae tortor condimentum lacinia. Urna porttitor rhoncus dolor purus non enim praesent elementum facilisis.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy-small.jpg",
                IsInStock = true,
                IsOnSale = true
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 8,
                Name = "Another Assorted Gummy Candy",
                Price = 1.95M,
                Description = "Posuere ac ut consequat semper viverra nam libero justo laoreet. Ultrices dui sapien eget mi proin sed libero enim. Etiam non quam lacus suspendisse faucibus interdum. Amet nisl suscipit adipiscing bibendum est ultricies integer quis.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy2.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy2-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
            modelBuilder.Entity<Tire>().HasData(new Tire
            {
                TireId = 9,
                Name = "Gummy Candy",
                Price = 13.95M,
                Description = "Ut ornare lectus sit amet est placerat in egestas. Iaculis nunc sed augue lacus viverra vitae. Bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida. Accumsan tortor posuere ac ut consequat semper viverra.",
                CategoryId = 3,
                ImageUrl = "\\Images\\gummyCandy3.jpg",
                ImageThumbnailUrl = "\\Images\\thumbnails\\gummyCandy3-small.jpg",
                IsInStock = true,
                IsOnSale = false
            });
           
        }
    }
}
