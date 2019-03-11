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

        /// <summary>
        /// This method brings in the user manager and shopping cart manager to construct view component
        /// </summary>
        /// <param name="shoppingCartManager">user shopping cart</param>
        /// <param name="shoppingCartItemManager">items inside cart</param>
        /// <param name="userManager">user identity</param>
        public UserCartItems(IShoppingCartManager shoppingCartManager, IShoppingCartItemManager shoppingCartItemManager, UserManager<ApplicationUser> userManager)
        {
            _shoppingCartItemManager = shoppingCartItemManager;
            _shoppingCartManager = shoppingCartManager;
            _userManager = userManager;
        }

        /// <summary>
        /// This method invokes shopping cart view component
        /// </summary>
        /// <param name="userName"></param>
        /// <returns>a component view of all items</returns>
        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            //var user = await _userManager.FindByEmailAsync(userName);
            //string userID = user.Id;
            var cart = await _shoppingCartManager.GetCart(userName);
            var items = await _shoppingCartItemManager.GetItemsForSpecificCart(cart.ID);
            return View(items);
        }
    }
}