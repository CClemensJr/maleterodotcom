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
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderManager order, ShoppingCart shoppingCart)
        {
            _order = order;
            _shoppingCart = shoppingCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
