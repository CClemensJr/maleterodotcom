using Maletero.Data;
using Maletero.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ProductManagement : IInventory
    {
        //connect db to service

        private MaleteroDbContext _context { get; }

        //constructor
        public ProductManagement(MaleteroDbContext context)
        {
            _context = context;
        }

        Task IInventory.CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Task IInventory.DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<Product>> IInventory.GetAll()
        {
            throw new NotImplementedException();
        }

        Task<Product> IInventory.GetbyID(int? id)
        {
            throw new NotImplementedException();
        }

        bool IInventory.ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        Task IInventory.UpdateProduct(Product id)
        {
            throw new NotImplementedException();
        }
    }
}
