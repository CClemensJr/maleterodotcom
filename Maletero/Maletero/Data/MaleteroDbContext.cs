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
                    Name = "Mountaineer Backpack",
                    Price = 1.00m,
                    Description = "Grey and blackpack with multiple outer compartments",
                    Image = "https://images.unsplash.com/photo-1509762774605-f07235a08f1f?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                },
                new Product
                {
                    ID = 2,
                    SKU = "abc-2",
                    Name = "Leather Duffle",
                    Price = 2.00m,
                    Description = "Brown leather duffle bag",
                    Image = "https://images.unsplash.com/photo-1525103504173-8dc1582c7430?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1053&q=80"
                },
                new Product
                {
                    ID = 3,
                    SKU = "abc-3",
                    Name = "Tan Duffle",
                    Price = 3.00m,
                    Description = "Tan waterproof duffle bag with removable shoulder strap",
                    Image = "https://images.unsplash.com/photo-1448582649076-3981753123b5?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80"
                },
                new Product
                {
                    ID = 4,
                    SKU = "abc-4",
                    Name = "Unsplash Backpack",
                    Price = 1.00m,
                    Description = "Water-proof black backpack with adjustable straps",
                    Image = "https://images.unsplash.com/photo-1505308144658-03c69861061a?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80"
                },
                new Product
                {
                    ID = 5,
                    SKU = "abc-5",
                    Name = "Burgundy Convertible Bag",
                    Price = 2.00m,
                    Description = "Convertible carrier bag also can be used as a roller suitcase",
                    Image = "https://images.unsplash.com/photo-1515935480894-3bab89cf8e89?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80"
                },
                new Product
                {
                    ID = 6,
                    SKU = "abc-6",
                    Name = "laptop Bag",
                    Price = 1.00m,
                    Description = "Camel-colored leather laptop bag",
                    Image = "https://images.unsplash.com/photo-1473445361085-b9a07f55608b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1084&q=80"
                },
                new Product
                {
                    ID = 7,
                    SKU = "abc-7",
                    Name = "Vintage Maleta",
                    Price = 3.00m,
                    Description = "Vintae suitcase with metal buckles",
                    Image = "https://images.unsplash.com/photo-1515622472995-1a06094d2224?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=800&q=80"
                },
                new Product
                {
                    ID = 8,
                    SKU = "abc-8",
                    Name = "Tote",
                    Price = 2.00m,
                    Description = "women's brown and red leather tote bag",
                    Image = "https://images.unsplash.com/photo-1525708570275-58d59ffe4a93?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1050&q=80"
                },
                new Product
                {
                    ID = 9,
                    SKU = "abc-9",
                    Name = "Sling Bag",
                    Price = 3.00m,
                    Description = "Roud woven brown sling bag",
                    Image = "https://images.unsplash.com/photo-1527430203327-e97f64c96a2c?ixlib=rb-1.2.1&auto=format&fit=crop&w=1050&q=80"
                },
                new Product
                {
                    ID = 10,
                    SKU = "abc-10",
                    Name = "Elephant Bag",
                    Price = 1.00m,
                    Description = "Woven tote bag with red embroidered elephant",
                    Image = "https://images.unsplash.com/photo-1494578151111-d35ec4c84e2b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1052&q=80"
                }
                );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
