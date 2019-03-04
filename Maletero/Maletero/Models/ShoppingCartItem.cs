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

        //[ForeignKey("Product")]
        [Required]
        public Product Product { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShoppingCartItem() {}

        /// <summary>
        /// This is a custom constructor that allows properties to be set upon instantiation
        /// </summary>
        /// <param name="cartID"></param>
        /// <param name="product"></param>
        /// <param name="quantity"></param>
        public ShoppingCartItem(int cartID, Product product, int quantity)
        {
            ShoppingCartID = cartID;
            Product = product;
            Quantity = quantity;
            ProductID = Product.ID;
        }
    }
}
