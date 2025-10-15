// This file demonstrates the concept: When to use a dictionary over a list
namespace Topics.Collections
{
    public class DictionaryVsList
    {
        public void Demo()
        {
            // List: good for ordered data, searching by index
            var names = new List<string> { "Alice", "Bob", "Charlie" };
            System.Console.WriteLine(names[1]); // Output: Bob

            // Dictionary: good for fast lookup by key
            var phoneBook = new Dictionary<string, string>
            {
                {"Alice", "123"},
                {"Bob", "456"},
                {"Charlie", "789"}
            };
            System.Console.WriteLine(phoneBook["Charlie"]); // Output: 789
        }
    }
}
