using Maletero.Data;
using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ShoppingCartManagementService : IShoppingCartManager
    {
        private MaleteroDbContext __table { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public async Task AddToCart(ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCartItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ShoppingCartItem> GetACartItem(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ShoppingCartItem>> GetAllCartItems()
        {
            throw new NotImplementedException();
        }

        public Task UpdateCartItems(ShoppingCartItem item)
        {
            throw new NotImplementedException();
        }
    }
}
