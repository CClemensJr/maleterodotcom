using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Maletero.Pages.Profile
{
    public class IndexModel : PageModel
    {
        private UserManager<ApplicationUser> _userManager;

        public void OnGet()
        {
        }
    }
}