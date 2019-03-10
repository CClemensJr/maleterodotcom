using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Models;
using Maletero.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maletero.Pages.Admin
{
    public class IndexModel : PageModel
    {
        private readonly IInventory _product;

        public IndexModel(IInventory product)
        {
            _product = product;
        }
        [FromRoute]
        //id is captured in the route
        public int ID { get; set; }

        public IEnumerable<Product> Product { get; set; }

        public async Task OnGet()
        {
            Product = await _product.GetAll();
        }
    }
}