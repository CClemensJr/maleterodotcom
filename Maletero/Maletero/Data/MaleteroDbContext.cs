using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Maletero.Data
{
    public class MaleteroDbContext :DbContext 
    {
        public MaleteroDbContext(DbContextOptions<MaleteroDbContext> options) : base(options)
        {

        }
    }
}
