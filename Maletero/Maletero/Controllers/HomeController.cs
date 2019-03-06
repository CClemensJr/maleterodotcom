using Maletero.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Controllers
{
    /// <summary>
    /// This action returns the view index
    /// </summary>
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bool works = true)
        {
            Payment payment = new Payment(_configuration);
            string answer = payment.Run();

            if (answer == "Ok")
            {
                return View();
            }
            else
            {
                return View();
            }
        }
    }
}
