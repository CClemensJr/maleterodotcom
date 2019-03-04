using Microsoft.EntityFrameworkCore.Migrations;

namespace Maletero.Migrations
{
    public partial class newseedtesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "women's brown and red leather tote bag", "https://images.unsplash.com/photo-1525708570275-58d59ffe4a93?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80", "Tote", 2.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Roud woven brown sling bag", "https://images.unsplash.com/photo-1527430203327-e97f64c96a2c?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "Sling Bag", 3.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Woven tote bag with red embroidered elephant", "https://images.unsplash.com/photo-1494578151111-d35ec4c84e2b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1052&q=80", "Elephant Bag", 1.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProducttEightDescription", "https://via.placeholder.com/150", "ProductEightName", 80.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductNineDescription", "https://via.placeholder.com/150", "ProductNineName", 90.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductTenDescription", "https://via.placeholder.com/150", "ProductTenName", 100.00m });
        }
    }
}
