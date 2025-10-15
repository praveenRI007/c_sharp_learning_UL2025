// This file demonstrates the concept: Sorting a list of simple types
namespace Topics.Collections
{
    public class SortSimpleTypes
    {
        public void Demo()
        {
            var numbers = new List<int> { 5, 2, 8, 1, 3 };
            numbers.Sort(); // Sorts in ascending order
            foreach (var n in numbers)
            {
                System.Console.WriteLine(n); // Output: 1, 2, 3, 5, 8
            }
        }
    }
}
