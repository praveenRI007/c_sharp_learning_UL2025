// This file demonstrates the concept: Why override Equals()
namespace Topics.ObjectMethodsStringHandling
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Override Equals to compare object content
        public override bool Equals(object obj)
        {
            if (obj is Product other)
                return Id == other.Id && Name == other.Name;
            return false;
        }

        public override int GetHashCode() => (Id, Name).GetHashCode();
    }

    public class WhyOverrideEquals
    {
        public void Demo()
        {
            Product p1 = new Product { Id = 1, Name = "Book" };
            Product p2 = new Product { Id = 1, Name = "Book" };
            System.Console.WriteLine(p1.Equals(p2)); // Output: True
        }
    }
}
