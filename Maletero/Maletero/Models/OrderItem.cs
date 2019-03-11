using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class OrderItem
    {
        [Key]
        public int ID { get; set; }

        [ForeignKey("Order")]
        public int OrderID { get; set; }

        [ForeignKey("Product")]
        [Required]
        public Product Product { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public OrderItem() { }

        /// <summary>
        /// This is a custom constructor that allows properties to be set upon instantiation
        /// </summary>
        /// <param name="orderID">order id</param>
        /// <param name="product">product object</param>
        /// <param name="quantity">quantity of items</param>
        public OrderItem(int orderID, Product product, int quantity)
        {
            OrderID = orderID;
            Product = product;
            Quantity = quantity;
            ProductID = Product.ID;
        }
    }
}
