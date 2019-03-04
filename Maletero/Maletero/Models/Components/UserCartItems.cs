using Maletero.Data;
using Maletero.Models.Interfaces;
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

        public UserCartItems(IShoppingCartManager shoppingCartManager, IShoppingCartItemManager shoppingCartItemManager )
        {
            _shoppingCartItemManager = shoppingCartItemManager;
            _shoppingCartManager = shoppingCartManager;
        }

        public async Task<IViewComponentResult> InvokeAsync(string userName)
        {
            var cart = await _shoppingCartManager.GetCart(userName);
            var items = await _shoppingCartItemManager.GetItemsForSpecificCart(cart.ID);
            return View(items);
        }
    }
}
