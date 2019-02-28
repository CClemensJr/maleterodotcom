using Maletero.Data;
using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ShoppingCartManagementService : IShoppingCartManager
    {
        private MaleteroDbContext __table { get; }

        /// <summary>
        /// This custom constructor assigns a dbcontext to the property.
        /// </summary>
        /// <param name="cart"></param>
        public ShoppingCartManagementService(MaleteroDbContext cart)
        {
            __table = cart;
        }

        /// <summary>
        /// This method takes an item and add to cart
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task CreateCart(ShoppingCart cart)
        {
            __table.ShoppingCarts.Add(cart);

            await __table.SaveChangesAsync();
        }

        public Task DeleteCartItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCartItem> GetACartItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShoppingCartItem>> GetAllCartItems()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCartItems(ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
