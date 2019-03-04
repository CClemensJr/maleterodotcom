using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartManager
    {
        // Create or update a cart
        Task SaveCart(ShoppingCart cart);

        // Get a cart
        Task<ShoppingCart> GetCart(string userEmail);

        // Get all carts
        Task<IEnumerable<ShoppingCart>> GetAllCarts();

        // Delete a ShoppingCart
        Task DeleteCart(int id);
    }
}
