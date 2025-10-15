// This file demonstrates the concept: Working with generic list class and ranges
namespace Topics.Collections
{
    public class ListRanges
    {
        public void Demo()
        {
            var numbers = new List<int> { 10, 20, 30, 40, 50 };

            // Get a range (subset) of the list
            var subList = numbers.GetRange(1, 3); // Gets 3 items starting at index 1

            foreach (var n in subList)
            {
                System.Console.WriteLine(n); // Output: 20, 30, 40
            }
        }
    }
}
