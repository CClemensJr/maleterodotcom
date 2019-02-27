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

        public async Task CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteProduct(int id)
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

        /// <summary>
        /// THis method finds an object in the db with the associated ID and returns it
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A Product object</returns>
        public async Task<Product> GetbyID(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public bool ProductExists(int id)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateProduct(Product id)
        {
            throw new NotImplementedException();
        }
    }
}
