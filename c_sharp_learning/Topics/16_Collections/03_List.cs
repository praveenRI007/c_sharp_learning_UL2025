// This file demonstrates the concept: List collection class in C#
namespace Topics.Collections
{
    public class ListDemo
    {
        public void Demo()
        {
            // List stores ordered collection of items
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Add(6); // Add item
            numbers.Remove(2); // Remove item
            System.Console.WriteLine($"Count: {numbers.Count}"); // Output: 5
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n);
            }
        }
    }
}
