using Microsoft.EntityFrameworkCore.Migrations;

namespace Maletero.Migrations
{
    public partial class UpdatedCartAndCartItemProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumberOfProducts",
                table: "ShoppingCartItems",
                newName: "Quantity");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductID",
                table: "ShoppingCartItems",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductID",
                table: "ShoppingCartItems",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Products_ProductID",
                table: "ShoppingCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_ProductID",
                table: "ShoppingCartItems");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "ShoppingCartItems",
                newName: "NumberOfProducts");
        }
    }
}
