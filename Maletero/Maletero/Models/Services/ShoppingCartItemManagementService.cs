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

        public Task CreateCartItem(ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartItem(int id)
        {
            throw new NotImplementedException();
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
