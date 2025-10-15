// This file demonstrates the concept: Useful methods of List collection class
namespace Topics.Collections
{
    public class ListUsefulMethods
    {
        public void Demo()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            numbers.Reverse(); // Reverse the list
            System.Console.WriteLine(string.Join(", ", numbers)); // Output: 5, 4, 3, 2, 1
            bool containsThree = numbers.Contains(3); // Check if list contains 3
            System.Console.WriteLine($"Contains 3: {containsThree}"); // Output: True
        }
    }
}
