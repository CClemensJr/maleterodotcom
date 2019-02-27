﻿// <auto-generated />
using Maletero.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Maletero.Migrations
{
    [DbContext(typeof(MaleteroDbContext))]
    partial class MaleteroDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Maletero.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("SKU");

                    b.HasKey("ID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Description = "ProductOneDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductOneName",
                            Price = 10.00m,
                            SKU = "abc-1"
                        },
                        new
                        {
                            ID = 2,
                            Description = "ProductTwoDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductTwoName",
                            Price = 20.00m,
                            SKU = "abc-2"
                        },
                        new
                        {
                            ID = 3,
                            Description = "ProductThreeDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductThreeName",
                            Price = 30.00m,
                            SKU = "abc-3"
                        },
                        new
                        {
                            ID = 4,
                            Description = "ProductFourDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductTFourName",
                            Price = 40.00m,
                            SKU = "abc-4"
                        },
                        new
                        {
                            ID = 5,
                            Description = "ProductTFiveDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductFiveName",
                            Price = 50.00m,
                            SKU = "abc-5"
                        },
                        new
                        {
                            ID = 6,
                            Description = "ProductSixDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductSixName",
                            Price = 60.00m,
                            SKU = "abc-6"
                        },
                        new
                        {
                            ID = 7,
                            Description = "ProductSevenDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductSevenName",
                            Price = 70.00m,
                            SKU = "abc-7"
                        },
                        new
                        {
                            ID = 8,
                            Description = "ProducttEightDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductEightName",
                            Price = 80.00m,
                            SKU = "abc-8"
                        },
                        new
                        {
                            ID = 9,
                            Description = "ProductNineDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductNineName",
                            Price = 90.00m,
                            SKU = "abc-9"
                        },
                        new
                        {
                            ID = 10,
                            Description = "ProductTenDescription",
                            Image = "https://via.placeholder.com/150",
                            Name = "ProductTenName",
                            Price = 100.00m,
                            SKU = "abc-10"
                        });
                });

            modelBuilder.Entity("Maletero.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CartID");

                    b.Property<int>("ProductIDID");

                    b.Property<int>("ProductQuantity");

                    b.Property<int>("ShopperID");

                    b.HasKey("ID");

                    b.HasIndex("ProductIDID");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Maletero.Models.ShoppingCart", b =>
                {
                    b.HasOne("Maletero.Models.Product", "ProductID")
                        .WithMany()
                        .HasForeignKey("ProductIDID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
