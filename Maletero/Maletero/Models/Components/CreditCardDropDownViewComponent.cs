using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models.Components
{
    public class CreditCardDropDownViewComponent : ViewComponent
    {
    }

    public enum CreditCardNumbers:long
    {
        AmericanExpress = 370000000000002,
        Discover = 6011000000000012,
        Visa = 4007000000027,
        Mastercard = 5424000000000015
    }
}
