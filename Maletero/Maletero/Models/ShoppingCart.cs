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

        /// <summary>
        /// This method takes an object and a quantity and either adds the object to the cart or increases the number objects in the cart.
        /// </summary>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public void AddProduct(Product product, int quantity)
        {
            ShoppingCartItem cartItem = ShoppingCartItems
                .Where(p => p.Product.ID == product.ID)
                .FirstOrDefault();

            if (cartItem == null)
            {
                ShoppingCartItems.Add(new ShoppingCartItem(ID, product, quantity));
            }
            else
            {
                cartItem.Quantity += quantity;
            }
        }

        /// <summary>
        /// This method takes an shopping cart item and removes it from the cart
        /// </summary>
        /// <param name="product"></param>
        public void RemoveFromCart(Product product)
        {
            ShoppingCartItems.RemoveAll(sci => sci.Product.ID == product.ID);
        }
    }
}
