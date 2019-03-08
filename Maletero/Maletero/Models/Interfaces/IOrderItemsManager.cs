using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IOrderItemsManager
    {
        // Get a order item
        Task<Order> GetOrderItem(string userName);

        // Get all order items
        Task<IEnumerable<Order>> GetAllOrderItems();
    }
}
