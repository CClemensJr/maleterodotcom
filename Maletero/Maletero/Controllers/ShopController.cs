using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    [Authorize(Policy = "WashingtonStateOnly")]
    public class ShopController : Controller
    {
        private readonly IInventory _inventory;
        private readonly IShoppingCartManager _cart;
        private readonly IShoppingCartItemManager _cartItem;

        /// <summary>
        /// This custom constructor is used to bring in the Inventory interface
        /// </summary>
        /// <param name="inventory"></param>
        public ShopController(IInventory inventory, IShoppingCartManager cart, IShoppingCartItemManager cartItem)
        {
            _inventory = inventory;
            _cart = cart;
            _cartItem = cartItem;
        }

        /// <summary>
        /// This method renders the view page when the index route is hit while sending all of the table items with it.
        /// </summary>
        /// <returns>A View</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _inventory.GetAll());
        }

        /// <summary>
        /// This action takes an id and sends the user to the view page for that id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>A View</returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ShowBag(int id)
        {
            return View(await _inventory.GetbyID(id));
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<RedirectToActionResult> AddToCart(int id)
        {
            Product product = await _inventory.GetbyID(id);

            if (product != null)
            {
                ShoppingCart shoppingCart = new ShoppingCart();

                //shoppingCart.ID = Convert.ToInt32(DateTime.Now);
                shoppingCart.UserID = "test@test.com";

                shoppingCart.AddProduct(product, 1);

                await _cart.UpdateCart(shoppingCart);
            }

            return RedirectToAction("/Shop/Index");

        }

        /// <summary>
        /// This method renders the View for authorized logged in users
        /// </summary>
        /// <returns>A View</returns>
        [Authorize]
        public IActionResult SeahawkBags()
        {
            return View();
        }
    }
}
