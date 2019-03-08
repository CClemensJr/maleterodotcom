using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    public class CheckoutController: Controller
    {
        private readonly ShoppingCart _shoppingCart;
        private readonly IShoppingCartManager _shoppingCartManager;
        private readonly IShoppingCartItemManager _shoppingCartItemManager;

        public CheckoutController(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;

        }

      

        public IActionResult Receipt()
        {
            return View();
        }
    }
}
