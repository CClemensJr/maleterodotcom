using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IOrderManager 
    {
      
        // Get an order
        Task<Order> GetOrder(string userName);

        // Get all orders
        Task<IEnumerable<Order>> GetAllOrders();

    }
}
