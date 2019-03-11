using Maletero.Models;
using Maletero.Models.Interfaces;
using Maletero.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    public class OrderController: Controller
    {
        private readonly IOrderManager _order;
        //private readonly IShoppingCartManager _shoppingCart;

        /// <summary>
        /// This method constructs an order
        /// </summary>
        /// <param name="order">order from cart</param>
        public OrderController(IOrderManager order)
        {
            _order = order;
            //_shoppingCart = shoppingCart;
        }

        /// <summary>
        /// This method calls for a cart checkout
        /// </summary>
        /// <returns>Checkout view page</returns>
        public IActionResult Checkout()
        {
            return View();
        }
    }
}
