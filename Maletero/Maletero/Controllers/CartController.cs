using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    public class CartController : Controller 
    {
        private readonly IInventory _inventory;
        private readonly IShoppingCartManager _cart;
        private readonly IShoppingCartItemManager _cartItem;

        /// <summary>
        /// This custom constructor is used to bring in the shoppingcart interfaces
        /// </summary>
        /// <param name="cart">shopping cart</param>
        /// <param name="cartItem">shopping cart item</param>
        public CartController(IInventory inventory, IShoppingCartManager cart, IShoppingCartItemManager cartItem)
        {
            _inventory = inventory;
            _cart = cart;
            _cartItem = cartItem;
        }
    }
}
