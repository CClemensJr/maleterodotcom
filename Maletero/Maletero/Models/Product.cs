namespace Maletero.Models.Interfaces
{
    public class Product
    {
        public int ID { get; set; }

        public string SKU { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }
    }
}