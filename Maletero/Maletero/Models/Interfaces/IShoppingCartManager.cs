﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Interfaces
{
    public interface IShoppingCartManager
    {
        // Add a ShoppingCartItem to ShoppingCart
        Task AddToCart(ShoppingCartItem item);

        // Get a ShoppingCartItem from the ShoppingCart

        // Get all of the ShoppingCartItems from the ShoppingCart


        // Update a ShoppingCart

        // Delete a ShoppingCartItem 

    }
}
