﻿// <auto-generated />
using Maletero.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Maletero.Migrations
{
    [DbContext(typeof(MaleteroDbContext))]
    [Migration("20190304210420_newseedtesting")]
    partial class newseedtesting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Description = "Grey and blackpack with multiple outer compartments",
                            Image = "https://images.unsplash.com/photo-1509762774605-f07235a08f1f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                            Name = "Mountaineer Backpack",
                            Price = 1.00m,
                            SKU = "abc-1"
                        },
                        new
                        {
                            ID = 2,
                            Description = "Brown leather duffle bag",
                            Image = "https://images.unsplash.com/photo-1525103504173-8dc1582c7430?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1053&q=80",
                            Name = "Leather Duffle",
                            Price = 2.00m,
                            SKU = "abc-2"
                        },
                        new
                        {
                            ID = 3,
                            Description = "Tan waterproof duffle bag with removable shoulder strap",
                            Image = "https://images.unsplash.com/photo-1448582649076-3981753123b5?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80",
                            Name = "Tan Duffle",
                            Price = 3.00m,
                            SKU = "abc-3"
                        },
                        new
                        {
                            ID = 4,
                            Description = "Water-proof black backpack with adjustable straps",
                            Image = "https://images.unsplash.com/photo-1505308144658-03c69861061a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80",
                            Name = "Unsplash Backpack",
                            Price = 1.00m,
                            SKU = "abc-4"
                        },
                        new
                        {
                            ID = 5,
                            Description = "Convertible carrier bag also can be used as a roller suitcase",
                            Image = "https://images.unsplash.com/photo-1515935480894-3bab89cf8e89?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80",
                            Name = "Burgundy Convertible Bag",
                            Price = 2.00m,
                            SKU = "abc-5"
                        },
                        new
                        {
                            ID = 6,
                            Description = "Camel-colored leather laptop bag",
                            Image = "https://images.unsplash.com/photo-1473445361085-b9a07f55608b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80",
                            Name = "laptop Bag",
                            Price = 1.00m,
                            SKU = "abc-6"
                        },
                        new
                        {
                            ID = 7,
                            Description = "Vintae suitcase with metal buckles",
                            Image = "https://images.unsplash.com/photo-1515622472995-1a06094d2224?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=80",
                            Name = "Vintage Maleta",
                            Price = 3.00m,
                            SKU = "abc-7"
                        },
                        new
                        {
                            ID = 8,
                            Description = "women's brown and red leather tote bag",
                            Image = "https://images.unsplash.com/photo-1525708570275-58d59ffe4a93?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80",
                            Name = "Tote",
                            Price = 2.00m,
                            SKU = "abc-8"
                        },
                        new
                        {
                            ID = 9,
                            Description = "Roud woven brown sling bag",
                            Image = "https://images.unsplash.com/photo-1527430203327-e97f64c96a2c?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80",
                            Name = "Sling Bag",
                            Price = 3.00m,
                            SKU = "abc-9"
                        },
                        new
                        {
                            ID = 10,
                            Description = "Woven tote bag with red embroidered elephant",
                            Image = "https://images.unsplash.com/photo-1494578151111-d35ec4c84e2b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1052&q=80",
                            Name = "Elephant Bag",
                            Price = 1.00m,
                            SKU = "abc-10"
                        });
                });

            modelBuilder.Entity("Maletero.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UserID")
                        .IsRequired();

                    b.HasKey("ID");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("Maletero.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID");

                    b.Property<int>("Quantity");

                    b.Property<int>("ShoppingCartID");

                    b.HasKey("ID");

                    b.HasIndex("ProductID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Maletero.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("Maletero.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Maletero.Models.ShoppingCart")
                        .WithMany("ShoppingCartItems")
                        .HasForeignKey("ShoppingCartID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
