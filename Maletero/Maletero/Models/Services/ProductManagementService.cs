using Maletero.Data;
using Maletero.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        Task DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// This interface method gathers all of the objects in the table and returns them in a list
        /// </summary>
        /// <returns>A list of objects</returns>
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> GetbyID(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        Task UpdateProduct(Product id)
        {
            throw new NotImplementedException();
        }
    }
}
