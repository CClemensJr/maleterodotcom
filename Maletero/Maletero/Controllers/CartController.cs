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
        private readonly IShoppingCartManager _cart;
        private readonly IShoppingCartItemManager _cartItem;
    }
}
