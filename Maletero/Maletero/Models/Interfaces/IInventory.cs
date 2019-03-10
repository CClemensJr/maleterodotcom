using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IInventory
    {
        //create
        Task CreateProduct(Product product);

        //read

        Task<Product> GetbyID(int id);

        Task<IEnumerable<Product>> GetAll();

        //update

        Task UpdateProduct(Product id);

        //delete

        Task DeleteProduct(int id);

        bool ProductExists(int id);

        Task SaveAsync(Product product);
    }
}
