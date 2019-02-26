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

        /// <summary>
        /// This custom constructor is used to bring in the Inventory interface
        /// </summary>
        /// <param name="inventory"></param>
        public ShopController(IInventory inventory)
        {
            _inventory = inventory;
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> View(int id)
        {
            return View(await _inventory.GetbyID(id));
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
