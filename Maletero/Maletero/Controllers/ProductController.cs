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

        public ProductController(IInventory context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}