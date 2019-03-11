using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;

        /// <summary>
        /// This custom constructor is used to bring in the shoppingcart interfaces
        /// </summary>
        /// <param name="cart"></param>
        /// <param name="cartItem"></param>
        public CartController(IInventory inventory, IShoppingCartManager cart, IShoppingCartItemManager cartItem, IConfiguration configuration)
        {
            _inventory = inventory;
            _cart = cart;
            _cartItem = cartItem;
            _configuration = configuration;
        }

        /// <summary>
        /// This method returns all items in the cart of a logged in user
        /// </summary>
        /// <returns>A View with a bunch of cart items</returns>
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _cartItem.GetAllCartItems());
        }

        [HttpPost]
        public IActionResult Index(bool works = true)
        {
            Payment payment = new Payment(_configuration);
            string answer = payment.Run();

            if (answer == "Ok")
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
