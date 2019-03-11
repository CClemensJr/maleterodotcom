using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Maletero.Migrations
{
    public partial class ordertesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "ShoppingCartItems",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserID = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_OrderID",
                table: "ShoppingCartItems",
                column: "OrderID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Orders_OrderID",
                table: "ShoppingCartItems",
                column: "OrderID",
                principalTable: "Orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Orders_OrderID",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingCartItems_OrderID",
                table: "ShoppingCartItems");

            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "ShoppingCartItems");
        }
    }
}
