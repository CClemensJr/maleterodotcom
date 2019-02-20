using Maletero.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}
