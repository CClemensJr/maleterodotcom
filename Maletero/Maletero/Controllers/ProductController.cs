using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Maletero.Controllers
{
    public class ProductController : Controller
    {
        private readonly IInventory _context;

        /// <summary>
        /// This custom constructor brings in the db
        /// </summary>
        /// <param name="context"></param>
        public ProductController(IInventory context)
        {
            _context = context;
        }

        /// <summary>
        /// This action returns the index view
        /// </summary>
        /// <returns>A View</returns> 
        public IActionResult Index()
        {
            return View();
        }
    }
}