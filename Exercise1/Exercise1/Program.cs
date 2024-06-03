using Exercise1.Models;

namespace Exercise1
{
    public class Program
    {
        static void Main(string[] args)
        {


            List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Price = 999.99m },
                new Product { Id = 2, Name = "Mouse", Price = 25.50m },
                new Product { Id = 3, Name = "Keyboard", Price = 49.99m },
                new Product { Id = 4, Name = "Monitor", Price = 150.00m },
                new Product { Id = 5, Name = "USB Cable", Price = 5.99m },
                new Product { Id = 6, Name = "External Hard Drive", Price = 89.99m },
                new Product { Id = 7, Name = "Webcam", Price = 45.00m },
                new Product { Id = 8, Name = "Desk Lamp", Price = 30.00m },
                new Product { Id = 9, Name = "Headphones", Price = 70.00m },
                new Product { Id = 10, Name = "Microphone", Price = 120.00m }
            };

            List<Product> productsWithPrice20 = products
                .Where(product => product.Price > 20)
                .ToList();

            Product productHighestPrice = products
                .OrderByDescending(product => product.Price)
                .FirstOrDefault();

            List<Product> orderedListByName = products
                .OrderBy(product => product.Name)
                .ToList();
            //
            Console.WriteLine("The products with prices higher then 20:");
            foreach (Product item in productsWithPrice20)
            {
                Console.WriteLine($"Name of product: { item.Name}, Price : {item.Price}");
            }
            //
        
                Console.WriteLine($"Name of product with highest price is  {productHighestPrice.Name}, Price : {productHighestPrice.Price}");

            //
            Console.WriteLine("Products ordered by name:");
            foreach (Product item in orderedListByName)
            {
                Console.WriteLine($"Name of product: {item.Name}, Price : {item.Price}");
            }
        }
    }
}
