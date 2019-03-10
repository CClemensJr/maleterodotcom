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

        public async Task DeleteAsync(int id)
        {
            //check to see if the post exists in the db
            Product product = await _context.Products.FindAsync(id);

            if (product != null)
            {
                _context.Remove(product);
                //remove and save the changes
                await _context.SaveChangesAsync();
            }
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
        /// <param name="id">product id</param>
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

        public async Task SaveAsync(Product product)
        {
            //look for the post in the db
            if (await _context.Products.FirstOrDefaultAsync(p => p.ID == product.ID) == null)
            {
                //if it doesn't exist, add it
                _context.Products.Add(product);
            }
            else
            {
                //update the db with a new post
                _context.Products.Update(product);
            }
            //save changes to the db
            await _context.SaveChangesAsync();
        }
    }
}
