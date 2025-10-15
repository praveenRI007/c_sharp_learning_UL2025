// This file demonstrates the concept: Dictionary in C# (continued)
namespace Topics.Collections
{
    public class DictionaryContinued
    {
        // Demonstrates iterating and updating a Dictionary
        public void Demo()
        {
            var capitals = new Dictionary<string, string>
            {
                {"France", "Paris"},
                {"Japan", "Tokyo"},
                {"India", "New Delhi"}
            };

            // Iterate over key-value pairs
            foreach (var kvp in capitals)
            {
                Console.WriteLine($"Country: {kvp.Key}, Capital: {kvp.Value}");
            }

            // Update a value
            capitals["India"] = "Delhi";
            Console.WriteLine($"Updated capital of India: {capitals["India"]}");
        }
    }
}
