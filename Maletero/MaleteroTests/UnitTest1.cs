using Maletero.Models;
using Maletero.Models.Interfaces;
using System;
using Xunit;

namespace MaleteroTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanGetProductID()
        {
            Product product = new Product();
            product.ID = 1;
            Assert.Equal(1, product.ID);
        }

        [Fact]
        public void CanSetProductID()
        {
            Product product = new Product();
            product.ID = 1;
            product.ID = 2;
            Assert.Equal(2, product.ID);
        }

        [Fact]
        public void CanGetProductSKU()
        {
            Product product = new Product();
            product.SKU = "abc-123";
            Assert.Equal("abc-123", product.SKU);
        }

        [Fact]
        public void CanSetProductSKU()
        {
            Product product = new Product();
            product.SKU = "abc-123";
            product.SKU = "abc-456";
            Assert.Equal("abc-456", product.SKU);
        }

        [Fact]
        public void CanGetProductName()
        {
            Product product = new Product();
            product.Name = "backpack";
            Assert.Equal("backpack", product.Name);
        }

        [Fact]
        public void CanSetProductName()
        {
            Product product = new Product();
            product.Name = "backpack";
            product.Name = "duffle bag";
            Assert.Equal("duffle bag", product.Name);
        }

        [Fact]
        public void CanGetProductPrice()
        {
            Product product = new Product();
            product.Price = 100.00m;
            Assert.Equal(100.00m, product.Price);
        }

        [Fact]
        public void CanSetProductPrice()
        {
            Product product = new Product();
            product.Price = 100.00m;
            product.Price = 200.00m;
            Assert.Equal(200.00m, product.Price);

        }

        [Fact]
        public void CanGetProductDescription()
        {
            Product product = new Product();
            product.Description = "productonedescription";
            Assert.Equal("productonedescription", product.Description);
        }

        [Fact]
        public void CanSetProductDescription()
        {
            Product product = new Product();
            product.Description = "productonedescription";
            product.Description = "productonedescriptionchanged";
            Assert.Equal("productonedescriptionchanged", product.Description);
        }

        [Fact]
        public void CanGetProductImage()
        {
            Product product = new Product();
            product.Image = "https://via.placeholder.com/150";
            Assert.Equal("https://via.placeholder.com/150", product.Image);
        }

        [Fact]
        public void CanSetProductImage()
        {
            Product product = new Product();
            product.Image = "https://via.placeholder.com/200";
            product.Image = "https://via.placeholder.com/200";
            Assert.Equal("https://via.placeholder.com/200", product.Image);
        }
    }
}
