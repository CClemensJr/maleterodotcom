using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartManager
    {
        // Create a new cart
        Task AddToCart(ShoppingCart cart);

        // Get a cart
        Task<ShoppingCartItem> GetACart(int id);

        // Get all carts
        Task<IEnumerable<ShoppingCartItem>> GetAllCarts();

        // Update a ShoppingCart
        Task UpdateCart(ShoppingCart cart);

        // Delete a ShoppingCart
        Task DeleteCart(int id);
    }
}
