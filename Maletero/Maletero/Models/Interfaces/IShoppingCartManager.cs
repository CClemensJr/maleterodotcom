using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartManager
    {
        // Create a new cart
        Task CreateCartItem(ShoppingCartItem item);

        // Get a cart
        Task<ShoppingCartItem> GetCartItem(int id);

        // Get all carts
        Task<IEnumerable<ShoppingCartItem>> GetAllCartItems();

        // Update a ShoppingCart
        Task UpdateCart(ShoppingCartItem cartItem);

        // Delete a ShoppingCart
        Task DeleteCart(int id);
    }
}
