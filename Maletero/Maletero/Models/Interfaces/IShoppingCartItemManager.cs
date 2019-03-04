using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartItemManager
    {
        // Get a cart
        Task<ShoppingCartItem> GetCartItem(int id);

        // Get all carts items
        Task<IEnumerable<ShoppingCartItem>> GetAllCartItems();

        // Create or save a ShoppingCartItem
        Task SaveCartItem(ShoppingCartItem item);

        // Delete a ShoppingCart item
        Task DeleteCartItem(int id);

        //add method for to find all cart items for a specific cart
        Task<IEnumerable<ShoppingCartItem>> GetItemsForSpecificCart(int cartId);
    }
}
