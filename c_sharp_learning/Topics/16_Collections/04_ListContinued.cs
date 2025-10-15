// This file demonstrates the concept: List collection class (continued)
namespace Topics.Collections
{
    public class ListContinued
    {
        public void Demo()
        {
            var fruits = new List<string> { "Apple", "Banana", "Cherry" };
            fruits.Insert(1, "Orange"); // Insert at index
            fruits.RemoveAt(0); // Remove at index
            System.Console.WriteLine($"First fruit: {fruits[0]}"); // Output: Orange
            foreach (var fruit in fruits)
            {
                System.Console.WriteLine(fruit);
            }
        }
    }
}
