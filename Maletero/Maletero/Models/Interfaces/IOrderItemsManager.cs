using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public class IOrderItemsManager
    {
        // Get a order item
        Task<ShoppingCart> GetOrderItem(string userName);

        // Get all order items
        Task<IEnumerable<ShoppingCart>> GetAllOrderItems();
    }
}
