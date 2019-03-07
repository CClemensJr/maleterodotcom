using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Components
{
    public class CreditCardDropDownViewComponent : ViewComponent
    {
        public string CreditCardProvider { get; set; }

        public List<SelectListItem> CreditCardProviders { get; } = new List<SelectListItem>
        {
            new SelectListItem { Value = "AMEX", Text = "American Express" },
            new SelectListItem { Value = "DC", Text = "Discover Card" },
            new SelectListItem { Value = "MC", Text = "MasterCard"  },
            new SelectListItem { Value = "VI", Text = "Visa"}
        };

        public async Task<IViewComponentResult> InvokeAsync(string creditCard)
        {
            var creditCardNumber = await GetCreditCardAsync(creditCard);

            return View(CreditCardProviders);
        }

        public async Task<CreditCardNumbers> GetCreditCardAsync(string creditCard)
        {
            return CreditCardNumbers.AmericanExpress;
        }

        //public enum CreditCardProviders
        //{
        //    [Display(Name = "American Express")]
        //    AMEX,
        //    [Display(Name = "Discover Card")]
        //    Discover,
        //    MasterCard,
        //    Visa
        //}

        public enum CreditCardNumbers:long
        {
            AmericanExpress = 370000000000002,
            Discover = 6011000000000012,
            Visa = 4007000000027,
            Mastercard = 5424000000000015
        }
    }
}
