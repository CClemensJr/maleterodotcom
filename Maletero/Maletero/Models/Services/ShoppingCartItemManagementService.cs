using Maletero.Data;
using Maletero.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        /// <summary>
        /// This method returns a list of all of the items in the table
        /// </summary>
        /// <returns>A Task with a collection of shopping cart items</returns>
        public async Task<IEnumerable<ShoppingCartItem>> GetAllCartItems()
        {
            return await _table.ShoppingCartItems.ToListAsync();
        }

        /// <summary>
        /// This method takes an ID and returns the object with that ID from the table.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Task object containing a ShoppingCartItem</returns>
        public async Task<ShoppingCartItem> GetCartItem(int id)
        {
            return await _table.ShoppingCartItems.FindAsync(id);
        }

        /// <summary>
        /// This method takes an item and updates the item in the db if it exists.
        /// </summary>
        /// <param name="item"></param>
        /// <returns>An empty Task object</returns>
        public async Task SaveCartItem(ShoppingCartItem item)
        {
            if (await _table.ShoppingCartItems.FirstOrDefaultAsync(sci => sci.ID == item.ID) != null)
            {
                _table.ShoppingCartItems.Update(item);
            }
            else
            {
                _table.ShoppingCartItems.Add(item);
            }

            await _table.SaveChangesAsync();
        }
    }
}
