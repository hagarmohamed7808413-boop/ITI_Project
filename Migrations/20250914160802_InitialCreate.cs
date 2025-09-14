using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Devices, gadgets and more", "Electronics" },
                    { 2, "Apparel and accessories", "Clothing" },
                    { 3, "Various genres and authors", "Books" },
                    { 4, "Home and office furniture", "Furniture" },
                    { 5, "Equipment and accessories for sports", "Sports" },
                    { 6, "Kids toys and educational games", "Toys" },
                    { 7, "Cosmetics and skincare products", "Beauty" },
                    { 8, "Food, drinks and household essentials", "Groceries" },
                    { 9, "Car parts and accessories", "Automotive" },
                    { 10, "Rings, necklaces, and watches", "Jewelry" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Email", "FirstName", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, "ahmed.ali@example.com", "Ahmed", "Ali", "123456" },
                    { 2, "sara.mohamed@example.com", "Sara", "Mohamed", "password1" },
                    { 3, "omar.hassan@example.com", "Omar", "Hassan", "qwerty123" },
                    { 4, "layla.ibrahim@example.com", "Layla", "Ibrahim", "mypassword" },
                    { 5, "youssef.fahmy@example.com", "Youssef", "Fahmy", "abc123" },
                    { 6, "mona.kamel@example.com", "Mona", "Kamel", "pass1234" },
                    { 7, "khaled.saeed@example.com", "Khaled", "Saeed", "securepass" },
                    { 8, "aya.mostafa@example.com", "Aya", "Mostafa", "password123" },
                    { 9, "islam.nabil@example.com", "Islam", "Nabil", "mypwd321" },
                    { 10, "dina.mahmoud@example.com", "Dina", "Mahmoud", "pass2025" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "Quantity", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Latest smartphone with advanced features", "images/smartphone.jpg", 750.00m, 50, "Smartphone X10" },
                    { 2, 2, "Comfortable running shoes for all terrains", "images/shoes.jpg", 120.00m, 100, "Running Shoes Model A" },
                    { 3, 4, "100% cotton casual t-shirt", "images/tshirt.jpg", 25.00m, 200, "Cotton T-Shirt" },
                    { 4, 3, "Outdoor furniture set", "images/chairset.jpg", 180.00m, 30, "Garden Chair Set" },
                    { 5, 6, "Best-selling sci-fi novel", "images/book.jpg", 15.00m, 150, "Science Fiction Novel" },
                    { 6, 7, "Noise-cancelling wireless headphones", "images/headphones.jpg", 350.00m, 45, "Wireless Headphones" },
                    { 7, 8, "Genuine leather jacket", "images/jacket.jpg", 250.00m, 60, "Leather Jacket" },
                    { 8, 9, "1.5L electric kettle with auto shutoff", "images/kettle.jpg", 40.00m, 80, "Electric Kettle" },
                    { 9, 1, "Durable mountain bike for off-road adventures", "images/bike.jpg", 500.00m, 20, "Mountain Bike" },
                    { 10, 10, "Non-slip yoga mat", "images/yogamat.jpg", 30.00m, 120, "Yoga Mat" },
                    { 11, 1, "Fitness tracker and smartwatch", "images/smartwatch.jpg", 280.00m, 75, "Smartwatch Z5" },
                    { 12, 2, "Slim fit formal shirt", "images/formalshirt.jpg", 45.00m, 90, "Formal Shirt" },
                    { 13, 3, "Non-stick pan set for kitchen", "images/panset.jpg", 120.00m, 55, "Cooking Pan Set" },
                    { 14, 1, "Ergonomic wireless mouse", "images/mouse.jpg", 25.00m, 130, "Wireless Mouse" },
                    { 15, 5, "Blue denim jeans", "images/jeans.jpg", 60.00m, 160, "Jeans" },
                    { 16, 3, "LED desk lamp with adjustable arm", "images/lampe.jpg", 35.00m, 70, "Desk Lamp" },
                    { 17, 1, "Portable bluetooth speaker", "images/speaker.jpg", 90.00m, 85, "Bluetooth Speaker" },
                    { 18, 2, "Lightweight sports shorts", "images/shorts.jpg", 30.00m, 140, "Sports Shorts" },
                    { 19, 5, "Modern wall decoration", "images/wallart.jpg", 150.00m, 40, "Wall Art Painting" },
                    { 20, 1, "Track your health and activity", "images/fitnesstracker.jpg", 110.00m, 95, "Fitness Tracker" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
