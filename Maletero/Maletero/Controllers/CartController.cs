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
        /// <param name="cart"></param>
        /// <param name="cartItem"></param>
        public CartController(IInventory inventory, IShoppingCartManager cart, IShoppingCartItemManager cartItem)
        {
            _inventory = inventory;
            _cart = cart;
            _cartItem = cartItem;
        }

        [HttpPost]
        public async Task<RedirectToActionResult> AddToCart(int id)
        {
            Product product = await _inventory.GetbyID(id);

            if (product != null)
            {
                ShoppingCart shoppingCart = new ShoppingCart();

                shoppingCart.ID = Convert.ToInt32(DateTime.Now);
                shoppingCart.UserID = "test@test.com";

                shoppingCart.AddProduct(product, 1);

                await _cart.UpdateCart(shoppingCart);
            }

            return RedirectToAction("/Shop/Index");

        }
    }
}
