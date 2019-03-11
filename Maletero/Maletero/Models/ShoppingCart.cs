using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Maletero.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string UserID { get; set; }

        [Required]
        public List<ShoppingCartItem> ShoppingCartItems { get; set; } = null;

        public ShoppingCart(string userID, List<ShoppingCartItem> shoppingCartItems)
        {
            UserID = UserID;
            ShoppingCartItems = shoppingCartItems;
        }

        public ShoppingCart()
        {
        }
    }
}
