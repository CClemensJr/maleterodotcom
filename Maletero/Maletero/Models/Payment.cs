using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
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
                name = "98h6p9uLRKbp",
                ItemElementName = ItemChoiceType.transactionKey,
                Item = "6vad94bCh44E3hLq"
            };

            //bring in credit card
            var creditCard = new creditCardType
            {
                cardNumber = "4111111111111111",
                expirationDate = "1020"
            };

            customerAddressType billingAddress = GetAddress();

            //accept credit cards as the payment type
            paymentType paymentType = new paymentType { Item = creditCard };

            //consolidate all transaction info before sending to auth.net with the following parameters
            transactionRequestType transactionRequest = new transactionRequestType
            {
                transactionType = transactionTypeEnum.authCaptureTransaction.ToString(),
                amount = 1.00m,
                payment = paymentType,
                billTo = billingAddress,
                //lineItems = 
            };

            createTransactionRequest request = new createTransactionRequest
            {
                transactionRequest = transactionRequest
            };

            //call out to auth.net using request
            var controller = new createTransactionController(request);
           
            //execute controller call
            controller.Execute();

            var response = controller.GetApiResponse();

            if (response != null)
            {
                if (response.messages.resultCode == messageTypeEnum.Ok)
                {
                    if (response.transactionResponse != null)
                    {
                        return "Ok";
                    }
                }
                else
                {
                    return "Not Ok";
                }
            }

            return "Not Ok";
        }

        /// <summary>
        /// Bring in user profile by user id
        /// </summary>
        /// <returns>address</returns>
        private customerAddressType GetAddress()
        {
            //call out to user's profile info to complete address type

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

        private lineItemType[] GetLineItems(List<Product> products)
        {
            lineItemType[] lineitems = new lineItemType[products.Count];

            int count = 0;

            foreach(var p in products)
            {
                lineitems[count] = new lineItemType
                {
                    itemId = "1",
                    name = "productOne",
                    quantity = 1,
                    unitPrice = new Decimal(1.00)
                };
                count++;
            }
            return lineitems;
        }
    }
}
