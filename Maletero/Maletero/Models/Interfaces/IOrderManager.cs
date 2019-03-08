using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public class IOrderManager
    {
      
        // Get an order
        Task<ShoppingCart> GetOrder(string userName);

        // Get all orders
        Task<IEnumerable<Order>> GetAllOrders();

    }
}
