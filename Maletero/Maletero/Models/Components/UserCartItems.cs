using Maletero.Data;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Components
{
    public class UserCartItems : ViewComponent
    {
        private IShoppingCartItemManager _shoppingCartItemManager;
        private IShoppingCartManager _shoppingCartManager;
        private UserManager<ApplicationUser> _userManager;

        public UserCartItems(IShoppingCartManager shoppingCartManager, IShoppingCartItemManager shoppingCartItemManager, UserManager<ApplicationUser> userManager)
        {
            _shoppingCartItemManager = shoppingCartItemManager;
            _shoppingCartManager = shoppingCartManager;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            //var user = await _userManager.FindByEmailAsync(userName);
            //string userID = user.Id;
            var cart = await _shoppingCartManager.GetCart(userName);
            IEnumerable<ShoppingCartItem> items = await _shoppingCartItemManager.GetItemsForSpecificCart(cart.ID);
            return View(items);
        }
    }
}