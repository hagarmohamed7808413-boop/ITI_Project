using Microsoft.EntityFrameworkCore;
using Project.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Project.Context
{
    public class MYContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-9RDHD2I;Database=PROJECT;Trusted_Connection=True;TrustServerCertificate=true";
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var products = new List<Product>()
{
                   new Product { ProductId = 1, Title = "Smartphone X10", Price = 750.00m, Description = "Latest smartphone with advanced features", Quantity = 50, ImagePath = "images/smartphone.jpg", CategoryId = 1 },
                   new Product { ProductId = 2, Title = "Running Shoes Model A", Price = 120.00m, Description = "Comfortable running shoes for all terrains", Quantity = 100, ImagePath = "images/shoes.jpg", CategoryId = 2 },
                   new Product { ProductId = 3, Title = "Cotton T-Shirt", Price = 25.00m, Description = "100% cotton casual t-shirt", Quantity = 200, ImagePath = "images/tshirt.jpg", CategoryId = 4 },
                   new Product { ProductId = 4, Title = "Garden Chair Set", Price = 180.00m, Description = "Outdoor furniture set", Quantity = 30, ImagePath = "images/chairset.jpg", CategoryId = 3 },
                   new Product { ProductId = 5, Title = "Science Fiction Novel", Price = 15.00m, Description = "Best-selling sci-fi novel", Quantity = 150, ImagePath = "images/book.jpg", CategoryId = 6 },
                   new Product { ProductId = 6, Title = "Wireless Headphones", Price = 350.00m, Description = "Noise-cancelling wireless headphones", Quantity = 45, ImagePath = "images/headphones.jpg", CategoryId = 7},
                   new Product { ProductId = 7, Title = "Leather Jacket", Price = 250.00m, Description = "Genuine leather jacket", Quantity = 60, ImagePath = "images/jacket.jpg", CategoryId = 8 },
                   new Product { ProductId = 8, Title = "Electric Kettle", Price = 40.00m, Description = "1.5L electric kettle with auto shutoff", Quantity = 80, ImagePath = "images/kettle.jpg", CategoryId = 9 },
                   new Product { ProductId = 9, Title = "Mountain Bike", Price = 500.00m, Description = "Durable mountain bike for off-road adventures", Quantity = 20, ImagePath = "images/bike.jpg", CategoryId = 1 },
                   new Product { ProductId = 10, Title = "Yoga Mat", Price = 30.00m, Description = "Non-slip yoga mat", Quantity = 120, ImagePath = "images/yogamat.jpg", CategoryId = 10},
                   new Product { ProductId = 11, Title = "Smartwatch Z5", Price = 280.00m, Description = "Fitness tracker and smartwatch", Quantity = 75, ImagePath = "images/smartwatch.jpg", CategoryId = 1 },
                   new Product { ProductId = 12, Title = "Formal Shirt", Price = 45.00m, Description = "Slim fit formal shirt", Quantity = 90, ImagePath = "images/formalshirt.jpg", CategoryId = 2 },
                   new Product { ProductId = 13, Title = "Cooking Pan Set", Price = 120.00m, Description = "Non-stick pan set for kitchen", Quantity = 55, ImagePath = "images/panset.jpg", CategoryId = 3 },
                   new Product { ProductId = 14, Title = "Wireless Mouse", Price = 25.00m, Description = "Ergonomic wireless mouse", Quantity = 130, ImagePath = "images/mouse.jpg", CategoryId = 1 },
                   new Product { ProductId = 15, Title = "Jeans", Price = 60.00m, Description = "Blue denim jeans", Quantity = 160, ImagePath = "images/jeans.jpg", CategoryId = 5},
                   new Product { ProductId = 16, Title = "Desk Lamp", Price = 35.00m, Description = "LED desk lamp with adjustable arm", Quantity = 70, ImagePath = "images/lampe.jpg", CategoryId = 3 },
                   new Product { ProductId = 17, Title = "Bluetooth Speaker", Price = 90.00m, Description = "Portable bluetooth speaker", Quantity = 85, ImagePath = "images/speaker.jpg", CategoryId = 1 },
                   new Product { ProductId = 18, Title = "Sports Shorts", Price = 30.00m, Description = "Lightweight sports shorts", Quantity = 140, ImagePath = "images/shorts.jpg", CategoryId = 2 },
                   new Product { ProductId = 19, Title = "Wall Art Painting", Price = 150.00m, Description = "Modern wall decoration", Quantity = 40, ImagePath = "images/wallart.jpg", CategoryId = 5},
                   new Product { ProductId = 20, Title = "Fitness Tracker", Price = 110.00m, Description = "Track your health and activity", Quantity = 95, ImagePath = "images/fitnesstracker.jpg", CategoryId = 1 }
};
            ;
            var Users = new List<User>()
            {
               new User { UserId = 1, FirstName = "Ahmed", LastName = "Ali", Email = "ahmed.ali@example.com", Password = "123456" },
               new User { UserId = 2, FirstName = "Sara", LastName = "Mohamed", Email = "sara.mohamed@example.com", Password = "password1" },
               new User { UserId = 3, FirstName = "Omar", LastName = "Hassan", Email = "omar.hassan@example.com", Password = "qwerty123" },
               new User { UserId = 4, FirstName = "Layla", LastName = "Ibrahim", Email = "layla.ibrahim@example.com", Password = "mypassword" },
               new User { UserId = 5, FirstName = "Youssef", LastName = "Fahmy", Email = "youssef.fahmy@example.com", Password = "abc123" },
               new User { UserId = 6, FirstName = "Mona", LastName = "Kamel", Email = "mona.kamel@example.com", Password = "pass1234" },
               new User { UserId = 7, FirstName = "Khaled", LastName = "Saeed", Email = "khaled.saeed@example.com", Password = "securepass" },
               new User { UserId = 8, FirstName = "Aya", LastName = "Mostafa", Email = "aya.mostafa@example.com", Password = "password123" },
               new User { UserId = 9, FirstName = "Islam", LastName = "Nabil", Email = "islam.nabil@example.com", Password = "mypwd321" },
               new User { UserId = 10, FirstName = "Dina", LastName = "Mahmoud", Email = "dina.mahmoud@example.com", Password = "pass2025" }
    };

            var categories = new List<Category>()
             {
            new Category { CategoryId = 1, Name = "Electronics", Description = "Devices, gadgets and more" },
            new Category { CategoryId = 2, Name = "Clothing", Description = "Apparel and accessories" },
            new Category { CategoryId = 3, Name = "Books", Description = "Various genres and authors" },
            new Category { CategoryId = 4, Name = "Furniture", Description = "Home and office furniture" },
            new Category { CategoryId = 5, Name = "Sports", Description = "Equipment and accessories for sports" },
            new Category { CategoryId = 6, Name = "Toys", Description = "Kids toys and educational games" },
            new Category { CategoryId = 7, Name = "Beauty", Description = "Cosmetics and skincare products" },
            new Category { CategoryId = 8, Name = "Groceries", Description = "Food, drinks and household essentials" },
            new Category { CategoryId = 9, Name = "Automotive", Description = "Car parts and accessories" },
            new Category { CategoryId = 10, Name = "Jewelry", Description = "Rings, necklaces, and watches" }

             };


            modelBuilder
                   .Entity<Product>()
                    .HasData(products);

            modelBuilder
                .Entity<User>()
                    .HasData(Users);


            modelBuilder
                   .Entity<Category>()
                    .HasData(categories);

            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<User> Users { get; set; }

    }
}


