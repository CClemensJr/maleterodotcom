using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maletero.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SKU = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCarts",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCarts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ShoppingCartID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    NumberOfProducts = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_ShoppingCarts_ShoppingCartID",
                        column: x => x.ShoppingCartID,
                        principalTable: "ShoppingCarts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Description", "Image", "Name", "Price", "SKU" },
                values: new object[,]
                {
                    { 1, "ProductOneDescription", "https://via.placeholder.com/150", "ProductOneName", 10.00m, "abc-1" },
                    { 2, "ProductTwoDescription", "https://via.placeholder.com/150", "ProductTwoName", 20.00m, "abc-2" },
                    { 3, "ProductThreeDescription", "https://via.placeholder.com/150", "ProductThreeName", 30.00m, "abc-3" },
                    { 4, "ProductFourDescription", "https://via.placeholder.com/150", "ProductTFourName", 40.00m, "abc-4" },
                    { 5, "ProductTFiveDescription", "https://via.placeholder.com/150", "ProductFiveName", 50.00m, "abc-5" },
                    { 6, "ProductSixDescription", "https://via.placeholder.com/150", "ProductSixName", 60.00m, "abc-6" },
                    { 7, "ProductSevenDescription", "https://via.placeholder.com/150", "ProductSevenName", 70.00m, "abc-7" },
                    { 8, "ProducttEightDescription", "https://via.placeholder.com/150", "ProductEightName", 80.00m, "abc-8" },
                    { 9, "ProductNineDescription", "https://via.placeholder.com/150", "ProductNineName", 90.00m, "abc-9" },
                    { 10, "ProductTenDescription", "https://via.placeholder.com/150", "ProductTenName", 100.00m, "abc-10" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ShoppingCartID",
                table: "ShoppingCartItems",
                column: "ShoppingCartID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "ShoppingCarts");
        }
    }
}
