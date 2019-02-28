using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartItemManager
    {
        // Create a new cartitem
        Task CreateCartItem(ShoppingCartItem item);

        // Get a cart
        Task<ShoppingCartItem> GetCartItem(int id);

        // Get all carts
        Task<IEnumerable<ShoppingCartItem>> GetAllCartItems();

        // Update a ShoppingCart
        Task UpdateCartItem(ShoppingCartItem item);

        // Delete a ShoppingCart
        Task DeleteCartItem(int id);
    }
}
