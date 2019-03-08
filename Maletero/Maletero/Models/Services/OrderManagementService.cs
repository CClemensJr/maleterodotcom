using Maletero.Data;
using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class OrderManagementService: IOrderManager
    {
        private MaleteroDbContext __table { get; }

        /// <summary>
        /// This custom constructor assigns a dbcontext to the property.
        /// </summary>
        /// <param name="order"></param>
        public OrderManagementService(MaleteroDbContext order)
        {
            __table = order;
        }

        /// <summary>
        /// This method takes an id and returns the cart object with that ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>An order object</returns>
        public async Task<Order> GetOrder(string userName)
        {
            return await __table.Orders.FirstOrDefaultAsync(o => o.UserID == userName);
        }

        /// <summary>
        /// This method returns all carts in the table
        /// </summary>
        /// <returns>A list of ShoppingCart objects</returns>
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await __table.Orders.ToListAsync();
        }
    }
}
