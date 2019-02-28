using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartManager
    {
        // Add a ShoppingCartItem to ShoppingCart
        Task AddToCart(ShoppingCart cart);

        // Get a ShoppingCartItem from the ShoppingCart
        Task<ShoppingCartItem> GetACart(int id);

        // Get all of the ShoppingCartItems from the ShoppingCart
        Task<IEnumerable<ShoppingCartItem>> GetAllCarts();

        // Update a ShoppingCart
        Task UpdateCart(ShoppingCart cart);

        // Delete a ShoppingCartItem 
        Task DeleteCart(int id);
    }
}
