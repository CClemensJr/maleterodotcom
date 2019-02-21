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

        
    }
}
