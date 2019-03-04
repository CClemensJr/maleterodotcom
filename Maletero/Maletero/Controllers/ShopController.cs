using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private UserManager<ApplicationUser> _userManager;

        /// <summary>
        /// This custom constructor is used to bring in the Inventory interface
        /// </summary>
        /// <param name="inventory"></param>
        public ShopController(IInventory inventory, IShoppingCartManager shoppingCart, IShoppingCartItemManager shoppingCartItem, UserManager<ApplicationUser> userManager)
        {
            _inventory = inventory;
            _cart = shoppingCart;
            _cartItem = shoppingCartItem;
            _userManager = userManager;
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

        /// <summary>
        /// This method adds an item to the cart
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<RedirectToActionResult> AddToCart(int id)
        {
            Product product = await _inventory.GetbyID(id);

            if (product != null)
            {
                var user = await _userManager.GetUserAsync(User);
                var userName = user.UserName;

                ShoppingCart cart = await _cart.GetCart(userName);

                ShoppingCartItem cartItem = new ShoppingCartItem(cart.ID, product, 1);

                await _cartItem.SaveCartItem(cartItem);

                cart.ShoppingCartItems.Add(cartItem);

                await _cart.SaveCart(cart);
            }

            return RedirectToAction("Index");
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
