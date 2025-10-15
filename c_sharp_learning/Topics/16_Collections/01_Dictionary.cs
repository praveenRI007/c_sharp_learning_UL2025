// This file demonstrates the concept: Dictionary in C#
namespace Topics.Collections
{
    public class DictionaryDemo
    {
        public void Demo()
        {
            // Dictionary stores key-value pairs
            var ages = new Dictionary<string, int>
            {
                {"Alice", 30},
                {"Bob", 25},
                {"Charlie", 35}
            };

            // Access value by key
            System.Console.WriteLine($"Alice's age: {ages["Alice"]}"); // Output: 30

            // Add new entry
            ages["David"] = 40;

            // Iterate over dictionary
            foreach (var kvp in ages)
            {
                System.Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
            }
        }
    }
}
