using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class EmailSender: IEmailSender
    {
        private IConfiguration _configuration;

        //dependency injection gives access to user secrets file
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
    }
}
