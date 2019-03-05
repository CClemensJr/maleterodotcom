using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class Payment
    {
        private IConfiguration _configuration;
        
        public Payment(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string Run()
        {
            return "YAY!";
        }
    }
}
