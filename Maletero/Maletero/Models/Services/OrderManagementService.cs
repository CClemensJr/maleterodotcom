using Maletero.Data;
using Maletero.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class OrderManagementService: IOrderManager
    {
        private MaleteroDbContext _table { get; }

        /// <summary>
        /// This custom constructor assigns a dbcontext to the property.
        /// </summary>
        /// <param name="order">cart order data</param>
        public OrderManagementService(MaleteroDbContext order)
        {
            _table = order;
        }

        /// <summary>
        /// This method takes an id and returns the cart object with that ID
        /// </summary>
        /// <param name="id">order id</param>
        /// <returns>An order object</returns>
        public async Task<Order> GetOrder(int id)
        {
            return await _table.Orders.FirstOrDefaultAsync(o => o.ID == id);
        }

        /// <summary>
        /// This method returns all carts in the table
        /// </summary>
        /// <returns>A list of ShoppingCart objects</returns>
        public async Task<IEnumerable<Order>> GetAllOrders()
        {
            return await _table.Orders.ToListAsync();
        }

        /// <summary>
        /// This method creates a new order
        /// </summary>
        /// <param name="order">order object</param>
        /// <returns></returns>
        public Task CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
