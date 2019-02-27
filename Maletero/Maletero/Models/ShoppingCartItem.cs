using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ID { get; set; }
    }
}
