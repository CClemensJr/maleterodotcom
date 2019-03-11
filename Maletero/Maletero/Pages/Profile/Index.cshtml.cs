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

        public ApplicationUser ApplicationUser { get; set; }

        /// <summary>
        /// This constructor used dependency injection to bring in the UserManager identity class
        /// </summary>
        /// <param name="userManager"></param>
        public IndexModel (UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        /// <summary>
        /// This method runs on page load
        /// </summary>
        public async Task OnGet()
        {
            ApplicationUser = await _userManager.GetUserAsync(User);
        }
    }
}