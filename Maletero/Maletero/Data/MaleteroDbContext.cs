using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Maletero.Data
{
    public class MaleteroDbContext :DbContext 
    {
        public MaleteroDbContext(DbContextOptions<MaleteroDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //seed db with data

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID= 1,
                    SKU= "abc-1",
                    Name = "ProductOneName",
                    Price = 10.00m,
                    Description = "ProductOneDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 2,
                    SKU = "abc-2",
                    Name = "ProductTwoName",
                    Price = 20.00m,
                    Description = "ProductTwoDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 3,
                    SKU = "abc-3",
                    Name = "ProductThreeName",
                    Price = 30.00m,
                    Description = "ProductThreeDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 4,
                    SKU = "abc-4",
                    Name = "ProductTFourName",
                    Price = 40.00m,
                    Description = "ProductFourDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 5,
                    SKU = "abc-5",
                    Name = "ProductFiveName",
                    Price = 50.00m,
                    Description = "ProductTFiveDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 6,
                    SKU = "abc-6",
                    Name = "ProductSixName",
                    Price = 60.00m,
                    Description = "ProductSixDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 7,
                    SKU = "abc-7",
                    Name = "ProductSevenName",
                    Price = 70.00m,
                    Description = "ProductSevenDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 8,
                    SKU = "abc-8",
                    Name = "ProductEightName",
                    Price = 80.00m,
                    Description = "ProducttEightDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 9,
                    SKU = "abc-9",
                    Name = "ProductNineName",
                    Price = 90.00m,
                    Description = "ProductNineDescription",
                    Image = "https://via.placeholder.com/150"
                },
                new Product
                {
                    ID = 10,
                    SKU = "abc-10",
                    Name = "ProductTenName",
                    Price = 100.00m,
                    Description = "ProductTenDescription",
                    Image = "https://via.placeholder.com/150"
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
    }
}
