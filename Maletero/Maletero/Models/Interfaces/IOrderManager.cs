using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IOrderManager 
    {
        //create an order
        Task CreateOrder(Order order);
      
        // Get an order
        Task<Order> GetOrder(int id);

        // Get all orders
        Task<IEnumerable<Order>> GetAllOrders();
    }
}
