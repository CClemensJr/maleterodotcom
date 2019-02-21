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

        
    }
}
