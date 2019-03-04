using Maletero.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Components
{
    public class UserCartItems : ViewComponent
    {
        //may need to change to different db for user cart
        private MaleteroDbContext _context;

        public UserCartItems(MaleteroDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var items = _context.Products.OrderByDescending(p => p.ID).Take(number).ToList();
            return View(items);
        }
    }
}
