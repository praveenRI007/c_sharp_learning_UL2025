// This file demonstrates the concept: Sorting a list of complex types using Comparison delegate
namespace Topics.Collections
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class SortComplexTypesWithComparison
    {
        public void Demo()
        {
            var products = new List<Product>
            {
                new Product { Name = "Pen", Price = 1.5 },
                new Product { Name = "Book", Price = 10.0 },
                new Product { Name = "Pencil", Price = 0.5 }
            };
            // Sort by Price using Comparison delegate
            products.Sort((a, b) => a.Price.CompareTo(b.Price));
            foreach (var p in products)
            {
                System.Console.WriteLine($"{p.Name}: {p.Price}"); // Output: Pencil, Pen, Book
            }
        }
    }
}
