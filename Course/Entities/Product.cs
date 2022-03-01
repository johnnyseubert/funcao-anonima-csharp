using System.Globalization;

namespace Course.Entities
{
    public class Product
    {
        //properties
        public string Name { get; set; }
        public double Price { get; set; }
        //constructor
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name}, {Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}