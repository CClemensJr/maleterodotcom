using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Maletero.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [EmailAddress]
        public string UserID { get; set; }

        [Required]
        public List<OrderItem> OrderItems { get; set; } = null;

    }
}
