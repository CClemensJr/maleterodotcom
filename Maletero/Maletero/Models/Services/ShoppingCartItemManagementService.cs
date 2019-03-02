using Maletero.Data;
using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ShoppingCartItemManagementService : IShoppingCartItemManager
    {
        private MaleteroDbContext _table { get; }

        /// <summary>
        /// This custom constructor assigns a dbcontext to the property.
        /// </summary>
        /// <param name="cartItem"></param>
        public ShoppingCartItemManagementService(MaleteroDbContext cartItem)
        {
            _table = cartItem;
        }

        /// <summary>
        /// This method takes an object and Adds it to the table.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>An empty Task object</returns>
        public async Task CreateCartItem(ShoppingCartItem item)
        {
            _table.ShoppingCartItems.Add(item);

            await _table.SaveChangesAsync();
        }

        /// <summary>
        /// This method takes an id then deletes an object with the same ID from the table if it exists.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An empty Task object</returns>
        public async Task DeleteCartItem(int id)
        {
            ShoppingCartItem item = await _table.ShoppingCartItems.FindAsync(id);

            if (item != null)
            {
                _table.Remove(item);
            }

            await _table.SaveChangesAsync();
        }

        public Task<IEnumerable<ShoppingCartItem>> GetAllCartItems()
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCartItem> GetCartItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCartItem(ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
