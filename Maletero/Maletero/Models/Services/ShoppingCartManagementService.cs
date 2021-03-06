﻿using Maletero.Data;
using Maletero.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Services
{
    public class ShoppingCartManagementService : IShoppingCartManager
    {
        private MaleteroDbContext __table { get; }

        /// <summary>
        /// This custom constructor assigns a dbcontext to the property.
        /// </summary>
        /// <param name="cart">cart object</param>
        public ShoppingCartManagementService(MaleteroDbContext cart)
        {
            __table = cart;
        }

        /// <summary>
        /// This method takes an id and deletes the cart from if it exhists.
        /// </summary>
        /// <param name="id">cart id</param>
        /// <returns>A Task object</returns>
        public async Task DeleteCart(int id)
        {
            ShoppingCart cart = await __table.ShoppingCarts.FindAsync(id);

            if (cart != null)
            {
                __table.Remove(cart);
            }

            await __table.SaveChangesAsync();
        }

        /// <summary>
        /// This method takes an id and returns the cart object with that ID
        /// </summary>
        /// <param name="userName">user's email</param>
        /// <returns>A Cart object</returns>
        public async Task<ShoppingCart> GetCart(string userName)
        {
            var cart = await __table.ShoppingCarts.FirstOrDefaultAsync(sc => sc.UserID == userName);
            return cart;
        }

        /// <summary>
        /// This method returns all carts in the table
        /// </summary>
        /// <returns>A list of ShoppingCart objects</returns>
        public async Task<IEnumerable<ShoppingCart>> GetAllCarts()
        {
            return await __table.ShoppingCarts.ToListAsync();
        }

        /// <summary>
        /// This method takes a cart object and updates it in the database
        /// </summary>
        /// <param name="cart">cart object</param>
        /// <returns>A Task object</returns>
        public async Task SaveCart(ShoppingCart cart)
        {
            if (await __table.ShoppingCarts.FirstOrDefaultAsync(sc => sc.ID == cart.ID) != null)
            {
                __table.ShoppingCarts.Update(cart);
            }
            else
            {
                __table.ShoppingCarts.Add(cart);
            }

            await __table.SaveChangesAsync();
        }
    }
}
