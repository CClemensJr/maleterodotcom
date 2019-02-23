using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
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
        /// This method renders the view page when the index route is hit.
        /// </summary>
        /// <returns>A View</returns>
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
