using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("ShoppingCart")]
        public int ShoppingCartID { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }
    }
}
