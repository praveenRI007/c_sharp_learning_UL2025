// This file demonstrates the concept: Sorting a list of complex types
namespace Topics.Collections
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class SortComplexTypes
    {
        public void Demo()
        {
            var people = new List<Person>
            {
                new Person { Name = "Alice", Age = 30 },
                new Person { Name = "Bob", Age = 25 },
                new Person { Name = "Charlie", Age = 35 }
            };
            // Sort by Age using a lambda expression
            people.Sort((a, b) => a.Age.CompareTo(b.Age));
            foreach (var p in people)
            {
                System.Console.WriteLine($"{p.Name}: {p.Age}"); // Output: Bob, Alice, Charlie
            }
        }
    }
}
