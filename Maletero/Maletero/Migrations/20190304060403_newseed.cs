using Microsoft.EntityFrameworkCore.Migrations;

namespace Maletero.Migrations
{
    public partial class newseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Grey and blackpack with multiple outer compartments", "https://images.unsplash.com/photo-1509762774605-f07235a08f1f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80", "Mountaineer Backpack", 1.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Brown leather duffle bag", "https://images.unsplash.com/photo-1525103504173-8dc1582c7430?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1053&q=80", "Leather Duffle", 2.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Tan waterproof duffle bag with removable shoulder strap", "https://images.unsplash.com/photo-1448582649076-3981753123b5?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "Tan Duffle", 3.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Water-proof black backpack with adjustable straps", "https://images.unsplash.com/photo-1505308144658-03c69861061a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80", "Unsplash Backpack", 1.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Convertible carrier bag also can be used as a roller suitcase", "https://images.unsplash.com/photo-1515935480894-3bab89cf8e89?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80", "Burgundy Convertible Bag", 2.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Camel-colored leather laptop bag", "https://images.unsplash.com/photo-1473445361085-b9a07f55608b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80", "laptop Bag", 1.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "Vintae suitcase with metal buckles", "https://images.unsplash.com/photo-1515622472995-1a06094d2224?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=80", "Vintage Maleta", 3.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductOneDescription", "https://via.placeholder.com/150", "ProductOneName", 10.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductTwoDescription", "https://via.placeholder.com/150", "ProductTwoName", 20.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductThreeDescription", "https://via.placeholder.com/150", "ProductThreeName", 30.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductFourDescription", "https://via.placeholder.com/150", "ProductTFourName", 40.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductTFiveDescription", "https://via.placeholder.com/150", "ProductFiveName", 50.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductSixDescription", "https://via.placeholder.com/150", "ProductSixName", 60.00m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Description", "Image", "Name", "Price" },
                values: new object[] { "ProductSevenDescription", "https://via.placeholder.com/150", "ProductSevenName", 70.00m });
        }
    }
}
