using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ShoppingCartItemManagementService : IShoppingCartItemManager
    {
        private MaleteroDbcontext _table { get; }
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
