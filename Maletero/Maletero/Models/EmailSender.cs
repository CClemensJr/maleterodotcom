using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
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

        /// <summary>
        /// Send email method brings in email, subject, and message parameters
        /// </summary>
        /// <param name="email">email</param>
        /// <param name="subject">email subject</param>
        /// <param name="htmlMessage">email message</param>
        /// <returns>client email</returns>
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //establish connection to sendgrid
            SendGridClient client = new SendGridClient(_configuration["Sendgrid_Api_Key"]);

            //load the message
            SendGridMessage msg = new SendGridMessage();

            msg.SetFrom("noreply@Maletero.com", "Maletero Admin");

            msg.AddTo(email);
            msg.SetSubject("Welcome to our Store!");
            msg.AddContent(MimeType.Html, htmlMessage);

            //send message
            await client.SendEmailAsync(msg);
        }
    }
}
