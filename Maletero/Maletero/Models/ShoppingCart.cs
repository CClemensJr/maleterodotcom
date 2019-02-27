using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string UserID { get; set; }

        public ICollection<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
