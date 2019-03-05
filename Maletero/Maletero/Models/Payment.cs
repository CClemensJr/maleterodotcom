using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Bases;
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
            //declare use of sandbox acct

            ApiOperationBase<ANetApiRequest, ANetApiResponse>.RunEnvironment = AuthorizeNet.Environment.SANDBOX;

            //define merchant info
            ApiOperationBase<ANetApiRequest, ANetApiResponse>.MerchantAuthentication = new merchantAuthenticationType()
            {
                name = _configuration["AuthNetAPILogin"],
                ItemElementName = ItemChoiceType.transactionKey,
                Item = _configuration["AuthNetTransactionKey"]
            };

            //bring in credit card
            var creditCard = new creditCardType
            {
                cardNumber = "4111111111111111",
                expirationDate = "1020"
            };

            customerAddressType billingAddress = GetAddress();

            return "YAY!";
        }

        private customerAddressType GetAddress()
        {
            customerAddressType address = new customerAddressType()
            {
                firstName = "Maletero",
                lastName = "Admin",
                address = "122 Code Fellows Ave",
                city = "Seattle",
                zip = "98121"
            };

            return address;
        }
    }
}
