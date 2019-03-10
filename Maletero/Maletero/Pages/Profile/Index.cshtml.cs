using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maletero.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maletero.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;

        public IndexModel (UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
          

        public void OnGet()
        {
        }
    }
}